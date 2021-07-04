Public Class FormGestaoProd
    Dim menub As Boolean = False
    Dim locx, locy As Integer
    Private formatual As Form


    Private Sub abrirformulariof(formulariofilho As Form)
        If formatual IsNot Nothing Then
            If formatual.Name = formulariofilho.Name Then
                Exit Sub
            End If
            formatual.Close()
        End If
        formatual = formulariofilho
        formulariofilho.TopLevel = False
        formulariofilho.FormBorderStyle = FormBorderStyle.None
        formulariofilho.Dock = DockStyle.Fill
        PanelForm.Controls.Add(formulariofilho)
        PanelForm.Tag = formulariofilho
        formulariofilho.BringToFront()
        formulariofilho.Show()
    End Sub
    Private Sub botoes(btn As FontAwesome.Sharp.IconButton, locx As Integer, locy As Integer)
        PanelMenu.Controls.Add(btn)
        btn.Location = New Point(locx, locy)
        btn.Size = New Size(72, 63)
        btn.IconSize = 60
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If menub = False Then
            botoes(btnAdd, btnAdd.Location.X.ToString + 60, 5)
            botoes(BtnRemover, BtnRemover.Location.X.ToString + 60, 5)
            botoes(BtnEditar, BtnEditar.Location.X.ToString + 60, 5)
            menub = True
        End If
        abrirformulariof(FormAddProd)
    End Sub

    Private Sub BtnRemover_Click(sender As Object, e As EventArgs) Handles BtnRemover.Click
        If menub = False Then
            botoes(btnAdd, btnAdd.Location.X.ToString + 60, 5)
            botoes(BtnRemover, BtnRemover.Location.X.ToString + 60, 5)
            botoes(BtnEditar, BtnEditar.Location.X.ToString + 60, 5)
            menub = True
        End If
        abrirformulariof(FormRemoverProduto)
    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If menub = False Then
            botoes(btnAdd, btnAdd.Location.X.ToString + 60, 5)
            botoes(BtnRemover, BtnRemover.Location.X.ToString + 60, 5)
            botoes(BtnEditar, BtnEditar.Location.X.ToString + 60, 5)
            menub = True
        End If
        abrirformulariof(FormEditarProduto)
    End Sub

    Private Sub btnfechar_Click(sender As Object, e As EventArgs) Handles btnfechar.Click
        Me.Close()
    End Sub

End Class