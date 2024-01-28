<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSTEntregaRecep
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSTEntregaRecep))
        Me.gbxDatagrid = New System.Windows.Forms.GroupBox()
        Me.dgvServTecnico = New System.Windows.Forms.DataGridView()
        Me.Marcar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnEntregado = New System.Windows.Forms.Button()
        Me.btnRecibido = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gbxBotones = New System.Windows.Forms.GroupBox()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnMarcarTodo = New System.Windows.Forms.Button()
        Me.chbEntrega = New System.Windows.Forms.CheckBox()
        Me.txtFecEntrega = New System.Windows.Forms.TextBox()
        Me.nudDias = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvCliente = New System.Windows.Forms.DataGridView()
        Me.cbxTercerizado = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxEstado = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
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
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnTodo = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnImpStock = New System.Windows.Forms.Button()
        Me.gbxDatagrid.SuspendLayout()
        CType(Me.dgvServTecnico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxBotones.SuspendLayout()
        CType(Me.nudDias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxDatagrid
        '
        Me.gbxDatagrid.BackColor = System.Drawing.Color.Transparent
        Me.gbxDatagrid.Controls.Add(Me.dgvServTecnico)
        Me.gbxDatagrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDatagrid.ForeColor = System.Drawing.Color.LawnGreen
        Me.gbxDatagrid.Location = New System.Drawing.Point(12, 169)
        Me.gbxDatagrid.Name = "gbxDatagrid"
        Me.gbxDatagrid.Size = New System.Drawing.Size(903, 339)
        Me.gbxDatagrid.TabIndex = 58
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServTecnico.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvServTecnico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServTecnico.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Marcar})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
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
        Me.dgvServTecnico.Size = New System.Drawing.Size(882, 316)
        Me.dgvServTecnico.TabIndex = 18
        '
        'Marcar
        '
        Me.Marcar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Marcar.HeaderText = "Marcar"
        Me.Marcar.Name = "Marcar"
        Me.Marcar.ReadOnly = True
        Me.Marcar.Width = 52
        '
        'btnEntregado
        '
        Me.btnEntregado.BackgroundImage = Global.ByB_SI.My.Resources.Resources.EntregaIn
        Me.btnEntregado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEntregado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEntregado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntregado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEntregado.Location = New System.Drawing.Point(921, 20)
        Me.btnEntregado.Name = "btnEntregado"
        Me.btnEntregado.Size = New System.Drawing.Size(61, 59)
        Me.btnEntregado.TabIndex = 11
        Me.btnEntregado.Tag = ""
        Me.btnEntregado.UseVisualStyleBackColor = True
        '
        'btnRecibido
        '
        Me.btnRecibido.BackColor = System.Drawing.SystemColors.Control
        Me.btnRecibido.BackgroundImage = Global.ByB_SI.My.Resources.Resources.RecepcionIn
        Me.btnRecibido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRecibido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecibido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecibido.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRecibido.Location = New System.Drawing.Point(921, 96)
        Me.btnRecibido.Name = "btnRecibido"
        Me.btnRecibido.Size = New System.Drawing.Size(61, 60)
        Me.btnRecibido.TabIndex = 12
        Me.btnRecibido.Tag = ""
        Me.btnRecibido.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = Global.ByB_SI.My.Resources.Resources.SalirIn
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Location = New System.Drawing.Point(921, 447)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(61, 61)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Tag = ""
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'gbxBotones
        '
        Me.gbxBotones.BackColor = System.Drawing.Color.Transparent
        Me.gbxBotones.Controls.Add(Me.btnQuitar)
        Me.gbxBotones.Controls.Add(Me.btnMarcarTodo)
        Me.gbxBotones.Controls.Add(Me.chbEntrega)
        Me.gbxBotones.Controls.Add(Me.txtFecEntrega)
        Me.gbxBotones.Controls.Add(Me.nudDias)
        Me.gbxBotones.Controls.Add(Me.Label5)
        Me.gbxBotones.Controls.Add(Me.Label4)
        Me.gbxBotones.Controls.Add(Me.PictureBox1)
        Me.gbxBotones.Controls.Add(Me.dgvCliente)
        Me.gbxBotones.Controls.Add(Me.cbxTercerizado)
        Me.gbxBotones.Controls.Add(Me.Label3)
        Me.gbxBotones.Controls.Add(Me.cbxEstado)
        Me.gbxBotones.Controls.Add(Me.Label2)
        Me.gbxBotones.Controls.Add(Me.Label1)
        Me.gbxBotones.Controls.Add(Me.txtCliente)
        Me.gbxBotones.Controls.Add(Me.Label15)
        Me.gbxBotones.Controls.Add(Me.txtBuscCliente)
        Me.gbxBotones.Controls.Add(Me.cbxBuscTEq)
        Me.gbxBotones.Controls.Add(Me.Label17)
        Me.gbxBotones.Controls.Add(Me.txtBuscProblema)
        Me.gbxBotones.Controls.Add(Me.Label18)
        Me.gbxBotones.Controls.Add(Me.txtBuscDescripcion)
        Me.gbxBotones.Controls.Add(Me.Label19)
        Me.gbxBotones.Controls.Add(Me.Label22)
        Me.gbxBotones.Controls.Add(Me.txtBuscCdBarra)
        Me.gbxBotones.Controls.Add(Me.btnBuscar)
        Me.gbxBotones.Controls.Add(Me.btnTodo)
        Me.gbxBotones.Controls.Add(Me.btnLimpiar)
        Me.gbxBotones.Location = New System.Drawing.Point(12, 3)
        Me.gbxBotones.Name = "gbxBotones"
        Me.gbxBotones.Size = New System.Drawing.Size(903, 160)
        Me.gbxBotones.TabIndex = 60
        Me.gbxBotones.TabStop = False
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(746, 123)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(75, 23)
        Me.btnQuitar.TabIndex = 133
        Me.btnQuitar.Text = "Quitar Todo"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnMarcarTodo
        '
        Me.btnMarcarTodo.Location = New System.Drawing.Point(665, 123)
        Me.btnMarcarTodo.Name = "btnMarcarTodo"
        Me.btnMarcarTodo.Size = New System.Drawing.Size(75, 23)
        Me.btnMarcarTodo.TabIndex = 132
        Me.btnMarcarTodo.Text = "Sel Todo"
        Me.btnMarcarTodo.UseVisualStyleBackColor = True
        '
        'chbEntrega
        '
        Me.chbEntrega.AutoSize = True
        Me.chbEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbEntrega.ForeColor = System.Drawing.Color.LawnGreen
        Me.chbEntrega.Location = New System.Drawing.Point(169, 127)
        Me.chbEntrega.Name = "chbEntrega"
        Me.chbEntrega.Size = New System.Drawing.Size(221, 20)
        Me.chbEntrega.TabIndex = 131
        Me.chbEntrega.Text = "Entrega Equipos Fecha ---->"
        Me.chbEntrega.UseVisualStyleBackColor = True
        '
        'txtFecEntrega
        '
        Me.txtFecEntrega.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtFecEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecEntrega.ForeColor = System.Drawing.Color.Teal
        Me.txtFecEntrega.Location = New System.Drawing.Point(389, 125)
        Me.txtFecEntrega.Name = "txtFecEntrega"
        Me.txtFecEntrega.Size = New System.Drawing.Size(102, 22)
        Me.txtFecEntrega.TabIndex = 129
        Me.txtFecEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudDias
        '
        Me.nudDias.BackColor = System.Drawing.Color.MediumTurquoise
        Me.nudDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDias.ForeColor = System.Drawing.Color.Teal
        Me.nudDias.Location = New System.Drawing.Point(561, 125)
        Me.nudDias.Name = "nudDias"
        Me.nudDias.Size = New System.Drawing.Size(50, 20)
        Me.nudDias.TabIndex = 128
        Me.nudDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label5.Location = New System.Drawing.Point(617, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 127
        Me.Label5.Text = "Días"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label4.Location = New System.Drawing.Point(499, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 16)
        Me.Label4.TabIndex = 126
        Me.Label4.Text = "Menos"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Image = Global.ByB_SI.My.Resources.Resources.TodosArtAc
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
        'cbxTercerizado
        '
        Me.cbxTercerizado.BackColor = System.Drawing.Color.MediumTurquoise
        Me.cbxTercerizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTercerizado.ForeColor = System.Drawing.Color.Teal
        Me.cbxTercerizado.FormattingEnabled = True
        Me.cbxTercerizado.Items.AddRange(New Object() {"Si", "No"})
        Me.cbxTercerizado.Location = New System.Drawing.Point(496, 41)
        Me.cbxTercerizado.Name = "cbxTercerizado"
        Me.cbxTercerizado.Size = New System.Drawing.Size(158, 21)
        Me.cbxTercerizado.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label3.Location = New System.Drawing.Point(493, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "Tercerizado"
        '
        'cbxEstado
        '
        Me.cbxEstado.BackColor = System.Drawing.Color.MediumTurquoise
        Me.cbxEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxEstado.ForeColor = System.Drawing.Color.Teal
        Me.cbxEstado.FormattingEnabled = True
        Me.cbxEstado.Items.AddRange(New Object() {"En Reparacion ByB", "En Reparacion Terceros", "Devuelto Por Terceros", "Devuelto Al Cliente"})
        Me.cbxEstado.Location = New System.Drawing.Point(660, 41)
        Me.cbxEstado.Name = "cbxEstado"
        Me.cbxEstado.Size = New System.Drawing.Size(161, 21)
        Me.cbxEstado.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label2.Location = New System.Drawing.Point(657, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "Estado"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label1.Location = New System.Drawing.Point(240, 19)
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
        Me.txtCliente.Location = New System.Drawing.Point(241, 39)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(249, 22)
        Me.txtCliente.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label15.Location = New System.Drawing.Point(167, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 18)
        Me.Label15.TabIndex = 116
        Me.Label15.Text = "Cta"
        '
        'txtBuscCliente
        '
        Me.txtBuscCliente.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtBuscCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscCliente.ForeColor = System.Drawing.Color.Teal
        Me.txtBuscCliente.Location = New System.Drawing.Point(170, 39)
        Me.txtBuscCliente.Name = "txtBuscCliente"
        Me.txtBuscCliente.Size = New System.Drawing.Size(65, 22)
        Me.txtBuscCliente.TabIndex = 0
        Me.txtBuscCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbxBuscTEq
        '
        Me.cbxBuscTEq.BackColor = System.Drawing.Color.MediumTurquoise
        Me.cbxBuscTEq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxBuscTEq.ForeColor = System.Drawing.Color.Teal
        Me.cbxBuscTEq.FormattingEnabled = True
        Me.cbxBuscTEq.Items.AddRange(New Object() {"CPU (PC Escritorio)", "Monitor", "Impresora", "Notebook", "NetBook", "Tablet", "Consola de Juego", "Celular", "GPS", "Otros"})
        Me.cbxBuscTEq.Location = New System.Drawing.Point(330, 89)
        Me.cbxBuscTEq.Name = "cbxBuscTEq"
        Me.cbxBuscTEq.Size = New System.Drawing.Size(161, 21)
        Me.cbxBuscTEq.TabIndex = 5
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label17.Location = New System.Drawing.Point(657, 68)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 16)
        Me.Label17.TabIndex = 114
        Me.Label17.Text = "Problema"
        '
        'txtBuscProblema
        '
        Me.txtBuscProblema.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtBuscProblema.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscProblema.ForeColor = System.Drawing.Color.Teal
        Me.txtBuscProblema.Location = New System.Drawing.Point(660, 87)
        Me.txtBuscProblema.Name = "txtBuscProblema"
        Me.txtBuscProblema.Size = New System.Drawing.Size(161, 22)
        Me.txtBuscProblema.TabIndex = 7
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label18.Location = New System.Drawing.Point(493, 68)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 16)
        Me.Label18.TabIndex = 113
        Me.Label18.Text = "Descripción"
        '
        'txtBuscDescripcion
        '
        Me.txtBuscDescripcion.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtBuscDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscDescripcion.ForeColor = System.Drawing.Color.Teal
        Me.txtBuscDescripcion.Location = New System.Drawing.Point(496, 87)
        Me.txtBuscDescripcion.Name = "txtBuscDescripcion"
        Me.txtBuscDescripcion.Size = New System.Drawing.Size(158, 22)
        Me.txtBuscDescripcion.TabIndex = 6
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label19.Location = New System.Drawing.Point(327, 68)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(93, 16)
        Me.Label19.TabIndex = 112
        Me.Label19.Text = "Tipo Equipo"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label22.Location = New System.Drawing.Point(169, 68)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(82, 16)
        Me.Label22.TabIndex = 111
        Me.Label22.Text = "Cod. Barra"
        '
        'txtBuscCdBarra
        '
        Me.txtBuscCdBarra.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtBuscCdBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscCdBarra.ForeColor = System.Drawing.Color.Teal
        Me.txtBuscCdBarra.Location = New System.Drawing.Point(170, 87)
        Me.txtBuscCdBarra.Name = "txtBuscCdBarra"
        Me.txtBuscCdBarra.Size = New System.Drawing.Size(155, 22)
        Me.txtBuscCdBarra.TabIndex = 4
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.ConsultaIn
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBuscar.Location = New System.Drawing.Point(848, 17)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(43, 43)
        Me.btnBuscar.TabIndex = 8
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
        Me.btnTodo.Location = New System.Drawing.Point(848, 63)
        Me.btnTodo.Name = "btnTodo"
        Me.btnTodo.Size = New System.Drawing.Size(43, 43)
        Me.btnTodo.TabIndex = 9
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
        Me.btnLimpiar.Location = New System.Drawing.Point(848, 109)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(43, 43)
        Me.btnLimpiar.TabIndex = 10
        Me.btnLimpiar.Tag = ""
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnImpStock
        '
        Me.btnImpStock.BackgroundImage = Global.ByB_SI.My.Resources.Resources.ImpresoraIn
        Me.btnImpStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnImpStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImpStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImpStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnImpStock.Location = New System.Drawing.Point(921, 186)
        Me.btnImpStock.Name = "btnImpStock"
        Me.btnImpStock.Size = New System.Drawing.Size(61, 62)
        Me.btnImpStock.TabIndex = 13
        Me.btnImpStock.Tag = ""
        Me.btnImpStock.UseVisualStyleBackColor = True
        '
        'frmSTEntregaRecep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ByB_SI.My.Resources.Resources.Fondo_23___Reducido
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(992, 520)
        Me.Controls.Add(Me.btnImpStock)
        Me.Controls.Add(Me.gbxBotones)
        Me.Controls.Add(Me.gbxDatagrid)
        Me.Controls.Add(Me.btnEntregado)
        Me.Controls.Add(Me.btnRecibido)
        Me.Controls.Add(Me.btnSalir)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSTEntregaRecep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSTProveedores"
        Me.gbxDatagrid.ResumeLayout(False)
        CType(Me.dgvServTecnico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxBotones.ResumeLayout(False)
        Me.gbxBotones.PerformLayout()
        CType(Me.nudDias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxDatagrid As System.Windows.Forms.GroupBox
    Friend WithEvents dgvServTecnico As System.Windows.Forms.DataGridView
    Friend WithEvents btnEntregado As System.Windows.Forms.Button
    Friend WithEvents btnRecibido As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents gbxBotones As System.Windows.Forms.GroupBox
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
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnTodo As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents cbxEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbxTercerizado As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Marcar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
    Friend WithEvents btnImpStock As System.Windows.Forms.Button
    Friend WithEvents nudDias As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFecEntrega As System.Windows.Forms.TextBox
    Friend WithEvents chbEntrega As System.Windows.Forms.CheckBox
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents btnMarcarTodo As System.Windows.Forms.Button
End Class
