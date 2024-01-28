<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfSTEntregaAClietne
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInfSTEntregaAClietne))
        Me.rptST = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rptST
        '
        Me.rptST.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rptST.Location = New System.Drawing.Point(2, 37)
        Me.rptST.Name = "rptST"
        Me.rptST.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
        Me.rptST.Size = New System.Drawing.Size(851, 566)
        Me.rptST.TabIndex = 20
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Location = New System.Drawing.Point(768, 9)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 22)
        Me.btnCerrar.TabIndex = 21
        Me.btnCerrar.Text = "Salir"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'frmInfSTEntregaAClietne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 725)
        Me.Controls.Add(Me.rptST)
        Me.Controls.Add(Me.btnCerrar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInfSTEntregaAClietne"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmInfSTEntregaAClietne"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rptST As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
End Class
