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
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panelbaldiar = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IconButton2
        '
        Me.IconButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.IconButton2.IconColor = System.Drawing.Color.Coral
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 75
        Me.IconButton2.Location = New System.Drawing.Point(478, 3)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(73, 73)
        Me.IconButton2.TabIndex = 1
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowRight
        Me.IconButton1.IconColor = System.Drawing.Color.Coral
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 75
        Me.IconButton1.Location = New System.Drawing.Point(790, 3)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(73, 73)
        Me.IconButton1.TabIndex = 0
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.DateTimePicker1.Location = New System.Drawing.Point(568, 26)
        Me.DateTimePicker1.MaxDate = New Date(2020, 10, 30, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(2020, 10, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 2
        Me.DateTimePicker1.Value = New Date(2020, 10, 30, 0, 0, 0, 0)
        '
        'Panelbaldiar
        '
        Me.Panelbaldiar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panelbaldiar.Location = New System.Drawing.Point(0, 0)
        Me.Panelbaldiar.Name = "Panelbaldiar"
        Me.Panelbaldiar.Size = New System.Drawing.Size(1399, 661)
        Me.Panelbaldiar.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Controls.Add(Me.IconButton2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 582)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1399, 79)
        Me.Panel1.TabIndex = 4
        '
        'FormBalDiar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1399, 661)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panelbaldiar)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormBalDiar"
        Me.Text = "FormBalDiar"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Panelbaldiar As Panel
    Friend WithEvents Panel1 As Panel
End Class
