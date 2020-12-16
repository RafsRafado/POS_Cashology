<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnHist = New FontAwesome.Sharp.IconButton()
        Me.btnConfig = New FontAwesome.Sharp.IconButton()
        Me.btnBalDiar = New FontAwesome.Sharp.IconButton()
        Me.btnQuant = New FontAwesome.Sharp.IconButton()
        Me.btnPedido = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.imgHome = New System.Windows.Forms.PictureBox()
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbhoras = New System.Windows.Forms.Label()
        Me.btnAbrirMenu = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.lbTituloForm = New System.Windows.Forms.Label()
        Me.iconformatual = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.pblogoini = New System.Windows.Forms.PictureBox()
        Me.lbstatus = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitulo.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconformatual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.pblogoini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnHist)
        Me.PanelMenu.Controls.Add(Me.btnConfig)
        Me.PanelMenu.Controls.Add(Me.btnBalDiar)
        Me.PanelMenu.Controls.Add(Me.btnQuant)
        Me.PanelMenu.Controls.Add(Me.btnPedido)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 661)
        Me.PanelMenu.TabIndex = 0
        '
        'btnHist
        '
        Me.btnHist.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnHist.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHist.Enabled = False
        Me.btnHist.FlatAppearance.BorderSize = 0
        Me.btnHist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHist.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnHist.IconChar = FontAwesome.Sharp.IconChar.History
        Me.btnHist.IconColor = System.Drawing.Color.Gainsboro
        Me.btnHist.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnHist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHist.Location = New System.Drawing.Point(0, 468)
        Me.btnHist.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnHist.Name = "btnHist"
        Me.btnHist.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.btnHist.Size = New System.Drawing.Size(220, 74)
        Me.btnHist.TabIndex = 6
        Me.btnHist.Text = "Histórico Vendas"
        Me.btnHist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHist.UseVisualStyleBackColor = True
        '
        'btnConfig
        '
        Me.btnConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnConfig.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConfig.Enabled = False
        Me.btnConfig.FlatAppearance.BorderSize = 0
        Me.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfig.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnConfig.IconChar = FontAwesome.Sharp.IconChar.Tools
        Me.btnConfig.IconColor = System.Drawing.Color.Gainsboro
        Me.btnConfig.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfig.Location = New System.Drawing.Point(0, 394)
        Me.btnConfig.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.btnConfig.Size = New System.Drawing.Size(220, 74)
        Me.btnConfig.TabIndex = 5
        Me.btnConfig.Text = "Configurações"
        Me.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfig.UseVisualStyleBackColor = True
        '
        'btnBalDiar
        '
        Me.btnBalDiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBalDiar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBalDiar.Enabled = False
        Me.btnBalDiar.FlatAppearance.BorderSize = 0
        Me.btnBalDiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBalDiar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnBalDiar.IconChar = FontAwesome.Sharp.IconChar.BalanceScale
        Me.btnBalDiar.IconColor = System.Drawing.Color.Gainsboro
        Me.btnBalDiar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBalDiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBalDiar.Location = New System.Drawing.Point(0, 320)
        Me.btnBalDiar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBalDiar.Name = "btnBalDiar"
        Me.btnBalDiar.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.btnBalDiar.Size = New System.Drawing.Size(220, 74)
        Me.btnBalDiar.TabIndex = 4
        Me.btnBalDiar.Text = "Balanço Diário"
        Me.btnBalDiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBalDiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBalDiar.UseVisualStyleBackColor = True
        '
        'btnQuant
        '
        Me.btnQuant.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnQuant.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnQuant.Enabled = False
        Me.btnQuant.FlatAppearance.BorderSize = 0
        Me.btnQuant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuant.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnQuant.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt
        Me.btnQuant.IconColor = System.Drawing.Color.Gainsboro
        Me.btnQuant.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnQuant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuant.Location = New System.Drawing.Point(0, 246)
        Me.btnQuant.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnQuant.Name = "btnQuant"
        Me.btnQuant.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.btnQuant.Size = New System.Drawing.Size(220, 74)
        Me.btnQuant.TabIndex = 3
        Me.btnQuant.Text = "Quantidades"
        Me.btnQuant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnQuant.UseVisualStyleBackColor = True
        '
        'btnPedido
        '
        Me.btnPedido.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPedido.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPedido.Enabled = False
        Me.btnPedido.FlatAppearance.BorderSize = 0
        Me.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPedido.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnPedido.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd
        Me.btnPedido.IconColor = System.Drawing.Color.Gainsboro
        Me.btnPedido.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPedido.Location = New System.Drawing.Point(0, 172)
        Me.btnPedido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPedido.Name = "btnPedido"
        Me.btnPedido.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.btnPedido.Size = New System.Drawing.Size(220, 74)
        Me.btnPedido.TabIndex = 2
        Me.btnPedido.Text = "Fazer Pedido"
        Me.btnPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPedido.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.imgHome)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(220, 172)
        Me.PanelLogo.TabIndex = 0
        '
        'imgHome
        '
        Me.imgHome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.imgHome.Image = Global.POS_Cashology.My.Resources.Resources.dreamid2
        Me.imgHome.Location = New System.Drawing.Point(0, 0)
        Me.imgHome.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.imgHome.Name = "imgHome"
        Me.imgHome.Size = New System.Drawing.Size(220, 172)
        Me.imgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgHome.TabIndex = 0
        Me.imgHome.TabStop = False
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelTitulo.Controls.Add(Me.PictureBox2)
        Me.PanelTitulo.Controls.Add(Me.lbhoras)
        Me.PanelTitulo.Controls.Add(Me.btnAbrirMenu)
        Me.PanelTitulo.Controls.Add(Me.IconButton1)
        Me.PanelTitulo.Controls.Add(Me.lbTituloForm)
        Me.PanelTitulo.Controls.Add(Me.iconformatual)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(220, 0)
        Me.PanelTitulo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(1179, 71)
        Me.PanelTitulo.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.Image = Global.POS_Cashology.My.Resources.Resources.dreamid__1_
        Me.PictureBox2.Location = New System.Drawing.Point(456, 6)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(161, 62)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'lbhoras
        '
        Me.lbhoras.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbhoras.AutoSize = True
        Me.lbhoras.Font = New System.Drawing.Font("Franklin Gothic Medium", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbhoras.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lbhoras.Location = New System.Drawing.Point(933, 16)
        Me.lbhoras.Name = "lbhoras"
        Me.lbhoras.Size = New System.Drawing.Size(0, 38)
        Me.lbhoras.TabIndex = 3
        '
        'btnAbrirMenu
        '
        Me.btnAbrirMenu.FlatAppearance.BorderSize = 0
        Me.btnAbrirMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbrirMenu.IconChar = FontAwesome.Sharp.IconChar.Bars
        Me.btnAbrirMenu.IconColor = System.Drawing.Color.Black
        Me.btnAbrirMenu.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAbrirMenu.IconSize = 36
        Me.btnAbrirMenu.Location = New System.Drawing.Point(16, 10)
        Me.btnAbrirMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAbrirMenu.Name = "btnAbrirMenu"
        Me.btnAbrirMenu.Size = New System.Drawing.Size(48, 44)
        Me.btnAbrirMenu.TabIndex = 1
        Me.btnAbrirMenu.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.Dock = System.Windows.Forms.DockStyle.Right
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.IconButton1.IconColor = System.Drawing.Color.DarkRed
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(1100, 0)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.IconButton1.Size = New System.Drawing.Size(79, 71)
        Me.IconButton1.TabIndex = 5
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'lbTituloForm
        '
        Me.lbTituloForm.AutoSize = True
        Me.lbTituloForm.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbTituloForm.Location = New System.Drawing.Point(132, 27)
        Me.lbTituloForm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTituloForm.Name = "lbTituloForm"
        Me.lbTituloForm.Size = New System.Drawing.Size(40, 17)
        Me.lbTituloForm.TabIndex = 1
        Me.lbTituloForm.Text = "Início"
        '
        'iconformatual
        '
        Me.iconformatual.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.iconformatual.ForeColor = System.Drawing.Color.MediumPurple
        Me.iconformatual.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.iconformatual.IconColor = System.Drawing.Color.MediumPurple
        Me.iconformatual.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconformatual.IconSize = 39
        Me.iconformatual.Location = New System.Drawing.Point(81, 15)
        Me.iconformatual.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.iconformatual.Name = "iconformatual"
        Me.iconformatual.Size = New System.Drawing.Size(43, 39)
        Me.iconformatual.TabIndex = 0
        Me.iconformatual.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelDesktop.Controls.Add(Me.pblogoini)
        Me.PanelDesktop.Controls.Add(Me.lbstatus)
        Me.PanelDesktop.Controls.Add(Me.PictureBox1)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(220, 71)
        Me.PanelDesktop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1179, 590)
        Me.PanelDesktop.TabIndex = 2
        '
        'pblogoini
        '
        Me.pblogoini.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pblogoini.Image = Global.POS_Cashology.My.Resources.Resources.dreamid__1_
        Me.pblogoini.Location = New System.Drawing.Point(285, 0)
        Me.pblogoini.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pblogoini.Name = "pblogoini"
        Me.pblogoini.Size = New System.Drawing.Size(489, 287)
        Me.pblogoini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pblogoini.TabIndex = 2
        Me.pblogoini.TabStop = False
        '
        'lbstatus
        '
        Me.lbstatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbstatus.AutoSize = True
        Me.lbstatus.Font = New System.Drawing.Font("Myanmar Text", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbstatus.Location = New System.Drawing.Point(409, 332)
        Me.lbstatus.MaximumSize = New System.Drawing.Size(500, 0)
        Me.lbstatus.Name = "lbstatus"
        Me.lbstatus.Size = New System.Drawing.Size(341, 58)
        Me.lbstatus.TabIndex = 1
        Me.lbstatus.Text = "A Carregar Aguarde."
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.POS_Cashology.My.Resources.Resources.ezgif_com_gif_maker
        Me.PictureBox1.Location = New System.Drawing.Point(339, 331)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BackgroundWorker2
        '
        Me.BackgroundWorker2.WorkerReportsProgress = True
        Me.BackgroundWorker2.WorkerSupportsCancellation = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 250
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'FormInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1399, 661)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitulo)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconformatual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        Me.PanelDesktop.PerformLayout()
        CType(Me.pblogoini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents btnPedido As FontAwesome.Sharp.IconButton
    Friend WithEvents btnBalDiar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnQuant As FontAwesome.Sharp.IconButton
    Friend WithEvents btnConfig As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents lbTituloForm As Label
    Friend WithEvents iconformatual As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAbrirMenu As FontAwesome.Sharp.IconButton
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbstatus As Label
    Friend WithEvents lbhoras As Label
    Friend WithEvents pblogoini As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnHist As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Timer2 As Timer
End Class
