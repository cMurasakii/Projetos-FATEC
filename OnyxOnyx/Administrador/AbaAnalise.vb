Public Class AbaAnalise
    Public Sub New()
        InitializeComponent()
        Me.WindowState = FormWindowState.Maximized
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim iniciar As New CriarResumo
        iniciar.Show()
        Close()
    End Sub

    Private Sub PicSair_Click(sender As Object, e As EventArgs) Handles PicSair.Click
        sair_login(Me)
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Dim iniciar As New InicialCliente()
        iniciar.Show()
        Application.DoEvents()
        Me.Close()
    End Sub
End Class