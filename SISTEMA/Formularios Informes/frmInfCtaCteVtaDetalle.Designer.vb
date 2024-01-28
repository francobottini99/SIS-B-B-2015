<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfCtaCteVtaDetalle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInfCtaCteVtaDetalle))
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.rptResD = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dgvFa = New System.Windows.Forms.DataGridView()
        Me.dgvRec = New System.Windows.Forms.DataGridView()
        CType(Me.dgvFa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Location = New System.Drawing.Point(979, 11)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 5
        Me.btnCerrar.Text = "Salir"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'rptResD
        '
        Me.rptResD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rptResD.Location = New System.Drawing.Point(1, 40)
        Me.rptResD.Name = "rptResD"
        Me.rptResD.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
        Me.rptResD.Size = New System.Drawing.Size(1064, 583)
        Me.rptResD.TabIndex = 4
        '
        'dgvFa
        '
        Me.dgvFa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFa.Location = New System.Drawing.Point(12, 86)
        Me.dgvFa.Name = "dgvFa"
        Me.dgvFa.Size = New System.Drawing.Size(192, 20)
        Me.dgvFa.TabIndex = 6
        '
        'dgvRec
        '
        Me.dgvRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRec.Location = New System.Drawing.Point(210, 86)
        Me.dgvRec.Name = "dgvRec"
        Me.dgvRec.Size = New System.Drawing.Size(192, 20)
        Me.dgvRec.TabIndex = 7
        '
        'frmInfCtaCteVtaDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 624)
        Me.Controls.Add(Me.rptResD)
        Me.Controls.Add(Me.dgvRec)
        Me.Controls.Add(Me.dgvFa)
        Me.Controls.Add(Me.btnCerrar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInfCtaCteVtaDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmInfCtaCteVtaDetalle"
        CType(Me.dgvFa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents rptResD As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dgvFa As System.Windows.Forms.DataGridView
    Friend WithEvents dgvRec As System.Windows.Forms.DataGridView
End Class
