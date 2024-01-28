<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSTGarantiayOtros
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSTGarantiayOtros))
        Me.txtDiagnostico = New System.Windows.Forms.TextBox()
        Me.txtCdBarrEq = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtPresupuesto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblFuncion = New System.Windows.Forms.Label()
        Me.lblIdServTecnico = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbxDatagrid = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtBuscCliente = New System.Windows.Forms.TextBox()
        Me.cbxBuscTEq = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtBuscProblema = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtBuscDescripcion = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtBuscCdBarra = New System.Windows.Forms.TextBox()
        Me.btnTodo = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.dgvServTecnico = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dgvCliente = New System.Windows.Forms.DataGridView()
        Me.tmrMensaje = New System.Windows.Forms.Timer(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.txtCodBarra = New System.Windows.Forms.TextBox()
        Me.cbxTipoEq = New System.Windows.Forms.ComboBox()
        Me.lblOrigen = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCdEmp = New System.Windows.Forms.TextBox()
        Me.txtObaserv = New System.Windows.Forms.TextBox()
        Me.txtNroOrden = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gbxDatos = New System.Windows.Forms.GroupBox()
        Me.txtAccesorios = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtPresupProv = New System.Windows.Forms.TextBox()
        Me.chbEntregado = New System.Windows.Forms.CheckBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtVtoGar = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtGarantia = New System.Windows.Forms.TextBox()
        Me.txtTE = New System.Windows.Forms.TextBox()
        Me.txtFecEntrega = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtProblema = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFecAlta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblIdUs = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvProveedor = New System.Windows.Forms.DataGridView()
        Me.dgvResumen = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatagrid.SuspendLayout()
        CType(Me.dgvServTecnico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbxDatos.SuspendLayout()
        CType(Me.dgvProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDiagnostico
        '
        Me.txtDiagnostico.BackColor = System.Drawing.Color.DarkGray
        Me.txtDiagnostico.Enabled = False
        Me.txtDiagnostico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiagnostico.ForeColor = System.Drawing.Color.Teal
        Me.txtDiagnostico.Location = New System.Drawing.Point(520, 141)
        Me.txtDiagnostico.Multiline = True
        Me.txtDiagnostico.Name = "txtDiagnostico"
        Me.txtDiagnostico.Size = New System.Drawing.Size(371, 201)
        Me.txtDiagnostico.TabIndex = 10
        '
        'txtCdBarrEq
        '
        Me.txtCdBarrEq.BackColor = System.Drawing.Color.DarkGray
        Me.txtCdBarrEq.Enabled = False
        Me.txtCdBarrEq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCdBarrEq.ForeColor = System.Drawing.Color.White
        Me.txtCdBarrEq.Location = New System.Drawing.Point(525, 68)
        Me.txtCdBarrEq.Name = "txtCdBarrEq"
        Me.txtCdBarrEq.Size = New System.Drawing.Size(158, 22)
        Me.txtCdBarrEq.TabIndex = 5
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.ConsultaIn
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBuscar.Location = New System.Drawing.Point(750, 7)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(43, 43)
        Me.btnBuscar.TabIndex = 67
        Me.btnBuscar.Tag = ""
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtPresupuesto
        '
        Me.txtPresupuesto.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPresupuesto.ForeColor = System.Drawing.Color.Teal
        Me.txtPresupuesto.Location = New System.Drawing.Point(304, 262)
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
        Me.Label8.Location = New System.Drawing.Point(522, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 16)
        Me.Label8.TabIndex = 101
        Me.Label8.Text = "Diagnóstico"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label16.Location = New System.Drawing.Point(442, 265)
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
        Me.Label14.Location = New System.Drawing.Point(180, 265)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 16)
        Me.Label14.TabIndex = 105
        Me.Label14.Text = "Presupuesto"
        '
        'lblFuncion
        '
        Me.lblFuncion.BackColor = System.Drawing.Color.White
        Me.lblFuncion.Location = New System.Drawing.Point(14, 299)
        Me.lblFuncion.Name = "lblFuncion"
        Me.lblFuncion.Size = New System.Drawing.Size(74, 20)
        Me.lblFuncion.TabIndex = 108
        Me.lblFuncion.Visible = False
        '
        'lblIdServTecnico
        '
        Me.lblIdServTecnico.BackColor = System.Drawing.SystemColors.Control
        Me.lblIdServTecnico.Location = New System.Drawing.Point(12, 270)
        Me.lblIdServTecnico.Name = "lblIdServTecnico"
        Me.lblIdServTecnico.Size = New System.Drawing.Size(119, 19)
        Me.lblIdServTecnico.TabIndex = 99
        Me.lblIdServTecnico.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Image = Global.ByB_SI.My.Resources.Resources.Stock1
        Me.PictureBox1.Location = New System.Drawing.Point(9, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label3.Location = New System.Drawing.Point(464, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Cd Bar"
        '
        'gbxDatagrid
        '
        Me.gbxDatagrid.BackColor = System.Drawing.Color.Transparent
        Me.gbxDatagrid.Controls.Add(Me.Label15)
        Me.gbxDatagrid.Controls.Add(Me.txtBuscCliente)
        Me.gbxDatagrid.Controls.Add(Me.cbxBuscTEq)
        Me.gbxDatagrid.Controls.Add(Me.Label17)
        Me.gbxDatagrid.Controls.Add(Me.txtBuscProblema)
        Me.gbxDatagrid.Controls.Add(Me.Label18)
        Me.gbxDatagrid.Controls.Add(Me.txtBuscDescripcion)
        Me.gbxDatagrid.Controls.Add(Me.Label19)
        Me.gbxDatagrid.Controls.Add(Me.Label22)
        Me.gbxDatagrid.Controls.Add(Me.txtBuscCdBarra)
        Me.gbxDatagrid.Controls.Add(Me.btnBuscar)
        Me.gbxDatagrid.Controls.Add(Me.btnTodo)
        Me.gbxDatagrid.Controls.Add(Me.btnLimpiar)
        Me.gbxDatagrid.Controls.Add(Me.dgvServTecnico)
        Me.gbxDatagrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDatagrid.ForeColor = System.Drawing.Color.LawnGreen
        Me.gbxDatagrid.Location = New System.Drawing.Point(12, 373)
        Me.gbxDatagrid.Name = "gbxDatagrid"
        Me.gbxDatagrid.Size = New System.Drawing.Size(903, 219)
        Me.gbxDatagrid.TabIndex = 53
        Me.gbxDatagrid.TabStop = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label15.Location = New System.Drawing.Point(6, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 18)
        Me.Label15.TabIndex = 103
        Me.Label15.Text = "Cliente"
        '
        'txtBuscCliente
        '
        Me.txtBuscCliente.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtBuscCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscCliente.ForeColor = System.Drawing.Color.Teal
        Me.txtBuscCliente.Location = New System.Drawing.Point(9, 27)
        Me.txtBuscCliente.Name = "txtBuscCliente"
        Me.txtBuscCliente.Size = New System.Drawing.Size(65, 22)
        Me.txtBuscCliente.TabIndex = 102
        Me.txtBuscCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbxBuscTEq
        '
        Me.cbxBuscTEq.BackColor = System.Drawing.Color.MediumTurquoise
        Me.cbxBuscTEq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxBuscTEq.ForeColor = System.Drawing.Color.Teal
        Me.cbxBuscTEq.FormattingEnabled = True
        Me.cbxBuscTEq.Items.AddRange(New Object() {"CPU (PC Escritorio)", "Monitor", "Impresora", "Notebook", "NetBook", "Tablet", "Consola de Juego", "Celular", "GPS", "Otros"})
        Me.cbxBuscTEq.Location = New System.Drawing.Point(241, 27)
        Me.cbxBuscTEq.Name = "cbxBuscTEq"
        Me.cbxBuscTEq.Size = New System.Drawing.Size(161, 21)
        Me.cbxBuscTEq.TabIndex = 95
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label17.Location = New System.Drawing.Point(569, 6)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 16)
        Me.Label17.TabIndex = 101
        Me.Label17.Text = "Problema"
        '
        'txtBuscProblema
        '
        Me.txtBuscProblema.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtBuscProblema.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscProblema.ForeColor = System.Drawing.Color.Teal
        Me.txtBuscProblema.Location = New System.Drawing.Point(572, 26)
        Me.txtBuscProblema.Name = "txtBuscProblema"
        Me.txtBuscProblema.Size = New System.Drawing.Size(158, 22)
        Me.txtBuscProblema.TabIndex = 97
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label18.Location = New System.Drawing.Point(405, 7)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 16)
        Me.Label18.TabIndex = 100
        Me.Label18.Text = "Descripción"
        '
        'txtBuscDescripcion
        '
        Me.txtBuscDescripcion.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtBuscDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscDescripcion.ForeColor = System.Drawing.Color.Teal
        Me.txtBuscDescripcion.Location = New System.Drawing.Point(408, 25)
        Me.txtBuscDescripcion.Name = "txtBuscDescripcion"
        Me.txtBuscDescripcion.Size = New System.Drawing.Size(158, 22)
        Me.txtBuscDescripcion.TabIndex = 96
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label19.Location = New System.Drawing.Point(239, 8)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(93, 16)
        Me.Label19.TabIndex = 99
        Me.Label19.Text = "Tipo Equipo"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label22.Location = New System.Drawing.Point(79, 8)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(82, 16)
        Me.Label22.TabIndex = 98
        Me.Label22.Text = "Cod. Barra"
        '
        'txtBuscCdBarra
        '
        Me.txtBuscCdBarra.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtBuscCdBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscCdBarra.ForeColor = System.Drawing.Color.Teal
        Me.txtBuscCdBarra.Location = New System.Drawing.Point(80, 27)
        Me.txtBuscCdBarra.Name = "txtBuscCdBarra"
        Me.txtBuscCdBarra.Size = New System.Drawing.Size(155, 22)
        Me.txtBuscCdBarra.TabIndex = 94
        '
        'btnTodo
        '
        Me.btnTodo.BackgroundImage = Global.ByB_SI.My.Resources.Resources.TodosArtIn
        Me.btnTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTodo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTodo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnTodo.Location = New System.Drawing.Point(799, 7)
        Me.btnTodo.Name = "btnTodo"
        Me.btnTodo.Size = New System.Drawing.Size(43, 43)
        Me.btnTodo.TabIndex = 22
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
        Me.btnLimpiar.Location = New System.Drawing.Point(848, 7)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(43, 43)
        Me.btnLimpiar.TabIndex = 21
        Me.btnLimpiar.Tag = ""
        Me.btnLimpiar.UseVisualStyleBackColor = True
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
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvServTecnico.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvServTecnico.Location = New System.Drawing.Point(9, 56)
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
        Me.dgvServTecnico.Size = New System.Drawing.Size(882, 153)
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label11.Location = New System.Drawing.Point(684, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 16)
        Me.Label11.TabIndex = 107
        Me.Label11.Text = "Nro Orden"
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'dgvCliente
        '
        Me.dgvCliente.AllowUserToAddRows = False
        Me.dgvCliente.AllowUserToDeleteRows = False
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCliente.Location = New System.Drawing.Point(15, 40)
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.ReadOnly = True
        Me.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCliente.Size = New System.Drawing.Size(146, 53)
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
        Me.Label12.Location = New System.Drawing.Point(182, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 18)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "Nro Cta Cliente"
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.Color.DarkGray
        Me.txtCliente.Enabled = False
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.ForeColor = System.Drawing.Color.White
        Me.txtCliente.Location = New System.Drawing.Point(375, 36)
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
        Me.txtIdCliente.Location = New System.Drawing.Point(304, 36)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(65, 26)
        Me.txtIdCliente.TabIndex = 2
        Me.txtIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCodBarra
        '
        Me.txtCodBarra.BackColor = System.Drawing.Color.DarkGray
        Me.txtCodBarra.Enabled = False
        Me.txtCodBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodBarra.ForeColor = System.Drawing.Color.White
        Me.txtCodBarra.Location = New System.Drawing.Point(520, 8)
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
        Me.cbxTipoEq.Location = New System.Drawing.Point(734, 69)
        Me.cbxTipoEq.Name = "cbxTipoEq"
        Me.cbxTipoEq.Size = New System.Drawing.Size(157, 21)
        Me.cbxTipoEq.TabIndex = 6
        '
        'lblOrigen
        '
        Me.lblOrigen.BackColor = System.Drawing.SystemColors.Control
        Me.lblOrigen.Location = New System.Drawing.Point(12, 242)
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
        Me.GroupBox1.Location = New System.Drawing.Point(9, 182)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 54)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Codigo Empresa"
        Me.GroupBox1.Visible = False
        '
        'txtCdEmp
        '
        Me.txtCdEmp.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCdEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCdEmp.ForeColor = System.Drawing.Color.Teal
        Me.txtCdEmp.Location = New System.Drawing.Point(6, 7)
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
        Me.txtObaserv.Location = New System.Drawing.Point(304, 346)
        Me.txtObaserv.Name = "txtObaserv"
        Me.txtObaserv.Size = New System.Drawing.Size(483, 22)
        Me.txtObaserv.TabIndex = 13
        '
        'txtNroOrden
        '
        Me.txtNroOrden.BackColor = System.Drawing.Color.DarkGray
        Me.txtNroOrden.Enabled = False
        Me.txtNroOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroOrden.ForeColor = System.Drawing.Color.White
        Me.txtNroOrden.Location = New System.Drawing.Point(773, 8)
        Me.txtNroOrden.Name = "txtNroOrden"
        Me.txtNroOrden.Size = New System.Drawing.Size(118, 22)
        Me.txtNroOrden.TabIndex = 1
        Me.txtNroOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label13.Location = New System.Drawing.Point(180, 349)
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
        Me.Label10.Location = New System.Drawing.Point(182, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 16)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Teléfono"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label9.Location = New System.Drawing.Point(180, 237)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 16)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Fecha Entrega"
        '
        'btnModificar
        '
        Me.btnModificar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.ModifIn
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnModificar.Location = New System.Drawing.Point(921, 13)
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
        Me.lblMsg.Location = New System.Drawing.Point(921, 210)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(61, 253)
        Me.lblMsg.TabIndex = 54
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label6.Location = New System.Drawing.Point(597, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 16)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Accesorios"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.CancelarIn
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCancelar.Location = New System.Drawing.Point(921, 144)
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
        Me.btnGuardar.Location = New System.Drawing.Point(921, 78)
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
        Me.btnSalir.Location = New System.Drawing.Point(921, 521)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(61, 61)
        Me.btnSalir.TabIndex = 51
        Me.btnSalir.Tag = ""
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'gbxDatos
        '
        Me.gbxDatos.BackColor = System.Drawing.Color.Transparent
        Me.gbxDatos.Controls.Add(Me.txtAccesorios)
        Me.gbxDatos.Controls.Add(Me.Label24)
        Me.gbxDatos.Controls.Add(Me.txtPresupProv)
        Me.gbxDatos.Controls.Add(Me.chbEntregado)
        Me.gbxDatos.Controls.Add(Me.Label23)
        Me.gbxDatos.Controls.Add(Me.txtVtoGar)
        Me.gbxDatos.Controls.Add(Me.Label20)
        Me.gbxDatos.Controls.Add(Me.Label21)
        Me.gbxDatos.Controls.Add(Me.txtGarantia)
        Me.gbxDatos.Controls.Add(Me.lblFuncion)
        Me.gbxDatos.Controls.Add(Me.Label11)
        Me.gbxDatos.Controls.Add(Me.Label16)
        Me.gbxDatos.Controls.Add(Me.Label14)
        Me.gbxDatos.Controls.Add(Me.txtPresupuesto)
        Me.gbxDatos.Controls.Add(Me.Label8)
        Me.gbxDatos.Controls.Add(Me.txtDiagnostico)
        Me.gbxDatos.Controls.Add(Me.lblIdServTecnico)
        Me.gbxDatos.Controls.Add(Me.PictureBox1)
        Me.gbxDatos.Controls.Add(Me.Label3)
        Me.gbxDatos.Controls.Add(Me.txtCdBarrEq)
        Me.gbxDatos.Controls.Add(Me.dgvCliente)
        Me.gbxDatos.Controls.Add(Me.Label12)
        Me.gbxDatos.Controls.Add(Me.txtCliente)
        Me.gbxDatos.Controls.Add(Me.txtIdCliente)
        Me.gbxDatos.Controls.Add(Me.txtCodBarra)
        Me.gbxDatos.Controls.Add(Me.cbxTipoEq)
        Me.gbxDatos.Controls.Add(Me.lblOrigen)
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
        Me.gbxDatos.Controls.Add(Me.Label4)
        Me.gbxDatos.Controls.Add(Me.txtDescripcion)
        Me.gbxDatos.Controls.Add(Me.Label2)
        Me.gbxDatos.Controls.Add(Me.txtFecAlta)
        Me.gbxDatos.Controls.Add(Me.Label5)
        Me.gbxDatos.Controls.Add(Me.lblIdUs)
        Me.gbxDatos.Controls.Add(Me.Label1)
        Me.gbxDatos.Controls.Add(Me.dgvProveedor)
        Me.gbxDatos.Controls.Add(Me.dgvResumen)
        Me.gbxDatos.Enabled = False
        Me.gbxDatos.Location = New System.Drawing.Point(12, 1)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.Size = New System.Drawing.Size(903, 373)
        Me.gbxDatos.TabIndex = 52
        Me.gbxDatos.TabStop = False
        '
        'txtAccesorios
        '
        Me.txtAccesorios.BackColor = System.Drawing.Color.DarkGray
        Me.txtAccesorios.Enabled = False
        Me.txtAccesorios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccesorios.ForeColor = System.Drawing.Color.White
        Me.txtAccesorios.Location = New System.Drawing.Point(681, 99)
        Me.txtAccesorios.Name = "txtAccesorios"
        Me.txtAccesorios.Size = New System.Drawing.Size(211, 22)
        Me.txtAccesorios.TabIndex = 8
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label24.Location = New System.Drawing.Point(180, 207)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(97, 16)
        Me.Label24.TabIndex = 116
        Me.Label24.Text = "Presup. Prov"
        '
        'txtPresupProv
        '
        Me.txtPresupProv.BackColor = System.Drawing.Color.DarkGray
        Me.txtPresupProv.Enabled = False
        Me.txtPresupProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPresupProv.ForeColor = System.Drawing.Color.White
        Me.txtPresupProv.Location = New System.Drawing.Point(304, 206)
        Me.txtPresupProv.Multiline = True
        Me.txtPresupProv.Name = "txtPresupProv"
        Me.txtPresupProv.Size = New System.Drawing.Size(132, 22)
        Me.txtPresupProv.TabIndex = 115
        Me.txtPresupProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chbEntregado
        '
        Me.chbEntregado.AutoSize = True
        Me.chbEntregado.Checked = True
        Me.chbEntregado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbEntregado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbEntregado.ForeColor = System.Drawing.Color.LawnGreen
        Me.chbEntregado.Location = New System.Drawing.Point(793, 348)
        Me.chbEntregado.Name = "chbEntregado"
        Me.chbEntregado.Size = New System.Drawing.Size(99, 20)
        Me.chbEntregado.TabIndex = 114
        Me.chbEntregado.Text = "Entregado"
        Me.chbEntregado.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label23.Location = New System.Drawing.Point(180, 321)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(110, 16)
        Me.Label23.TabIndex = 113
        Me.Label23.Text = "Venc. Garantía"
        '
        'txtVtoGar
        '
        Me.txtVtoGar.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtVtoGar.Enabled = False
        Me.txtVtoGar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVtoGar.ForeColor = System.Drawing.Color.Teal
        Me.txtVtoGar.Location = New System.Drawing.Point(304, 318)
        Me.txtVtoGar.Name = "txtVtoGar"
        Me.txtVtoGar.Size = New System.Drawing.Size(132, 22)
        Me.txtVtoGar.TabIndex = 112
        Me.txtVtoGar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label20.Location = New System.Drawing.Point(442, 293)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(54, 16)
        Me.Label20.TabIndex = 111
        Me.Label20.Text = "Meses"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label21.Location = New System.Drawing.Point(180, 293)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 16)
        Me.Label21.TabIndex = 110
        Me.Label21.Text = "Garantía"
        '
        'txtGarantia
        '
        Me.txtGarantia.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtGarantia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGarantia.ForeColor = System.Drawing.Color.Teal
        Me.txtGarantia.Location = New System.Drawing.Point(304, 290)
        Me.txtGarantia.Name = "txtGarantia"
        Me.txtGarantia.Size = New System.Drawing.Size(132, 22)
        Me.txtGarantia.TabIndex = 109
        Me.txtGarantia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTE
        '
        Me.txtTE.BackColor = System.Drawing.Color.DarkGray
        Me.txtTE.Enabled = False
        Me.txtTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTE.ForeColor = System.Drawing.Color.White
        Me.txtTE.Location = New System.Drawing.Point(304, 68)
        Me.txtTE.Name = "txtTE"
        Me.txtTE.Size = New System.Drawing.Size(154, 22)
        Me.txtTE.TabIndex = 4
        '
        'txtFecEntrega
        '
        Me.txtFecEntrega.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtFecEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecEntrega.ForeColor = System.Drawing.Color.Teal
        Me.txtFecEntrega.Location = New System.Drawing.Point(304, 234)
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
        Me.Label7.Location = New System.Drawing.Point(182, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 16)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Problema"
        '
        'txtProblema
        '
        Me.txtProblema.BackColor = System.Drawing.Color.DarkGray
        Me.txtProblema.Enabled = False
        Me.txtProblema.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProblema.ForeColor = System.Drawing.Color.White
        Me.txtProblema.Location = New System.Drawing.Point(304, 127)
        Me.txtProblema.Multiline = True
        Me.txtProblema.Name = "txtProblema"
        Me.txtProblema.Size = New System.Drawing.Size(211, 73)
        Me.txtProblema.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label4.Location = New System.Drawing.Point(182, 102)
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
        Me.txtDescripcion.Location = New System.Drawing.Point(304, 99)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(287, 22)
        Me.txtDescripcion.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label2.Location = New System.Drawing.Point(180, 11)
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
        Me.txtFecAlta.Location = New System.Drawing.Point(304, 8)
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
        Me.Label5.Location = New System.Drawing.Point(690, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Equip"
        '
        'lblIdUs
        '
        Me.lblIdUs.BackColor = System.Drawing.SystemColors.Control
        Me.lblIdUs.Location = New System.Drawing.Point(94, 2)
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
        Me.Label1.Location = New System.Drawing.Point(15, 5)
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
        Me.dgvProveedor.Location = New System.Drawing.Point(18, 99)
        Me.dgvProveedor.Name = "dgvProveedor"
        Me.dgvProveedor.ReadOnly = True
        Me.dgvProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProveedor.Size = New System.Drawing.Size(146, 71)
        Me.dgvProveedor.TabIndex = 98
        Me.dgvProveedor.VirtualMode = True
        '
        'dgvResumen
        '
        Me.dgvResumen.AllowUserToAddRows = False
        Me.dgvResumen.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgvResumen.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvResumen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvResumen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvResumen.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResumen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.LawnGreen
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvResumen.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvResumen.Location = New System.Drawing.Point(15, 42)
        Me.dgvResumen.Name = "dgvResumen"
        Me.dgvResumen.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvResumen.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvResumen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvResumen.Size = New System.Drawing.Size(153, 51)
        Me.dgvResumen.TabIndex = 117
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Eliminar"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 70
        '
        'frmSTGarantiayOtros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ByB_SI.My.Resources.Resources.Fondo_23___Reducido
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(991, 604)
        Me.Controls.Add(Me.gbxDatos)
        Me.Controls.Add(Me.gbxDatagrid)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSTGarantiayOtros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSTGarantiayOtros"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatagrid.ResumeLayout(False)
        Me.gbxDatagrid.PerformLayout()
        CType(Me.dgvServTecnico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbxDatos.ResumeLayout(False)
        Me.gbxDatos.PerformLayout()
        CType(Me.dgvProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtDiagnostico As System.Windows.Forms.TextBox
    Friend WithEvents txtCdBarrEq As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtPresupuesto As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblFuncion As System.Windows.Forms.Label
    Friend WithEvents lblIdServTecnico As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbxDatagrid As System.Windows.Forms.GroupBox
    Friend WithEvents btnTodo As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents dgvServTecnico As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents errP As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents gbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtIdCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtCodBarra As System.Windows.Forms.TextBox
    Friend WithEvents cbxTipoEq As System.Windows.Forms.ComboBox
    Friend WithEvents lblOrigen As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCdEmp As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtObaserv As System.Windows.Forms.TextBox
    Friend WithEvents txtNroOrden As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTE As System.Windows.Forms.TextBox
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
    Friend WithEvents tmrMensaje As System.Windows.Forms.Timer
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtVtoGar As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtGarantia As System.Windows.Forms.TextBox
    Friend WithEvents chbEntregado As System.Windows.Forms.CheckBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtBuscCliente As System.Windows.Forms.TextBox
    Friend WithEvents cbxBuscTEq As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtBuscProblema As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtBuscDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtBuscCdBarra As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtPresupProv As System.Windows.Forms.TextBox
    Friend WithEvents dgvResumen As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
