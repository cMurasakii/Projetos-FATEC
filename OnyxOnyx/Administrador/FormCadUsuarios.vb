Imports System.IO

Public Class FormCadUsuarios
    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_perfil.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma foto"
                .InitialDirectory = Application.StartupPath & "\fotos\"
                .ShowDialog()
                fotoperfil = .FileName
                fotoperfil = fotoperfil.Replace("\", "/")
                img_perfil.Load(fotoperfil)
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar imagem", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        banco_onyx()
        data_cadusuario()

        Dim paises As String() = {
    "África do Sul",
    "Alemanha",
    "Argentina",
    "Austrália",
    "Brasil",
    "Canadá",
    "Chile",
    "Espanha",
    "Estados Unidos",
    "França",
    "Itália",
    "Japão",
    "México",
    "Portugal",
    "Reino Unido"
}
        cmb_pais.Items.Clear()
        cmb_pais.Items.AddRange(paises)
        cmb_pais.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_pais.SelectedIndex = 0
        cmb_pais.SelectedIndex = -1

        Dim niveis As String() = {
    "Administrador",
    "Comprador"
}
        cmb_nivel.Items.Clear()
        cmb_nivel.Items.AddRange(niveis)
        cmb_nivel.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_nivel.SelectedIndex = 0
        cmb_nivel.SelectedIndex = -1
    End Sub

    Private Sub grid_data_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_data.CellContentClick
        If grid_data.CurrentRow Is Nothing Then Exit Sub

        Select Case e.ColumnIndex
        'Coluna de edição
            Case 8
                txt_nome.Text = grid_data.CurrentRow.Cells(1).Value.ToString()
                txt_email.Text = grid_data.CurrentRow.Cells(2).Value.ToString()
                txt_cpf.Text = grid_data.CurrentRow.Cells(3).Value.ToString()
                cmb_pais.Text = grid_data.CurrentRow.Cells(4).Value.ToString()
                txt_fone.Text = grid_data.CurrentRow.Cells(5).Value.ToString()
                cmb_nivel.Text = grid_data.CurrentRow.Cells(6).Value.ToString()
                cmb_data_ped.Text = grid_data.CurrentRow.Cells(7).Value.ToString()

        'Coluna de exclusão
            Case 9
                aux_cpf = grid_data.CurrentRow.Cells(3).Value.ToString()
                resp = MsgBox("Deseja excluir o CPF: " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    sql = $"DELETE FROM tb_usuarios WHERE cpf = '{aux_cpf}'"
                    rs = db.Execute(sql)
                    limpar_cadastro_usuario()
                    data_cadusuario() ' Recarrega o grid após exclusão
                    MsgBox("Usuário excluído com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                End If

            Case Else
                Exit Sub
        End Select
    End Sub

    Private Sub txt_cpf_DoubleClick(sender As Object, e As EventArgs) Handles txt_cpf.DoubleClick
        limpar_cadastro_usuario()
    End Sub

    Private Sub data_cadusuario()
        Try
            sql = "SELECT * FROM tb_usuarios order by nivel asc"
            rs = db.Execute(sql)

            grid_data.Rows.Clear()

            Do While Not rs.EOF
                grid_data.Rows.Add(
                rs.Fields("idCliente").Value,
                rs.Fields("nome").Value,
                rs.Fields("email").Value,
                rs.Fields("cpf").Value,
                rs.Fields("pais").Value,
                rs.Fields("tel").Value,
                rs.Fields("nivel").Value,
                rs.Fields("dataped").Value
)
                rs.MoveNext()
            Loop

        Catch ex As Exception
            MsgBox("Erro ao carregar dados: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub


    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        Try
            sql = $"SELECT * FROM tb_usuarios WHERE cpf = '{txt_cpf.Text}'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                txt_nome.Focus()
            Else
                txt_cpf.BackColor = Color.Red
                MsgBox("CPF já cadastrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                txt_cpf.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro de processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub PicSair_Click(sender As Object, e As EventArgs) Handles PicSair.Click
        sair_login(Me)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim dataFormatada As String = cmb_data_ped.Value.ToString("yyyy-MM-dd")
        Try
            sql = $"SELECT * FROM tb_usuarios WHERE cpf = '{txt_cpf.Text}'"
            rs = db.Execute(sql)

            If rs.EOF = True Then
                ' Inserir novo usuário
                sql = $"INSERT INTO tb_usuarios (dataped, cpf, nome, tel, email, senha, pais, nivel) VALUES (
                   '{dataFormatada}',     
                   '{txt_cpf.Text}', 
                   '{txt_nome.Text}', 
                   '{txt_fone.Text}', 
                   '{txt_email.Text}', 
                   '{txt_senha.Text}', 
                   '{cmb_pais.Text}', 
                   '{cmb_nivel.Text}')"


                rs = db.Execute(sql)
                MsgBox("Dados gravados", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")

            Else
                ' Atualizar usuário existente
                sql = $"UPDATE tb_usuarios SET 
                   dataped = '{dataFormatada}', 
                   nome = '{txt_nome.Text}', 
                   tel = '{txt_fone.Text}', 
                   email = '{txt_email.Text}', 
                   senha = '{txt_senha.Text}', 
                   pais = '{cmb_pais.Text}', 
                   nivel = '{cmb_nivel.Text}' 
               WHERE cpf = '{txt_cpf.Text}'"


                rs = db.Execute(sql)
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
            End If

            limpar_cadastro_usuario()

        Catch ex As Exception
            MsgBox("Erro ao gravar! " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim iniciar As New FormCadProduto()
        iniciar.Show()
        Me.Close()
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Dim iniciar As New InicialCliente()
        iniciar.Show()
        Application.DoEvents()
        Me.Close()
    End Sub
End Class

