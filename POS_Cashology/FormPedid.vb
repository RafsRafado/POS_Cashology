Imports FontAwesome.Sharp
Imports System.Net
Imports System.IO
Imports System.Text

Public Class FormPedid
    Dim btnativo As IconButton
    Private btnbordaesquerda As Panel
    Public tipo As String
    Dim pagatual As Integer = 0
    Dim npags As Integer = 0
    Dim numregistos As Integer = 0
    Dim position As Integer = 0
    Dim quant As String
    Public valpagar As Integer
    Dim dt_enable As New DataTable
    Dim idpedido As Integer
    Dim rs As New Resizer
    Dim mousepositionpr As Integer
    Dim novaquantprod As Integer
    Dim labeledit As New Label
    Dim labeleditad, txtval As Boolean
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
        carrpedidos(FormInicio.dt_menus)
        idpedido = 0
    End Sub
    Private Sub btnbebida_click(sender As Object, e As EventArgs) Handles btnBebida.Click
        desativarbotao()
        numregistos = 0
        ativarbotao(sender, RGBColors.color4)
        carrpedidos(FormInicio.dt_bebidas)
        idpedido = 1

    End Sub
    Private Sub btnprato_click(sender As Object, e As EventArgs) Handles btnPrato.Click
        desativarbotao()
        numregistos = 0
        ativarbotao(sender, RGBColors.color4)
        carrpedidos(FormInicio.dt_pratos)
        idpedido = 2

    End Sub
    Private Sub btnlanche_click(sender As Object, e As EventArgs) Handles btnLanche.Click
        desativarbotao()
        numregistos = 0
        ativarbotao(sender, RGBColors.color4)
        carrpedidos(FormInicio.dt_lanche)
        idpedido = 3
    End Sub
    Private Sub formped_load(sender As Object, e As EventArgs) Handles Me.Load
        rs.FindAllControls(Panelprods)
    End Sub
    Private Sub formpedidos_resize(sender As Object, e As EventArgs) Handles Panelprods.Resize
        If Val(FormInicio.PanelMenu.Width.ToString) = 70 Or Val(FormInicio.PanelMenu.Width.ToString) = 220 Then
            rs.ResizeAllControls(Panelprods)
        Else
            Exit Sub
        End If

    End Sub
    Private Sub FormPedidos_load(sender As Object, e As EventArgs) Handles MyBase.Shown
        btnMenu.PerformClick()
        For Each ctrl As Control In Panelprods.Controls
            If ctrl.ForeColor <> Color.Red Then
                AddHandler ctrl.Click, AddressOf prod_click
                ctrl.ForeColor = Color.White
            End If
        Next
        For Each ctrl As Control In Panel2.Controls

            If ctrl.Text <> Nothing And ctrl.Text <> "X" And ctrl.Name <> "btnPagamento" Then
                AddHandler ctrl.Click, AddressOf tecl_click
            End If
        Next
    End Sub
    Private Sub btnPagSeg_Click(sender As Object, e As EventArgs) Handles btnPagSeg.Click
        pagatual += 1
        lbPags.Text = pagatual + 1 & "/" & npags + 1
        If pagatual = npags Then
            btnPagSeg.Enabled = False
        End If
        btnPagAnt.Enabled = True
        numregistos = (62 * npags) + 1
        Select Case lbselec.Text
            Case = "MENU"
                carrpedidos(FormInicio.dt_menus)
                idpedido = 0
            Case = "BEBIDAS"
                carrpedidos(FormInicio.dt_bebidas)
                idpedido = 1
            Case = "PRATOS"
                carrpedidos(FormInicio.dt_pratos)
                idpedido = 2
            Case = "LANCHE"
                carrpedidos(FormInicio.dt_lanche)
                idpedido = 3
        End Select
    End Sub
    Private Sub btnPagAnt_Click(sender As Object, e As EventArgs) Handles btnPagAnt.Click
        btnPagSeg.Enabled = True
        pagatual -= 1
        numregistos = (62 * npags) + 1
        lbPags.Text = pagatual + 1 & "/" & npags + 1
        If pagatual = 0 Then
            btnPagAnt.Enabled = False
            numregistos = 0
        End If
        Select Case lbselec.Text
            Case = "MENU"
                carrpedidos(FormInicio.dt_menus)
                idpedido = 0
            Case = "BEBIDAS"
                carrpedidos(FormInicio.dt_bebidas)
                idpedido = 1
            Case = "PRATOS"
                carrpedidos(FormInicio.dt_pratos)
                idpedido = 2
            Case = "LANCHE"
                carrpedidos(FormInicio.dt_lanche)
                idpedido = 3
        End Select
    End Sub
    Public Sub carrpedidos(ByVal dt As DataTable)
        Dim cont As Integer = 0
        Dim btn As New Button
        dt_enable = dt
        For Each ctrl As Control In Panelprods.Controls.Cast(Of Control).OrderBy(Function(c) c.TabIndex)
            If ctrl.ForeColor = Color.Red Then
                GoTo nextt
            End If
            cont += 1
            btn = ctrl
            Carregar_Menu(cont, btn, dt)
            If btn.Text = "" Then
                For Each ctrls As Control In Panelprods.Controls
                    If ctrls.TabIndex > btn.TabIndex Then
                        ctrls.Text = ""
                    End If
                Next
                Exit Sub
            End If
