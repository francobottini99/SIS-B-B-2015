<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStock))
        Me.btnResta = New System.Windows.Forms.Button()
        Me.lblFuncion = New System.Windows.Forms.Label()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCdEmp = New System.Windows.Forms.TextBox()
        Me.tmrMensaje = New System.Windows.Forms.Timer(Me.components)
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtCodCategoria = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtCdBarra = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.gbxStock = New System.Windows.Forms.GroupBox()
        Me.dgvStock = New System.Windows.Forms.DataGridView()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.gbxArticulos = New System.Windows.Forms.GroupBox()
        Me.txtCantAnt = New System.Windows.Forms.TextBox()
        Me.dgvArticulos = New System.Windows.Forms.DataGridView()
        Me.lblIdStk = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtArtSeleccionado = New System.Windows.Forms.TextBox()
        Me.txtFecAlta = New System.Windows.Forms.TextBox()
        Me.lblOperacion = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.lblTotalStk = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxStock.SuspendLayout()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxArticulos.SuspendLayout()
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnResta
        '
        Me.btnResta.BackgroundImage = Global.ByB_SI.My.Resources.Resources.RestarIn
        Me.btnResta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnResta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnResta.Location = New System.Drawing.Point(924, 85)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(61, 59)
        Me.btnResta.TabIndex = 6
        Me.btnResta.Tag = ""
        Me.btnResta.UseVisualStyleBackColor = True
        '
        'lblFuncion
        '
        Me.lblFuncion.Location = New System.Drawing.Point(817, 366)
        Me.lblFuncion.Name = "lblFuncion"
        Me.lblFuncion.Size = New System.Drawing.Size(74, 20)
        Me.lblFuncion.TabIndex = 31
        Me.lblFuncion.Visible = False
        '
        'btnSuma
        '
        Me.btnSuma.BackgroundImage = Global.ByB_SI.My.Resources.Resources.AgregarIn
        Me.btnSuma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSuma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSuma.Location = New System.Drawing.Point(924, 19)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(61, 59)
        Me.btnSuma.TabIndex = 5
        Me.btnSuma.Tag = ""
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = Global.ByB_SI.My.Resources.Resources.SalirIn
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Location = New System.Drawing.Point(924, 424)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(61, 61)
        Me.btnSalir.TabIndex = 8
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
        Me.btnGuardar.Location = New System.Drawing.Point(924, 216)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(61, 60)
        Me.btnGuardar.TabIndex = 3
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
        Me.btnCancelar.Location = New System.Drawing.Point(924, 282)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(61, 60)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Tag = ""
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCdEmp)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.LawnGreen
        Me.GroupBox1.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(165, 54)
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
        Me.txtCdEmp.Location = New System.Drawing.Point(6, 18)
        Me.txtCdEmp.Name = "txtCdEmp"
        Me.txtCdEmp.Size = New System.Drawing.Size(153, 26)
        Me.txtCdEmp.TabIndex = 9
        Me.txtCdEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tmrMensaje
        '
        Me.tmrMensaje.Interval = 5000
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.Transparent
        Me.lblMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Location = New System.Drawing.Point(408, 282)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(507, 33)
        Me.lblMsg.TabIndex = 70
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label8.Location = New System.Drawing.Point(725, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 16)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Cantidad"
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCantidad.Location = New System.Drawing.Point(728, 228)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(169, 26)
        Me.txtCantidad.TabIndex = 2
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCodCategoria
        '
        Me.txtCodCategoria.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCodCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCategoria.ForeColor = System.Drawing.Color.Teal
        Me.txtCodCategoria.Location = New System.Drawing.Point(9, 148)
        Me.txtCodCategoria.Name = "txtCodCategoria"
        Me.txtCodCategoria.Size = New System.Drawing.Size(134, 22)
        Me.txtCodCategoria.TabIndex = 1
        Me.txtCodCategoria.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label5.Location = New System.Drawing.Point(393, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 16)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Código de Barra"
        '
        'lblId
        '
        Me.lblId.BackColor = System.Drawing.SystemColors.Control
        Me.lblId.Location = New System.Drawing.Point(6, 125)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(74, 20)
        Me.lblId.TabIndex = 32
        Me.lblId.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Image = Global.ByB_SI.My.Resources.Resources.Stock
        Me.PictureBox1.Location = New System.Drawing.Point(9, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'txtCdBarra
        '
        Me.txtCdBarra.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCdBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCdBarra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCdBarra.Location = New System.Drawing.Point(396, 228)
        Me.txtCdBarra.Name = "txtCdBarra"
        Me.txtCdBarra.Size = New System.Drawing.Size(326, 26)
        Me.txtCdBarra.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label15.Location = New System.Drawing.Point(180, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(116, 16)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "Buscar Artículo:"
        '
        'gbxStock
        '
        Me.gbxStock.BackColor = System.Drawing.Color.Transparent
        Me.gbxStock.Controls.Add(Me.dgvStock)
        Me.gbxStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxStock.ForeColor = System.Drawing.Color.LawnGreen
        Me.gbxStock.Location = New System.Drawing.Point(12, 278)
        Me.gbxStock.Name = "gbxStock"
        Me.gbxStock.Size = New System.Drawing.Size(390, 197)
        Me.gbxStock.TabIndex = 45
        Me.gbxStock.TabStop = False
        '
        'dgvStock
        '
        Me.dgvStock.AllowUserToAddRows = False
        Me.dgvStock.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvStock.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.LawnGreen
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStock.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvStock.Location = New System.Drawing.Point(6, 15)
        Me.dgvStock.Name = "dgvStock"
        Me.dgvStock.ReadOnly = True
        Me.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStock.Size = New System.Drawing.Size(378, 173)
        Me.dgvStock.TabIndex = 12
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.ForeColor = System.Drawing.Color.Teal
        Me.txtBuscar.Location = New System.Drawing.Point(180, 34)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(717, 22)
        Me.txtBuscar.TabIndex = 0
        '
        'gbxArticulos
        '
        Me.gbxArticulos.BackColor = System.Drawing.Color.Transparent
        Me.gbxArticulos.Controls.Add(Me.txtCantAnt)
        Me.gbxArticulos.Controls.Add(Me.dgvArticulos)
        Me.gbxArticulos.Controls.Add(Me.lblIdStk)
        Me.gbxArticulos.Controls.Add(Me.Label3)
        Me.gbxArticulos.Controls.Add(Me.Label1)
        Me.gbxArticulos.Controls.Add(Me.txtArtSeleccionado)
        Me.gbxArticulos.Controls.Add(Me.txtFecAlta)
        Me.gbxArticulos.Controls.Add(Me.lblOperacion)
        Me.gbxArticulos.Controls.Add(Me.Label15)
        Me.gbxArticulos.Controls.Add(Me.txtBuscar)
        Me.gbxArticulos.Controls.Add(Me.GroupBox1)
        Me.gbxArticulos.Controls.Add(Me.lblFuncion)
        Me.gbxArticulos.Controls.Add(Me.Label8)
        Me.gbxArticulos.Controls.Add(Me.txtCodCategoria)
        Me.gbxArticulos.Controls.Add(Me.txtCantidad)
        Me.gbxArticulos.Controls.Add(Me.Label5)
        Me.gbxArticulos.Controls.Add(Me.lblId)
        Me.gbxArticulos.Controls.Add(Me.PictureBox1)
        Me.gbxArticulos.Controls.Add(Me.txtCdBarra)
        Me.gbxArticulos.Enabled = False
        Me.gbxArticulos.Location = New System.Drawing.Point(12, 12)
        Me.gbxArticulos.Name = "gbxArticulos"
        Me.gbxArticulos.Size = New System.Drawing.Size(903, 260)
        Me.gbxArticulos.TabIndex = 44
        Me.gbxArticulos.TabStop = False
        '
        'txtCantAnt
        '
        Me.txtCantAnt.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCantAnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantAnt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCantAnt.Location = New System.Drawing.Point(6, 62)
        Me.txtCantAnt.Name = "txtCantAnt"
        Me.txtCantAnt.Size = New System.Drawing.Size(169, 26)
        Me.txtCantAnt.TabIndex = 68
        Me.txtCantAnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantAnt.Visible = False
        '
        'dgvArticulos
        '
        Me.dgvArticulos.AllowUserToAddRows = False
        Me.dgvArticulos.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.dgvArticulos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvArticulos.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvArticulos.Location = New System.Drawing.Point(180, 62)
        Me.dgvArticulos.Name = "dgvArticulos"
        Me.dgvArticulos.ReadOnly = True
        Me.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvArticulos.Size = New System.Drawing.Size(717, 136)
        Me.dgvArticulos.TabIndex = 67
        '
        'lblIdStk
        '
        Me.lblIdStk.BackColor = System.Drawing.SystemColors.Control
        Me.lblIdStk.Location = New System.Drawing.Point(6, 94)
        Me.lblIdStk.Name = "lblIdStk"
        Me.lblIdStk.Size = New System.Drawing.Size(74, 20)
        Me.lblIdStk.TabIndex = 33
        Me.lblIdStk.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label3.Location = New System.Drawing.Point(690, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Función:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label1.Location = New System.Drawing.Point(6, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 16)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Artículo Seleccionado"
        '
        'txtArtSeleccionado
        '
        Me.txtArtSeleccionado.BackColor = System.Drawing.Color.DimGray
        Me.txtArtSeleccionado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArtSeleccionado.ForeColor = System.Drawing.Color.White
        Me.txtArtSeleccionado.Location = New System.Drawing.Point(9, 228)
        Me.txtArtSeleccionado.Name = "txtArtSeleccionado"
        Me.txtArtSeleccionado.Size = New System.Drawing.Size(381, 26)
        Me.txtArtSeleccionado.TabIndex = 64
        '
        'txtFecAlta
        '
        Me.txtFecAlta.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtFecAlta.Enabled = False
        Me.txtFecAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecAlta.ForeColor = System.Drawing.Color.Teal
        Me.txtFecAlta.Location = New System.Drawing.Point(9, 176)
        Me.txtFecAlta.Name = "txtFecAlta"
        Me.txtFecAlta.Size = New System.Drawing.Size(134, 22)
        Me.txtFecAlta.TabIndex = 63
        Me.txtFecAlta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtFecAlta.Visible = False
        '
        'lblOperacion
        '
        Me.lblOperacion.BackColor = System.Drawing.Color.Gold
        Me.lblOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperacion.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblOperacion.Location = New System.Drawing.Point(762, 11)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(135, 23)
        Me.lblOperacion.TabIndex = 62
        Me.lblOperacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnModificar
        '
        Me.btnModificar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.ModifIn
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnModificar.Location = New System.Drawing.Point(924, 151)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(61, 59)
        Me.btnModificar.TabIndex = 71
        Me.btnModificar.Tag = ""
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'lblTotalStk
        '
        Me.lblTotalStk.BackColor = System.Drawing.Color.DimGray
        Me.lblTotalStk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalStk.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalStk.ForeColor = System.Drawing.Color.White
        Me.lblTotalStk.Location = New System.Drawing.Point(411, 443)
        Me.lblTotalStk.Name = "lblTotalStk"
        Me.lblTotalStk.Size = New System.Drawing.Size(171, 30)
        Me.lblTotalStk.TabIndex = 72
        Me.lblTotalStk.Text = "0.00"
        Me.lblTotalStk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label2.Location = New System.Drawing.Point(408, 424)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "STOCK"
        '
        'frmStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ByB_SI.My.Resources.Resources.Fondo_23___Reducido1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(993, 488)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTotalStk)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.btnResta)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.gbxStock)
        Me.Controls.Add(Me.gbxArticulos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStock"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxStock.ResumeLayout(False)
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxArticulos.ResumeLayout(False)
        Me.gbxArticulos.PerformLayout()
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnResta As System.Windows.Forms.Button
    Friend WithEvents lblFuncion As System.Windows.Forms.Label
    Friend WithEvents btnSuma As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCdEmp As System.Windows.Forms.TextBox
    Friend WithEvents tmrMensaje As System.Windows.Forms.Timer
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtCodCategoria As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtCdBarra As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents gbxStock As System.Windows.Forms.GroupBox
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents gbxArticulos As System.Windows.Forms.GroupBox
    Friend WithEvents lblOperacion As System.Windows.Forms.Label
    Friend WithEvents txtFecAlta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtArtSeleccionado As System.Windows.Forms.TextBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblIdStk As System.Windows.Forms.Label
    Friend WithEvents dgvArticulos As System.Windows.Forms.DataGridView
    Friend WithEvents dgvStock As System.Windows.Forms.DataGridView
    Friend WithEvents lblTotalStk As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCantAnt As System.Windows.Forms.TextBox
End Class
