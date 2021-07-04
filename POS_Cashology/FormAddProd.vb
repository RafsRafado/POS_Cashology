Imports FontAwesome.Sharp
Imports MySql.Data.MySqlClient
Imports System.Net.Sockets
Imports System.Net
Imports System.IO
Imports System.Text
Public Class FormAddProd
    Private mprcTabTip As Process
    Dim con As New MySqlConnection("server=" & mysql.server & ";user=" & mysql.user & ";password=" & mysql.password & ";database=" & mysql.database & "")
    Dim cmd As New MySqlCommand
    Dim sda As New MySqlDataAdapter
    Dim DT As New DataTable
    Dim data, CPA, porta, fcs As Integer
    Dim p() As Process

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
            txtNomeProd.Focus()
        Else
            txtPreco.Focus()
        End If
        If mprcTabTip Is Nothing OrElse mprcTabTip.HasExited Then
            If mprcTabTip IsNot Nothing AndAlso mprcTabTip.HasExited Then
                mprcTabTip.Close()
            End If
            mprcTabTip = Process.Start("C:\Program Files\Common Files\microsoft shared\ink\TabTip.exe")
        End If
    End Sub

    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        If txtNomeProd.Text = "" Then
            MessageBox.Show("Por favor insira o nome do produto.")
            txtNomeProd.Focus()
            Exit Sub
        ElseIf txtPreco.Text = "" Then
            MessageBox.Show("Por favor insira o preço do produto.")
            txtPreco.Focus()
            Exit Sub
        End If
        Dim resultado As DialogResult = MessageBox.Show("Tem a certeza que quer adicionar este produto?", "Verificação", MessageBoxButtons.YesNo)
        If resultado = DialogResult.No Then
            Exit Sub
        ElseIf resultado = DialogResult.Yes Then
            Dim sql As String
            Try
                sql = "INSERT INTO pedido(idpedido, Nome, Preco) VALUES (@idp, @nome, @preco)"
                With cmd
                    .Connection = con
                    .CommandText = sql
                    .Parameters.AddWithValue("@idp", ComboBox1.SelectedIndex + 1)
                    .Parameters.AddWithValue("@nome", txtNomeProd.Text)
                    .Parameters.AddWithValue("@preco", Convert.ToInt32(txtPreco.Text))
                End With
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
                MessageBox.Show("Produto adicionado com sucesso!", "Aviso")
            Catch ex As Exception
                cmd.Parameters.Clear()
                MessageBox.Show("Ocorreu um erro ao tentar comunicar com a base de dados, tente novamente mais tarde.", "Aviso")
            End Try
        End If
    End Sub

    Private Sub txtPreco_TextChanged(sender As Object, e As EventArgs) Handles txtPreco.TextChanged
        If txtPreco.Text.Length = 0 Then
            Exit Sub
        End If
        Try
            Convert.ToInt32(txtPreco.Text)
        Catch ex As Exception
            txtPreco.Text = txtPreco.Text.Remove(txtPreco.Text.Length - 1)
        End Try
    End Sub


    Private Sub txtNomeProd_focus(sender As Object, e As EventArgs) Handles txtNomeProd.GotFocus
        fcs = 0
    End Sub
    Private Sub txtPreco_focus(sender As Object, e As EventArgs) Handles txtPreco.GotFocus
        fcs = 1
    End Sub
    Private Sub FormAddProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con.Open()
        Catch ex As Exception
            MessageBox.Show("Erro de conexão com a base de dados. Contacte um administrador.")
            Exit Sub
        End Try
        'Dim cmd As New MySqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * from tipopedidos"
        sda = New MySqlDataAdapter(cmd.CommandText, con)
        DT = New DataTable
        data = sda.Fill(DT)
        For i = 0 To data - 1
            ComboBox1.Items.Add(DT.Rows(i)(1))
        Next
        ComboBox1.SelectedIndex = 0
    End Sub
End Class