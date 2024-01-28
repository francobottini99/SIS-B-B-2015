<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActualizarPrecios
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActualizarPrecios))
        Me.lblAvance = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvCtaCte = New System.Windows.Forms.DataGridView()
        Me.dgvCliente = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pbrActualizacion = New System.Windows.Forms.ProgressBar()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.lblTC = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTCAct = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCtaCte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAvance
        '
        Me.lblAvance.BackColor = System.Drawing.Color.Transparent
        Me.lblAvance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvance.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblAvance.Location = New System.Drawing.Point(548, 147)
        Me.lblAvance.Name = "lblAvance"
        Me.lblAvance.Size = New System.Drawing.Size(66, 16)
        Me.lblAvance.TabIndex = 129
        Me.lblAvance.Text = "0 %"
        Me.lblAvance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Image = Global.ByB_SI.My.Resources.Resources.IngresoAc
        Me.PictureBox1.Location = New System.Drawing.Point(8, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 178)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 124
        Me.PictureBox1.TabStop = False
        '
        'dgvCtaCte
        '
        Me.dgvCtaCte.AllowUserToAddRows = False
        Me.dgvCtaCte.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCtaCte.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvCtaCte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvCtaCte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCtaCte.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvCtaCte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCtaCte.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvCtaCte.Location = New System.Drawing.Point(29, 90)
        Me.dgvCtaCte.Name = "dgvCtaCte"
        Me.dgvCtaCte.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCtaCte.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvCtaCte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCtaCte.Size = New System.Drawing.Size(85, 21)
        Me.dgvCtaCte.TabIndex = 128
        '
        'dgvCliente
        '
        Me.dgvCliente.AllowUserToAddRows = False
        Me.dgvCliente.AllowUserToDeleteRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCliente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCliente.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgvCliente.Location = New System.Drawing.Point(29, 59)
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.ReadOnly = True
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCliente.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCliente.Size = New System.Drawing.Size(85, 21)
        Me.dgvCliente.TabIndex = 127
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label2.Location = New System.Drawing.Point(215, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 16)
        Me.Label2.TabIndex = 126
        Me.Label2.Text = "Progreso de Operación"
        '
        'pbrActualizacion
        '
        Me.pbrActualizacion.ForeColor = System.Drawing.Color.Lime
        Me.pbrActualizacion.Location = New System.Drawing.Point(216, 166)
        Me.pbrActualizacion.Name = "pbrActualizacion"
        Me.pbrActualizacion.Size = New System.Drawing.Size(398, 23)
        Me.pbrActualizacion.TabIndex = 125
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = CType(resources.GetObject("btnSalir.BackgroundImage"), System.Drawing.Image)
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Location = New System.Drawing.Point(687, 128)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(61, 61)
        Me.btnSalir.TabIndex = 121
        Me.btnSalir.Tag = ""
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.BackgroundImage = CType(resources.GetObject("btnActualizar.BackgroundImage"), System.Drawing.Image)
        Me.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnActualizar.Location = New System.Drawing.Point(620, 128)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(61, 61)
        Me.btnActualizar.TabIndex = 118
        Me.btnActualizar.Tag = ""
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'lblTC
        '
        Me.lblTC.BackColor = System.Drawing.Color.Transparent
        Me.lblTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTC.ForeColor = System.Drawing.Color.LightGray
        Me.lblTC.Location = New System.Drawing.Point(367, 69)
        Me.lblTC.Name = "lblTC"
        Me.lblTC.Size = New System.Drawing.Size(62, 19)
        Me.lblTC.TabIndex = 135
        Me.lblTC.Text = "1 U$S = "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label12.Location = New System.Drawing.Point(238, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 16)
        Me.Label12.TabIndex = 134
        Me.Label12.Text = "TC Sistema"
        '
        'txtTC
        '
        Me.txtTC.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtTC.Enabled = False
        Me.txtTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTC.ForeColor = System.Drawing.Color.Teal
        Me.txtTC.Location = New System.Drawing.Point(435, 66)
        Me.txtTC.Name = "txtTC"
        Me.txtTC.Size = New System.Drawing.Size(88, 22)
        Me.txtTC.TabIndex = 132
        Me.txtTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label4.Location = New System.Drawing.Point(238, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 16)
        Me.Label4.TabIndex = 133
        Me.Label4.Text = "Fecha TC"
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtFecha.Enabled = False
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.ForeColor = System.Drawing.Color.Teal
        Me.txtFecha.Location = New System.Drawing.Point(370, 24)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(153, 26)
        Me.txtFecha.TabIndex = 131
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(529, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 19)
        Me.Label1.TabIndex = 136
        Me.Label1.Text = "Ultima Fecha Ingresada"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(529, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 19)
        Me.Label3.TabIndex = 137
        Me.Label3.Text = "Ultima Tipo Cambio"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(367, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 19)
        Me.Label5.TabIndex = 140
        Me.Label5.Text = "1 U$S = "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label6.Location = New System.Drawing.Point(238, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 16)
        Me.Label6.TabIndex = 139
        Me.Label6.Text = "TC Actualización"
        '
        'txtTCAct
        '
        Me.txtTCAct.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtTCAct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTCAct.ForeColor = System.Drawing.Color.Teal
        Me.txtTCAct.Location = New System.Drawing.Point(435, 102)
        Me.txtTCAct.Name = "txtTCAct"
        Me.txtTCAct.Size = New System.Drawing.Size(88, 22)
        Me.txtTCAct.TabIndex = 138
        Me.txtTCAct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmActualizarPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ByB_SI.My.Resources.Resources.Fondo_23___Reducido
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(756, 199)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTCAct)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTC)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtTC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.lblAvance)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgvCtaCte)
        Me.Controls.Add(Me.dgvCliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pbrActualizacion)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnActualizar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmActualizarPrecios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmActualizarPrecios"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCtaCte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAvance As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dgvCtaCte As System.Windows.Forms.DataGridView
    Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pbrActualizacion As System.Windows.Forms.ProgressBar
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents lblTC As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTC As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTCAct As System.Windows.Forms.TextBox
End Class
