<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArtCategorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArtCategorias))
        Me.gbxDatagrid = New System.Windows.Forms.GroupBox()
        Me.dgvCategorias = New System.Windows.Forms.DataGridView()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.lblFuncion = New System.Windows.Forms.Label()
        Me.tmrMensaje = New System.Windows.Forms.Timer(Me.components)
        Me.lblIdUs = New System.Windows.Forms.Label()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.txtSubrubro = New System.Windows.Forms.TextBox()
        Me.txtRubro = New System.Windows.Forms.TextBox()
        Me.gbxCategorias = New System.Windows.Forms.GroupBox()
        Me.txtCodResumen = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodCategoria = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.txtCodSubRubro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodRubro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblOrigen = New System.Windows.Forms.Label()
        Me.gbxDatagrid.SuspendLayout()
        CType(Me.dgvCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxCategorias.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxDatagrid
        '
        Me.gbxDatagrid.BackColor = System.Drawing.Color.Transparent
        Me.gbxDatagrid.Controls.Add(Me.dgvCategorias)
        Me.gbxDatagrid.Location = New System.Drawing.Point(12, 208)
        Me.gbxDatagrid.Name = "gbxDatagrid"
        Me.gbxDatagrid.Size = New System.Drawing.Size(591, 214)
        Me.gbxDatagrid.TabIndex = 44
        Me.gbxDatagrid.TabStop = False
        '
        'dgvCategorias
        '
        Me.dgvCategorias.AllowUserToAddRows = False
        Me.dgvCategorias.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCategorias.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvCategorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCategorias.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCategorias.Location = New System.Drawing.Point(6, 13)
        Me.dgvCategorias.Name = "dgvCategorias"
        Me.dgvCategorias.ReadOnly = True
        Me.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCategorias.Size = New System.Drawing.Size(579, 195)
        Me.dgvCategorias.TabIndex = 9
        '
        'btnNuevo
        '
        Me.btnNuevo.BackgroundImage = Global.ByB_SI.My.Resources.Resources.NuevoIn
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnNuevo.Location = New System.Drawing.Point(623, 207)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(61, 59)
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Tag = ""
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'lblFuncion
        '
        Me.lblFuncion.Location = New System.Drawing.Point(690, 392)
        Me.lblFuncion.Name = "lblFuncion"
        Me.lblFuncion.Size = New System.Drawing.Size(74, 20)
        Me.lblFuncion.TabIndex = 41
        Me.lblFuncion.Visible = False
        '
        'tmrMensaje
        '
        Me.tmrMensaje.Interval = 5000
        '
        'lblIdUs
        '
        Me.lblIdUs.Location = New System.Drawing.Point(610, 392)
        Me.lblIdUs.Name = "lblIdUs"
        Me.lblIdUs.Size = New System.Drawing.Size(74, 20)
        Me.lblIdUs.TabIndex = 42
        Me.lblIdUs.Visible = False
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.Transparent
        Me.lblMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Location = New System.Drawing.Point(620, 283)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(263, 59)
        Me.lblMsg.TabIndex = 40
        '
        'txtCategoria
        '
        Me.txtCategoria.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoria.ForeColor = System.Drawing.Color.Teal
        Me.txtCategoria.Location = New System.Drawing.Point(584, 92)
        Me.txtCategoria.MaxLength = 100
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(281, 22)
        Me.txtCategoria.TabIndex = 6
        '
        'txtSubrubro
        '
        Me.txtSubrubro.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtSubrubro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubrubro.ForeColor = System.Drawing.Color.Teal
        Me.txtSubrubro.Location = New System.Drawing.Point(584, 57)
        Me.txtSubrubro.MaxLength = 100
        Me.txtSubrubro.Name = "txtSubrubro"
        Me.txtSubrubro.Size = New System.Drawing.Size(281, 22)
        Me.txtSubrubro.TabIndex = 4
        '
        'txtRubro
        '
        Me.txtRubro.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtRubro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRubro.ForeColor = System.Drawing.Color.Teal
        Me.txtRubro.Location = New System.Drawing.Point(584, 22)
        Me.txtRubro.MaxLength = 100
        Me.txtRubro.Name = "txtRubro"
        Me.txtRubro.Size = New System.Drawing.Size(281, 22)
        Me.txtRubro.TabIndex = 2
        '
        'gbxCategorias
        '
        Me.gbxCategorias.BackColor = System.Drawing.Color.Transparent
        Me.gbxCategorias.Controls.Add(Me.txtCodResumen)
        Me.gbxCategorias.Controls.Add(Me.Label5)
        Me.gbxCategorias.Controls.Add(Me.txtCategoria)
        Me.gbxCategorias.Controls.Add(Me.txtSubrubro)
        Me.gbxCategorias.Controls.Add(Me.txtRubro)
        Me.gbxCategorias.Controls.Add(Me.txtCodCategoria)
        Me.gbxCategorias.Controls.Add(Me.Label6)
        Me.gbxCategorias.Controls.Add(Me.Label8)
        Me.gbxCategorias.Controls.Add(Me.pbxLogo)
        Me.gbxCategorias.Controls.Add(Me.txtCodSubRubro)
        Me.gbxCategorias.Controls.Add(Me.Label4)
        Me.gbxCategorias.Controls.Add(Me.Label3)
        Me.gbxCategorias.Controls.Add(Me.txtCodRubro)
        Me.gbxCategorias.Controls.Add(Me.Label2)
        Me.gbxCategorias.Controls.Add(Me.Label1)
        Me.gbxCategorias.Location = New System.Drawing.Point(12, 12)
        Me.gbxCategorias.Name = "gbxCategorias"
        Me.gbxCategorias.Size = New System.Drawing.Size(871, 189)
        Me.gbxCategorias.TabIndex = 39
        Me.gbxCategorias.TabStop = False
        '
        'txtCodResumen
        '
        Me.txtCodResumen.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCodResumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodResumen.ForeColor = System.Drawing.Color.Teal
        Me.txtCodResumen.Location = New System.Drawing.Point(297, 133)
        Me.txtCodResumen.Name = "txtCodResumen"
        Me.txtCodResumen.Size = New System.Drawing.Size(123, 22)
        Me.txtCodResumen.TabIndex = 28
        Me.txtCodResumen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label5.Location = New System.Drawing.Point(178, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 16)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Cód. Resumen"
        '
        'txtCodCategoria
        '
        Me.txtCodCategoria.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCodCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCategoria.ForeColor = System.Drawing.Color.Teal
        Me.txtCodCategoria.Location = New System.Drawing.Point(297, 92)
        Me.txtCodCategoria.MaxLength = 3
        Me.txtCodCategoria.Name = "txtCodCategoria"
        Me.txtCodCategoria.Size = New System.Drawing.Size(123, 22)
        Me.txtCodCategoria.TabIndex = 5
        Me.txtCodCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label6.Location = New System.Drawing.Point(440, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 16)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Descrip. Categoría"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label8.Location = New System.Drawing.Point(440, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 16)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Descrip. SubRubro"
        '
        'pbxLogo
        '
        Me.pbxLogo.Image = Global.ByB_SI.My.Resources.Resources.CategoriasAc
        Me.pbxLogo.Location = New System.Drawing.Point(6, 9)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(165, 167)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo.TabIndex = 23
        Me.pbxLogo.TabStop = False
        '
        'txtCodSubRubro
        '
        Me.txtCodSubRubro.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCodSubRubro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodSubRubro.ForeColor = System.Drawing.Color.Teal
        Me.txtCodSubRubro.Location = New System.Drawing.Point(297, 57)
        Me.txtCodSubRubro.MaxLength = 3
        Me.txtCodSubRubro.Name = "txtCodSubRubro"
        Me.txtCodSubRubro.Size = New System.Drawing.Size(123, 22)
        Me.txtCodSubRubro.TabIndex = 3
        Me.txtCodSubRubro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label4.Location = New System.Drawing.Point(440, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Descrip. Rubro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label3.Location = New System.Drawing.Point(177, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cód. SubRubro"
        '
        'txtCodRubro
        '
        Me.txtCodRubro.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCodRubro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodRubro.ForeColor = System.Drawing.Color.Teal
        Me.txtCodRubro.Location = New System.Drawing.Point(297, 22)
        Me.txtCodRubro.MaxLength = 3
        Me.txtCodRubro.Name = "txtCodRubro"
        Me.txtCodRubro.Size = New System.Drawing.Size(123, 22)
        Me.txtCodRubro.TabIndex = 1
        Me.txtCodRubro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label2.Location = New System.Drawing.Point(177, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cód. Categoría"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label1.Location = New System.Drawing.Point(177, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cód. Rubro"
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
        Me.btnGuardar.Location = New System.Drawing.Point(755, 207)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(61, 60)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Tag = ""
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = Global.ByB_SI.My.Resources.Resources.SalirIn
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Location = New System.Drawing.Point(807, 351)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(76, 71)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Tag = ""
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.ModifIn
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnModificar.Location = New System.Drawing.Point(688, 208)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(61, 59)
        Me.btnModificar.TabIndex = 8
        Me.btnModificar.Tag = ""
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.CancelarIn
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCancelar.Location = New System.Drawing.Point(822, 207)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(61, 60)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Tag = ""
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblOrigen
        '
        Me.lblOrigen.Location = New System.Drawing.Point(609, 362)
        Me.lblOrigen.Name = "lblOrigen"
        Me.lblOrigen.Size = New System.Drawing.Size(74, 20)
        Me.lblOrigen.TabIndex = 45
        Me.lblOrigen.Text = "Categoria"
        Me.lblOrigen.Visible = False
        '
        'frmArtCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ByB_SI.My.Resources.Resources.Fondo_23___Reducido
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(897, 434)
        Me.Controls.Add(Me.lblOrigen)
        Me.Controls.Add(Me.gbxDatagrid)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.lblFuncion)
        Me.Controls.Add(Me.lblIdUs)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.gbxCategorias)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmArtCategorias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmArtCategorias"
        Me.gbxDatagrid.ResumeLayout(False)
        CType(Me.dgvCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxCategorias.ResumeLayout(False)
        Me.gbxCategorias.PerformLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxDatagrid As System.Windows.Forms.GroupBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents lblFuncion As System.Windows.Forms.Label
    Friend WithEvents tmrMensaje As System.Windows.Forms.Timer
    Friend WithEvents lblIdUs As System.Windows.Forms.Label
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents txtCategoria As System.Windows.Forms.TextBox
    Friend WithEvents txtSubrubro As System.Windows.Forms.TextBox
    Friend WithEvents txtRubro As System.Windows.Forms.TextBox
    Friend WithEvents gbxCategorias As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodCategoria As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents pbxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents txtCodSubRubro As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodRubro As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtCodResumen As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblOrigen As System.Windows.Forms.Label
    Friend WithEvents dgvCategorias As System.Windows.Forms.DataGridView
End Class
