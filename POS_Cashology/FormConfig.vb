Imports FontAwesome.Sharp
Imports MySql.Data.MySqlClient
Imports System.Net.Sockets
Imports System.Net
Imports System.IO
Imports System.Text
Public Class FormConfig
    Private mprcTabTip As Process
    Dim loc As Integer
    Dim locy As Integer
    Dim con As New MySqlConnection("server=" & mysql.server & ";user=" & mysql.user & ";password=" & mysql.password & ";database=" & mysql.database & "")
    Dim cmd As New MySqlCommand
    Dim sda As New MySqlDataAdapter
    Dim DT As New DataTable
    Dim data, CPA, porta, fcs As Integer
    Dim ip As String
    Dim p() As Process

    Private Sub FormConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        visivel("false")
        Try
            con.Open()
        Catch ex As Exception
            MessageBox.Show("Erro de conexão com a base de dados. Contacte um administrador.")
            Exit Sub
        End Try
        Dim cmd As New MySqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * from config"
        sda = New MySqlDataAdapter(cmd.CommandText, con)
        DT = New DataTable
        data = sda.Fill(DT)
        If data = 0 Then
            btnCPA.IconChar = FontAwesome.Sharp.IconChar.ToggleOff
            btnCPA.IconColor = Color.Red
            CPA = 0
            Exit Sub
        End If
        ip = DT.Rows(0)(0)
        porta = DT.Rows(0)(1)
        CPA = DT.Rows(0)(2)
        txtIP.Text = ip
        txtPorta.Text = porta
        If DT.Rows(0)(2) = 0 Then
            btnCPA.IconChar = FontAwesome.Sharp.IconChar.ToggleOff
            btnCPA.IconColor = Color.Red
        Else
            btnCPA.IconChar = FontAwesome.Sharp.IconChar.ToggleOn
            btnCPA.IconColor = Color.Green

        End If
    End Sub
    Private Sub btnCPA_Click(sender As Object, e As EventArgs) Handles btnCPA.Click
        botaocfg(btnCPA)
        If CPA = 0 Then
            CPA = 1
            visivel("true")
        Else
            CPA = 0
            visivel("false")
        End If
    End Sub
    Private Sub visivel(v As String)
        lbIP.Visible = v
        lbPorta.Visible = v
        txtIP.Visible = v
        txtPorta.Visible = v
        btnTeclado.Visible = v
    End Sub
    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        Dim resultado As DialogResult = MessageBox.Show("Tem a certeza que quer aplicar estas configurações?", "Verificação", MessageBoxButtons.YesNo)
        If resultado = DialogResult.No Then
            Exit Sub
        ElseIf resultado = DialogResult.Yes Then
            Dim sql As String
            Try
                If data = 1 Then
                    sql = "UPDATE config SET  ip=@ip, porta=@porta, CPA=@cpa"
                    With cmd
                        .Connection = con
                        .CommandText = sql
                        .Parameters.AddWithValue("@ip", txtIP.Text)
                        .Parameters.AddWithValue("@porta", txtPorta.Text)
                        .Parameters.AddWithValue("@cpa", CPA)
                    End With
                    cmd.ExecuteNonQuery()
                ElseIf data = 0 Then
insert:
                    sql = "INSERT INTO config VALUES (@ip, @porta, @cpa)"
                    With cmd
                        .Connection = con
                        .CommandText = sql
                        .Parameters.AddWithValue("@ip", txtIP.Text)
                        .Parameters.AddWithValue("@porta", txtPorta.Text)
                        .Parameters.AddWithValue("@cpa", CPA)
                    End With
                    cmd.ExecuteNonQuery()
                Else
                    Dim cmd As New MySqlCommand
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "DELETE FROM config"
                    cmd.Connection = con
                    cmd.ExecuteNonQuery()
                    GoTo insert
                End If
                cmd.Parameters.Clear()
                MessageBox.Show("Configurações guardadas com sucesso!", "Aviso")
                Dim resultado2 As DialogResult = MessageBox.Show("Para aplicar as alterações é necessário reiniciar a aplicação, deseja reiniciar?", "Verificação", MessageBoxButtons.YesNo)
                If resultado2 = DialogResult.No Then
                    Exit Sub
                ElseIf resultado2 = DialogResult.Yes Then
                    Application.Restart()
                End If
            Catch ex As Exception
                cmd.Parameters.Clear()
                MessageBox.Show("Ocorreu um erro ao tentar comunicar com a base de dados, tente novamente mais tarde.", "Aviso")
            End Try
        End If
    End Sub


    Private Sub btnTeclado_Click(sender As Object, e As EventArgs) Handles btnTeclado.Click
        p = Process.GetProcessesByName("TabTip")
        If p.Count > 0 Then
            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName = "TabTip" Then
                    prog.Kill()
                End If
            Next
        End If
        If fcs = 0 Then
            txtIP.Focus()
        Else
            txtPorta.Focus()
        End If
        If mprcTabTip Is Nothing OrElse mprcTabTip.HasExited Then
            If mprcTabTip IsNot Nothing AndAlso mprcTabTip.HasExited Then
                mprcTabTip.Close()
            End If
            mprcTabTip = Process.Start("C:\Program Files\Common Files\microsoft shared\ink\TabTip.exe")
        End If

    End Sub

    Private Sub txtIP_focus(sender As Object, e As EventArgs) Handles txtIP.GotFocus
        fcs = 0
    End Sub
    Private Sub txtporta_focus(sender As Object, e As EventArgs) Handles txtPorta.GotFocus
        fcs = 1
    End Sub
    Public Sub botaocfg(bot As IconButton)
        If bot.IconChar = FontAwesome.Sharp.IconChar.ToggleOff Then
            bot.IconChar = FontAwesome.Sharp.IconChar.ToggleOn
            bot.IconColor = Color.Green
        Else
            bot.IconChar = FontAwesome.Sharp.IconChar.ToggleOff
            bot.IconColor = Color.Red
        End If
    End Sub
End Class