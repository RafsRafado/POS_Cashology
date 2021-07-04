Imports FontAwesome.Sharp
Imports MySql.Data.MySqlClient
Imports System.Net.Sockets
Imports System.Net
Imports System.IO
Imports System.Text
Public Class FormRemoverProduto
    Dim con As New MySqlConnection("server=" & mysql.server & ";user=" & mysql.user & ";password=" & mysql.password & ";database=" & mysql.database & "")
    Dim cmd As New MySqlCommand
    Dim sda As New MySqlDataAdapter
    Dim DT As New DataTable
    Dim data, i, tipopedido As Integer

    Private Sub lvProds_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvProds.SelectedIndexChanged
        If lvProds.SelectedItems.Count > 0 Then
            BtnRemover.Enabled = True
        Else
            BtnRemover.Enabled = False
        End If
    End Sub
    Private Sub LvApagar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvApagar.SelectedIndexChanged
        If LvApagar.SelectedItems.Count > 0 Then
            BtnUndo.Enabled = True
        Else
            BtnUndo.Enabled = False
        End If
    End Sub

    Private Sub BtnRemover_Click(sender As Object, e As EventArgs) Handles BtnRemover.Click
        For i = 0 To lvProds.SelectedItems.Count - 1
            Dim item As ListViewItem = lvProds.SelectedItems(i)
            lvProds.Items.Remove(item)
            LvApagar.Items.Add(item)
        Next
        btnAplicar.Enabled = True
    End Sub

    Private Sub BtnUndo_Click(sender As Object, e As EventArgs) Handles BtnUndo.Click
        For i = 0 To LvApagar.SelectedItems.Count - 1
            Dim item As ListViewItem = LvApagar.SelectedItems(i)
            LvApagar.Items.Remove(item)
            lvProds.Items.Add(item)
        Next
        If LvApagar.Items.Count = 0 Then
            btnAplicar.Enabled = False
        End If
    End Sub

    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        Dim resultado As DialogResult = MessageBox.Show("Tem a certeza que quer apagar estes produtos?", "Verificação", MessageBoxButtons.YesNo)
        If resultado = DialogResult.No Then
            Exit Sub
        ElseIf resultado = DialogResult.Yes Then
            For i = 0 To LvApagar.Items.Count - 1
                Select Case LvApagar.Items(0).SubItems(2).Text
                    Case "Menu"
                        tipopedido = 1
                    Case "Bebidas"
                        tipopedido = 2
                    Case "Pratos"
                        tipopedido = 3
                    Case "Lanche"
                        tipopedido = 4
                End Select
                Try
                    Dim cmd As New MySqlCommand
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "DELETE FROM pedido WHERE nome = '" & LvApagar.Items(i).Text & "' AND idPedido = " & tipopedido
                    cmd.Connection = con
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Ocorreu um erro ao tentar comunicar com a base de dados.")
                    Exit Sub
                End Try
            Next
            LvApagar.Items.Clear()
            MessageBox.Show("Produtos apagados com suce")
        End If
    End Sub

    Private Sub FormRemoverProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT nome,preco,tipopedidos.tipopedido FROM pedido,tipopedidos where tipopedidos.idpedido=pedido.idpedido"
        sda = New MySqlDataAdapter(cmd.CommandText, con)
        data = sda.Fill(DT)
        For Each col As DataColumn In DT.Columns
            lvProds.Columns.Add(col.ToString, 140)
            LvApagar.Columns.Add(col.ToString, 140)
        Next

        For Each row As DataRow In DT.Rows
            Dim lst As ListViewItem = lvProds.Items.Add(If(row(0) IsNot Nothing, row(0).ToString, String.Empty))

            For i As Integer = 1 To DT.Columns.Count - 1
                lst.SubItems.Add(If(row(i) IsNot Nothing, row(i).ToString, String.Empty))
            Next
        Next
    End Sub
End Class