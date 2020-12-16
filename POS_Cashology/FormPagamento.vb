Public Class FormPagamento
    Dim j, i As Integer
    Dim mensagem, valrlev As String
    Private Sub btncancop_Click(sender As Object, e As EventArgs) Handles btncancop.Click
        If Val(lbtxtvlrins.Text) > 0 Then
            FormInicio.mensagem = ""
            FormInicio.Enviar("#P#" & Val(valrlev) * 100 & "#0#0#0#")
            While FormInicio.mensagem = ""
                FormInicio.receberdata()
            End While
        End If
        Me.Close()
    End Sub

    Private Sub btnconcop_Click(sender As Object, e As EventArgs) Handles btnconcop.Click

    End Sub

    Private Sub FormPagamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormInicio.pagamento(Val(lbval.Text))
        While FormInicio.continuarpag = Nothing
            If FormInicio.continuarpag = True And TimerQuant.Enabled = False Then
                TimerQuant.Start()
            End If
        End While

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
            TimerQuant.Stop()
        End If
    End Sub
End Class