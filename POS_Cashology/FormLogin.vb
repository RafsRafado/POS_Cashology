Imports FontAwesome.Sharp
Imports MySql.Data.MySqlClient
Imports System.Net.Sockets
Imports System.Net
Imports System.IO
Imports System.Text
Public Class FormLogin
    Public con As New MySqlConnection("server=" & mysql.server & ";user=" & mysql.user & ";password=" & mysql.password & ";database=" & mysql.database & "")
    Public cmd, CMDquant As New MySqlCommand
    Public sda, SDAquant As New MySqlDataAdapter
    Public DT As New DataTable
    Dim data, i, pos, posy As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pos = 100
        posy = 10
        con.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * from utilizadores"
        sda = New MySqlDataAdapter(cmd.CommandText, con)
        DT = New DataTable
        Data = sda.Fill(DT)
        For i = 0 To DT.Rows.Count - 1
            Dim Panel As New Panel With
    {
        .Name = DT.Rows(i)(0),
        .Location = New Point(pos, posy),
        .Height = 150,
        .Width = 150,
        .BorderStyle = BorderStyle.FixedSingle
    }
            Dim LabelNome As New Label With
    {
        .Text = DT.Rows(i)(1),
        .Location = New Point(40, 50)
    }
            Dim LabelID As New Label With
    {
        .Text = DT.Rows(i)(0),
        .Location = New Point(70, 10)
    }
            PanelUtilizadores.Controls.Add(Panel)
            Panel.Controls.Add(LabelNome)
            Panel.Controls.Add(LabelID)
            pos += 250
            If pos >= PanelUtilizadores.Width.ToString - 150 Then
                pos = 100
                posy += 170
            End If
        Next
    End Sub
End Class