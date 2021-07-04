<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelUtilizadores = New System.Windows.Forms.Panel()
        Me.btnAddconta = New FontAwesome.Sharp.IconButton()
        Me.LogoDream = New System.Windows.Forms.PictureBox()
        CType(Me.LogoDream, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelUtilizadores
        '
        Me.PanelUtilizadores.AutoScroll = True
        Me.PanelUtilizadores.Location = New System.Drawing.Point(60, 74)
        Me.PanelUtilizadores.Name = "PanelUtilizadores"
        Me.PanelUtilizadores.Size = New System.Drawing.Size(1147, 385)
        Me.PanelUtilizadores.TabIndex = 0
        '
        'btnAddconta
        '
        Me.btnAddconta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddconta.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAddconta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnAddconta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddconta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddconta.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnAddconta.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.btnAddconta.IconColor = System.Drawing.Color.Black
        Me.btnAddconta.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAddconta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddconta.Location = New System.Drawing.Point(521, 466)
        Me.btnAddconta.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddconta.Name = "btnAddconta"
        Me.btnAddconta.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnAddconta.Rotation = 90.0R
        Me.btnAddconta.Size = New System.Drawing.Size(197, 60)
        Me.btnAddconta.TabIndex = 3
        Me.btnAddconta.Text = "Adicionar Conta"
        Me.btnAddconta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddconta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddconta.UseVisualStyleBackColor = True
        '
        'LogoDream
        '
        Me.LogoDream.Dock = System.Windows.Forms.DockStyle.Top
        Me.LogoDream.Image = Global.POS_Cashology.My.Resources.Resources.dreamid__1_
        Me.LogoDream.Location = New System.Drawing.Point(0, 0)
        Me.LogoDream.Margin = New System.Windows.Forms.Padding(4)
        Me.LogoDream.Name = "LogoDream"
        Me.LogoDream.Size = New System.Drawing.Size(1263, 67)
        Me.LogoDream.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoDream.TabIndex = 1
        Me.LogoDream.TabStop = False
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1263, 537)
        Me.Controls.Add(Me.btnAddconta)
        Me.Controls.Add(Me.LogoDream)
        Me.Controls.Add(Me.PanelUtilizadores)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "FormLogin"
        Me.Text = "FormLogin"
        CType(Me.LogoDream, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelUtilizadores As Panel
    Friend WithEvents LogoDream As PictureBox
    Friend WithEvents btnAddconta As FontAwesome.Sharp.IconButton
End Class
