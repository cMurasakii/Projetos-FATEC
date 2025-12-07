<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCadProduto
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCadProduto))
        dgv_produtos = New DataGridView()
        ID_PRODUTO = New DataGridViewTextBoxColumn()
        NOME = New DataGridViewTextBoxColumn()
        CATEGORIA = New DataGridViewTextBoxColumn()
        PRECO = New DataGridViewTextBoxColumn()
        ESTOQUE = New DataGridViewTextBoxColumn()
        EDITAR = New DataGridViewImageColumn()
        EXCLUIR = New DataGridViewImageColumn()
        Label8 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        txt_nomeprod = New TextBox()
        Label1 = New Label()
        cmb_categ = New ComboBox()
        txt_estoque = New TextBox()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txt_preco = New MaskedTextBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label4 = New Label()
        Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        btn_home = New PictureBox()
        CType(dgv_produtos, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Guna2CirclePictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btn_home, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgv_produtos
        ' 
        dgv_produtos.AllowUserToAddRows = False
        dgv_produtos.AllowUserToDeleteRows = False
        dgv_produtos.BackgroundColor = Color.Indigo
        dgv_produtos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_produtos.Columns.AddRange(New DataGridViewColumn() {ID_PRODUTO, NOME, CATEGORIA, PRECO, ESTOQUE, EDITAR, EXCLUIR})
        dgv_produtos.Location = New Point(361, 118)
        dgv_produtos.Name = "dgv_produtos"
        dgv_produtos.ReadOnly = True
        dgv_produtos.Size = New Size(704, 463)
        dgv_produtos.TabIndex = 0
        ' 
        ' ID_PRODUTO
        ' 
        ID_PRODUTO.HeaderText = "ID PRODUTO"
        ID_PRODUTO.Name = "ID_PRODUTO"
        ID_PRODUTO.ReadOnly = True
        ' 
        ' NOME
        ' 
        NOME.HeaderText = "NOME"
        NOME.Name = "NOME"
        NOME.ReadOnly = True
        ' 
        ' CATEGORIA
        ' 
        CATEGORIA.HeaderText = "CATEGORIA"
        CATEGORIA.Name = "CATEGORIA"
        CATEGORIA.ReadOnly = True
        ' 
        ' PRECO
        ' 
        PRECO.HeaderText = "PREÇO"
        PRECO.Name = "PRECO"
        PRECO.ReadOnly = True
        ' 
        ' ESTOQUE
        ' 
        ESTOQUE.HeaderText = "ESTOQUE"
        ESTOQUE.Name = "ESTOQUE"
        ESTOQUE.ReadOnly = True
        ' 
        ' EDITAR
        ' 
        EDITAR.HeaderText = "EDITAR"
        EDITAR.Image = My.Resources.Resources.Colebemis_Feather_Edit_21
        EDITAR.Name = "EDITAR"
        EDITAR.ReadOnly = True
        ' 
        ' EXCLUIR
        ' 
        EXCLUIR.HeaderText = "EXCLUIR"
        EXCLUIR.Image = My.Resources.Resources.Icons8_Windows_8_Editing_Delete1
        EXCLUIR.Name = "EXCLUIR"
        EXCLUIR.ReadOnly = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.MediumSlateBlue
        Label8.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(32, 252)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(55, 20)
        Label8.TabIndex = 56
        Label8.Text = "Preço"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.MediumSlateBlue
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(32, 373)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 20)
        Label3.TabIndex = 53
        Label3.Text = "Categoria"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.MediumSlateBlue
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(32, 190)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(147, 20)
        Label2.TabIndex = 52
        Label2.Text = "Nome do produto"
        ' 
        ' txt_nomeprod
        ' 
        txt_nomeprod.BackColor = Color.Lavender
        txt_nomeprod.Location = New Point(32, 217)
        txt_nomeprod.Margin = New Padding(4, 3, 4, 3)
        txt_nomeprod.Name = "txt_nomeprod"
        txt_nomeprod.Size = New Size(297, 23)
        txt_nomeprod.TabIndex = 49
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.MediumSlateBlue
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(32, 311)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 20)
        Label1.TabIndex = 47
        Label1.Text = "Estoque"
        ' 
        ' cmb_categ
        ' 
        cmb_categ.BackColor = Color.Lavender
        cmb_categ.FormattingEnabled = True
        cmb_categ.Location = New Point(32, 396)
        cmb_categ.Name = "cmb_categ"
        cmb_categ.Size = New Size(223, 23)
        cmb_categ.TabIndex = 57
        ' 
        ' txt_estoque
        ' 
        txt_estoque.BackColor = Color.Lavender
        txt_estoque.ForeColor = SystemColors.WindowText
        txt_estoque.Location = New Point(32, 334)
        txt_estoque.Margin = New Padding(4, 3, 4, 3)
        txt_estoque.Name = "txt_estoque"
        txt_estoque.Size = New Size(297, 23)
        txt_estoque.TabIndex = 58
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.Anchor = AnchorStyles.Top
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.BackgroundImage = My.Resources.Resources.Colebemis_Feather_Edit_22
        Guna2HtmlLabel2.BorderStyle = BorderStyle.FixedSingle
        Guna2HtmlLabel2.Font = New Font("Arial", 27F, FontStyle.Bold)
        Guna2HtmlLabel2.ForeColor = Color.Lavender
        Guna2HtmlLabel2.Location = New Point(361, 43)
        Guna2HtmlLabel2.Margin = New Padding(5)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Padding = New Padding(10)
        Guna2HtmlLabel2.Size = New Size(379, 67)
        Guna2HtmlLabel2.TabIndex = 59
        Guna2HtmlLabel2.Text = "Cadastro de produto"
        Guna2HtmlLabel2.TextAlignment = ContentAlignment.MiddleCenter
        ' 
        ' txt_preco
        ' 
        txt_preco.BackColor = Color.Lavender
        txt_preco.Location = New Point(32, 275)
        txt_preco.Margin = New Padding(4, 3, 4, 3)
        txt_preco.Name = "txt_preco"
        txt_preco.Size = New Size(297, 23)
        txt_preco.TabIndex = 60
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Lavender
        PictureBox1.BackgroundImage = My.Resources.Resources.icone__5__removebg_preview1
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Location = New Point(263, 396)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(66, 62)
        PictureBox1.TabIndex = 61
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Lavender
        PictureBox2.BackgroundImage = My.Resources.Resources.Icons8_Ios7_Arrows_Right1
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.BorderStyle = BorderStyle.Fixed3D
        PictureBox2.Location = New Point(1009, 72)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(39, 37)
        PictureBox2.TabIndex = 62
        PictureBox2.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Lavender
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(831, 72)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(171, 20)
        Label4.TabIndex = 63
        Label4.Text = "Cadastro de usuário"
        ' 
        ' Guna2CirclePictureBox1
        ' 
        Guna2CirclePictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Guna2CirclePictureBox1.BackColor = Color.Transparent
        Guna2CirclePictureBox1.BackgroundImage = My.Resources.Resources.logoonyx_removebg_preview2
        Guna2CirclePictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        Guna2CirclePictureBox1.Image = My.Resources.Resources.logoonyx_removebg_preview1
        Guna2CirclePictureBox1.ImageRotate = 0F
        Guna2CirclePictureBox1.Location = New Point(93, 2)
        Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CirclePictureBox1.Size = New Size(193, 185)
        Guna2CirclePictureBox1.TabIndex = 64
        Guna2CirclePictureBox1.TabStop = False
        ' 
        ' btn_home
        ' 
        btn_home.BackColor = Color.Lavender
        btn_home.BackgroundImage = My.Resources.Resources.Fa_Team_Fontawesome_FontAwesome_House_Chimney_User_256
        btn_home.BackgroundImageLayout = ImageLayout.Stretch
        btn_home.BorderStyle = BorderStyle.Fixed3D
        btn_home.Location = New Point(21, 12)
        btn_home.Name = "btn_home"
        btn_home.Size = New Size(66, 63)
        btn_home.TabIndex = 65
        btn_home.TabStop = False
        ' 
        ' FormCadProduto
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.imagemfundo
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1077, 603)
        Controls.Add(btn_home)
        Controls.Add(Guna2CirclePictureBox1)
        Controls.Add(Label4)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(txt_preco)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(txt_estoque)
        Controls.Add(cmb_categ)
        Controls.Add(Label8)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txt_nomeprod)
        Controls.Add(Label1)
        Controls.Add(dgv_produtos)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FormCadProduto"
        Text = "Cadastro de produto"
        CType(dgv_produtos, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(Guna2CirclePictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(btn_home, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgv_produtos As DataGridView
    Friend WithEvents ID_PRODUTO As DataGridViewTextBoxColumn
    Friend WithEvents NOME As DataGridViewTextBoxColumn
    Friend WithEvents CATEGORIA As DataGridViewTextBoxColumn
    Friend WithEvents PRECO As DataGridViewTextBoxColumn
    Friend WithEvents ESTOQUE As DataGridViewTextBoxColumn
    Friend WithEvents EDITAR As DataGridViewImageColumn
    Friend WithEvents EXCLUIR As DataGridViewImageColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nomeprod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_categ As ComboBox
    Friend WithEvents txt_estoque As TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txt_preco As MaskedTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents btn_home As PictureBox
End Class
