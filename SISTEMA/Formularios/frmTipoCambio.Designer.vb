<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipoCambio
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTipoCambio))
        Me.lblFuncion = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.gbxDatagrid = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnTodo = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFecHasta = New System.Windows.Forms.TextBox()
        Me.dgvTC = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtFecDesde = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.tmrMensaje = New System.Windows.Forms.Timer(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTC = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gbxTC = New System.Windows.Forms.GroupBox()
        Me.lblUltimoTC = New System.Windows.Forms.Label()
        Me.lblUltimaFec = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTC = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblidTC = New System.Windows.Forms.Label()
        Me.gbxDatagrid.SuspendLayout()
        CType(Me.dgvTC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxTC.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFuncion
        '
        Me.lblFuncion.Location = New System.Drawing.Point(817, 366)
        Me.lblFuncion.Name = "lblFuncion"
        Me.lblFuncion.Size = New System.Drawing.Size(74, 20)
        Me.lblFuncion.TabIndex = 31
        Me.lblFuncion.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label15.Location = New System.Drawing.Point(15, 34)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 16)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "Fecha Desde"
        '
        'gbxDatagrid
        '
        Me.gbxDatagrid.BackColor = System.Drawing.Color.Transparent
        Me.gbxDatagrid.Controls.Add(Me.btnBuscar)
        Me.gbxDatagrid.Controls.Add(Me.btnTodo)
        Me.gbxDatagrid.Controls.Add(Me.btnLimpiar)
        Me.gbxDatagrid.Controls.Add(Me.Label4)
        Me.gbxDatagrid.Controls.Add(Me.txtFecHasta)
        Me.gbxDatagrid.Controls.Add(Me.dgvTC)
        Me.gbxDatagrid.Controls.Add(Me.Label15)
        Me.gbxDatagrid.Controls.Add(Me.txtFecDesde)
        Me.gbxDatagrid.Location = New System.Drawing.Point(12, 205)
        Me.gbxDatagrid.Name = "gbxDatagrid"
        Me.gbxDatagrid.Size = New System.Drawing.Size(711, 252)
        Me.gbxDatagrid.TabIndex = 37
        Me.gbxDatagrid.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.ConsultaIn
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBuscar.Location = New System.Drawing.Point(552, 13)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(43, 43)
        Me.btnBuscar.TabIndex = 94
        Me.btnBuscar.Tag = ""
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnTodo
        '
        Me.btnTodo.BackgroundImage = Global.ByB_SI.My.Resources.Resources.TodosArtIn
        Me.btnTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTodo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTodo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnTodo.Location = New System.Drawing.Point(601, 13)
        Me.btnTodo.Name = "btnTodo"
        Me.btnTodo.Size = New System.Drawing.Size(43, 43)
        Me.btnTodo.TabIndex = 93
        Me.btnTodo.Tag = ""
        Me.btnTodo.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.CancelarIn
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLimpiar.Location = New System.Drawing.Point(650, 13)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(43, 43)
        Me.btnLimpiar.TabIndex = 92
        Me.btnLimpiar.Tag = ""
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label4.Location = New System.Drawing.Point(259, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Fecha Hasta"
        '
        'txtFecHasta
        '
        Me.txtFecHasta.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtFecHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecHasta.ForeColor = System.Drawing.Color.Teal
        Me.txtFecHasta.Location = New System.Drawing.Point(370, 31)
        Me.txtFecHasta.Name = "txtFecHasta"
        Me.txtFecHasta.Size = New System.Drawing.Size(109, 22)
        Me.txtFecHasta.TabIndex = 58
        '
        'dgvTC
        '
        Me.dgvTC.AllowUserToAddRows = False
        Me.dgvTC.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvTC.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvTC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTC.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTC.Location = New System.Drawing.Point(9, 62)
        Me.dgvTC.Name = "dgvTC"
        Me.dgvTC.ReadOnly = True
        Me.dgvTC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTC.Size = New System.Drawing.Size(696, 184)
        Me.dgvTC.TabIndex = 57
        '
        'Eliminar
        '
        Me.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Width = 49
        '
        'txtFecDesde
        '
        Me.txtFecDesde.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtFecDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecDesde.ForeColor = System.Drawing.Color.Teal
        Me.txtFecDesde.Location = New System.Drawing.Point(126, 31)
        Me.txtFecDesde.Name = "txtFecDesde"
        Me.txtFecDesde.Size = New System.Drawing.Size(109, 22)
        Me.txtFecDesde.TabIndex = 22
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.EliminarIn
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.Location = New System.Drawing.Point(729, 267)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(61, 59)
        Me.btnEliminar.TabIndex = 34
        Me.btnEliminar.Tag = ""
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.BackgroundImage = Global.ByB_SI.My.Resources.Resources.NuevoIn
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnNuevo.Location = New System.Drawing.Point(528, 140)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(61, 59)
        Me.btnNuevo.TabIndex = 30
        Me.btnNuevo.Tag = ""
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'tmrMensaje
        '
        Me.tmrMensaje.Interval = 5000
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label12.Location = New System.Drawing.Point(12, 81)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 16)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Tipo Cambio"
        '
        'txtTC
        '
        Me.txtTC.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTC.ForeColor = System.Drawing.Color.Teal
        Me.txtTC.Location = New System.Drawing.Point(201, 78)
        Me.txtTC.Name = "txtTC"
        Me.txtTC.Size = New System.Drawing.Size(88, 22)
        Me.txtTC.TabIndex = 12
        Me.txtTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.GuardarIn
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnGuardar.Location = New System.Drawing.Point(662, 140)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(61, 60)
        Me.btnGuardar.TabIndex = 32
        Me.btnGuardar.Tag = ""
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = Global.ByB_SI.My.Resources.Resources.SalirIn
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Location = New System.Drawing.Point(729, 390)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(61, 61)
        Me.btnSalir.TabIndex = 35
        Me.btnSalir.Tag = ""
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'gbxTC
        '
        Me.gbxTC.BackColor = System.Drawing.Color.Transparent
        Me.gbxTC.Controls.Add(Me.lblUltimoTC)
        Me.gbxTC.Controls.Add(Me.lblUltimaFec)
        Me.gbxTC.Controls.Add(Me.Label1)
        Me.gbxTC.Controls.Add(Me.Label3)
        Me.gbxTC.Controls.Add(Me.lblTC)
        Me.gbxTC.Controls.Add(Me.lblFuncion)
        Me.gbxTC.Controls.Add(Me.Label12)
        Me.gbxTC.Controls.Add(Me.txtTC)
        Me.gbxTC.Controls.Add(Me.Label2)
        Me.gbxTC.Controls.Add(Me.txtFecha)
        Me.gbxTC.Enabled = False
        Me.gbxTC.Location = New System.Drawing.Point(138, 5)
        Me.gbxTC.Name = "gbxTC"
        Me.gbxTC.Size = New System.Drawing.Size(652, 129)
        Me.gbxTC.TabIndex = 36
        Me.gbxTC.TabStop = False
        '
        'lblUltimoTC
        '
        Me.lblUltimoTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUltimoTC.ForeColor = System.Drawing.Color.LightGray
        Me.lblUltimoTC.Location = New System.Drawing.Point(542, 80)
        Me.lblUltimoTC.Name = "lblUltimoTC"
        Me.lblUltimoTC.Size = New System.Drawing.Size(94, 19)
        Me.lblUltimoTC.TabIndex = 63
        Me.lblUltimoTC.Text = "1.00"
        Me.lblUltimoTC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUltimaFec
        '
        Me.lblUltimaFec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUltimaFec.ForeColor = System.Drawing.Color.LightGray
        Me.lblUltimaFec.Location = New System.Drawing.Point(539, 36)
        Me.lblUltimaFec.Name = "lblUltimaFec"
        Me.lblUltimaFec.Size = New System.Drawing.Size(97, 19)
        Me.lblUltimaFec.TabIndex = 62
        Me.lblUltimaFec.Text = "01/01/2016"
        Me.lblUltimaFec.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label1.Location = New System.Drawing.Point(358, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 16)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Tipo Cambio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label3.Location = New System.Drawing.Point(358, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 16)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Ultima Fecha Registrada"
        '
        'lblTC
        '
        Me.lblTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTC.ForeColor = System.Drawing.Color.LightGray
        Me.lblTC.Location = New System.Drawing.Point(133, 81)
        Me.lblTC.Name = "lblTC"
        Me.lblTC.Size = New System.Drawing.Size(62, 19)
        Me.lblTC.TabIndex = 59
        Me.lblTC.Text = "1 U$S = "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label2.Location = New System.Drawing.Point(12, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Fecha"
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.ForeColor = System.Drawing.Color.Teal
        Me.txtFecha.Location = New System.Drawing.Point(136, 34)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(153, 26)
        Me.txtFecha.TabIndex = 0
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Image = Global.ByB_SI.My.Resources.Resources.IngresoAc
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'btnModificar
        '
        Me.btnModificar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.ModifIn
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnModificar.Location = New System.Drawing.Point(595, 140)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(61, 59)
        Me.btnModificar.TabIndex = 31
        Me.btnModificar.Tag = ""
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.Transparent
        Me.lblMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Location = New System.Drawing.Point(135, 159)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(387, 40)
        Me.lblMsg.TabIndex = 38
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.CancelarIn
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCancelar.Location = New System.Drawing.Point(729, 140)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(61, 60)
        Me.btnCancelar.TabIndex = 33
        Me.btnCancelar.Tag = ""
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblidTC
        '
        Me.lblidTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidTC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblidTC.Location = New System.Drawing.Point(18, 161)
        Me.lblidTC.Name = "lblidTC"
        Me.lblidTC.Size = New System.Drawing.Size(94, 19)
        Me.lblidTC.TabIndex = 64
        Me.lblidTC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblidTC.Visible = False
        '
        'frmTipoCambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ByB_SI.My.Resources.Resources.Fondo_23___Reducido
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(802, 470)
        Me.Controls.Add(Me.lblidTC)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gbxDatagrid)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.gbxTC)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.btnCancelar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTipoCambio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTipoCambio"
        Me.gbxDatagrid.ResumeLayout(False)
        Me.gbxDatagrid.PerformLayout()
        CType(Me.dgvTC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxTC.ResumeLayout(False)
        Me.gbxTC.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblFuncion As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents gbxDatagrid As System.Windows.Forms.GroupBox
    Friend WithEvents dgvTC As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents txtFecDesde As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents tmrMensaje As System.Windows.Forms.Timer
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTC As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents gbxTC As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblUltimoTC As System.Windows.Forms.Label
    Friend WithEvents lblUltimaFec As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTC As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFecHasta As System.Windows.Forms.TextBox
    Friend WithEvents lblidTC As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnTodo As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
End Class