nextt:
        Next
    End Sub
    Public Sub Carregar_Menu(ByVal num As Integer, ByVal button As Button, ByVal dt As DataTable)
        num -= 1
        num += numregistos
        If num = 0 Then
            pagatual = 0
            npags = 0
            If dt.Rows.Count / 62 = 0 Then
                npags = 0
            Else
                npags = (dt.Rows.Count \ 62)
            End If
            If npags > pagatual Then
                btnPagSeg.Enabled = True
            Else
                btnPagSeg.Enabled = False
            End If
        End If
        lbPags.Text = pagatual + 1 & "/" & npags + 1
        Try
            button.Text = dt.Rows(num)(0)
        Catch ex As Exception
            button.Text = Nothing
        End Try
    End Sub
    Private Sub tecl_click(sender As Object, e As EventArgs)
        If TextBox1.Enabled = True And sender.text <> "X" Then
            TextBox1.Text += sender.text
        End If
    End Sub
    Private Sub prodclick(ByVal btn As Button)
        If btn.Text <> "" Then
            Dim pos As Integer
            Dim valfin As Decimal
            Dim j As Integer
            Dim vallb As String = ""
            quant = Nothing
            valfin = dt_enable.Rows(btn.TabIndex + numregistos)(1)
            pos = 15
            For Each ctrl As Control In panelprod.Controls
                If Val(ctrl.Location.Y) >= pos Then
                    pos = Val(ctrl.Location.Y) + 90
                End If
                If ctrl.GetType.ToString = "System.Windows.Forms.Label" Then
                    If ctrl.Name = dt_enable.Rows(btn.TabIndex + numregistos)(0) & "." & idpedido Then
                        Dim i As Integer
                        While ctrl.Text(i) <> "x"
                            If ctrl.Text(i) <> "x" Then
                                quant += ctrl.Text(i)
                            End If
                            i += 1
                        End While
                        Convert.ToInt32(quant)
                        quant += 1
                        ctrl.Text = quant & "x " & btn.Text & "-" & valfin & " €"
                        If lbpreco.Text = "" Then
                            lbpreco.Text = valfin & " €"
                            valpagar = valfin
                        Else
                            While (lbpreco.Text(j) <> " ")
                                vallb += lbpreco.Text(j)
                                    j += 1
                            End While
                            lbpreco.Text = Val(valfin) + Convert.ToDecimal(vallb) & " €"
                            valpagar = valfin + Convert.ToDecimal(vallb)
                            i = 0
                            quant = 0
                        End If
                        Exit Sub
                    End If
                End If
            Next
            Dim label As New Label With
                {
                    .Text = "1x " & btn.Text & "-" & valfin & " €",
                    .Name = dt_enable.Rows(btn.TabIndex + numregistos)(0) & "." & idpedido,
                    .Location = New Point(10, pos),
                    .Font = New Font("Comic Sans MS", 17, FontStyle.Bold),
                    .ForeColor = Color.White,
                    .Height = 90,
                    .Width = panelprod.Width - 90
                }

            If lbpreco.Text = "" Then
                lbpreco.Text = valfin & " €"
                valpagar = valfin
            Else

                While (lbpreco.Text(j) <> "€")
                    vallb += lbpreco.Text(j)
                    j += 1
                End While
                lbpreco.Text = valfin + Convert.ToDecimal(vallb) & " €"
                valpagar = valfin + Convert.ToDecimal(vallb)
            End If
            'AddHandler label.Click, AddressOf labeledit_click
            panelprod.Controls.Add(label)
            Dim botremov As New FontAwesome.Sharp.IconButton With
                    {
                .Location = New Point(panelprod.Width - 70, label.Location.Y.ToString),
                .Height = 40,
                .Width = 40,
                .IconChar = IconChar.TrashAlt,
                .FlatStyle = FlatStyle.Flat
            }
            AddHandler botremov.Click, AddressOf botaoremov_click
            panelprod.Controls.Add(botremov)
            botremov.BringToFront()
            Exit Sub
