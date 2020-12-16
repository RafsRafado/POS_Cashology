Imports FontAwesome.Sharp
Imports System.Net
Imports System.IO
Imports System.Text

Public Class FormPedidos
    Dim btnativo As IconButton
    Private btnbordaesquerda As Panel
    Public tipo As String
    Dim pagatual As Integer = 0
    Dim npags As Integer = 0
    Dim numregistos As Integer = 0
    Dim position As Integer = 0
    Dim quant As String
    Public valpagar As Integer
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        btnbordaesquerda = New Panel()
        btnbordaesquerda.Size = New Size(7, 60)
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
    End Sub
    Private Sub ativarbotao(senderbtn As Object, customcolor As Color)
        If senderbtn IsNot Nothing Then
RETRY:
            Try
                btnativo = CType(senderbtn, IconButton)
                btnativo.BackColor = Color.FromArgb(37, 36, 81)
                btnativo.ForeColor = customcolor
                btnativo.IconColor = customcolor
                btnativo.TextAlign = ContentAlignment.MiddleCenter
                btnativo.ImageAlign = ContentAlignment.MiddleRight
                btnativo.TextImageRelation = TextImageRelation.TextBeforeImage
                lbselec.Text = btnativo.Text

                btnbordaesquerda.BackColor = customcolor
                btnbordaesquerda.Location = New Point(btnativo.Location.Y, 0)
                btnbordaesquerda.Visible = True
                btnbordaesquerda.BringToFront()
            Catch ex As Exception
                GoTo RETRY
            End Try
        End If
    End Sub
    Private Sub desativarbotao()
        If btnativo IsNot Nothing Then
