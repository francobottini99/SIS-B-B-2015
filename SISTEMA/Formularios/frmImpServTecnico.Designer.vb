<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImpServTecnico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImpServTecnico))
        Me.btnCtaCteDetallada = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSTEstado = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCtaCteDetallada
        '
        Me.btnCtaCteDetallada.BackColor = System.Drawing.Color.Olive
        Me.btnCtaCteDetallada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCtaCteDetallada.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCtaCteDetallada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCtaCteDetallada.ForeColor = System.Drawing.Color.White
        Me.btnCtaCteDetallada.Location = New System.Drawing.Point(28, 70)
        Me.btnCtaCteDetallada.Name = "btnCtaCteDetallada"
        Me.btnCtaCteDetallada.Size = New System.Drawing.Size(201, 46)
        Me.btnCtaCteDetallada.TabIndex = 7
        Me.btnCtaCteDetallada.Text = "DETALLE POR CLIENTE"
        Me.btnCtaCteDetallada.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Firebrick
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(28, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 46)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "SALIR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnSTEstado
        '
        Me.btnSTEstado.BackColor = System.Drawing.Color.Olive
        Me.btnSTEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSTEstado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSTEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSTEstado.ForeColor = System.Drawing.Color.White
        Me.btnSTEstado.Location = New System.Drawing.Point(28, 12)
        Me.btnSTEstado.Name = "btnSTEstado"
        Me.btnSTEstado.Size = New System.Drawing.Size(201, 46)
        Me.btnSTEstado.TabIndex = 4
        Me.btnSTEstado.Text = "DETALLE POR ESTADO"
        Me.btnSTEstado.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Olive
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(28, 128)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(201, 46)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "DETALLE POR EQUIPO"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmImpServTecnico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ByB_SI.My.Resources.Resources.Fondo_23___Reducido
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(258, 258)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnCtaCteDetallada)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSTEstado)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmImpServTecnico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmImpServTecnico"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCtaCteDetallada As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnSTEstado As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
