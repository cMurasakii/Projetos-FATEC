<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginUsuario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        'Dim txt_senha As TextBox
        'Dim txt_usuario As TextBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginUsuario))
        Label4 = New Label()
        Label3 = New Label()
        btn_entrar = New Guna.UI2.WinForms.Guna2GradientButton()
        esq_senha = New Guna.UI2.WinForms.Guna2GradientButton()
        Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        txt_senha = New TextBox()
        txt_usuario = New TextBox()
        CType(Guna2CirclePictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label4.AutoSize = True
        Label4.BackColor = Color.MediumSlateBlue
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(304, 484)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 21)
        Label4.TabIndex = 10
        Label4.Text = "Senha"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label3.AutoSize = True
        Label3.BackColor = Color.MediumSlateBlue
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(304, 418)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 21)
        Label3.TabIndex = 9
        Label3.Text = "Usuário / Email"
        ' 
        ' btn_entrar
        ' 
        btn_entrar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        btn_entrar.Animated = True
        btn_entrar.BackColor = Color.Transparent
        btn_entrar.BorderRadius = 10
        btn_entrar.CustomizableEdges = CustomizableEdges1
        btn_entrar.DisabledState.BorderColor = Color.DarkGray
        btn_entrar.DisabledState.CustomBorderColor = Color.DarkGray
        btn_entrar.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_entrar.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_entrar.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_entrar.FillColor = Color.BlueViolet
        btn_entrar.FillColor2 = Color.CornflowerBlue
        btn_entrar.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_entrar.ForeColor = Color.Black
        btn_entrar.GradientMode = Drawing2D.LinearGradientMode.ForwardDiagonal
        btn_entrar.Location = New Point(366, 566)
        btn_entrar.Name = "btn_entrar"
        btn_entrar.ShadowDecoration.BorderRadius = 10
        btn_entrar.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btn_entrar.Size = New Size(244, 76)
        btn_entrar.TabIndex = 28
        btn_entrar.Text = "Entrar"
        btn_entrar.UseTransparentBackground = True
        ' 
        ' esq_senha
        ' 
        esq_senha.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        esq_senha.Animated = True
        esq_senha.BackColor = Color.Transparent
        esq_senha.BorderRadius = 10
        esq_senha.BorderStyle = Drawing2D.DashStyle.Dot
        esq_senha.CustomizableEdges = CustomizableEdges3
        esq_senha.DisabledState.BorderColor = Color.DarkGray
        esq_senha.DisabledState.CustomBorderColor = Color.DarkGray
        esq_senha.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        esq_senha.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        esq_senha.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        esq_senha.FillColor = Color.BlueViolet
        esq_senha.FillColor2 = Color.CornflowerBlue
        esq_senha.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        esq_senha.ForeColor = Color.Black
        esq_senha.GradientMode = Drawing2D.LinearGradientMode.ForwardDiagonal
        esq_senha.Location = New Point(391, 681)
        esq_senha.Name = "esq_senha"
        esq_senha.ShadowDecoration.BorderRadius = 10
        esq_senha.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        esq_senha.Size = New Size(193, 55)
        esq_senha.TabIndex = 30
        esq_senha.Text = "Esqueceu a senha?"
        esq_senha.UseTransparentBackground = True
        ' 
        ' Guna2CirclePictureBox1
        ' 
        Guna2CirclePictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Guna2CirclePictureBox1.BackColor = Color.Transparent
        Guna2CirclePictureBox1.BackgroundImage = My.Resources.Resources.logoonyx_removebg_preview2
        Guna2CirclePictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        Guna2CirclePictureBox1.Image = My.Resources.Resources.logoonyx_removebg_preview1
        Guna2CirclePictureBox1.ImageRotate = 0F
        Guna2CirclePictureBox1.Location = New Point(391, 201)
        Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges5
        Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CirclePictureBox1.Size = New Size(202, 202)
        Guna2CirclePictureBox1.TabIndex = 29
        Guna2CirclePictureBox1.TabStop = False
        ' 
        ' txt_senha
        ' 
        txt_senha.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        txt_senha.BackColor = Color.Lavender
        txt_senha.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_senha.Location = New Point(304, 508)
        txt_senha.Name = "txt_senha"
        txt_senha.Size = New Size(377, 29)
        txt_senha.TabIndex = 6
        txt_senha.UseSystemPasswordChar = True
        ' 
        ' txt_usuario
        ' 
        txt_usuario.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        txt_usuario.BackColor = Color.Lavender
        txt_usuario.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_usuario.Location = New Point(304, 442)
        txt_usuario.Name = "txt_usuario"
        txt_usuario.Size = New Size(377, 29)
        txt_usuario.TabIndex = 3
        ' 
        ' LoginUsuario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.imagemfundo
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(984, 1041)
        Controls.Add(esq_senha)
        Controls.Add(Guna2CirclePictureBox1)
        Controls.Add(btn_entrar)
        Controls.Add(txt_usuario)
        Controls.Add(Label4)
        Controls.Add(txt_senha)
        Controls.Add(Label3)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "LoginUsuario"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Entrar na conta"
        CType(Guna2CirclePictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_entrar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents esq_senha As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
End Class
