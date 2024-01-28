<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblCnn = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.cbxUsuario = New System.Windows.Forms.ComboBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnIngreso = New System.Windows.Forms.Button()
        Me.txtCodE = New System.Windows.Forms.TextBox()
        Me.gbxEmpresa = New System.Windows.Forms.GroupBox()
        Me.dgvEmpresas = New System.Windows.Forms.DataGridView()
        Me.dgvTipoCambio = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxEmpresa.SuspendLayout()
        CType(Me.dgvEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTipoCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCnn
        '
        Me.lblCnn.BackColor = System.Drawing.Color.Transparent
        Me.lblCnn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCnn.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblCnn.Location = New System.Drawing.Point(12, 242)
        Me.lblCnn.Name = "lblCnn"
        Me.lblCnn.Size = New System.Drawing.Size(328, 43)
        Me.lblCnn.TabIndex = 23
        Me.lblCnn.Text = "cnn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label2.Location = New System.Drawing.Point(119, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Contraseña"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label1.Location = New System.Drawing.Point(119, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Usuario"
        '
        'txtContraseña
        '
        Me.txtContraseña.BackColor = System.Drawing.Color.Turquoise
        Me.txtContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.Location = New System.Drawing.Point(122, 94)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(334, 22)
        Me.txtContraseña.TabIndex = 1
        '
        'cbxUsuario
        '
        Me.cbxUsuario.BackColor = System.Drawing.Color.Turquoise
        Me.cbxUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxUsuario.FormattingEnabled = True
        Me.cbxUsuario.Location = New System.Drawing.Point(122, 34)
        Me.cbxUsuario.Name = "cbxUsuario"
        Me.cbxUsuario.Size = New System.Drawing.Size(334, 24)
        Me.cbxUsuario.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancelar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.SalirIn
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Location = New System.Drawing.Point(404, 234)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(52, 51)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnIngreso
        '
        Me.btnIngreso.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btnIngreso.BackColor = System.Drawing.SystemColors.Control
        Me.btnIngreso.BackgroundImage = Global.ByB_SI.My.Resources.Resources.OkIn
        Me.btnIngreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnIngreso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIngreso.Location = New System.Drawing.Point(346, 234)
        Me.btnIngreso.Name = "btnIngreso"
        Me.btnIngreso.Size = New System.Drawing.Size(52, 51)
        Me.btnIngreso.TabIndex = 2
        Me.btnIngreso.UseVisualStyleBackColor = False
        '
        'txtCodE
        '
        Me.txtCodE.BackColor = System.Drawing.Color.Turquoise
        Me.txtCodE.Enabled = False
        Me.txtCodE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodE.Location = New System.Drawing.Point(12, 7)
        Me.txtCodE.Name = "txtCodE"
        Me.txtCodE.Size = New System.Drawing.Size(81, 24)
        Me.txtCodE.TabIndex = 26
        Me.txtCodE.Visible = False
        '
        'gbxEmpresa
        '
        Me.gbxEmpresa.BackColor = System.Drawing.Color.Transparent
        Me.gbxEmpresa.Controls.Add(Me.dgvEmpresas)
        Me.gbxEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxEmpresa.ForeColor = System.Drawing.Color.LawnGreen
        Me.gbxEmpresa.Location = New System.Drawing.Point(15, 123)
        Me.gbxEmpresa.Name = "gbxEmpresa"
        Me.gbxEmpresa.Size = New System.Drawing.Size(441, 105)
        Me.gbxEmpresa.TabIndex = 29
        Me.gbxEmpresa.TabStop = False
        Me.gbxEmpresa.Text = " Seleccione Empresa "
        '
        'dgvEmpresas
        '
        Me.dgvEmpresas.AllowUserToAddRows = False
        Me.dgvEmpresas.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvEmpresas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEmpresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmpresas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmpresas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEmpresas.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvEmpresas.Location = New System.Drawing.Point(5, 17)
        Me.dgvEmpresas.Name = "dgvEmpresas"
        Me.dgvEmpresas.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmpresas.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmpresas.Size = New System.Drawing.Size(430, 82)
        Me.dgvEmpresas.TabIndex = 29
        '
        'dgvTipoCambio
        '
        Me.dgvTipoCambio.AllowUserToAddRows = False
        Me.dgvTipoCambio.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgvTipoCambio.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvTipoCambio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTipoCambio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTipoCambio.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvTipoCambio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.LawnGreen
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTipoCambio.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvTipoCambio.Location = New System.Drawing.Point(12, 50)
        Me.dgvTipoCambio.Name = "dgvTipoCambio"
        Me.dgvTipoCambio.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTipoCambio.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvTipoCambio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTipoCambio.Size = New System.Drawing.Size(81, 28)
        Me.dgvTipoCambio.TabIndex = 30
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ByB_SI.My.Resources.Resources.Fondo_23___Reducido1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(467, 294)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgvTipoCambio)
        Me.Controls.Add(Me.gbxEmpresa)
        Me.Controls.Add(Me.txtCodE)
        Me.Controls.Add(Me.lblCnn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.cbxUsuario)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnIngreso)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenido, introduzca Usuario y Contraseña para ingrear."
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxEmpresa.ResumeLayout(False)
        CType(Me.dgvEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTipoCambio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCnn As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents cbxUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnIngreso As System.Windows.Forms.Button
    Friend WithEvents txtCodE As System.Windows.Forms.TextBox
    Friend WithEvents gbxEmpresa As System.Windows.Forms.GroupBox
    Friend WithEvents dgvEmpresas As System.Windows.Forms.DataGridView
    Friend WithEvents dgvTipoCambio As System.Windows.Forms.DataGridView
End Class
