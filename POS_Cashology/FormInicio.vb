Imports FontAwesome.Sharp
Imports MySql.Data.MySqlClient
Imports System.Net.Sockets
Imports System.Net
Imports System.IO
Imports System.Text


Public Class FormInicio
    Public socket As New TcpClient
    Public bytes(10024) As Byte
    Public stream As NetworkStream
    Public ip, tempmens, xmessag, menstem, VlorRecicladores, VlorStacker As String
    Public vreceb As Integer
    Public mensagem, link As String
    Public con As New MySqlConnection("server=" & mysql.server & ";user=" & mysql.user & ";password=" & mysql.password & ";database=" & mysql.database & "")
    Public cmd, CMDquant As New MySqlCommand
    Public sda, SDAquant As New MySqlDataAdapter
    Public DT, DTquant As New DataTable
    Public Table As String = "tablequant"
    Public Data, DataQuant As Integer
    Private btnativo As IconButton
    Private btnbordaesquerda As Panel
    Private formatual As Form
    Public quantd(0, 0) As Integer
    Public Shared dt_temp, dt_pedidos, dt_pratos, dt_bebidas, dt_menus, dt_lanche As New DataTable
    Public Shared imgmenus, imgpratos, imgbebidas, imglanche As New List(Of Bitmap)
    Dim timage As Bitmap
    Dim estadomenu As String = "Abrir"
    Dim tclient As WebClient = New WebClient

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        btnbordaesquerda = New Panel()
        btnbordaesquerda.Size = New Size(7, 60)
        PanelMenu.Controls.Add(btnbordaesquerda)

        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
    End Sub

    Private Sub ativarbotao(senderbtn As Object, customcolor As Color)
        If senderbtn IsNot Nothing Then
Retry:
            Try
                btnativo = CType(senderbtn, IconButton)
                btnativo.BackColor = Color.FromArgb(37, 36, 81)
                btnativo.ForeColor = customcolor
                btnativo.IconColor = customcolor
                btnativo.TextAlign = ContentAlignment.MiddleCenter
                btnativo.ImageAlign = ContentAlignment.MiddleRight
                btnativo.TextImageRelation = TextImageRelation.TextBeforeImage


                btnbordaesquerda.BackColor = customcolor
                btnbordaesquerda.Location = New Point(0, btnativo.Location.Y)
                btnbordaesquerda.Visible = True
                btnbordaesquerda.BringToFront()


                iconformatual.IconChar = btnativo.IconChar
                iconformatual.IconColor = customcolor

            Catch ex As Exception
                GoTo Retry
            End Try

        End If
    End Sub
    Private Sub desativarbotao()
        If btnativo IsNot Nothing Then
