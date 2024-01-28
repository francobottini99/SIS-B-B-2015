<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChqEnCartera
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChqEnCartera))
        Me.gbxValores = New System.Windows.Forms.GroupBox()
        Me.dgvValEnCartera = New System.Windows.Forms.DataGridView()
        Me.Seleccion = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnTranf = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTotVal = New System.Windows.Forms.TextBox()
        Me.lblOrigen = New System.Windows.Forms.Label()
        Me.gbxValores.SuspendLayout()
        CType(Me.dgvValEnCartera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxValores
        '
        Me.gbxValores.BackColor = System.Drawing.Color.Transparent
        Me.gbxValores.Controls.Add(Me.dgvValEnCartera)
        Me.gbxValores.Location = New System.Drawing.Point(7, 3)
        Me.gbxValores.Name = "gbxValores"
        Me.gbxValores.Size = New System.Drawing.Size(867, 224)
        Me.gbxValores.TabIndex = 107
        Me.gbxValores.TabStop = False
        '
        'dgvValEnCartera
        '
        Me.dgvValEnCartera.AllowUserToAddRows = False
        Me.dgvValEnCartera.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvValEnCartera.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvValEnCartera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvValEnCartera.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvValEnCartera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvValEnCartera.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccion})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvValEnCartera.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvValEnCartera.Location = New System.Drawing.Point(6, 13)
        Me.dgvValEnCartera.Name = "dgvValEnCartera"
        Me.dgvValEnCartera.ReadOnly = True
        Me.dgvValEnCartera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvValEnCartera.Size = New System.Drawing.Size(855, 205)
        Me.dgvValEnCartera.TabIndex = 73
        '
        'Seleccion
        '
        Me.Seleccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Seleccion.HeaderText = "SELECCION"
        Me.Seleccion.Name = "Seleccion"
        Me.Seleccion.ReadOnly = True
        Me.Seleccion.Width = 73
        '
        'btnTranf
        '
        Me.btnTranf.BackgroundImage = Global.ByB_SI.My.Resources.Resources.EmitirIn
        Me.btnTranf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTranf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTranf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTranf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnTranf.Location = New System.Drawing.Point(803, 230)
        Me.btnTranf.Name = "btnTranf"
        Me.btnTranf.Size = New System.Drawing.Size(65, 61)
        Me.btnTranf.TabIndex = 110
        Me.btnTranf.Tag = ""
        Me.btnTranf.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label11.Location = New System.Drawing.Point(12, 235)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 16)
        Me.Label11.TabIndex = 108
        Me.Label11.Text = "Total Valores"
        '
        'txtTotVal
        '
        Me.txtTotVal.BackColor = System.Drawing.Color.Orange
        Me.txtTotVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotVal.ForeColor = System.Drawing.Color.White
        Me.txtTotVal.Location = New System.Drawing.Point(13, 254)
        Me.txtTotVal.Name = "txtTotVal"
        Me.txtTotVal.Size = New System.Drawing.Size(139, 26)
        Me.txtTotVal.TabIndex = 109
        Me.txtTotVal.Text = "$ 0.00"
        Me.txtTotVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblOrigen
        '
        Me.lblOrigen.BackColor = System.Drawing.Color.Salmon
        Me.lblOrigen.Location = New System.Drawing.Point(158, 254)
        Me.lblOrigen.Name = "lblOrigen"
        Me.lblOrigen.Size = New System.Drawing.Size(157, 26)
        Me.lblOrigen.TabIndex = 111
        Me.lblOrigen.Visible = False
        '
        'frmChqEnCartera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ByB_SI.My.Resources.Resources.Fondo_23___Reducido
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(882, 294)
        Me.Controls.Add(Me.lblOrigen)
        Me.Controls.Add(Me.btnTranf)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtTotVal)
        Me.Controls.Add(Me.gbxValores)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmChqEnCartera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmChqEnCartera"
        Me.gbxValores.ResumeLayout(False)
        CType(Me.dgvValEnCartera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxValores As System.Windows.Forms.GroupBox
    Friend WithEvents dgvValEnCartera As System.Windows.Forms.DataGridView
    Friend WithEvents btnTranf As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTotVal As System.Windows.Forms.TextBox
    Friend WithEvents Seleccion As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents lblOrigen As System.Windows.Forms.Label
End Class
