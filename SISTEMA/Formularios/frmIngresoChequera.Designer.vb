<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresoChequera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIngresoChequera))
        Me.txtNroChq = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.tmrMensaje = New System.Windows.Forms.Timer(Me.components)
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblFuncion = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gbxClientes = New System.Windows.Forms.GroupBox()
        Me.txtSucursal = New System.Windows.Forms.TextBox()
        Me.cbxBanco = New System.Windows.Forms.ComboBox()
        Me.txtCta = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTitular = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFecAlta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbxClientes.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNroChq
        '
        Me.txtNroChq.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtNroChq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroChq.ForeColor = System.Drawing.Color.Teal
        Me.txtNroChq.Location = New System.Drawing.Point(316, 163)
        Me.txtNroChq.Name = "txtNroChq"
        Me.txtNroChq.Size = New System.Drawing.Size(134, 22)
        Me.txtNroChq.TabIndex = 5
        Me.txtNroChq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label9.Location = New System.Drawing.Point(180, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 16)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "Cantidad"
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCantidad.Enabled = False
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.ForeColor = System.Drawing.Color.Teal
        Me.txtCantidad.Location = New System.Drawing.Point(316, 193)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(76, 26)
        Me.txtCantidad.TabIndex = 6
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label3.Location = New System.Drawing.Point(180, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Numero Inic."
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.Transparent
        Me.lblMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Location = New System.Drawing.Point(551, 213)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(346, 36)
        Me.lblMsg.TabIndex = 70
        '
        'tmrMensaje
        '
        Me.tmrMensaje.Interval = 5000
        '
        'btnNuevo
        '
        Me.btnNuevo.BackgroundImage = Global.ByB_SI.My.Resources.Resources.NuevoIn
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnNuevo.Location = New System.Drawing.Point(467, 243)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(61, 61)
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Tag = ""
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = Global.ByB_SI.My.Resources.Resources.SalirIn
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Location = New System.Drawing.Point(692, 243)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(61, 61)
        Me.btnSalir.TabIndex = 10
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
        Me.btnGuardar.Location = New System.Drawing.Point(534, 243)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(61, 60)
        Me.btnGuardar.TabIndex = 8
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
        Me.btnCancelar.Location = New System.Drawing.Point(601, 243)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(61, 60)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Tag = ""
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblFuncion
        '
        Me.lblFuncion.Location = New System.Drawing.Point(817, 366)
        Me.lblFuncion.Name = "lblFuncion"
        Me.lblFuncion.Size = New System.Drawing.Size(74, 20)
        Me.lblFuncion.TabIndex = 31
        Me.lblFuncion.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label8.Location = New System.Drawing.Point(180, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 16)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Titular/es"
        '
        'gbxClientes
        '
        Me.gbxClientes.BackColor = System.Drawing.Color.Transparent
        Me.gbxClientes.Controls.Add(Me.txtSucursal)
        Me.gbxClientes.Controls.Add(Me.cbxBanco)
        Me.gbxClientes.Controls.Add(Me.txtNroChq)
        Me.gbxClientes.Controls.Add(Me.Label9)
        Me.gbxClientes.Controls.Add(Me.txtCantidad)
        Me.gbxClientes.Controls.Add(Me.Label3)
        Me.gbxClientes.Controls.Add(Me.lblMsg)
        Me.gbxClientes.Controls.Add(Me.lblFuncion)
        Me.gbxClientes.Controls.Add(Me.Label8)
        Me.gbxClientes.Controls.Add(Me.txtCta)
        Me.gbxClientes.Controls.Add(Me.Label7)
        Me.gbxClientes.Controls.Add(Me.txtTitular)
        Me.gbxClientes.Controls.Add(Me.Label6)
        Me.gbxClientes.Controls.Add(Me.Label2)
        Me.gbxClientes.Controls.Add(Me.txtFecAlta)
        Me.gbxClientes.Controls.Add(Me.Label5)
        Me.gbxClientes.Controls.Add(Me.PictureBox1)
        Me.gbxClientes.Enabled = False
        Me.gbxClientes.Location = New System.Drawing.Point(10, 3)
        Me.gbxClientes.Name = "gbxClientes"
        Me.gbxClientes.Size = New System.Drawing.Size(743, 232)
        Me.gbxClientes.TabIndex = 44
        Me.gbxClientes.TabStop = False
        '
        'txtSucursal
        '
        Me.txtSucursal.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSucursal.ForeColor = System.Drawing.Color.Teal
        Me.txtSucursal.Location = New System.Drawing.Point(316, 78)
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Size = New System.Drawing.Size(230, 22)
        Me.txtSucursal.TabIndex = 2
        '
        'cbxBanco
        '
        Me.cbxBanco.BackColor = System.Drawing.Color.MediumTurquoise
        Me.cbxBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxBanco.ForeColor = System.Drawing.Color.Teal
        Me.cbxBanco.FormattingEnabled = True
        Me.cbxBanco.Items.AddRange(New Object() {"Banex", "Bank Boston", "Bisel", "BNL", "City Bank", "Comafi", "Credocoop", "Entre Río", "Formosa", "Francés", "Galicia", "Hipotecario", "HSBC", "Industrial", "Itaú", "La Pampa", "La Rioja", "Macro Bansud", "Nación Argentina", "Patagonia", "Provincia De Buenos Aires", "Provincia De Córdoba", "Provincia De Neuquén", "Regional De Cuyo", "Roela", "Santa Cruz", "Santa Fe", "Santander Río", "Standard Bank", "Superville", "Suquía"})
        Me.cbxBanco.Location = New System.Drawing.Point(316, 47)
        Me.cbxBanco.Name = "cbxBanco"
        Me.cbxBanco.Size = New System.Drawing.Size(230, 24)
        Me.cbxBanco.Sorted = True
        Me.cbxBanco.TabIndex = 1
        '
        'txtCta
        '
        Me.txtCta.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCta.ForeColor = System.Drawing.Color.Teal
        Me.txtCta.Location = New System.Drawing.Point(316, 107)
        Me.txtCta.Name = "txtCta"
        Me.txtCta.Size = New System.Drawing.Size(134, 22)
        Me.txtCta.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label7.Location = New System.Drawing.Point(180, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 16)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Nro Cuenta"
        '
        'txtTitular
        '
        Me.txtTitular.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtTitular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitular.ForeColor = System.Drawing.Color.Teal
        Me.txtTitular.Location = New System.Drawing.Point(316, 135)
        Me.txtTitular.Name = "txtTitular"
        Me.txtTitular.Size = New System.Drawing.Size(415, 22)
        Me.txtTitular.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label6.Location = New System.Drawing.Point(180, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 16)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Banco"
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
        Me.txtFecAlta.Location = New System.Drawing.Point(316, 19)
        Me.txtFecAlta.Name = "txtFecAlta"
        Me.txtFecAlta.Size = New System.Drawing.Size(134, 22)
        Me.txtFecAlta.TabIndex = 0
        Me.txtFecAlta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label5.Location = New System.Drawing.Point(180, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Sucursal"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Image = Global.ByB_SI.My.Resources.Resources.ChequesAc
        Me.PictureBox1.Location = New System.Drawing.Point(9, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 138)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'frmIngresoChequera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ByB_SI.My.Resources.Resources.Fondo_23___Reducido
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(763, 314)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.gbxClientes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmIngresoChequera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmIngresoChequera"
        Me.gbxClientes.ResumeLayout(False)
        Me.gbxClientes.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNroChq As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents tmrMensaje As System.Windows.Forms.Timer
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblFuncion As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gbxClientes As System.Windows.Forms.GroupBox
    Friend WithEvents txtCta As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTitular As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFecAlta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSucursal As System.Windows.Forms.TextBox
    Friend WithEvents cbxBanco As System.Windows.Forms.ComboBox
End Class
