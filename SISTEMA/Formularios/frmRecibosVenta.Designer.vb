<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecibosVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecibosVenta))
        Me.dgvCliente = New System.Windows.Forms.DataGridView()
        Me.lblFuncion = New System.Windows.Forms.Label()
        Me.lblIdUs = New System.Windows.Forms.Label()
        Me.lblFunValor = New System.Windows.Forms.Label()
        Me.lblidDetCaja = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLibrador = New System.Windows.Forms.TextBox()
        Me.btnCancelarValor = New System.Windows.Forms.Button()
        Me.cbxTipoValor = New System.Windows.Forms.ComboBox()
        Me.dgvCaja = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnModValor = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbxDetalle = New System.Windows.Forms.GroupBox()
        Me.btnEliminarValor = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnCargarValor = New System.Windows.Forms.Button()
        Me.txtObsValor = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCdEmp = New System.Windows.Forms.TextBox()
        Me.txtImpValor = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtFecCobro = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtSucursal = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtValNum = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cbxBanco = New System.Windows.Forms.ComboBox()
        Me.gbxValores = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgvBufDetalle = New System.Windows.Forms.DataGridView()
        Me.ElimBuff = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtTotVal = New System.Windows.Forms.TextBox()
        Me.tmrHora = New System.Windows.Forms.Timer(Me.components)
        Me.lblOrigen = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtObserv = New System.Windows.Forms.TextBox()
        Me.txtIdCli = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFecAlta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.tmrMensaje = New System.Windows.Forms.Timer(Me.components)
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gbxDatos = New System.Windows.Forms.GroupBox()
        Me.txtImpTexto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxTipoMov = New System.Windows.Forms.ComboBox()
        Me.txtNroRecibo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPtoVta = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dgvCtaCte = New System.Windows.Forms.DataGridView()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDetalle.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbxValores.SuspendLayout()
        CType(Me.dgvBufDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatos.SuspendLayout()
        CType(Me.dgvCtaCte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCliente
        '
        Me.dgvCliente.AllowUserToAddRows = False
        Me.dgvCliente.AllowUserToDeleteRows = False
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCliente.Location = New System.Drawing.Point(16, 15)
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.ReadOnly = True
        Me.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCliente.Size = New System.Drawing.Size(87, 28)
        Me.dgvCliente.TabIndex = 118
        Me.dgvCliente.VirtualMode = True
        '
        'lblFuncion
        '
        Me.lblFuncion.BackColor = System.Drawing.Color.White
        Me.lblFuncion.Location = New System.Drawing.Point(151, -4)
        Me.lblFuncion.Name = "lblFuncion"
        Me.lblFuncion.Size = New System.Drawing.Size(59, 20)
        Me.lblFuncion.TabIndex = 101
        Me.lblFuncion.Visible = False
        '
        'lblIdUs
        '
        Me.lblIdUs.BackColor = System.Drawing.SystemColors.Control
        Me.lblIdUs.Location = New System.Drawing.Point(74, -4)
        Me.lblIdUs.Name = "lblIdUs"
        Me.lblIdUs.Size = New System.Drawing.Size(71, 20)
        Me.lblIdUs.TabIndex = 32
        Me.lblIdUs.Visible = False
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
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.CancelarIn
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCancelar.Location = New System.Drawing.Point(847, 143)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(61, 60)
        Me.btnCancelar.TabIndex = 111
        Me.btnCancelar.Tag = ""
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.Transparent
        Me.lblMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Location = New System.Drawing.Point(933, 512)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(128, 50)
        Me.lblMsg.TabIndex = 115
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label3.Location = New System.Drawing.Point(3, 50)
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
        Me.txtLibrador.Location = New System.Drawing.Point(6, 64)
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
        Me.btnCancelarValor.Location = New System.Drawing.Point(738, 92)
        Me.btnCancelarValor.Name = "btnCancelarValor"
        Me.btnCancelarValor.Size = New System.Drawing.Size(37, 38)
        Me.btnCancelarValor.TabIndex = 76
        Me.btnCancelarValor.Tag = ""
        Me.btnCancelarValor.UseVisualStyleBackColor = True
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
        'dgvCaja
        '
        Me.dgvCaja.AllowUserToAddRows = False
        Me.dgvCaja.AllowUserToDeleteRows = False
        Me.dgvCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCaja.Location = New System.Drawing.Point(16, 44)
        Me.dgvCaja.Name = "dgvCaja"
        Me.dgvCaja.ReadOnly = True
        Me.dgvCaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCaja.Size = New System.Drawing.Size(87, 27)
        Me.dgvCaja.TabIndex = 119
        Me.dgvCaja.VirtualMode = True
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
        Me.btnModValor.Location = New System.Drawing.Point(695, 92)
        Me.btnModValor.Name = "btnModValor"
        Me.btnModValor.Size = New System.Drawing.Size(37, 38)
        Me.btnModValor.TabIndex = 75
        Me.btnModValor.Tag = ""
        Me.btnModValor.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Image = Global.ByB_SI.My.Resources.Resources.Recibos
        Me.PictureBox1.Location = New System.Drawing.Point(7, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 107
        Me.PictureBox1.TabStop = False
        '
        'gbxDetalle
        '
        Me.gbxDetalle.BackColor = System.Drawing.Color.Transparent
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
        Me.gbxDetalle.Controls.Add(Me.txtObsValor)
        Me.gbxDetalle.Controls.Add(Me.Label13)
        Me.gbxDetalle.Controls.Add(Me.GroupBox1)
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
        Me.gbxDetalle.Location = New System.Drawing.Point(7, 201)
        Me.gbxDetalle.Name = "gbxDetalle"
        Me.gbxDetalle.Size = New System.Drawing.Size(823, 138)
        Me.gbxDetalle.TabIndex = 116
        Me.gbxDetalle.TabStop = False
        '
        'btnEliminarValor
        '
        Me.btnEliminarValor.BackgroundImage = Global.ByB_SI.My.Resources.Resources.EliminarIn
        Me.btnEliminarValor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEliminarValor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarValor.Location = New System.Drawing.Point(780, 92)
        Me.btnEliminarValor.Name = "btnEliminarValor"
        Me.btnEliminarValor.Size = New System.Drawing.Size(37, 38)
        Me.btnEliminarValor.TabIndex = 34
        Me.btnEliminarValor.Tag = ""
        Me.btnEliminarValor.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label10.Location = New System.Drawing.Point(238, 50)
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
        Me.btnCargarValor.Location = New System.Drawing.Point(653, 92)
        Me.btnCargarValor.Name = "btnCargarValor"
        Me.btnCargarValor.Size = New System.Drawing.Size(37, 38)
        Me.btnCargarValor.TabIndex = 74
        Me.btnCargarValor.Tag = ""
        Me.btnCargarValor.UseVisualStyleBackColor = True
        '
        'txtObsValor
        '
        Me.txtObsValor.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtObsValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObsValor.ForeColor = System.Drawing.Color.Teal
        Me.txtObsValor.Location = New System.Drawing.Point(457, 64)
        Me.txtObsValor.Name = "txtObsValor"
        Me.txtObsValor.Size = New System.Drawing.Size(360, 22)
        Me.txtObsValor.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label13.Location = New System.Drawing.Point(454, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 13)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Observaciones"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCdEmp)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.LawnGreen
        Me.GroupBox1.Location = New System.Drawing.Point(9, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(110, 35)
        Me.GroupBox1.TabIndex = 117
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Codigo Empresa"
        Me.GroupBox1.Visible = False
        '
        'txtCdEmp
        '
        Me.txtCdEmp.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCdEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCdEmp.ForeColor = System.Drawing.Color.Teal
        Me.txtCdEmp.Location = New System.Drawing.Point(6, 9)
        Me.txtCdEmp.Name = "txtCdEmp"
        Me.txtCdEmp.Size = New System.Drawing.Size(90, 26)
        Me.txtCdEmp.TabIndex = 60
        Me.txtCdEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtImpValor
        '
        Me.txtImpValor.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtImpValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpValor.ForeColor = System.Drawing.Color.Teal
        Me.txtImpValor.Location = New System.Drawing.Point(350, 64)
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
        Me.Label14.Location = New System.Drawing.Point(347, 50)
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
        Me.txtFecCobro.Location = New System.Drawing.Point(241, 64)
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
        Me.Label18.Location = New System.Drawing.Point(499, 9)
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
        Me.txtSucursal.Location = New System.Drawing.Point(502, 25)
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Size = New System.Drawing.Size(315, 22)
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
        'gbxValores
        '
        Me.gbxValores.BackColor = System.Drawing.Color.Transparent
        Me.gbxValores.Controls.Add(Me.Label11)
        Me.gbxValores.Controls.Add(Me.dgvBufDetalle)
        Me.gbxValores.Controls.Add(Me.txtTotVal)
        Me.gbxValores.Location = New System.Drawing.Point(7, 341)
        Me.gbxValores.Name = "gbxValores"
        Me.gbxValores.Size = New System.Drawing.Size(823, 235)
        Me.gbxValores.TabIndex = 120
        Me.gbxValores.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label11.Location = New System.Drawing.Point(594, 212)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 13)
        Me.Label11.TabIndex = 105
        Me.Label11.Text = "Total Valores ="
        '
        'dgvBufDetalle
        '
        Me.dgvBufDetalle.AllowUserToAddRows = False
        Me.dgvBufDetalle.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvBufDetalle.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBufDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvBufDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvBufDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBufDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ElimBuff})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBufDetalle.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBufDetalle.Location = New System.Drawing.Point(6, 13)
        Me.dgvBufDetalle.Name = "dgvBufDetalle"
        Me.dgvBufDetalle.ReadOnly = True
        Me.dgvBufDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBufDetalle.Size = New System.Drawing.Size(806, 188)
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
        'txtTotVal
        '
        Me.txtTotVal.BackColor = System.Drawing.Color.Orange
        Me.txtTotVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotVal.ForeColor = System.Drawing.Color.White
        Me.txtTotVal.Location = New System.Drawing.Point(693, 207)
        Me.txtTotVal.Name = "txtTotVal"
        Me.txtTotVal.Size = New System.Drawing.Size(119, 22)
        Me.txtTotVal.TabIndex = 105
        Me.txtTotVal.Text = "$ 0.00"
        Me.txtTotVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tmrHora
        '
        Me.tmrHora.Enabled = True
        Me.tmrHora.Interval = 1000
        '
        'lblOrigen
        '
        Me.lblOrigen.BackColor = System.Drawing.SystemColors.Control
        Me.lblOrigen.Location = New System.Drawing.Point(9, -4)
        Me.lblOrigen.Name = "lblOrigen"
        Me.lblOrigen.Size = New System.Drawing.Size(59, 20)
        Me.lblOrigen.TabIndex = 67
        Me.lblOrigen.Text = "Cliente"
        Me.lblOrigen.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label15.Location = New System.Drawing.Point(252, 59)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 16)
        Me.Label15.TabIndex = 71
        Me.Label15.Text = "Razón Social"
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
        'txtObserv
        '
        Me.txtObserv.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtObserv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObserv.ForeColor = System.Drawing.Color.Teal
        Me.txtObserv.Location = New System.Drawing.Point(174, 117)
        Me.txtObserv.Name = "txtObserv"
        Me.txtObserv.Size = New System.Drawing.Size(527, 22)
        Me.txtObserv.TabIndex = 13
        '
        'txtIdCli
        '
        Me.txtIdCli.BackColor = System.Drawing.Color.DarkGray
        Me.txtIdCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCli.ForeColor = System.Drawing.Color.Black
        Me.txtIdCli.Location = New System.Drawing.Point(174, 75)
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
        Me.Label9.Location = New System.Drawing.Point(171, 98)
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
        Me.txtImporte.Location = New System.Drawing.Point(9, 117)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(159, 22)
        Me.txtImporte.TabIndex = 6
        Me.txtImporte.Text = "$ 0.00"
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label8.Location = New System.Drawing.Point(6, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 16)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Importe"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label4.Location = New System.Drawing.Point(174, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Cuenta"
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.ForeColor = System.Drawing.Color.Teal
        Me.txtCliente.Location = New System.Drawing.Point(252, 75)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(449, 22)
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
        Me.Label5.Location = New System.Drawing.Point(6, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 16)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Tipo Recibo"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackgroundImage = Global.ByB_SI.My.Resources.Resources.NuevoIn
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnNuevo.Location = New System.Drawing.Point(847, 12)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(61, 59)
        Me.btnNuevo.TabIndex = 108
        Me.btnNuevo.Tag = ""
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'tmrMensaje
        '
        Me.tmrMensaje.Interval = 5000
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
        Me.btnGuardar.Location = New System.Drawing.Point(847, 77)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(61, 60)
        Me.btnGuardar.TabIndex = 110
        Me.btnGuardar.Tag = ""
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = Global.ByB_SI.My.Resources.Resources.SalirIn
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Location = New System.Drawing.Point(847, 505)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(61, 61)
        Me.btnSalir.TabIndex = 112
        Me.btnSalir.Tag = ""
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'gbxDatos
        '
        Me.gbxDatos.BackColor = System.Drawing.Color.Transparent
        Me.gbxDatos.Controls.Add(Me.txtImpTexto)
        Me.gbxDatos.Controls.Add(Me.Label6)
        Me.gbxDatos.Controls.Add(Me.lblFuncion)
        Me.gbxDatos.Controls.Add(Me.lblIdUs)
        Me.gbxDatos.Controls.Add(Me.lblOrigen)
        Me.gbxDatos.Controls.Add(Me.Label15)
        Me.gbxDatos.Controls.Add(Me.Label19)
        Me.gbxDatos.Controls.Add(Me.txtObserv)
        Me.gbxDatos.Controls.Add(Me.txtIdCli)
        Me.gbxDatos.Controls.Add(Me.Label9)
        Me.gbxDatos.Controls.Add(Me.txtImporte)
        Me.gbxDatos.Controls.Add(Me.Label8)
        Me.gbxDatos.Controls.Add(Me.txtHora)
        Me.gbxDatos.Controls.Add(Me.Label4)
        Me.gbxDatos.Controls.Add(Me.txtCliente)
        Me.gbxDatos.Controls.Add(Me.Label2)
        Me.gbxDatos.Controls.Add(Me.txtFecAlta)
        Me.gbxDatos.Controls.Add(Me.Label5)
        Me.gbxDatos.Controls.Add(Me.cbxTipoMov)
        Me.gbxDatos.Enabled = False
        Me.gbxDatos.Location = New System.Drawing.Point(123, 11)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.Size = New System.Drawing.Size(707, 188)
        Me.gbxDatos.TabIndex = 113
        Me.gbxDatos.TabStop = False
        '
        'txtImpTexto
        '
        Me.txtImpTexto.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtImpTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpTexto.ForeColor = System.Drawing.Color.Teal
        Me.txtImpTexto.Location = New System.Drawing.Point(9, 161)
        Me.txtImpTexto.Name = "txtImpTexto"
        Me.txtImpTexto.Size = New System.Drawing.Size(692, 22)
        Me.txtImpTexto.TabIndex = 102
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label6.Location = New System.Drawing.Point(6, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 16)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "Importe En Letras"
        '
        'cbxTipoMov
        '
        Me.cbxTipoMov.BackColor = System.Drawing.Color.MediumTurquoise
        Me.cbxTipoMov.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipoMov.ForeColor = System.Drawing.Color.Teal
        Me.cbxTipoMov.FormattingEnabled = True
        Me.cbxTipoMov.Items.AddRange(New Object() {"Recibo Oficial", "Recibo Provisorio"})
        Me.cbxTipoMov.Location = New System.Drawing.Point(9, 73)
        Me.cbxTipoMov.Name = "cbxTipoMov"
        Me.cbxTipoMov.Size = New System.Drawing.Size(159, 24)
        Me.cbxTipoMov.TabIndex = 11
        '
        'txtNroRecibo
        '
        Me.txtNroRecibo.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtNroRecibo.Enabled = False
        Me.txtNroRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroRecibo.ForeColor = System.Drawing.Color.Teal
        Me.txtNroRecibo.Location = New System.Drawing.Point(7, 178)
        Me.txtNroRecibo.Name = "txtNroRecibo"
        Me.txtNroRecibo.Size = New System.Drawing.Size(110, 22)
        Me.txtNroRecibo.TabIndex = 104
        Me.txtNroRecibo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label7.Location = New System.Drawing.Point(4, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 16)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "Nro Recibo"
        '
        'txtPtoVta
        '
        Me.txtPtoVta.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtPtoVta.Enabled = False
        Me.txtPtoVta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPtoVta.ForeColor = System.Drawing.Color.Teal
        Me.txtPtoVta.Location = New System.Drawing.Point(50, 134)
        Me.txtPtoVta.Name = "txtPtoVta"
        Me.txtPtoVta.Size = New System.Drawing.Size(67, 22)
        Me.txtPtoVta.TabIndex = 105
        Me.txtPtoVta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label16.Location = New System.Drawing.Point(47, 118)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 16)
        Me.Label16.TabIndex = 105
        Me.Label16.Text = "PuntoVta"
        '
        'dgvCtaCte
        '
        Me.dgvCtaCte.AllowUserToAddRows = False
        Me.dgvCtaCte.AllowUserToDeleteRows = False
        Me.dgvCtaCte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCtaCte.Location = New System.Drawing.Point(16, 70)
        Me.dgvCtaCte.Name = "dgvCtaCte"
        Me.dgvCtaCte.ReadOnly = True
        Me.dgvCtaCte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCtaCte.Size = New System.Drawing.Size(87, 27)
        Me.dgvCtaCte.TabIndex = 121
        Me.dgvCtaCte.VirtualMode = True
        '
        'frmRecibosVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ByB_SI.My.Resources.Resources.Fondo_23___Reducido
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(916, 582)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtPtoVta)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNroRecibo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.gbxDetalle)
        Me.Controls.Add(Me.gbxValores)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dgvCaja)
        Me.Controls.Add(Me.gbxDatos)
        Me.Controls.Add(Me.dgvCliente)
        Me.Controls.Add(Me.dgvCtaCte)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRecibosVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRecibosVenta"
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDetalle.ResumeLayout(False)
        Me.gbxDetalle.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbxValores.ResumeLayout(False)
        Me.gbxValores.PerformLayout()
        CType(Me.dgvBufDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatos.ResumeLayout(False)
        Me.gbxDatos.PerformLayout()
        CType(Me.dgvCtaCte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
    Friend WithEvents lblFuncion As System.Windows.Forms.Label
    Friend WithEvents lblIdUs As System.Windows.Forms.Label
    Friend WithEvents lblFunValor As System.Windows.Forms.Label
    Friend WithEvents lblidDetCaja As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLibrador As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelarValor As System.Windows.Forms.Button
    Friend WithEvents cbxTipoValor As System.Windows.Forms.ComboBox
    Friend WithEvents dgvCaja As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnModValor As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents gbxDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents btnEliminarValor As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnCargarValor As System.Windows.Forms.Button
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
    Friend WithEvents gbxValores As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dgvBufDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents ElimBuff As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents txtTotVal As System.Windows.Forms.TextBox
    Friend WithEvents tmrHora As System.Windows.Forms.Timer
    Friend WithEvents lblOrigen As System.Windows.Forms.Label
    Friend WithEvents txtCdEmp As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtObserv As System.Windows.Forms.TextBox
    Friend WithEvents txtIdCli As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtHora As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFecAlta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents tmrMensaje As System.Windows.Forms.Timer
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents gbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents cbxTipoMov As System.Windows.Forms.ComboBox
    Friend WithEvents txtImpTexto As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNroRecibo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPtoVta As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dgvCtaCte As System.Windows.Forms.DataGridView
End Class