Retry:
            Try
                btnativo.BackColor = Color.FromArgb(31, 30, 68)
                btnativo.ForeColor = Color.Gainsboro
                btnativo.IconColor = Color.Gainsboro
                btnativo.TextAlign = ContentAlignment.MiddleLeft
                btnativo.ImageAlign = ContentAlignment.MiddleLeft
                btnativo.TextImageRelation = TextImageRelation.ImageBeforeText
            Catch ex As Exception
                GoTo Retry
            End Try
        End If
    End Sub
    Private Sub btnmenu_click(sender As Object, e As EventArgs) Handles btnMenu.Click
        desativarbotao()
        numregistos = 0
        ativarbotao(sender, RGBColors.color4)
        carrpedidos(FormInicio.dt_menus, FormInicio.imgmenus)
    End Sub
    Private Sub btnbebida_click(sender As Object, e As EventArgs) Handles btnBebida.Click
        desativarbotao()
        numregistos = 0
        ativarbotao(sender, RGBColors.color4)
        carrpedidos(FormInicio.dt_bebidas, FormInicio.imgbebidas)

    End Sub
    Private Sub btnprato_click(sender As Object, e As EventArgs) Handles btnPrato.Click
        desativarbotao()
        numregistos = 0
        ativarbotao(sender, RGBColors.color4)
        carrpedidos(FormInicio.dt_pratos, FormInicio.imgpratos)

    End Sub
    Private Sub btnlanche_click(sender As Object, e As EventArgs) Handles btnLanche.Click
        desativarbotao()
        numregistos = 0
        ativarbotao(sender, RGBColors.color4)
        carrpedidos(FormInicio.dt_lanche, FormInicio.imglanche)
    End Sub
    Private Sub FormPedidos_load(sender As Object, e As EventArgs) Handles MyBase.Shown
        Control.CheckForIllegalCrossThreadCalls = False
        btnMenu.PerformClick()
        For Each ctrl As Control In panelprods.Controls
            For Each ctrls As Control In ctrl.Controls
                AddHandler ctrls.Click, AddressOf prod_click
            Next
        Next
    End Sub
    Private Sub btnPagSeg_Click(sender As Object, e As EventArgs) Handles btnPagSeg.Click
        pagatual += 1
        If pagatual = npags Then
            btnPagSeg.Enabled = False
        End If
        btnPagAnt.Enabled = True
        numregistos = (17 * npags) + 1
        Select Case lbselec.Text
            Case = "MENU"
                carrpedidos(FormInicio.dt_menus, FormInicio.imgmenus)
            Case = "BEBIDAS"
                carrpedidos(FormInicio.dt_bebidas, FormInicio.imgbebidas)
            Case = "PRATOS"
                carrpedidos(FormInicio.dt_pratos, FormInicio.imgpratos)
            Case = "LANCHE"
                carrpedidos(FormInicio.dt_lanche, FormInicio.imglanche)
        End Select
    End Sub

    Private Sub btnPagAnt_Click(sender As Object, e As EventArgs) Handles btnPagAnt.Click
        btnPagSeg.Enabled = True
        pagatual -= 1
        numregistos = (17 * npags) + 1
        If pagatual = 0 Then
            btnPagAnt.Enabled = False
            numregistos = 0
        End If
        Select Case lbselec.Text
            Case = "MENU"
                carrpedidos(FormInicio.dt_menus, FormInicio.imgmenus)
            Case = "BEBIDAS"
                carrpedidos(FormInicio.dt_bebidas, FormInicio.imgbebidas)
            Case = "PRATOS"
                carrpedidos(FormInicio.dt_pratos, FormInicio.imgpratos)
            Case = "LANCHE"
                carrpedidos(FormInicio.dt_lanche, FormInicio.imglanche)
        End Select
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim picturebox As New PictureBox
        Dim icon As New FontAwesome.Sharp.IconPictureBox
        If IconButton1.Text = "Editar Nome" Then
            IconButton1.Text = "Terminar Edição"
            For Each ctrl As Control In panelprods.Controls
                For Each ctrls As Control In ctrl.Controls
                    If ctrls.Name.Contains("PictureBox") Then
                        picturebox = ctrls
                    ElseIf ctrls.Name.Contains("IconEdit") Then
                        icon = ctrls
                    End If
                Next
                check(picturebox, icon)
            Next
            Panel8.Enabled = False
        ElseIf IconButton1.Text = "Terminar Edição" Then
            IconButton1.Text = "Editar Nome"
            If IconButton1.Text = "Editar Nome" Then
                IconButton1.Text = "Terminar Edição"
                For Each ctrl As Control In panelprods.Controls
                    For Each ctrls As Control In ctrl.Controls
                        If ctrls.Name.Contains("PictureBox") Then
                            picturebox = ctrls
                        ElseIf ctrls.Name.Contains("IconEdit") Then
                            icon = ctrls
                        End If
                    Next
                    check(picturebox, icon)
                Next
                Panel8.Enabled = True
            End If
        End If
    End Sub
    Private Sub check(ByVal pb As PictureBox, ByVal ic As IconPictureBox)
        If pb.Image Is Nothing Or IconButton1.Text <> "Terminar Edição" Then
            ic.Visible = False
        ElseIf Not pb.Image Is Nothing Then
            ic.Visible = True
        End If
    End Sub

    Public Sub carrpedidos(ByVal dt As DataTable, ByVal imgbit As List(Of Bitmap))
        Carregar_Menu(0, lb1, lbpreco1, PictureBox1, dt, imgbit)
        Carregar_Menu(1, lb2, lbpreco2, PictureBox2, dt, imgbit)
        Carregar_Menu(2, lb3, lbpreco3, PictureBox3, dt, imgbit)
        Carregar_Menu(3, lb4, lbpreco4, PictureBox4, dt, imgbit)
        Carregar_Menu(4, lb5, lbpreco5, PictureBox5, dt, imgbit)
        Carregar_Menu(5, lb6, lbpreco6, PictureBox6, dt, imgbit)
        Carregar_Menu(6, lb7, lbpreco7, PictureBox7, dt, imgbit)
        Carregar_Menu(7, lb8, lbpreco8, PictureBox8, dt, imgbit)
        Carregar_Menu(8, lb9, lbpreco9, PictureBox9, dt, imgbit)
        Carregar_Menu(9, lb10, lbpreco10, PictureBox10, dt, imgbit)
        Carregar_Menu(10, lb11, lbpreco11, PictureBox11, dt, imgbit)
        Carregar_Menu(11, lb12, lbpreco12, PictureBox12, dt, imgbit)
        Carregar_Menu(12, lb13, lbpreco13, PictureBox13, dt, imgbit)
        Carregar_Menu(13, Lb14, lbpreco14, PictureBox14, dt, imgbit)
        Carregar_Menu(14, Lb15, lbpreco15, PictureBox15, dt, imgbit)
        Carregar_Menu(15, lb16, lbpreco16, PictureBox16, dt, imgbit)
        Carregar_Menu(16, lb17, lbpreco17, PictureBox17, dt, imgbit)
        Carregar_Menu(17, lb18, lbpreco18, PictureBox18, dt, imgbit)
    End Sub
    Public Sub Carregar_Menu(ByVal num As Integer, ByVal label As Label, ByVal lbpreco As Label, ByVal pb As PictureBox, ByVal dt As DataTable, ByVal img As List(Of Bitmap))
        num += numregistos
        If num = 0 Then
            pagatual = 0
            npags = 0
            If img.Count / 18 = 0 Then
                npags = 0
            ElseIf img.Count / 18 <> img.Count \ 18 Then
                npags = (img.Count \ 18)
            Else
                npags = (img.Count \ 18)
            End If
            lbPags.Text = pagatual + 1 & "/" & npags + 1
            If npags > pagatual Then
                btnPagSeg.Enabled = True
            End If
        End If
        Try
            label.Text = dt.Rows(num)(0)
            lbpreco.Text = dt.Rows(num)(2) & " €"
            pb.Image = img(num)
        Catch ex As Exception
            label.Text = Nothing
            pb.Image = Nothing
            lbpreco.Text = Nothing
        End Try
    End Sub


    Private Sub prodclick(ByVal lb As Label, lbprecoprod As Label, ByVal ip As IconPictureBox)
        quant = Nothing
        If IconButton1.Text = "Terminar Edição" And ip.Visible = True Then
            Dim result As String = InputBox("Qual o novo nome que deseja?", "Insira o novo nome", lb.Text)
            If result = "" Then
                Exit Sub
            ElseIf result = lb.Text Then
                MessageBox.Show("Não editou o nome.", "Erro")
                Exit Sub
            End If
            Dim nomeant As String = lb.Text
            Dim output As New StringBuilder()
            For Each i As Char In nomeant
                output.Append(Char.ToLower(i))
            Next
            nomeant = output.ToString
            With FormInicio.cmd
                .CommandText = "UPDATE pedidos_" & btnativo.Text & " SET  nome=@nome  WHERE nome='" & nomeant & "'"
                .Connection = FormInicio.con
                .Parameters.AddWithValue("@nome", result)
                .ExecuteNonQuery()
                .Parameters.Clear()
            End With
            FormInicio.exec()
            lb.Text = result
            GoTo checkprod
        Else
            If lb.Text <> "" Then
                Dim pos As Integer
                Dim valfin As String = ""
                Dim j As Integer
                While lbprecoprod.Text(j) <> " "
                    valfin += lbprecoprod.Text(j)
                    j += 1
                End While
                j = 0
                valfin = Convert.ToInt32(valfin)
                If lbpreco.Text.Length > 0 Then
                    lbpreco.Text = lbpreco.Text.Substring(0, lbpreco.Text.Length - 1)
                End If
                lbpreco.Text = Val(lbpreco.Text) + Val(valfin)
                valpagar = Val(lbpreco.Text)
                lbpreco.Text = lbpreco.Text + "€"
                For Each ctrl As Control In panelprod.Controls
                    If Val(ctrl.Location.Y) >= pos Then
                        pos = Val(ctrl.Location.Y) + 90
                    End If
                    If ctrl.GetType.ToString = "System.Windows.Forms.Label" Then
                        If ctrl.Text.Contains(lb.Text + "-" + valfin + " €") Then
                            Dim i As Integer
                            While ctrl.Text(i) <> "x"
                                If ctrl.Text(i) <> "x" Then
                                    quant += ctrl.Text(i)
                                End If
                                i += 1
                            End While
                            Convert.ToInt32(quant)
                            quant += 1
                            ctrl.Text = quant & "x " & lb.Text & "-" & valfin & " €"
                            Exit Sub
                        End If
                    End If
                Next
                Dim label As New Label With
                {
                    .Text = "1x" & lb.Text & "-" & valfin & " €",
                    .Location = New Point(10, pos),
                    .Font = New Font("Comic Sans MS", 17, FontStyle.Bold),
                    .Height = 90,
                    .Width = panelprod.Width - 90
                }
                panelprod.Controls.Add(label)
                Dim botremov As New FontAwesome.Sharp.IconButton With
                    {
                .Location = New Point(panelprod.Width.ToString - 70, pos),
                .Height = 40,
                .Width = 40,
                .IconChar = IconChar.TrashAlt,
                .FlatStyle = FlatStyle.Flat
                }
                AddHandler botremov.Click, AddressOf botaoremov_click
                panelprod.Controls.Add(botremov)
                Exit Sub
