<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedores))
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblFuncion = New System.Windows.Forms.Label()
        Me.gbxDatagrid = New System.Windows.Forms.GroupBox()
        Me.dgvProveedores = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCdEmp = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbxClientes = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtContacto = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTEContacto = New System.Windows.Forms.TextBox()
        Me.txtCodBarra = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtIB = New System.Windows.Forms.TextBox()
        Me.txtCodCat = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCuit = New System.Windows.Forms.TextBox()
        Me.cbxCatIva = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblOrigen = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtWeb = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTE = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtProvincia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFecAlta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblIdUs = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.tmrMensaje = New System.Windows.Forms.Timer(Me.components)
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.gbxDatagrid.SuspendLayout()
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbxClientes.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.ForeColor = System.Drawing.Color.Teal
        Me.txtBuscar.Location = New System.Drawing.Point(177, 13)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(720, 22)
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
        Me.gbxDatagrid.Controls.Add(Me.dgvProveedores)
        Me.gbxDatagrid.Controls.Add(Me.Label15)
        Me.gbxDatagrid.Controls.Add(Me.txtBuscar)
        Me.gbxDatagrid.Location = New System.Drawing.Point(12, 390)
        Me.gbxDatagrid.Name = "gbxDatagrid"
        Me.gbxDatagrid.Size = New System.Drawing.Size(903, 203)
        Me.gbxDatagrid.TabIndex = 37
        Me.gbxDatagrid.TabStop = False
        '
        'dgvProveedores
        '
        Me.dgvProveedores.AllowUserToAddRows = False
        Me.dgvProveedores.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvProveedores.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProveedores.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProveedores.Location = New System.Drawing.Point(9, 39)
        Me.dgvProveedores.Name = "dgvProveedores"
        Me.dgvProveedores.ReadOnly = True
        Me.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProveedores.Size = New System.Drawing.Size(888, 158)
        Me.dgvProveedores.TabIndex = 58
        '
        'Eliminar
        '
        Me.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Width = 49
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label15.Location = New System.Drawing.Point(15, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(156, 16)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "Buscar: Razón Social"
        '
        'txtCdEmp
        '
        Me.txtCdEmp.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCdEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCdEmp.ForeColor = System.Drawing.Color.Teal
        Me.txtCdEmp.Location = New System.Drawing.Point(6, 18)
        Me.txtCdEmp.Name = "txtCdEmp"
        Me.txtCdEmp.Size = New System.Drawing.Size(140, 26)
        Me.txtCdEmp.TabIndex = 60
        Me.txtCdEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCdEmp)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.LawnGreen
        Me.GroupBox1.Location = New System.Drawing.Point(9, 195)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 54)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Codigo Empresa"
        '
        'gbxClientes
        '
        Me.gbxClientes.BackColor = System.Drawing.Color.Transparent
        Me.gbxClientes.Controls.Add(Me.GroupBox3)
        Me.gbxClientes.Controls.Add(Me.GroupBox2)
        Me.gbxClientes.Controls.Add(Me.txtCodBarra)
        Me.gbxClientes.Controls.Add(Me.Label18)
        Me.gbxClientes.Controls.Add(Me.Label16)
        Me.gbxClientes.Controls.Add(Me.txtIB)
        Me.gbxClientes.Controls.Add(Me.txtCodCat)
        Me.gbxClientes.Controls.Add(Me.Label11)
        Me.gbxClientes.Controls.Add(Me.txtCuit)
        Me.gbxClientes.Controls.Add(Me.cbxCatIva)
        Me.gbxClientes.Controls.Add(Me.Label3)
        Me.gbxClientes.Controls.Add(Me.lblOrigen)
        Me.gbxClientes.Controls.Add(Me.GroupBox1)
        Me.gbxClientes.Controls.Add(Me.lblFuncion)
        Me.gbxClientes.Controls.Add(Me.Label13)
        Me.gbxClientes.Controls.Add(Me.txtWeb)
        Me.gbxClientes.Controls.Add(Me.Label12)
        Me.gbxClientes.Controls.Add(Me.txtMail)
        Me.gbxClientes.Controls.Add(Me.Label10)
        Me.gbxClientes.Controls.Add(Me.txtTE)
        Me.gbxClientes.Controls.Add(Me.Label9)
        Me.gbxClientes.Controls.Add(Me.txtPais)
        Me.gbxClientes.Controls.Add(Me.Label8)
        Me.gbxClientes.Controls.Add(Me.txtProvincia)
        Me.gbxClientes.Controls.Add(Me.Label7)
        Me.gbxClientes.Controls.Add(Me.txtCP)
        Me.gbxClientes.Controls.Add(Me.Label6)
        Me.gbxClientes.Controls.Add(Me.txtLocalidad)
        Me.gbxClientes.Controls.Add(Me.Label4)
        Me.gbxClientes.Controls.Add(Me.txtDireccion)
        Me.gbxClientes.Controls.Add(Me.Label2)
        Me.gbxClientes.Controls.Add(Me.txtFecAlta)
        Me.gbxClientes.Controls.Add(Me.Label5)
        Me.gbxClientes.Controls.Add(Me.lblIdUs)
        Me.gbxClientes.Controls.Add(Me.Label1)
        Me.gbxClientes.Controls.Add(Me.PictureBox1)
        Me.gbxClientes.Controls.Add(Me.txtNombre)
        Me.gbxClientes.Enabled = False
        Me.gbxClientes.Location = New System.Drawing.Point(12, 1)
        Me.gbxClientes.Name = "gbxClientes"
        Me.gbxClientes.Size = New System.Drawing.Size(903, 390)
        Me.gbxClientes.TabIndex = 36
        Me.gbxClientes.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtContacto)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox3.Location = New System.Drawing.Point(738, 263)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(153, 60)
        Me.GroupBox3.TabIndex = 77
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contacto"
        '
        'txtContacto
        '
        Me.txtContacto.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContacto.ForeColor = System.Drawing.Color.Teal
        Me.txtContacto.Location = New System.Drawing.Point(6, 25)
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Size = New System.Drawing.Size(141, 22)
        Me.txtContacto.TabIndex = 62
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTEContacto)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox2.Location = New System.Drawing.Point(738, 329)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(153, 57)
        Me.GroupBox2.TabIndex = 76
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TE Contacto"
        '
        'txtTEContacto
        '
        Me.txtTEContacto.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtTEContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTEContacto.ForeColor = System.Drawing.Color.Teal
        Me.txtTEContacto.Location = New System.Drawing.Point(6, 21)
        Me.txtTEContacto.Name = "txtTEContacto"
        Me.txtTEContacto.Size = New System.Drawing.Size(141, 22)
        Me.txtTEContacto.TabIndex = 64
        '
        'txtCodBarra
        '
        Me.txtCodBarra.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCodBarra.Enabled = False
        Me.txtCodBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodBarra.ForeColor = System.Drawing.Color.Teal
        Me.txtCodBarra.Location = New System.Drawing.Point(449, 19)
        Me.txtCodBarra.Name = "txtCodBarra"
        Me.txtCodBarra.Size = New System.Drawing.Size(132, 22)
        Me.txtCodBarra.TabIndex = 75
        Me.txtCodBarra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCodBarra.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label18.Location = New System.Drawing.Point(446, 279)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(269, 16)
        Me.Label18.TabIndex = 74
        Me.Label18.Text = "Ingrese sólo los números sin guiones."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label16.Location = New System.Drawing.Point(180, 307)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 16)
        Me.Label16.TabIndex = 73
        Me.Label16.Text = "II. BB."
        '
        'txtIB
        '
        Me.txtIB.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtIB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIB.ForeColor = System.Drawing.Color.Teal
        Me.txtIB.Location = New System.Drawing.Point(304, 304)
        Me.txtIB.Name = "txtIB"
        Me.txtIB.Size = New System.Drawing.Size(132, 22)
        Me.txtIB.TabIndex = 11
        Me.txtIB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCodCat
        '
        Me.txtCodCat.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCodCat.Enabled = False
        Me.txtCodCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCat.ForeColor = System.Drawing.Color.Teal
        Me.txtCodCat.Location = New System.Drawing.Point(304, 248)
        Me.txtCodCat.Name = "txtCodCat"
        Me.txtCodCat.Size = New System.Drawing.Size(72, 22)
        Me.txtCodCat.TabIndex = 8
        Me.txtCodCat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label11.Location = New System.Drawing.Point(180, 279)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 16)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "CUIT"
        '
        'txtCuit
        '
        Me.txtCuit.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuit.ForeColor = System.Drawing.Color.Teal
        Me.txtCuit.Location = New System.Drawing.Point(304, 276)
        Me.txtCuit.MaxLength = 13
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.Size = New System.Drawing.Size(132, 22)
        Me.txtCuit.TabIndex = 10
        Me.txtCuit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxCatIva
        '
        Me.cbxCatIva.BackColor = System.Drawing.Color.MediumTurquoise
        Me.cbxCatIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCatIva.ForeColor = System.Drawing.Color.Teal
        Me.cbxCatIva.FormattingEnabled = True
        Me.cbxCatIva.Items.AddRange(New Object() {"IVA Responsable Inscripto", "IVA Responsable No Inscripto", "IVA No Responsable", "IVA Sujeto Exento", "Consumidor Final", "Responsable Monotributo", "Sujeto No Categorizado", "Proveedor del Exterior", "Cliente del Exterior", "IVA Liberado – Ley Nº 19.640", "IVA Responsable Inscripto – Agente de Percepción", "Pequeño Contribuyente Eventual", "Monotributista Social", "Pequeño Contribuyente Eventual Social"})
        Me.cbxCatIva.Location = New System.Drawing.Point(382, 247)
        Me.cbxCatIva.Name = "cbxCatIva"
        Me.cbxCatIva.Size = New System.Drawing.Size(317, 24)
        Me.cbxCatIva.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label3.Location = New System.Drawing.Point(180, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Categoría IVA"
        '
        'lblOrigen
        '
        Me.lblOrigen.BackColor = System.Drawing.SystemColors.Control
        Me.lblOrigen.Location = New System.Drawing.Point(12, 253)
        Me.lblOrigen.Name = "lblOrigen"
        Me.lblOrigen.Size = New System.Drawing.Size(74, 20)
        Me.lblOrigen.TabIndex = 66
        Me.lblOrigen.Text = "Proveedor"
        Me.lblOrigen.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label13.Location = New System.Drawing.Point(180, 363)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 16)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Web"
        '
        'txtWeb
        '
        Me.txtWeb.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtWeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeb.ForeColor = System.Drawing.Color.Teal
        Me.txtWeb.Location = New System.Drawing.Point(304, 360)
        Me.txtWeb.Name = "txtWeb"
        Me.txtWeb.Size = New System.Drawing.Size(395, 22)
        Me.txtWeb.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label12.Location = New System.Drawing.Point(180, 335)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 16)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Mail"
        '
        'txtMail
        '
        Me.txtMail.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.ForeColor = System.Drawing.Color.Teal
        Me.txtMail.Location = New System.Drawing.Point(304, 332)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(395, 22)
        Me.txtMail.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label10.Location = New System.Drawing.Point(180, 223)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 16)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Teléfono"
        '
        'txtTE
        '
        Me.txtTE.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTE.ForeColor = System.Drawing.Color.Teal
        Me.txtTE.Location = New System.Drawing.Point(304, 220)
        Me.txtTE.Name = "txtTE"
        Me.txtTE.Size = New System.Drawing.Size(395, 22)
        Me.txtTE.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label9.Location = New System.Drawing.Point(180, 195)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 16)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "País"
        '
        'txtPais
        '
        Me.txtPais.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPais.ForeColor = System.Drawing.Color.Teal
        Me.txtPais.Location = New System.Drawing.Point(304, 192)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(395, 22)
        Me.txtPais.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label8.Location = New System.Drawing.Point(180, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 16)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Provincia"
        '
        'txtProvincia
        '
        Me.txtProvincia.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvincia.ForeColor = System.Drawing.Color.Teal
        Me.txtProvincia.Location = New System.Drawing.Point(304, 164)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(395, 22)
        Me.txtProvincia.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label7.Location = New System.Drawing.Point(180, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 16)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Código Postal"
        '
        'txtCP
        '
        Me.txtCP.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCP.ForeColor = System.Drawing.Color.Teal
        Me.txtCP.Location = New System.Drawing.Point(304, 135)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(132, 22)
        Me.txtCP.TabIndex = 4
        Me.txtCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label6.Location = New System.Drawing.Point(180, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 16)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Localidad"
        '
        'txtLocalidad
        '
        Me.txtLocalidad.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalidad.ForeColor = System.Drawing.Color.Teal
        Me.txtLocalidad.Location = New System.Drawing.Point(304, 107)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(395, 22)
        Me.txtLocalidad.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label4.Location = New System.Drawing.Point(180, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Dirección"
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ForeColor = System.Drawing.Color.Teal
        Me.txtDireccion.Location = New System.Drawing.Point(304, 79)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(395, 22)
        Me.txtDireccion.TabIndex = 2
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
        Me.txtFecAlta.Location = New System.Drawing.Point(304, 19)
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
        Me.Label5.Location = New System.Drawing.Point(180, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Razón Social"
        '
        'lblIdUs
        '
        Me.lblIdUs.BackColor = System.Drawing.SystemColors.Control
        Me.lblIdUs.Location = New System.Drawing.Point(94, 13)
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
        Me.Label1.Location = New System.Drawing.Point(15, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Cliente"
        Me.Label1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Image = Global.ByB_SI.My.Resources.Resources.Proveedores
        Me.PictureBox1.Location = New System.Drawing.Point(9, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtNombre.Location = New System.Drawing.Point(304, 47)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(587, 26)
        Me.txtNombre.TabIndex = 1
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.EliminarIn
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.Location = New System.Drawing.Point(921, 450)
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
        Me.btnNuevo.Location = New System.Drawing.Point(921, 28)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(61, 59)
        Me.btnNuevo.TabIndex = 30
        Me.btnNuevo.Tag = ""
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = Global.ByB_SI.My.Resources.Resources.SalirIn
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Location = New System.Drawing.Point(921, 526)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(61, 61)
        Me.btnSalir.TabIndex = 35
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
        Me.btnGuardar.Location = New System.Drawing.Point(921, 159)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(61, 60)
        Me.btnGuardar.TabIndex = 32
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
        Me.btnCancelar.Location = New System.Drawing.Point(921, 225)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(61, 60)
        Me.btnCancelar.TabIndex = 33
        Me.btnCancelar.Tag = ""
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'tmrMensaje
        '
        Me.tmrMensaje.Interval = 5000
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.Transparent
        Me.lblMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Location = New System.Drawing.Point(921, 291)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(61, 140)
        Me.lblMsg.TabIndex = 38
        '
        'btnModificar
        '
        Me.btnModificar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.ModifIn
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnModificar.Location = New System.Drawing.Point(921, 94)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(61, 59)
        Me.btnModificar.TabIndex = 31
        Me.btnModificar.Tag = ""
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'frmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ByB_SI.My.Resources.Resources.Fondo_23___Reducido
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(995, 601)
        Me.Controls.Add(Me.gbxDatagrid)
        Me.Controls.Add(Me.gbxClientes)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.btnModificar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProveedores"
        Me.gbxDatagrid.ResumeLayout(False)
        Me.gbxDatagrid.PerformLayout()
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbxClientes.ResumeLayout(False)
        Me.gbxClientes.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents lblFuncion As System.Windows.Forms.Label
    Friend WithEvents gbxDatagrid As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCdEmp As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbxClientes As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtWeb As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTE As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPais As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtProvincia As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFecAlta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblIdUs As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents tmrMensaje As System.Windows.Forms.Timer
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents txtTEContacto As System.Windows.Forms.TextBox
    Friend WithEvents txtContacto As System.Windows.Forms.TextBox
    Friend WithEvents dgvProveedores As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents lblOrigen As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtIB As System.Windows.Forms.TextBox
    Friend WithEvents txtCodCat As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCuit As System.Windows.Forms.TextBox
    Friend WithEvents cbxCatIva As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodBarra As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
