<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsStock))
        Me.gbxStock = New System.Windows.Forms.GroupBox()
        Me.dgvStock = New System.Windows.Forms.DataGridView()
        Me.gbxFilros = New System.Windows.Forms.GroupBox()
        Me.btnCdB = New System.Windows.Forms.Button()
        Me.btnId = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCdBarra = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.txtSubRubro = New System.Windows.Forms.TextBox()
        Me.txtRubro = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.btnTodos = New System.Windows.Forms.Button()
        Me.pbxStock = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotalStk = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblImpSiva = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblImpCiva = New System.Windows.Forms.Label()
        Me.lblOrigen = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnImpStock = New System.Windows.Forms.Button()
        Me.gbxStock.SuspendLayout()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxFilros.SuspendLayout()
        CType(Me.pbxStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxStock
        '
        Me.gbxStock.BackColor = System.Drawing.Color.Transparent
        Me.gbxStock.Controls.Add(Me.dgvStock)
        Me.gbxStock.Location = New System.Drawing.Point(7, 145)
        Me.gbxStock.Name = "gbxStock"
        Me.gbxStock.Size = New System.Drawing.Size(1105, 366)
        Me.gbxStock.TabIndex = 10
        Me.gbxStock.TabStop = False
        '
        'dgvStock
        '
        Me.dgvStock.AllowUserToAddRows = False
        Me.dgvStock.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvStock.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStock.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStock.Location = New System.Drawing.Point(9, 19)
        Me.dgvStock.Name = "dgvStock"
        Me.dgvStock.ReadOnly = True
        Me.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStock.Size = New System.Drawing.Size(1090, 331)
        Me.dgvStock.TabIndex = 8
        '
        'gbxFilros
        '
        Me.gbxFilros.BackColor = System.Drawing.Color.Transparent
        Me.gbxFilros.Controls.Add(Me.btnCdB)
        Me.gbxFilros.Controls.Add(Me.btnId)
        Me.gbxFilros.Controls.Add(Me.Label9)
        Me.gbxFilros.Controls.Add(Me.txtCdBarra)
        Me.gbxFilros.Controls.Add(Me.Label7)
        Me.gbxFilros.Controls.Add(Me.txtId)
        Me.gbxFilros.Controls.Add(Me.Label4)
        Me.gbxFilros.Controls.Add(Me.Label3)
        Me.gbxFilros.Controls.Add(Me.Label1)
        Me.gbxFilros.Controls.Add(Me.Label2)
        Me.gbxFilros.Controls.Add(Me.txtCategoria)
        Me.gbxFilros.Controls.Add(Me.txtSubRubro)
        Me.gbxFilros.Controls.Add(Me.txtRubro)
        Me.gbxFilros.Controls.Add(Me.txtDescripcion)
        Me.gbxFilros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxFilros.ForeColor = System.Drawing.Color.LawnGreen
        Me.gbxFilros.Location = New System.Drawing.Point(176, 6)
        Me.gbxFilros.Name = "gbxFilros"
        Me.gbxFilros.Size = New System.Drawing.Size(808, 120)
        Me.gbxFilros.TabIndex = 11
        Me.gbxFilros.TabStop = False
        Me.gbxFilros.Text = " Buscar Articulos Por... "
        '
        'btnCdB
        '
        Me.btnCdB.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCdB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCdB.ForeColor = System.Drawing.SystemColors.InfoText
        Me.btnCdB.Location = New System.Drawing.Point(321, 45)
        Me.btnCdB.Name = "btnCdB"
        Me.btnCdB.Size = New System.Drawing.Size(41, 23)
        Me.btnCdB.TabIndex = 3
        Me.btnCdB.Text = ":) ->"
        Me.btnCdB.UseVisualStyleBackColor = False
        '
        'btnId
        '
        Me.btnId.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnId.ForeColor = System.Drawing.SystemColors.InfoText
        Me.btnId.Location = New System.Drawing.Point(86, 44)
        Me.btnId.Name = "btnId"
        Me.btnId.Size = New System.Drawing.Size(41, 23)
        Me.btnId.TabIndex = 1
        Me.btnId.Text = ":) ->"
        Me.btnId.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label9.Location = New System.Drawing.Point(138, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Codigo Barra"
        '
        'txtCdBarra
        '
        Me.txtCdBarra.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCdBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCdBarra.ForeColor = System.Drawing.Color.Teal
        Me.txtCdBarra.Location = New System.Drawing.Point(137, 45)
        Me.txtCdBarra.Name = "txtCdBarra"
        Me.txtCdBarra.Size = New System.Drawing.Size(182, 22)
        Me.txtCdBarra.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label7.Location = New System.Drawing.Point(7, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "ID"
        '
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.ForeColor = System.Drawing.Color.Teal
        Me.txtId.Location = New System.Drawing.Point(6, 44)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(78, 22)
        Me.txtId.TabIndex = 0
        Me.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label4.Location = New System.Drawing.Point(369, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Descripción"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label3.Location = New System.Drawing.Point(369, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Categoría"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label1.Location = New System.Drawing.Point(184, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "SubRubro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label2.Location = New System.Drawing.Point(7, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Rubro"
        '
        'txtCategoria
        '
        Me.txtCategoria.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoria.ForeColor = System.Drawing.Color.Teal
        Me.txtCategoria.Location = New System.Drawing.Point(368, 87)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(276, 22)
        Me.txtCategoria.TabIndex = 7
        '
        'txtSubRubro
        '
        Me.txtSubRubro.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtSubRubro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubRubro.ForeColor = System.Drawing.Color.Teal
        Me.txtSubRubro.Location = New System.Drawing.Point(187, 87)
        Me.txtSubRubro.Name = "txtSubRubro"
        Me.txtSubRubro.Size = New System.Drawing.Size(175, 22)
        Me.txtSubRubro.TabIndex = 6
        '
        'txtRubro
        '
        Me.txtRubro.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtRubro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRubro.ForeColor = System.Drawing.Color.Teal
        Me.txtRubro.Location = New System.Drawing.Point(6, 87)
        Me.txtRubro.Name = "txtRubro"
        Me.txtRubro.Size = New System.Drawing.Size(175, 22)
        Me.txtRubro.TabIndex = 5
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.Teal
        Me.txtDescripcion.Location = New System.Drawing.Point(372, 44)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(430, 22)
        Me.txtDescripcion.TabIndex = 4
        '
        'btnTodos
        '
        Me.btnTodos.BackgroundImage = Global.ByB_SI.My.Resources.Resources.TodosArtIn
        Me.btnTodos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTodos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTodos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnTodos.Location = New System.Drawing.Point(990, 12)
        Me.btnTodos.Name = "btnTodos"
        Me.btnTodos.Size = New System.Drawing.Size(55, 57)
        Me.btnTodos.TabIndex = 9
        Me.btnTodos.Tag = ""
        Me.btnTodos.UseVisualStyleBackColor = True
        '
        'pbxStock
        '
        Me.pbxStock.BackColor = System.Drawing.SystemColors.Control
        Me.pbxStock.Image = Global.ByB_SI.My.Resources.Resources.Stock1
        Me.pbxStock.Location = New System.Drawing.Point(7, 11)
        Me.pbxStock.Name = "pbxStock"
        Me.pbxStock.Size = New System.Drawing.Size(163, 133)
        Me.pbxStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxStock.TabIndex = 24
        Me.pbxStock.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = Global.ByB_SI.My.Resources.Resources.SalirIn
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Location = New System.Drawing.Point(1051, 518)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(61, 61)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Tag = ""
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label5.Location = New System.Drawing.Point(13, 514)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 16)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Stock"
        '
        'lblTotalStk
        '
        Me.lblTotalStk.BackColor = System.Drawing.Color.Orange
        Me.lblTotalStk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalStk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalStk.ForeColor = System.Drawing.Color.White
        Me.lblTotalStk.Location = New System.Drawing.Point(16, 532)
        Me.lblTotalStk.Name = "lblTotalStk"
        Me.lblTotalStk.Size = New System.Drawing.Size(171, 30)
        Me.lblTotalStk.TabIndex = 74
        Me.lblTotalStk.Text = "0.00"
        Me.lblTotalStk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label6.Location = New System.Drawing.Point(207, 514)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 16)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Total Sin IVA"
        '
        'lblImpSiva
        '
        Me.lblImpSiva.BackColor = System.Drawing.Color.Orange
        Me.lblImpSiva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblImpSiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpSiva.ForeColor = System.Drawing.Color.White
        Me.lblImpSiva.Location = New System.Drawing.Point(210, 532)
        Me.lblImpSiva.Name = "lblImpSiva"
        Me.lblImpSiva.Size = New System.Drawing.Size(171, 30)
        Me.lblImpSiva.TabIndex = 76
        Me.lblImpSiva.Text = "$ 0.00"
        Me.lblImpSiva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label8.Location = New System.Drawing.Point(402, 516)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 16)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = "Total Con IVA"
        '
        'lblImpCiva
        '
        Me.lblImpCiva.BackColor = System.Drawing.Color.Orange
        Me.lblImpCiva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblImpCiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpCiva.ForeColor = System.Drawing.Color.White
        Me.lblImpCiva.Location = New System.Drawing.Point(405, 532)
        Me.lblImpCiva.Name = "lblImpCiva"
        Me.lblImpCiva.Size = New System.Drawing.Size(171, 30)
        Me.lblImpCiva.TabIndex = 78
        Me.lblImpCiva.Text = "$ 0.00"
        Me.lblImpCiva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOrigen
        '
        Me.lblOrigen.AutoSize = True
        Me.lblOrigen.BackColor = System.Drawing.Color.White
        Me.lblOrigen.Location = New System.Drawing.Point(97, 9)
        Me.lblOrigen.Name = "lblOrigen"
        Me.lblOrigen.Size = New System.Drawing.Size(35, 13)
        Me.lblOrigen.TabIndex = 80
        Me.lblOrigen.Text = "Stock"
        Me.lblOrigen.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = Global.ByB_SI.My.Resources.Resources.CancelarIn
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCancelar.Location = New System.Drawing.Point(1051, 12)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(55, 57)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Tag = ""
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnImpStock
        '
        Me.btnImpStock.BackgroundImage = Global.ByB_SI.My.Resources.Resources.ImpresoraIn
        Me.btnImpStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnImpStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImpStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImpStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnImpStock.Location = New System.Drawing.Point(1051, 75)
        Me.btnImpStock.Name = "btnImpStock"
        Me.btnImpStock.Size = New System.Drawing.Size(55, 57)
        Me.btnImpStock.TabIndex = 11
        Me.btnImpStock.Tag = ""
        Me.btnImpStock.UseVisualStyleBackColor = True
        '
        'frmConsStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ByB_SI.My.Resources.Resources.Fondo_23___Reducido
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1118, 586)
        Me.Controls.Add(Me.btnImpStock)
        Me.Controls.Add(Me.btnTodos)
        Me.Controls.Add(Me.lblOrigen)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblImpCiva)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblImpSiva)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTotalStk)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.pbxStock)
        Me.Controls.Add(Me.gbxFilros)
        Me.Controls.Add(Me.gbxStock)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConsStock"
        Me.gbxStock.ResumeLayout(False)
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxFilros.ResumeLayout(False)
        Me.gbxFilros.PerformLayout()
        CType(Me.pbxStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxStock As System.Windows.Forms.GroupBox
    Friend WithEvents dgvStock As System.Windows.Forms.DataGridView
    Friend WithEvents gbxFilros As System.Windows.Forms.GroupBox
    Friend WithEvents pbxStock As System.Windows.Forms.PictureBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtCategoria As System.Windows.Forms.TextBox
    Friend WithEvents txtSubRubro As System.Windows.Forms.TextBox
    Friend WithEvents txtRubro As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnTodos As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTotalStk As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblImpSiva As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblImpCiva As System.Windows.Forms.Label
    Friend WithEvents lblOrigen As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnImpStock As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCdBarra As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents btnCdB As System.Windows.Forms.Button
    Friend WithEvents btnId As System.Windows.Forms.Button
End Class
