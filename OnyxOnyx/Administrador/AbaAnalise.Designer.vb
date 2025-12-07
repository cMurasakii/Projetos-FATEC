<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AbaAnalise
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
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AbaAnalise))
        Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        img_perfil = New PictureBox()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        PicSair = New PictureBox()
        PictureBox1 = New PictureBox()
        Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        btn_home = New PictureBox()
        Guna2CirclePictureBox2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        CType(Guna2CirclePictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(img_perfil, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicSair, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btn_home, ComponentModel.ISupportInitialize).BeginInit()
        CType(Guna2CirclePictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2CirclePictureBox1
        ' 
        Guna2CirclePictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Guna2CirclePictureBox1.BackColor = Color.Transparent
        Guna2CirclePictureBox1.BackgroundImage = My.Resources.Resources.logoonyx_removebg_preview2
        Guna2CirclePictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        Guna2CirclePictureBox1.Image = My.Resources.Resources.logoonyx_removebg_preview1
        Guna2CirclePictureBox1.ImageRotate = 0F
        Guna2CirclePictureBox1.Location = New Point(54, 25)
        Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CirclePictureBox1.Size = New Size(193, 0)
        Guna2CirclePictureBox1.TabIndex = 31
        Guna2CirclePictureBox1.TabStop = False
        ' 
        ' img_perfil
        ' 
        img_perfil.BackgroundImage = My.Resources.Resources.icone__1_
        img_perfil.BackgroundImageLayout = ImageLayout.Stretch
        img_perfil.Location = New Point(710, 35)
        img_perfil.Margin = New Padding(4, 3, 4, 3)
        img_perfil.Name = "img_perfil"
        img_perfil.Size = New Size(173, 175)
        img_perfil.SizeMode = PictureBoxSizeMode.StretchImage
        img_perfil.TabIndex = 32
        img_perfil.TabStop = False
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.Anchor = AnchorStyles.Top
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel2.ForeColor = Color.Lavender
        Guna2HtmlLabel2.Location = New Point(301, 101)
        Guna2HtmlLabel2.Margin = New Padding(5)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Padding = New Padding(10)
        Guna2HtmlLabel2.Size = New Size(279, 66)
        Guna2HtmlLabel2.TabIndex = 35
        Guna2HtmlLabel2.Text = "Seus resumos"
        Guna2HtmlLabel2.TextAlignment = ContentAlignment.TopCenter
        ' 
        ' PicSair
        ' 
        PicSair.BackColor = Color.SlateBlue
        PicSair.BackgroundImage = My.Resources.Resources.saida1
        PicSair.BackgroundImageLayout = ImageLayout.Stretch
        PicSair.BorderStyle = BorderStyle.Fixed3D
        PicSair.Location = New Point(890, 165)
        PicSair.Name = "PicSair"
        PicSair.Size = New Size(47, 45)
        PicSair.TabIndex = 40
        PicSair.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ActiveCaptionText
        PictureBox1.Location = New Point(684, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(299, 658)
        PictureBox1.TabIndex = 41
        PictureBox1.TabStop = False
        ' 
        ' Guna2GradientButton2
        ' 
        Guna2GradientButton2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Guna2GradientButton2.Animated = True
        Guna2GradientButton2.BackColor = Color.Transparent
        Guna2GradientButton2.BorderRadius = 10
        Guna2GradientButton2.CustomizableEdges = CustomizableEdges2
        Guna2GradientButton2.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientButton2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientButton2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton2.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientButton2.FillColor = Color.BlueViolet
        Guna2GradientButton2.FillColor2 = Color.CornflowerBlue
        Guna2GradientButton2.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2GradientButton2.ForeColor = Color.Black
        Guna2GradientButton2.GradientMode = Drawing2D.LinearGradientMode.ForwardDiagonal
        Guna2GradientButton2.Location = New Point(316, 275)
        Guna2GradientButton2.Name = "Guna2GradientButton2"
        Guna2GradientButton2.ShadowDecoration.BorderRadius = 10
        Guna2GradientButton2.ShadowDecoration.CustomizableEdges = CustomizableEdges3
        Guna2GradientButton2.Size = New Size(244, 76)
        Guna2GradientButton2.TabIndex = 43
        Guna2GradientButton2.Text = "Ver resumos"
        Guna2GradientButton2.UseTransparentBackground = True
        ' 
        ' Guna2GradientButton1
        ' 
        Guna2GradientButton1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Guna2GradientButton1.Animated = True
        Guna2GradientButton1.BackColor = Color.Transparent
        Guna2GradientButton1.BorderRadius = 10
        Guna2GradientButton1.CustomizableEdges = CustomizableEdges4
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
        Guna2GradientButton1.Location = New Point(316, 374)
        Guna2GradientButton1.Name = "Guna2GradientButton1"
        Guna2GradientButton1.ShadowDecoration.BorderRadius = 10
        Guna2GradientButton1.ShadowDecoration.CustomizableEdges = CustomizableEdges5
        Guna2GradientButton1.Size = New Size(244, 76)
        Guna2GradientButton1.TabIndex = 42
        Guna2GradientButton1.Text = "Criar um novo"
        Guna2GradientButton1.UseTransparentBackground = True
        ' 
        ' btn_home
        ' 
        btn_home.BackColor = Color.DarkSlateBlue
        btn_home.BackgroundImage = My.Resources.Resources.Fa_Team_Fontawesome_FontAwesome_House_Chimney_User_256
        btn_home.BackgroundImageLayout = ImageLayout.Stretch
        btn_home.BorderStyle = BorderStyle.Fixed3D
        btn_home.Location = New Point(28, 25)
        btn_home.Name = "btn_home"
        btn_home.Size = New Size(66, 63)
        btn_home.TabIndex = 66
        btn_home.TabStop = False
        ' 
        ' Guna2CirclePictureBox2
        ' 
        Guna2CirclePictureBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Guna2CirclePictureBox2.BackColor = Color.Transparent
        Guna2CirclePictureBox2.BackgroundImage = My.Resources.Resources.logoonyx_removebg_preview2
        Guna2CirclePictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        Guna2CirclePictureBox2.Image = My.Resources.Resources.logoonyx_removebg_preview1
        Guna2CirclePictureBox2.ImageRotate = 0F
        Guna2CirclePictureBox2.Location = New Point(100, 25)
        Guna2CirclePictureBox2.Name = "Guna2CirclePictureBox2"
        Guna2CirclePictureBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CirclePictureBox2.Size = New Size(193, 185)
        Guna2CirclePictureBox2.TabIndex = 67
        Guna2CirclePictureBox2.TabStop = False
        ' 
        ' AbaAnalise
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.imagemfundo
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(984, 632)
        Controls.Add(Guna2CirclePictureBox2)
        Controls.Add(btn_home)
        Controls.Add(Guna2GradientButton2)
        Controls.Add(Guna2GradientButton1)
        Controls.Add(PicSair)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(img_perfil)
        Controls.Add(Guna2CirclePictureBox1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "AbaAnalise"
        Text = "Ferramentas de Análise"
        CType(Guna2CirclePictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(img_perfil, ComponentModel.ISupportInitialize).EndInit()
        CType(PicSair, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(btn_home, ComponentModel.ISupportInitialize).EndInit()
        CType(Guna2CirclePictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents img_perfil As PictureBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PicSair As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_home As PictureBox
    Friend WithEvents Guna2CirclePictureBox2 As Guna.UI2.WinForms.Guna2CirclePictureBox
End Class
