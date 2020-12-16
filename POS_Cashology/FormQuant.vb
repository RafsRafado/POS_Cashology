Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class FormQuant
    Dim i As Integer = 0
    Private Sub FormQuant_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        lb1cS.Text = FormInicio.quantd(0, 0)
        lb1cR.Text = FormInicio.quantd(0, 1)
        lb2cS.Text = FormInicio.quantd(1, 0)
        lb2cR.Text = FormInicio.quantd(1, 1)
        lb5cS.Text = FormInicio.quantd(2, 0)
        lb5cR.Text = FormInicio.quantd(2, 1)
        lb10cS.Text = FormInicio.quantd(3, 0)
        lb10cR.Text = FormInicio.quantd(3, 1)
        lb20cS.Text = FormInicio.quantd(4, 0)
        lb20cR.Text = FormInicio.quantd(4, 1)
        lb50cS.Text = FormInicio.quantd(5, 0)
        lb50cR.Text = FormInicio.quantd(5, 1)
        lb1eS.Text = FormInicio.quantd(6, 0)
        lb1eR.Text = FormInicio.quantd(6, 1)
        lb2eS.Text = FormInicio.quantd(7, 0)
        lb2eR.Text = FormInicio.quantd(7, 1)
        lb5eS.Text = FormInicio.quantd(8, 0)
        lb5eR.Text = FormInicio.quantd(8, 1)
        lb10eS.Text = FormInicio.quantd(9, 0)
        lb10eR.Text = FormInicio.quantd(9, 1)
        lb20eS.Text = FormInicio.quantd(10, 0)
        lb20eR.Text = FormInicio.quantd(10, 1)
        lb50eS.Text = FormInicio.quantd(11, 0)
        lb50eR.Text = FormInicio.quantd(11, 1)
        lb100eS.Text = FormInicio.quantd(12, 0)
        lb100eR.Text = FormInicio.quantd(12, 1)
        lb200eS.Text = FormInicio.quantd(13, 0)
        lb200eR.Text = FormInicio.quantd(13, 1)
        lb500eS.Text = FormInicio.quantd(14, 0)
        lb500eR.Text = FormInicio.quantd(14, 1)
        Try
            FormInicio.Enviar("#T#")
            Threading.Thread.Sleep(250)
            FormInicio.receberdata()
        Catch ex As Exception
            MessageBox.Show("Erro ao enviar a mensagem tente novamente mais tarde", "Erro de Envio.")
            Exit Sub
        End Try
        Try
            If FormInicio.mensagem.Contains("WR:BUSY") Then
                MessageBox.Show("A caixa está ocupada aguarda um momento.", "Maquina Ocupada")
            ElseIf FormInicio.mensagem.Contains("ER:") Then
                MessageBox.Show("Ocorreu um erro ao tentar efetuar a mensagem", FormInicio.mensagem)
                Exit Sub
            End If
            Dim j As Integer
            j = 1
            While FormInicio.mensagem(j) <> "#"
                j += 1
            End While
            FormInicio.mensagem = FormInicio.mensagem.Remove(0, j)
            j = 0
            While FormInicio.mensagem(j) <> "#"
                j += 1
            End While
            Dim VlorRecicladores As String = ""
            Dim VlorStacker As String = ""
            For i = 0 To j - 1
                VlorStacker += FormInicio.mensagem(i)
            Next
            For i = j + 1 To FormInicio.mensagem.Length - 3
                VlorRecicladores += FormInicio.mensagem(i)
            Next
            Dim vlorRecicladoresint, vlorstackerint As Decimal
            vlorRecicladoresint = Val(VlorRecicladores) / 100
            vlorstackerint = Val(VlorStacker) / 100
            lbtotal.Text = "TOTAL: " & vlorRecicladoresint + vlorstackerint & "€"
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("Erro ao ler a mensagem tente novamente mais tarde", "Erro de Leitura.")
        End Try
        FormInicio.mensagem = ""
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class