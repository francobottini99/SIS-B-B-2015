<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArticulos))
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblFuncion = New System.Windows.Forms.Label()
        Me.gbxDatagrid = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dgvArticulos = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtCdEmp = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbxClientes = New System.Windows.Forms.GroupBox()
        Me.lblNroFila = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTC = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblOrigen = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAlicIva = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPrecFinal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.txtIdCategoria = New System.Windows.Forms.TextBox()
        Me.chbReqStk = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodCategoria = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFecAlta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblIdUs = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.tmrMensaje = New System.Windows.Forms.Timer(Me.components)
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.chkManual = New System.Windows.Forms.CheckBox()
        Me.gbxDatagrid.SuspendLayout()
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbxClientes.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.ForeColor = System.Drawing.Color.Teal
        Me.txtBuscar.Location = New System.Drawing.Point(137, 13)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(760, 22)
        Me.txtBuscar.TabIndex = 22
        '
        'lblFuncion
        '
        Me.lblFuncion.Location = New System.Drawing.Point(817, 366)
        Me.lblFuncion.Name = "lblFuncion"
        Me.lblFuncion.Size = New System.Drawing.Size(74, 20)
        Me.lblFuncion.TabIndex = 31
        Me.lblFuncion.Visible = False
        '
        'gbxDatagrid
        '
        Me.gbxDatagrid.BackColor = System.Drawing.Color.Transparent
        Me.gbxDatagrid.Controls.Add(Me.Label15)
        Me.gbxDatagrid.Controls.Add(Me.txtBuscar)
        Me.gbxDatagrid.Controls.Add(Me.dgvArticulos)
        Me.gbxDatagrid.Location = New System.Drawing.Point(12, 278)
        Me.gbxDatagrid.Name = "gbxDatagrid"
        Me.gbxDatagrid.Size = New System.Drawing.Size(903, 252)
        Me.gbxDatagrid.TabIndex = 37
        Me.gbxDatagrid.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label15.Location = New System.Drawing.Point(15, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(116, 16)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "Buscar Artículo:"
        '
        'dgvArticulos
        '
        Me.dgvArticulos.AllowUserToAddRows = False
        Me.dgvArticulos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvArticulos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvArticulos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvArticulos.Location = New System.Drawing.Point(9, 41)
        Me.dgvArticulos.Name = "dgvArticulos"
        Me.dgvArticulos.ReadOnly = True
        Me.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvArticulos.Size = New System.Drawing.Size(888, 205)
        Me.dgvArticulos.TabIndex = 8
        '
        'Eliminar
        '
        Me.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Width = 49
        '
        'txtCdEmp
        '
        Me.txtCdEmp.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCdEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCdEmp.ForeColor = System.Drawing.Color.Teal
        Me.txtCdEmp.Location = New System.Drawing.Point(6, 18)
        Me.txtCdEmp.Name = "txtCdEmp"
        Me.txtCdEmp.Size = New System.Drawing.Size(153, 26)
        Me.txtCdEmp.TabIndex = 9
        Me.txtCdEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCdEmp)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.LawnGreen
        Me.GroupBox1.Location = New System.Drawing.Point(9, 195)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(165, 54)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Codigo Empresa"
        '
        'gbxClientes
        '
        Me.gbxClientes.BackColor = System.Drawing.Color.Transparent
        Me.gbxClientes.Controls.Add(Me.chkManual)
        Me.gbxClientes.Controls.Add(Me.lblNroFila)
        Me.gbxClientes.Controls.Add(Me.Label12)
        Me.gbxClientes.Controls.Add(Me.txtTC)
        Me.gbxClientes.Controls.Add(Me.Label11)
        Me.gbxClientes.Controls.Add(Me.Label10)
        Me.gbxClientes.Controls.Add(Me.lblOrigen)
        Me.gbxClientes.Controls.Add(Me.Label4)
        Me.gbxClientes.Controls.Add(Me.txtAlicIva)
        Me.gbxClientes.Controls.Add(Me.Label9)
        Me.gbxClientes.Controls.Add(Me.txtPrecFinal)
        Me.gbxClientes.Controls.Add(Me.Label3)
        Me.gbxClientes.Controls.Add(Me.lblMsg)
        Me.gbxClientes.Controls.Add(Me.txtIdCategoria)
        Me.gbxClientes.Controls.Add(Me.chbReqStk)
        Me.gbxClientes.Controls.Add(Me.GroupBox1)
        Me.gbxClientes.Controls.Add(Me.lblFuncion)
        Me.gbxClientes.Controls.Add(Me.Label8)
        Me.gbxClientes.Controls.Add(Me.txtUnidad)
        Me.gbxClientes.Controls.Add(Me.Label7)
        Me.gbxClientes.Controls.Add(Me.txtPrecio)
        Me.gbxClientes.Controls.Add(Me.Label6)
        Me.gbxClientes.Controls.Add(Me.txtCodCategoria)
        Me.gbxClientes.Controls.Add(Me.Label2)
        Me.gbxClientes.Controls.Add(Me.txtFecAlta)
        Me.gbxClientes.Controls.Add(Me.Label5)
        Me.gbxClientes.Controls.Add(Me.lblIdUs)
        Me.gbxClientes.Controls.Add(Me.Label1)
        Me.gbxClientes.Controls.Add(Me.PictureBox1)
        Me.gbxClientes.Controls.Add(Me.txtDescripcion)
        Me.gbxClientes.Enabled = False
        Me.gbxClientes.Location = New System.Drawing.Point(12, 12)
        Me.gbxClientes.Name = "gbxClientes"
        Me.gbxClientes.Size = New System.Drawing.Size(903, 260)
        Me.gbxClientes.TabIndex = 36
        Me.gbxClientes.TabStop = False
        '
        'lblNroFila
        '
        Me.lblNroFila.BackColor = System.Drawing.SystemColors.Control
        Me.lblNroFila.Location = New System.Drawing.Point(174, 7)
        Me.lblNroFila.Name = "lblNroFila"
        Me.lblNroFila.Size = New System.Drawing.Size(74, 20)
        Me.lblNroFila.TabIndex = 84
        Me.lblNroFila.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label12.Location = New System.Drawing.Point(718, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 16)
        Me.Label12.TabIndex = 83
        Me.Label12.Text = "Tipo Cambio:"
        '
        'txtTC
        '
        Me.txtTC.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtTC.Enabled = False
        Me.txtTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTC.ForeColor = System.Drawing.Color.Teal
        Me.txtTC.Location = New System.Drawing.Point(825, 19)
        Me.txtTC.Name = "txtTC"
        Me.txtTC.Size = New System.Drawing.Size(72, 22)
        Me.txtTC.TabIndex = 82
        Me.txtTC.Text = "$ 0.00"
        Me.txtTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label11.Location = New System.Drawing.Point(456, 199)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 16)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "U$S"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label10.Location = New System.Drawing.Point(456, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 16)
        Me.Label10.TabIndex = 80
        Me.Label10.Text = "U$S"
        '
        'lblOrigen
        '
        Me.lblOrigen.BackColor = System.Drawing.SystemColors.Control
        Me.lblOrigen.Location = New System.Drawing.Point(94, 46)
        Me.lblOrigen.Name = "lblOrigen"
        Me.lblOrigen.Size = New System.Drawing.Size(74, 20)
        Me.lblOrigen.TabIndex = 79
        Me.lblOrigen.Text = "Articulos"
        Me.lblOrigen.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label4.Location = New System.Drawing.Point(453, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 16)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "%"
        '
        'txtAlicIva
        '
        Me.txtAlicIva.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtAlicIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlicIva.ForeColor = System.Drawing.Color.Teal
        Me.txtAlicIva.Location = New System.Drawing.Point(316, 163)
        Me.txtAlicIva.Name = "txtAlicIva"
        Me.txtAlicIva.Size = New System.Drawing.Size(134, 22)
        Me.txtAlicIva.TabIndex = 77
        Me.txtAlicIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label9.Location = New System.Drawing.Point(180, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 16)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "Precio Final"
        '
        'txtPrecFinal
        '
        Me.txtPrecFinal.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtPrecFinal.Enabled = False
        Me.txtPrecFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecFinal.ForeColor = System.Drawing.Color.Teal
        Me.txtPrecFinal.Location = New System.Drawing.Point(316, 193)
        Me.txtPrecFinal.Name = "txtPrecFinal"
        Me.txtPrecFinal.Size = New System.Drawing.Size(134, 26)
        Me.txtPrecFinal.TabIndex = 75
        Me.txtPrecFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label3.Location = New System.Drawing.Point(180, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Alicuota IVA"
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.Transparent
        Me.lblMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Location = New System.Drawing.Point(551, 213)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(346, 36)
        Me.lblMsg.TabIndex = 70
        '
        'txtIdCategoria
        '
        Me.txtIdCategoria.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtIdCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCategoria.ForeColor = System.Drawing.Color.Teal
        Me.txtIdCategoria.Location = New System.Drawing.Point(456, 47)
        Me.txtIdCategoria.Name = "txtIdCategoria"
        Me.txtIdCategoria.Size = New System.Drawing.Size(72, 22)
        Me.txtIdCategoria.TabIndex = 69
        Me.txtIdCategoria.Visible = False
        '
        'chbReqStk
        '
        Me.chbReqStk.AutoSize = True
        Me.chbReqStk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbReqStk.ForeColor = System.Drawing.Color.LawnGreen
        Me.chbReqStk.Location = New System.Drawing.Point(316, 229)
        Me.chbReqStk.Name = "chbReqStk"
        Me.chbReqStk.Size = New System.Drawing.Size(134, 20)
        Me.chbReqStk.TabIndex = 5
        Me.chbReqStk.Text = "Requiere Stock"
        Me.chbReqStk.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label8.Location = New System.Drawing.Point(180, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 16)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Precio"
        '
        'txtUnidad
        '
        Me.txtUnidad.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnidad.ForeColor = System.Drawing.Color.Teal
        Me.txtUnidad.Location = New System.Drawing.Point(316, 107)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(134, 22)
        Me.txtUnidad.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label7.Location = New System.Drawing.Point(180, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Unidad"
        '
        'txtPrecio
        '
        Me.txtPrecio.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.ForeColor = System.Drawing.Color.Teal
        Me.txtPrecio.Location = New System.Drawing.Point(316, 135)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(134, 22)
        Me.txtPrecio.TabIndex = 3
        Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label6.Location = New System.Drawing.Point(180, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 16)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Codigo Categoría"
        '
        'txtCodCategoria
        '
        Me.txtCodCategoria.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCodCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCategoria.ForeColor = System.Drawing.Color.Teal
        Me.txtCodCategoria.Location = New System.Drawing.Point(316, 47)
        Me.txtCodCategoria.Name = "txtCodCategoria"
        Me.txtCodCategoria.Size = New System.Drawing.Size(134, 22)
        Me.txtCodCategoria.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label2.Location = New System.Drawing.Point(180, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Fecha Alta"
        '
        'txtFecAlta
        '
        Me.txtFecAlta.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtFecAlta.Enabled = False
        Me.txtFecAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecAlta.ForeColor = System.Drawing.Color.Teal
        Me.txtFecAlta.Location = New System.Drawing.Point(316, 19)
        Me.txtFecAlta.Name = "txtFecAlta"
        Me.txtFecAlta.Size = New System.Drawing.Size(134, 22)
        Me.txtFecAlta.TabIndex = 0
        Me.txtFecAlta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label5.Location = New System.Drawing.Point(180, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 16)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Descripción"
        '
        'lblIdUs
        '
        Me.lblIdUs.BackColor = System.Drawing.SystemColors.Control
        Me.lblIdUs.Location = New System.Drawing.Point(94, 11)
        Me.lblIdUs.Name = "lblIdUs"
        Me.lblIdUs.Size = New System.Drawing.Size(74, 20)
        Me.lblIdUs.TabIndex = 32
        Me.lblIdUs.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Cliente"
        Me.Label1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Image = Global.ByB_SI.My.Resources.Resources.Articulos
        Me.PictureBox1.Location = New System.Drawing.Point(9, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtDescripcion.Location = New System.Drawing.Point(316, 75)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(581, 26)
        Me.txtDescripcion.TabIndex = 2
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.EliminarIn
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.Location = New System.Drawing.Point(924, 319)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(61, 59)
        Me.btnEliminar.TabIndex = 14
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
        Me.btnNuevo.Location = New System.Drawing.Point(924, 19)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(61, 59)
        Me.btnNuevo.TabIndex = 10
        Me.btnNuevo.Tag = ""
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = Global.ByB_SI.My.Resources.Resources.SalirIn
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Location = New System.Drawing.Point(924, 469)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(61, 61)
        Me.btnSalir.TabIndex = 15
        Me.btnSalir.Tag = ""
        Me.btnSalir.UseVisualStyleBackColor = True
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
        Me.btnGuardar.Location = New System.Drawing.Point(924, 150)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(61, 60)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Tag = ""
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.CancelarIn
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCancelar.Location = New System.Drawing.Point(924, 216)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(61, 60)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Tag = ""
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'tmrMensaje
        '
        Me.tmrMensaje.Interval = 5000
        '
        'btnModificar
        '
        Me.btnModificar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.ModifIn
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnModificar.Location = New System.Drawing.Point(924, 85)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(61, 59)
        Me.btnModificar.TabIndex = 11
        Me.btnModificar.Tag = ""
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'chkManual
        '
        Me.chkManual.AutoSize = True
        Me.chkManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkManual.ForeColor = System.Drawing.Color.Orange
        Me.chkManual.Location = New System.Drawing.Point(570, 229)
        Me.chkManual.Name = "chkManual"
        Me.chkManual.Size = New System.Drawing.Size(321, 20)
        Me.chkManual.TabIndex = 85
        Me.chkManual.Text = "Atrubutos Especiales Para Factura Manual"
        Me.chkManual.UseVisualStyleBackColor = True
        '
        'frmArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ByB_SI.My.Resources.Resources.Fondo_23___Reducido
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(994, 543)
        Me.Controls.Add(Me.gbxDatagrid)
        Me.Controls.Add(Me.gbxClientes)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnModificar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmArticulos"
        Me.gbxDatagrid.ResumeLayout(False)
        Me.gbxDatagrid.PerformLayout()
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbxClientes.ResumeLayout(False)
        Me.gbxClientes.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents lblFuncion As System.Windows.Forms.Label
    Friend WithEvents gbxDatagrid As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dgvArticulos As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents txtCdEmp As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbxClientes As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCodCategoria As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFecAlta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblIdUs As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents tmrMensaje As System.Windows.Forms.Timer
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents chbReqStk As System.Windows.Forms.CheckBox
    Friend WithEvents txtIdCategoria As System.Windows.Forms.TextBox
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPrecFinal As System.Windows.Forms.TextBox
    Friend WithEvents txtAlicIva As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblOrigen As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTC As System.Windows.Forms.TextBox
    Friend WithEvents lblNroFila As System.Windows.Forms.Label
    Friend WithEvents chkManual As System.Windows.Forms.CheckBox
End Class
