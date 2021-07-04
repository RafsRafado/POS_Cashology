<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormConfig
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCPA = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAplicar = New FontAwesome.Sharp.IconButton()
        Me.btnTeclado = New FontAwesome.Sharp.IconButton()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.txtPorta = New System.Windows.Forms.TextBox()
        Me.lbIP = New System.Windows.Forms.Label()
        Me.lbPorta = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Consolas", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(481, 3)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.MaximumSize = New System.Drawing.Size(225, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CONFIGURAÇÕES"
        '
        'btnCPA
        '
        Me.btnCPA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCPA.BackColor = System.Drawing.Color.Transparent
        Me.btnCPA.FlatAppearance.BorderSize = 0
        Me.btnCPA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCPA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCPA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCPA.ForeColor = System.Drawing.Color.Transparent
        Me.btnCPA.IconChar = FontAwesome.Sharp.IconChar.ToggleOff
        Me.btnCPA.IconColor = System.Drawing.Color.Maroon
        Me.btnCPA.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCPA.IconSize = 100
        Me.btnCPA.Location = New System.Drawing.Point(604, 86)
        Me.btnCPA.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCPA.Name = "btnCPA"
        Me.btnCPA.Size = New System.Drawing.Size(85, 73)
        Me.btnCPA.TabIndex = 73
        Me.btnCPA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCPA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCPA.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(482, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 29)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Utilizar CPA"
        '
        'btnAplicar
        '
        Me.btnAplicar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAplicar.BackColor = System.Drawing.Color.Transparent
        Me.btnAplicar.FlatAppearance.BorderSize = 0
        Me.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAplicar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAplicar.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.btnAplicar.IconColor = System.Drawing.Color.Black
        Me.btnAplicar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAplicar.IconSize = 125
        Me.btnAplicar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAplicar.Location = New System.Drawing.Point(457, 434)
        Me.btnAplicar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(234, 129)
        Me.btnAplicar.TabIndex = 75
        Me.btnAplicar.UseVisualStyleBackColor = False
        '
        'btnTeclado
        '
        Me.btnTeclado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnTeclado.BackColor = System.Drawing.Color.Transparent
        Me.btnTeclado.FlatAppearance.BorderSize = 0
        Me.btnTeclado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTeclado.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeclado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnTeclado.IconChar = FontAwesome.Sharp.IconChar.Keyboard
        Me.btnTeclado.IconColor = System.Drawing.Color.Silver
        Me.btnTeclado.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnTeclado.IconSize = 50
        Me.btnTeclado.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTeclado.Location = New System.Drawing.Point(701, 187)
        Me.btnTeclado.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTeclado.Name = "btnTeclado"
        Me.btnTeclado.Size = New System.Drawing.Size(47, 52)
        Me.btnTeclado.TabIndex = 76
        Me.btnTeclado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnTeclado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnTeclado.UseVisualStyleBackColor = False
        '
        'txtIP
        '
        Me.txtIP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtIP.Location = New System.Drawing.Point(486, 176)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(210, 20)
        Me.txtIP.TabIndex = 77
        '
        'txtPorta
        '
        Me.txtPorta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPorta.Location = New System.Drawing.Point(486, 212)
        Me.txtPorta.Name = "txtPorta"
        Me.txtPorta.Size = New System.Drawing.Size(210, 20)
        Me.txtPorta.TabIndex = 78
        '
        'lbIP
        '
        Me.lbIP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbIP.AutoSize = True
        Me.lbIP.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIP.ForeColor = System.Drawing.Color.White
        Me.lbIP.Location = New System.Drawing.Point(452, 171)
        Me.lbIP.Name = "lbIP"
        Me.lbIP.Size = New System.Drawing.Size(30, 29)
        Me.lbIP.TabIndex = 79
        Me.lbIP.Text = "IP"
        '
        'lbPorta
        '
        Me.lbPorta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbPorta.AutoSize = True
        Me.lbPorta.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPorta.ForeColor = System.Drawing.Color.White
        Me.lbPorta.Location = New System.Drawing.Point(422, 203)
        Me.lbPorta.Name = "lbPorta"
        Me.lbPorta.Size = New System.Drawing.Size(60, 29)
        Me.lbPorta.TabIndex = 80
        Me.lbPorta.Text = "Porta"
        '
        'FormConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1172, 574)
        Me.Controls.Add(Me.lbPorta)
        Me.Controls.Add(Me.lbIP)
        Me.Controls.Add(Me.txtPorta)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.btnTeclado)
        Me.Controls.Add(Me.btnAplicar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCPA)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FormConfig"
        Me.Text = "FormConfig"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents btnCPA As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAplicar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnTeclado As FontAwesome.Sharp.IconButton
    Friend WithEvents txtIP As TextBox
    Friend WithEvents txtPorta As TextBox
    Friend WithEvents lbIP As Label
    Friend WithEvents lbPorta As Label
End Class
