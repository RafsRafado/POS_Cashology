<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddProd
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbPreco = New System.Windows.Forms.Label()
        Me.lbNomeProd = New System.Windows.Forms.Label()
        Me.txtPreco = New System.Windows.Forms.TextBox()
        Me.txtNomeProd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnTeclado = New FontAwesome.Sharp.IconButton()
        Me.btnAplicar = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'lbPreco
        '
        Me.lbPreco.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbPreco.AutoSize = True
        Me.lbPreco.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPreco.ForeColor = System.Drawing.Color.White
        Me.lbPreco.Location = New System.Drawing.Point(445, 178)
        Me.lbPreco.Name = "lbPreco"
        Me.lbPreco.Size = New System.Drawing.Size(70, 29)
        Me.lbPreco.TabIndex = 89
        Me.lbPreco.Text = "Preço:"
        '
        'lbNomeProd
        '
        Me.lbNomeProd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbNomeProd.AutoSize = True
        Me.lbNomeProd.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNomeProd.ForeColor = System.Drawing.Color.White
        Me.lbNomeProd.Location = New System.Drawing.Point(344, 147)
        Me.lbNomeProd.Name = "lbNomeProd"
        Me.lbNomeProd.Size = New System.Drawing.Size(171, 29)
        Me.lbNomeProd.TabIndex = 88
        Me.lbNomeProd.Text = "Nome do Produto:"
        '
        'txtPreco
        '
        Me.txtPreco.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPreco.Location = New System.Drawing.Point(534, 178)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.Size = New System.Drawing.Size(210, 20)
        Me.txtPreco.TabIndex = 87
        '
        'txtNomeProd
        '
        Me.txtNomeProd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNomeProd.Location = New System.Drawing.Point(534, 147)
        Me.txtNomeProd.Name = "txtNomeProd"
        Me.txtNomeProd.Size = New System.Drawing.Size(210, 20)
        Me.txtNomeProd.TabIndex = 86
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(501, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 32)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Adicionar Produto"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(412, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 29)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Categoria:"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(534, 209)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(210, 21)
        Me.ComboBox1.TabIndex = 92
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
        Me.btnTeclado.Location = New System.Drawing.Point(749, 155)
        Me.btnTeclado.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTeclado.Name = "btnTeclado"
        Me.btnTeclado.Size = New System.Drawing.Size(47, 52)
        Me.btnTeclado.TabIndex = 85
        Me.btnTeclado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnTeclado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnTeclado.UseVisualStyleBackColor = False
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
        Me.btnAplicar.IconColor = System.Drawing.Color.Orange
        Me.btnAplicar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAplicar.IconSize = 125
        Me.btnAplicar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAplicar.Location = New System.Drawing.Point(563, 480)
        Me.btnAplicar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(106, 129)
        Me.btnAplicar.TabIndex = 84
        Me.btnAplicar.UseVisualStyleBackColor = False
        '
        'FormAddProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1240, 629)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbPreco)
        Me.Controls.Add(Me.lbNomeProd)
        Me.Controls.Add(Me.txtPreco)
        Me.Controls.Add(Me.txtNomeProd)
        Me.Controls.Add(Me.btnTeclado)
        Me.Controls.Add(Me.btnAplicar)
        Me.Name = "FormAddProd"
        Me.Text = "FormAddProd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbPreco As Label
    Friend WithEvents lbNomeProd As Label
    Friend WithEvents txtPreco As TextBox
    Friend WithEvents txtNomeProd As TextBox
    Friend WithEvents btnTeclado As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAplicar As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
