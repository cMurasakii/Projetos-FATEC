<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidoCliente
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PedidoCliente))
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txt_senha = New TextBox()
        txt_fone = New MaskedTextBox()
        txt_nome = New TextBox()
        txt_cpf = New MaskedTextBox()
        Label6 = New Label()
        Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        PicSair = New PictureBox()
        img_perfil = New PictureBox()
        btn_home = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        cmbEntrega = New Guna.UI2.WinForms.Guna2ComboBox()
        cmb_produto = New Guna.UI2.WinForms.Guna2ComboBox()
        Label5 = New Label()
        cmb_qtd = New Guna.UI2.WinForms.Guna2ComboBox()
        Label7 = New Label()
        CType(PicSair, ComponentModel.ISupportInitialize).BeginInit()
        CType(img_perfil, ComponentModel.ISupportInitialize).BeginInit()
        CType(btn_home, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.MediumSlateBlue
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(141, 226)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(133, 20)
        Label2.TabIndex = 15
        Label2.Text = "Nome completo"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.MediumSlateBlue
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(141, 293)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 20)
        Label1.TabIndex = 16
        Label1.Text = "Senha"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.MediumSlateBlue
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(141, 360)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 20)
        Label3.TabIndex = 17
        Label3.Text = "Telefone"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.MediumSlateBlue
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(562, 226)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 20)
        Label4.TabIndex = 18
        Label4.Text = "CPF"
        ' 
        ' txt_senha
        ' 
        txt_senha.BackColor = Color.Lavender
        txt_senha.ForeColor = SystemColors.ControlText
        txt_senha.Location = New Point(141, 316)
        txt_senha.Margin = New Padding(4, 3, 4, 3)
        txt_senha.Name = "txt_senha"
        txt_senha.PasswordChar = "*"c
        txt_senha.Size = New Size(330, 23)
        txt_senha.TabIndex = 24
        ' 
        ' txt_fone
        ' 
        txt_fone.BackColor = Color.Lavender
        txt_fone.Location = New Point(141, 383)
        txt_fone.Margin = New Padding(4, 3, 4, 3)
        txt_fone.Mask = "+99 (99) 99999-9999 "
        txt_fone.Name = "txt_fone"
        txt_fone.Size = New Size(330, 23)
        txt_fone.TabIndex = 23
        ' 
        ' txt_nome
        ' 
        txt_nome.BackColor = Color.Lavender
        txt_nome.Location = New Point(141, 249)
        txt_nome.Margin = New Padding(4, 3, 4, 3)
        txt_nome.Name = "txt_nome"
        txt_nome.Size = New Size(330, 23)
        txt_nome.TabIndex = 21
        ' 
        ' txt_cpf
        ' 
        txt_cpf.BackColor = Color.Lavender
        txt_cpf.Location = New Point(562, 249)
        txt_cpf.Margin = New Padding(4, 3, 4, 3)
        txt_cpf.Mask = "999,999,999-99"
        txt_cpf.Name = "txt_cpf"
        txt_cpf.Size = New Size(330, 23)
        txt_cpf.TabIndex = 20
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.MediumSlateBlue
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(562, 291)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(140, 20)
        Label6.TabIndex = 25
        Label6.Text = "Data de entrega"
        ' 
        ' Guna2GradientButton1
        ' 
        Guna2GradientButton1.Animated = True
        Guna2GradientButton1.BackColor = Color.Transparent
        Guna2GradientButton1.BorderRadius = 10
        Guna2GradientButton1.CustomizableEdges = CustomizableEdges1
        Guna2GradientButton1.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientButton1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientButton1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton1.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientButton1.FillColor = Color.BlueViolet
        Guna2GradientButton1.FillColor2 = Color.CornflowerBlue
        Guna2GradientButton1.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2GradientButton1.ForeColor = Color.Black
        Guna2GradientButton1.GradientMode = Drawing2D.LinearGradientMode.ForwardDiagonal
        Guna2GradientButton1.Location = New Point(660, 449)
        Guna2GradientButton1.Name = "Guna2GradientButton1"
        Guna2GradientButton1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2GradientButton1.Size = New Size(227, 60)
        Guna2GradientButton1.TabIndex = 27
        Guna2GradientButton1.Text = "Iniciar pedido"
        Guna2GradientButton1.UseTransparentBackground = True
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.Anchor = AnchorStyles.Top
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Arial", 30F, FontStyle.Bold)
        Guna2HtmlLabel2.ForeColor = Color.Lavender
        Guna2HtmlLabel2.Location = New Point(136, 124)
        Guna2HtmlLabel2.Margin = New Padding(5)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Padding = New Padding(10)
        Guna2HtmlLabel2.Size = New Size(316, 68)
        Guna2HtmlLabel2.TabIndex = 28
        Guna2HtmlLabel2.Text = "Realizar pedido"
        Guna2HtmlLabel2.TextAlignment = ContentAlignment.TopCenter
        ' 
        ' PicSair
        ' 
        PicSair.BackColor = Color.Lavender
        PicSair.BackgroundImage = My.Resources.Resources.saida1
        PicSair.BackgroundImageLayout = ImageLayout.Stretch
        PicSair.BorderStyle = BorderStyle.Fixed3D
        PicSair.Location = New Point(894, 157)
        PicSair.Name = "PicSair"
        PicSair.Size = New Size(47, 45)
        PicSair.TabIndex = 38
        PicSair.TabStop = False
        ' 
        ' img_perfil
        ' 
        img_perfil.BackgroundImage = My.Resources.Resources.icone__1_
        img_perfil.BackgroundImageLayout = ImageLayout.Stretch
        img_perfil.Location = New Point(714, 27)
        img_perfil.Margin = New Padding(4, 3, 4, 3)
        img_perfil.Name = "img_perfil"
        img_perfil.Size = New Size(173, 175)
        img_perfil.SizeMode = PictureBoxSizeMode.StretchImage
        img_perfil.TabIndex = 37
        img_perfil.TabStop = False
        ' 
        ' btn_home
        ' 
        btn_home.BackColor = Color.Lavender
        btn_home.BackgroundImage = My.Resources.Resources.Fa_Team_Fontawesome_FontAwesome_House_Chimney_User_256
        btn_home.BackgroundImageLayout = ImageLayout.Stretch
        btn_home.BorderStyle = BorderStyle.Fixed3D
        btn_home.Location = New Point(28, 27)
        btn_home.Name = "btn_home"
        btn_home.Size = New Size(66, 63)
        btn_home.TabIndex = 67
        btn_home.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' cmbEntrega
        ' 
        cmbEntrega.BackColor = Color.Transparent
        cmbEntrega.BorderRadius = 10
        cmbEntrega.CustomizableEdges = CustomizableEdges3
        cmbEntrega.DrawMode = DrawMode.OwnerDrawFixed
        cmbEntrega.DropDownStyle = ComboBoxStyle.DropDownList
        cmbEntrega.FillColor = Color.Lavender
        cmbEntrega.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmbEntrega.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmbEntrega.Font = New Font("Segoe UI", 10F)
        cmbEntrega.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cmbEntrega.ItemHeight = 30
        cmbEntrega.Location = New Point(562, 316)
        cmbEntrega.Name = "cmbEntrega"
        cmbEntrega.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        cmbEntrega.Size = New Size(330, 36)
        cmbEntrega.TabIndex = 68
        ' 
        ' cmb_produto
        ' 
        cmb_produto.BackColor = Color.Transparent
        cmb_produto.BorderRadius = 10
        cmb_produto.CustomizableEdges = CustomizableEdges5
        cmb_produto.DrawMode = DrawMode.OwnerDrawFixed
        cmb_produto.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_produto.FillColor = Color.Lavender
        cmb_produto.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmb_produto.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmb_produto.Font = New Font("Segoe UI", 10F)
        cmb_produto.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cmb_produto.ItemHeight = 30
        cmb_produto.Location = New Point(562, 383)
        cmb_produto.Name = "cmb_produto"
        cmb_produto.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        cmb_produto.Size = New Size(250, 36)
        cmb_produto.TabIndex = 69
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.MediumSlateBlue
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(562, 360)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 20)
        Label5.TabIndex = 70
        Label5.Text = "Pruduto"
        ' 
        ' cmb_qtd
        ' 
        cmb_qtd.BackColor = Color.Transparent
        cmb_qtd.BorderRadius = 10
        cmb_qtd.CustomizableEdges = CustomizableEdges7
        cmb_qtd.DrawMode = DrawMode.OwnerDrawFixed
        cmb_qtd.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_qtd.FillColor = Color.Lavender
        cmb_qtd.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmb_qtd.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmb_qtd.Font = New Font("Segoe UI", 10F)
        cmb_qtd.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cmb_qtd.ItemHeight = 30
        cmb_qtd.Location = New Point(818, 383)
        cmb_qtd.Name = "cmb_qtd"
        cmb_qtd.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        cmb_qtd.Size = New Size(69, 36)
        cmb_qtd.TabIndex = 71
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.MediumSlateBlue
        Label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(818, 360)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(63, 20)
        Label7.TabIndex = 72
        Label7.Text = "Quant."
        ' 
        ' PedidoCliente
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.imagemfundo
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(984, 561)
        Controls.Add(Label7)
        Controls.Add(cmb_qtd)
        Controls.Add(Label5)
        Controls.Add(cmb_produto)
        Controls.Add(cmbEntrega)
        Controls.Add(btn_home)
        Controls.Add(PicSair)
        Controls.Add(img_perfil)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(Guna2GradientButton1)
        Controls.Add(Label6)
        Controls.Add(txt_senha)
        Controls.Add(txt_fone)
        Controls.Add(txt_nome)
        Controls.Add(txt_cpf)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "PedidoCliente"
        Text = "Solicitar pedido"
        CType(PicSair, ComponentModel.ISupportInitialize).EndInit()
        CType(img_perfil, ComponentModel.ISupportInitialize).EndInit()
        CType(btn_home, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_fone As MaskedTextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PicSair As PictureBox
    Friend WithEvents img_perfil As PictureBox
    Friend WithEvents btn_home As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents cmbEntrega As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmb_produto As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_qtd As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label7 As Label
End Class
