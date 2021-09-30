<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.bntConsultar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblConsulta = New System.Windows.Forms.Label()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.txtCodigoRastreio = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnLimparTudo = New System.Windows.Forms.Button()
        Me.btnApagar = New System.Windows.Forms.Button()
        Me.lstRastreio = New System.Windows.Forms.ListBox()
        Me.epValida = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnConfig = New System.Windows.Forms.Button()
        Me.notifica = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cmMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuAbrir = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmConsulta = New System.Windows.Forms.Timer(Me.components)
        Me.ttpDica = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSobre = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.epValida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.cmMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'bntConsultar
        '
        Me.bntConsultar.Location = New System.Drawing.Point(93, 224)
        Me.bntConsultar.Name = "bntConsultar"
        Me.bntConsultar.Size = New System.Drawing.Size(75, 23)
        Me.bntConsultar.TabIndex = 1
        Me.bntConsultar.Text = "Consultar"
        Me.ttpDica.SetToolTip(Me.bntConsultar, "Consulta rastreio selecionado.")
        Me.bntConsultar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblConsulta)
        Me.GroupBox1.Controls.Add(Me.btnAdicionar)
        Me.GroupBox1.Controls.Add(Me.txtCodigoRastreio)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 104)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Novo Rastreio"
        '
        'lblConsulta
        '
        Me.lblConsulta.AutoSize = True
        Me.lblConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsulta.Location = New System.Drawing.Point(40, 76)
        Me.lblConsulta.Name = "lblConsulta"
        Me.lblConsulta.Size = New System.Drawing.Size(204, 13)
        Me.lblConsulta.TabIndex = 4
        Me.lblConsulta.Text = "Consulta em andamento aguarde..."
        Me.lblConsulta.Visible = False
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Location = New System.Drawing.Point(250, 71)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(75, 23)
        Me.btnAdicionar.TabIndex = 5
        Me.btnAdicionar.Text = "Adicionar"
        Me.ttpDica.SetToolTip(Me.btnAdicionar, "Adiciona novo código de rastreamento.")
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'txtCodigoRastreio
        '
        Me.txtCodigoRastreio.Location = New System.Drawing.Point(98, 45)
        Me.txtCodigoRastreio.Name = "txtCodigoRastreio"
        Me.txtCodigoRastreio.Size = New System.Drawing.Size(227, 20)
        Me.txtCodigoRastreio.TabIndex = 3
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(98, 19)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(227, 20)
        Me.txtNome.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Código Rastreio:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnLimparTudo)
        Me.GroupBox2.Controls.Add(Me.btnApagar)
        Me.GroupBox2.Controls.Add(Me.lstRastreio)
        Me.GroupBox2.Controls.Add(Me.bntConsultar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 122)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(336, 257)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rastreios"
        '
        'btnLimparTudo
        '
        Me.btnLimparTudo.Location = New System.Drawing.Point(174, 224)
        Me.btnLimparTudo.Name = "btnLimparTudo"
        Me.btnLimparTudo.Size = New System.Drawing.Size(75, 23)
        Me.btnLimparTudo.TabIndex = 2
        Me.btnLimparTudo.Text = "Limpar Tudo"
        Me.ttpDica.SetToolTip(Me.btnLimparTudo, "Limpa todos os códigos de rastreio.")
        Me.btnLimparTudo.UseVisualStyleBackColor = True
        '
        'btnApagar
        '
        Me.btnApagar.Location = New System.Drawing.Point(255, 224)
        Me.btnApagar.Name = "btnApagar"
        Me.btnApagar.Size = New System.Drawing.Size(75, 23)
        Me.btnApagar.TabIndex = 3
        Me.btnApagar.Text = "Apagar"
        Me.ttpDica.SetToolTip(Me.btnApagar, "Apaga rastreio selecionado.")
        Me.btnApagar.UseVisualStyleBackColor = True
        '
        'lstRastreio
        '
        Me.lstRastreio.FormattingEnabled = True
        Me.lstRastreio.Location = New System.Drawing.Point(6, 19)
        Me.lstRastreio.Name = "lstRastreio"
        Me.lstRastreio.Size = New System.Drawing.Size(324, 199)
        Me.lstRastreio.TabIndex = 0
        Me.ttpDica.SetToolTip(Me.lstRastreio, "Duplo clique para consultar.")
        '
        'epValida
        '
        Me.epValida.ContainerControl = Me
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(6, 19)
        Me.txtResultado.Multiline = True
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResultado.Size = New System.Drawing.Size(422, 309)
        Me.txtResultado.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtResultado)
        Me.GroupBox3.Location = New System.Drawing.Point(354, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(434, 339)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resultado"
        '
        'btnConfig
        '
        Me.btnConfig.Location = New System.Drawing.Point(632, 357)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(75, 23)
        Me.btnConfig.TabIndex = 2
        Me.btnConfig.Text = "Configurar"
        Me.ttpDica.SetToolTip(Me.btnConfig, "Configura tempo de verificação.")
        Me.btnConfig.UseVisualStyleBackColor = True
        '
        'notifica
        '
        Me.notifica.ContextMenuStrip = Me.cmMenu
        Me.notifica.Icon = CType(resources.GetObject("notifica.Icon"), System.Drawing.Icon)
        Me.notifica.Text = "Consulta Pacote"
        Me.notifica.Visible = True
        '
        'cmMenu
        '
        Me.cmMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbrir})
        Me.cmMenu.Name = "cmMenu"
        Me.cmMenu.Size = New System.Drawing.Size(101, 26)
        '
        'mnuAbrir
        '
        Me.mnuAbrir.Name = "mnuAbrir"
        Me.mnuAbrir.Size = New System.Drawing.Size(100, 22)
        Me.mnuAbrir.Text = "Abrir"
        '
        'tmConsulta
        '
        '
        'btnSobre
        '
        Me.btnSobre.Location = New System.Drawing.Point(713, 357)
        Me.btnSobre.Name = "btnSobre"
        Me.btnSobre.Size = New System.Drawing.Size(75, 23)
        Me.btnSobre.TabIndex = 3
        Me.btnSobre.Text = "Sobre"
        Me.ttpDica.SetToolTip(Me.btnSobre, "Informações sobre o desenvolvedor.")
        Me.btnSobre.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 392)
        Me.Controls.Add(Me.btnSobre)
        Me.Controls.Add(Me.btnConfig)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Pacote"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.epValida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.cmMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bntConsultar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents txtCodigoRastreio As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnLimparTudo As Button
    Friend WithEvents btnApagar As Button
    Friend WithEvents lstRastreio As ListBox
    Friend WithEvents epValida As ErrorProvider
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents btnConfig As Button
    Friend WithEvents notifica As NotifyIcon
    Friend WithEvents tmConsulta As Timer
    Friend WithEvents lblConsulta As Label
    Friend WithEvents cmMenu As ContextMenuStrip
    Friend WithEvents mnuAbrir As ToolStripMenuItem
    Friend WithEvents ttpDica As ToolTip
    Friend WithEvents btnSobre As Button
End Class