checkprod:
                valfin = ""
                While lbprecoprod.Text(j) <> "€"
                    valfin += lbprecoprod.Text(j)
                    j += 1
                End While
                For Each ctrl As Control In panelprod.Controls
                    If ctrl.GetType.ToString = "System.Windows.Forms.Label" Then
                        If ctrl.Text.Contains(lb.Text + "-" & valfin & " €") Then
                            Dim i As Integer
                            While ctrl.Text(i) <> "x"
                                If ctrl.Text(i) <> "x" Then
                                    quant += ctrl.Text(i)
                                End If
                                i += 1
                            End While
                            j = 0
                            ctrl.Text = quant & "x " & lb.Text & "-" & valfin & " €"
                        End If
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub prod_click(sender As Object, e As EventArgs)
        Dim panel As Panel = Nothing
        Dim lbpreco As Label = Nothing
        Dim lb As Label = Nothing
        Dim icon As New FontAwesome.Sharp.IconPictureBox
        For Each ctrl As Control In panelprods.Controls
            For Each ctrls As Control In ctrl.Controls
                If sender.Equals(ctrls) Then
                    panel = ctrl
                End If
            Next
        Next
        For Each ctrl As Control In panel.Controls
            If ctrl.Name.Contains("lbpreco") Then
                lbpreco = ctrl
            ElseIf ctrl.Name.Contains("lb") Then
                lb = ctrl
            ElseIf ctrl.Name.Contains("IconEdit") Then
                icon = ctrl
            End If
        Next
        prodclick(lb, lbpreco, icon)
    End Sub
    Private Sub botaoremov_click(sender As Object, e As EventArgs)
        Dim y As Integer
        Dim preco As String = ""
        For Each ctrl As Control In panelprod.Controls
            If sender.Equals(ctrl) Then
                y = Val(ctrl.Location.Y.ToString)
                panelprod.Controls.Remove(ctrl)
            End If
        Next
        For Each ctrl As Control In panelprod.Controls
            If ctrl.GetType.ToString = "System.Windows.Forms.Label" Then
                Dim i As Integer
                quant = Nothing
                If y = Val(ctrl.Location.Y.ToString) Then
                    While ctrl.Text(i) <> "x"
                        If ctrl.Text(i) <> "x" Then
                            quant += ctrl.Text(i)
                        End If
                        i += 1
                    End While
                    While ctrl.Text(i) <> "-"
                        i += 1
                    End While
                    i += 1
                    While ctrl.Text(i) <> "€"
                        preco += ctrl.Text(i)
                        i += 1
                    End While
                    y = Val(ctrl.Location.Y.ToString)
                    panelprod.Controls.Remove(ctrl)
                    Exit For
                End If
            End If
        Next
        lbpreco.Text = Val(lbpreco.Text) - (Val(preco) * Val(quant)) & "€"
        For Each ctrl As Control In panelprod.Controls
            If y < ctrl.Location.Y.ToString Then
                ctrl.Location = New Point(ctrl.Location.X.ToString, Val(ctrl.Location.Y.ToString) - 90)
            End If
        Next
        y = Nothing
        quant = Nothing
        For Each ctrl As Control In Me.Controls
            If ctrl.GetType.ToString = "System.Windows.Forms.Panel" Then
                If ctrl.Contains(lb5) Then
                    For Each contr As Control In ctrl.Controls
                        If contr.Name.Contains("lbpreco") Then
                            MessageBox.Show("labelpreco: " & contr.Name)
                        ElseIf contr.Name.Contains("lb") Then
                            MessageBox.Show("label: " & contr.Name)
                        End If
                    Next
                End If
            End If
        Next
    End Sub
    Private Sub lbpreco_Click(sender As Object, e As EventArgs) Handles lbpreco.TextChanged

    End Sub
    Private Sub btnAdic_Click(sender As Object, e As EventArgs) Handles btnAdic.Click
        FormAddProd.Show()
    End Sub

    Private Sub btnpagamento_Click(sender As Object, e As EventArgs) Handles btnPagamento.Click
        FormPagamento.Show()
        FormPagamento.lbval.Text = valpagar
        For Each label As Label In panelprod.Controls
            FormPagamento.panelresumo.Controls.Add(label)
        Next
    End Sub
End Class