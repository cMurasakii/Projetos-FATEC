<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCadUsuarios
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCadUsuarios))
        Label1 = New Label()
        txt_cpf = New MaskedTextBox()
        txt_nome = New TextBox()
        txt_fone = New MaskedTextBox()
        txt_email = New TextBox()
        img_perfil = New PictureBox()
        grid_data = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        PAIS = New DataGridViewTextBoxColumn()
        TEL = New DataGridViewTextBoxColumn()
        NIVEL = New DataGridViewTextBoxColumn()
        DATA = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewImageColumn()
        Column6 = New DataGridViewImageColumn()
        OpenFileDialog1 = New OpenFileDialog()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        cmb_data_ped = New DateTimePicker()
        PicSair = New PictureBox()
        cmb_pais = New ComboBox()
        Label4 = New Label()
        cmb_nivel = New ComboBox()
        Label7 = New Label()
        Label8 = New Label()
        txt_senha = New TextBox()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label9 = New Label()
        Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        btn_home = New PictureBox()
        CType(img_perfil, ComponentModel.ISupportInitialize).BeginInit()
        CType(grid_data, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicSair, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Guna2CirclePictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btn_home, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.MediumSlateBlue
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(22, 422)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 20)
        Label1.TabIndex = 0
        Label1.Text = "CPF"
        ' 
        ' txt_cpf
        ' 
        txt_cpf.BackColor = Color.Lavender
        txt_cpf.Location = New Point(22, 449)
        txt_cpf.Margin = New Padding(4, 3, 4, 3)
        txt_cpf.Mask = "999,999,999-99"
        txt_cpf.Name = "txt_cpf"
        txt_cpf.Size = New Size(297, 23)
        txt_cpf.TabIndex = 1
        ' 
        ' txt_nome
        ' 
        txt_nome.BackColor = Color.Lavender
        txt_nome.Location = New Point(22, 251)
        txt_nome.Margin = New Padding(4, 3, 4, 3)
        txt_nome.Name = "txt_nome"
        txt_nome.Size = New Size(297, 23)
        txt_nome.TabIndex = 3
        ' 
        ' txt_fone
        ' 
        txt_fone.BackColor = Color.Lavender
        txt_fone.Location = New Point(22, 516)
        txt_fone.Margin = New Padding(4, 3, 4, 3)
        txt_fone.Mask = "+99 (99) 99999-9999 "
        txt_fone.Name = "txt_fone"
        txt_fone.Size = New Size(297, 23)
        txt_fone.TabIndex = 7
        ' 
        ' txt_email
        ' 
        txt_email.BackColor = Color.Lavender
        txt_email.ForeColor = SystemColors.WindowText
        txt_email.Location = New Point(22, 318)
        txt_email.Margin = New Padding(4, 3, 4, 3)
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(297, 23)
        txt_email.TabIndex = 9
        ' 
        ' img_perfil
        ' 
        img_perfil.BackgroundImage = My.Resources.Resources.icone__1_
        img_perfil.BackgroundImageLayout = ImageLayout.Stretch
        img_perfil.Location = New Point(341, 69)
        img_perfil.Margin = New Padding(4, 3, 4, 3)
        img_perfil.Name = "img_perfil"
        img_perfil.Size = New Size(127, 128)
        img_perfil.SizeMode = PictureBoxSizeMode.StretchImage
        img_perfil.TabIndex = 10
        img_perfil.TabStop = False
        ' 
        ' grid_data
        ' 
        grid_data.AllowUserToAddRows = False
        grid_data.AllowUserToDeleteRows = False
        grid_data.BackgroundColor = Color.Indigo
        grid_data.BorderStyle = BorderStyle.None
        grid_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grid_data.Columns.AddRange(New DataGridViewColumn() {Column1, Column3, Column4, Column2, PAIS, TEL, NIVEL, DATA, Column5, Column6})
        grid_data.GridColor = SystemColors.ButtonHighlight
        grid_data.Location = New Point(532, 83)
        grid_data.Margin = New Padding(4, 3, 4, 3)
        grid_data.Name = "grid_data"
        grid_data.ReadOnly = True
        grid_data.Size = New Size(687, 463)
        grid_data.TabIndex = 11
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "ID"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 43
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "COMPRADOR"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 106
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "EMAIL"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 66
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "CPF"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 53
        ' 
        ' PAIS
        ' 
        PAIS.HeaderText = "PAIS"
        PAIS.Name = "PAIS"
        PAIS.ReadOnly = True
        PAIS.Width = 55
        ' 
        ' TEL
        ' 
        TEL.HeaderText = "TEL"
        TEL.Name = "TEL"
        TEL.ReadOnly = True
        TEL.Width = 50
        ' 
        ' NIVEL
        ' 
        NIVEL.HeaderText = "NIVEL"
        NIVEL.Name = "NIVEL"
        NIVEL.ReadOnly = True
        NIVEL.Width = 63
        ' 
        ' DATA
        ' 
        DATA.HeaderText = "DATA"
        DATA.Name = "DATA"
        DATA.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "EDITAR"
        Column5.Image = My.Resources.Resources.Colebemis_Feather_Edit_2_16
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 50
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "EXCLUIR"
        Column6.Image = My.Resources.Resources.Icons8_Windows_8_Editing_Delete_16
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 58
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.MediumSlateBlue
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(22, 224)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(133, 20)
        Label2.TabIndex = 14
        Label2.Text = "Nome completo"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.MediumSlateBlue
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(22, 291)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 20)
        Label3.TabIndex = 15
        Label3.Text = "E-mail"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.MediumSlateBlue
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(341, 361)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(132, 20)
        Label5.TabIndex = 16
        Label5.Text = "Data do pedido"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.MediumSlateBlue
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(22, 493)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 20)
        Label6.TabIndex = 17
        Label6.Text = "Telefone"
        ' 
        ' cmb_data_ped
        ' 
        cmb_data_ped.CalendarMonthBackground = Color.Lavender
        cmb_data_ped.Location = New Point(341, 388)
        cmb_data_ped.MaxDate = New Date(2025, 12, 31, 0, 0, 0, 0)
        cmb_data_ped.Name = "cmb_data_ped"
        cmb_data_ped.Size = New Size(178, 23)
        cmb_data_ped.TabIndex = 18
        ' 
        ' PicSair
        ' 
        PicSair.BackColor = Color.Lavender
        PicSair.BackgroundImage = My.Resources.Resources.saida1
        PicSair.BackgroundImageLayout = ImageLayout.Stretch
        PicSair.BorderStyle = BorderStyle.Fixed3D
        PicSair.Location = New Point(479, 159)
        PicSair.Name = "PicSair"
        PicSair.Size = New Size(35, 38)
        PicSair.TabIndex = 40
        PicSair.TabStop = False
        ' 
        ' cmb_pais
        ' 
        cmb_pais.BackColor = Color.Lavender
        cmb_pais.FormattingEnabled = True
        cmb_pais.Location = New Point(341, 251)
        cmb_pais.Name = "cmb_pais"
        cmb_pais.Size = New Size(173, 23)
        cmb_pais.TabIndex = 41
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.MediumSlateBlue
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(341, 224)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(127, 20)
        Label4.TabIndex = 42
        Label4.Text = "País de origem"
        ' 
        ' cmb_nivel
        ' 
        cmb_nivel.BackColor = Color.Lavender
        cmb_nivel.FormattingEnabled = True
        cmb_nivel.Location = New Point(341, 318)
        cmb_nivel.Name = "cmb_nivel"
        cmb_nivel.Size = New Size(173, 23)
        cmb_nivel.TabIndex = 43
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.MediumSlateBlue
        Label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(341, 291)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(136, 20)
        Label7.TabIndex = 44
        Label7.Text = "Nível de usuário"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.MediumSlateBlue
        Label8.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(22, 361)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(61, 20)
        Label8.TabIndex = 46
        Label8.Text = "Senha"
        ' 
        ' txt_senha
        ' 
        txt_senha.BackColor = Color.Lavender
        txt_senha.ForeColor = SystemColors.WindowText
        txt_senha.Location = New Point(22, 388)
        txt_senha.Margin = New Padding(4, 3, 4, 3)
        txt_senha.Name = "txt_senha"
        txt_senha.Size = New Size(297, 23)
        txt_senha.TabIndex = 45
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.Anchor = AnchorStyles.Top
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.BackgroundImage = My.Resources.Resources.Colebemis_Feather_Edit_21
        Guna2HtmlLabel2.BorderStyle = BorderStyle.FixedSingle
        Guna2HtmlLabel2.Font = New Font("Arial", 30F, FontStyle.Bold)
        Guna2HtmlLabel2.ForeColor = Color.Lavender
        Guna2HtmlLabel2.Location = New Point(531, 14)
        Guna2HtmlLabel2.Margin = New Padding(5)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Padding = New Padding(10)
        Guna2HtmlLabel2.Size = New Size(406, 70)
        Guna2HtmlLabel2.TabIndex = 47
        Guna2HtmlLabel2.Text = "Cadastro de usuário"
        Guna2HtmlLabel2.TextAlignment = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Lavender
        PictureBox1.BackgroundImage = My.Resources.Resources.icone__5__removebg_preview1
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Location = New Point(436, 477)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(66, 62)
        PictureBox1.TabIndex = 48
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Lavender
        PictureBox2.BackgroundImage = My.Resources.Resources.Icons8_Ios7_Arrows_Right_128
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.BorderStyle = BorderStyle.Fixed3D
        PictureBox2.Location = New Point(1180, 37)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(39, 37)
        PictureBox2.TabIndex = 63
        PictureBox2.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Lavender
        Label9.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(999, 37)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(174, 20)
        Label9.TabIndex = 64
        Label9.Text = "Cadastro de produto"
        ' 
        ' Guna2CirclePictureBox1
        ' 
        Guna2CirclePictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Guna2CirclePictureBox1.BackColor = Color.Transparent
        Guna2CirclePictureBox1.BackgroundImage = My.Resources.Resources.logoonyx_removebg_preview2
        Guna2CirclePictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        Guna2CirclePictureBox1.Image = My.Resources.Resources.logoonyx_removebg_preview1
        Guna2CirclePictureBox1.ImageRotate = 0F
        Guna2CirclePictureBox1.Location = New Point(75, 11)
        Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CirclePictureBox1.Size = New Size(193, 185)
        Guna2CirclePictureBox1.TabIndex = 65
        Guna2CirclePictureBox1.TabStop = False
        ' 
        ' btn_home
        ' 
        btn_home.BackColor = Color.Lavender
        btn_home.BackgroundImage = My.Resources.Resources.Fa_Team_Fontawesome_FontAwesome_House_Chimney_User_256
        btn_home.BackgroundImageLayout = ImageLayout.Stretch
        btn_home.BorderStyle = BorderStyle.Fixed3D
        btn_home.Location = New Point(22, 21)
        btn_home.Name = "btn_home"
        btn_home.Size = New Size(66, 63)
        btn_home.TabIndex = 66
        btn_home.TabStop = False
        ' 
        ' FormCadUsuarios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        BackgroundImage = My.Resources.Resources.imagemfundo
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1231, 569)
        Controls.Add(btn_home)
        Controls.Add(Guna2CirclePictureBox1)
        Controls.Add(Label9)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(Label8)
        Controls.Add(txt_senha)
        Controls.Add(Label7)
        Controls.Add(cmb_nivel)
        Controls.Add(Label4)
        Controls.Add(cmb_pais)
        Controls.Add(PicSair)
        Controls.Add(cmb_data_ped)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(grid_data)
        Controls.Add(img_perfil)
        Controls.Add(txt_email)
        Controls.Add(txt_fone)
        Controls.Add(txt_nome)
        Controls.Add(txt_cpf)
        Controls.Add(Label1)
        DoubleBuffered = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
        Name = "FormCadUsuarios"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Gerenciar clientes"
        CType(img_perfil, ComponentModel.ISupportInitialize).EndInit()
        CType(grid_data, ComponentModel.ISupportInitialize).EndInit()
        CType(PicSair, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(Guna2CirclePictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(btn_home, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_fone As MaskedTextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents img_perfil As PictureBox
    Friend WithEvents grid_data As DataGridView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_data_ped As DateTimePicker
    Friend WithEvents PicSair As PictureBox
    Friend WithEvents cmb_pais As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_nivel As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents PAIS As DataGridViewTextBoxColumn
    Friend WithEvents TEL As DataGridViewTextBoxColumn
    Friend WithEvents NIVEL As DataGridViewTextBoxColumn
    Friend WithEvents DATA As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents btn_home As PictureBox
End Class
