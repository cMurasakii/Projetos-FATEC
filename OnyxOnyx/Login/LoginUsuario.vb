Imports System.Net.Mail
Imports System.Security.Policy
Imports System.Diagnostics
Public Class LoginUsuario
    Public CodigoGerado As String
    'Num aleatório
    Private Function GerarCodigo() As String
        Dim rnd As New Random()
        Return rnd.Next(100000, 999999).ToString()
    End Function
    Public Sub AbrirBanco()
        Try
            Dim caminhoExe As String = "F:\FATEC 2°SEMESTRE\Programas Prof Humberto\OnyxOnyx\USBWebserver v10\usbwebserver.exe"

            Process.Start(caminhoExe)

        Catch ex As Exception
            MsgBox("Erro ao abrir o banco de dados: " & ex.Message, MsgBoxStyle.Critical, "ATENÇÃO")
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        banco_onyx()
        'AbrirBanco()
    End Sub
    'Função para enviar e-mail
    Public Sub EnviarCodigoEmail(Optional destinatario As String = "")
        Dim codigoDigitado As String = ""
        If String.IsNullOrEmpty(destinatario) Then
            destinatario = InputBox("Digite o e-mail do destinatário:", "Enviar Código de Verificação")

            If String.IsNullOrEmpty(destinatario) Then
                MsgBox("E-mail não informado.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                Return
            End If
        End If

        Dim codigo As String = GerarCodigo()
        CodigoGerado = codigo

        Try
            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.Credentials = New Net.NetworkCredential("onyxiassistente@gmail.com", "pxcgutjukydggftl")
            smtp.EnableSsl = True

            Dim mail As New MailMessage()
            mail.From = New MailAddress("onyxiassistente@gmail.com")
            mail.To.Add(destinatario)
            mail.Subject = "Código de Verificação do Onyx Analytics ~"
            mail.Body = $"Olá usuário! Seu código de verificação é: {codigo}"

            smtp.Send(mail)
            MsgBox($"Código enviado para o e-mail {destinatario}.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO!")
            codigoDigitado = InputBox("Digite o código de verificação:", "Entrar por código de verificação")
            If codigoDigitado = codigo Then
                MsgBox("Código verificado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO!")

                sql = "SELECT * FROM tb_usuarios WHERE email='" & destinatario & "'"
                rs = db.Execute(sql)

                nivel_usuario = rs.Fields("nivel").Value

                MsgBox("Login realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                If nivel_usuario = "Administrador" Then
                    perm = "adm"
                    Dim iniciar As New InicialCliente()
                    iniciar.Show()
                    Me.Hide()
                Else
                    perm = "cliente"
                    Dim iniciar As New InicialCliente()
                    iniciar.Show()
                    Me.Hide()
                End If
            Else
                MsgBox("Código ou e-mail inválidos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            End If
        Catch ex As Exception
            MsgBox("Erro ao enviar e-mail: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub esq_senha_Click(sender As Object, e As EventArgs) Handles esq_senha.Click
        EnviarCodigoEmail()
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.WindowState = FormWindowState.Maximized
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub entrarconta(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            If db Is Nothing OrElse db.State <> 1 Then
                MsgBox("Conexão do banco não está aberta.")
                Exit Sub
            End If

            If txt_usuario.Text = "" OrElse txt_senha.Text = "" Then
                MsgBox("Usuário e senha não podem estar vazios.")
                Exit Sub
            End If

            If txt_usuario Is Nothing OrElse txt_senha Is Nothing Then
                MsgBox("Controles de usuário/senha não estão referenciados no formulário.")
                Exit Sub
            End If

            sql = "SELECT * FROM tb_usuarios WHERE (nome='" & txt_usuario.Text & "' OR email='" & txt_usuario.Text & "') AND senha='" & txt_senha.Text & "'"
            rs = db.Execute(sql)

            If Not rs.EOF Then

                nivel_usuario = rs.Fields("nivel").Value

                MsgBox("Login realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                If nivel_usuario = "Administrador" Then
                    perm = "adm"
                    Dim iniciar As New InicialCliente()
                    iniciar.Show()
                    Me.Hide()
                Else
                    perm = "cliente"
                    Dim iniciar As New InicialCliente()
                    iniciar.Show()
                    Me.Hide()
                End If
            Else
                MsgBox("Usuário ou senha inválidos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If

        Catch ex As Exception
            MsgBox("Erro ao tentar conectar ou consultar o banco: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class











