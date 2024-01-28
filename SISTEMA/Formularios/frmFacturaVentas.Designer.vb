<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturaVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturaVentas))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbxCarga = New System.Windows.Forms.GroupBox()
        Me.txtImpFinal = New System.Windows.Forms.TextBox()
        Me.txtArticulo = New System.Windows.Forms.TextBox()
        Me.txtAlIvaReal = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtIdArt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAlicIva = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCdBarra = New System.Windows.Forms.TextBox()
        Me.lblFuncion = New System.Windows.Forms.Label()
        Me.lblIdDet = New System.Windows.Forms.Label()
        Me.txtIdStock = New System.Windows.Forms.TextBox()
        Me.txtPrecioFin = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCdEmp = New System.Windows.Forms.TextBox()
        Me.gbxResumen = New System.Windows.Forms.GroupBox()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtIva21 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtIva105 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.dgvCliente = New System.Windows.Forms.DataGridView()
        Me.gbxControles = New System.Windows.Forms.GroupBox()
        Me.lblManual = New System.Windows.Forms.Label()
        Me.btnManual = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.gbxObserv = New System.Windows.Forms.GroupBox()
        Me.txtObserv = New System.Windows.Forms.TextBox()
        Me.btnEmitirFactura = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.dgvStock = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtSubTotalIva1050 = New System.Windows.Forms.TextBox()
        Me.txtSubTotalIva2100 = New System.Windows.Forms.TextBox()
        Me.lblst = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.gbxDetalle = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtIva105Contable = New System.Windows.Forms.TextBox()
        Me.txtIva21Contable = New System.Windows.Forms.TextBox()
        Me.gbxCliente = New System.Windows.Forms.GroupBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtEst = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtCred = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtProv = New System.Windows.Forms.TextBox()
        Me.txtCatIva = New System.Windows.Forms.TextBox()
        Me.txtIIBB = New System.Windows.Forms.TextBox()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.txtCuit = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbxCondPago = New System.Windows.Forms.GroupBox()
        Me.dgvPago = New System.Windows.Forms.DataGridView()
        Me.btnCargaCuota = New System.Windows.Forms.Button()
        Me.txtImpCta = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtVto = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtCuotas = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.rbtFactura = New System.Windows.Forms.RadioButton()
        Me.rbnND = New System.Windows.Forms.RadioButton()
        Me.rbtnNC = New System.Windows.Forms.RadioButton()
        Me.rbtnOtras = New System.Windows.Forms.RadioButton()
        Me.rbtCtaCte = New System.Windows.Forms.RadioButton()
        Me.rbtCdo = New System.Windows.Forms.RadioButton()
        Me.gbxFactura = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblPtoVta = New System.Windows.Forms.Label()
        Me.lblComprobante = New System.Windows.Forms.Label()
        Me.gbxLetra = New System.Windows.Forms.GroupBox()
        Me.lblCodComprobante = New System.Windows.Forms.Label()
        Me.lblLetra = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.gbxTipoC = New System.Windows.Forms.GroupBox()
        Me.gbxTipoVta = New System.Windows.Forms.GroupBox()
        Me.tmrActNroComp = New System.Windows.Forms.Timer(Me.components)
        Me.gbxConceptos = New System.Windows.Forms.GroupBox()
        Me.cbxConceptos = New System.Windows.Forms.ComboBox()
        Me.lblTiket = New System.Windows.Forms.Label()
        Me.lblIdFactura = New System.Windows.Forms.Label()
        Me.lblEnter = New System.Windows.Forms.Label()
        Me.dgvCtaCte = New System.Windows.Forms.DataGridView()
        Me.dgvCaja = New System.Windows.Forms.DataGridView()
        Me.gbxCarga.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbxResumen.SuspendLayout()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxControles.SuspendLayout()
        Me.gbxObserv.SuspendLayout()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDetalle.SuspendLayout()
        Me.gbxCliente.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxCondPago.SuspendLayout()
        CType(Me.dgvPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxFactura.SuspendLayout()
        Me.gbxLetra.SuspendLayout()
        Me.gbxTipoC.SuspendLayout()
        Me.gbxTipoVta.SuspendLayout()
        Me.gbxConceptos.SuspendLayout()
        CType(Me.dgvCtaCte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label4.Location = New System.Drawing.Point(61, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Número"
        '
        'gbxCarga
        '
        Me.gbxCarga.BackColor = System.Drawing.Color.Transparent
        Me.gbxCarga.Controls.Add(Me.txtImpFinal)
        Me.gbxCarga.Controls.Add(Me.txtArticulo)
        Me.gbxCarga.Controls.Add(Me.txtAlIvaReal)
        Me.gbxCarga.Controls.Add(Me.Label18)
        Me.gbxCarga.Controls.Add(Me.txtUnidad)
        Me.gbxCarga.Controls.Add(Me.Label17)
        Me.gbxCarga.Controls.Add(Me.txtIdArt)
        Me.gbxCarga.Controls.Add(Me.Label10)
        Me.gbxCarga.Controls.Add(Me.txtImporte)
        Me.gbxCarga.Controls.Add(Me.Label9)
        Me.gbxCarga.Controls.Add(Me.txtAlicIva)
        Me.gbxCarga.Controls.Add(Me.Label7)
        Me.gbxCarga.Controls.Add(Me.txtPrecio)
        Me.gbxCarga.Controls.Add(Me.Label8)
        Me.gbxCarga.Controls.Add(Me.txtCantidad)
        Me.gbxCarga.Controls.Add(Me.Label5)
        Me.gbxCarga.Controls.Add(Me.Label3)
        Me.gbxCarga.Controls.Add(Me.txtCdBarra)
        Me.gbxCarga.Controls.Add(Me.lblFuncion)
        Me.gbxCarga.Controls.Add(Me.lblIdDet)
        Me.gbxCarga.Controls.Add(Me.txtIdStock)
        Me.gbxCarga.Controls.Add(Me.txtPrecioFin)
        Me.gbxCarga.Enabled = False
        Me.gbxCarga.Location = New System.Drawing.Point(10, 200)
        Me.gbxCarga.Name = "gbxCarga"
        Me.gbxCarga.Size = New System.Drawing.Size(875, 110)
        Me.gbxCarga.TabIndex = 85
        Me.gbxCarga.TabStop = False
        '
        'txtImpFinal
        '
        Me.txtImpFinal.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtImpFinal.Enabled = False
        Me.txtImpFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpFinal.ForeColor = System.Drawing.Color.Teal
        Me.txtImpFinal.Location = New System.Drawing.Point(727, 76)
        Me.txtImpFinal.Name = "txtImpFinal"
        Me.txtImpFinal.Size = New System.Drawing.Size(139, 26)
        Me.txtImpFinal.TabIndex = 88
        Me.txtImpFinal.Text = "$ 0.00"
        Me.txtImpFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtImpFinal.Visible = False
        '
        'txtArticulo
        '
        Me.txtArticulo.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtArticulo.Enabled = False
        Me.txtArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArticulo.ForeColor = System.Drawing.Color.Teal
        Me.txtArticulo.Location = New System.Drawing.Point(96, 29)
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.Size = New System.Drawing.Size(624, 26)
        Me.txtArticulo.TabIndex = 8
        '
        'txtAlIvaReal
        '
        Me.txtAlIvaReal.BackColor = System.Drawing.Color.DimGray
        Me.txtAlIvaReal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlIvaReal.ForeColor = System.Drawing.Color.White
        Me.txtAlIvaReal.Location = New System.Drawing.Point(214, 11)
        Me.txtAlIvaReal.Name = "txtAlIvaReal"
        Me.txtAlIvaReal.Size = New System.Drawing.Size(100, 26)
        Me.txtAlIvaReal.TabIndex = 85
        Me.txtAlIvaReal.Text = "0"
        Me.txtAlIvaReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAlIvaReal.Visible = False
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label18.Location = New System.Drawing.Point(724, 11)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 18)
        Me.Label18.TabIndex = 82
        Me.Label18.Tag = ""
        Me.Label18.Text = "Unidad"
        '
        'txtUnidad
        '
        Me.txtUnidad.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtUnidad.Enabled = False
        Me.txtUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnidad.ForeColor = System.Drawing.Color.Teal
        Me.txtUnidad.Location = New System.Drawing.Point(727, 29)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(139, 26)
        Me.txtUnidad.TabIndex = 81
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label17.Location = New System.Drawing.Point(7, 11)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 18)
        Me.Label17.TabIndex = 80
        Me.Label17.Tag = ""
        Me.Label17.Text = "Cd. Art."
        '
        'txtIdArt
        '
        Me.txtIdArt.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtIdArt.Enabled = False
        Me.txtIdArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdArt.ForeColor = System.Drawing.Color.Teal
        Me.txtIdArt.Location = New System.Drawing.Point(10, 29)
        Me.txtIdArt.Name = "txtIdArt"
        Me.txtIdArt.Size = New System.Drawing.Size(80, 26)
        Me.txtIdArt.TabIndex = 79
        Me.txtIdArt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label10.Location = New System.Drawing.Point(724, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(142, 18)
        Me.Label10.TabIndex = 78
        Me.Label10.Tag = ""
        Me.Label10.Text = "Importe"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtImporte
        '
        Me.txtImporte.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtImporte.Enabled = False
        Me.txtImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.ForeColor = System.Drawing.Color.Teal
        Me.txtImporte.Location = New System.Drawing.Point(727, 76)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(139, 26)
        Me.txtImporte.TabIndex = 12
        Me.txtImporte.Text = "$ 0.00"
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label9.Location = New System.Drawing.Point(602, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 18)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "Alicuota IVA"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAlicIva
        '
        Me.txtAlicIva.BackColor = System.Drawing.Color.DimGray
        Me.txtAlicIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlicIva.ForeColor = System.Drawing.Color.White
        Me.txtAlicIva.Location = New System.Drawing.Point(599, 76)
        Me.txtAlicIva.Name = "txtAlicIva"
        Me.txtAlicIva.Size = New System.Drawing.Size(119, 26)
        Me.txtAlicIva.TabIndex = 11
        Me.txtAlicIva.Text = "0.00 %"
        Me.txtAlicIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label7.Location = New System.Drawing.Point(475, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 18)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Precio"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPrecio
        '
        Me.txtPrecio.BackColor = System.Drawing.Color.DimGray
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.ForeColor = System.Drawing.Color.White
        Me.txtPrecio.Location = New System.Drawing.Point(472, 76)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(121, 26)
        Me.txtPrecio.TabIndex = 10
        Me.txtPrecio.Text = "$ 0.00"
        Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label8.Location = New System.Drawing.Point(343, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 18)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "Cantidad"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.DimGray
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.ForeColor = System.Drawing.Color.White
        Me.txtCantidad.Location = New System.Drawing.Point(346, 77)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(120, 26)
        Me.txtCantidad.TabIndex = 9
        Me.txtCantidad.Text = "0.00"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label5.Location = New System.Drawing.Point(94, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 18)
        Me.Label5.TabIndex = 69
        Me.Label5.Tag = ""
        Me.Label5.Text = "Descripción"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label3.Location = New System.Drawing.Point(8, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(332, 18)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Código Barra"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCdBarra
        '
        Me.txtCdBarra.BackColor = System.Drawing.Color.DimGray
        Me.txtCdBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCdBarra.ForeColor = System.Drawing.Color.White
        Me.txtCdBarra.Location = New System.Drawing.Point(10, 77)
        Me.txtCdBarra.Name = "txtCdBarra"
        Me.txtCdBarra.Size = New System.Drawing.Size(330, 26)
        Me.txtCdBarra.TabIndex = 7
        Me.txtCdBarra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblFuncion
        '
        Me.lblFuncion.BackColor = System.Drawing.SystemColors.Window
        Me.lblFuncion.Location = New System.Drawing.Point(516, 13)
        Me.lblFuncion.Name = "lblFuncion"
        Me.lblFuncion.Size = New System.Drawing.Size(60, 20)
        Me.lblFuncion.TabIndex = 84
        Me.lblFuncion.Text = "Nuevo"
        Me.lblFuncion.Visible = False
        '
        'lblIdDet
        '
        Me.lblIdDet.BackColor = System.Drawing.SystemColors.Window
        Me.lblIdDet.Location = New System.Drawing.Point(450, 13)
        Me.lblIdDet.Name = "lblIdDet"
        Me.lblIdDet.Size = New System.Drawing.Size(60, 20)
        Me.lblIdDet.TabIndex = 83
        Me.lblIdDet.Visible = False
        '
        'txtIdStock
        '
        Me.txtIdStock.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtIdStock.Enabled = False
        Me.txtIdStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdStock.ForeColor = System.Drawing.Color.Teal
        Me.txtIdStock.Location = New System.Drawing.Point(320, 11)
        Me.txtIdStock.Name = "txtIdStock"
        Me.txtIdStock.Size = New System.Drawing.Size(59, 26)
        Me.txtIdStock.TabIndex = 86
        Me.txtIdStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIdStock.Visible = False
        '
        'txtPrecioFin
        '
        Me.txtPrecioFin.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtPrecioFin.Enabled = False
        Me.txtPrecioFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioFin.ForeColor = System.Drawing.Color.Teal
        Me.txtPrecioFin.Location = New System.Drawing.Point(385, 11)
        Me.txtPrecioFin.Name = "txtPrecioFin"
        Me.txtPrecioFin.Size = New System.Drawing.Size(59, 26)
        Me.txtPrecioFin.TabIndex = 87
        Me.txtPrecioFin.Text = "0"
        Me.txtPrecioFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPrecioFin.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCdEmp)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.LawnGreen
        Me.GroupBox2.Location = New System.Drawing.Point(10, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(134, 54)
        Me.GroupBox2.TabIndex = 91
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Codigo Empresa"
        Me.GroupBox2.UseWaitCursor = True
        Me.GroupBox2.Visible = False
        '
        'txtCdEmp
        '
        Me.txtCdEmp.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCdEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCdEmp.ForeColor = System.Drawing.Color.Teal
        Me.txtCdEmp.Location = New System.Drawing.Point(6, 18)
        Me.txtCdEmp.Name = "txtCdEmp"
        Me.txtCdEmp.Size = New System.Drawing.Size(125, 26)
        Me.txtCdEmp.TabIndex = 60
        Me.txtCdEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCdEmp.UseWaitCursor = True
        Me.txtCdEmp.Visible = False
        '
        'gbxResumen
        '
        Me.gbxResumen.BackColor = System.Drawing.Color.Transparent
        Me.gbxResumen.Controls.Add(Me.txtDescuento)
        Me.gbxResumen.Controls.Add(Me.Label15)
        Me.gbxResumen.Controls.Add(Me.txtTotal)
        Me.gbxResumen.Controls.Add(Me.Label14)
        Me.gbxResumen.Controls.Add(Me.txtIva21)
        Me.gbxResumen.Controls.Add(Me.Label13)
        Me.gbxResumen.Controls.Add(Me.txtIva105)
        Me.gbxResumen.Controls.Add(Me.Label12)
        Me.gbxResumen.Controls.Add(Me.Label11)
        Me.gbxResumen.Controls.Add(Me.txtSubTotal)
        Me.gbxResumen.Enabled = False
        Me.gbxResumen.Location = New System.Drawing.Point(10, 523)
        Me.gbxResumen.Name = "gbxResumen"
        Me.gbxResumen.Size = New System.Drawing.Size(875, 66)
        Me.gbxResumen.TabIndex = 86
        Me.gbxResumen.TabStop = False
        '
        'txtDescuento
        '
        Me.txtDescuento.BackColor = System.Drawing.Color.DimGray
        Me.txtDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuento.ForeColor = System.Drawing.Color.White
        Me.txtDescuento.Location = New System.Drawing.Point(171, 34)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(152, 26)
        Me.txtDescuento.TabIndex = 89
        Me.txtDescuento.Text = "$ 0.00"
        Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label15.Location = New System.Drawing.Point(645, 13)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(221, 18)
        Me.Label15.TabIndex = 88
        Me.Label15.Tag = ""
        Me.Label15.Text = "Total"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.Black
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Red
        Me.txtTotal.Location = New System.Drawing.Point(645, 34)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(221, 26)
        Me.txtTotal.TabIndex = 87
        Me.txtTotal.Text = "$ 0.00"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label14.Location = New System.Drawing.Point(488, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(152, 18)
        Me.Label14.TabIndex = 86
        Me.Label14.Tag = ""
        Me.Label14.Text = "Iva 21.00 %"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtIva21
        '
        Me.txtIva21.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtIva21.Enabled = False
        Me.txtIva21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIva21.ForeColor = System.Drawing.Color.Teal
        Me.txtIva21.Location = New System.Drawing.Point(487, 34)
        Me.txtIva21.Name = "txtIva21"
        Me.txtIva21.Size = New System.Drawing.Size(152, 26)
        Me.txtIva21.TabIndex = 85
        Me.txtIva21.Text = "$ 0.00"
        Me.txtIva21.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label13.Location = New System.Drawing.Point(327, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(155, 18)
        Me.Label13.TabIndex = 84
        Me.Label13.Tag = ""
        Me.Label13.Text = "Iva 10.50 %"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtIva105
        '
        Me.txtIva105.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtIva105.Enabled = False
        Me.txtIva105.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIva105.ForeColor = System.Drawing.Color.Teal
        Me.txtIva105.Location = New System.Drawing.Point(330, 34)
        Me.txtIva105.Name = "txtIva105"
        Me.txtIva105.Size = New System.Drawing.Size(152, 26)
        Me.txtIva105.TabIndex = 83
        Me.txtIva105.Text = "$ 0.00"
        Me.txtIva105.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label12.Location = New System.Drawing.Point(168, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(152, 18)
        Me.Label12.TabIndex = 82
        Me.Label12.Tag = ""
        Me.Label12.Text = "Descuento"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label11.Location = New System.Drawing.Point(10, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(155, 18)
        Me.Label11.TabIndex = 80
        Me.Label11.Tag = ""
        Me.Label11.Text = "Sub Total"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtSubTotal.Enabled = False
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.ForeColor = System.Drawing.Color.Teal
        Me.txtSubTotal.Location = New System.Drawing.Point(13, 34)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(152, 26)
        Me.txtSubTotal.TabIndex = 79
        Me.txtSubTotal.Text = "$ 0.00"
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvCliente
        '
        Me.dgvCliente.AllowUserToAddRows = False
        Me.dgvCliente.AllowUserToDeleteRows = False
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCliente.Location = New System.Drawing.Point(10, 12)
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.ReadOnly = True
        Me.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCliente.Size = New System.Drawing.Size(51, 27)
        Me.dgvCliente.TabIndex = 89
        Me.dgvCliente.VirtualMode = True
        '
        'gbxControles
        '
        Me.gbxControles.BackColor = System.Drawing.Color.Transparent
        Me.gbxControles.Controls.Add(Me.lblManual)
        Me.gbxControles.Controls.Add(Me.btnManual)
        Me.gbxControles.Controls.Add(Me.btnModificar)
        Me.gbxControles.Controls.Add(Me.btnCancelar)
        Me.gbxControles.Controls.Add(Me.btnGuardar)
        Me.gbxControles.Controls.Add(Me.btnEliminar)
        Me.gbxControles.Enabled = False
        Me.gbxControles.Location = New System.Drawing.Point(891, 200)
        Me.gbxControles.Name = "gbxControles"
        Me.gbxControles.Size = New System.Drawing.Size(169, 110)
        Me.gbxControles.TabIndex = 87
        Me.gbxControles.TabStop = False
        '
        'lblManual
        '
        Me.lblManual.AutoSize = True
        Me.lblManual.BackColor = System.Drawing.Color.Transparent
        Me.lblManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManual.ForeColor = System.Drawing.Color.Gold
        Me.lblManual.Location = New System.Drawing.Point(58, 86)
        Me.lblManual.Name = "lblManual"
        Me.lblManual.Size = New System.Drawing.Size(47, 16)
        Me.lblManual.TabIndex = 70
        Me.lblManual.Tag = ""
        Me.lblManual.Text = "Stock"
        '
        'btnManual
        '
        Me.btnManual.BackgroundImage = Global.ByB_SI.My.Resources.Resources.CargaManualIn
        Me.btnManual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnManual.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnManual.Location = New System.Drawing.Point(4, 57)
        Me.btnManual.Name = "btnManual"
        Me.btnManual.Size = New System.Drawing.Size(51, 50)
        Me.btnManual.TabIndex = 43
        Me.btnManual.Tag = ""
        Me.btnManual.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.ModifIn
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Enabled = False
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnModificar.Location = New System.Drawing.Point(61, 8)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(48, 50)
        Me.btnModificar.TabIndex = 39
        Me.btnModificar.Tag = ""
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.CancelarIn
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCancelar.Location = New System.Drawing.Point(115, 8)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(51, 50)
        Me.btnCancelar.TabIndex = 41
        Me.btnCancelar.Tag = ""
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.GuardarIn
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnGuardar.Location = New System.Drawing.Point(4, 8)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(51, 50)
        Me.btnGuardar.TabIndex = 40
        Me.btnGuardar.Tag = ""
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.EliminarIn
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(115, 57)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(51, 50)
        Me.btnEliminar.TabIndex = 42
        Me.btnEliminar.Tag = ""
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'gbxObserv
        '
        Me.gbxObserv.BackColor = System.Drawing.Color.Transparent
        Me.gbxObserv.Controls.Add(Me.txtObserv)
        Me.gbxObserv.Enabled = False
        Me.gbxObserv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxObserv.ForeColor = System.Drawing.Color.LawnGreen
        Me.gbxObserv.Location = New System.Drawing.Point(891, 311)
        Me.gbxObserv.Name = "gbxObserv"
        Me.gbxObserv.Size = New System.Drawing.Size(169, 60)
        Me.gbxObserv.TabIndex = 88
        Me.gbxObserv.TabStop = False
        Me.gbxObserv.Text = " Observaciones "
        '
        'txtObserv
        '
        Me.txtObserv.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtObserv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObserv.ForeColor = System.Drawing.Color.Teal
        Me.txtObserv.Location = New System.Drawing.Point(6, 19)
        Me.txtObserv.Multiline = True
        Me.txtObserv.Name = "txtObserv"
        Me.txtObserv.Size = New System.Drawing.Size(156, 35)
        Me.txtObserv.TabIndex = 87
        '
        'btnEmitirFactura
        '
        Me.btnEmitirFactura.BackgroundImage = Global.ByB_SI.My.Resources.Resources.Emitir1In
        Me.btnEmitirFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEmitirFactura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmitirFactura.Location = New System.Drawing.Point(901, 529)
        Me.btnEmitirFactura.Name = "btnEmitirFactura"
        Me.btnEmitirFactura.Size = New System.Drawing.Size(61, 61)
        Me.btnEmitirFactura.TabIndex = 45
        Me.btnEmitirFactura.Tag = ""
        Me.btnEmitirFactura.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = Global.ByB_SI.My.Resources.Resources.SalirIn
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Location = New System.Drawing.Point(992, 529)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(61, 61)
        Me.btnSalir.TabIndex = 44
        Me.btnSalir.Tag = ""
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'dgvStock
        '
        Me.dgvStock.AllowUserToAddRows = False
        Me.dgvStock.AllowUserToDeleteRows = False
        Me.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStock.Location = New System.Drawing.Point(10, 45)
        Me.dgvStock.Name = "dgvStock"
        Me.dgvStock.ReadOnly = True
        Me.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStock.Size = New System.Drawing.Size(51, 27)
        Me.dgvStock.TabIndex = 90
        Me.dgvStock.VirtualMode = True
        '
        'Eliminar
        '
        Me.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Eliminar.HeaderText = "ELIM"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Width = 60
        '
        'txtSubTotalIva1050
        '
        Me.txtSubTotalIva1050.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtSubTotalIva1050.Enabled = False
        Me.txtSubTotalIva1050.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotalIva1050.ForeColor = System.Drawing.Color.Teal
        Me.txtSubTotalIva1050.Location = New System.Drawing.Point(569, 183)
        Me.txtSubTotalIva1050.Name = "txtSubTotalIva1050"
        Me.txtSubTotalIva1050.Size = New System.Drawing.Size(142, 22)
        Me.txtSubTotalIva1050.TabIndex = 83
        Me.txtSubTotalIva1050.Text = "$ 0.00"
        Me.txtSubTotalIva1050.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSubTotalIva1050.Visible = False
        '
        'txtSubTotalIva2100
        '
        Me.txtSubTotalIva2100.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtSubTotalIva2100.Enabled = False
        Me.txtSubTotalIva2100.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotalIva2100.ForeColor = System.Drawing.Color.Teal
        Me.txtSubTotalIva2100.Location = New System.Drawing.Point(720, 183)
        Me.txtSubTotalIva2100.Name = "txtSubTotalIva2100"
        Me.txtSubTotalIva2100.Size = New System.Drawing.Size(142, 22)
        Me.txtSubTotalIva2100.TabIndex = 81
        Me.txtSubTotalIva2100.Text = "$ 0.00"
        Me.txtSubTotalIva2100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSubTotalIva2100.Visible = False
        '
        'lblst
        '
        Me.lblst.BackColor = System.Drawing.Color.Transparent
        Me.lblst.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblst.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblst.Location = New System.Drawing.Point(724, 169)
        Me.lblst.Name = "lblst"
        Me.lblst.Size = New System.Drawing.Size(138, 18)
        Me.lblst.TabIndex = 84
        Me.lblst.Tag = ""
        Me.lblst.Text = "Sub Total IVA 21.0%"
        Me.lblst.Visible = False
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label16.Location = New System.Drawing.Point(573, 169)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(138, 18)
        Me.Label16.TabIndex = 82
        Me.Label16.Tag = ""
        Me.Label16.Text = "Sub Total IVA 10.5%"
        Me.Label16.Visible = False
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvDetalle.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetalle.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDetalle.Location = New System.Drawing.Point(9, 13)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalle.Size = New System.Drawing.Size(857, 192)
        Me.dgvDetalle.TabIndex = 8
        '
        'gbxDetalle
        '
        Me.gbxDetalle.BackColor = System.Drawing.Color.Transparent
        Me.gbxDetalle.Controls.Add(Me.Label19)
        Me.gbxDetalle.Controls.Add(Me.Label23)
        Me.gbxDetalle.Controls.Add(Me.txtIva105Contable)
        Me.gbxDetalle.Controls.Add(Me.txtIva21Contable)
        Me.gbxDetalle.Controls.Add(Me.txtSubTotalIva1050)
        Me.gbxDetalle.Controls.Add(Me.txtSubTotalIva2100)
        Me.gbxDetalle.Controls.Add(Me.lblst)
        Me.gbxDetalle.Controls.Add(Me.Label16)
        Me.gbxDetalle.Controls.Add(Me.dgvDetalle)
        Me.gbxDetalle.Enabled = False
        Me.gbxDetalle.Location = New System.Drawing.Point(10, 311)
        Me.gbxDetalle.Name = "gbxDetalle"
        Me.gbxDetalle.Size = New System.Drawing.Size(875, 212)
        Me.gbxDetalle.TabIndex = 82
        Me.gbxDetalle.TabStop = False
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label19.Location = New System.Drawing.Point(418, 169)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(138, 18)
        Me.Label19.TabIndex = 88
        Me.Label19.Tag = ""
        Me.Label19.Text = "IVA 21.0%"
        Me.Label19.Visible = False
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label23.Location = New System.Drawing.Point(267, 169)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(138, 18)
        Me.Label23.TabIndex = 87
        Me.Label23.Tag = ""
        Me.Label23.Text = "IVA 10.5%"
        Me.Label23.Visible = False
        '
        'txtIva105Contable
        '
        Me.txtIva105Contable.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtIva105Contable.Enabled = False
        Me.txtIva105Contable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIva105Contable.ForeColor = System.Drawing.Color.Teal
        Me.txtIva105Contable.Location = New System.Drawing.Point(263, 183)
        Me.txtIva105Contable.Name = "txtIva105Contable"
        Me.txtIva105Contable.Size = New System.Drawing.Size(142, 22)
        Me.txtIva105Contable.TabIndex = 86
        Me.txtIva105Contable.Text = "$ 0.00"
        Me.txtIva105Contable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIva105Contable.Visible = False
        '
        'txtIva21Contable
        '
        Me.txtIva21Contable.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtIva21Contable.Enabled = False
        Me.txtIva21Contable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIva21Contable.ForeColor = System.Drawing.Color.Teal
        Me.txtIva21Contable.Location = New System.Drawing.Point(414, 183)
        Me.txtIva21Contable.Name = "txtIva21Contable"
        Me.txtIva21Contable.Size = New System.Drawing.Size(142, 22)
        Me.txtIva21Contable.TabIndex = 85
        Me.txtIva21Contable.Text = "$ 0.00"
        Me.txtIva21Contable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIva21Contable.Visible = False
        '
        'gbxCliente
        '
        Me.gbxCliente.BackColor = System.Drawing.Color.Transparent
        Me.gbxCliente.Controls.Add(Me.Label33)
        Me.gbxCliente.Controls.Add(Me.txtEst)
        Me.gbxCliente.Controls.Add(Me.Label32)
        Me.gbxCliente.Controls.Add(Me.txtCred)
        Me.gbxCliente.Controls.Add(Me.Label31)
        Me.gbxCliente.Controls.Add(Me.Label30)
        Me.gbxCliente.Controls.Add(Me.Label29)
        Me.gbxCliente.Controls.Add(Me.Label28)
        Me.gbxCliente.Controls.Add(Me.Label27)
        Me.gbxCliente.Controls.Add(Me.Label26)
        Me.gbxCliente.Controls.Add(Me.txtProv)
        Me.gbxCliente.Controls.Add(Me.txtCatIva)
        Me.gbxCliente.Controls.Add(Me.txtIIBB)
        Me.gbxCliente.Controls.Add(Me.txtLoc)
        Me.gbxCliente.Controls.Add(Me.txtDir)
        Me.gbxCliente.Controls.Add(Me.txtCuit)
        Me.gbxCliente.Controls.Add(Me.Label6)
        Me.gbxCliente.Controls.Add(Me.Label1)
        Me.gbxCliente.Controls.Add(Me.txtCliente)
        Me.gbxCliente.Controls.Add(Me.txtIdCliente)
        Me.gbxCliente.Location = New System.Drawing.Point(147, 2)
        Me.gbxCliente.Name = "gbxCliente"
        Me.gbxCliente.Size = New System.Drawing.Size(738, 158)
        Me.gbxCliente.TabIndex = 84
        Me.gbxCliente.TabStop = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label33.Location = New System.Drawing.Point(428, 102)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(57, 16)
        Me.Label33.TabIndex = 79
        Me.Label33.Text = "Estado"
        '
        'txtEst
        '
        Me.txtEst.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtEst.Enabled = False
        Me.txtEst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEst.ForeColor = System.Drawing.Color.Teal
        Me.txtEst.Location = New System.Drawing.Point(431, 121)
        Me.txtEst.Name = "txtEst"
        Me.txtEst.Size = New System.Drawing.Size(153, 26)
        Me.txtEst.TabIndex = 78
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label32.Location = New System.Drawing.Point(587, 103)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(58, 16)
        Me.Label32.TabIndex = 77
        Me.Label32.Text = "Crédito"
        '
        'txtCred
        '
        Me.txtCred.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCred.Enabled = False
        Me.txtCred.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCred.ForeColor = System.Drawing.Color.Teal
        Me.txtCred.Location = New System.Drawing.Point(590, 121)
        Me.txtCred.Name = "txtCred"
        Me.txtCred.Size = New System.Drawing.Size(139, 26)
        Me.txtCred.TabIndex = 76
        Me.txtCred.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label31.Location = New System.Drawing.Point(159, 103)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(101, 16)
        Me.Label31.TabIndex = 75
        Me.Label31.Text = "Categoria Iva"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label30.Location = New System.Drawing.Point(6, 103)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(48, 16)
        Me.Label30.TabIndex = 74
        Me.Label30.Text = "II. BB."
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label29.Location = New System.Drawing.Point(532, 56)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(73, 16)
        Me.Label29.TabIndex = 73
        Me.Label29.Text = "Provincia"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label28.Location = New System.Drawing.Point(299, 56)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(77, 16)
        Me.Label28.TabIndex = 72
        Me.Label28.Text = "Localidad"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label27.Location = New System.Drawing.Point(6, 56)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(74, 16)
        Me.Label27.TabIndex = 71
        Me.Label27.Text = "Dirección"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label26.Location = New System.Drawing.Point(587, 11)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(43, 16)
        Me.Label26.TabIndex = 70
        Me.Label26.Text = "CUIT"
        '
        'txtProv
        '
        Me.txtProv.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtProv.Enabled = False
        Me.txtProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProv.ForeColor = System.Drawing.Color.Teal
        Me.txtProv.Location = New System.Drawing.Point(535, 74)
        Me.txtProv.Name = "txtProv"
        Me.txtProv.Size = New System.Drawing.Size(194, 26)
        Me.txtProv.TabIndex = 69
        '
        'txtCatIva
        '
        Me.txtCatIva.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCatIva.Enabled = False
        Me.txtCatIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCatIva.ForeColor = System.Drawing.Color.Teal
        Me.txtCatIva.Location = New System.Drawing.Point(162, 121)
        Me.txtCatIva.Name = "txtCatIva"
        Me.txtCatIva.Size = New System.Drawing.Size(263, 26)
        Me.txtCatIva.TabIndex = 68
        '
        'txtIIBB
        '
        Me.txtIIBB.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtIIBB.Enabled = False
        Me.txtIIBB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIIBB.ForeColor = System.Drawing.Color.Teal
        Me.txtIIBB.Location = New System.Drawing.Point(9, 121)
        Me.txtIIBB.Name = "txtIIBB"
        Me.txtIIBB.Size = New System.Drawing.Size(147, 26)
        Me.txtIIBB.TabIndex = 67
        '
        'txtLoc
        '
        Me.txtLoc.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtLoc.Enabled = False
        Me.txtLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoc.ForeColor = System.Drawing.Color.Teal
        Me.txtLoc.Location = New System.Drawing.Point(302, 74)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(227, 26)
        Me.txtLoc.TabIndex = 66
        '
        'txtDir
        '
        Me.txtDir.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtDir.Enabled = False
        Me.txtDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDir.ForeColor = System.Drawing.Color.Teal
        Me.txtDir.Location = New System.Drawing.Point(9, 75)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(287, 26)
        Me.txtDir.TabIndex = 65
        '
        'txtCuit
        '
        Me.txtCuit.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCuit.Enabled = False
        Me.txtCuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuit.ForeColor = System.Drawing.Color.Teal
        Me.txtCuit.Location = New System.Drawing.Point(590, 28)
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.Size = New System.Drawing.Size(139, 26)
        Me.txtCuit.TabIndex = 64
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label6.Location = New System.Drawing.Point(92, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Cliente"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Nro Cta"
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCliente.Enabled = False
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.ForeColor = System.Drawing.Color.Teal
        Me.txtCliente.Location = New System.Drawing.Point(95, 28)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(491, 26)
        Me.txtCliente.TabIndex = 1
        '
        'txtIdCliente
        '
        Me.txtIdCliente.BackColor = System.Drawing.Color.DimGray
        Me.txtIdCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCliente.ForeColor = System.Drawing.Color.White
        Me.txtIdCliente.Location = New System.Drawing.Point(9, 28)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(80, 26)
        Me.txtIdCliente.TabIndex = 0
        Me.txtIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.DimGray
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.ForeColor = System.Drawing.Color.White
        Me.txtFecha.Location = New System.Drawing.Point(6, 28)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(156, 26)
        Me.txtFecha.TabIndex = 2
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label2.Location = New System.Drawing.Point(6, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Fecha"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Image = Global.ByB_SI.My.Resources.Resources.Facturacion1
        Me.PictureBox1.Location = New System.Drawing.Point(10, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 83
        Me.PictureBox1.TabStop = False
        '
        'gbxCondPago
        '
        Me.gbxCondPago.BackColor = System.Drawing.Color.Transparent
        Me.gbxCondPago.Controls.Add(Me.dgvPago)
        Me.gbxCondPago.Controls.Add(Me.btnCargaCuota)
        Me.gbxCondPago.Controls.Add(Me.txtImpCta)
        Me.gbxCondPago.Controls.Add(Me.Label22)
        Me.gbxCondPago.Controls.Add(Me.txtVto)
        Me.gbxCondPago.Controls.Add(Me.Label21)
        Me.gbxCondPago.Controls.Add(Me.txtCuotas)
        Me.gbxCondPago.Controls.Add(Me.Label20)
        Me.gbxCondPago.Enabled = False
        Me.gbxCondPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxCondPago.ForeColor = System.Drawing.Color.LawnGreen
        Me.gbxCondPago.Location = New System.Drawing.Point(891, 373)
        Me.gbxCondPago.Name = "gbxCondPago"
        Me.gbxCondPago.Size = New System.Drawing.Size(169, 150)
        Me.gbxCondPago.TabIndex = 92
        Me.gbxCondPago.TabStop = False
        Me.gbxCondPago.Text = " Condición de Pago "
        '
        'dgvPago
        '
        Me.dgvPago.AllowUserToAddRows = False
        Me.dgvPago.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPago.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPago.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.LawnGreen
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPago.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPago.Location = New System.Drawing.Point(4, 86)
        Me.dgvPago.Name = "dgvPago"
        Me.dgvPago.ReadOnly = True
        Me.dgvPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPago.Size = New System.Drawing.Size(162, 58)
        Me.dgvPago.TabIndex = 85
        '
        'btnCargaCuota
        '
        Me.btnCargaCuota.BackColor = System.Drawing.SystemColors.Control
        Me.btnCargaCuota.BackgroundImage = Global.ByB_SI.My.Resources.Resources.IngresoIn
        Me.btnCargaCuota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCargaCuota.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCargaCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargaCuota.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCargaCuota.Location = New System.Drawing.Point(129, 11)
        Me.btnCargaCuota.Name = "btnCargaCuota"
        Me.btnCargaCuota.Size = New System.Drawing.Size(35, 28)
        Me.btnCargaCuota.TabIndex = 97
        Me.btnCargaCuota.Tag = ""
        Me.btnCargaCuota.UseVisualStyleBackColor = False
        '
        'txtImpCta
        '
        Me.txtImpCta.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtImpCta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpCta.ForeColor = System.Drawing.Color.Teal
        Me.txtImpCta.Location = New System.Drawing.Point(82, 64)
        Me.txtImpCta.Name = "txtImpCta"
        Me.txtImpCta.Size = New System.Drawing.Size(80, 20)
        Me.txtImpCta.TabIndex = 96
        Me.txtImpCta.Text = "$ 0.00"
        Me.txtImpCta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label22.Location = New System.Drawing.Point(7, 67)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 13)
        Me.Label22.TabIndex = 95
        Me.Label22.Tag = ""
        Me.Label22.Text = "Importe:"
        '
        'txtVto
        '
        Me.txtVto.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtVto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVto.ForeColor = System.Drawing.Color.Teal
        Me.txtVto.Location = New System.Drawing.Point(82, 40)
        Me.txtVto.Name = "txtVto"
        Me.txtVto.Size = New System.Drawing.Size(80, 20)
        Me.txtVto.TabIndex = 94
        Me.txtVto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label21.Location = New System.Drawing.Point(7, 43)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 13)
        Me.Label21.TabIndex = 93
        Me.Label21.Tag = ""
        Me.Label21.Text = "Vencimiento:"
        '
        'txtCuotas
        '
        Me.txtCuotas.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCuotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuotas.ForeColor = System.Drawing.Color.Teal
        Me.txtCuotas.Location = New System.Drawing.Point(82, 16)
        Me.txtCuotas.Name = "txtCuotas"
        Me.txtCuotas.Size = New System.Drawing.Size(41, 20)
        Me.txtCuotas.TabIndex = 92
        Me.txtCuotas.Text = "1"
        Me.txtCuotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label20.Location = New System.Drawing.Point(7, 19)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(50, 13)
        Me.Label20.TabIndex = 87
        Me.Label20.Tag = ""
        Me.Label20.Text = "Cuotas:"
        '
        'rbtFactura
        '
        Me.rbtFactura.AutoSize = True
        Me.rbtFactura.Checked = True
        Me.rbtFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtFactura.ForeColor = System.Drawing.Color.LawnGreen
        Me.rbtFactura.Location = New System.Drawing.Point(13, 13)
        Me.rbtFactura.Name = "rbtFactura"
        Me.rbtFactura.Size = New System.Drawing.Size(97, 20)
        Me.rbtFactura.TabIndex = 4
        Me.rbtFactura.TabStop = True
        Me.rbtFactura.Text = "FACTURA"
        Me.rbtFactura.UseVisualStyleBackColor = True
        '
        'rbnND
        '
        Me.rbnND.AutoSize = True
        Me.rbnND.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnND.ForeColor = System.Drawing.Color.LawnGreen
        Me.rbnND.Location = New System.Drawing.Point(279, 13)
        Me.rbnND.Name = "rbnND"
        Me.rbnND.Size = New System.Drawing.Size(128, 20)
        Me.rbnND.TabIndex = 6
        Me.rbnND.Text = "NOTA DEBITO"
        Me.rbnND.UseVisualStyleBackColor = True
        '
        'rbtnNC
        '
        Me.rbtnNC.AutoSize = True
        Me.rbtnNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnNC.ForeColor = System.Drawing.Color.LawnGreen
        Me.rbtnNC.Location = New System.Drawing.Point(125, 13)
        Me.rbtnNC.Name = "rbtnNC"
        Me.rbtnNC.Size = New System.Drawing.Size(139, 20)
        Me.rbtnNC.TabIndex = 5
        Me.rbtnNC.Text = "NOTA CREDITO"
        Me.rbtnNC.UseVisualStyleBackColor = True
        '
        'rbtnOtras
        '
        Me.rbtnOtras.AutoSize = True
        Me.rbtnOtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnOtras.ForeColor = System.Drawing.Color.LawnGreen
        Me.rbtnOtras.Location = New System.Drawing.Point(414, 13)
        Me.rbtnOtras.Name = "rbtnOtras"
        Me.rbtnOtras.Size = New System.Drawing.Size(78, 20)
        Me.rbtnOtras.TabIndex = 7
        Me.rbtnOtras.Text = "OTRAS"
        Me.rbtnOtras.UseVisualStyleBackColor = True
        '
        'rbtCtaCte
        '
        Me.rbtCtaCte.AutoSize = True
        Me.rbtCtaCte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCtaCte.ForeColor = System.Drawing.Color.LawnGreen
        Me.rbtCtaCte.Location = New System.Drawing.Point(114, 13)
        Me.rbtCtaCte.Name = "rbtCtaCte"
        Me.rbtCtaCte.Size = New System.Drawing.Size(90, 20)
        Me.rbtCtaCte.TabIndex = 5
        Me.rbtCtaCte.Text = "CTA CTE"
        Me.rbtCtaCte.UseVisualStyleBackColor = True
        '
        'rbtCdo
        '
        Me.rbtCdo.AutoSize = True
        Me.rbtCdo.Checked = True
        Me.rbtCdo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCdo.ForeColor = System.Drawing.Color.LawnGreen
        Me.rbtCdo.Location = New System.Drawing.Point(6, 13)
        Me.rbtCdo.Name = "rbtCdo"
        Me.rbtCdo.Size = New System.Drawing.Size(100, 20)
        Me.rbtCdo.TabIndex = 4
        Me.rbtCdo.TabStop = True
        Me.rbtCdo.Text = "CONTADO"
        Me.rbtCdo.UseVisualStyleBackColor = True
        '
        'gbxFactura
        '
        Me.gbxFactura.BackColor = System.Drawing.Color.Transparent
        Me.gbxFactura.Controls.Add(Me.Label24)
        Me.gbxFactura.Controls.Add(Me.lblPtoVta)
        Me.gbxFactura.Controls.Add(Me.lblComprobante)
        Me.gbxFactura.Controls.Add(Me.Label2)
        Me.gbxFactura.Controls.Add(Me.txtFecha)
        Me.gbxFactura.Controls.Add(Me.Label4)
        Me.gbxFactura.Enabled = False
        Me.gbxFactura.Location = New System.Drawing.Point(891, 2)
        Me.gbxFactura.Name = "gbxFactura"
        Me.gbxFactura.Size = New System.Drawing.Size(169, 110)
        Me.gbxFactura.TabIndex = 93
        Me.gbxFactura.TabStop = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label24.Location = New System.Drawing.Point(3, 56)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(58, 16)
        Me.Label24.TabIndex = 65
        Me.Label24.Text = "Pto Vta"
        '
        'lblPtoVta
        '
        Me.lblPtoVta.BackColor = System.Drawing.Color.DimGray
        Me.lblPtoVta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPtoVta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtoVta.ForeColor = System.Drawing.Color.White
        Me.lblPtoVta.Location = New System.Drawing.Point(6, 74)
        Me.lblPtoVta.Name = "lblPtoVta"
        Me.lblPtoVta.Size = New System.Drawing.Size(49, 25)
        Me.lblPtoVta.TabIndex = 64
        Me.lblPtoVta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblComprobante
        '
        Me.lblComprobante.BackColor = System.Drawing.Color.DimGray
        Me.lblComprobante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComprobante.ForeColor = System.Drawing.Color.White
        Me.lblComprobante.Location = New System.Drawing.Point(61, 74)
        Me.lblComprobante.Name = "lblComprobante"
        Me.lblComprobante.Size = New System.Drawing.Size(101, 25)
        Me.lblComprobante.TabIndex = 63
        Me.lblComprobante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbxLetra
        '
        Me.gbxLetra.BackColor = System.Drawing.Color.Transparent
        Me.gbxLetra.Controls.Add(Me.lblCodComprobante)
        Me.gbxLetra.Controls.Add(Me.lblLetra)
        Me.gbxLetra.Controls.Add(Me.Label34)
        Me.gbxLetra.Enabled = False
        Me.gbxLetra.Location = New System.Drawing.Point(891, 118)
        Me.gbxLetra.Name = "gbxLetra"
        Me.gbxLetra.Size = New System.Drawing.Size(169, 82)
        Me.gbxLetra.TabIndex = 94
        Me.gbxLetra.TabStop = False
        '
        'lblCodComprobante
        '
        Me.lblCodComprobante.AutoSize = True
        Me.lblCodComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodComprobante.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblCodComprobante.Location = New System.Drawing.Point(53, 38)
        Me.lblCodComprobante.Name = "lblCodComprobante"
        Me.lblCodComprobante.Size = New System.Drawing.Size(24, 16)
        Me.lblCodComprobante.TabIndex = 81
        Me.lblCodComprobante.Text = "01"
        '
        'lblLetra
        '
        Me.lblLetra.BackColor = System.Drawing.Color.Maroon
        Me.lblLetra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLetra.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblLetra.Font = New System.Drawing.Font("Arial Black", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetra.ForeColor = System.Drawing.Color.White
        Me.lblLetra.Location = New System.Drawing.Point(92, 11)
        Me.lblLetra.Name = "lblLetra"
        Me.lblLetra.Size = New System.Drawing.Size(70, 64)
        Me.lblLetra.TabIndex = 80
        Me.lblLetra.Text = "A"
        Me.lblLetra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label34.Location = New System.Drawing.Point(7, 38)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(40, 16)
        Me.Label34.TabIndex = 79
        Me.Label34.Text = "Cód."
        '
        'gbxTipoC
        '
        Me.gbxTipoC.BackColor = System.Drawing.Color.Transparent
        Me.gbxTipoC.Controls.Add(Me.rbtnOtras)
        Me.gbxTipoC.Controls.Add(Me.rbtFactura)
        Me.gbxTipoC.Controls.Add(Me.rbnND)
        Me.gbxTipoC.Controls.Add(Me.rbtnNC)
        Me.gbxTipoC.Enabled = False
        Me.gbxTipoC.Location = New System.Drawing.Point(10, 160)
        Me.gbxTipoC.Name = "gbxTipoC"
        Me.gbxTipoC.Size = New System.Drawing.Size(513, 40)
        Me.gbxTipoC.TabIndex = 95
        Me.gbxTipoC.TabStop = False
        '
        'gbxTipoVta
        '
        Me.gbxTipoVta.BackColor = System.Drawing.Color.Transparent
        Me.gbxTipoVta.Controls.Add(Me.rbtCtaCte)
        Me.gbxTipoVta.Controls.Add(Me.rbtCdo)
        Me.gbxTipoVta.Enabled = False
        Me.gbxTipoVta.Location = New System.Drawing.Point(529, 160)
        Me.gbxTipoVta.Name = "gbxTipoVta"
        Me.gbxTipoVta.Size = New System.Drawing.Size(204, 40)
        Me.gbxTipoVta.TabIndex = 96
        Me.gbxTipoVta.TabStop = False
        '
        'tmrActNroComp
        '
        Me.tmrActNroComp.Interval = 1000
        '
        'gbxConceptos
        '
        Me.gbxConceptos.BackColor = System.Drawing.Color.Transparent
        Me.gbxConceptos.Controls.Add(Me.cbxConceptos)
        Me.gbxConceptos.Enabled = False
        Me.gbxConceptos.Location = New System.Drawing.Point(739, 160)
        Me.gbxConceptos.Name = "gbxConceptos"
        Me.gbxConceptos.Size = New System.Drawing.Size(146, 40)
        Me.gbxConceptos.TabIndex = 98
        Me.gbxConceptos.TabStop = False
        '
        'cbxConceptos
        '
        Me.cbxConceptos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxConceptos.FormattingEnabled = True
        Me.cbxConceptos.Items.AddRange(New Object() {"1 - Productos", "2 - Servicios", "3 - Productos y Servicios"})
        Me.cbxConceptos.Location = New System.Drawing.Point(6, 12)
        Me.cbxConceptos.Name = "cbxConceptos"
        Me.cbxConceptos.Size = New System.Drawing.Size(134, 21)
        Me.cbxConceptos.TabIndex = 99
        Me.cbxConceptos.Text = "1 - Productos"
        '
        'lblTiket
        '
        Me.lblTiket.BackColor = System.Drawing.Color.DarkOrange
        Me.lblTiket.Location = New System.Drawing.Point(17, 133)
        Me.lblTiket.Name = "lblTiket"
        Me.lblTiket.Size = New System.Drawing.Size(124, 20)
        Me.lblTiket.TabIndex = 97
        Me.lblTiket.Text = "Tiket"
        Me.lblTiket.Visible = False
        '
        'lblIdFactura
        '
        Me.lblIdFactura.BackColor = System.Drawing.Color.DarkOrange
        Me.lblIdFactura.Location = New System.Drawing.Point(13, 19)
        Me.lblIdFactura.Name = "lblIdFactura"
        Me.lblIdFactura.Size = New System.Drawing.Size(124, 20)
        Me.lblIdFactura.TabIndex = 99
        Me.lblIdFactura.Visible = False
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.BackColor = System.Drawing.Color.DarkOrange
        Me.lblEnter.Location = New System.Drawing.Point(15, 46)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(21, 13)
        Me.lblEnter.TabIndex = 100
        Me.lblEnter.Text = "No"
        Me.lblEnter.Visible = False
        '
        'dgvCtaCte
        '
        Me.dgvCtaCte.AllowUserToAddRows = False
        Me.dgvCtaCte.AllowUserToDeleteRows = False
        Me.dgvCtaCte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCtaCte.Location = New System.Drawing.Point(33, 47)
        Me.dgvCtaCte.Name = "dgvCtaCte"
        Me.dgvCtaCte.ReadOnly = True
        Me.dgvCtaCte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCtaCte.Size = New System.Drawing.Size(87, 27)
        Me.dgvCtaCte.TabIndex = 122
        Me.dgvCtaCte.VirtualMode = True
        '
        'dgvCaja
        '
        Me.dgvCaja.AllowUserToAddRows = False
        Me.dgvCaja.AllowUserToDeleteRows = False
        Me.dgvCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCaja.Location = New System.Drawing.Point(33, 126)
        Me.dgvCaja.Name = "dgvCaja"
        Me.dgvCaja.ReadOnly = True
        Me.dgvCaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCaja.Size = New System.Drawing.Size(87, 27)
        Me.dgvCaja.TabIndex = 120
        Me.dgvCaja.VirtualMode = True
        '
        'frmFacturaVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ByB_SI.My.Resources.Resources.Fondo_23___Reducido
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1070, 600)
        Me.Controls.Add(Me.lblEnter)
        Me.Controls.Add(Me.lblIdFactura)
        Me.Controls.Add(Me.gbxConceptos)
        Me.Controls.Add(Me.lblTiket)
        Me.Controls.Add(Me.btnEmitirFactura)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.gbxTipoVta)
        Me.Controls.Add(Me.gbxTipoC)
        Me.Controls.Add(Me.gbxLetra)
        Me.Controls.Add(Me.gbxFactura)
        Me.Controls.Add(Me.gbxCondPago)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gbxCarga)
        Me.Controls.Add(Me.gbxResumen)
        Me.Controls.Add(Me.dgvCliente)
        Me.Controls.Add(Me.gbxControles)
        Me.Controls.Add(Me.gbxObserv)
        Me.Controls.Add(Me.dgvStock)
        Me.Controls.Add(Me.gbxDetalle)
        Me.Controls.Add(Me.gbxCliente)
        Me.Controls.Add(Me.dgvCtaCte)
        Me.Controls.Add(Me.dgvCaja)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFacturaVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFacturaVentas"
        Me.gbxCarga.ResumeLayout(False)
        Me.gbxCarga.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbxResumen.ResumeLayout(False)
        Me.gbxResumen.PerformLayout()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxControles.ResumeLayout(False)
        Me.gbxControles.PerformLayout()
        Me.gbxObserv.ResumeLayout(False)
        Me.gbxObserv.PerformLayout()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDetalle.ResumeLayout(False)
        Me.gbxDetalle.PerformLayout()
        Me.gbxCliente.ResumeLayout(False)
        Me.gbxCliente.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxCondPago.ResumeLayout(False)
        Me.gbxCondPago.PerformLayout()
        CType(Me.dgvPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxFactura.ResumeLayout(False)
        Me.gbxFactura.PerformLayout()
        Me.gbxLetra.ResumeLayout(False)
        Me.gbxLetra.PerformLayout()
        Me.gbxTipoC.ResumeLayout(False)
        Me.gbxTipoC.PerformLayout()
        Me.gbxTipoVta.ResumeLayout(False)
        Me.gbxTipoVta.PerformLayout()
        Me.gbxConceptos.ResumeLayout(False)
        CType(Me.dgvCtaCte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbxCarga As System.Windows.Forms.GroupBox
    Friend WithEvents txtArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtIdArt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAlicIva As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCdBarra As System.Windows.Forms.TextBox
    Friend WithEvents txtAlIvaReal As System.Windows.Forms.TextBox
    Friend WithEvents lblFuncion As System.Windows.Forms.Label
    Friend WithEvents lblIdDet As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCdEmp As System.Windows.Forms.TextBox
    Friend WithEvents gbxResumen As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtIva21 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtIva105 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
    Friend WithEvents gbxControles As System.Windows.Forms.GroupBox
    Friend WithEvents lblManual As System.Windows.Forms.Label
    Friend WithEvents btnManual As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents gbxObserv As System.Windows.Forms.GroupBox
    Friend WithEvents btnEmitirFactura As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents dgvStock As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents txtSubTotalIva1050 As System.Windows.Forms.TextBox
    Friend WithEvents txtSubTotalIva2100 As System.Windows.Forms.TextBox
    Friend WithEvents lblst As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents gbxDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents gbxCliente As System.Windows.Forms.GroupBox
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtIdCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtIdStock As System.Windows.Forms.TextBox
    Friend WithEvents rbtCtaCte As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCdo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnOtras As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnNC As System.Windows.Forms.RadioButton
    Friend WithEvents rbnND As System.Windows.Forms.RadioButton
    Friend WithEvents rbtFactura As System.Windows.Forms.RadioButton
    Friend WithEvents gbxCondPago As System.Windows.Forms.GroupBox
    Friend WithEvents gbxFactura As System.Windows.Forms.GroupBox
    Friend WithEvents gbxLetra As System.Windows.Forms.GroupBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtEst As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtCred As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtProv As System.Windows.Forms.TextBox
    Friend WithEvents txtCatIva As System.Windows.Forms.TextBox
    Friend WithEvents txtIIBB As System.Windows.Forms.TextBox
    Friend WithEvents txtLoc As System.Windows.Forms.TextBox
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents txtCuit As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents gbxTipoC As System.Windows.Forms.GroupBox
    Friend WithEvents gbxTipoVta As System.Windows.Forms.GroupBox
    Friend WithEvents txtObserv As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtImpCta As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtVto As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtCuotas As System.Windows.Forms.TextBox
    Friend WithEvents lblLetra As System.Windows.Forms.Label
    Friend WithEvents btnCargaCuota As System.Windows.Forms.Button
    Friend WithEvents txtPrecioFin As System.Windows.Forms.TextBox
    Friend WithEvents txtImpFinal As System.Windows.Forms.TextBox
    Friend WithEvents dgvPago As System.Windows.Forms.DataGridView
    Friend WithEvents tmrActNroComp As System.Windows.Forms.Timer
    Friend WithEvents lblComprobante As System.Windows.Forms.Label
    Friend WithEvents gbxConceptos As System.Windows.Forms.GroupBox
    Friend WithEvents cbxConceptos As System.Windows.Forms.ComboBox
    Friend WithEvents lblTiket As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtIva105Contable As System.Windows.Forms.TextBox
    Friend WithEvents txtIva21Contable As System.Windows.Forms.TextBox
    Friend WithEvents lblCodComprobante As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lblPtoVta As System.Windows.Forms.Label
    Friend WithEvents lblIdFactura As System.Windows.Forms.Label
    Friend WithEvents lblEnter As System.Windows.Forms.Label
    Friend WithEvents dgvCtaCte As System.Windows.Forms.DataGridView
    Friend WithEvents dgvCaja As System.Windows.Forms.DataGridView
End Class
