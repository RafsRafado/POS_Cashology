<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPagamento
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
        Me.components = New System.ComponentModel.Container()
        Me.PanelVlr = New System.Windows.Forms.Panel()
        Me.lbval = New System.Windows.Forms.Label()
        Me.lbeuro = New System.Windows.Forms.Label()
        Me.btncancop = New System.Windows.Forms.Button()
        Me.btnconcop = New System.Windows.Forms.Button()
        Me.panelresumo = New System.Windows.Forms.Panel()
        Me.lbtxtresumo = New System.Windows.Forms.Label()
        Me.TimerQuant = New System.Windows.Forms.Timer(Me.components)
        Me.panelins = New System.Windows.Forms.Panel()
        Me.lbvalins = New System.Windows.Forms.Label()
        Me.lbeuroins = New System.Windows.Forms.Label()
        Me.lbtxtvlrserpago = New System.Windows.Forms.Label()
        Me.lbtxtvlrins = New System.Windows.Forms.Label()
        Me.lbNif = New System.Windows.Forms.Label()
        Me.PanelVlr.SuspendLayout()
        Me.panelins.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelVlr
        '
        Me.PanelVlr.BackColor = System.Drawing.Color.Gray
        Me.PanelVlr.Controls.Add(Me.lbval)
        Me.PanelVlr.Controls.Add(Me.lbeuro)
        Me.PanelVlr.Location = New System.Drawing.Point(349, 163)
        Me.PanelVlr.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelVlr.Name = "PanelVlr"
        Me.PanelVlr.Size = New System.Drawing.Size(142, 81)
        Me.PanelVlr.TabIndex = 0
        '
        'lbval
        '
        Me.lbval.AutoSize = True
        Me.lbval.Font = New System.Drawing.Font("Poor Richard", 22.2!)
        Me.lbval.Location = New System.Drawing.Point(15, 24)
        Me.lbval.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbval.Name = "lbval"
        Me.lbval.Size = New System.Drawing.Size(0, 35)
        Me.lbval.TabIndex = 1
        Me.lbval.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbeuro
        '
        Me.lbeuro.AutoSize = True
        Me.lbeuro.Font = New System.Drawing.Font("Poor Richard", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbeuro.Location = New System.Drawing.Point(93, 24)
        Me.lbeuro.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbeuro.Name = "lbeuro"
        Me.lbeuro.Size = New System.Drawing.Size(35, 35)
        Me.lbeuro.TabIndex = 0
        Me.lbeuro.Text = "€"
        '
        'btncancop
        '
        Me.btncancop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncancop.Location = New System.Drawing.Point(253, 414)
        Me.btncancop.Margin = New System.Windows.Forms.Padding(2)
        Me.btncancop.Name = "btncancop"
        Me.btncancop.Size = New System.Drawing.Size(121, 42)
        Me.btncancop.TabIndex = 1
        Me.btncancop.Text = "Cancelar Operação"
        Me.btncancop.UseVisualStyleBackColor = True
        '
        'btnconcop
        '
        Me.btnconcop.Enabled = False
        Me.btnconcop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnconcop.Location = New System.Drawing.Point(436, 414)
        Me.btnconcop.Margin = New System.Windows.Forms.Padding(2)
        Me.btnconcop.Name = "btnconcop"
        Me.btnconcop.Size = New System.Drawing.Size(121, 42)
        Me.btnconcop.TabIndex = 2
        Me.btnconcop.Text = "Concluir Operação"
        Me.btnconcop.UseVisualStyleBackColor = True
        '
        'panelresumo
        '
        Me.panelresumo.AutoScroll = True
        Me.panelresumo.Location = New System.Drawing.Point(11, 66)
        Me.panelresumo.Margin = New System.Windows.Forms.Padding(2)
        Me.panelresumo.Name = "panelresumo"
        Me.panelresumo.Size = New System.Drawing.Size(319, 307)
        Me.panelresumo.TabIndex = 3
        '
        'lbtxtresumo
        '
        Me.lbtxtresumo.AutoSize = True
        Me.lbtxtresumo.Location = New System.Drawing.Point(26, 42)
        Me.lbtxtresumo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbtxtresumo.Name = "lbtxtresumo"
        Me.lbtxtresumo.Size = New System.Drawing.Size(102, 13)
        Me.lbtxtresumo.TabIndex = 4
        Me.lbtxtresumo.Text = "Resumo Do Pedido:"
        '
        'TimerQuant
        '
        Me.TimerQuant.Interval = 250
        '
        'panelins
        '
        Me.panelins.BackColor = System.Drawing.Color.Gray
        Me.panelins.Controls.Add(Me.lbvalins)
        Me.panelins.Controls.Add(Me.lbeuroins)
        Me.panelins.Location = New System.Drawing.Point(601, 163)
        Me.panelins.Margin = New System.Windows.Forms.Padding(2)
        Me.panelins.Name = "panelins"
        Me.panelins.Size = New System.Drawing.Size(142, 81)
        Me.panelins.TabIndex = 5
        '
        'lbvalins
        '
        Me.lbvalins.AutoSize = True
        Me.lbvalins.Font = New System.Drawing.Font("Poor Richard", 22.2!)
        Me.lbvalins.Location = New System.Drawing.Point(42, 24)
        Me.lbvalins.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbvalins.Name = "lbvalins"
        Me.lbvalins.Size = New System.Drawing.Size(0, 35)
        Me.lbvalins.TabIndex = 1
        Me.lbvalins.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbeuroins
        '
        Me.lbeuroins.AutoSize = True
        Me.lbeuroins.Font = New System.Drawing.Font("Poor Richard", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbeuroins.Location = New System.Drawing.Point(93, 24)
        Me.lbeuroins.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbeuroins.Name = "lbeuroins"
        Me.lbeuroins.Size = New System.Drawing.Size(35, 35)
        Me.lbeuroins.TabIndex = 0
        Me.lbeuroins.Text = "€"
        '
        'lbtxtvlrserpago
        '
        Me.lbtxtvlrserpago.AutoSize = True
        Me.lbtxtvlrserpago.Location = New System.Drawing.Point(372, 147)
        Me.lbtxtvlrserpago.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbtxtvlrserpago.Name = "lbtxtvlrserpago"
        Me.lbtxtvlrserpago.Size = New System.Drawing.Size(88, 13)
        Me.lbtxtvlrserpago.TabIndex = 6
        Me.lbtxtvlrserpago.Text = "Valor a ser Pago:"
        '
        'lbtxtvlrins
        '
        Me.lbtxtvlrins.AutoSize = True
        Me.lbtxtvlrins.Location = New System.Drawing.Point(624, 146)
        Me.lbtxtvlrins.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbtxtvlrins.Name = "lbtxtvlrins"
        Me.lbtxtvlrins.Size = New System.Drawing.Size(74, 13)
        Me.lbtxtvlrins.TabIndex = 7
        Me.lbtxtvlrins.Text = "Valor Inserido:"
        '
        'lbNif
        '
        Me.lbNif.AutoSize = True
        Me.lbNif.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNif.Location = New System.Drawing.Point(577, 9)
        Me.lbNif.Name = "lbNif"
        Me.lbNif.Size = New System.Drawing.Size(45, 24)
        Me.lbNif.TabIndex = 8
        Me.lbNif.Text = "NIF:"
        '
        'FormPagamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(852, 466)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbNif)
        Me.Controls.Add(Me.lbtxtvlrins)
        Me.Controls.Add(Me.lbtxtvlrserpago)
        Me.Controls.Add(Me.panelins)
        Me.Controls.Add(Me.lbtxtresumo)
        Me.Controls.Add(Me.panelresumo)
        Me.Controls.Add(Me.btnconcop)
        Me.Controls.Add(Me.btncancop)
        Me.Controls.Add(Me.PanelVlr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormPagamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelVlr.ResumeLayout(False)
        Me.PanelVlr.PerformLayout()
        Me.panelins.ResumeLayout(False)
        Me.panelins.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelVlr As Panel
    Friend WithEvents lbeuro As Label
    Friend WithEvents btncancop As Button
    Friend WithEvents btnconcop As Button
    Friend WithEvents lbval As Label
    Friend WithEvents panelresumo As Panel
    Friend WithEvents lbtxtresumo As Label
    Friend WithEvents TimerQuant As Timer
    Friend WithEvents panelins As Panel
    Friend WithEvents lbvalins As Label
    Friend WithEvents lbeuroins As Label
    Friend WithEvents lbtxtvlrserpago As Label
    Friend WithEvents lbtxtvlrins As Label
    Friend WithEvents lbNif As Label
End Class