checkprod:
            valfin = dt_enable.Rows(btn.TabIndex + numregistos)(2)
            For Each ctrl As Control In panelprod.Controls
                If ctrl.GetType.ToString = "System.Windows.Forms.Label" Then
                    If ctrl.Text.Contains(btn.Text + "-" & valfin & " €") Then
                        Dim i As Integer
                        While ctrl.Text(i) <> "x"
                            If ctrl.Text(i) <> "x" Then
                                quant += ctrl.Text(i)
                            End If
                            i += 1
                        End While
                        j = 0
                        ctrl.Text = quant & "x " & btn.Text & "-" & valfin & " €"
                    End If
                End If
            Next
        Else
            Exit Sub
        End If
    End Sub
    Private Sub prod_click(sender As Object, e As EventArgs)
        Dim btn As New Button
        For Each ctrl As Control In panelprods.Controls
            If sender.Equals(ctrl) Then
                btn = ctrl
            End If
        Next
        prodclick(btn)
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
        lbpreco.Text = Val(lbpreco.Text) - (Val(preco) * Val(quant)) & " €"
        valpagar = Val(lbpreco.Text) - (Val(preco) * Val(quant))
        For Each ctrl As Control In panelprod.Controls
            If y < ctrl.Location.Y.ToString Then
                ctrl.Location = New Point(ctrl.Location.X.ToString, Val(ctrl.Location.Y.ToString) - 90)
            End If
        Next
        y = Nothing
        quant = Nothing
    End Sub
    Private Sub btnAdic_Click(sender As Object, e As EventArgs) Handles btnAdic.Click
        FormGestaoProd.Show()
    End Sub
    Private Sub btnpagamento_Click(sender As Object, e As EventArgs) Handles btnPagamento.Click
        If TextBox1.Text <> Nothing Then
            If ValidNif(TextBox1.Text) = False Then
                MessageBox.Show("Nif Invalido.", "Erro de validação")
                Exit Sub
            End If
            FormPagamento.lbNif.Text = "NIF: " + TextBox1.Text
        End If
        FormPagamento.Show()
        FormPagamento.lbval.Text = valpagar
        For Each ctrl As Control In panelprod.Controls
            If ctrl.GetType.ToString = "System.Windows.Forms.Label" Then
                Dim label As New Label With
                {
                    .Text = ctrl.Text,
                    .Name = ctrl.Name,
                    .Location = ctrl.Location,
                    .Font = ctrl.Font,
                    .Height = ctrl.Height,
                    .Width = ctrl.Width
                }
                FormPagamento.panelresumo.Controls.Add(label)
            End If
        Next

    End Sub
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        TextBox1.Clear()
    End Sub
    Private Sub Button78_Click(sender As Object, e As EventArgs) Handles Button78.Click
        If TextBox1.Text.Length >= 1 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1)
        End If
    End Sub

    Private Sub Atualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizarMenu.Click
        FormInicio.exec()
        btnativo.PerformClick()
    End Sub
    Public Shared Function ValidNif(ByVal contrib As String) As Boolean
        Dim s As String = contrib
        Dim c As Char
        Dim i, checkDigit As Integer
        If (s.Length = 9) Then
            c = s.Chars(0)
            If (c.Equals("1"c) Or c.Equals("2"c) Or c.Equals("5"c) Or c.Equals("6"c) Or c.Equals("8"c) Or c.Equals("9"c)) Then
                checkDigit = Val(c) * 9
                For i = 2 To 8
                    checkDigit += Val(s.Chars(i - 1)) * (10 - i)
                Next
                checkDigit = 11 - (checkDigit Mod 11)
                If (checkDigit >= 10) Then checkDigit = 0
                If (checkDigit = Val(s.Chars(8))) Then Return True
            End If
        End If
        Return False


    End Function
End Class