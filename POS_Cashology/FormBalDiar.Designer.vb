<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBalDiar
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.btnpaganterior1 = New FontAwesome.Sharp.IconButton()
        Me.btnpagseguinte1 = New FontAwesome.Sharp.IconButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panelbaldiar = New System.Windows.Forms.Panel()
        Me.lbdia = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GraficoVendasDiarias = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panelbaldiar.SuspendLayout()
        CType(Me.GraficoVendasDiarias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnpaganterior1
        '
        Me.btnpaganterior1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnpaganterior1.Enabled = False
        Me.btnpaganterior1.FlatAppearance.BorderSize = 0
        Me.btnpaganterior1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpaganterior1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.btnpaganterior1.IconColor = System.Drawing.Color.Coral
        Me.btnpaganterior1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnpaganterior1.IconSize = 75
        Me.btnpaganterior1.Location = New System.Drawing.Point(425, 458)
        Me.btnpaganterior1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnpaganterior1.Name = "btnpaganterior1"
        Me.btnpaganterior1.Size = New System.Drawing.Size(55, 59)
        Me.btnpaganterior1.TabIndex = 1
        Me.btnpaganterior1.UseVisualStyleBackColor = True
        '
        'btnpagseguinte1
        '
        Me.btnpagseguinte1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnpagseguinte1.Enabled = False
        Me.btnpagseguinte1.FlatAppearance.BorderSize = 0
        Me.btnpagseguinte1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpagseguinte1.IconChar = FontAwesome.Sharp.IconChar.ArrowRight
        Me.btnpagseguinte1.IconColor = System.Drawing.Color.Coral
        Me.btnpagseguinte1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnpagseguinte1.IconSize = 75
        Me.btnpagseguinte1.Location = New System.Drawing.Point(675, 458)
        Me.btnpagseguinte1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnpagseguinte1.Name = "btnpagseguinte1"
        Me.btnpagseguinte1.Size = New System.Drawing.Size(55, 59)
        Me.btnpagseguinte1.TabIndex = 0
        Me.btnpagseguinte1.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(509, 475)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.MaxDate = New Date(2080, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(2020, 10, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(151, 20)
        Me.DateTimePicker1.TabIndex = 2
        Me.DateTimePicker1.Value = New Date(2020, 10, 30, 0, 0, 0, 0)
        '
        'Panelbaldiar
        '
        Me.Panelbaldiar.Controls.Add(Me.lbdia)
        Me.Panelbaldiar.Controls.Add(Me.Label1)
        Me.Panelbaldiar.Controls.Add(Me.DateTimePicker1)
        Me.Panelbaldiar.Controls.Add(Me.btnpagseguinte1)
        Me.Panelbaldiar.Controls.Add(Me.GraficoVendasDiarias)
        Me.Panelbaldiar.Controls.Add(Me.btnpaganterior1)
        Me.Panelbaldiar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panelbaldiar.Location = New System.Drawing.Point(0, 0)
        Me.Panelbaldiar.Margin = New System.Windows.Forms.Padding(2)
        Me.Panelbaldiar.Name = "Panelbaldiar"
        Me.Panelbaldiar.Size = New System.Drawing.Size(1287, 537)
        Me.Panelbaldiar.TabIndex = 3
        '
        'lbdia
        '
        Me.lbdia.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbdia.AutoSize = True
        Me.lbdia.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbdia.ForeColor = System.Drawing.Color.White
        Me.lbdia.Location = New System.Drawing.Point(456, 53)
        Me.lbdia.Name = "lbdia"
        Me.lbdia.Size = New System.Drawing.Size(99, 42)
        Me.lbdia.TabIndex = 8
        Me.lbdia.Text = "Dia: "
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(356, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(527, 42)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Vendas Diarias (Quantidade)"
        '
        'GraficoVendasDiarias
        '
        Me.GraficoVendasDiarias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GraficoVendasDiarias.BackColor = System.Drawing.Color.Silver
        Me.GraficoVendasDiarias.BorderlineColor = System.Drawing.Color.Transparent
        Me.GraficoVendasDiarias.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight
        ChartArea1.BackColor = System.Drawing.Color.Silver
        ChartArea1.BackSecondaryColor = System.Drawing.Color.Gray
        ChartArea1.Name = "ChartArea1"
        Me.GraficoVendasDiarias.ChartAreas.Add(ChartArea1)
        Legend1.BackColor = System.Drawing.Color.Transparent
        Legend1.ForeColor = System.Drawing.Color.White
        Legend1.HeaderSeparatorColor = System.Drawing.Color.White
        Legend1.ItemColumnSeparatorColor = System.Drawing.Color.White
        Legend1.Name = "Legend1"
        Legend1.TitleBackColor = System.Drawing.Color.Tomato
        Legend1.TitleForeColor = System.Drawing.Color.White
        Legend1.TitleSeparatorColor = System.Drawing.Color.White
        Me.GraficoVendasDiarias.Legends.Add(Legend1)
        Me.GraficoVendasDiarias.Location = New System.Drawing.Point(296, 111)
        Me.GraficoVendasDiarias.Margin = New System.Windows.Forms.Padding(2)
        Me.GraficoVendasDiarias.Name = "GraficoVendasDiarias"
        Me.GraficoVendasDiarias.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
        Me.GraficoVendasDiarias.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.White}
        Me.GraficoVendasDiarias.Size = New System.Drawing.Size(606, 343)
        Me.GraficoVendasDiarias.TabIndex = 0
        Me.GraficoVendasDiarias.Text = "Chart1"
        '
        'FormBalDiar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1287, 537)
        Me.Controls.Add(Me.Panelbaldiar)
        Me.Name = "FormBalDiar"
        Me.Text = "FormBalDiar"
        Me.Panelbaldiar.ResumeLayout(False)
        Me.Panelbaldiar.PerformLayout()
        CType(Me.GraficoVendasDiarias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnpagseguinte1 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnpaganterior1 As FontAwesome.Sharp.IconButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Panelbaldiar As Panel
    Friend WithEvents GraficoVendasDiarias As DataVisualization.Charting.Chart
    Friend WithEvents Label1 As Label
    Friend WithEvents lbdia As Label
End Class
