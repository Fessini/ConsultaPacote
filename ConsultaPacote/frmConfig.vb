
Public Class frmConfig
    Public Property Minutos As Integer
    Private blnCancelado As Boolean = True
    Public ReadOnly Property Cancelado As Boolean
        Get
            Return blnCancelado
        End Get
    End Property
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtMinutos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMinutos.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSurrogate(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If txtMinutos.TextLength = 0 Then
            MessageBox.Show("Favor informar um tempo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If IsNumeric(txtMinutos.Text) = False Then
                MessageBox.Show("Formato de número inválido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Minutos = Convert.ToInt32(txtMinutos.Text)
                If Minutos > 60 Then
                    MessageBox.Show("Minutos máximo é 60.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    blnCancelado = False
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub frmConfig_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtMinutos.Text = Minutos
    End Sub
End Class