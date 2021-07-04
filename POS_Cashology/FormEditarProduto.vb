Imports FontAwesome.Sharp
Imports MySql.Data.MySqlClient
Imports System.Net.Sockets
Imports System.Net
Imports System.IO
Imports System.Text
Public Class FormEditarProduto
    Private mprcTabTip As Process
    Dim con As New MySqlConnection("server=" & mysql.server & ";user=" & mysql.user & ";password=" & mysql.password & ";database=" & mysql.database & "")
    Dim cmd As New MySqlCommand
    Dim sda, sdaprods As New MySqlDataAdapter
    Dim DT, dtprods As New DataTable
    Dim data, dataprods, i, tipopedido, fcs, idx As Integer
    Dim p() As Process

    Private Sub txtPreco_TextChanged(sender As Object, e As EventArgs) Handles txtPreco.TextChanged
        If txtPreco.Text.Length = 0 Then
            Exit Sub
        End If
        Try
            If txtPreco.Text(txtPreco.Text.Length - 1) <> "." Then
                Convert.ToInt32(txtPreco.Text(txtPreco.Text.Length - 1))
            End If
        Catch ex As Exception
            txtPreco.Text = txtPreco.Text.Remove(txtPreco.Text.Length - 1)
        End Try
    End Sub

    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        Dim resultado As DialogResult = MessageBox.Show("Tem a certeza que quer alterar este produto?", "Verificação", MessageBoxButtons.YesNo)
        If resultado = DialogResult.No Then
            Exit Sub
        ElseIf resultado = DialogResult.Yes Then
            Try
                Select Case dtprods.Rows(ComboBox2.SelectedIndex)(2)
                    Case "Menu"
                        tipopedido = 1
                    Case "Bebidas"
                        tipopedido = 2
                    Case "Pratos"
                        tipopedido = 3
                    Case "Lanche"
                        tipopedido = 4
                End Select
                Dim cmd As New MySqlCommand
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "UPDATE pedido SET nome='" & txtNomeProd.Text & "', Preco= " & txtPreco.Text & " WHERE nome = '" & dtprods.Rows(ComboBox2.SelectedIndex)(0) & "' AND idPedido= " & tipopedido
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                MessageBox.Show("Produto alterado com sucesso!")
            Catch ex As Exception
                MessageBox.Show("Ocorreu um erro ao tentar comunicar com a base de dados.")
                Exit Sub
            End Try
            produpdate()
        End If
    End Sub

    Private Sub txtPreco_gotfocus(sender As Object, e As EventArgs) Handles txtPreco.GotFocus
        fcs = 1
    End Sub

    Private Sub txtNomeProd_gotfocus(sender As Object, e As EventArgs) Handles txtNomeProd.GotFocus
        fcs = 0
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
    Private Sub produpdate()
        dtprods.Clear()
        ComboBox2.Items.Clear()
        ComboBox2.SelectedIndex = -1
        txtNomeProd.Enabled = False
        txtPreco.Enabled = False
        btnTeclado.Enabled = False
        txtNomeProd.Text = ""
        txtPreco.Text = ""
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT nome,preco,tipopedidos.tipopedido FROM pedido,tipopedidos where tipopedidos.idpedido=pedido.idpedido AND pedido.idpedido=" & ComboBox1.SelectedIndex + 1
        sdaprods = New MySqlDataAdapter(cmd.CommandText, con)
        dataprods = sdaprods.Fill(dtprods)
        If dataprods = 0 Then
            MessageBox.Show("Não existem items existentes na categoria " & ComboBox1.SelectedItem.ToString)
        Else
            For i = 0 To dataprods - 1
                ComboBox2.Items.Add(dtprods.Rows(i)(0))
            Next
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        produpdate()
    End Sub

    Private Sub FormEditarProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
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
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        txtNomeProd.Enabled = True
        txtPreco.Enabled = True
        btnTeclado.Enabled = True
        btnAplicar.Enabled = True
        txtNomeProd.Text = dtprods.Rows(ComboBox2.SelectedIndex)(0)
        txtPreco.Text = dtprods.Rows(ComboBox2.SelectedIndex)(1)
    End Sub

End Class