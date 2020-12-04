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
        Me.lbaviso2 = New System.Windows.Forms.Label()
        Me.btnContinuar = New System.Windows.Forms.Button()
        Me.lbaviso1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbaviso2
        '
        Me.lbaviso2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbaviso2.AutoSize = True
        Me.lbaviso2.Location = New System.Drawing.Point(583, 149)
        Me.lbaviso2.Name = "lbaviso2"
        Me.lbaviso2.Size = New System.Drawing.Size(429, 17)
        Me.lbaviso2.TabIndex = 5
        Me.lbaviso2.Text = "USO RECOMENDADO PARA apenas para utilizadores avançados."
        '
        'btnContinuar
        '
        Me.btnContinuar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnContinuar.Location = New System.Drawing.Point(705, 181)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(139, 73)
        Me.btnContinuar.TabIndex = 4
        Me.btnContinuar.Text = "Continuar"
        Me.btnContinuar.UseVisualStyleBackColor = True
        '
        'lbaviso1
        '
        Me.lbaviso1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbaviso1.AutoSize = True
        Me.lbaviso1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbaviso1.Location = New System.Drawing.Point(607, 120)
        Me.lbaviso1.Name = "lbaviso1"
        Me.lbaviso1.Size = New System.Drawing.Size(378, 29)
        Me.lbaviso1.TabIndex = 3
        Me.lbaviso1.Text = "Tem acerteza que quer continuar?"
        '
        'FormConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1563, 706)
        Me.Controls.Add(Me.lbaviso2)
        Me.Controls.Add(Me.btnContinuar)
        Me.Controls.Add(Me.lbaviso1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormConfig"
        Me.Text = "FormConfig"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbaviso2 As Label
    Friend WithEvents btnContinuar As Button
    Friend WithEvents lbaviso1 As Label
End Class
