<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsVentas))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnImpComprobante = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvCliente = New System.Windows.Forms.DataGridView()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnTodo = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.lblReg = New System.Windows.Forms.Label()
        Me.gbxBotones = New System.Windows.Forms.GroupBox()
        Me.cbxClaseFac = New System.Windows.Forms.ComboBox()
        Me.chkClaseFac = New System.Windows.Forms.CheckBox()
        Me.txtCdBarr = New System.Windows.Forms.TextBox()
        Me.chkCdBarr = New System.Windows.Forms.CheckBox()
        Me.txtCli = New System.Windows.Forms.TextBox()
        Me.chkCli = New System.Windows.Forms.CheckBox()
        Me.txtDet = New System.Windows.Forms.TextBox()
        Me.chkDet = New System.Windows.Forms.CheckBox()
        Me.txtCat = New System.Windows.Forms.TextBox()
        Me.chkCat = New System.Windows.Forms.CheckBox()
        Me.txtSubR = New System.Windows.Forms.TextBox()
        Me.chkSubR = New System.Windows.Forms.CheckBox()
        Me.txtRub = New System.Windows.Forms.TextBox()
        Me.chkRub = New System.Windows.Forms.CheckBox()
        Me.txtTipoFac = New System.Windows.Forms.TextBox()
        Me.chkTipoFac = New System.Windows.Forms.CheckBox()
        Me.txtNroFac = New System.Windows.Forms.TextBox()
        Me.chkNroFac = New System.Windows.Forms.CheckBox()
        Me.txtFecHasta = New System.Windows.Forms.TextBox()
        Me.chkFecHasta = New System.Windows.Forms.CheckBox()
        Me.txtFecDesde = New System.Windows.Forms.TextBox()
        Me.chkFecDesde = New System.Windows.Forms.CheckBox()
        Me.gbxDataGrid = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCant = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSubT = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblIva = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxBotones.SuspendLayout()
        Me.gbxDataGrid.SuspendLayout()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label5.Location = New System.Drawing.Point(150, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 22)
        Me.Label5.TabIndex = 187
        Me.Label5.Text = "Reg. ="
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnImpComprobante
        '
        Me.btnImpComprobante.BackgroundImage = Global.ByB_SI.My.Resources.Resources.ImpresoraIn
        Me.btnImpComprobante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnImpComprobante.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImpComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImpComprobante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnImpComprobante.Location = New System.Drawing.Point(1086, 79)
        Me.btnImpComprobante.Name = "btnImpComprobante"
        Me.btnImpComprobante.Size = New System.Drawing.Size(61, 61)
        Me.btnImpComprobante.TabIndex = 23
        Me.btnImpComprobante.Tag = ""
        Me.btnImpComprobante.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Image = Global.ByB_SI.My.Resources.Resources.Ventas1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 183
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
        Me.dgvCliente.TabIndex = 184
        Me.dgvCliente.VirtualMode = True
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = Global.ByB_SI.My.Resources.Resources.SalirIn
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Location = New System.Drawing.Point(1153, 79)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(61, 61)
        Me.btnSalir.TabIndex = 24
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
        Me.btnBuscar.Location = New System.Drawing.Point(1019, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(61, 61)
        Me.btnBuscar.TabIndex = 20
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
        Me.btnTodo.Location = New System.Drawing.Point(1086, 12)
        Me.btnTodo.Name = "btnTodo"
        Me.btnTodo.Size = New System.Drawing.Size(61, 61)
        Me.btnTodo.TabIndex = 21
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
        Me.btnLimpiar.Location = New System.Drawing.Point(1153, 12)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(61, 61)
        Me.btnLimpiar.TabIndex = 22
        Me.btnLimpiar.Tag = ""
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'lblReg
        '
        Me.lblReg.BackColor = System.Drawing.Color.Transparent
        Me.lblReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReg.ForeColor = System.Drawing.Color.Gold
        Me.lblReg.Location = New System.Drawing.Point(211, 125)
        Me.lblReg.Name = "lblReg"
        Me.lblReg.Size = New System.Drawing.Size(62, 22)
        Me.lblReg.TabIndex = 186
        Me.lblReg.Text = "0"
        Me.lblReg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbxBotones
        '
        Me.gbxBotones.BackColor = System.Drawing.Color.Transparent
        Me.gbxBotones.Controls.Add(Me.cbxClaseFac)
        Me.gbxBotones.Controls.Add(Me.chkClaseFac)
        Me.gbxBotones.Controls.Add(Me.txtCdBarr)
        Me.gbxBotones.Controls.Add(Me.chkCdBarr)
        Me.gbxBotones.Controls.Add(Me.txtCli)
        Me.gbxBotones.Controls.Add(Me.chkCli)
        Me.gbxBotones.Controls.Add(Me.txtDet)
        Me.gbxBotones.Controls.Add(Me.chkDet)
        Me.gbxBotones.Controls.Add(Me.txtCat)
        Me.gbxBotones.Controls.Add(Me.chkCat)
        Me.gbxBotones.Controls.Add(Me.txtSubR)
        Me.gbxBotones.Controls.Add(Me.chkSubR)
        Me.gbxBotones.Controls.Add(Me.txtRub)
        Me.gbxBotones.Controls.Add(Me.chkRub)
        Me.gbxBotones.Controls.Add(Me.txtTipoFac)
        Me.gbxBotones.Controls.Add(Me.chkTipoFac)
        Me.gbxBotones.Controls.Add(Me.txtNroFac)
        Me.gbxBotones.Controls.Add(Me.chkNroFac)
        Me.gbxBotones.Controls.Add(Me.txtFecHasta)
        Me.gbxBotones.Controls.Add(Me.chkFecHasta)
        Me.gbxBotones.Controls.Add(Me.txtFecDesde)
        Me.gbxBotones.Controls.Add(Me.chkFecDesde)
        Me.gbxBotones.Location = New System.Drawing.Point(150, 3)
        Me.gbxBotones.Name = "gbxBotones"
        Me.gbxBotones.Size = New System.Drawing.Size(863, 116)
        Me.gbxBotones.TabIndex = 178
        Me.gbxBotones.TabStop = False
        '
        'cbxClaseFac
        '
        Me.cbxClaseFac.BackColor = System.Drawing.Color.LightGray
        Me.cbxClaseFac.Enabled = False
        Me.cbxClaseFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxClaseFac.FormattingEnabled = True
        Me.cbxClaseFac.Items.AddRange(New Object() {"A", "B", "X", "A y B", "A y X", "B y X"})
        Me.cbxClaseFac.Location = New System.Drawing.Point(570, 32)
        Me.cbxClaseFac.Name = "cbxClaseFac"
        Me.cbxClaseFac.Size = New System.Drawing.Size(135, 24)
        Me.cbxClaseFac.TabIndex = 21
        '
        'chkClaseFac
        '
        Me.chkClaseFac.AutoSize = True
        Me.chkClaseFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkClaseFac.ForeColor = System.Drawing.Color.LawnGreen
        Me.chkClaseFac.Location = New System.Drawing.Point(570, 12)
        Me.chkClaseFac.Name = "chkClaseFac"
        Me.chkClaseFac.Size = New System.Drawing.Size(104, 17)
        Me.chkClaseFac.TabIndex = 20
        Me.chkClaseFac.Text = "Clase Factura"
        Me.chkClaseFac.UseVisualStyleBackColor = True
        '
        'txtCdBarr
        '
        Me.txtCdBarr.BackColor = System.Drawing.Color.LightGray
        Me.txtCdBarr.Enabled = False
        Me.txtCdBarr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCdBarr.ForeColor = System.Drawing.Color.Black
        Me.txtCdBarr.Location = New System.Drawing.Point(711, 76)
        Me.txtCdBarr.Name = "txtCdBarr"
        Me.txtCdBarr.Size = New System.Drawing.Size(135, 22)
        Me.txtCdBarr.TabIndex = 19
        '
        'chkCdBarr
        '
        Me.chkCdBarr.AutoSize = True
        Me.chkCdBarr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCdBarr.ForeColor = System.Drawing.Color.LawnGreen
        Me.chkCdBarr.Location = New System.Drawing.Point(711, 56)
        Me.chkCdBarr.Name = "chkCdBarr"
        Me.chkCdBarr.Size = New System.Drawing.Size(126, 17)
        Me.chkCdBarr.TabIndex = 18
        Me.chkCdBarr.Text = "Cd. Barra Facrura"
        Me.chkCdBarr.UseVisualStyleBackColor = True
        '
        'txtCli
        '
        Me.txtCli.BackColor = System.Drawing.Color.LightGray
        Me.txtCli.Enabled = False
        Me.txtCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCli.ForeColor = System.Drawing.Color.Black
        Me.txtCli.Location = New System.Drawing.Point(288, 76)
        Me.txtCli.Name = "txtCli"
        Me.txtCli.Size = New System.Drawing.Size(202, 22)
        Me.txtCli.TabIndex = 15
        '
        'chkCli
        '
        Me.chkCli.AutoSize = True
        Me.chkCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCli.ForeColor = System.Drawing.Color.LawnGreen
        Me.chkCli.Location = New System.Drawing.Point(288, 56)
        Me.chkCli.Name = "chkCli"
        Me.chkCli.Size = New System.Drawing.Size(65, 17)
        Me.chkCli.TabIndex = 14
        Me.chkCli.Text = "Cliente"
        Me.chkCli.UseVisualStyleBackColor = True
        '
        'txtDet
        '
        Me.txtDet.BackColor = System.Drawing.Color.LightGray
        Me.txtDet.Enabled = False
        Me.txtDet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDet.ForeColor = System.Drawing.Color.Black
        Me.txtDet.Location = New System.Drawing.Point(496, 76)
        Me.txtDet.Name = "txtDet"
        Me.txtDet.Size = New System.Drawing.Size(209, 22)
        Me.txtDet.TabIndex = 17
        '
        'chkDet
        '
        Me.chkDet.AutoSize = True
        Me.chkDet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDet.ForeColor = System.Drawing.Color.LawnGreen
        Me.chkDet.Location = New System.Drawing.Point(498, 56)
        Me.chkDet.Name = "chkDet"
        Me.chkDet.Size = New System.Drawing.Size(66, 17)
        Me.chkDet.TabIndex = 16
        Me.chkDet.Text = "Detalle"
        Me.chkDet.UseVisualStyleBackColor = True
        '
        'txtCat
        '
        Me.txtCat.BackColor = System.Drawing.Color.LightGray
        Me.txtCat.Enabled = False
        Me.txtCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCat.ForeColor = System.Drawing.Color.Black
        Me.txtCat.Location = New System.Drawing.Point(147, 76)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.Size = New System.Drawing.Size(135, 22)
        Me.txtCat.TabIndex = 13
        '
        'chkCat
        '
        Me.chkCat.AutoSize = True
        Me.chkCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCat.ForeColor = System.Drawing.Color.LawnGreen
        Me.chkCat.Location = New System.Drawing.Point(147, 56)
        Me.chkCat.Name = "chkCat"
        Me.chkCat.Size = New System.Drawing.Size(82, 17)
        Me.chkCat.TabIndex = 12
        Me.chkCat.Text = "Categoría"
        Me.chkCat.UseVisualStyleBackColor = True
        '
        'txtSubR
        '
        Me.txtSubR.BackColor = System.Drawing.Color.LightGray
        Me.txtSubR.Enabled = False
        Me.txtSubR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubR.ForeColor = System.Drawing.Color.Black
        Me.txtSubR.Location = New System.Drawing.Point(6, 76)
        Me.txtSubR.Name = "txtSubR"
        Me.txtSubR.Size = New System.Drawing.Size(135, 22)
        Me.txtSubR.TabIndex = 11
        '
        'chkSubR
        '
        Me.chkSubR.AutoSize = True
        Me.chkSubR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSubR.ForeColor = System.Drawing.Color.LawnGreen
        Me.chkSubR.Location = New System.Drawing.Point(6, 56)
        Me.chkSubR.Name = "chkSubR"
        Me.chkSubR.Size = New System.Drawing.Size(86, 17)
        Me.chkSubR.TabIndex = 10
        Me.chkSubR.Text = "Sub Rubro"
        Me.chkSubR.UseVisualStyleBackColor = True
        '
        'txtRub
        '
        Me.txtRub.BackColor = System.Drawing.Color.LightGray
        Me.txtRub.Enabled = False
        Me.txtRub.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRub.ForeColor = System.Drawing.Color.Black
        Me.txtRub.Location = New System.Drawing.Point(711, 32)
        Me.txtRub.Name = "txtRub"
        Me.txtRub.Size = New System.Drawing.Size(135, 22)
        Me.txtRub.TabIndex = 9
        '
        'chkRub
        '
        Me.chkRub.AutoSize = True
        Me.chkRub.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRub.ForeColor = System.Drawing.Color.LawnGreen
        Me.chkRub.Location = New System.Drawing.Point(711, 12)
        Me.chkRub.Name = "chkRub"
        Me.chkRub.Size = New System.Drawing.Size(60, 17)
        Me.chkRub.TabIndex = 8
        Me.chkRub.Text = "Rubro"
        Me.chkRub.UseVisualStyleBackColor = True
        '
        'txtTipoFac
        '
        Me.txtTipoFac.BackColor = System.Drawing.Color.LightGray
        Me.txtTipoFac.Enabled = False
        Me.txtTipoFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoFac.ForeColor = System.Drawing.Color.Black
        Me.txtTipoFac.Location = New System.Drawing.Point(429, 32)
        Me.txtTipoFac.Name = "txtTipoFac"
        Me.txtTipoFac.Size = New System.Drawing.Size(135, 22)
        Me.txtTipoFac.TabIndex = 7
        '
        'chkTipoFac
        '
        Me.chkTipoFac.AutoSize = True
        Me.chkTipoFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTipoFac.ForeColor = System.Drawing.Color.LawnGreen
        Me.chkTipoFac.Location = New System.Drawing.Point(429, 12)
        Me.chkTipoFac.Name = "chkTipoFac"
        Me.chkTipoFac.Size = New System.Drawing.Size(98, 17)
        Me.chkTipoFac.TabIndex = 6
        Me.chkTipoFac.Text = "Tipo Factura"
        Me.chkTipoFac.UseVisualStyleBackColor = True
        '
        'txtNroFac
        '
        Me.txtNroFac.BackColor = System.Drawing.Color.LightGray
        Me.txtNroFac.Enabled = False
        Me.txtNroFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroFac.ForeColor = System.Drawing.Color.Black
        Me.txtNroFac.Location = New System.Drawing.Point(288, 32)
        Me.txtNroFac.Name = "txtNroFac"
        Me.txtNroFac.Size = New System.Drawing.Size(135, 22)
        Me.txtNroFac.TabIndex = 5
        Me.txtNroFac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkNroFac
        '
        Me.chkNroFac.AutoSize = True
        Me.chkNroFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNroFac.ForeColor = System.Drawing.Color.LawnGreen
        Me.chkNroFac.Location = New System.Drawing.Point(288, 12)
        Me.chkNroFac.Name = "chkNroFac"
        Me.chkNroFac.Size = New System.Drawing.Size(93, 17)
        Me.chkNroFac.TabIndex = 4
        Me.chkNroFac.Text = "Nro Factura"
        Me.chkNroFac.UseVisualStyleBackColor = True
        '
        'txtFecHasta
        '
        Me.txtFecHasta.BackColor = System.Drawing.Color.LightGray
        Me.txtFecHasta.Enabled = False
        Me.txtFecHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecHasta.ForeColor = System.Drawing.Color.Black
        Me.txtFecHasta.Location = New System.Drawing.Point(147, 32)
        Me.txtFecHasta.Name = "txtFecHasta"
        Me.txtFecHasta.Size = New System.Drawing.Size(135, 22)
        Me.txtFecHasta.TabIndex = 3
        Me.txtFecHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkFecHasta
        '
        Me.chkFecHasta.AutoSize = True
        Me.chkFecHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFecHasta.ForeColor = System.Drawing.Color.LawnGreen
        Me.chkFecHasta.Location = New System.Drawing.Point(147, 12)
        Me.chkFecHasta.Name = "chkFecHasta"
        Me.chkFecHasta.Size = New System.Drawing.Size(98, 17)
        Me.chkFecHasta.TabIndex = 2
        Me.chkFecHasta.Text = "Fecha Hasta"
        Me.chkFecHasta.UseVisualStyleBackColor = True
        '
        'txtFecDesde
        '
        Me.txtFecDesde.BackColor = System.Drawing.Color.LightGray
        Me.txtFecDesde.Enabled = False
        Me.txtFecDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecDesde.ForeColor = System.Drawing.Color.Black
        Me.txtFecDesde.Location = New System.Drawing.Point(6, 32)
        Me.txtFecDesde.Name = "txtFecDesde"
        Me.txtFecDesde.Size = New System.Drawing.Size(135, 22)
        Me.txtFecDesde.TabIndex = 1
        Me.txtFecDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkFecDesde
        '
        Me.chkFecDesde.AutoSize = True
        Me.chkFecDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFecDesde.ForeColor = System.Drawing.Color.LawnGreen
        Me.chkFecDesde.Location = New System.Drawing.Point(6, 12)
        Me.chkFecDesde.Name = "chkFecDesde"
        Me.chkFecDesde.Size = New System.Drawing.Size(101, 17)
        Me.chkFecDesde.TabIndex = 0
        Me.chkFecDesde.Text = "Fecha Desde"
        Me.chkFecDesde.UseVisualStyleBackColor = True
        '
        'gbxDataGrid
        '
        Me.gbxDataGrid.BackColor = System.Drawing.Color.Transparent
        Me.gbxDataGrid.Controls.Add(Me.dgvVentas)
        Me.gbxDataGrid.Location = New System.Drawing.Point(12, 147)
        Me.gbxDataGrid.Name = "gbxDataGrid"
        Me.gbxDataGrid.Size = New System.Drawing.Size(1202, 415)
        Me.gbxDataGrid.TabIndex = 188
        Me.gbxDataGrid.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label1.Location = New System.Drawing.Point(279, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 22)
        Me.Label1.TabIndex = 190
        Me.Label1.Text = "Cantidad ="
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCant
        '
        Me.lblCant.BackColor = System.Drawing.Color.Transparent
        Me.lblCant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCant.ForeColor = System.Drawing.Color.Gold
        Me.lblCant.Location = New System.Drawing.Point(367, 125)
        Me.lblCant.Name = "lblCant"
        Me.lblCant.Size = New System.Drawing.Size(73, 22)
        Me.lblCant.TabIndex = 189
        Me.lblCant.Text = "0"
        Me.lblCant.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label2.Location = New System.Drawing.Point(446, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 22)
        Me.Label2.TabIndex = 192
        Me.Label2.Text = "SubTotal ="
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubT
        '
        Me.lblSubT.BackColor = System.Drawing.Color.Transparent
        Me.lblSubT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubT.ForeColor = System.Drawing.Color.Gold
        Me.lblSubT.Location = New System.Drawing.Point(534, 125)
        Me.lblSubT.Name = "lblSubT"
        Me.lblSubT.Size = New System.Drawing.Size(126, 22)
        Me.lblSubT.TabIndex = 191
        Me.lblSubT.Text = "0"
        Me.lblSubT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label3.Location = New System.Drawing.Point(666, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 22)
        Me.Label3.TabIndex = 194
        Me.Label3.Text = "Iva ="
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIva
        '
        Me.lblIva.BackColor = System.Drawing.Color.Transparent
        Me.lblIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIva.ForeColor = System.Drawing.Color.Gold
        Me.lblIva.Location = New System.Drawing.Point(712, 125)
        Me.lblIva.Name = "lblIva"
        Me.lblIva.Size = New System.Drawing.Size(96, 22)
        Me.lblIva.TabIndex = 193
        Me.lblIva.Text = "0"
        Me.lblIva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label6.Location = New System.Drawing.Point(814, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 22)
        Me.Label6.TabIndex = 196
        Me.Label6.Text = "Total ="
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Gold
        Me.lblTotal.Location = New System.Drawing.Point(874, 125)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(139, 22)
        Me.lblTotal.TabIndex = 195
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgvVentas
        '
        Me.dgvVentas.AllowUserToAddRows = False
        Me.dgvVentas.AllowUserToDeleteRows = False
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Location = New System.Drawing.Point(8, 13)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.ReadOnly = True
        Me.dgvVentas.Size = New System.Drawing.Size(1188, 396)
        Me.dgvVentas.TabIndex = 0
        '
        'frmConsVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ByB_SI.My.Resources.Resources.Fondo_23___Reducido
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1220, 574)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblIva)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblSubT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCant)
        Me.Controls.Add(Me.gbxDataGrid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnImpComprobante)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgvCliente)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnTodo)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.lblReg)
        Me.Controls.Add(Me.gbxBotones)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConsVentas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxBotones.ResumeLayout(False)
        Me.gbxBotones.PerformLayout()
        Me.gbxDataGrid.ResumeLayout(False)
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnImpComprobante As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnTodo As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents lblReg As System.Windows.Forms.Label
    Friend WithEvents gbxBotones As System.Windows.Forms.GroupBox
    Friend WithEvents gbxDataGrid As System.Windows.Forms.GroupBox
    Friend WithEvents txtFecHasta As System.Windows.Forms.TextBox
    Friend WithEvents chkFecHasta As System.Windows.Forms.CheckBox
    Friend WithEvents txtFecDesde As System.Windows.Forms.TextBox
    Friend WithEvents chkFecDesde As System.Windows.Forms.CheckBox
    Friend WithEvents txtNroFac As System.Windows.Forms.TextBox
    Friend WithEvents chkNroFac As System.Windows.Forms.CheckBox
    Friend WithEvents txtTipoFac As System.Windows.Forms.TextBox
    Friend WithEvents chkTipoFac As System.Windows.Forms.CheckBox
    Friend WithEvents txtRub As System.Windows.Forms.TextBox
    Friend WithEvents chkRub As System.Windows.Forms.CheckBox
    Friend WithEvents txtSubR As System.Windows.Forms.TextBox
    Friend WithEvents chkSubR As System.Windows.Forms.CheckBox
    Friend WithEvents txtCat As System.Windows.Forms.TextBox
    Friend WithEvents chkCat As System.Windows.Forms.CheckBox
    Friend WithEvents txtCdBarr As System.Windows.Forms.TextBox
    Friend WithEvents chkCdBarr As System.Windows.Forms.CheckBox
    Friend WithEvents txtCli As System.Windows.Forms.TextBox
    Friend WithEvents chkCli As System.Windows.Forms.CheckBox
    Friend WithEvents txtDet As System.Windows.Forms.TextBox
    Friend WithEvents chkDet As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCant As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblSubT As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblIva As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents cbxClaseFac As System.Windows.Forms.ComboBox
    Friend WithEvents chkClaseFac As System.Windows.Forms.CheckBox
    Friend WithEvents dgvVentas As System.Windows.Forms.DataGridView
End Class
