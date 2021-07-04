Imports System.IO
Imports System.Text
Imports System.Net
Imports MySql.Data.MySqlClient

Public Class Formadicimagem
    Public cmd, CMDquant As New MySqlCommand
    Public sda, SDAquant As New MySqlDataAdapter
    Public DT, DTquant As New DataTable
    Dim cod As String
    Dim ra As New Random

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim tClient As WebClient = New WebClient
        Dim tImage As Bitmap
Retr:
        Try
            tImage = Bitmap.FromStream(New MemoryStream(tClient.DownloadData("https://chart.googleapis.com/chart?chs=500x500&cht=qr&chl=https://upload.rafatech.pt/?cod=" & cod)))
        Catch ex As Exception
            GoTo Retr
        End Try
        pbqrc.Image = tImage

    End Sub

    Private Sub Formadicimagem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        cmd = New MySqlCommand
        cod = RandomString(ra)
        With cmd
            .CommandText = "INSERT INTO codsimg SET  cod=@cod"
            .Connection = FormInicio.con
            .Parameters.AddWithValue("@cod", cod)
            .ExecuteNonQuery()
        End With
        BackgroundWorker1.RunWorkerAsync()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTerminar.Click
        With cmd
            .CommandText = "Delete FROM codsimg WHERE cod = """ & cod & """"
            .Connection = FormInicio.con
            .ExecuteNonQuery()
        End With
        Me.Close()
    End Sub
    Function RandomString(r As Random)
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim sb As New StringBuilder
        Dim cnt As Integer = r.Next(15, 33)
        For i As Integer = 1 To cnt
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
End Class