Retr:
            Try
                btnativo.BackColor = Color.FromArgb(31, 30, 68)
                btnativo.ForeColor = Color.Gainsboro
                btnativo.IconColor = Color.Gainsboro
                btnativo.TextAlign = ContentAlignment.MiddleLeft
                btnativo.ImageAlign = ContentAlignment.MiddleLeft
                btnativo.TextImageRelation = TextImageRelation.ImageBeforeText
            Catch ex As Exception
                GoTo Retr
            End Try

        End If
    End Sub

    Private Sub abrirformulariof(formulariofilho As Form)
        If formatual IsNot Nothing Then
            formatual.Close()
        End If
        formatual = formulariofilho
        formulariofilho.TopLevel = False
        formulariofilho.FormBorderStyle = FormBorderStyle.None
        formulariofilho.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(formulariofilho)
        PanelDesktop.Tag = formulariofilho
        formulariofilho.BringToFront()
        formulariofilho.Show()
        lbTituloForm.Text = btnativo.Text

    End Sub

    Private Sub btnPedido_Click(sender As Object, e As EventArgs) Handles btnPedido.Click
        ativarbotao(sender, RGBColors.color6)
        abrirformulariof(New FormPedidos)
    End Sub
    Private Sub btnPedido_sair(sender As Object, e As EventArgs) Handles btnPedido.Leave
        desativarbotao()
    End Sub

    Private Sub btnQuant_Click(sender As Object, e As EventArgs) Handles btnQuant.Click
        ativarbotao(sender, RGBColors.color2)
        abrirformulariof(New FormQuant)
    End Sub
    Private Sub btnQuant_sair(sender As Object, e As EventArgs) Handles btnQuant.Leave
        desativarbotao()
    End Sub

    Private Sub btnBalDiar_Click(sender As Object, e As EventArgs) Handles btnBalDiar.Click
        ativarbotao(sender, RGBColors.color3)
        abrirformulariof(New FormBalDiar)
    End Sub
    Private Sub btnBalDiar_sair(sender As Object, e As EventArgs) Handles btnBalDiar.Leave
        desativarbotao()
    End Sub

    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        ativarbotao(sender, RGBColors.color4)
        abrirformulariof(New FormConfig)
    End Sub
    Private Sub btnConfig_sair(sender As Object, e As EventArgs) Handles btnConfig.Leave
        desativarbotao()
    End Sub
    Private Sub btnHist_Click(sender As Object, e As EventArgs) Handles btnHist.Click
        ativarbotao(sender, RGBColors.color3)
        abrirformulariof(New FormHistVendas)
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If estadomenu = "Abrir" Then
            If PanelMenu.Width < 220 Then
                PanelMenu.Width += 10
                PanelLogo.Height += 3.6
            Else
                atribnomemenu()
                estadomenu = "Fechar"
                Timer2.Stop()
            End If
        Else
            If PanelMenu.Width > 70 Then
                If PanelMenu.Width = 220 Then
                    desatnomemenu()
                End If
                PanelMenu.Width -= 10
                PanelLogo.Height -= 3.6
            Else
                estadomenu = "Abrir"
                Timer2.Stop()
            End If

        End If
    End Sub

    Private Sub btnmenuenabled()
        btnPedido.Enabled = True
        btnQuant.Enabled = True
        btnBalDiar.Enabled = True
        btnConfig.Enabled = True
        btnHist.Enabled = True
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs)
        ativarbotao(sender, RGBColors.color3)
        abrirformulariof(New FormPedidos)
    End Sub

    Private Sub btnHist_sair(sender As Object, e As EventArgs) Handles btnHist.Leave
        desativarbotao()
    End Sub
    Private Sub imgHome_Click(sender As Object, e As EventArgs) Handles imgHome.Click
        If formatual IsNot Nothing Then
            formatual.Close()
        End If
        Reset()
    End Sub
    Private Sub Reset()
        desativarbotao()
        btnbordaesquerda.Visible = False
        iconformatual.IconChar = IconChar.Home
        iconformatual.IconColor = Color.MediumPurple
        lbTituloForm.Text = "Início"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbhoras.Text = Format(Now, "dd-MM-yyyy HH:mm:ss")
    End Sub


    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Application.Exit()
    End Sub
    Private Sub panelmenu_resize(sender As Object, e As EventArgs) Handles PanelMenu.Resize

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAbrirMenu.Select()
        desatnomemenu()
        PanelMenu.Width = 70
        PanelLogo.Height = 55
        ReDim quantd(14, 1)
        Control.CheckForIllegalCrossThreadCalls = False
        BackgroundWorker2.RunWorkerAsync()

    End Sub
    Private Sub desatnomemenu()
        btnPedido.Text = ""
        btnQuant.Text = ""
        btnBalDiar.Text = ""
        btnConfig.Text = ""
        btnHist.Text = ""
    End Sub
    Private Sub atribnomemenu()
        btnPedido.Text = "Fazer Pedido"
        btnQuant.Text = "Quantidades"
        btnBalDiar.Text = "Balanço Diário"
        btnConfig.Text = "Configurações"
        btnHist.Text = "Histórico Vendas"
    End Sub

    Private Sub btnAbrirMenu_Click(sender As Object, e As EventArgs) Handles btnAbrirMenu.Click
        Timer2.Start()
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
Recon:
        Try
            con.Open()
        Catch ex As Exception
            lbstatus.Text = "Erro de conexão com a base de dados. Contacte um administrador."
            PictureBox1.Image = My.Resources.iconfinder_Error_381599
            GoTo Recon
            Exit Sub
        End Try
        Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM config", con)
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * from config"
        sda = New MySqlDataAdapter(cmd.CommandText, con)
        DT = New DataTable
        Data = sda.Fill(DT)
        Try
            GoTo repeatp
            socket.Connect(DT.Rows(0)(0), DT.Rows(0)(1))
            stream = socket.GetStream
            Enviar("#T#")
            receberdata()
            While mensagem = ""
                wait(0.25)
            receberdata()
            End While
            If Not mensagem.Contains("ER:") Then
                GoTo Endcon
            End If
            mensagem = ""
            Enviar("#I#")
            wait(0.25)
            receberdata()
            While mensagem = ""
                wait(0.1)
            receberdata()
            End While
            If mensagem.Contains("ER:") Then
                lbstatus.Text = "Ocorreu um erro ao conectar com a máquina"
                PictureBox1.Image = My.Resources.iconfinder_Error_381599
                Exit Sub
            End If
            MessageBox.Show("3")
Endcon:
            lbstatus.Text = "Conectado com sucesso."
            PictureBox1.Image = My.Resources.green_checkmarck
        Catch ex As Exception
            lbstatus.Text = "Ocorreu um erro ao tentar conectar com a máquina."
            PictureBox1.Image = My.Resources.iconfinder_Error_381599
            Exit Sub
        End Try
repeatq:
        Try
            quant(1, 0)
            quant(2, 1)
            quant(5, 2)
            quant(10, 3)
            quant(20, 4)
            quant(50, 5)
            quant(100, 6)
            quant(200, 7)
            quant(500, 8)
            quant(1000, 9)
            quant(2000, 10)
            quant(5000, 11)
            quant(10000, 12)
            quant(20000, 13)
            quant(50000, 14)
        Catch ex As Exception
            'GoTo repeatq
        End Try
