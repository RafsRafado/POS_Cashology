Imports FontAwesome.Sharp
Imports System.Net
Imports System.IO
Imports System.Text

Public Class FormPedidos
    Dim btnativo As IconButton
    Private btnbordaesquerda As Panel
    Public tipo As String
    Dim pagatual As Integer = 1
    Dim npags As Integer = 1
    Dim numregistos As Integer = 0
    Dim position As Integer = 0
    Dim quant As String
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
    Private Sub FormPedidos_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        btnMenu.PerformClick()
    End Sub
    Private Sub btnPagSeg_Click(sender As Object, e As EventArgs) Handles btnPagSeg.Click
        pagatual += 1
        If pagatual = npags Then
            btnPagSeg.Enabled = False
        End If
        btnPagAnt.Enabled = True
        numregistos = (17 * npags) + 1
        Select Case lbselec.Text
            Case = "MENUS"
                loadpanels.RunWorkerAsync()
            Case = "BEBIDAS"
                loadbebidas.RunWorkerAsync()
            Case = "PRATOS"
                loadpratos.RunWorkerAsync()
            Case = "LANCHE"
                loadlanche.RunWorkerAsync()
        End Select
    End Sub

    Private Sub btnPagAnt_Click(sender As Object, e As EventArgs) Handles btnPagAnt.Click
        btnPagSeg.Enabled = True
        pagatual -= 1
        numregistos = (17 * npags) + 1
        If pagatual = 1 Then
            btnPagAnt.Enabled = False
            numregistos = 0
        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If IconButton1.Text = "Editar Nome" Then
            IconButton1.Text = "Terminar Edição"
            check(PictureBox1, IconEdit1)
            check(PictureBox2, IconEdit2)
            check(PictureBox3, IconEdit3)
            check(PictureBox4, IconEdit4)
            check(PictureBox5, IconEdit5)
            check(PictureBox6, IconEdit6)
            check(PictureBox7, IconEdit7)
            check(PictureBox8, IconEdit8)
            check(PictureBox9, IconEdit9)
            check(PictureBox10, IconEdit10)
            check(PictureBox11, IconEdit11)
            check(PictureBox12, IconEdit12)
            check(PictureBox13, IconEdit13)
            check(PictureBox14, IconEdit14)
            check(PictureBox15, IconEdit15)
            check(PictureBox16, IconEdit16)
            check(PictureBox17, IconEdit17)
            check(PictureBox18, IconEdit18)
            Panel8.Enabled = False
        ElseIf IconButton1.Text = "Terminar Edição" Then
            IconButton1.Text = "Editar Nome"
            check(PictureBox1, IconEdit1)
            check(PictureBox2, IconEdit2)
            check(PictureBox3, IconEdit3)
            check(PictureBox4, IconEdit4)
            check(PictureBox5, IconEdit5)
            check(PictureBox6, IconEdit6)
            check(PictureBox7, IconEdit7)
            check(PictureBox8, IconEdit8)
            check(PictureBox9, IconEdit9)
            check(PictureBox10, IconEdit10)
            check(PictureBox11, IconEdit11)
            check(PictureBox12, IconEdit12)
            check(PictureBox13, IconEdit13)
            check(PictureBox14, IconEdit14)
            check(PictureBox15, IconEdit15)
            check(PictureBox16, IconEdit16)
            check(PictureBox17, IconEdit17)
            check(PictureBox18, IconEdit18)
            Panel8.Enabled = True
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
        If num = 0 Then
            pagatual = 1
            npags = 1
            num += numregistos
            If img.Count / 18 = 0 Then
                npags = 1
            ElseIf img.Count / 18 <> img.Count \ 18 Then
                npags = (img.Count \ 18) + 1
            Else
                npags = img.Count \ 18
            End If
            lbPags.Text = pagatual & "/" & npags
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
        End Try
    End Sub


    Private Sub prodclick(ByVal lb As Label, lbprecoprod As Label, ByVal ip As IconPictureBox)

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
                        End If
                    End If
                Next
                If quant > 1 Then
                    quant = 0
                    Exit Sub
                End If
                Dim label As New Label With
                {
                    .Text = "1x" & lb.Text & "-" & valfin & " €",
                    .Location = New Point(10, pos),
                    .Font = New Font("Comic Sans MS", 17, FontStyle.Bold),
                    .Height = 100,
                    .Width = 289
                }
                panelprod.Controls.Add(label)
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
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        prodclick(lb1, lbpreco1, IconEdit1)
    End Sub

    Private Sub lb1_Click(sender As Object, e As EventArgs) Handles lb1.Click
        prodclick(lb1, lbpreco1, IconEdit1)
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        prodclick(lb2, lbpreco2, IconEdit2)
    End Sub
    Private Sub lb2_Click(sender As Object, e As EventArgs) Handles lb2.Click
        prodclick(lb2, lbpreco2, IconEdit2)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        prodclick(lb3, lbpreco3, IconEdit3)
    End Sub
    Private Sub lb3_Click(sender As Object, e As EventArgs) Handles lb3.Click
        prodclick(lb3, lbpreco3, IconEdit3)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        prodclick(lb4, lbpreco4, IconEdit4)
    End Sub
    Private Sub lb4_Click(sender As Object, e As EventArgs) Handles lb4.Click
        prodclick(lb4, lbpreco4, IconEdit4)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        prodclick(lb5, lbpreco5, IconEdit5)
    End Sub
    Private Sub lb5_Click(sender As Object, e As EventArgs) Handles lb5.Click
        prodclick(lb5, lbpreco5, IconEdit5)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        prodclick(lb6, lbpreco6, IconEdit6)
    End Sub
    Private Sub lb6_Click(sender As Object, e As EventArgs) Handles lb6.Click
        prodclick(lb6, lbpreco6, IconEdit6)
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        prodclick(lb7, lbpreco7, IconEdit7)
    End Sub
    Private Sub lb7_Click(sender As Object, e As EventArgs) Handles lb7.Click
        prodclick(lb7, lbpreco7, IconEdit7)
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        prodclick(lb8, lbpreco8, IconEdit8)
    End Sub
    Private Sub lb8_Click(sender As Object, e As EventArgs) Handles lb8.Click
        prodclick(lb8, lbpreco8, IconEdit8)
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        prodclick(lb9, lbpreco9, IconEdit9)
    End Sub
    Private Sub lb9_Click(sender As Object, e As EventArgs) Handles lb9.Click
        prodclick(lb9, lbpreco9, IconEdit9)
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        prodclick(lb10, lbpreco10, IconEdit10)
    End Sub
    Private Sub lb10_Click(sender As Object, e As EventArgs) Handles lb10.Click
        prodclick(lb10, lbpreco10, IconEdit10)
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        prodclick(lb11, lbpreco11, IconEdit11)
    End Sub
    Private Sub lb11_Click(sender As Object, e As EventArgs) Handles lb11.Click
        prodclick(lb11, lbpreco11, IconEdit11)
    End Sub
    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        prodclick(lb12, lbpreco12, IconEdit12)
    End Sub
    Private Sub lb12_Click(sender As Object, e As EventArgs) Handles lb12.Click
        prodclick(lb12, lbpreco12, IconEdit12)
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        prodclick(lb13, lbpreco13, IconEdit13)
    End Sub
    Private Sub lb13_Click(sender As Object, e As EventArgs) Handles lb13.Click
        prodclick(lb13, lbpreco13, IconEdit13)
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        prodclick(Lb14, lbpreco14, IconEdit14)
    End Sub
    Private Sub lb14_Click(sender As Object, e As EventArgs) Handles Lb14.Click
        prodclick(Lb14, lbpreco14, IconEdit14)
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        prodclick(Lb15, lbpreco15, IconEdit15)
    End Sub
    Private Sub lb15_Click(sender As Object, e As EventArgs) Handles Lb15.Click
        prodclick(Lb15, lbpreco15, IconEdit15)
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        prodclick(lb16, lbpreco16, IconEdit16)
    End Sub
    Private Sub lb16_Click(sender As Object, e As EventArgs) Handles lb16.Click
        prodclick(lb16, lbpreco16, IconEdit16)
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        prodclick(lb17, lbpreco17, IconEdit17)
    End Sub
    Private Sub lb17_Click(sender As Object, e As EventArgs) Handles lb17.Click
        prodclick(lb17, lbpreco17, IconEdit17)
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        prodclick(lb18, lbpreco18, IconEdit18)
    End Sub
    Private Sub lb18_Click(sender As Object, e As EventArgs) Handles lb18.Click
        prodclick(lb18, lbpreco18, IconEdit18)
    End Sub

    Private Sub btnAdic_Click(sender As Object, e As EventArgs) Handles btnAdic.Click
        FormAddProd.Show()
    End Sub
End Class