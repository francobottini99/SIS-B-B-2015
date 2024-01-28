<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsServicioTecnico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsServicioTecnico))
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
        Me.gbxBotones = New System.Windows.Forms.GroupBox()
        Me.gbxDatagrid = New System.Windows.Forms.GroupBox()
        Me.dgvServTecnico = New System.Windows.Forms.DataGridView()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnTodo = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvCliente = New System.Windows.Forms.DataGridView()
        Me.btnImpComprobante = New System.Windows.Forms.Button()
        Me.lblReg = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbxBotones.SuspendLayout()
        Me.gbxDatagrid.SuspendLayout()
        CType(Me.dgvServTecnico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxTercerizado
        '
        Me.cbxTercerizado.BackColor = System.Drawing.Color.MediumTurquoise
        Me.cbxTercerizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTercerizado.ForeColor = System.Drawing.Color.Teal
        Me.cbxTercerizado.FormattingEnabled = True
        Me.cbxTercerizado.Items.AddRange(New Object() {"Si", "No"})
        Me.cbxTercerizado.Location = New System.Drawing.Point(468, 33)
        Me.cbxTercerizado.Name = "cbxTercerizado"
        Me.cbxTercerizado.Size = New System.Drawing.Size(158, 21)
        Me.cbxTercerizado.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label3.Location = New System.Drawing.Point(465, 11)
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
        Me.cbxEstado.Location = New System.Drawing.Point(632, 33)
        Me.cbxEstado.Name = "cbxEstado"
        Me.cbxEstado.Size = New System.Drawing.Size(161, 21)
        Me.cbxEstado.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label2.Location = New System.Drawing.Point(629, 11)
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
        Me.Label1.Location = New System.Drawing.Point(79, 11)
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
        Me.txtCliente.Location = New System.Drawing.Point(80, 31)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(382, 22)
        Me.txtCliente.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label15.Location = New System.Drawing.Point(6, 11)
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
        Me.txtBuscCliente.Location = New System.Drawing.Point(9, 31)
        Me.txtBuscCliente.Name = "txtBuscCliente"
        Me.txtBuscCliente.Size = New System.Drawing.Size(65, 22)
        Me.txtBuscCliente.TabIndex = 1
        Me.txtBuscCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbxBuscTEq
        '
        Me.cbxBuscTEq.BackColor = System.Drawing.Color.MediumTurquoise
        Me.cbxBuscTEq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxBuscTEq.ForeColor = System.Drawing.Color.Teal
        Me.cbxBuscTEq.FormattingEnabled = True
        Me.cbxBuscTEq.Items.AddRange(New Object() {"CPU (PC Escritorio)", "Monitor", "Impresora", "Notebook", "NetBook", "Tablet", "Consola de Juego", "Celular", "GPS", "Otros"})
        Me.cbxBuscTEq.Location = New System.Drawing.Point(168, 87)
        Me.cbxBuscTEq.Name = "cbxBuscTEq"
        Me.cbxBuscTEq.Size = New System.Drawing.Size(161, 21)
        Me.cbxBuscTEq.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label17.Location = New System.Drawing.Point(562, 66)
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
        Me.txtBuscProblema.Location = New System.Drawing.Point(565, 85)
        Me.txtBuscProblema.Name = "txtBuscProblema"
        Me.txtBuscProblema.Size = New System.Drawing.Size(226, 22)
        Me.txtBuscProblema.TabIndex = 8
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label18.Location = New System.Drawing.Point(332, 67)
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
        Me.txtBuscDescripcion.Location = New System.Drawing.Point(335, 85)
        Me.txtBuscDescripcion.Name = "txtBuscDescripcion"
        Me.txtBuscDescripcion.Size = New System.Drawing.Size(224, 22)
        Me.txtBuscDescripcion.TabIndex = 7
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label19.Location = New System.Drawing.Point(166, 68)
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
        Me.Label22.Location = New System.Drawing.Point(6, 68)
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
        Me.txtBuscCdBarra.Location = New System.Drawing.Point(7, 87)
        Me.txtBuscCdBarra.Name = "txtBuscCdBarra"
        Me.txtBuscCdBarra.Size = New System.Drawing.Size(155, 22)
        Me.txtBuscCdBarra.TabIndex = 5
        '
        'gbxBotones
        '
        Me.gbxBotones.BackColor = System.Drawing.Color.Transparent
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
        Me.gbxBotones.Location = New System.Drawing.Point(150, 3)
        Me.gbxBotones.Name = "gbxBotones"
        Me.gbxBotones.Size = New System.Drawing.Size(801, 116)
        Me.gbxBotones.TabIndex = 65
        Me.gbxBotones.TabStop = False
        '
        'gbxDatagrid
        '
        Me.gbxDatagrid.BackColor = System.Drawing.Color.Transparent
        Me.gbxDatagrid.Controls.Add(Me.dgvServTecnico)
        Me.gbxDatagrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDatagrid.ForeColor = System.Drawing.Color.LawnGreen
        Me.gbxDatagrid.Location = New System.Drawing.Point(12, 139)
        Me.gbxDatagrid.Name = "gbxDatagrid"
        Me.gbxDatagrid.Size = New System.Drawing.Size(1140, 427)
        Me.gbxDatagrid.TabIndex = 64
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
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
        Me.dgvServTecnico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvServTecnico.Size = New System.Drawing.Size(1125, 402)
        Me.dgvServTecnico.TabIndex = 18
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = Global.ByB_SI.My.Resources.Resources.SalirIn
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Location = New System.Drawing.Point(1091, 79)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(61, 61)
        Me.btnSalir.TabIndex = 69
        Me.btnSalir.Tag = ""
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.ConsultaIn
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBuscar.Location = New System.Drawing.Point(957, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(61, 61)
        Me.btnBuscar.TabIndex = 66
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
        Me.btnTodo.Location = New System.Drawing.Point(1024, 12)
        Me.btnTodo.Name = "btnTodo"
        Me.btnTodo.Size = New System.Drawing.Size(61, 61)
        Me.btnTodo.TabIndex = 67
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
        Me.btnLimpiar.Location = New System.Drawing.Point(1091, 12)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(61, 61)
        Me.btnLimpiar.TabIndex = 68
        Me.btnLimpiar.Tag = ""
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Image = Global.ByB_SI.My.Resources.Resources.OrdenST
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 121)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 124
        Me.PictureBox1.TabStop = False
        '
        'dgvCliente
        '
        Me.dgvCliente.AllowUserToAddRows = False
        Me.dgvCliente.AllowUserToDeleteRows = False
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCliente.Location = New System.Drawing.Point(34, 63)
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.ReadOnly = True
        Me.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCliente.Size = New System.Drawing.Size(86, 23)
        Me.dgvCliente.TabIndex = 125
        Me.dgvCliente.VirtualMode = True
        '
        'btnImpComprobante
        '
        Me.btnImpComprobante.BackgroundImage = Global.ByB_SI.My.Resources.Resources.ImpresoraIn
        Me.btnImpComprobante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnImpComprobante.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImpComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImpComprobante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnImpComprobante.Location = New System.Drawing.Point(1024, 79)
        Me.btnImpComprobante.Name = "btnImpComprobante"
        Me.btnImpComprobante.Size = New System.Drawing.Size(61, 61)
        Me.btnImpComprobante.TabIndex = 174
        Me.btnImpComprobante.Tag = ""
        Me.btnImpComprobante.UseVisualStyleBackColor = True
        '
        'lblReg
        '
        Me.lblReg.BackColor = System.Drawing.Color.Transparent
        Me.lblReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReg.ForeColor = System.Drawing.Color.Gold
        Me.lblReg.Location = New System.Drawing.Point(878, 122)
        Me.lblReg.Name = "lblReg"
        Me.lblReg.Size = New System.Drawing.Size(73, 22)
        Me.lblReg.TabIndex = 175
        Me.lblReg.Text = "0"
        Me.lblReg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label5.Location = New System.Drawing.Point(717, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 22)
        Me.Label5.TabIndex = 176
        Me.Label5.Text = "Cantidad Registros ="
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmConsServicioTecnico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ByB_SI.My.Resources.Resources.Fondo_23___Reducido
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1161, 570)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblReg)
        Me.Controls.Add(Me.btnImpComprobante)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgvCliente)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnTodo)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.gbxBotones)
        Me.Controls.Add(Me.gbxDatagrid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsServicioTecnico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConsServicioTecnico"
        Me.gbxBotones.ResumeLayout(False)
        Me.gbxBotones.PerformLayout()
        Me.gbxDatagrid.ResumeLayout(False)
        CType(Me.dgvServTecnico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbxTercerizado As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbxEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
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
    Friend WithEvents gbxBotones As System.Windows.Forms.GroupBox
    Friend WithEvents gbxDatagrid As System.Windows.Forms.GroupBox
    Friend WithEvents dgvServTecnico As System.Windows.Forms.DataGridView
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnTodo As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
    Friend WithEvents btnImpComprobante As System.Windows.Forms.Button
    Friend WithEvents lblReg As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
