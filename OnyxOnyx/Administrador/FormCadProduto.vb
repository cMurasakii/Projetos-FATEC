Public Class FormCadProduto
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        banco_onyx()
        data_cadproduto()
        Dim categorias As String() = {
        "Vestuário",
        "Eletrônicos",
        "Alimentos",
        "Móveis",
        "Livros",
        "Acessórios",
        "Higiene"
    }
        cmb_categ.Items.Clear()
        cmb_categ.Items.AddRange(categorias)
        cmb_categ.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_categ.SelectedIndex = 0
        cmb_categ.SelectedIndex = -1
    End Sub

    Private Sub dgv_produtos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_produtos.CellContentClick
        ' Verifica se há linha selecionada
        If dgv_produtos.CurrentRow Is Nothing Then Exit Sub

        Select Case e.ColumnIndex
        ' Coluna de edição (5)
            Case 5
                aux_prod = dgv_produtos.CurrentRow.Cells(0).Value
                sql = $"SELECT * FROM tb_produtos WHERE idProduto = {aux_prod}"
                rs = db.Execute(sql)

                If Not rs.EOF Then
                    txt_nomeprod.Text = rs.Fields("nome").Value
                    cmb_categ.Text = rs.Fields("categoria").Value
                    txt_preco.Text = rs.Fields("preco").Value
                    txt_estoque.Text = rs.Fields("estoque").Value
                End If

        ' Coluna de exclusão (6)
            Case 6
                aux_prod = dgv_produtos.CurrentRow.Cells(0).Value
                sql = $"SELECT * FROM tb_produtos WHERE idProduto = {aux_prod}"
                rs = db.Execute(sql)

                If Not rs.EOF Then
                    resp = MsgBox("Deseja excluir o produto ID: " & aux_prod & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = $"DELETE FROM tb_produtos WHERE idProduto = {aux_prod}"
                        rs = db.Execute(sql)
                        limpar_cadastro_produto()
                        data_cadproduto() ' recarrega o grid após exclusão
                        MsgBox("Produto excluído com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                    End If
                End If

            Case Else
                Exit Sub
        End Select
    End Sub
    Private Sub data_cadproduto()
        Try
            sql = "SELECT * FROM tb_produtos ORDER BY idProduto ASC"
            rs = db.Execute(sql)

            With Me.dgv_produtos
                .Rows.Clear()
                cont = 1

                Do While Not rs.EOF
                    .Rows.Add(
                    rs.Fields("idProduto").Value,   ' ID do produto
                    rs.Fields("nome").Value,        ' Nome
                    rs.Fields("categoria").Value,   ' Categoria
                    rs.Fields("preco").Value,       ' Preço
                    rs.Fields("estoque").Value      ' Estoque
                )
                    cont += 1
                    rs.MoveNext()
                Loop
            End With

        Catch ex As Exception
            MsgBox("Erro ao carregar produtos: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Private Sub salvar_produto(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            If aux_prod = 0 Then
                ' Novo produto
                sql = $"INSERT INTO tb_produtos (nome, categoria, preco, estoque) VALUES 
                    ('{txt_nomeprod.Text}', '{cmb_categ.Text}', {txt_preco.Text}, {txt_estoque.Text})"
                db.Execute(sql)
                MsgBox("Produto cadastrado com sucesso!", vbInformation)
            Else
                ' Atualizar existente
                sql = $"UPDATE tb_produtos SET 
                    nome = '{txt_nomeprod.Text}', 
                    categoria = '{cmb_categ.Text}', 
                    preco = {txt_preco.Text}, 
                    estoque = {txt_estoque.Text} 
                WHERE idProduto = {aux_prod}"
                db.Execute(sql)
                MsgBox("Produto alterado com sucesso!", vbInformation)
            End If

            limpar_cadastro_produto
            aux_prod = 0

        Catch ex As Exception
            MsgBox("Erro ao gravar: " & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim iniciar As New FormCadUsuarios()
        iniciar.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Dim iniciar As New InicialCliente()
        iniciar.Show()
        Application.DoEvents()
        Me.Close()
    End Sub
End Class