<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.chbHabilitacion = New System.Windows.Forms.CheckBox()
        Me.txtReContrseña = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxCategoria = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.gbxDatagrid = New System.Windows.Forms.GroupBox()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.tmrMensaje = New System.Windows.Forms.Timer(Me.components)
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gbxUsuarios = New System.Windows.Forms.GroupBox()
        Me.cbxRemoto = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMneuHab = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.lblFuncion = New System.Windows.Forms.Label()
        Me.lblIdUs = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.gbxDatagrid.SuspendLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxUsuarios.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.Transparent
        Me.lblMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Location = New System.Drawing.Point(498, 265)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(270, 47)
        Me.lblMsg.TabIndex = 17
        '
        'chbHabilitacion
        '
        Me.chbHabilitacion.AutoSize = True
        Me.chbHabilitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbHabilitacion.ForeColor = System.Drawing.Color.LawnGreen
        Me.chbHabilitacion.Location = New System.Drawing.Point(480, 130)
        Me.chbHabilitacion.Name = "chbHabilitacion"
        Me.chbHabilitacion.Size = New System.Drawing.Size(99, 20)
        Me.chbHabilitacion.TabIndex = 9
        Me.chbHabilitacion.Text = "Habilitado"
        Me.chbHabilitacion.UseVisualStyleBackColor = True
        '
        'txtReContrseña
        '
        Me.txtReContrseña.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtReContrseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReContrseña.ForeColor = System.Drawing.Color.Teal
        Me.txtReContrseña.Location = New System.Drawing.Point(161, 100)
        Me.txtReContrseña.Name = "txtReContrseña"
        Me.txtReContrseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtReContrseña.Size = New System.Drawing.Size(256, 22)
        Me.txtReContrseña.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label4.Location = New System.Drawing.Point(3, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Confirma Contraseña"
        '
        'cbxCategoria
        '
        Me.cbxCategoria.BackColor = System.Drawing.Color.MediumTurquoise
        Me.cbxCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCategoria.ForeColor = System.Drawing.Color.Teal
        Me.cbxCategoria.FormattingEnabled = True
        Me.cbxCategoria.Items.AddRange(New Object() {"Administrador", "Usuario"})
        Me.cbxCategoria.Location = New System.Drawing.Point(161, 42)
        Me.cbxCategoria.Name = "cbxCategoria"
        Me.cbxCategoria.Size = New System.Drawing.Size(256, 24)
        Me.cbxCategoria.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label3.Location = New System.Drawing.Point(3, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Categoría"
        '
        'txtContraseña
        '
        Me.txtContraseña.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.ForeColor = System.Drawing.Color.Teal
        Me.txtContraseña.Location = New System.Drawing.Point(161, 72)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(256, 22)
        Me.txtContraseña.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label2.Location = New System.Drawing.Point(3, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contraseña"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.Teal
        Me.txtNombre.Location = New System.Drawing.Point(162, 14)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(418, 22)
        Me.txtNombre.TabIndex = 0
        '
        'gbxDatagrid
        '
        Me.gbxDatagrid.BackColor = System.Drawing.Color.Transparent
        Me.gbxDatagrid.Controls.Add(Me.dgvUsuarios)
        Me.gbxDatagrid.Location = New System.Drawing.Point(13, 191)
        Me.gbxDatagrid.Name = "gbxDatagrid"
        Me.gbxDatagrid.Size = New System.Drawing.Size(479, 203)
        Me.gbxDatagrid.TabIndex = 15
        Me.gbxDatagrid.TabStop = False
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvUsuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUsuarios.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvUsuarios.Location = New System.Drawing.Point(6, 19)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsuarios.Size = New System.Drawing.Size(467, 178)
        Me.dgvUsuarios.TabIndex = 10
        '
        'Eliminar
        '
        Me.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Width = 49
        '
        'btnModificar
        '
        Me.btnModificar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.ModifIn
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnModificar.Location = New System.Drawing.Point(567, 196)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(63, 66)
        Me.btnModificar.TabIndex = 5
        Me.btnModificar.Tag = ""
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label1.Location = New System.Drawing.Point(4, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Usuario"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.CancelarIn
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCancelar.Location = New System.Drawing.Point(705, 196)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(63, 66)
        Me.btnCancelar.TabIndex = 7
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
        Me.btnGuardar.Location = New System.Drawing.Point(636, 196)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(63, 66)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Tag = ""
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'tmrMensaje
        '
        Me.tmrMensaje.Interval = 5000
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = Global.ByB_SI.My.Resources.Resources.SalirIn
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Location = New System.Drawing.Point(693, 323)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(76, 71)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Tag = ""
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'gbxUsuarios
        '
        Me.gbxUsuarios.BackColor = System.Drawing.Color.Transparent
        Me.gbxUsuarios.Controls.Add(Me.cbxRemoto)
        Me.gbxUsuarios.Controls.Add(Me.Label6)
        Me.gbxUsuarios.Controls.Add(Me.Label5)
        Me.gbxUsuarios.Controls.Add(Me.txtMneuHab)
        Me.gbxUsuarios.Controls.Add(Me.chbHabilitacion)
        Me.gbxUsuarios.Controls.Add(Me.txtReContrseña)
        Me.gbxUsuarios.Controls.Add(Me.Label4)
        Me.gbxUsuarios.Controls.Add(Me.cbxCategoria)
        Me.gbxUsuarios.Controls.Add(Me.Label3)
        Me.gbxUsuarios.Controls.Add(Me.txtContraseña)
        Me.gbxUsuarios.Controls.Add(Me.Label2)
        Me.gbxUsuarios.Controls.Add(Me.txtNombre)
        Me.gbxUsuarios.Controls.Add(Me.Label1)
        Me.gbxUsuarios.Enabled = False
        Me.gbxUsuarios.Location = New System.Drawing.Point(184, 7)
        Me.gbxUsuarios.Name = "gbxUsuarios"
        Me.gbxUsuarios.Size = New System.Drawing.Size(585, 183)
        Me.gbxUsuarios.TabIndex = 11
        Me.gbxUsuarios.TabStop = False
        '
        'cbxRemoto
        '
        Me.cbxRemoto.BackColor = System.Drawing.Color.MediumTurquoise
        Me.cbxRemoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxRemoto.ForeColor = System.Drawing.Color.Teal
        Me.cbxRemoto.FormattingEnabled = True
        Me.cbxRemoto.Items.AddRange(New Object() {"Si", "No"})
        Me.cbxRemoto.Location = New System.Drawing.Point(161, 128)
        Me.cbxRemoto.Name = "cbxRemoto"
        Me.cbxRemoto.Size = New System.Drawing.Size(87, 24)
        Me.cbxRemoto.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label6.Location = New System.Drawing.Point(6, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Menu Habilitado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label5.Location = New System.Drawing.Point(6, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Remoto"
        '
        'txtMneuHab
        '
        Me.txtMneuHab.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtMneuHab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMneuHab.ForeColor = System.Drawing.Color.Teal
        Me.txtMneuHab.Location = New System.Drawing.Point(161, 156)
        Me.txtMneuHab.Name = "txtMneuHab"
        Me.txtMneuHab.Size = New System.Drawing.Size(418, 22)
        Me.txtMneuHab.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ByB_SI.My.Resources.Resources.Usuarios_1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackgroundImage = Global.ByB_SI.My.Resources.Resources.NuevoIn
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnNuevo.Location = New System.Drawing.Point(498, 196)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(63, 66)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Tag = ""
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'lblFuncion
        '
        Me.lblFuncion.Location = New System.Drawing.Point(613, 374)
        Me.lblFuncion.Name = "lblFuncion"
        Me.lblFuncion.Size = New System.Drawing.Size(74, 20)
        Me.lblFuncion.TabIndex = 19
        Me.lblFuncion.Visible = False
        '
        'lblIdUs
        '
        Me.lblIdUs.Location = New System.Drawing.Point(533, 372)
        Me.lblIdUs.Name = "lblIdUs"
        Me.lblIdUs.Size = New System.Drawing.Size(74, 20)
        Me.lblIdUs.TabIndex = 20
        Me.lblIdUs.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.EliminarIn
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.Location = New System.Drawing.Point(498, 326)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(63, 66)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Tag = ""
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ByB_SI.My.Resources.Resources.Fondo_23___Reducido
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(776, 401)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.lblIdUs)
        Me.Controls.Add(Me.lblFuncion)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.gbxDatagrid)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.gbxUsuarios)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUsuarios"
        Me.gbxDatagrid.ResumeLayout(False)
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxUsuarios.ResumeLayout(False)
        Me.gbxUsuarios.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents chbHabilitacion As System.Windows.Forms.CheckBox
    Friend WithEvents txtReContrseña As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbxCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents gbxDatagrid As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents tmrMensaje As System.Windows.Forms.Timer
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents gbxUsuarios As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents lblFuncion As System.Windows.Forms.Label
    Friend WithEvents lblIdUs As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents dgvUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cbxRemoto As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMneuHab As System.Windows.Forms.TextBox
End Class
