<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpresa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpresa))
        Me.lblFuncion = New System.Windows.Forms.Label()
        Me.tmrMensaje = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblIdUs = New System.Windows.Forms.Label()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.cbxCatIva = New System.Windows.Forms.ComboBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gbxUsuarios = New System.Windows.Forms.GroupBox()
        Me.txtCodEmpresa = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnLogo = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtEslogan = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtIIBB = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtFechaInicio = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCuit = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPropietario = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtWeb = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtTE = New System.Windows.Forms.TextBox()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.txtProvincia = New System.Windows.Forms.TextBox()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.ofdImagen = New System.Windows.Forms.OpenFileDialog()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.gbxDatagrid = New System.Windows.Forms.GroupBox()
        Me.dgvEmpresas = New System.Windows.Forms.DataGridView()
        Me.gbxUsuarios.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatagrid.SuspendLayout()
        CType(Me.dgvEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFuncion
        '
        Me.lblFuncion.Location = New System.Drawing.Point(721, 558)
        Me.lblFuncion.Name = "lblFuncion"
        Me.lblFuncion.Size = New System.Drawing.Size(74, 20)
        Me.lblFuncion.TabIndex = 31
        Me.lblFuncion.Visible = False
        '
        'tmrMensaje
        '
        Me.tmrMensaje.Interval = 5000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label1.Location = New System.Drawing.Point(177, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Razón Social"
        '
        'lblIdUs
        '
        Me.lblIdUs.Location = New System.Drawing.Point(641, 558)
        Me.lblIdUs.Name = "lblIdUs"
        Me.lblIdUs.Size = New System.Drawing.Size(74, 20)
        Me.lblIdUs.TabIndex = 32
        Me.lblIdUs.Visible = False
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.Transparent
        Me.lblMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Location = New System.Drawing.Point(617, 427)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(260, 59)
        Me.lblMsg.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label3.Location = New System.Drawing.Point(177, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Dirección"
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ForeColor = System.Drawing.Color.Teal
        Me.txtDireccion.Location = New System.Drawing.Point(283, 45)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(582, 22)
        Me.txtDireccion.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label2.Location = New System.Drawing.Point(177, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Localidad"
        '
        'btnModificar
        '
        Me.btnModificar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.ModifIn
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnModificar.Location = New System.Drawing.Point(682, 365)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(61, 59)
        Me.btnModificar.TabIndex = 18
        Me.btnModificar.Tag = ""
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'cbxCatIva
        '
        Me.cbxCatIva.BackColor = System.Drawing.Color.MediumTurquoise
        Me.cbxCatIva.Enabled = False
        Me.cbxCatIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCatIva.ForeColor = System.Drawing.Color.Teal
        Me.cbxCatIva.FormattingEnabled = True
        Me.cbxCatIva.Items.AddRange(New Object() {"Responsable Inscripto", "Monotributo"})
        Me.cbxCatIva.Location = New System.Drawing.Point(90, 245)
        Me.cbxCatIva.Name = "cbxCatIva"
        Me.cbxCatIva.Size = New System.Drawing.Size(256, 24)
        Me.cbxCatIva.TabIndex = 12
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.CancelarIn
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCancelar.Location = New System.Drawing.Point(816, 364)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(61, 60)
        Me.btnCancelar.TabIndex = 20
        Me.btnCancelar.Tag = ""
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.GuardarIn
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnGuardar.Location = New System.Drawing.Point(749, 364)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(61, 60)
        Me.btnGuardar.TabIndex = 19
        Me.btnGuardar.Tag = ""
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label4.Location = New System.Drawing.Point(177, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Código Postal"
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = Global.ByB_SI.My.Resources.Resources.SalirIn
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Location = New System.Drawing.Point(801, 507)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(76, 71)
        Me.btnSalir.TabIndex = 21
        Me.btnSalir.Tag = ""
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'gbxUsuarios
        '
        Me.gbxUsuarios.BackColor = System.Drawing.Color.Transparent
        Me.gbxUsuarios.Controls.Add(Me.txtCodEmpresa)
        Me.gbxUsuarios.Controls.Add(Me.Label17)
        Me.gbxUsuarios.Controls.Add(Me.btnLogo)
        Me.gbxUsuarios.Controls.Add(Me.Label16)
        Me.gbxUsuarios.Controls.Add(Me.Label15)
        Me.gbxUsuarios.Controls.Add(Me.txtEslogan)
        Me.gbxUsuarios.Controls.Add(Me.Label14)
        Me.gbxUsuarios.Controls.Add(Me.txtIIBB)
        Me.gbxUsuarios.Controls.Add(Me.Label13)
        Me.gbxUsuarios.Controls.Add(Me.txtFechaInicio)
        Me.gbxUsuarios.Controls.Add(Me.Label12)
        Me.gbxUsuarios.Controls.Add(Me.txtCuit)
        Me.gbxUsuarios.Controls.Add(Me.Label11)
        Me.gbxUsuarios.Controls.Add(Me.txtPropietario)
        Me.gbxUsuarios.Controls.Add(Me.Label10)
        Me.gbxUsuarios.Controls.Add(Me.txtWeb)
        Me.gbxUsuarios.Controls.Add(Me.Label9)
        Me.gbxUsuarios.Controls.Add(Me.txtMail)
        Me.gbxUsuarios.Controls.Add(Me.txtTE)
        Me.gbxUsuarios.Controls.Add(Me.txtPais)
        Me.gbxUsuarios.Controls.Add(Me.txtProvincia)
        Me.gbxUsuarios.Controls.Add(Me.txtCP)
        Me.gbxUsuarios.Controls.Add(Me.Label5)
        Me.gbxUsuarios.Controls.Add(Me.Label6)
        Me.gbxUsuarios.Controls.Add(Me.Label7)
        Me.gbxUsuarios.Controls.Add(Me.Label8)
        Me.gbxUsuarios.Controls.Add(Me.pbxLogo)
        Me.gbxUsuarios.Controls.Add(Me.txtLocalidad)
        Me.gbxUsuarios.Controls.Add(Me.Label4)
        Me.gbxUsuarios.Controls.Add(Me.cbxCatIva)
        Me.gbxUsuarios.Controls.Add(Me.Label3)
        Me.gbxUsuarios.Controls.Add(Me.txtDireccion)
        Me.gbxUsuarios.Controls.Add(Me.Label2)
        Me.gbxUsuarios.Controls.Add(Me.txtRazonSocial)
        Me.gbxUsuarios.Controls.Add(Me.Label1)
        Me.gbxUsuarios.Location = New System.Drawing.Point(6, 12)
        Me.gbxUsuarios.Name = "gbxUsuarios"
        Me.gbxUsuarios.Size = New System.Drawing.Size(871, 344)
        Me.gbxUsuarios.TabIndex = 23
        Me.gbxUsuarios.TabStop = False
        '
        'txtCodEmpresa
        '
        Me.txtCodEmpresa.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCodEmpresa.Enabled = False
        Me.txtCodEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodEmpresa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCodEmpresa.Location = New System.Drawing.Point(668, 101)
        Me.txtCodEmpresa.Name = "txtCodEmpresa"
        Me.txtCodEmpresa.Size = New System.Drawing.Size(197, 26)
        Me.txtCodEmpresa.TabIndex = 4
        Me.txtCodEmpresa.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label17.Location = New System.Drawing.Point(538, 107)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(124, 16)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "Codigo Empresa"
        Me.Label17.Visible = False
        '
        'btnLogo
        '
        Me.btnLogo.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnLogo.Enabled = False
        Me.btnLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogo.Location = New System.Drawing.Point(90, 303)
        Me.btnLogo.Name = "btnLogo"
        Me.btnLogo.Size = New System.Drawing.Size(104, 34)
        Me.btnLogo.TabIndex = 16
        Me.btnLogo.Text = "Agregar Logo"
        Me.btnLogo.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label16.Location = New System.Drawing.Point(6, 312)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 16)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "Logotipo"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label15.Location = New System.Drawing.Point(6, 278)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 16)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "Eslogan"
        '
        'txtEslogan
        '
        Me.txtEslogan.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtEslogan.Enabled = False
        Me.txtEslogan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEslogan.ForeColor = System.Drawing.Color.Teal
        Me.txtEslogan.Location = New System.Drawing.Point(90, 275)
        Me.txtEslogan.Name = "txtEslogan"
        Me.txtEslogan.Size = New System.Drawing.Size(775, 22)
        Me.txtEslogan.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label14.Location = New System.Drawing.Point(595, 248)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 16)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "II. BB."
        '
        'txtIIBB
        '
        Me.txtIIBB.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtIIBB.Enabled = False
        Me.txtIIBB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIIBB.ForeColor = System.Drawing.Color.Teal
        Me.txtIIBB.Location = New System.Drawing.Point(646, 247)
        Me.txtIIBB.Name = "txtIIBB"
        Me.txtIIBB.Size = New System.Drawing.Size(219, 22)
        Me.txtIIBB.TabIndex = 14
        Me.txtIIBB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label13.Location = New System.Drawing.Point(359, 248)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 16)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Inicio Activ."
        '
        'txtFechaInicio
        '
        Me.txtFechaInicio.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtFechaInicio.Enabled = False
        Me.txtFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaInicio.ForeColor = System.Drawing.Color.Teal
        Me.txtFechaInicio.Location = New System.Drawing.Point(452, 245)
        Me.txtFechaInicio.Name = "txtFechaInicio"
        Me.txtFechaInicio.Size = New System.Drawing.Size(129, 22)
        Me.txtFechaInicio.TabIndex = 13
        Me.txtFechaInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label12.Location = New System.Drawing.Point(6, 248)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 16)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "IVA"
        '
        'txtCuit
        '
        Me.txtCuit.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCuit.Enabled = False
        Me.txtCuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuit.ForeColor = System.Drawing.Color.Teal
        Me.txtCuit.Location = New System.Drawing.Point(646, 220)
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.Size = New System.Drawing.Size(219, 22)
        Me.txtCuit.TabIndex = 11
        Me.txtCuit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label11.Location = New System.Drawing.Point(600, 223)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 16)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "CUIT"
        '
        'txtPropietario
        '
        Me.txtPropietario.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtPropietario.Enabled = False
        Me.txtPropietario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropietario.ForeColor = System.Drawing.Color.Teal
        Me.txtPropietario.Location = New System.Drawing.Point(90, 217)
        Me.txtPropietario.Name = "txtPropietario"
        Me.txtPropietario.Size = New System.Drawing.Size(491, 22)
        Me.txtPropietario.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label10.Location = New System.Drawing.Point(6, 223)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 16)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Propietario"
        '
        'txtWeb
        '
        Me.txtWeb.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtWeb.Enabled = False
        Me.txtWeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeb.ForeColor = System.Drawing.Color.Teal
        Me.txtWeb.Location = New System.Drawing.Point(646, 192)
        Me.txtWeb.Name = "txtWeb"
        Me.txtWeb.Size = New System.Drawing.Size(219, 22)
        Me.txtWeb.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label9.Location = New System.Drawing.Point(600, 195)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 16)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Web"
        '
        'txtMail
        '
        Me.txtMail.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtMail.Enabled = False
        Me.txtMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.ForeColor = System.Drawing.Color.Teal
        Me.txtMail.Location = New System.Drawing.Point(362, 189)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(219, 22)
        Me.txtMail.TabIndex = 8
        '
        'txtTE
        '
        Me.txtTE.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtTE.Enabled = False
        Me.txtTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTE.ForeColor = System.Drawing.Color.Teal
        Me.txtTE.Location = New System.Drawing.Point(90, 189)
        Me.txtTE.Name = "txtTE"
        Me.txtTE.Size = New System.Drawing.Size(219, 22)
        Me.txtTE.TabIndex = 7
        '
        'txtPais
        '
        Me.txtPais.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtPais.Enabled = False
        Me.txtPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPais.ForeColor = System.Drawing.Color.Teal
        Me.txtPais.Location = New System.Drawing.Point(283, 157)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(216, 22)
        Me.txtPais.TabIndex = 6
        '
        'txtProvincia
        '
        Me.txtProvincia.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtProvincia.Enabled = False
        Me.txtProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvincia.ForeColor = System.Drawing.Color.Teal
        Me.txtProvincia.Location = New System.Drawing.Point(283, 129)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(216, 22)
        Me.txtProvincia.TabIndex = 5
        '
        'txtCP
        '
        Me.txtCP.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCP.Enabled = False
        Me.txtCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCP.ForeColor = System.Drawing.Color.Teal
        Me.txtCP.Location = New System.Drawing.Point(283, 101)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(162, 22)
        Me.txtCP.TabIndex = 3
        Me.txtCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label5.Location = New System.Drawing.Point(319, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 16)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Mail"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label6.Location = New System.Drawing.Point(177, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 16)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "País"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label7.Location = New System.Drawing.Point(6, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 16)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Teléfono"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label8.Location = New System.Drawing.Point(177, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 16)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Provincia"
        '
        'pbxLogo
        '
        Me.pbxLogo.Image = Global.ByB_SI.My.Resources.Resources.Empresa
        Me.pbxLogo.Location = New System.Drawing.Point(6, 9)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(165, 167)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxLogo.TabIndex = 23
        Me.pbxLogo.TabStop = False
        '
        'txtLocalidad
        '
        Me.txtLocalidad.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtLocalidad.Enabled = False
        Me.txtLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalidad.ForeColor = System.Drawing.Color.Teal
        Me.txtLocalidad.Location = New System.Drawing.Point(283, 73)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(582, 22)
        Me.txtLocalidad.TabIndex = 2
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtRazonSocial.Enabled = False
        Me.txtRazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtRazonSocial.Location = New System.Drawing.Point(283, 13)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(582, 26)
        Me.txtRazonSocial.TabIndex = 0
        '
        'ofdImagen
        '
        Me.ofdImagen.FileName = "OpenFileDialog1"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackgroundImage = Global.ByB_SI.My.Resources.Resources.NuevoIn
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnNuevo.Location = New System.Drawing.Point(617, 364)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(61, 59)
        Me.btnNuevo.TabIndex = 17
        Me.btnNuevo.Tag = ""
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'gbxDatagrid
        '
        Me.gbxDatagrid.BackColor = System.Drawing.Color.Transparent
        Me.gbxDatagrid.Controls.Add(Me.dgvEmpresas)
        Me.gbxDatagrid.Location = New System.Drawing.Point(6, 364)
        Me.gbxDatagrid.Name = "gbxDatagrid"
        Me.gbxDatagrid.Size = New System.Drawing.Size(605, 214)
        Me.gbxDatagrid.TabIndex = 34
        Me.gbxDatagrid.TabStop = False
        '
        'dgvEmpresas
        '
        Me.dgvEmpresas.AllowUserToAddRows = False
        Me.dgvEmpresas.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvEmpresas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEmpresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvEmpresas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEmpresas.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEmpresas.Location = New System.Drawing.Point(6, 13)
        Me.dgvEmpresas.Name = "dgvEmpresas"
        Me.dgvEmpresas.ReadOnly = True
        Me.dgvEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmpresas.Size = New System.Drawing.Size(593, 195)
        Me.dgvEmpresas.TabIndex = 22
        '
        'frmEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ByB_SI.My.Resources.Resources.Fondo_23___Reducido
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 586)
        Me.Controls.Add(Me.gbxDatagrid)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.lblFuncion)
        Me.Controls.Add(Me.lblIdUs)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.gbxUsuarios)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEmpresa"
        Me.gbxUsuarios.ResumeLayout(False)
        Me.gbxUsuarios.PerformLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatagrid.ResumeLayout(False)
        CType(Me.dgvEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblFuncion As System.Windows.Forms.Label
    Friend WithEvents tmrMensaje As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblIdUs As System.Windows.Forms.Label
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents cbxCatIva As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents gbxUsuarios As System.Windows.Forms.GroupBox
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents pbxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents txtPais As System.Windows.Forms.TextBox
    Friend WithEvents txtProvincia As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents txtTE As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtFechaInicio As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCuit As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPropietario As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtEslogan As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtIIBB As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnLogo As System.Windows.Forms.Button
    Friend WithEvents ofdImagen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtWeb As System.Windows.Forms.TextBox
    Friend WithEvents txtLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents gbxDatagrid As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dgvEmpresas As System.Windows.Forms.DataGridView
End Class
