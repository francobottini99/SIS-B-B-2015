<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfFacturaVenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInfFacturaVenta))
        Me.rptFacVenta = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.dgvFactura = New System.Windows.Forms.DataGridView()
        Me.lblOrigen = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        CType(Me.dgvFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rptFacVenta
        '
        Me.rptFacVenta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rptFacVenta.Location = New System.Drawing.Point(0, 32)
        Me.rptFacVenta.Name = "rptFacVenta"
        Me.rptFacVenta.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
        Me.rptFacVenta.Size = New System.Drawing.Size(837, 605)
        Me.rptFacVenta.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Location = New System.Drawing.Point(749, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.Text = "Salir"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'dgvFactura
        '
        Me.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFactura.Location = New System.Drawing.Point(118, 4)
        Me.dgvFactura.Name = "dgvFactura"
        Me.dgvFactura.Size = New System.Drawing.Size(231, 22)
        Me.dgvFactura.TabIndex = 2
        Me.dgvFactura.Visible = False
        '
        'lblOrigen
        '
        Me.lblOrigen.BackColor = System.Drawing.Color.LightSalmon
        Me.lblOrigen.Location = New System.Drawing.Point(-3, 4)
        Me.lblOrigen.Name = "lblOrigen"
        Me.lblOrigen.Size = New System.Drawing.Size(115, 22)
        Me.lblOrigen.TabIndex = 3
        Me.lblOrigen.Visible = False
        '
        'lblTipo
        '
        Me.lblTipo.BackColor = System.Drawing.Color.LightSalmon
        Me.lblTipo.Location = New System.Drawing.Point(355, 3)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(115, 22)
        Me.lblTipo.TabIndex = 4
        Me.lblTipo.Visible = False
        '
        'frmInfFacturaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 637)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.lblOrigen)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.rptFacVenta)
        Me.Controls.Add(Me.dgvFactura)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInfFacturaVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmInfFacturaVenta"
        CType(Me.dgvFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rptFacVenta As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents dgvFactura As System.Windows.Forms.DataGridView
    Friend WithEvents lblOrigen As System.Windows.Forms.Label
    Friend WithEvents lblTipo As System.Windows.Forms.Label
End Class
