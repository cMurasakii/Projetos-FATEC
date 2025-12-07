
Imports System.IO
Imports ADODB
Module Module1
    Public sql, aux_cpf, aux_prod, resp, perm, nivel_usuario, cliente, adm As String
    Public fotoperfil As String = ""
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public cont As Integer

    Public Sub AbrirPastaRelatorios()
        Try
            Dim pastaRelatorios As String = Path.Combine(Application.StartupPath, "Relatórios")
            Directory.CreateDirectory(pastaRelatorios)

            Process.Start(New ProcessStartInfo(pastaRelatorios) With {.UseShellExecute = True})

        Catch ex As Exception
            MsgBox("Erro ao abrir a pasta Relatórios: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub
    Sub banco_onyx()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("DRIVER={MySQL ODBC 3.51 Driver};SERVER=localhost;DATABASE=onyx_analytics;UID=root;PWD=usbw;port=3307;")
            MsgBox("Funcionando!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub limpar_cadastro_usuario()
        Try
            With FormCadUsuarios
                .txt_cpf.BackColor = Color.White
                .txt_cpf.Clear()
                .txt_nome.Clear()
                .txt_email.Clear()
                .txt_fone.Clear()
                .txt_senha.Clear()
                .cmb_pais.SelectedIndex = -1
                .cmb_nivel.SelectedIndex = -1
                .cmb_data_ped.Value = Now
                .img_perfil.Load(Application.StartupPath & "\fotos\nova_foto.png")
                .txt_cpf.Focus()
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub limpar_cadastro_produto()
        Try
            With FormCadProduto
                .txt_nomeprod.Clear()
                .txt_preco.Clear()
                .txt_estoque.Clear()
                .cmb_categ.SelectedIndex = -1
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Public Sub sair_login(formAtual As Form)
            Dim iniciar As New LoginUsuario()
        nivel_usuario = ""
        LoginUsuario.txt_usuario.Clear()
        LoginUsuario.txt_senha.Clear()
        iniciar.Show()
        formAtual.Hide()
    End Sub
    End Module