repeatp:
        Try
            Pedidos("Menu", dt_menus)
            Pedidos("Bebidas", dt_bebidas)
            Pedidos("Pratos", dt_pratos)
            Pedidos("Lanche", dt_lanche)
        Catch ex As Exception
            GoTo repeatp
        End Try
        guardimgs(dt_menus, imgmenus)
        guardimgs(dt_bebidas, imgbebidas)
        guardimgs(dt_pratos, imgpratos)
        guardimgs(dt_lanche, imglanche)
        lbstatus.Text = ""
        PictureBox1.Image = Nothing
        btnmenuenabled()

    End Sub
    Private Sub guardimgs(ByVal dt As DataTable, ByVal bitmaplist As List(Of Bitmap))
        For Each row As DataRow In dt.Rows
            Try
                link = row("imagem")
                timage = Bitmap.FromStream(New MemoryStream(tclient.DownloadData(link)))
                bitmaplist.Add(timage)
            Catch ex As Exception
                Continue For
            End Try
        Next
    End Sub
    Private Sub quant(ByVal num As Integer, ByVal pos As Integer)
qret:
        Try
reciclvl:
            mensagem = ""
            Enviar("#X#" & num & "#")
            receberdata()
            While mensagem = ""
                wait(0.025)
                receberdata()
            End While
            VlorRecicladores = 0
            VlorStacker = 0
            Dim j, i As Integer
            If mensagem.Contains("WR:BUSY") Then
                MessageBox.Show("A caixa está ocupada aguarda um momento.", "Maquina Ocupada")
            ElseIf mensagem.Contains("ER:") Then
                MessageBox.Show("Ocorreu um erro ao tentar efetuar a mensagem", mensagem)
                Exit Sub
            End If
            j = 1
            If mensagem.Contains("WR") Then
                j = 1
                While mensagem(j) <> "#"
                    j += 1
                End While
                mensagem = mensagem.Remove(0, j + 1)
                j = 1
            End If
            While mensagem(j) <> "#"
                j += 1
            End While
            VlorRecicladores = ""
            VlorStacker = ""
            For i = 0 To j - 1
                VlorRecicladores += mensagem(i)
            Next
            If VlorRecicladores.Contains("#") Then
                VlorRecicladores = ""
                GoTo reciclvl
            End If
            For i = j + 2 To mensagem.Length - 2
                VlorStacker += mensagem(i)
            Next
            If VlorStacker.Contains("#") Then
                VlorStacker = ""
                GoTo reciclvl
            End If
            If VlorStacker = "" Then
                VlorStacker = 0
            End If
            If VlorRecicladores = "" Then
                VlorRecicladores = 0
            End If
            quantd(pos, 0) = VlorStacker
            quantd(pos, 1) = VlorRecicladores
            Exit Sub
        Catch ex As Exception
            GoTo qret
        End Try

    End Sub
    Public Sub Pedidos(ByVal tipo As String, dt As DataTable)
pedrep:
        Try
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT nome,imagem,preco FROM pedidos_" & tipo
            sda = New MySqlDataAdapter(cmd.CommandText, con)
            Data = sda.Fill(dt)
        Catch ex As Exception
            GoTo pedrep
        End Try
    End Sub

    Private Sub wait(ByVal segundos As Integer)
        For i As Integer = 0 To segundos * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub
    Public Sub exec()
        dt_menus.Clear()
        dt_bebidas.Clear()
        dt_pratos.Clear()
        dt_lanche.Clear()
        Pedidos("Menu", dt_menus)
        Pedidos("Bebidas", dt_bebidas)
        Pedidos("Pratos", dt_pratos)
        Pedidos("Lanche", dt_lanche)
    End Sub
    Public Sub Enviar(ByVal msg As String)
err:
        Try
            Dim serverStream As NetworkStream = socket.GetStream()
            Dim byt_a_enviar() As Byte = System.Text.Encoding.ASCII.GetBytes(msg)
            socket.Client.Send(byt_a_enviar, 0, byt_a_enviar.Length, SocketFlags.None)
        Catch ex As Exception
            wait(0.25)
            GoTo err
        End Try

    End Sub
    Public Sub receberdata()
        mensagem = ""
        If Not (socket.Connected AndAlso stream.DataAvailable) Then
            Return
        End If
        Dim bytes As Byte() = New [Byte](2047) {}
        Dim i As Integer
        While socket.Connected AndAlso stream.DataAvailable
            i = stream.Read(bytes, 0, bytes.Length)
            mensagem += System.Text.Encoding.ASCII.GetString(bytes, 0, i)
        End While
        tempmens = mensagem
    End Sub
End Class


Public Structure RGBColors
    Public Shared color1 As Color = Color.FromArgb(172, 126, 241)
    Public Shared color2 As Color = Color.FromArgb(249, 118, 176)
    Public Shared color3 As Color = Color.FromArgb(253, 138, 114)
    Public Shared color4 As Color = Color.FromArgb(95, 77, 221)
    Public Shared color5 As Color = Color.FromArgb(249, 88, 155)
    Public Shared color6 As Color = Color.FromArgb(24, 161, 251)
End Structure
