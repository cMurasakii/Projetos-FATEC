<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CriarResumo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CriarResumo))
        img_perfil = New PictureBox()
        Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Guna2GradientButton3 = New Guna.UI2.WinForms.Guna2GradientButton()
        Guna2CheckBox1 = New Guna.UI2.WinForms.Guna2CheckBox()
        Guna2CheckBox2 = New Guna.UI2.WinForms.Guna2CheckBox()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        PicSair = New PictureBox()
        PictureBox1 = New PictureBox()
        CType(img_perfil, ComponentModel.ISupportInitialize).BeginInit()
        CType(Guna2CirclePictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicSair, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' img_perfil
        ' 
        img_perfil.BackgroundImage = My.Resources.Resources.icone__1_
        img_perfil.BackgroundImageLayout = ImageLayout.Stretch
        img_perfil.Location = New Point(726, 22)
        img_perfil.Margin = New Padding(4, 3, 4, 3)
        img_perfil.Name = "img_perfil"
        img_perfil.Size = New Size(173, 175)
        img_perfil.SizeMode = PictureBoxSizeMode.StretchImage
        img_perfil.TabIndex = 11
        img_perfil.TabStop = False
        ' 
        ' Guna2CirclePictureBox1
        ' 
        Guna2CirclePictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Guna2CirclePictureBox1.BackColor = Color.Transparent
        Guna2CirclePictureBox1.BackgroundImage = My.Resources.Resources.logoonyx_removebg_preview2
        Guna2CirclePictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        Guna2CirclePictureBox1.Image = My.Resources.Resources.logoonyx_removebg_preview1
        Guna2CirclePictureBox1.ImageRotate = 0F
        Guna2CirclePictureBox1.Location = New Point(39, 12)
        Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CirclePictureBox1.Size = New Size(193, 185)
        Guna2CirclePictureBox1.TabIndex = 32
        Guna2CirclePictureBox1.TabStop = False
        ' 
        ' Guna2GradientButton1
        ' 
        Guna2GradientButton1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Guna2GradientButton1.Animated = True
        Guna2GradientButton1.BackColor = Color.Transparent
        Guna2GradientButton1.BorderRadius = 10
        Guna2GradientButton1.CustomizableEdges = CustomizableEdges2
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
        Guna2GradientButton1.Location = New Point(282, 235)
        Guna2GradientButton1.Name = "Guna2GradientButton1"
        Guna2GradientButton1.ShadowDecoration.BorderRadius = 10
        Guna2GradientButton1.ShadowDecoration.CustomizableEdges = CustomizableEdges3
        Guna2GradientButton1.Size = New Size(244, 76)
        Guna2GradientButton1.TabIndex = 33
        Guna2GradientButton1.Text = "Criar resumo"
        Guna2GradientButton1.UseTransparentBackground = True
        ' 
        ' Guna2GradientButton2
        ' 
        Guna2GradientButton2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Guna2GradientButton2.Animated = True
        Guna2GradientButton2.BackColor = Color.Transparent
        Guna2GradientButton2.BorderRadius = 10
        Guna2GradientButton2.CustomizableEdges = CustomizableEdges4
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
        Guna2GradientButton2.Location = New Point(311, 391)
        Guna2GradientButton2.Name = "Guna2GradientButton2"
        Guna2GradientButton2.ShadowDecoration.BorderRadius = 10
        Guna2GradientButton2.ShadowDecoration.CustomizableEdges = CustomizableEdges5
        Guna2GradientButton2.Size = New Size(178, 44)
        Guna2GradientButton2.TabIndex = 34
        Guna2GradientButton2.Text = "Médias"
        Guna2GradientButton2.UseTransparentBackground = True
        ' 
        ' Guna2GradientButton3
        ' 
        Guna2GradientButton3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Guna2GradientButton3.Animated = True
        Guna2GradientButton3.BackColor = Color.Transparent
        Guna2GradientButton3.BorderRadius = 10
        Guna2GradientButton3.CustomizableEdges = CustomizableEdges6
        Guna2GradientButton3.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientButton3.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientButton3.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton3.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton3.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientButton3.FillColor = Color.BlueViolet
        Guna2GradientButton3.FillColor2 = Color.CornflowerBlue
        Guna2GradientButton3.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2GradientButton3.ForeColor = Color.Black
        Guna2GradientButton3.GradientMode = Drawing2D.LinearGradientMode.ForwardDiagonal
        Guna2GradientButton3.Location = New Point(311, 341)
        Guna2GradientButton3.Name = "Guna2GradientButton3"
        Guna2GradientButton3.ShadowDecoration.BorderRadius = 10
        Guna2GradientButton3.ShadowDecoration.CustomizableEdges = CustomizableEdges7
        Guna2GradientButton3.Size = New Size(178, 44)
        Guna2GradientButton3.TabIndex = 35
        Guna2GradientButton3.Text = "Crescimento"
        Guna2GradientButton3.UseTransparentBackground = True
        ' 
        ' Guna2CheckBox1
        ' 
        Guna2CheckBox1.AutoSize = True
        Guna2CheckBox1.BackColor = SystemColors.Control
        Guna2CheckBox1.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2CheckBox1.CheckedState.BorderRadius = 0
        Guna2CheckBox1.CheckedState.BorderThickness = 0
        Guna2CheckBox1.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2CheckBox1.Location = New Point(495, 356)
        Guna2CheckBox1.Name = "Guna2CheckBox1"
        Guna2CheckBox1.Size = New Size(102, 19)
        Guna2CheckBox1.TabIndex = 36
        Guna2CheckBox1.Text = "CheckBoxCres"
        Guna2CheckBox1.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2CheckBox1.UncheckedState.BorderRadius = 0
        Guna2CheckBox1.UncheckedState.BorderThickness = 0
        Guna2CheckBox1.UncheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' Guna2CheckBox2
        ' 
        Guna2CheckBox2.AutoSize = True
        Guna2CheckBox2.BackColor = SystemColors.Control
        Guna2CheckBox2.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2CheckBox2.CheckedState.BorderRadius = 0
        Guna2CheckBox2.CheckedState.BorderThickness = 0
        Guna2CheckBox2.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2CheckBox2.Location = New Point(495, 403)
        Guna2CheckBox2.Name = "Guna2CheckBox2"
        Guna2CheckBox2.Size = New Size(103, 19)
        Guna2CheckBox2.TabIndex = 37
        Guna2CheckBox2.Text = "CheckBoxMed"
        Guna2CheckBox2.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2CheckBox2.UncheckedState.BorderRadius = 0
        Guna2CheckBox2.UncheckedState.BorderThickness = 0
        Guna2CheckBox2.UncheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2CheckBox2.UseVisualStyleBackColor = False
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.Anchor = AnchorStyles.Top
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel2.ForeColor = Color.Lavender
        Guna2HtmlLabel2.Location = New Point(252, 86)
        Guna2HtmlLabel2.Margin = New Padding(5)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Padding = New Padding(10)
        Guna2HtmlLabel2.Size = New Size(315, 66)
        Guna2HtmlLabel2.TabIndex = 38
        Guna2HtmlLabel2.Text = "Crie seu resumo"
        Guna2HtmlLabel2.TextAlignment = ContentAlignment.TopCenter
        ' 
        ' PicSair
        ' 
        PicSair.BackColor = Color.SlateBlue
        PicSair.BackgroundImage = My.Resources.Resources.saida1
        PicSair.BackgroundImageLayout = ImageLayout.Stretch
        PicSair.BorderStyle = BorderStyle.Fixed3D
        PicSair.Location = New Point(906, 152)
        PicSair.Name = "PicSair"
        PicSair.Size = New Size(47, 45)
        PicSair.TabIndex = 39
        PicSair.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ActiveCaptionText
        PictureBox1.Location = New Point(685, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(287, 658)
        PictureBox1.TabIndex = 42
        PictureBox1.TabStop = False
        ' 
        ' CriarResumo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.imagemfundo
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(972, 574)
        Controls.Add(PicSair)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(Guna2CheckBox2)
        Controls.Add(Guna2CheckBox1)
        Controls.Add(Guna2GradientButton3)
        Controls.Add(Guna2GradientButton2)
        Controls.Add(Guna2GradientButton1)
        Controls.Add(Guna2CirclePictureBox1)
        Controls.Add(img_perfil)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "CriarResumo"
        Text = "Crie seu resumo"
        CType(img_perfil, ComponentModel.ISupportInitialize).EndInit()
        CType(Guna2CirclePictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PicSair, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents img_perfil As PictureBox
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton3 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2CheckBox1 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2CheckBox2 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PicSair As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
