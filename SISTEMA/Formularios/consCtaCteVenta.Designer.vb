<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consCtaCteVenta
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(consCtaCteVenta))
        Me.btnImpStock = New System.Windows.Forms.Button()
        Me.txtFecEntrega = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvCliente = New System.Windows.Forms.DataGridView()
        Me.gbxBotones = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtBuscCliente = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.gbxDatagrid = New System.Windows.Forms.GroupBox()
        Me.dgvServTecnico = New System.Windows.Forms.DataGridView()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SaldoCta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtFecHasta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtProv = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIIBB = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCuit = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCondIVA = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxBotones.SuspendLayout()
        Me.gbxDatagrid.SuspendLayout()
        CType(Me.dgvServTecnico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImpStock
        '
        Me.btnImpStock.BackgroundImage = Global.ByB_SI.My.Resources.Resources.ImpresoraIn
        Me.btnImpStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnImpStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImpStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImpStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnImpStock.Location = New System.Drawing.Point(935, 148)
        Me.btnImpStock.Name = "btnImpStock"
        Me.btnImpStock.Size = New System.Drawing.Size(61, 62)
        Me.btnImpStock.TabIndex = 63
        Me.btnImpStock.Tag = ""
        Me.btnImpStock.UseVisualStyleBackColor = True
        '
        'txtFecEntrega
        '
        Me.txtFecEntrega.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtFecEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecEntrega.ForeColor = System.Drawing.Color.Teal
        Me.txtFecEntrega.Location = New System.Drawing.Point(710, 44)
        Me.txtFecEntrega.Name = "txtFecEntrega"
        Me.txtFecEntrega.Size = New System.Drawing.Size(102, 22)
        Me.txtFecEntrega.TabIndex = 129
        Me.txtFecEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Image = Global.ByB_SI.My.Resources.Resources.Facturas11
        Me.PictureBox1.Location = New System.Drawing.Point(9, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'dgvCliente
        '
        Me.dgvCliente.AllowUserToAddRows = False
        Me.dgvCliente.AllowUserToDeleteRows = False
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCliente.Location = New System.Drawing.Point(18, 44)
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.ReadOnly = True
        Me.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCliente.Size = New System.Drawing.Size(121, 53)
        Me.dgvCliente.TabIndex = 123
        Me.dgvCliente.VirtualMode = True
        '
        'gbxBotones
        '
        Me.gbxBotones.BackColor = System.Drawing.Color.Transparent
        Me.gbxBotones.Controls.Add(Me.Label10)
        Me.gbxBotones.Controls.Add(Me.txtCondIVA)
        Me.gbxBotones.Controls.Add(Me.Label9)
        Me.gbxBotones.Controls.Add(Me.txtCuit)
        Me.gbxBotones.Controls.Add(Me.Label8)
        Me.gbxBotones.Controls.Add(Me.txtIIBB)
        Me.gbxBotones.Controls.Add(Me.Label7)
        Me.gbxBotones.Controls.Add(Me.txtProv)
        Me.gbxBotones.Controls.Add(Me.Label6)
        Me.gbxBotones.Controls.Add(Me.txtCP)
        Me.gbxBotones.Controls.Add(Me.Label5)
        Me.gbxBotones.Controls.Add(Me.txtLocalidad)
        Me.gbxBotones.Controls.Add(Me.Label4)
        Me.gbxBotones.Controls.Add(Me.txtDireccion)
        Me.gbxBotones.Controls.Add(Me.Label3)
        Me.gbxBotones.Controls.Add(Me.Label2)
        Me.gbxBotones.Controls.Add(Me.txtFecHasta)
        Me.gbxBotones.Controls.Add(Me.txtFecEntrega)
        Me.gbxBotones.Controls.Add(Me.PictureBox1)
        Me.gbxBotones.Controls.Add(Me.dgvCliente)
        Me.gbxBotones.Controls.Add(Me.Label1)
        Me.gbxBotones.Controls.Add(Me.txtCliente)
        Me.gbxBotones.Controls.Add(Me.Label15)
        Me.gbxBotones.Controls.Add(Me.txtBuscCliente)
        Me.gbxBotones.Location = New System.Drawing.Point(3, 3)
        Me.gbxBotones.Name = "gbxBotones"
        Me.gbxBotones.Size = New System.Drawing.Size(926, 160)
        Me.gbxBotones.TabIndex = 66
        Me.gbxBotones.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label1.Location = New System.Drawing.Point(232, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "Cliente"
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCliente.Enabled = False
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.ForeColor = System.Drawing.Color.Teal
        Me.txtCliente.Location = New System.Drawing.Point(233, 44)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(471, 22)
        Me.txtCliente.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label15.Location = New System.Drawing.Point(159, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 18)
        Me.Label15.TabIndex = 116
        Me.Label15.Text = "Cta"
        '
        'txtBuscCliente
        '
        Me.txtBuscCliente.BackColor = System.Drawing.Color.DarkGray
        Me.txtBuscCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscCliente.ForeColor = System.Drawing.Color.Teal
        Me.txtBuscCliente.Location = New System.Drawing.Point(162, 44)
        Me.txtBuscCliente.Name = "txtBuscCliente"
        Me.txtBuscCliente.Size = New System.Drawing.Size(65, 22)
        Me.txtBuscCliente.TabIndex = 0
        Me.txtBuscCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.ConsultaIn
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBuscar.Location = New System.Drawing.Point(935, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(61, 62)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.Tag = ""
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.CancelarIn
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLimpiar.Location = New System.Drawing.Point(935, 80)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(61, 62)
        Me.btnLimpiar.TabIndex = 10
        Me.btnLimpiar.Tag = ""
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'gbxDatagrid
        '
        Me.gbxDatagrid.BackColor = System.Drawing.Color.Transparent
        Me.gbxDatagrid.Controls.Add(Me.dgvServTecnico)
        Me.gbxDatagrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDatagrid.ForeColor = System.Drawing.Color.LawnGreen
        Me.gbxDatagrid.Location = New System.Drawing.Point(3, 169)
        Me.gbxDatagrid.Name = "gbxDatagrid"
        Me.gbxDatagrid.Size = New System.Drawing.Size(926, 339)
        Me.gbxDatagrid.TabIndex = 65
        Me.gbxDatagrid.TabStop = False
        '
        'dgvServTecnico
        '
        Me.dgvServTecnico.AllowUserToAddRows = False
        Me.dgvServTecnico.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvServTecnico.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvServTecnico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvServTecnico.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServTecnico.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvServTecnico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServTecnico.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SaldoCta})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.LawnGreen
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvServTecnico.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvServTecnico.Location = New System.Drawing.Point(9, 17)
        Me.dgvServTecnico.Name = "dgvServTecnico"
        Me.dgvServTecnico.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServTecnico.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkGray
        Me.dgvServTecnico.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvServTecnico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvServTecnico.Size = New System.Drawing.Size(911, 316)
        Me.dgvServTecnico.TabIndex = 18
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = Global.ByB_SI.My.Resources.Resources.SalirIn
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Location = New System.Drawing.Point(935, 441)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(61, 61)
        Me.btnSalir.TabIndex = 64
        Me.btnSalir.Tag = ""
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'SaldoCta
        '
        Me.SaldoCta.HeaderText = "Saldo"
        Me.SaldoCta.Name = "SaldoCta"
        Me.SaldoCta.ReadOnly = True
        Me.SaldoCta.Width = 74
        '
        'txtFecHasta
        '
        Me.txtFecHasta.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtFecHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecHasta.ForeColor = System.Drawing.Color.Teal
        Me.txtFecHasta.Location = New System.Drawing.Point(818, 44)
        Me.txtFecHasta.Name = "txtFecHasta"
        Me.txtFecHasta.Size = New System.Drawing.Size(102, 22)
        Me.txtFecHasta.TabIndex = 132
        Me.txtFecHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label2.Location = New System.Drawing.Point(707, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 18)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "Fecha Desde"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label3.Location = New System.Drawing.Point(818, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 18)
        Me.Label3.TabIndex = 134
        Me.Label3.Text = "Fecha Hasta"
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ForeColor = System.Drawing.Color.Teal
        Me.txtDireccion.Location = New System.Drawing.Point(162, 87)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(227, 22)
        Me.txtDireccion.TabIndex = 135
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label4.Location = New System.Drawing.Point(159, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 18)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "Dirección"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label5.Location = New System.Drawing.Point(392, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 18)
        Me.Label5.TabIndex = 138
        Me.Label5.Text = "Localidad"
        '
        'txtLocalidad
        '
        Me.txtLocalidad.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtLocalidad.Enabled = False
        Me.txtLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalidad.ForeColor = System.Drawing.Color.Teal
        Me.txtLocalidad.Location = New System.Drawing.Point(395, 87)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(160, 22)
        Me.txtLocalidad.TabIndex = 137
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label6.Location = New System.Drawing.Point(558, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 18)
        Me.Label6.TabIndex = 140
        Me.Label6.Text = "Cod. Postal"
        '
        'txtCP
        '
        Me.txtCP.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCP.Enabled = False
        Me.txtCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCP.ForeColor = System.Drawing.Color.Teal
        Me.txtCP.Location = New System.Drawing.Point(561, 87)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(98, 22)
        Me.txtCP.TabIndex = 139
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label7.Location = New System.Drawing.Point(662, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 18)
        Me.Label7.TabIndex = 142
        Me.Label7.Text = "Provincia"
        '
        'txtProv
        '
        Me.txtProv.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtProv.Enabled = False
        Me.txtProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProv.ForeColor = System.Drawing.Color.Teal
        Me.txtProv.Location = New System.Drawing.Point(665, 87)
        Me.txtProv.Name = "txtProv"
        Me.txtProv.Size = New System.Drawing.Size(227, 22)
        Me.txtProv.TabIndex = 141
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label8.Location = New System.Drawing.Point(159, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 18)
        Me.Label8.TabIndex = 144
        Me.Label8.Text = "Ing. Brutos"
        '
        'txtIIBB
        '
        Me.txtIIBB.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtIIBB.Enabled = False
        Me.txtIIBB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIIBB.ForeColor = System.Drawing.Color.Teal
        Me.txtIIBB.Location = New System.Drawing.Point(162, 131)
        Me.txtIIBB.Name = "txtIIBB"
        Me.txtIIBB.Size = New System.Drawing.Size(227, 22)
        Me.txtIIBB.TabIndex = 143
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label9.Location = New System.Drawing.Point(392, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(150, 18)
        Me.Label9.TabIndex = 146
        Me.Label9.Text = "CUIT"
        '
        'txtCuit
        '
        Me.txtCuit.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCuit.Enabled = False
        Me.txtCuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuit.ForeColor = System.Drawing.Color.Teal
        Me.txtCuit.Location = New System.Drawing.Point(395, 132)
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.Size = New System.Drawing.Size(227, 22)
        Me.txtCuit.TabIndex = 145
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label10.Location = New System.Drawing.Point(625, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(213, 18)
        Me.Label10.TabIndex = 148
        Me.Label10.Text = "Condición Frente Al IVA"
        '
        'txtCondIVA
        '
        Me.txtCondIVA.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCondIVA.Enabled = False
        Me.txtCondIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCondIVA.ForeColor = System.Drawing.Color.Teal
        Me.txtCondIVA.Location = New System.Drawing.Point(628, 132)
        Me.txtCondIVA.Name = "txtCondIVA"
        Me.txtCondIVA.Size = New System.Drawing.Size(227, 22)
        Me.txtCondIVA.TabIndex = 147
        '
        'consCtaCteVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ByB_SI.My.Resources.Resources.Fondo_23___Reducido
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 642)
        Me.Controls.Add(Me.btnImpStock)
        Me.Controls.Add(Me.gbxBotones)
        Me.Controls.Add(Me.gbxDatagrid)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "consCtaCteVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "consCtaCteVenta"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxBotones.ResumeLayout(False)
        Me.gbxBotones.PerformLayout()
        Me.gbxDatagrid.ResumeLayout(False)
        CType(Me.dgvServTecnico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnImpStock As System.Windows.Forms.Button
    Friend WithEvents txtFecEntrega As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
    Friend WithEvents gbxBotones As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtBuscCliente As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents gbxDatagrid As System.Windows.Forms.GroupBox
    Friend WithEvents dgvServTecnico As System.Windows.Forms.DataGridView
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCondIVA As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCuit As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtIIBB As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtProv As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFecHasta As System.Windows.Forms.TextBox
    Friend WithEvents SaldoCta As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
