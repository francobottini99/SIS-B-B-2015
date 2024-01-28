<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfCtaCteVta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInfCtaCteVta))
        Me.rptResD = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.dgvCta = New System.Windows.Forms.DataGridView()
        CType(Me.dgvCta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rptResD
        '
        Me.rptResD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rptResD.Location = New System.Drawing.Point(1, 41)
        Me.rptResD.Name = "rptResD"
        Me.rptResD.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
        Me.rptResD.Size = New System.Drawing.Size(840, 563)
        Me.rptResD.TabIndex = 8
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Location = New System.Drawing.Point(756, 12)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 9
        Me.btnCerrar.Text = "Salir"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'dgvCta
        '
        Me.dgvCta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCta.Location = New System.Drawing.Point(32, 95)
        Me.dgvCta.Name = "dgvCta"
        Me.dgvCta.Size = New System.Drawing.Size(170, 22)
        Me.dgvCta.TabIndex = 10
        '
        'frmInfCtaCteVta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 604)
        Me.Controls.Add(Me.rptResD)
        Me.Controls.Add(Me.dgvCta)
        Me.Controls.Add(Me.btnCerrar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInfCtaCteVta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmInfCtaCteVta"
        CType(Me.dgvCta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rptResD As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents dgvCta As System.Windows.Forms.DataGridView
End Class
