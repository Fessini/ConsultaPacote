Imports System.IO
Imports System.Text

Public Class frmPrincipal
    Dim dtRastreio, dtConfig As New DataTable
    Dim id As Integer
    Dim result As New StringBuilder
    Dim carregado As Boolean = False
    Dim temp As New Threading.Thread(AddressOf Atualiza)

    Private Sub Atualiza()
        Dim obj As New Pacote
        Dim Pesq() = dtRastreio.Select("Recebido = 'N'")

        For Each Linha As DataRow In Pesq
            Dim pac = obj.ObterPacote(Linha.Item("Codigo"))
            result.Clear()
            For Each objetos As Objeto In pac.objetos
                If objetos.eventos IsNot Nothing Then
                    For Each eventos As Evento In objetos.eventos
                        If Not IsDBNull(Linha.Item("Qtd")) Then
                            If Linha.Item("Qtd") < objetos.eventos.Count Then
                                Linha.Item("Qtd") = objetos.eventos.Count
                                Dim uni = eventos.unidade
                                Dim uniDest = eventos.unidadeDestino

                                result.Append("Descrição: " & eventos.descricao & vbNewLine)
                                result.Append("Unidade: " & uni.nome & vbNewLine)
                                If uniDest IsNot Nothing Then result.Append("Unidade Destino: " & uniDest.nome & vbNewLine)

                                notifica.ShowBalloonTip(5000, Linha.Item("Nome"), result.ToString, ToolTipIcon.Info)
                                If eventos.descricao = "Objeto entregue ao destinatário" Then
                                    Linha.Item("Recebido") = "S"
                                    dtRastreio.AcceptChanges()
                                End If

                            End If
                        Else
                            Linha.Item("Qtd") = objetos.eventos.Count
                            Dim uni = eventos.unidade
                            Dim uniDest = eventos.unidadeDestino

                            result.Append("Descrição: " & eventos.descricao & vbNewLine)
                            result.Append("Unidade: " & uni.nome & vbNewLine)
                            If uniDest IsNot Nothing Then result.Append("Unidade Destino: " & uniDest.nome & vbNewLine)

                            notifica.ShowBalloonTip(5000, Linha.Item("Nome"), result.ToString, ToolTipIcon.Info)
                            If eventos.descricao = "Objeto entregue ao destinatário" Then
                                Linha.Item("Recebido") = "S"
                                dtRastreio.AcceptChanges()
                            End If
                            dtRastreio.AcceptChanges()
                        End If
                    Next
                End If
            Next
        Next
        dtRastreio.WriteXml(Application.StartupPath & "\pacotes.xml")
    End Sub
    Private Sub Consultar()
        Dim obj As New Pacote
        Dim codigo As String
        Try
            result.Clear()

            If lstRastreio.SelectedItems.Count = 0 Then
                Exit Sub
            End If

            For Each encontrado As DataRowView In lstRastreio.SelectedItems
                codigo = encontrado.Item(0)
            Next


            Dim Pesq() As DataRow = dtRastreio.Select("Id = " & codigo)
            Dim pac = obj.ObterPacote(Pesq(0).Item("Codigo"))

            result.Append("Nome do Objeto: " & Pesq(0).Item("Nome") & vbNewLine)


            For Each objetos As Objeto In pac.objetos
                result.Append("Código do Objeto: " & objetos.codObjeto & vbNewLine)
                If objetos.eventos IsNot Nothing Then
                    For Each eventos As Evento In objetos.eventos
                        Dim uni = eventos.unidade
                        Dim uniDest = eventos.unidadeDestino

                        result.Append("Data: " & eventos.dtHrCriado & vbNewLine)
                        result.Append("Descrição: " & eventos.descricao & vbNewLine)
                        result.Append("Detalhes: " & eventos.detalhe & vbNewLine)
                        result.Append("Unidade: " & uni.nome & vbNewLine)
                        If uniDest IsNot Nothing Then result.Append("Unidade Destino: " & uniDest.nome & vbNewLine)
                        result.Append("==================================================================" & vbNewLine)
                    Next
                End If
            Next

            txtResultado.Text = result.ToString
        Catch ex As Exception
            MessageBox.Show("Erro:" & vbNewLine & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub AtualizaLista()
        lstRastreio.DataSource = Nothing
        lstRastreio.DataSource = dtRastreio
        lstRastreio.DisplayMember = "Nome"
        lstRastreio.ValueMember = "Id"
        dtRastreio.WriteXml(Application.StartupPath & "\pacotes.xml")
        id = lstRastreio.Items.Count
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        'CONFIGURA TABELA DE RASTREIO
        dtRastreio.TableName = "Rastreio"
        dtRastreio.Columns.Add("Id", GetType(Integer))
        dtRastreio.Columns.Add("Codigo", GetType(String))
        dtRastreio.Columns.Add("Nome", GetType(String))
        dtRastreio.Columns.Add("Qtd", GetType(Integer))
        dtRastreio.Columns.Add("Recebido", GetType(Char))
        If File.Exists(Application.StartupPath & "\pacotes.xml") = True Then
            dtRastreio.ReadXml(Application.StartupPath & "\pacotes.xml")
            AtualizaLista()
        End If
        '
        'CONFIGURA TABELA DE CONFIG
        dtConfig.TableName = "Config"
        dtConfig.Columns.Add("Tempo", GetType(Integer))
        If File.Exists(Application.StartupPath & "\config.xml") = True Then
            dtConfig.ReadXml(Application.StartupPath & "\config.xml")
            tmConsulta.Interval = dtConfig.Rows(0).Item("Tempo")
        Else
            Dim Nova As DataRow = dtConfig.NewRow
            Nova.Item("Tempo") = 60000
            dtConfig.Rows.Add(Nova)
            dtConfig.AcceptChanges()
            dtConfig.WriteXml(Application.StartupPath & "\config.xml")
            tmConsulta.Interval = 60000
        End If

        txtNome.Focus()
        tmConsulta.Enabled = True
        temp.IsBackground = True
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        Dim blnValida As Boolean = True

        Try

            If txtCodigoRastreio.TextLength = 0 Then
                epValida.SetError(txtCodigoRastreio, "Favor informar o código de rastreio.")
                blnValida = False
            End If
            If txtNome.TextLength = 0 Then
                epValida.SetError(txtNome, "Favor informar o nome.")
                blnValida = False
            End If
            If blnValida = False Then Exit Sub
            btnAdicionar.Enabled = False
            '
            Do While temp.IsAlive = True
                lblConsulta.Visible = True
            Loop

            lblConsulta.Visible = False
            id += 1
            Dim Nova As DataRow = dtRastreio.NewRow
            Nova.Item("Nome") = txtNome.Text
            Nova.Item("Codigo") = txtCodigoRastreio.Text
            Nova.Item("Id") = id
            Nova.Item("Recebido") = "N"
            dtRastreio.Rows.Add(Nova)
            dtRastreio.AcceptChanges()
            AtualizaLista()
            btnAdicionar.Enabled = True
            txtCodigoRastreio.Clear()
            txtNome.Clear()
            txtNome.Focus()
        Catch ex As Exception
            MessageBox.Show("Erro:" & vbNewLine & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bntConsultar_Click(sender As Object, e As EventArgs) Handles bntConsultar.Click
        Consultar()
    End Sub

    Private Sub frmPrincipal_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        carregado = True
    End Sub

    Private Sub lstRastreio_Click(sender As Object, e As EventArgs) Handles lstRastreio.Click

    End Sub

    Private Sub btnApagar_Click(sender As Object, e As EventArgs) Handles btnApagar.Click
        Dim codigo As String

        Try
            If lstRastreio.Items.Count > 0 Then
                For Each encontrado As DataRowView In lstRastreio.SelectedItems
                    codigo = encontrado.Item(0)
                Next

                Dim Pesq() As DataRow = dtRastreio.Select("Id = " & codigo)
                dtRastreio.Rows.Remove(Pesq(0))
                dtRastreio.AcceptChanges()

                AtualizaLista()
            End If
        Catch ex As Exception
            MessageBox.Show("Erro:" & vbNewLine & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLimparTudo_Click(sender As Object, e As EventArgs) Handles btnLimparTudo.Click
        If MessageBox.Show("Você tem certeza que deseja apagar todos os rastreios?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            dtRastreio.Rows.Clear()
            AtualizaLista()
        End If
    End Sub

    Private Sub tmConsulta_Tick(sender As Object, e As EventArgs) Handles tmConsulta.Tick
        If temp.IsAlive = False Then
            temp = New Threading.Thread(AddressOf Atualiza)
            temp.IsBackground = True
            temp.Start()
        End If
    End Sub

    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        Using frm As New frmConfig
            frm.Minutos = dtConfig.Rows(0).Item("Tempo") / 60000
            frm.ShowDialog()
            If frm.Cancelado = False Then
                tmConsulta.Interval = frm.Minutos * 60000
                dtConfig.Rows(0).Item("Tempo") = frm.Minutos * 60000
                dtConfig.WriteXml(Application.StartupPath & "\config.xml")
            End If
        End Using
    End Sub

    Private Sub mnuAbrir_Click(sender As Object, e As EventArgs) Handles mnuAbrir.Click
        If Me.Visible = False Then
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal

        End If
    End Sub

    Private Sub frmPrincipal_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If FormWindowState.Minimized = Me.WindowState Then
            Me.Visible = False
        End If
    End Sub

    Private Sub btnSobre_Click(sender As Object, e As EventArgs) Handles btnSobre.Click
        Using frm As New frmSobre
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub lstRastreio_DoubleClick(sender As Object, e As EventArgs) Handles lstRastreio.DoubleClick
        If carregado = True Then
            Consultar()
        End If
    End Sub
End Class
