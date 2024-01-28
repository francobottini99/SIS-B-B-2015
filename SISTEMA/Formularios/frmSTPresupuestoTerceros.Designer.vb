<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSTPresupuestoTerceros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSTPresupuestoTerceros))
        Me.cbxBuscTEq = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtBuscProblema = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblFuncion = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtBuscCliente = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPresupuesto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDiagnostico = New System.Windows.Forms.TextBox()
        Me.lblIdServTecnico = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCdBarrEq = New System.Windows.Forms.TextBox()
        Me.dgvCliente = New System.Windows.Forms.DataGridView()
        Me.tmrMensaje = New System.Windows.Forms.Timer(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBuscDescripcion = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnTodo = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtBuscCdBarra = New System.Windows.Forms.TextBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gbxDatagrid = New System.Windows.Forms.GroupBox()
        Me.dgvServTecnico = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtCodBarra = New System.Windows.Forms.TextBox()
        Me.cbxTipoEq = New System.Windows.Forms.ComboBox()
        Me.lblOrigen = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCdEmp = New System.Windows.Forms.TextBox()
        Me.txtObaserv = New System.Windows.Forms.TextBox()
        Me.txtNroOrden = New System.Windows.Forms.TextBox()
        Me.txtTE = New System.Windows.Forms.TextBox()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gbxDatos = New System.Windows.Forms.GroupBox()
        Me.lblPresCli = New System.Windows.Forms.Label()
        Me.txtPresClietne = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFecEntrega = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtProblema = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAccesorios = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFecAlta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblIdUs = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvProveedor = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatagrid.SuspendLayout()
        CType(Me.dgvServTecnico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatos.SuspendLayout()
        CType(Me.dgvProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxBuscTEq
        '
        Me.cbxBuscTEq.BackColor = System.Drawing.Color.MediumTurquoise
        Me.cbxBuscTEq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxBuscTEq.ForeColor = System.Drawing.Color.Teal
        Me.cbxBuscTEq.FormattingEnabled = True
        Me.cbxBuscTEq.Items.AddRange(New Object() {"CPU (PC Escritorio)", "Monitor", "Impresora", "Notebook", "NetBook", "Tablet", "Consola de Juego", "Celular", "GPS", "Otros"})
        Me.cbxBuscTEq.Location = New System.Drawing.Point(241, 31)
        Me.cbxBuscTEq.Name = "cbxBuscTEq"
        Me.cbxBuscTEq.Size = New System.Drawing.Size(161, 21)
        Me.cbxBuscTEq.TabIndex = 82
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label17.Location = New System.Drawing.Point(569, 10)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 16)
        Me.Label17.TabIndex = 90
        Me.Label17.Text = "Problema"
        '
        'txtBuscProblema
        '
        Me.txtBuscProblema.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtBuscProblema.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscProblema.ForeColor = System.Drawing.Color.Teal
        Me.txtBuscProblema.Location = New System.Drawing.Point(572, 30)
        Me.txtBuscProblema.Name = "txtBuscProblema"
        Me.txtBuscProblema.Size = New System.Drawing.Size(158, 22)
        Me.txtBuscProblema.TabIndex = 84
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label18.Location = New System.Drawing.Point(405, 11)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 16)
        Me.Label18.TabIndex = 89
        Me.Label18.Text = "Descripción"
        '
        'lblFuncion
        '
        Me.lblFuncion.BackColor = System.Drawing.Color.White
        Me.lblFuncion.Location = New System.Drawing.Point(15, 47)
        Me.lblFuncion.Name = "lblFuncion"
        Me.lblFuncion.Size = New System.Drawing.Size(74, 20)
        Me.lblFuncion.TabIndex = 108
        Me.lblFuncion.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Image = Global.ByB_SI.My.Resources.Resources.OrdenST1
        Me.PictureBox1.Location = New System.Drawing.Point(9, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label15.Location = New System.Drawing.Point(6, 11)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 18)
        Me.Label15.TabIndex = 93
        Me.Label15.Text = "Cliente"
        '
        'txtBuscCliente
        '
        Me.txtBuscCliente.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtBuscCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscCliente.ForeColor = System.Drawing.Color.Teal
        Me.txtBuscCliente.Location = New System.Drawing.Point(9, 31)
        Me.txtBuscCliente.Name = "txtBuscCliente"
        Me.txtBuscCliente.Size = New System.Drawing.Size(65, 22)
        Me.txtBuscCliente.TabIndex = 92
        Me.txtBuscCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.ConsultaIn
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBuscar.Location = New System.Drawing.Point(748, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(43, 43)
        Me.btnBuscar.TabIndex = 91
        Me.btnBuscar.Tag = ""
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label11.Location = New System.Drawing.Point(684, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 16)
        Me.Label11.TabIndex = 107
        Me.Label11.Text = "Nro Orden"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label16.Location = New System.Drawing.Point(442, 315)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(16, 16)
        Me.Label16.TabIndex = 106
        Me.Label16.Text = "$"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label14.Location = New System.Drawing.Point(180, 315)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 16)
        Me.Label14.TabIndex = 105
        Me.Label14.Text = "Presupuesto"
        '
        'txtPresupuesto
        '
        Me.txtPresupuesto.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPresupuesto.ForeColor = System.Drawing.Color.Teal
        Me.txtPresupuesto.Location = New System.Drawing.Point(304, 312)
        Me.txtPresupuesto.Name = "txtPresupuesto"
        Me.txtPresupuesto.Size = New System.Drawing.Size(132, 22)
        Me.txtPresupuesto.TabIndex = 12
        Me.txtPresupuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label8.Location = New System.Drawing.Point(557, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 16)
        Me.Label8.TabIndex = 101
        Me.Label8.Text = "Diagnóstico"
        '
        'txtDiagnostico
        '
        Me.txtDiagnostico.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtDiagnostico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiagnostico.ForeColor = System.Drawing.Color.Teal
        Me.txtDiagnostico.Location = New System.Drawing.Point(557, 150)
        Me.txtDiagnostico.Multiline = True
        Me.txtDiagnostico.Name = "txtDiagnostico"
        Me.txtDiagnostico.Size = New System.Drawing.Size(334, 187)
        Me.txtDiagnostico.TabIndex = 10
        '
        'lblIdServTecnico
        '
        Me.lblIdServTecnico.BackColor = System.Drawing.SystemColors.Control
        Me.lblIdServTecnico.Location = New System.Drawing.Point(14, 17)
        Me.lblIdServTecnico.Name = "lblIdServTecnico"
        Me.lblIdServTecnico.Size = New System.Drawing.Size(119, 19)
        Me.lblIdServTecnico.TabIndex = 99
        Me.lblIdServTecnico.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label3.Location = New System.Drawing.Point(499, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Cd Bar"
        '
        'txtCdBarrEq
        '
        Me.txtCdBarrEq.BackColor = System.Drawing.Color.DarkGray
        Me.txtCdBarrEq.Enabled = False
        Me.txtCdBarrEq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCdBarrEq.ForeColor = System.Drawing.Color.White
        Me.txtCdBarrEq.Location = New System.Drawing.Point(553, 79)
        Me.txtCdBarrEq.Name = "txtCdBarrEq"
        Me.txtCdBarrEq.Size = New System.Drawing.Size(154, 22)
        Me.txtCdBarrEq.TabIndex = 5
        '
        'dgvCliente
        '
        Me.dgvCliente.AllowUserToAddRows = False
        Me.dgvCliente.AllowUserToDeleteRows = False
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCliente.Location = New System.Drawing.Point(15, 51)
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.ReadOnly = True
        Me.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCliente.Size = New System.Drawing.Size(146, 38)
        Me.dgvCliente.TabIndex = 90
        Me.dgvCliente.VirtualMode = True
        '
        'tmrMensaje
        '
        Me.tmrMensaje.Interval = 5000
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label12.Location = New System.Drawing.Point(182, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 18)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "Nro Cta Cliente"
        '
        'txtBuscDescripcion
        '
        Me.txtBuscDescripcion.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtBuscDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscDescripcion.ForeColor = System.Drawing.Color.Teal
        Me.txtBuscDescripcion.Location = New System.Drawing.Point(408, 29)
        Me.txtBuscDescripcion.Name = "txtBuscDescripcion"
        Me.txtBuscDescripcion.Size = New System.Drawing.Size(158, 22)
        Me.txtBuscDescripcion.TabIndex = 83
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label19.Location = New System.Drawing.Point(239, 12)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(93, 16)
        Me.Label19.TabIndex = 88
        Me.Label19.Text = "Tipo Equipo"
        '
        'btnTodo
        '
        Me.btnTodo.BackgroundImage = Global.ByB_SI.My.Resources.Resources.TodosArtIn
        Me.btnTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTodo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTodo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnTodo.Location = New System.Drawing.Point(797, 12)
        Me.btnTodo.Name = "btnTodo"
        Me.btnTodo.Size = New System.Drawing.Size(43, 43)
        Me.btnTodo.TabIndex = 86
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
        Me.btnLimpiar.Location = New System.Drawing.Point(846, 12)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(43, 43)
        Me.btnLimpiar.TabIndex = 85
        Me.btnLimpiar.Tag = ""
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label20.Location = New System.Drawing.Point(79, 12)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(82, 16)
        Me.Label20.TabIndex = 87
        Me.Label20.Text = "Cod. Barra"
        '
        'txtBuscCdBarra
        '
        Me.txtBuscCdBarra.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtBuscCdBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscCdBarra.ForeColor = System.Drawing.Color.Teal
        Me.txtBuscCdBarra.Location = New System.Drawing.Point(80, 31)
        Me.txtBuscCdBarra.Name = "txtBuscCdBarra"
        Me.txtBuscCdBarra.Size = New System.Drawing.Size(155, 22)
        Me.txtBuscCdBarra.TabIndex = 81
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.Color.DarkGray
        Me.txtCliente.Enabled = False
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.ForeColor = System.Drawing.Color.White
        Me.txtCliente.Location = New System.Drawing.Point(375, 47)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(516, 26)
        Me.txtCliente.TabIndex = 3
        '
        'txtIdCliente
        '
        Me.txtIdCliente.BackColor = System.Drawing.Color.DarkGray
        Me.txtIdCliente.Enabled = False
        Me.txtIdCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCliente.ForeColor = System.Drawing.Color.White
        Me.txtIdCliente.Location = New System.Drawing.Point(304, 47)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(65, 26)
        Me.txtIdCliente.TabIndex = 2
        Me.txtIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label13.Location = New System.Drawing.Point(180, 343)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(122, 16)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Obsaervaciones"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label10.Location = New System.Drawing.Point(182, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 16)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Teléfono"
        '
        'gbxDatagrid
        '
        Me.gbxDatagrid.BackColor = System.Drawing.Color.Transparent
        Me.gbxDatagrid.Controls.Add(Me.Label15)
        Me.gbxDatagrid.Controls.Add(Me.txtBuscCliente)
        Me.gbxDatagrid.Controls.Add(Me.btnBuscar)
        Me.gbxDatagrid.Controls.Add(Me.cbxBuscTEq)
        Me.gbxDatagrid.Controls.Add(Me.Label17)
        Me.gbxDatagrid.Controls.Add(Me.txtBuscProblema)
        Me.gbxDatagrid.Controls.Add(Me.Label18)
        Me.gbxDatagrid.Controls.Add(Me.txtBuscDescripcion)
        Me.gbxDatagrid.Controls.Add(Me.Label19)
        Me.gbxDatagrid.Controls.Add(Me.btnTodo)
        Me.gbxDatagrid.Controls.Add(Me.btnLimpiar)
        Me.gbxDatagrid.Controls.Add(Me.Label20)
        Me.gbxDatagrid.Controls.Add(Me.txtBuscCdBarra)
        Me.gbxDatagrid.Controls.Add(Me.dgvServTecnico)
        Me.gbxDatagrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDatagrid.ForeColor = System.Drawing.Color.LawnGreen
        Me.gbxDatagrid.Location = New System.Drawing.Point(12, 379)
        Me.gbxDatagrid.Name = "gbxDatagrid"
        Me.gbxDatagrid.Size = New System.Drawing.Size(903, 220)
        Me.gbxDatagrid.TabIndex = 53
        Me.gbxDatagrid.TabStop = False
        '
        'dgvServTecnico
        '
        Me.dgvServTecnico.AllowUserToAddRows = False
        Me.dgvServTecnico.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.dgvServTecnico.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvServTecnico.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvServTecnico.Location = New System.Drawing.Point(9, 57)
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
        Me.dgvServTecnico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvServTecnico.Size = New System.Drawing.Size(882, 157)
        Me.dgvServTecnico.TabIndex = 18
        '
        'Eliminar
        '
        Me.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Width = 70
        '
        'txtCodBarra
        '
        Me.txtCodBarra.BackColor = System.Drawing.Color.DarkGray
        Me.txtCodBarra.Enabled = False
        Me.txtCodBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodBarra.ForeColor = System.Drawing.Color.White
        Me.txtCodBarra.Location = New System.Drawing.Point(520, 19)
        Me.txtCodBarra.Name = "txtCodBarra"
        Me.txtCodBarra.Size = New System.Drawing.Size(139, 22)
        Me.txtCodBarra.TabIndex = 70
        Me.txtCodBarra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCodBarra.Visible = False
        '
        'cbxTipoEq
        '
        Me.cbxTipoEq.BackColor = System.Drawing.Color.DarkGray
        Me.cbxTipoEq.Enabled = False
        Me.cbxTipoEq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipoEq.ForeColor = System.Drawing.Color.White
        Me.cbxTipoEq.FormattingEnabled = True
        Me.cbxTipoEq.Items.AddRange(New Object() {"CPU (PC Escritorio)", "Monitor", "Impresora", "Notebook", "NetBook", "Tablet", "Consola de Juego", "Celular", "GPS", "Otros"})
        Me.cbxTipoEq.Location = New System.Drawing.Point(759, 81)
        Me.cbxTipoEq.Name = "cbxTipoEq"
        Me.cbxTipoEq.Size = New System.Drawing.Size(132, 21)
        Me.cbxTipoEq.TabIndex = 6
        '
        'lblOrigen
        '
        Me.lblOrigen.BackColor = System.Drawing.SystemColors.Control
        Me.lblOrigen.Location = New System.Drawing.Point(24, 92)
        Me.lblOrigen.Name = "lblOrigen"
        Me.lblOrigen.Size = New System.Drawing.Size(119, 20)
        Me.lblOrigen.TabIndex = 67
        Me.lblOrigen.Text = "Servicio Tecnico"
        Me.lblOrigen.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCdEmp)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.LawnGreen
        Me.GroupBox1.Location = New System.Drawing.Point(6, 190)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 54)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Codigo Empresa"
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
        'txtObaserv
        '
        Me.txtObaserv.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtObaserv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObaserv.ForeColor = System.Drawing.Color.Teal
        Me.txtObaserv.Location = New System.Drawing.Point(304, 340)
        Me.txtObaserv.Name = "txtObaserv"
        Me.txtObaserv.Size = New System.Drawing.Size(587, 22)
        Me.txtObaserv.TabIndex = 13
        '
        'txtNroOrden
        '
        Me.txtNroOrden.BackColor = System.Drawing.Color.DarkGray
        Me.txtNroOrden.Enabled = False
        Me.txtNroOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroOrden.ForeColor = System.Drawing.Color.White
        Me.txtNroOrden.Location = New System.Drawing.Point(773, 19)
        Me.txtNroOrden.Name = "txtNroOrden"
        Me.txtNroOrden.Size = New System.Drawing.Size(118, 22)
        Me.txtNroOrden.TabIndex = 1
        Me.txtNroOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTE
        '
        Me.txtTE.BackColor = System.Drawing.Color.DarkGray
        Me.txtTE.Enabled = False
        Me.txtTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTE.ForeColor = System.Drawing.Color.White
        Me.txtTE.Location = New System.Drawing.Point(304, 79)
        Me.txtTE.Name = "txtTE"
        Me.txtTE.Size = New System.Drawing.Size(192, 22)
        Me.txtTE.TabIndex = 4
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'btnModificar
        '
        Me.btnModificar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.ModifIn
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnModificar.Location = New System.Drawing.Point(921, 24)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(61, 59)
        Me.btnModificar.TabIndex = 48
        Me.btnModificar.Tag = ""
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.Transparent
        Me.lblMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Location = New System.Drawing.Point(921, 220)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(61, 235)
        Me.lblMsg.TabIndex = 54
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.CancelarIn
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCancelar.Location = New System.Drawing.Point(921, 155)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(61, 60)
        Me.btnCancelar.TabIndex = 50
        Me.btnCancelar.Tag = ""
        Me.btnCancelar.UseVisualStyleBackColor = True
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
        Me.btnGuardar.Location = New System.Drawing.Point(921, 89)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(61, 60)
        Me.btnGuardar.TabIndex = 49
        Me.btnGuardar.Tag = ""
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = Global.ByB_SI.My.Resources.Resources.SalirIn
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Location = New System.Drawing.Point(921, 532)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(61, 61)
        Me.btnSalir.TabIndex = 51
        Me.btnSalir.Tag = ""
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'gbxDatos
        '
        Me.gbxDatos.BackColor = System.Drawing.Color.Transparent
        Me.gbxDatos.Controls.Add(Me.txtCdBarrEq)
        Me.gbxDatos.Controls.Add(Me.lblPresCli)
        Me.gbxDatos.Controls.Add(Me.lblOrigen)
        Me.gbxDatos.Controls.Add(Me.txtPresClietne)
        Me.gbxDatos.Controls.Add(Me.PictureBox1)
        Me.gbxDatos.Controls.Add(Me.Label11)
        Me.gbxDatos.Controls.Add(Me.Label16)
        Me.gbxDatos.Controls.Add(Me.Label14)
        Me.gbxDatos.Controls.Add(Me.txtPresupuesto)
        Me.gbxDatos.Controls.Add(Me.Label8)
        Me.gbxDatos.Controls.Add(Me.txtDiagnostico)
        Me.gbxDatos.Controls.Add(Me.Label3)
        Me.gbxDatos.Controls.Add(Me.dgvCliente)
        Me.gbxDatos.Controls.Add(Me.Label12)
        Me.gbxDatos.Controls.Add(Me.txtCliente)
        Me.gbxDatos.Controls.Add(Me.txtIdCliente)
        Me.gbxDatos.Controls.Add(Me.txtCodBarra)
        Me.gbxDatos.Controls.Add(Me.cbxTipoEq)
        Me.gbxDatos.Controls.Add(Me.GroupBox1)
        Me.gbxDatos.Controls.Add(Me.Label13)
        Me.gbxDatos.Controls.Add(Me.txtObaserv)
        Me.gbxDatos.Controls.Add(Me.txtNroOrden)
        Me.gbxDatos.Controls.Add(Me.Label10)
        Me.gbxDatos.Controls.Add(Me.txtTE)
        Me.gbxDatos.Controls.Add(Me.Label9)
        Me.gbxDatos.Controls.Add(Me.txtFecEntrega)
        Me.gbxDatos.Controls.Add(Me.Label7)
        Me.gbxDatos.Controls.Add(Me.txtProblema)
        Me.gbxDatos.Controls.Add(Me.Label6)
        Me.gbxDatos.Controls.Add(Me.txtAccesorios)
        Me.gbxDatos.Controls.Add(Me.Label4)
        Me.gbxDatos.Controls.Add(Me.txtDescripcion)
        Me.gbxDatos.Controls.Add(Me.Label2)
        Me.gbxDatos.Controls.Add(Me.txtFecAlta)
        Me.gbxDatos.Controls.Add(Me.Label5)
        Me.gbxDatos.Controls.Add(Me.lblIdUs)
        Me.gbxDatos.Controls.Add(Me.Label1)
        Me.gbxDatos.Controls.Add(Me.dgvProveedor)
        Me.gbxDatos.Controls.Add(Me.lblIdServTecnico)
        Me.gbxDatos.Controls.Add(Me.lblFuncion)
        Me.gbxDatos.Enabled = False
        Me.gbxDatos.Location = New System.Drawing.Point(12, 12)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.Size = New System.Drawing.Size(903, 368)
        Me.gbxDatos.TabIndex = 52
        Me.gbxDatos.TabStop = False
        '
        'lblPresCli
        '
        Me.lblPresCli.AutoSize = True
        Me.lblPresCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPresCli.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblPresCli.Location = New System.Drawing.Point(3, 257)
        Me.lblPresCli.Name = "lblPresCli"
        Me.lblPresCli.Size = New System.Drawing.Size(147, 16)
        Me.lblPresCli.TabIndex = 110
        Me.lblPresCli.Text = "Presupuesto Cliente"
        Me.lblPresCli.Visible = False
        '
        'txtPresClietne
        '
        Me.txtPresClietne.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtPresClietne.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPresClietne.ForeColor = System.Drawing.Color.Teal
        Me.txtPresClietne.Location = New System.Drawing.Point(6, 276)
        Me.txtPresClietne.Name = "txtPresClietne"
        Me.txtPresClietne.Size = New System.Drawing.Size(146, 22)
        Me.txtPresClietne.TabIndex = 109
        Me.txtPresClietne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPresClietne.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label9.Location = New System.Drawing.Point(180, 287)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 16)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Fecha Est. Ent."
        '
        'txtFecEntrega
        '
        Me.txtFecEntrega.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtFecEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecEntrega.ForeColor = System.Drawing.Color.Teal
        Me.txtFecEntrega.Location = New System.Drawing.Point(304, 284)
        Me.txtFecEntrega.Name = "txtFecEntrega"
        Me.txtFecEntrega.Size = New System.Drawing.Size(132, 22)
        Me.txtFecEntrega.TabIndex = 11
        Me.txtFecEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label7.Location = New System.Drawing.Point(182, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 16)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Problema"
        '
        'txtProblema
        '
        Me.txtProblema.BackColor = System.Drawing.Color.DarkGray
        Me.txtProblema.Enabled = False
        Me.txtProblema.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProblema.ForeColor = System.Drawing.Color.White
        Me.txtProblema.Location = New System.Drawing.Point(304, 136)
        Me.txtProblema.Multiline = True
        Me.txtProblema.Name = "txtProblema"
        Me.txtProblema.Size = New System.Drawing.Size(247, 142)
        Me.txtProblema.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label6.Location = New System.Drawing.Point(625, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 16)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Acc"
        '
        'txtAccesorios
        '
        Me.txtAccesorios.BackColor = System.Drawing.Color.DarkGray
        Me.txtAccesorios.Enabled = False
        Me.txtAccesorios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccesorios.ForeColor = System.Drawing.Color.White
        Me.txtAccesorios.Location = New System.Drawing.Point(665, 107)
        Me.txtAccesorios.Name = "txtAccesorios"
        Me.txtAccesorios.Size = New System.Drawing.Size(226, 22)
        Me.txtAccesorios.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label4.Location = New System.Drawing.Point(182, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Descripción"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.DarkGray
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.White
        Me.txtDescripcion.Location = New System.Drawing.Point(304, 107)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(315, 22)
        Me.txtDescripcion.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label2.Location = New System.Drawing.Point(180, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Fecha"
        '
        'txtFecAlta
        '
        Me.txtFecAlta.BackColor = System.Drawing.Color.DarkGray
        Me.txtFecAlta.Enabled = False
        Me.txtFecAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecAlta.ForeColor = System.Drawing.Color.White
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
        Me.Label5.Location = New System.Drawing.Point(713, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Equip"
        '
        'lblIdUs
        '
        Me.lblIdUs.BackColor = System.Drawing.SystemColors.Control
        Me.lblIdUs.Location = New System.Drawing.Point(25, 137)
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
        Me.Label1.Location = New System.Drawing.Point(24, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Cliente"
        Me.Label1.Visible = False
        '
        'dgvProveedor
        '
        Me.dgvProveedor.AllowUserToAddRows = False
        Me.dgvProveedor.AllowUserToDeleteRows = False
        Me.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProveedor.Location = New System.Drawing.Point(15, 95)
        Me.dgvProveedor.Name = "dgvProveedor"
        Me.dgvProveedor.ReadOnly = True
        Me.dgvProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProveedor.Size = New System.Drawing.Size(146, 42)
        Me.dgvProveedor.TabIndex = 98
        Me.dgvProveedor.VirtualMode = True
        '
        'frmSTPresupuestoTerceros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ByB_SI.My.Resources.Resources.Fondo_23___Reducido
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(989, 602)
        Me.Controls.Add(Me.gbxDatos)
        Me.Controls.Add(Me.gbxDatagrid)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSTPresupuestoTerceros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSTPresupuestoTerceros"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatagrid.ResumeLayout(False)
        Me.gbxDatagrid.PerformLayout()
        CType(Me.dgvServTecnico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatos.ResumeLayout(False)
        Me.gbxDatos.PerformLayout()
        CType(Me.dgvProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbxBuscTEq As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtBuscProblema As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblFuncion As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtBuscCliente As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtPresupuesto As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDiagnostico As System.Windows.Forms.TextBox
    Friend WithEvents lblIdServTecnico As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCdBarrEq As System.Windows.Forms.TextBox
    Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
    Friend WithEvents tmrMensaje As System.Windows.Forms.Timer
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtBuscDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnTodo As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtBuscCdBarra As System.Windows.Forms.TextBox
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtIdCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents gbxDatagrid As System.Windows.Forms.GroupBox
    Friend WithEvents dgvServTecnico As System.Windows.Forms.DataGridView
    Friend WithEvents txtCodBarra As System.Windows.Forms.TextBox
    Friend WithEvents cbxTipoEq As System.Windows.Forms.ComboBox
    Friend WithEvents lblOrigen As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCdEmp As System.Windows.Forms.TextBox
    Friend WithEvents txtObaserv As System.Windows.Forms.TextBox
    Friend WithEvents txtNroOrden As System.Windows.Forms.TextBox
    Friend WithEvents txtTE As System.Windows.Forms.TextBox
    Friend WithEvents errP As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents gbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtFecEntrega As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtProblema As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAccesorios As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFecAlta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblIdUs As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvProveedor As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents lblPresCli As System.Windows.Forms.Label
    Friend WithEvents txtPresClietne As System.Windows.Forms.TextBox
End Class
