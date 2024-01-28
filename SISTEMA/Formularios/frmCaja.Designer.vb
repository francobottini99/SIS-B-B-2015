<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaja
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCaja))
        Me.lblOrigen = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvValEnCartera = New System.Windows.Forms.DataGridView()
        Me.txtCdEmp = New System.Windows.Forms.TextBox()
        Me.gbxDatagrid = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtEfectivo = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtCantChqCartera = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtImpChqCartera = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.SaldoDia = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtSaldoAnt = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtSaldoCaja = New System.Windows.Forms.TextBox()
        Me.dgvCaja = New System.Windows.Forms.DataGridView()
        Me.txtObserv = New System.Windows.Forms.TextBox()
        Me.btnEliminarValor = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.tmrMensaje = New System.Windows.Forms.Timer(Me.components)
        Me.txtIdCli = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gbxDatos = New System.Windows.Forms.GroupBox()
        Me.lblFuncion = New System.Windows.Forms.Label()
        Me.lblIdUs = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtIdProv = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFecAlta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxTipoMov = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvCliente = New System.Windows.Forms.DataGridView()
        Me.dgvProveedor = New System.Windows.Forms.DataGridView()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbxDetalle = New System.Windows.Forms.GroupBox()
        Me.btnValEnCartera = New System.Windows.Forms.Button()
        Me.lblFunValor = New System.Windows.Forms.Label()
        Me.lblidDetCaja = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLibrador = New System.Windows.Forms.TextBox()
        Me.btnCancelarValor = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnModValor = New System.Windows.Forms.Button()
        Me.cbxTipoValor = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnCargarValor = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtObsValor = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtImpValor = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtFecCobro = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtSucursal = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtValNum = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cbxBanco = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgvBufDetalle = New System.Windows.Forms.DataGridView()
        Me.ElimBuff = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.tmrHora = New System.Windows.Forms.Timer(Me.components)
        Me.txtTotVal = New System.Windows.Forms.TextBox()
        Me.gbxValores = New System.Windows.Forms.GroupBox()
        Me.tmrSaldos = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvValEnCartera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatagrid.SuspendLayout()
        CType(Me.dgvCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatos.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDetalle.SuspendLayout()
        CType(Me.dgvBufDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxValores.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblOrigen
        '
        Me.lblOrigen.BackColor = System.Drawing.SystemColors.Control
        Me.lblOrigen.Location = New System.Drawing.Point(559, 12)
        Me.lblOrigen.Name = "lblOrigen"
        Me.lblOrigen.Size = New System.Drawing.Size(59, 20)
        Me.lblOrigen.TabIndex = 67
        Me.lblOrigen.Text = "Cliente"
        Me.lblOrigen.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvValEnCartera)
        Me.GroupBox1.Controls.Add(Me.txtCdEmp)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.LawnGreen
        Me.GroupBox1.Location = New System.Drawing.Point(9, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(138, 54)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Codigo Empresa"
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.LawnGreen
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvValEnCartera.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvValEnCartera.Location = New System.Drawing.Point(14, 5)
        Me.dgvValEnCartera.Name = "dgvValEnCartera"
        Me.dgvValEnCartera.ReadOnly = True
        Me.dgvValEnCartera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvValEnCartera.Size = New System.Drawing.Size(99, 26)
        Me.dgvValEnCartera.TabIndex = 112
        '
        'txtCdEmp
        '
        Me.txtCdEmp.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCdEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCdEmp.ForeColor = System.Drawing.Color.Teal
        Me.txtCdEmp.Location = New System.Drawing.Point(6, 21)
        Me.txtCdEmp.Name = "txtCdEmp"
        Me.txtCdEmp.Size = New System.Drawing.Size(123, 26)
        Me.txtCdEmp.TabIndex = 60
        Me.txtCdEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbxDatagrid
        '
        Me.gbxDatagrid.BackColor = System.Drawing.Color.Transparent
        Me.gbxDatagrid.Controls.Add(Me.Label25)
        Me.gbxDatagrid.Controls.Add(Me.txtEfectivo)
        Me.gbxDatagrid.Controls.Add(Me.Label24)
        Me.gbxDatagrid.Controls.Add(Me.txtCantChqCartera)
        Me.gbxDatagrid.Controls.Add(Me.Label23)
        Me.gbxDatagrid.Controls.Add(Me.txtImpChqCartera)
        Me.gbxDatagrid.Controls.Add(Me.Label22)
        Me.gbxDatagrid.Controls.Add(Me.SaldoDia)
        Me.gbxDatagrid.Controls.Add(Me.Label17)
        Me.gbxDatagrid.Controls.Add(Me.txtSaldoAnt)
        Me.gbxDatagrid.Controls.Add(Me.Label16)
        Me.gbxDatagrid.Controls.Add(Me.txtSaldoCaja)
        Me.gbxDatagrid.Controls.Add(Me.dgvCaja)
        Me.gbxDatagrid.Location = New System.Drawing.Point(9, 334)
        Me.gbxDatagrid.Name = "gbxDatagrid"
        Me.gbxDatagrid.Size = New System.Drawing.Size(920, 237)
        Me.gbxDatagrid.TabIndex = 37
        Me.gbxDatagrid.TabStop = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label25.Location = New System.Drawing.Point(664, 182)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(109, 16)
        Me.Label25.TabIndex = 116
        Me.Label25.Text = "Saldo Efectivo"
        '
        'txtEfectivo
        '
        Me.txtEfectivo.BackColor = System.Drawing.Color.OliveDrab
        Me.txtEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEfectivo.ForeColor = System.Drawing.Color.White
        Me.txtEfectivo.Location = New System.Drawing.Point(667, 200)
        Me.txtEfectivo.Name = "txtEfectivo"
        Me.txtEfectivo.Size = New System.Drawing.Size(119, 26)
        Me.txtEfectivo.TabIndex = 117
        Me.txtEfectivo.Text = "$ 0.00"
        Me.txtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label24.Location = New System.Drawing.Point(125, 182)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(129, 16)
        Me.Label24.TabIndex = 115
        Me.Label24.Text = "Cant. Chq Cartera"
        '
        'txtCantChqCartera
        '
        Me.txtCantChqCartera.BackColor = System.Drawing.Color.DarkOrange
        Me.txtCantChqCartera.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantChqCartera.ForeColor = System.Drawing.Color.White
        Me.txtCantChqCartera.Location = New System.Drawing.Point(128, 200)
        Me.txtCantChqCartera.Name = "txtCantChqCartera"
        Me.txtCantChqCartera.Size = New System.Drawing.Size(119, 26)
        Me.txtCantChqCartera.TabIndex = 114
        Me.txtCantChqCartera.Text = "0.00"
        Me.txtCantChqCartera.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label23.Location = New System.Drawing.Point(3, 181)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(102, 16)
        Me.Label23.TabIndex = 112
        Me.Label23.Text = "$ Chq Cartera"
        '
        'txtImpChqCartera
        '
        Me.txtImpChqCartera.BackColor = System.Drawing.Color.DarkOrange
        Me.txtImpChqCartera.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpChqCartera.ForeColor = System.Drawing.Color.White
        Me.txtImpChqCartera.Location = New System.Drawing.Point(3, 200)
        Me.txtImpChqCartera.Name = "txtImpChqCartera"
        Me.txtImpChqCartera.Size = New System.Drawing.Size(119, 26)
        Me.txtImpChqCartera.TabIndex = 113
        Me.txtImpChqCartera.Text = "$ 0.00"
        Me.txtImpChqCartera.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label22.Location = New System.Drawing.Point(463, 182)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(105, 16)
        Me.Label22.TabIndex = 110
        Me.Label22.Text = "Saldo Del Día"
        '
        'SaldoDia
        '
        Me.SaldoDia.BackColor = System.Drawing.Color.DarkOrange
        Me.SaldoDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaldoDia.ForeColor = System.Drawing.Color.White
        Me.SaldoDia.Location = New System.Drawing.Point(466, 200)
        Me.SaldoDia.Name = "SaldoDia"
        Me.SaldoDia.Size = New System.Drawing.Size(119, 26)
        Me.SaldoDia.TabIndex = 111
        Me.SaldoDia.Text = "$ 0.00"
        Me.SaldoDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label17.Location = New System.Drawing.Point(338, 182)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(107, 16)
        Me.Label17.TabIndex = 108
        Me.Label17.Text = "Saldo Anterior"
        '
        'txtSaldoAnt
        '
        Me.txtSaldoAnt.BackColor = System.Drawing.Color.DarkOrange
        Me.txtSaldoAnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoAnt.ForeColor = System.Drawing.Color.White
        Me.txtSaldoAnt.Location = New System.Drawing.Point(341, 200)
        Me.txtSaldoAnt.Name = "txtSaldoAnt"
        Me.txtSaldoAnt.Size = New System.Drawing.Size(119, 26)
        Me.txtSaldoAnt.TabIndex = 109
        Me.txtSaldoAnt.Text = "$ 0.00"
        Me.txtSaldoAnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DarkRed
        Me.Label16.Location = New System.Drawing.Point(789, 181)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(85, 16)
        Me.Label16.TabIndex = 106
        Me.Label16.Text = "Saldo Caja"
        '
        'txtSaldoCaja
        '
        Me.txtSaldoCaja.BackColor = System.Drawing.Color.DarkRed
        Me.txtSaldoCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoCaja.ForeColor = System.Drawing.Color.White
        Me.txtSaldoCaja.Location = New System.Drawing.Point(792, 200)
        Me.txtSaldoCaja.Name = "txtSaldoCaja"
        Me.txtSaldoCaja.Size = New System.Drawing.Size(119, 26)
        Me.txtSaldoCaja.TabIndex = 107
        Me.txtSaldoCaja.Text = "$ 0.00"
        Me.txtSaldoCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvCaja
        '
        Me.dgvCaja.AllowUserToAddRows = False
        Me.dgvCaja.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCaja.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvCaja.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCaja.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCaja.Location = New System.Drawing.Point(6, 14)
        Me.dgvCaja.Name = "dgvCaja"
        Me.dgvCaja.ReadOnly = True
        Me.dgvCaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCaja.Size = New System.Drawing.Size(908, 165)
        Me.dgvCaja.TabIndex = 57
        '
        'txtObserv
        '
        Me.txtObserv.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtObserv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObserv.ForeColor = System.Drawing.Color.Teal
        Me.txtObserv.Location = New System.Drawing.Point(147, 123)
        Me.txtObserv.Name = "txtObserv"
        Me.txtObserv.Size = New System.Drawing.Size(753, 22)
        Me.txtObserv.TabIndex = 13
        '
        'btnEliminarValor
        '
        Me.btnEliminarValor.BackgroundImage = Global.ByB_SI.My.Resources.Resources.EliminarIn
        Me.btnEliminarValor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEliminarValor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarValor.Location = New System.Drawing.Point(459, 134)
        Me.btnEliminarValor.Name = "btnEliminarValor"
        Me.btnEliminarValor.Size = New System.Drawing.Size(37, 38)
        Me.btnEliminarValor.TabIndex = 34
        Me.btnEliminarValor.Tag = ""
        Me.btnEliminarValor.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.BackgroundImage = Global.ByB_SI.My.Resources.Resources.NuevoIn
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnNuevo.Location = New System.Drawing.Point(935, 345)
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
        'txtIdCli
        '
        Me.txtIdCli.BackColor = System.Drawing.Color.DarkGray
        Me.txtIdCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCli.ForeColor = System.Drawing.Color.Black
        Me.txtIdCli.Location = New System.Drawing.Point(375, 32)
        Me.txtIdCli.Name = "txtIdCli"
        Me.txtIdCli.Size = New System.Drawing.Size(72, 22)
        Me.txtIdCli.TabIndex = 10
        Me.txtIdCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label9.Location = New System.Drawing.Point(144, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 16)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Observaciones"
        '
        'txtImporte
        '
        Me.txtImporte.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.ForeColor = System.Drawing.Color.Teal
        Me.txtImporte.Location = New System.Drawing.Point(9, 123)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(132, 22)
        Me.txtImporte.TabIndex = 6
        Me.txtImporte.Text = "$ 0.00"
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.btnGuardar.Location = New System.Drawing.Point(1002, 344)
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
        Me.btnSalir.Location = New System.Drawing.Point(1002, 510)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(61, 61)
        Me.btnSalir.TabIndex = 35
        Me.btnSalir.Tag = ""
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'gbxDatos
        '
        Me.gbxDatos.BackColor = System.Drawing.Color.Transparent
        Me.gbxDatos.Controls.Add(Me.lblFuncion)
        Me.gbxDatos.Controls.Add(Me.lblIdUs)
        Me.gbxDatos.Controls.Add(Me.lblOrigen)
        Me.gbxDatos.Controls.Add(Me.Label15)
        Me.gbxDatos.Controls.Add(Me.txtIdProv)
        Me.gbxDatos.Controls.Add(Me.Label19)
        Me.gbxDatos.Controls.Add(Me.txtObserv)
        Me.gbxDatos.Controls.Add(Me.txtIdCli)
        Me.gbxDatos.Controls.Add(Me.Label9)
        Me.gbxDatos.Controls.Add(Me.txtImporte)
        Me.gbxDatos.Controls.Add(Me.Label8)
        Me.gbxDatos.Controls.Add(Me.txtDetalle)
        Me.gbxDatos.Controls.Add(Me.Label7)
        Me.gbxDatos.Controls.Add(Me.txtHora)
        Me.gbxDatos.Controls.Add(Me.Label6)
        Me.gbxDatos.Controls.Add(Me.txtProveedor)
        Me.gbxDatos.Controls.Add(Me.Label4)
        Me.gbxDatos.Controls.Add(Me.txtCliente)
        Me.gbxDatos.Controls.Add(Me.Label2)
        Me.gbxDatos.Controls.Add(Me.txtFecAlta)
        Me.gbxDatos.Controls.Add(Me.Label5)
        Me.gbxDatos.Controls.Add(Me.cbxTipoMov)
        Me.gbxDatos.Enabled = False
        Me.gbxDatos.Location = New System.Drawing.Point(157, 2)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.Size = New System.Drawing.Size(906, 153)
        Me.gbxDatos.TabIndex = 36
        Me.gbxDatos.TabStop = False
        '
        'lblFuncion
        '
        Me.lblFuncion.BackColor = System.Drawing.Color.White
        Me.lblFuncion.Location = New System.Drawing.Point(701, 12)
        Me.lblFuncion.Name = "lblFuncion"
        Me.lblFuncion.Size = New System.Drawing.Size(59, 20)
        Me.lblFuncion.TabIndex = 101
        Me.lblFuncion.Visible = False
        '
        'lblIdUs
        '
        Me.lblIdUs.BackColor = System.Drawing.SystemColors.Control
        Me.lblIdUs.Location = New System.Drawing.Point(624, 12)
        Me.lblIdUs.Name = "lblIdUs"
        Me.lblIdUs.Size = New System.Drawing.Size(71, 20)
        Me.lblIdUs.TabIndex = 32
        Me.lblIdUs.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label15.Location = New System.Drawing.Point(453, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 16)
        Me.Label15.TabIndex = 71
        Me.Label15.Text = "Razón Social"
        '
        'txtIdProv
        '
        Me.txtIdProv.BackColor = System.Drawing.Color.DarkGray
        Me.txtIdProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdProv.ForeColor = System.Drawing.Color.Black
        Me.txtIdProv.Location = New System.Drawing.Point(9, 79)
        Me.txtIdProv.Name = "txtIdProv"
        Me.txtIdProv.Size = New System.Drawing.Size(72, 22)
        Me.txtIdProv.TabIndex = 70
        Me.txtIdProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label19.Location = New System.Drawing.Point(147, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 16)
        Me.Label19.TabIndex = 69
        Me.Label19.Text = "Hora"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label8.Location = New System.Drawing.Point(6, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 16)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Importe"
        '
        'txtDetalle
        '
        Me.txtDetalle.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalle.ForeColor = System.Drawing.Color.Teal
        Me.txtDetalle.Location = New System.Drawing.Point(453, 79)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(447, 22)
        Me.txtDetalle.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label7.Location = New System.Drawing.Point(453, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 16)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Detalle Movimiento"
        '
        'txtHora
        '
        Me.txtHora.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtHora.Enabled = False
        Me.txtHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHora.ForeColor = System.Drawing.Color.Teal
        Me.txtHora.Location = New System.Drawing.Point(146, 32)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(85, 22)
        Me.txtHora.TabIndex = 4
        Me.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label6.Location = New System.Drawing.Point(6, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 16)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Destinatario"
        '
        'txtProveedor
        '
        Me.txtProveedor.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedor.ForeColor = System.Drawing.Color.Teal
        Me.txtProveedor.Location = New System.Drawing.Point(87, 79)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(360, 22)
        Me.txtProveedor.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label4.Location = New System.Drawing.Point(375, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Emisor"
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.ForeColor = System.Drawing.Color.Teal
        Me.txtCliente.Location = New System.Drawing.Point(453, 32)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(447, 22)
        Me.txtCliente.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Fecha"
        '
        'txtFecAlta
        '
        Me.txtFecAlta.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtFecAlta.Enabled = False
        Me.txtFecAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecAlta.ForeColor = System.Drawing.Color.Teal
        Me.txtFecAlta.Location = New System.Drawing.Point(9, 32)
        Me.txtFecAlta.Name = "txtFecAlta"
        Me.txtFecAlta.Size = New System.Drawing.Size(132, 22)
        Me.txtFecAlta.TabIndex = 0
        Me.txtFecAlta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label5.Location = New System.Drawing.Point(234, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 16)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Tipo Movimiento"
        '
        'cbxTipoMov
        '
        Me.cbxTipoMov.BackColor = System.Drawing.Color.MediumTurquoise
        Me.cbxTipoMov.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipoMov.ForeColor = System.Drawing.Color.Teal
        Me.cbxTipoMov.FormattingEnabled = True
        Me.cbxTipoMov.Items.AddRange(New Object() {"Ingreso", "Egreso"})
        Me.cbxTipoMov.Location = New System.Drawing.Point(237, 32)
        Me.cbxTipoMov.Name = "cbxTipoMov"
        Me.cbxTipoMov.Size = New System.Drawing.Size(132, 24)
        Me.cbxTipoMov.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Image = Global.ByB_SI.My.Resources.Resources.Caja1
        Me.PictureBox1.Location = New System.Drawing.Point(9, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(138, 146)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'dgvCliente
        '
        Me.dgvCliente.AllowUserToAddRows = False
        Me.dgvCliente.AllowUserToDeleteRows = False
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCliente.Location = New System.Drawing.Point(18, 18)
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.ReadOnly = True
        Me.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCliente.Size = New System.Drawing.Size(113, 38)
        Me.dgvCliente.TabIndex = 99
        Me.dgvCliente.VirtualMode = True
        '
        'dgvProveedor
        '
        Me.dgvProveedor.AllowUserToAddRows = False
        Me.dgvProveedor.AllowUserToDeleteRows = False
        Me.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProveedor.Location = New System.Drawing.Point(18, 62)
        Me.dgvProveedor.Name = "dgvProveedor"
        Me.dgvProveedor.ReadOnly = True
        Me.dgvProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProveedor.Size = New System.Drawing.Size(113, 35)
        Me.dgvProveedor.TabIndex = 100
        Me.dgvProveedor.VirtualMode = True
        '
        'btnModificar
        '
        Me.btnModificar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.ModifIn
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnModificar.Location = New System.Drawing.Point(935, 410)
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
        Me.lblMsg.Location = New System.Drawing.Point(935, 472)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(128, 68)
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
        Me.btnCancelar.Location = New System.Drawing.Point(1002, 410)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(61, 60)
        Me.btnCancelar.TabIndex = 33
        Me.btnCancelar.Tag = ""
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'gbxDetalle
        '
        Me.gbxDetalle.BackColor = System.Drawing.Color.Transparent
        Me.gbxDetalle.Controls.Add(Me.btnValEnCartera)
        Me.gbxDetalle.Controls.Add(Me.lblFunValor)
        Me.gbxDetalle.Controls.Add(Me.lblidDetCaja)
        Me.gbxDetalle.Controls.Add(Me.Label3)
        Me.gbxDetalle.Controls.Add(Me.txtLibrador)
        Me.gbxDetalle.Controls.Add(Me.btnCancelarValor)
        Me.gbxDetalle.Controls.Add(Me.Label1)
        Me.gbxDetalle.Controls.Add(Me.btnEliminarValor)
        Me.gbxDetalle.Controls.Add(Me.btnModValor)
        Me.gbxDetalle.Controls.Add(Me.cbxTipoValor)
        Me.gbxDetalle.Controls.Add(Me.Label10)
        Me.gbxDetalle.Controls.Add(Me.btnCargarValor)
        Me.gbxDetalle.Controls.Add(Me.Label12)
        Me.gbxDetalle.Controls.Add(Me.txtObsValor)
        Me.gbxDetalle.Controls.Add(Me.Label13)
        Me.gbxDetalle.Controls.Add(Me.txtImpValor)
        Me.gbxDetalle.Controls.Add(Me.Label14)
        Me.gbxDetalle.Controls.Add(Me.txtFecCobro)
        Me.gbxDetalle.Controls.Add(Me.Label18)
        Me.gbxDetalle.Controls.Add(Me.txtSucursal)
        Me.gbxDetalle.Controls.Add(Me.Label20)
        Me.gbxDetalle.Controls.Add(Me.txtValNum)
        Me.gbxDetalle.Controls.Add(Me.Label21)
        Me.gbxDetalle.Controls.Add(Me.cbxBanco)
        Me.gbxDetalle.Enabled = False
        Me.gbxDetalle.Location = New System.Drawing.Point(9, 155)
        Me.gbxDetalle.Name = "gbxDetalle"
        Me.gbxDetalle.Size = New System.Drawing.Size(505, 178)
        Me.gbxDetalle.TabIndex = 39
        Me.gbxDetalle.TabStop = False
        '
        'btnValEnCartera
        '
        Me.btnValEnCartera.BackgroundImage = Global.ByB_SI.My.Resources.Resources.ChequesIn
        Me.btnValEnCartera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnValEnCartera.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnValEnCartera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValEnCartera.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnValEnCartera.Location = New System.Drawing.Point(6, 134)
        Me.btnValEnCartera.Name = "btnValEnCartera"
        Me.btnValEnCartera.Size = New System.Drawing.Size(37, 38)
        Me.btnValEnCartera.TabIndex = 105
        Me.btnValEnCartera.Tag = ""
        Me.btnValEnCartera.UseVisualStyleBackColor = True
        '
        'lblFunValor
        '
        Me.lblFunValor.BackColor = System.Drawing.Color.White
        Me.lblFunValor.Location = New System.Drawing.Point(6, 3)
        Me.lblFunValor.Name = "lblFunValor"
        Me.lblFunValor.Size = New System.Drawing.Size(74, 20)
        Me.lblFunValor.TabIndex = 104
        Me.lblFunValor.Visible = False
        '
        'lblidDetCaja
        '
        Me.lblidDetCaja.BackColor = System.Drawing.Color.White
        Me.lblidDetCaja.Location = New System.Drawing.Point(86, 3)
        Me.lblidDetCaja.Name = "lblidDetCaja"
        Me.lblidDetCaja.Size = New System.Drawing.Size(74, 20)
        Me.lblidDetCaja.TabIndex = 103
        Me.lblidDetCaja.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label3.Location = New System.Drawing.Point(263, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Librador"
        '
        'txtLibrador
        '
        Me.txtLibrador.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtLibrador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLibrador.ForeColor = System.Drawing.Color.Teal
        Me.txtLibrador.Location = New System.Drawing.Point(266, 65)
        Me.txtLibrador.Name = "txtLibrador"
        Me.txtLibrador.Size = New System.Drawing.Size(230, 22)
        Me.txtLibrador.TabIndex = 77
        '
        'btnCancelarValor
        '
        Me.btnCancelarValor.BackgroundImage = Global.ByB_SI.My.Resources.Resources.CancelarIn
        Me.btnCancelarValor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancelarValor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelarValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarValor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCancelarValor.Location = New System.Drawing.Point(417, 134)
        Me.btnCancelarValor.Name = "btnCancelarValor"
        Me.btnCancelarValor.Size = New System.Drawing.Size(37, 38)
        Me.btnCancelarValor.TabIndex = 76
        Me.btnCancelarValor.Tag = ""
        Me.btnCancelarValor.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label1.Location = New System.Drawing.Point(112, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Valor Tipo"
        '
        'btnModValor
        '
        Me.btnModValor.BackgroundImage = Global.ByB_SI.My.Resources.Resources.ModifIn
        Me.btnModValor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnModValor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModValor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnModValor.Location = New System.Drawing.Point(374, 134)
        Me.btnModValor.Name = "btnModValor"
        Me.btnModValor.Size = New System.Drawing.Size(37, 38)
        Me.btnModValor.TabIndex = 75
        Me.btnModValor.Tag = ""
        Me.btnModValor.UseVisualStyleBackColor = True
        '
        'cbxTipoValor
        '
        Me.cbxTipoValor.BackColor = System.Drawing.Color.MediumTurquoise
        Me.cbxTipoValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipoValor.ForeColor = System.Drawing.Color.Teal
        Me.cbxTipoValor.FormattingEnabled = True
        Me.cbxTipoValor.Items.AddRange(New Object() {"Efectivo", "Cheque", "Tarjeta Crédito", "Tarjeta Débito", "Otros"})
        Me.cbxTipoValor.Location = New System.Drawing.Point(115, 23)
        Me.cbxTipoValor.Name = "cbxTipoValor"
        Me.cbxTipoValor.Size = New System.Drawing.Size(145, 24)
        Me.cbxTipoValor.TabIndex = 71
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label10.Location = New System.Drawing.Point(3, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Fecha Cobro"
        '
        'btnCargarValor
        '
        Me.btnCargarValor.BackgroundImage = Global.ByB_SI.My.Resources.Resources.IngresoIn
        Me.btnCargarValor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCargarValor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCargarValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarValor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCargarValor.Location = New System.Drawing.Point(332, 134)
        Me.btnCargarValor.Name = "btnCargarValor"
        Me.btnCargarValor.Size = New System.Drawing.Size(37, 38)
        Me.btnCargarValor.TabIndex = 74
        Me.btnCargarValor.Tag = ""
        Me.btnCargarValor.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label12.Location = New System.Drawing.Point(167, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 13)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "$"
        '
        'txtObsValor
        '
        Me.txtObsValor.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtObsValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObsValor.ForeColor = System.Drawing.Color.Teal
        Me.txtObsValor.Location = New System.Drawing.Point(222, 104)
        Me.txtObsValor.Name = "txtObsValor"
        Me.txtObsValor.Size = New System.Drawing.Size(274, 22)
        Me.txtObsValor.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label13.Location = New System.Drawing.Point(219, 90)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 13)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Observaciones"
        '
        'txtImpValor
        '
        Me.txtImpValor.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtImpValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpValor.ForeColor = System.Drawing.Color.Teal
        Me.txtImpValor.Location = New System.Drawing.Point(115, 104)
        Me.txtImpValor.Name = "txtImpValor"
        Me.txtImpValor.Size = New System.Drawing.Size(103, 22)
        Me.txtImpValor.TabIndex = 6
        Me.txtImpValor.Text = "$ 0.00"
        Me.txtImpValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label14.Location = New System.Drawing.Point(112, 90)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Importe"
        '
        'txtFecCobro
        '
        Me.txtFecCobro.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtFecCobro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecCobro.ForeColor = System.Drawing.Color.Teal
        Me.txtFecCobro.Location = New System.Drawing.Point(6, 104)
        Me.txtFecCobro.Name = "txtFecCobro"
        Me.txtFecCobro.Size = New System.Drawing.Size(103, 22)
        Me.txtFecCobro.TabIndex = 4
        Me.txtFecCobro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label18.Location = New System.Drawing.Point(3, 49)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 13)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "Sucursal"
        '
        'txtSucursal
        '
        Me.txtSucursal.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSucursal.ForeColor = System.Drawing.Color.Teal
        Me.txtSucursal.Location = New System.Drawing.Point(6, 65)
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Size = New System.Drawing.Size(254, 22)
        Me.txtSucursal.TabIndex = 2
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label20.Location = New System.Drawing.Point(6, 9)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(83, 13)
        Me.Label20.TabIndex = 35
        Me.Label20.Text = "Valor Número"
        '
        'txtValNum
        '
        Me.txtValNum.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtValNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValNum.ForeColor = System.Drawing.Color.Teal
        Me.txtValNum.Location = New System.Drawing.Point(6, 25)
        Me.txtValNum.Name = "txtValNum"
        Me.txtValNum.Size = New System.Drawing.Size(103, 22)
        Me.txtValNum.TabIndex = 0
        Me.txtValNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label21.Location = New System.Drawing.Point(263, 9)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 13)
        Me.Label21.TabIndex = 33
        Me.Label21.Text = "Banco"
        '
        'cbxBanco
        '
        Me.cbxBanco.BackColor = System.Drawing.Color.MediumTurquoise
        Me.cbxBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxBanco.ForeColor = System.Drawing.Color.Teal
        Me.cbxBanco.FormattingEnabled = True
        Me.cbxBanco.Items.AddRange(New Object() {"Banex", "Bank Boston", "Bisel", "BNL", "City Bank", "Comafi", "Credocoop", "Entre Río", "Formosa", "Francés", "Galicia", "Hipotecario", "HSBC", "Industrial", "Itaú", "La Pampa", "La Rioja", "Macro Bansud", "Nación Argentina", "Patagonia", "Provincia De Buenos Aires", "Provincia De Córdoba", "Provincia De Neuquén", "Regional De Cuyo", "Roela", "Santa Cruz", "Santa Fe", "Santander Río", "Standard Bank", "Superville", "Suquía"})
        Me.cbxBanco.Location = New System.Drawing.Point(266, 23)
        Me.cbxBanco.Name = "cbxBanco"
        Me.cbxBanco.Size = New System.Drawing.Size(230, 24)
        Me.cbxBanco.Sorted = True
        Me.cbxBanco.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label11.Location = New System.Drawing.Point(319, 155)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 13)
        Me.Label11.TabIndex = 105
        Me.Label11.Text = "Total Valores ="
        '
        'dgvBufDetalle
        '
        Me.dgvBufDetalle.AllowUserToAddRows = False
        Me.dgvBufDetalle.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgvBufDetalle.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvBufDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvBufDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvBufDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBufDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ElimBuff})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBufDetalle.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvBufDetalle.Location = New System.Drawing.Point(6, 13)
        Me.dgvBufDetalle.Name = "dgvBufDetalle"
        Me.dgvBufDetalle.ReadOnly = True
        Me.dgvBufDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBufDetalle.Size = New System.Drawing.Size(531, 131)
        Me.dgvBufDetalle.TabIndex = 73
        '
        'ElimBuff
        '
        Me.ElimBuff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ElimBuff.HeaderText = "ELIM"
        Me.ElimBuff.Name = "ElimBuff"
        Me.ElimBuff.ReadOnly = True
        Me.ElimBuff.Width = 38
        '
        'tmrHora
        '
        Me.tmrHora.Enabled = True
        Me.tmrHora.Interval = 1000
        '
        'txtTotVal
        '
        Me.txtTotVal.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtTotVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotVal.ForeColor = System.Drawing.Color.Teal
        Me.txtTotVal.Location = New System.Drawing.Point(418, 150)
        Me.txtTotVal.Name = "txtTotVal"
        Me.txtTotVal.Size = New System.Drawing.Size(119, 22)
        Me.txtTotVal.TabIndex = 105
        Me.txtTotVal.Text = "$ 0.00"
        Me.txtTotVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gbxValores
        '
        Me.gbxValores.BackColor = System.Drawing.Color.Transparent
        Me.gbxValores.Controls.Add(Me.Label11)
        Me.gbxValores.Controls.Add(Me.dgvBufDetalle)
        Me.gbxValores.Controls.Add(Me.txtTotVal)
        Me.gbxValores.Location = New System.Drawing.Point(520, 155)
        Me.gbxValores.Name = "gbxValores"
        Me.gbxValores.Size = New System.Drawing.Size(543, 178)
        Me.gbxValores.TabIndex = 106
        Me.gbxValores.TabStop = False
        '
        'tmrSaldos
        '
        Me.tmrSaldos.Enabled = True
        '
        'frmCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ByB_SI.My.Resources.Resources.Fondo_23___Reducido
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1072, 579)
        Me.Controls.Add(Me.gbxValores)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gbxDetalle)
        Me.Controls.Add(Me.gbxDatagrid)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.gbxDatos)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.dgvCliente)
        Me.Controls.Add(Me.dgvProveedor)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCaja"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvValEnCartera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatagrid.ResumeLayout(False)
        Me.gbxDatagrid.PerformLayout()
        CType(Me.dgvCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatos.ResumeLayout(False)
        Me.gbxDatos.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDetalle.ResumeLayout(False)
        Me.gbxDetalle.PerformLayout()
        CType(Me.dgvBufDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxValores.ResumeLayout(False)
        Me.gbxValores.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblOrigen As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCdEmp As System.Windows.Forms.TextBox
    Friend WithEvents gbxDatagrid As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCaja As System.Windows.Forms.DataGridView
    Friend WithEvents txtObserv As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminarValor As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents tmrMensaje As System.Windows.Forms.Timer
    Friend WithEvents txtIdCli As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents gbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDetalle As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtHora As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFecAlta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblIdUs As System.Windows.Forms.Label
    Friend WithEvents cbxTipoMov As System.Windows.Forms.ComboBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtIdProv As System.Windows.Forms.TextBox
    Friend WithEvents gbxDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxTipoValor As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtObsValor As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtImpValor As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtFecCobro As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtSucursal As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtValNum As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cbxBanco As System.Windows.Forms.ComboBox
    Friend WithEvents dgvBufDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancelarValor As System.Windows.Forms.Button
    Friend WithEvents btnModValor As System.Windows.Forms.Button
    Friend WithEvents btnCargarValor As System.Windows.Forms.Button
    Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
    Friend WithEvents dgvProveedor As System.Windows.Forms.DataGridView
    Friend WithEvents lblFuncion As System.Windows.Forms.Label
    Friend WithEvents tmrHora As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLibrador As System.Windows.Forms.TextBox
    Friend WithEvents lblidDetCaja As System.Windows.Forms.Label
    Friend WithEvents lblFunValor As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTotVal As System.Windows.Forms.TextBox
    Friend WithEvents ElimBuff As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents gbxValores As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoCaja As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoAnt As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents SaldoDia As System.Windows.Forms.TextBox
    Friend WithEvents btnValEnCartera As System.Windows.Forms.Button
    Friend WithEvents dgvValEnCartera As System.Windows.Forms.DataGridView
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtCantChqCartera As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtImpChqCartera As System.Windows.Forms.TextBox
    Friend WithEvents tmrSaldos As System.Windows.Forms.Timer
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtEfectivo As System.Windows.Forms.TextBox
End Class
