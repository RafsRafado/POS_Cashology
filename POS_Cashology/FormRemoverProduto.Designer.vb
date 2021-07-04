<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRemoverProduto
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
        Me.lvProds = New System.Windows.Forms.ListView()
        Me.LvApagar = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAplicar = New FontAwesome.Sharp.IconButton()
        Me.BtnUndo = New FontAwesome.Sharp.IconButton()
        Me.BtnRemover = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'lvProds
        '
        Me.lvProds.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lvProds.FullRowSelect = True
        Me.lvProds.GridLines = True
        Me.lvProds.HideSelection = False
        Me.lvProds.Location = New System.Drawing.Point(12, 97)
        Me.lvProds.Name = "lvProds"
        Me.lvProds.Size = New System.Drawing.Size(426, 372)
        Me.lvProds.TabIndex = 0
        Me.lvProds.UseCompatibleStateImageBehavior = False
        Me.lvProds.View = System.Windows.Forms.View.Details
        '
        'LvApagar
        '
        Me.LvApagar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LvApagar.FullRowSelect = True
        Me.LvApagar.GridLines = True
        Me.LvApagar.HideSelection = False
        Me.LvApagar.Location = New System.Drawing.Point(567, 97)
        Me.LvApagar.Name = "LvApagar"
        Me.LvApagar.Size = New System.Drawing.Size(429, 372)
        Me.LvApagar.TabIndex = 89
        Me.LvApagar.UseCompatibleStateImageBehavior = False
        Me.LvApagar.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Location = New System.Drawing.Point(127, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 33)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Produtos"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label2.Location = New System.Drawing.Point(601, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(368, 33)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Produtos a ser apagados"
        '
        'btnAplicar
        '
        Me.btnAplicar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAplicar.BackColor = System.Drawing.Color.Transparent
        Me.btnAplicar.Enabled = False
        Me.btnAplicar.FlatAppearance.BorderSize = 0
        Me.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAplicar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAplicar.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.btnAplicar.IconColor = System.Drawing.Color.Orange
        Me.btnAplicar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAplicar.IconSize = 125
        Me.btnAplicar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAplicar.Location = New System.Drawing.Point(443, 489)
        Me.btnAplicar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(106, 129)
        Me.btnAplicar.TabIndex = 92
        Me.btnAplicar.UseVisualStyleBackColor = False
        '
        'BtnUndo
        '
        Me.BtnUndo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnUndo.BackColor = System.Drawing.Color.Transparent
        Me.BtnUndo.Enabled = False
        Me.BtnUndo.FlatAppearance.BorderSize = 0
        Me.BtnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUndo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUndo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnUndo.IconChar = FontAwesome.Sharp.IconChar.UndoAlt
        Me.BtnUndo.IconColor = System.Drawing.Color.Orange
        Me.BtnUndo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnUndo.IconSize = 125
        Me.BtnUndo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnUndo.Location = New System.Drawing.Point(443, 298)
        Me.BtnUndo.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnUndo.Name = "BtnUndo"
        Me.BtnUndo.Size = New System.Drawing.Size(119, 143)
        Me.BtnUndo.TabIndex = 88
        Me.BtnUndo.UseVisualStyleBackColor = False
        '
        'BtnRemover
        '
        Me.BtnRemover.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnRemover.BackColor = System.Drawing.Color.Transparent
        Me.BtnRemover.Enabled = False
        Me.BtnRemover.FlatAppearance.BorderSize = 0
        Me.BtnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemover.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemover.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnRemover.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.BtnRemover.IconColor = System.Drawing.Color.Red
        Me.BtnRemover.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnRemover.IconSize = 125
        Me.BtnRemover.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnRemover.Location = New System.Drawing.Point(443, 112)
        Me.BtnRemover.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRemover.Name = "BtnRemover"
        Me.BtnRemover.Size = New System.Drawing.Size(119, 143)
        Me.BtnRemover.TabIndex = 87
        Me.BtnRemover.UseVisualStyleBackColor = False
        '
        'FormRemoverProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 629)
        Me.Controls.Add(Me.btnAplicar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LvApagar)
        Me.Controls.Add(Me.BtnUndo)
        Me.Controls.Add(Me.BtnRemover)
        Me.Controls.Add(Me.lvProds)
        Me.Name = "FormRemoverProduto"
        Me.Text = "FormRemoverProduto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvProds As ListView
    Friend WithEvents BtnRemover As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnUndo As FontAwesome.Sharp.IconButton
    Friend WithEvents LvApagar As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAplicar As FontAwesome.Sharp.IconButton
End Class
