<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGestaoProd
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelForm = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnfechar = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnEditar = New FontAwesome.Sharp.IconButton()
        Me.BtnRemover = New FontAwesome.Sharp.IconButton()
        Me.btnAdd = New FontAwesome.Sharp.IconButton()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PanelForm.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelForm
        '
        Me.PanelForm.Controls.Add(Me.BtnEditar)
        Me.PanelForm.Controls.Add(Me.BtnRemover)
        Me.PanelForm.Controls.Add(Me.btnAdd)
        Me.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForm.Location = New System.Drawing.Point(0, 0)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(1049, 537)
        Me.PanelForm.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnfechar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1049, 65)
        Me.Panel1.TabIndex = 89
        '
        'btnfechar
        '
        Me.btnfechar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnfechar.FlatAppearance.BorderSize = 0
        Me.btnfechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfechar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnfechar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.btnfechar.IconColor = System.Drawing.Color.DarkRed
        Me.btnfechar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnfechar.Location = New System.Drawing.Point(994, 0)
        Me.btnfechar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnfechar.Name = "btnfechar"
        Me.btnfechar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnfechar.Size = New System.Drawing.Size(55, 65)
        Me.btnfechar.TabIndex = 6
        Me.btnfechar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnfechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnfechar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(353, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 40)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Gestão de Produtos"
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEditar.BackColor = System.Drawing.Color.Transparent
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.BtnEditar.IconColor = System.Drawing.Color.Silver
        Me.BtnEditar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnEditar.IconSize = 125
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEditar.Location = New System.Drawing.Point(665, 146)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(119, 143)
        Me.BtnEditar.TabIndex = 87
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnRemover
        '
        Me.BtnRemover.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnRemover.BackColor = System.Drawing.Color.Transparent
        Me.BtnRemover.FlatAppearance.BorderSize = 0
        Me.BtnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemover.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemover.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnRemover.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.BtnRemover.IconColor = System.Drawing.Color.Red
        Me.BtnRemover.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnRemover.IconSize = 125
        Me.BtnRemover.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnRemover.Location = New System.Drawing.Point(465, 146)
        Me.BtnRemover.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRemover.Name = "BtnRemover"
        Me.BtnRemover.Size = New System.Drawing.Size(119, 143)
        Me.BtnRemover.TabIndex = 86
        Me.BtnRemover.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.btnAdd.IconColor = System.Drawing.Color.Green
        Me.btnAdd.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAdd.IconSize = 125
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdd.Location = New System.Drawing.Point(265, 146)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(119, 143)
        Me.btnAdd.TabIndex = 85
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'PanelMenu
        '
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelMenu.Location = New System.Drawing.Point(0, 487)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(1049, 50)
        Me.PanelMenu.TabIndex = 2
        '
        'FormGestaoProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1049, 537)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelForm)
        Me.Name = "FormGestaoProd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelForm.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelForm As Panel
    Friend WithEvents BtnEditar As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnRemover As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAdd As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnfechar As FontAwesome.Sharp.IconButton
End Class
