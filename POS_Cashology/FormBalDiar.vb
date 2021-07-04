Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class FormBalDiar
    Dim con As New MySqlConnection("server=" & mysql.server & ";user=" & mysql.user & ";password=" & mysql.password & ";database=" & mysql.database & "")
    Dim cmd As New MySqlCommand
    Dim sda, sdaDatas As New MySqlDataAdapter
    Dim DT, DTdatas As New DataTable
    Dim data, dataDatas, diasel As Integer

    Private Sub GraficoVendasDiarias_Click(sender As Object, e As EventArgs) Handles GraficoVendasDiarias.Click

    End Sub

    Private Sub FormBalDiar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT DISTINCT dia from histvendas ORDER BY dia DESC"
        sdaDatas = New MySqlDataAdapter(cmd.CommandText, con)
        DTdatas = New DataTable
        dataDatas = sdaDatas.Fill(DTdatas)
        If dataDatas = 0 Then
            MessageBox.Show("Não existe nenhum histórico de vendas na base de dados.")
            GraficoVendasDiarias.Visible = False
            Exit Sub
        ElseIf dataDatas > 1 Then
            btnpaganterior1.Enabled = True
        End If
        DateTimePicker1.Value = DTdatas.Rows(0)(0)
        lbdia.Text = "Dia: " + DTdatas.Rows(0)(0)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim dataselec As String
        data = 0
        dataselec = DateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
        Try
            GraficoVendasDiarias.Series.Clear()
            GraficoVendasDiarias.Series.Add("Vendas")
        Catch ex As Exception

        End Try
        Dim cmd As New MySqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT dia, SUM(VendasTotal), SUM(VendasMenu), SUM(VendasBebidas), SUM(VendasLanche), SUM(VendasPratos), SUM(preco) from histvendas where dia= '" & dataselec & "'"
        sda = New MySqlDataAdapter(cmd.CommandText, con)
        DT = New DataTable
        data = sda.Fill(DT)
        Try
            If DT.Rows(0)(1) > 10 Then
                GraficoVendasDiarias.ChartAreas("ChartArea1").AxisY.Maximum = DT.Rows(0)(1)
            Else
                GraficoVendasDiarias.ChartAreas("ChartArea1").AxisY.Maximum = 10
            End If
            GraficoVendasDiarias.Series("Vendas").Points.AddXY("Vendas Menu", DT.Rows(0)(2))
            GraficoVendasDiarias.Series("Vendas").Points.AddXY("Vendas Bebidas", DT.Rows(0)(3))
            GraficoVendasDiarias.Series("Vendas").Points.AddXY("Vendas Lanche", DT.Rows(0)(4))
            GraficoVendasDiarias.Series("Vendas").Points.AddXY("Vendas Pratos", DT.Rows(0)(5))
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btnpaganterior1_Click(sender As Object, e As EventArgs) Handles btnpaganterior1.Click
        diasel += 1
        If diasel = dataDatas - 1 Then
            btnpaganterior1.Enabled = False
        End If
        DateTimePicker1.Value = DTdatas.Rows(diasel)(0)
        lbdia.Text = "Dia: " + DTdatas.Rows(diasel)(0)
        btnpagseguinte1.Enabled = True
    End Sub

    Private Sub btnpagseguinte1_Click(sender As Object, e As EventArgs) Handles btnpagseguinte1.Click
        diasel -= 1
        If diasel = 0 Then
            btnpagseguinte1.Enabled = False
        End If
        DateTimePicker1.Value = DTdatas.Rows(diasel)(0)
        lbdia.Text = "Dia: " + DTdatas.Rows(diasel)(0)
        btnpaganterior1.Enabled = True
    End Sub
End Class