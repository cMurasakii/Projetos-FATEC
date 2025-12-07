Public Class InicialCliente
    Sub visivel_usuario()
        If perm = "cliente" Then
            gerencia.Visible = False
        End If
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        banco_onyx()
        visivel_usuario()
    End Sub
    Public Sub CarregarFotoDoBanco(usuarioId As Integer, picture As PictureBox)
        Try
            sql = "SELECT foto FROM tb_usuarios WHERE nome=" & usuarioId
            rs = db.Execute(sql)

            If Not rs.EOF Then
                Dim caminhoFoto As String = rs.Fields("foto").Value.ToString()

                If caminhoFoto <> "" Then
                    picture.Load(caminhoFoto)
                End If
            End If

        Catch ex As Exception
            MsgBox("Erro ao carregar foto do banco: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_perfil.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma foto"
                .InitialDirectory = Application.StartupPath & "\fotos\"
                If .ShowDialog() = DialogResult.OK Then
                    Dim caminho As String = .FileName
                    img_perfil.Load(caminho)

                    Dim f2 As New PedidoCliente()
                    f2.FotoPerfilPath = caminho
                    f2.Show()
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar imagem", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PicSair.Click
        sair_login(Me)
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim PedidoCliente As New PedidoCliente()
        PedidoCliente.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles gerencia.Click
        Dim FormCadUsuarios As New FormCadUsuarios()
        FormCadUsuarios.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs)
        Dim AbaAnalise As New AbaAnalise
        AbaAnalise.Show
        Hide
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs)
        Dim iniciar As New InicialCliente
        iniciar.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        AbrirPastaRelatorios()
    End Sub
End Class