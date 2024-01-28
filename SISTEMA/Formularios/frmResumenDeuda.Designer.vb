<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResumenDeuda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResumenDeuda))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtFecHasta = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtFecDesde = New System.Windows.Forms.TextBox()
        Me.gbxDatagrid = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTotalDeuda = New System.Windows.Forms.TextBox()
        Me.dgvResumen = New System.Windows.Forms.DataGridView()
        Me.IdCtaCte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbxBotones = New System.Windows.Forms.GroupBox()
        Me.cbxOperador = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLimite = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtCta = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.pbrConsulta = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvCliente = New System.Windows.Forms.DataGridView()
        Me.dgvCtaCte = New System.Windows.Forms.DataGridView()
        Me.lblAvance = New System.Windows.Forms.Label()
        Me.btnImpComprobante = New System.Windows.Forms.Button()
        Me.gbxDatagrid.SuspendLayout()
        CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxBotones.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCtaCte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label17.Location = New System.Drawing.Point(112, 18)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 16)
        Me.Label17.TabIndex = 114
        Me.Label17.Text = "Fecha Hasta"
        '
        'txtFecHasta
        '
        Me.txtFecHasta.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtFecHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecHasta.ForeColor = System.Drawing.Color.Teal
        Me.txtFecHasta.Location = New System.Drawing.Point(110, 37)
        Me.txtFecHasta.Name = "txtFecHasta"
        Me.txtFecHasta.Size = New System.Drawing.Size(98, 22)
        Me.txtFecHasta.TabIndex = 1
        Me.txtFecHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label18.Location = New System.Drawing.Point(3, 18)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(101, 16)
        Me.Label18.TabIndex = 113
        Me.Label18.Text = "Fecha Desde"
        '
        'txtFecDesde
        '
        Me.txtFecDesde.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtFecDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecDesde.ForeColor = System.Drawing.Color.Teal
        Me.txtFecDesde.Location = New System.Drawing.Point(6, 36)
        Me.txtFecDesde.Name = "txtFecDesde"
        Me.txtFecDesde.Size = New System.Drawing.Size(98, 22)
        Me.txtFecDesde.TabIndex = 0
        Me.txtFecDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gbxDatagrid
        '
        Me.gbxDatagrid.BackColor = System.Drawing.Color.Transparent
        Me.gbxDatagrid.Controls.Add(Me.Label16)
        Me.gbxDatagrid.Controls.Add(Me.txtTotalDeuda)
        Me.gbxDatagrid.Controls.Add(Me.dgvResumen)
        Me.gbxDatagrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDatagrid.ForeColor = System.Drawing.Color.LawnGreen
        Me.gbxDatagrid.Location = New System.Drawing.Point(12, 139)
        Me.gbxDatagrid.Name = "gbxDatagrid"
        Me.gbxDatagrid.Size = New System.Drawing.Size(1114, 462)
        Me.gbxDatagrid.TabIndex = 66
        Me.gbxDatagrid.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(805, 433)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(158, 20)
        Me.Label16.TabIndex = 169
        Me.Label16.Text = "TOTAL DEUDA: ->"
        '
        'txtTotalDeuda
        '
        Me.txtTotalDeuda.BackColor = System.Drawing.Color.DarkRed
        Me.txtTotalDeuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDeuda.ForeColor = System.Drawing.Color.White
        Me.txtTotalDeuda.Location = New System.Drawing.Point(965, 430)
        Me.txtTotalDeuda.Name = "txtTotalDeuda"
        Me.txtTotalDeuda.Size = New System.Drawing.Size(143, 26)
        Me.txtTotalDeuda.TabIndex = 170
        Me.txtTotalDeuda.Text = "$ 0.00"
        Me.txtTotalDeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvResumen
        '
        Me.dgvResumen.AllowUserToAddRows = False
        Me.dgvResumen.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleGoldenrod
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvResumen.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvResumen.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResumen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCtaCte})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.PaleGoldenrod
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.LawnGreen
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvResumen.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvResumen.Location = New System.Drawing.Point(6, 21)
        Me.dgvResumen.Name = "dgvResumen"
        Me.dgvResumen.ReadOnly = True
        Me.dgvResumen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.dgvResumen.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvResumen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvResumen.Size = New System.Drawing.Size(1102, 403)
        Me.dgvResumen.TabIndex = 168
        '
        'IdCtaCte
        '
        Me.IdCtaCte.DataPropertyName = "IdCtaCte"
        Me.IdCtaCte.HeaderText = "IdCtaCte"
        Me.IdCtaCte.Name = "IdCtaCte"
        Me.IdCtaCte.ReadOnly = True
        Me.IdCtaCte.Visible = False
        '
        'gbxBotones
        '
        Me.gbxBotones.BackColor = System.Drawing.Color.Transparent
        Me.gbxBotones.Controls.Add(Me.cbxOperador)
        Me.gbxBotones.Controls.Add(Me.Label3)
        Me.gbxBotones.Controls.Add(Me.txtLimite)
        Me.gbxBotones.Controls.Add(Me.Label1)
        Me.gbxBotones.Controls.Add(Me.txtRazonSocial)
        Me.gbxBotones.Controls.Add(Me.Label17)
        Me.gbxBotones.Controls.Add(Me.txtFecHasta)
        Me.gbxBotones.Controls.Add(Me.Label18)
        Me.gbxBotones.Controls.Add(Me.txtFecDesde)
        Me.gbxBotones.Controls.Add(Me.Label22)
        Me.gbxBotones.Controls.Add(Me.txtCta)
        Me.gbxBotones.Location = New System.Drawing.Point(150, 8)
        Me.gbxBotones.Name = "gbxBotones"
        Me.gbxBotones.Size = New System.Drawing.Size(769, 73)
        Me.gbxBotones.TabIndex = 67
        Me.gbxBotones.TabStop = False
        '
        'cbxOperador
        '
        Me.cbxOperador.BackColor = System.Drawing.Color.MediumTurquoise
        Me.cbxOperador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxOperador.ForeColor = System.Drawing.Color.Teal
        Me.cbxOperador.FormattingEnabled = True
        Me.cbxOperador.Items.AddRange(New Object() {">", "<", "="})
        Me.cbxOperador.Location = New System.Drawing.Point(628, 38)
        Me.cbxOperador.Name = "cbxOperador"
        Me.cbxOperador.Size = New System.Drawing.Size(58, 21)
        Me.cbxOperador.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label3.Location = New System.Drawing.Point(625, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "Límite $"
        '
        'txtLimite
        '
        Me.txtLimite.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtLimite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimite.ForeColor = System.Drawing.Color.Teal
        Me.txtLimite.Location = New System.Drawing.Point(692, 36)
        Me.txtLimite.Name = "txtLimite"
        Me.txtLimite.Size = New System.Drawing.Size(71, 22)
        Me.txtLimite.TabIndex = 5
        Me.txtLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label1.Location = New System.Drawing.Point(290, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Razón Social"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtRazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocial.ForeColor = System.Drawing.Color.Teal
        Me.txtRazonSocial.Location = New System.Drawing.Point(291, 37)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(331, 22)
        Me.txtRazonSocial.TabIndex = 3
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label22.Location = New System.Drawing.Point(213, 18)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 16)
        Me.Label22.TabIndex = 111
        Me.Label22.Text = "Cuenta"
        '
        'txtCta
        '
        Me.txtCta.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCta.ForeColor = System.Drawing.Color.Teal
        Me.txtCta.Location = New System.Drawing.Point(214, 37)
        Me.txtCta.Name = "txtCta"
        Me.txtCta.Size = New System.Drawing.Size(71, 22)
        Me.txtCta.TabIndex = 2
        Me.txtCta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 121)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 68
        Me.PictureBox1.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = CType(resources.GetObject("btnSalir.BackgroundImage"), System.Drawing.Image)
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Location = New System.Drawing.Point(1059, 79)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(61, 61)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Tag = ""
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = CType(resources.GetObject("btnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBuscar.Location = New System.Drawing.Point(925, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(61, 61)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Tag = ""
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackgroundImage = CType(resources.GetObject("btnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLimpiar.Location = New System.Drawing.Point(992, 12)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(61, 61)
        Me.btnLimpiar.TabIndex = 7
        Me.btnLimpiar.Tag = ""
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'pbrConsulta
        '
        Me.pbrConsulta.ForeColor = System.Drawing.Color.Lime
        Me.pbrConsulta.Location = New System.Drawing.Point(150, 110)
        Me.pbrConsulta.Name = "pbrConsulta"
        Me.pbrConsulta.Size = New System.Drawing.Size(769, 23)
        Me.pbrConsulta.TabIndex = 69
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label2.Location = New System.Drawing.Point(149, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 16)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Progreso de Operación"
        '
        'dgvCliente
        '
        Me.dgvCliente.AllowUserToAddRows = False
        Me.dgvCliente.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCliente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCliente.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvCliente.Location = New System.Drawing.Point(32, 60)
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCliente.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCliente.Size = New System.Drawing.Size(85, 21)
        Me.dgvCliente.TabIndex = 115
        '
        'dgvCtaCte
        '
        Me.dgvCtaCte.AllowUserToAddRows = False
        Me.dgvCtaCte.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCtaCte.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvCtaCte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvCtaCte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCtaCte.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvCtaCte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCtaCte.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvCtaCte.Location = New System.Drawing.Point(32, 91)
        Me.dgvCtaCte.Name = "dgvCtaCte"
        Me.dgvCtaCte.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCtaCte.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvCtaCte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCtaCte.Size = New System.Drawing.Size(85, 21)
        Me.dgvCtaCte.TabIndex = 116
        '
        'lblAvance
        '
        Me.lblAvance.BackColor = System.Drawing.Color.Transparent
        Me.lblAvance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvance.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblAvance.Location = New System.Drawing.Point(749, 91)
        Me.lblAvance.Name = "lblAvance"
        Me.lblAvance.Size = New System.Drawing.Size(170, 16)
        Me.lblAvance.TabIndex = 117
        Me.lblAvance.Text = "0 %"
        Me.lblAvance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnImpComprobante
        '
        Me.btnImpComprobante.BackgroundImage = Global.ByB_SI.My.Resources.Resources.ImpresoraIn
        Me.btnImpComprobante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnImpComprobante.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImpComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImpComprobante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnImpComprobante.Location = New System.Drawing.Point(1059, 12)
        Me.btnImpComprobante.Name = "btnImpComprobante"
        Me.btnImpComprobante.Size = New System.Drawing.Size(61, 61)
        Me.btnImpComprobante.TabIndex = 8
        Me.btnImpComprobante.Tag = ""
        Me.btnImpComprobante.UseVisualStyleBackColor = True
        '
        'frmResumenDeuda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1135, 607)
        Me.Controls.Add(Me.btnImpComprobante)
        Me.Controls.Add(Me.lblAvance)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgvCtaCte)
        Me.Controls.Add(Me.dgvCliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pbrConsulta)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.gbxDatagrid)
        Me.Controls.Add(Me.gbxBotones)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmResumenDeuda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmResumenDeuda"
        Me.gbxDatagrid.ResumeLayout(False)
        Me.gbxDatagrid.PerformLayout()
        CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxBotones.ResumeLayout(False)
        Me.gbxBotones.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCtaCte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtFecHasta As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtFecDesde As System.Windows.Forms.TextBox
    Friend WithEvents gbxDatagrid As System.Windows.Forms.GroupBox
    Friend WithEvents gbxBotones As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtCta As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents pbrConsulta As System.Windows.Forms.ProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
    Friend WithEvents dgvResumen As System.Windows.Forms.DataGridView
    Friend WithEvents IdCtaCte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvCtaCte As System.Windows.Forms.DataGridView
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtTotalDeuda As System.Windows.Forms.TextBox
    Friend WithEvents lblAvance As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLimite As System.Windows.Forms.TextBox
    Friend WithEvents cbxOperador As System.Windows.Forms.ComboBox
    Friend WithEvents btnImpComprobante As System.Windows.Forms.Button
End Class
