<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImpCtaCteVta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImpCtaCteVta))
        Me.btnCtaCteResumida = New System.Windows.Forms.Button()
        Me.btnImpFactura = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCtaCteDetallada = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCtaCteResumida
        '
        Me.btnCtaCteResumida.BackColor = System.Drawing.Color.Olive
        Me.btnCtaCteResumida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCtaCteResumida.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCtaCteResumida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCtaCteResumida.ForeColor = System.Drawing.Color.White
        Me.btnCtaCteResumida.Location = New System.Drawing.Point(32, 12)
        Me.btnCtaCteResumida.Name = "btnCtaCteResumida"
        Me.btnCtaCteResumida.Size = New System.Drawing.Size(201, 46)
        Me.btnCtaCteResumida.TabIndex = 0
        Me.btnCtaCteResumida.Text = "IMPRIMIR CTA CTE RESUMIDA"
        Me.btnCtaCteResumida.UseVisualStyleBackColor = False
        '
        'btnImpFactura
        '
        Me.btnImpFactura.BackColor = System.Drawing.Color.Olive
        Me.btnImpFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImpFactura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImpFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImpFactura.ForeColor = System.Drawing.Color.White
        Me.btnImpFactura.Location = New System.Drawing.Point(32, 128)
        Me.btnImpFactura.Name = "btnImpFactura"
        Me.btnImpFactura.Size = New System.Drawing.Size(201, 46)
        Me.btnImpFactura.TabIndex = 1
        Me.btnImpFactura.Text = "IMPRIMIR FACTURA"
        Me.btnImpFactura.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Firebrick
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(32, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 46)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "SALIR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnCtaCteDetallada
        '
        Me.btnCtaCteDetallada.BackColor = System.Drawing.Color.Olive
        Me.btnCtaCteDetallada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCtaCteDetallada.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCtaCteDetallada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCtaCteDetallada.ForeColor = System.Drawing.Color.White
        Me.btnCtaCteDetallada.Location = New System.Drawing.Point(32, 70)
        Me.btnCtaCteDetallada.Name = "btnCtaCteDetallada"
        Me.btnCtaCteDetallada.Size = New System.Drawing.Size(201, 46)
        Me.btnCtaCteDetallada.TabIndex = 3
        Me.btnCtaCteDetallada.Text = "IMPRIMIR CTA CTE DETALLADA"
        Me.btnCtaCteDetallada.UseVisualStyleBackColor = False
        '
        'frmImpCtaCteVta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ByB_SI.My.Resources.Resources.Fondo_23___Reducido
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(263, 256)
        Me.Controls.Add(Me.btnCtaCteDetallada)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnImpFactura)
        Me.Controls.Add(Me.btnCtaCteResumida)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmImpCtaCteVta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "B&B - Impresión"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCtaCteResumida As System.Windows.Forms.Button
    Friend WithEvents btnImpFactura As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnCtaCteDetallada As System.Windows.Forms.Button
End Class
