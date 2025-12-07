Imports System.IO
Imports PdfSharpCore.Drawing
Imports PdfSharpCore.Pdf

Public Class PedidoCliente
    Private Sub PicSair_Click(sender As Object, e As EventArgs) Handles PicSair.Click
        sair_login(Me)
    End Sub
    Public Property FotoPerfilPath As String

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        banco_onyx()
        Try
            If FotoPerfilPath <> "" Then
                img_perfil.Load(FotoPerfilPath)
            End If

            'Limpa as combobox antes de carregar os dados
            cmbEntrega.Items.Clear()
            cmb_qtd.Items.Clear()
            cmb_produto.Items.Clear()

            sql = "SELECT nome FROM tb_produtos"
            rs = db.Execute(sql)
            Do While Not rs.EOF
                cmb_produto.Items.Add(rs.Fields("nome").Value.ToString())
                rs.MoveNext()
            Loop

            ' Adiciona opções de quantidade de 1 a 20
            For i As Integer = 1 To 20
                cmb_qtd.Items.Add(i.ToString())
            Next
            If cmb_qtd.Items.Count > 0 Then
                cmb_qtd.SelectedIndex = 0
            End If

            ' Adiciona opções de entrega a partir de 3 dias
            For i As Integer = 3 To 10
                Dim dataEntrega As Date = Date.Now.AddDays(i)
                cmbEntrega.Items.Add(dataEntrega.ToString("dd/MM/yyyy"))
            Next
            If cmbEntrega.Items.Count > 0 Then
                cmbEntrega.SelectedIndex = 0
            End If

        Catch ex As Exception
            MsgBox("Erro!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Public Sub GerarPDF()
        Try
            Dim nome As String, email As String, fone As String, pais As String, cpf As String

            sql = "SELECT * FROM tb_usuarios WHERE (nome='" & txt_nome.Text & "' OR email='" & txt_nome.Text & "') AND senha='" & txt_senha.Text & "'"
            rs = db.Execute(sql)

            If rs IsNot Nothing AndAlso Not rs.EOF Then
                nome = rs.Fields("nome").Value.ToString()
                email = rs.Fields("email").Value.ToString()
                fone = rs.Fields("tel").Value.ToString()
                cpf = rs.Fields("cpf").Value.ToString()
                pais = rs.Fields("pais").Value.ToString()

                txt_nome.Text = nome
                txt_fone.Text = fone
                txt_cpf.Text = cpf

                ' Cria documento PDF
                Dim doc As New PdfDocument()
                doc.Info.Title = "Pedido do Comprador"

                Dim paginaPdf As PdfPage = doc.AddPage()
                Dim graf As XGraphics = XGraphics.FromPdfPage(paginaPdf)
                Dim fontNormal As XFont = New XFont("Verdana", 12, XFontStyle.Regular)
                Dim fontUnderline As XFont = New XFont("Verdana", 12, XFontStyle.Underline)

                ' Proteções contra NullReference nas ComboBoxes
                Dim dataEntrega As String = If(cmbEntrega.SelectedIndex >= 0, cmbEntrega.SelectedItem.ToString(), "Não informado")
                Dim qtdEntrega As String = If(cmb_qtd.SelectedIndex >= 0, cmb_qtd.SelectedItem.ToString(), "Não informado")
                Dim produto As String = If(cmb_produto.SelectedIndex >= 0, cmb_produto.SelectedItem.ToString(), "Não informado")

                Dim logoBytes As Byte()
                Using bmp As System.Drawing.Bitmap = My.Resources.logoonyx_removebg_preview
                    Using msBmp As New MemoryStream()
                        bmp.Save(msBmp, System.Drawing.Imaging.ImageFormat.Png)
                        logoBytes = msBmp.ToArray()
                    End Using
                End Using
                Dim logo As XImage = XImage.FromStream(Function() New MemoryStream(logoBytes))
                graf.DrawImage(logo, (paginaPdf.Width.Point - 120) / 2, 40, 120, 120)

                graf.DrawString("Comprador(a): " & nome, fontNormal, XBrushes.Black, New XPoint(50, 200))
                graf.DrawString("Email: " & email, fontUnderline, XBrushes.Blue, New XPoint(50, 240))
                graf.DrawString("Telefone: " & fone, fontNormal, XBrushes.Black, New XPoint(50, 260))
                graf.DrawString("CPF: " & cpf, fontNormal, XBrushes.Black, New XPoint(50, 280))
                graf.DrawString("Destino de entrega: " & pais, fontNormal, XBrushes.Black, New XPoint(50, 300))
                graf.DrawString("Data de Entrega: " & dataEntrega, fontNormal, XBrushes.Black, New XPoint(50, 340))
                graf.DrawString("Produto: " & produto, fontNormal, XBrushes.Black, New XPoint(50, 380))
                graf.DrawString("Quantidade de itens: " & qtdEntrega, fontNormal, XBrushes.Black, New XPoint(50, 400))
                graf.DrawString("Precisa de ajuda? Mande um e-mail aqui -> onyxiassistente@gmail.com", fontUnderline, XBrushes.Black, New XPoint(50, 440))

                Dim pastaRelatorios As String = Path.Combine(Application.StartupPath, "Relatórios")
                Directory.CreateDirectory(pastaRelatorios)

                Dim timestamp As String = DateTime.Now.ToString("yyyy-MM-dd_HHmmss")
                Dim nomeSanitizado As String = String.Concat(nome.Where(Function(c) Not Path.GetInvalidFileNameChars().Contains(c)))
                Dim caminhoArquivo As String = Path.Combine(pastaRelatorios, $"pedido_{timestamp}_{nomeSanitizado}.pdf")

                doc.Save(caminhoArquivo)

                MsgBox("PDF gerado com sucesso em: " & caminhoArquivo, MsgBoxStyle.Information, "AVISO")
            Else
                MsgBox("Usuário não encontrado!", MsgBoxStyle.Exclamation, "Aviso")
            End If

        Catch ex As Exception
            MsgBox("Erro ao gerar PDF: " & ex.ToString(), MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Dim iniciar As New InicialCliente()
        iniciar.Show()
        Application.DoEvents()
        Me.Close()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        GerarPDF()
    End Sub
End Class