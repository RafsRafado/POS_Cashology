Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class FormPagamento
    Dim j, i As Integer
    Dim mensagem, valrlev, sql As String
    Dim pag(4) As Integer
    Dim con As New MySqlConnection("server=" & mysql.server & ";user=" & mysql.user & ";password=" & mysql.password & ";database=" & mysql.database & "")
    Dim cmd As New MySqlCommand
    Dim sda As New MySqlDataAdapter
    Dim DT As New DataTable

    Private Sub FormPagamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con.Open()
        Catch ex As Exception
            MessageBox.Show("Erro de conexão com a base de dados. Contacte um administrador.")
            Exit Sub
        End Try
        If FormInicio.CPA = 1 Then
            FormInicio.pagamento(Val(lbval.Text))
            While FormInicio.continuarpag = Nothing Or FormInicio.continuarpag = True
                If FormInicio.continuarpag = True And TimerQuant.Enabled = False Then
                    TimerQuant.Start()
                    Exit While
                End If
            End While
        Else
            btnconcop.Enabled = True
        End If
    End Sub
    Private Sub btncancop_Click(sender As Object, e As EventArgs) Handles btncancop.Click
        Dim resultado As DialogResult = MessageBox.Show("Tem a certeza que quer cancelar a operação", "Verificação", MessageBoxButtons.YesNo)
        If resultado = DialogResult.No Then
            Exit Sub
        ElseIf resultado = DialogResult.Yes Then
            If Val(lbtxtvlrins.Text) > 0 Then
                FormInicio.Enviar("#J#")
                FormInicio.mensagem = ""
                While FormInicio.mensagem = ""
                    FormInicio.receberdata()
                    FormInicio.wait(0.05)
                End While
                FormInicio.Enviar("#P#" & Val(valrlev) * 100 & "#0#0#0#")
                While FormInicio.mensagem = ""
                    FormInicio.receberdata()
                    FormInicio.wait(0.05)
                End While
                If Not FormInicio.mensagem.Contains("ER:") Then
                    MessageBox.Show("Operação Cancelada com sucesso.")
                Else
                    MessageBox.Show("Erro ao tentar cancelar a operação, tente novamente mais tarde.")
                    Exit Sub
                End If
            End If
            Me.Close()
        End If
    End Sub

    Private Sub btnconcop_Click(sender As Object, e As EventArgs) Handles btnconcop.Click
        Dim resultado As DialogResult = MessageBox.Show("Tem a certeza que quer concluir a venda?", "Verificação", MessageBoxButtons.YesNo)
        If resultado = DialogResult.No Then
            Exit Sub
        ElseIf resultado = DialogResult.Yes Then
            For Each cntrl As Control In panelresumo.Controls
                Dim n As String = cntrl.Name
                Dim nt As String = cntrl.Text
                Dim i, j As Integer
                Dim mult As String = ""
                i = 0
                j = 0
                While nt(j) <> "x"
                    j += 1
                End While
                For i = 0 To j - 1
                    mult += nt(i)
                Next
                i = 0
                While n(i) <> "."
                    i = i + 1
                End While
                pag(Val(n(i + 1))) += 1 * mult
            Next
            pag(4) = pag(0) + pag(1) + pag(2) + pag(3)
            Dim datahoje As String
            datahoje = DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
            sql = "INSERT INTO histvendas SET  dia=@dia, VendasTotal=@vt, VendasMenu=@vm,VendasBebidas=@vb, VendasLanche=@vl, VendasPratos=@vp, Preco=@preco"
            With cmd
                .Connection = con
                .CommandText = sql
                .Parameters.AddWithValue("@dia", datahoje)
                .Parameters.AddWithValue("@vt", pag(4))
                .Parameters.AddWithValue("@vm", pag(0))
                .Parameters.AddWithValue("@vb", pag(1))
                .Parameters.AddWithValue("@vl", pag(2))
                .Parameters.AddWithValue("@vp", pag(3))
                .Parameters.AddWithValue("@preco", lbval.Text)
            End With
            cmd.ExecuteNonQuery()
            MessageBox.Show("Operação realizada com sucesso!")
            Me.Close()
        End If
    End Sub

    Private Sub TimerQuant_Tick(sender As Object, e As EventArgs) Handles TimerQuant.Tick
        mensagem = ""
        FormInicio.Enviar("#Q#")
        While FormInicio.mensagem = ""
            FormInicio.Enviar("#Q#")
            Threading.Thread.Sleep(100)
        End While
        j = 1
        While FormInicio.mensagem(j) <> "#"
            j += 1
        End While
        mensagem = FormInicio.mensagem.Remove(0, j)
        If FormInicio.mensagem.Contains("ER:") Or FormInicio.mensagem.Contains("WR:") Then
            j = 1
            While mensagem(j) <> "#"
                j += 1
            End While
            mensagem = mensagem.Remove(0, j)
        End If
        valrlev = ""
        For i = 0 To mensagem.Length - 1
            valrlev += mensagem(i)
        Next
        lbtxtvlrins.Text = Val(valrlev) / 100
        If Val(valrlev) >= Val(lbtxtvlrserpago.Text) Then
            FormInicio.Enviar("#P#" & (Val(valrlev) - Val(lbtxtvlrserpago.Text)) * 100 & "#0#0#0#")
            Threading.Thread.Sleep(50)
            FormInicio.receberdata()
            FormInicio.Enviar("#J#")
            MessageBox.Show("Pagamento Concluido")
            btnconcop.Enabled = True
            btncancop.Enabled = False
            TimerQuant.Stop()
        End If
    End Sub
End Class