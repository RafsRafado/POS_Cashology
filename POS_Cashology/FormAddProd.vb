
Public Class FormAddProd
    Public tipo As String
    Private Sub btnQ_Click(sender As Object, e As EventArgs) Handles btnQ.Click
        TextBox1.Text = TextBox1.Text + "Q"
    End Sub

    Private Sub btnW_Click(sender As Object, e As EventArgs) Handles btnW.Click
        TextBox1.Text = TextBox1.Text + "W"
    End Sub

    Private Sub btnEspaco_Click(sender As Object, e As EventArgs) Handles btnEspaco.Click
        TextBox1.Text = TextBox1.Text + " "
    End Sub

    Private Sub btnK_Click(sender As Object, e As EventArgs) Handles btnK.Click
        TextBox1.Text = TextBox1.Text + "K"
    End Sub

    Private Sub btnL_Click(sender As Object, e As EventArgs) Handles btnL.Click
        TextBox1.Text = TextBox1.Text + "L"
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        TextBox1.Text = TextBox1.Text + "B"
    End Sub

    Private Sub btnV_Click(sender As Object, e As EventArgs) Handles btnV.Click
        TextBox1.Text = TextBox1.Text + "V"
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        TextBox1.Text = TextBox1.Text + "C"
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        TextBox1.Text = TextBox1.Text + "X"
    End Sub

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        TextBox1.Text = TextBox1.Text + "F"
    End Sub

    Private Sub btnJ_Click(sender As Object, e As EventArgs) Handles btnJ.Click
        TextBox1.Text = TextBox1.Text + "J"
    End Sub

    Private Sub btnH_Click(sender As Object, e As EventArgs) Handles btnH.Click
        TextBox1.Text = TextBox1.Text + "H"
    End Sub

    Private Sub btnG_Click(sender As Object, e As EventArgs) Handles btnG.Click
        TextBox1.Text = TextBox1.Text + "G"
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        TextBox1.Text = TextBox1.Text + "D"
    End Sub

    Private Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        TextBox1.Text = TextBox1.Text + "P"
    End Sub

    Private Sub btnO_Click(sender As Object, e As EventArgs) Handles btnO.Click
        TextBox1.Text = TextBox1.Text + "O"
    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        TextBox1.Text = TextBox1.Text + "S"
    End Sub

    Private Sub btnZ_Click(sender As Object, e As EventArgs) Handles btnZ.Click
        TextBox1.Text = TextBox1.Text + "Z"
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        TextBox1.Text = TextBox1.Text + "E"
    End Sub

    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        TextBox1.Text = TextBox1.Text + "R"
    End Sub

    Private Sub btnT_Click(sender As Object, e As EventArgs) Handles btnT.Click
        TextBox1.Text = TextBox1.Text + "T"
    End Sub

    Private Sub btnY_Click(sender As Object, e As EventArgs) Handles btnY.Click
        TextBox1.Text = TextBox1.Text + "Y"
    End Sub

    Private Sub btnU_Click(sender As Object, e As EventArgs) Handles btnU.Click
        TextBox1.Text = TextBox1.Text + "U"
    End Sub

    Private Sub btnI_Click(sender As Object, e As EventArgs) Handles btnI.Click
        TextBox1.Text = TextBox1.Text + "I"
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        TextBox1.Text = TextBox1.Text + "A"
    End Sub

    Private Sub btnApagar_Click(sender As Object, e As EventArgs) Handles btnApagar.Click
        If TextBox1.Text.Length > 0 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1)
        End If
    End Sub

    Private Sub btnaddIMG_Click(sender As Object, e As EventArgs) Handles btnaddIMG.Click
        Formadicimagem.Show()
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        If Application.OpenForms().OfType(Of Formadicimagem).Any Then
            MessageBox.Show("Porfavor, clique em terminar na janela de adicionar imagem primeiro, Obrigado.", "Erro")
        Else
            Me.Close()
        End If
    End Sub

    Private Sub FormAddProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txtPreco.Text = txtPreco.Text + "6"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtPreco.Text = txtPreco.Text + "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtPreco.Text = txtPreco.Text + "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtPreco.Text = txtPreco.Text + "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtPreco.Text = txtPreco.Text + "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txtPreco.Text = txtPreco.Text + "5"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        txtPreco.Text = txtPreco.Text + "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        txtPreco.Text = txtPreco.Text + "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        txtPreco.Text = txtPreco.Text + "9"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        txtPreco.Text = txtPreco.Text + "0"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If txtPreco.Text.Length > 0 Then
            txtPreco.Text = txtPreco.Text.Remove(txtPreco.Text.Length - 1)
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim letra As String
        If txtPreco.Text <> "" Then
            letra = txtPreco.Text.Substring(txtPreco.Text.Length - 1, 1)
        Else
            txtPreco.Text = "0."
            Exit Sub
        End If
        If letra = "." Then
            MessageBox.Show("Não pode adicionar 2 ""."".")
        Else
            txtPreco.Text = txtPreco.Text + "."
        End If
    End Sub

    Private Sub txtnome_click(sender As Object, e As EventArgs) Handles TextBox1.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        If Panel2.Height > 0 Then
            For i = 50 To 0 Step -1
                Panel2.Size = New Point(Panel2.Width.ToString, i * 3.5)
            Next
        End If
        For i = 0 To 50
            Panel1.Size = New Point(Panel1.Width.ToString, i * 4.42)
        Next
    End Sub

    Private Sub txtPreco_Click(sender As Object, e As EventArgs) Handles txtPreco.Click
        BackgroundWorker2.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        If Panel1.Height > 0 Then
            For i = 50 To 0 Step -1
                Panel1.Size = New Point(Panel1.Width.ToString, i * 4.42)
            Next
        End If
        For i = 0 To 50
            Panel2.Size = New Point(Panel2.Width.ToString, i * 3.5)
        Next
    End Sub
End Class