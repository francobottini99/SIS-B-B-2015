<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServTecnicoResumen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServTecnicoResumen))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDiagnostico = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtProblema = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNroOrden = New System.Windows.Forms.Label()
        Me.lblFecAlta = New System.Windows.Forms.Label()
        Me.lblRazonSocial = New System.Windows.Forms.Label()
        Me.lblTE = New System.Windows.Forms.Label()
        Me.lblCodBarra = New System.Windows.Forms.Label()
        Me.lblTipoEq = New System.Windows.Forms.Label()
        Me.lblDetalleEq = New System.Windows.Forms.Label()
        Me.lblAccesorios = New System.Windows.Forms.Label()
        Me.lblEstEntrega = New System.Windows.Forms.Label()
        Me.lblFecEntrega = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblEntregaAProv = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblDevProv = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblTercerizado = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.gbcProb = New System.Windows.Forms.GroupBox()
        Me.gbxDiag = New System.Windows.Forms.GroupBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblPresProveedor = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblVtoGrantia = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblGarantia = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblPresupuesto = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblIdCliente = New System.Windows.Forms.Label()
        Me.lblOrigen = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbcProb.SuspendLayout()
        Me.gbxDiag.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label11.Location = New System.Drawing.Point(180, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 16)
        Me.Label11.TabIndex = 107
        Me.Label11.Text = "Nro Orden"
        '
        'txtDiagnostico
        '
        Me.txtDiagnostico.BackColor = System.Drawing.Color.LightCyan
        Me.txtDiagnostico.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiagnostico.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDiagnostico.Location = New System.Drawing.Point(6, 19)
        Me.txtDiagnostico.Multiline = True
        Me.txtDiagnostico.Name = "txtDiagnostico"
        Me.txtDiagnostico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDiagnostico.Size = New System.Drawing.Size(559, 326)
        Me.txtDiagnostico.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Image = Global.ByB_SI.My.Resources.Resources.Diagnostico_ST
        Me.PictureBox1.Location = New System.Drawing.Point(9, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label3.Location = New System.Drawing.Point(177, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Id Equipo"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label12.Location = New System.Drawing.Point(429, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(190, 18)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "Razón Social"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label10.Location = New System.Drawing.Point(847, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 16)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Teléfono"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label9.Location = New System.Drawing.Point(177, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(150, 16)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Fec. Est. Ent. Cliente"
        '
        'txtProblema
        '
        Me.txtProblema.BackColor = System.Drawing.Color.LightCyan
        Me.txtProblema.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProblema.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtProblema.Location = New System.Drawing.Point(6, 21)
        Me.txtProblema.Multiline = True
        Me.txtProblema.Name = "txtProblema"
        Me.txtProblema.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtProblema.Size = New System.Drawing.Size(457, 324)
        Me.txtProblema.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label6.Location = New System.Drawing.Point(177, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 16)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Accesorios"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label4.Location = New System.Drawing.Point(615, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 16)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Detalle Del Equipo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label2.Location = New System.Drawing.Point(303, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Fecha Ingreso"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label5.Location = New System.Drawing.Point(429, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 16)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Tipo Equipo"
        '
        'lblNroOrden
        '
        Me.lblNroOrden.BackColor = System.Drawing.Color.Transparent
        Me.lblNroOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNroOrden.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroOrden.ForeColor = System.Drawing.Color.White
        Me.lblNroOrden.Location = New System.Drawing.Point(180, 25)
        Me.lblNroOrden.Name = "lblNroOrden"
        Me.lblNroOrden.Size = New System.Drawing.Size(120, 23)
        Me.lblNroOrden.TabIndex = 108
        Me.lblNroOrden.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFecAlta
        '
        Me.lblFecAlta.BackColor = System.Drawing.Color.Transparent
        Me.lblFecAlta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFecAlta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecAlta.ForeColor = System.Drawing.Color.White
        Me.lblFecAlta.Location = New System.Drawing.Point(306, 25)
        Me.lblFecAlta.Name = "lblFecAlta"
        Me.lblFecAlta.Size = New System.Drawing.Size(120, 23)
        Me.lblFecAlta.TabIndex = 109
        Me.lblFecAlta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.BackColor = System.Drawing.Color.Transparent
        Me.lblRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRazonSocial.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazonSocial.ForeColor = System.Drawing.Color.White
        Me.lblRazonSocial.Location = New System.Drawing.Point(432, 25)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(412, 23)
        Me.lblRazonSocial.TabIndex = 111
        Me.lblRazonSocial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTE
        '
        Me.lblTE.BackColor = System.Drawing.Color.Transparent
        Me.lblTE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTE.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTE.ForeColor = System.Drawing.Color.White
        Me.lblTE.Location = New System.Drawing.Point(850, 25)
        Me.lblTE.Name = "lblTE"
        Me.lblTE.Size = New System.Drawing.Size(208, 23)
        Me.lblTE.TabIndex = 112
        Me.lblTE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCodBarra
        '
        Me.lblCodBarra.BackColor = System.Drawing.Color.Transparent
        Me.lblCodBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCodBarra.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodBarra.ForeColor = System.Drawing.Color.White
        Me.lblCodBarra.Location = New System.Drawing.Point(180, 67)
        Me.lblCodBarra.Name = "lblCodBarra"
        Me.lblCodBarra.Size = New System.Drawing.Size(246, 23)
        Me.lblCodBarra.TabIndex = 113
        Me.lblCodBarra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoEq
        '
        Me.lblTipoEq.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoEq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTipoEq.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoEq.ForeColor = System.Drawing.Color.White
        Me.lblTipoEq.Location = New System.Drawing.Point(432, 67)
        Me.lblTipoEq.Name = "lblTipoEq"
        Me.lblTipoEq.Size = New System.Drawing.Size(180, 23)
        Me.lblTipoEq.TabIndex = 114
        Me.lblTipoEq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDetalleEq
        '
        Me.lblDetalleEq.BackColor = System.Drawing.Color.Transparent
        Me.lblDetalleEq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDetalleEq.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetalleEq.ForeColor = System.Drawing.Color.White
        Me.lblDetalleEq.Location = New System.Drawing.Point(618, 67)
        Me.lblDetalleEq.Name = "lblDetalleEq"
        Me.lblDetalleEq.Size = New System.Drawing.Size(440, 23)
        Me.lblDetalleEq.TabIndex = 115
        Me.lblDetalleEq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAccesorios
        '
        Me.lblAccesorios.BackColor = System.Drawing.Color.Transparent
        Me.lblAccesorios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAccesorios.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccesorios.ForeColor = System.Drawing.Color.White
        Me.lblAccesorios.Location = New System.Drawing.Point(180, 109)
        Me.lblAccesorios.Name = "lblAccesorios"
        Me.lblAccesorios.Size = New System.Drawing.Size(432, 23)
        Me.lblAccesorios.TabIndex = 116
        Me.lblAccesorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEstEntrega
        '
        Me.lblEstEntrega.BackColor = System.Drawing.Color.Transparent
        Me.lblEstEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEstEntrega.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstEntrega.ForeColor = System.Drawing.Color.White
        Me.lblEstEntrega.Location = New System.Drawing.Point(180, 155)
        Me.lblEstEntrega.Name = "lblEstEntrega"
        Me.lblEstEntrega.Size = New System.Drawing.Size(147, 23)
        Me.lblEstEntrega.TabIndex = 117
        Me.lblEstEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFecEntrega
        '
        Me.lblFecEntrega.BackColor = System.Drawing.Color.Transparent
        Me.lblFecEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFecEntrega.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecEntrega.ForeColor = System.Drawing.Color.White
        Me.lblFecEntrega.Location = New System.Drawing.Point(333, 155)
        Me.lblFecEntrega.Name = "lblFecEntrega"
        Me.lblFecEntrega.Size = New System.Drawing.Size(147, 23)
        Me.lblFecEntrega.TabIndex = 119
        Me.lblFecEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label18.Location = New System.Drawing.Point(330, 139)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(148, 16)
        Me.Label18.TabIndex = 118
        Me.Label18.Text = "Fec. Entrega Cliente"
        '
        'lblEntregaAProv
        '
        Me.lblEntregaAProv.BackColor = System.Drawing.Color.Transparent
        Me.lblEntregaAProv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEntregaAProv.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntregaAProv.ForeColor = System.Drawing.Color.White
        Me.lblEntregaAProv.Location = New System.Drawing.Point(716, 109)
        Me.lblEntregaAProv.Name = "lblEntregaAProv"
        Me.lblEntregaAProv.Size = New System.Drawing.Size(167, 23)
        Me.lblEntregaAProv.TabIndex = 129
        Me.lblEntregaAProv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label20.Location = New System.Drawing.Point(713, 93)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(134, 16)
        Me.Label20.TabIndex = 128
        Me.Label20.Text = "Entregado A Prov."
        '
        'lblDevProv
        '
        Me.lblDevProv.BackColor = System.Drawing.Color.Transparent
        Me.lblDevProv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDevProv.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDevProv.ForeColor = System.Drawing.Color.White
        Me.lblDevProv.Location = New System.Drawing.Point(891, 109)
        Me.lblDevProv.Name = "lblDevProv"
        Me.lblDevProv.Size = New System.Drawing.Size(167, 23)
        Me.lblDevProv.TabIndex = 131
        Me.lblDevProv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label21.Location = New System.Drawing.Point(888, 93)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(114, 16)
        Me.Label21.TabIndex = 130
        Me.Label21.Text = "Devuelve Prov."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label14.Location = New System.Drawing.Point(484, 139)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 16)
        Me.Label14.TabIndex = 132
        Me.Label14.Text = "Obervaciones"
        '
        'lblObservaciones
        '
        Me.lblObservaciones.BackColor = System.Drawing.Color.Transparent
        Me.lblObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblObservaciones.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.ForeColor = System.Drawing.Color.White
        Me.lblObservaciones.Location = New System.Drawing.Point(486, 155)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(572, 23)
        Me.lblObservaciones.TabIndex = 133
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTercerizado
        '
        Me.lblTercerizado.BackColor = System.Drawing.Color.Transparent
        Me.lblTercerizado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTercerizado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTercerizado.ForeColor = System.Drawing.Color.White
        Me.lblTercerizado.Location = New System.Drawing.Point(618, 109)
        Me.lblTercerizado.Name = "lblTercerizado"
        Me.lblTercerizado.Size = New System.Drawing.Size(89, 23)
        Me.lblTercerizado.TabIndex = 138
        Me.lblTercerizado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label22.Location = New System.Drawing.Point(615, 93)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(92, 16)
        Me.Label22.TabIndex = 137
        Me.Label22.Text = "Tercerizado"
        '
        'gbcProb
        '
        Me.gbcProb.BackColor = System.Drawing.Color.Transparent
        Me.gbcProb.Controls.Add(Me.txtProblema)
        Me.gbcProb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbcProb.ForeColor = System.Drawing.Color.LawnGreen
        Me.gbcProb.Location = New System.Drawing.Point(8, 230)
        Me.gbcProb.Name = "gbcProb"
        Me.gbcProb.Size = New System.Drawing.Size(469, 357)
        Me.gbcProb.TabIndex = 139
        Me.gbcProb.TabStop = False
        Me.gbcProb.Text = " Descripcion de la Falla "
        '
        'gbxDiag
        '
        Me.gbxDiag.BackColor = System.Drawing.Color.Transparent
        Me.gbxDiag.Controls.Add(Me.txtDiagnostico)
        Me.gbxDiag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDiag.ForeColor = System.Drawing.Color.LawnGreen
        Me.gbxDiag.Location = New System.Drawing.Point(486, 230)
        Me.gbxDiag.Name = "gbxDiag"
        Me.gbxDiag.Size = New System.Drawing.Size(571, 357)
        Me.gbxDiag.TabIndex = 140
        Me.gbxDiag.TabStop = False
        Me.gbxDiag.Text = " Diagnóstico y Seguimiento "
        '
        'lblEstado
        '
        Me.lblEstado.BackColor = System.Drawing.Color.Transparent
        Me.lblEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEstado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.Orange
        Me.lblEstado.Location = New System.Drawing.Point(769, 198)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(288, 23)
        Me.lblEstado.TabIndex = 150
        Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label23.Location = New System.Drawing.Point(766, 182)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(94, 16)
        Me.Label23.TabIndex = 149
        Me.Label23.Text = "Seguimiento"
        '
        'lblPresProveedor
        '
        Me.lblPresProveedor.BackColor = System.Drawing.Color.Transparent
        Me.lblPresProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPresProveedor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPresProveedor.ForeColor = System.Drawing.Color.White
        Me.lblPresProveedor.Location = New System.Drawing.Point(180, 198)
        Me.lblPresProveedor.Name = "lblPresProveedor"
        Me.lblPresProveedor.Size = New System.Drawing.Size(147, 23)
        Me.lblPresProveedor.TabIndex = 148
        Me.lblPresProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label19.Location = New System.Drawing.Point(177, 182)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(135, 16)
        Me.Label19.TabIndex = 147
        Me.Label19.Text = "Presupuesto Prov."
        '
        'lblVtoGrantia
        '
        Me.lblVtoGrantia.BackColor = System.Drawing.Color.Transparent
        Me.lblVtoGrantia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVtoGrantia.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVtoGrantia.ForeColor = System.Drawing.Color.White
        Me.lblVtoGrantia.Location = New System.Drawing.Point(618, 198)
        Me.lblVtoGrantia.Name = "lblVtoGrantia"
        Me.lblVtoGrantia.Size = New System.Drawing.Size(145, 23)
        Me.lblVtoGrantia.TabIndex = 146
        Me.lblVtoGrantia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label16.Location = New System.Drawing.Point(616, 182)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(126, 16)
        Me.Label16.TabIndex = 145
        Me.Label16.Text = "Vencim. Garantía"
        '
        'lblGarantia
        '
        Me.lblGarantia.BackColor = System.Drawing.Color.Transparent
        Me.lblGarantia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGarantia.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGarantia.ForeColor = System.Drawing.Color.White
        Me.lblGarantia.Location = New System.Drawing.Point(486, 198)
        Me.lblGarantia.Name = "lblGarantia"
        Me.lblGarantia.Size = New System.Drawing.Size(124, 23)
        Me.lblGarantia.TabIndex = 144
        Me.lblGarantia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label15.Location = New System.Drawing.Point(483, 182)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(127, 16)
        Me.Label15.TabIndex = 143
        Me.Label15.Text = "Garantía (Meses)"
        '
        'lblPresupuesto
        '
        Me.lblPresupuesto.BackColor = System.Drawing.Color.Transparent
        Me.lblPresupuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPresupuesto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPresupuesto.ForeColor = System.Drawing.Color.White
        Me.lblPresupuesto.Location = New System.Drawing.Point(333, 198)
        Me.lblPresupuesto.Name = "lblPresupuesto"
        Me.lblPresupuesto.Size = New System.Drawing.Size(147, 23)
        Me.lblPresupuesto.TabIndex = 142
        Me.lblPresupuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label17.Location = New System.Drawing.Point(330, 182)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 16)
        Me.Label17.TabIndex = 141
        Me.Label17.Text = "Presupuesto"
        '
        'lblIdCliente
        '
        Me.lblIdCliente.BackColor = System.Drawing.Color.Transparent
        Me.lblIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIdCliente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdCliente.ForeColor = System.Drawing.Color.White
        Me.lblIdCliente.Location = New System.Drawing.Point(8, 175)
        Me.lblIdCliente.Name = "lblIdCliente"
        Me.lblIdCliente.Size = New System.Drawing.Size(121, 23)
        Me.lblIdCliente.TabIndex = 151
        Me.lblIdCliente.Visible = False
        '
        'lblOrigen
        '
        Me.lblOrigen.BackColor = System.Drawing.Color.Transparent
        Me.lblOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOrigen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrigen.ForeColor = System.Drawing.Color.White
        Me.lblOrigen.Location = New System.Drawing.Point(9, 202)
        Me.lblOrigen.Name = "lblOrigen"
        Me.lblOrigen.Size = New System.Drawing.Size(121, 23)
        Me.lblOrigen.TabIndex = 152
        Me.lblOrigen.Visible = False
        '
        'frmServTecnicoResumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ByB_SI.My.Resources.Resources.Fondo_23___Reducido
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1066, 596)
        Me.Controls.Add(Me.lblOrigen)
        Me.Controls.Add(Me.lblIdCliente)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.lblPresProveedor)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lblVtoGrantia)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblGarantia)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblPresupuesto)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.gbxDiag)
        Me.Controls.Add(Me.gbcProb)
        Me.Controls.Add(Me.lblTercerizado)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblDevProv)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.lblEntregaAProv)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.lblFecEntrega)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lblEstEntrega)
        Me.Controls.Add(Me.lblAccesorios)
        Me.Controls.Add(Me.lblDetalleEq)
        Me.Controls.Add(Me.lblTipoEq)
        Me.Controls.Add(Me.lblCodBarra)
        Me.Controls.Add(Me.lblTE)
        Me.Controls.Add(Me.lblRazonSocial)
        Me.Controls.Add(Me.lblFecAlta)
        Me.Controls.Add(Me.lblNroOrden)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmServTecnicoResumen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmServTecnicoResumen"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbcProb.ResumeLayout(False)
        Me.gbcProb.PerformLayout()
        Me.gbxDiag.ResumeLayout(False)
        Me.gbxDiag.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDiagnostico As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtProblema As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblNroOrden As System.Windows.Forms.Label
    Friend WithEvents lblFecAlta As System.Windows.Forms.Label
    Friend WithEvents lblRazonSocial As System.Windows.Forms.Label
    Friend WithEvents lblTE As System.Windows.Forms.Label
    Friend WithEvents lblCodBarra As System.Windows.Forms.Label
    Friend WithEvents lblTipoEq As System.Windows.Forms.Label
    Friend WithEvents lblDetalleEq As System.Windows.Forms.Label
    Friend WithEvents lblAccesorios As System.Windows.Forms.Label
    Friend WithEvents lblEstEntrega As System.Windows.Forms.Label
    Friend WithEvents lblFecEntrega As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblEntregaAProv As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblDevProv As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents lblTercerizado As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents gbcProb As System.Windows.Forms.GroupBox
    Friend WithEvents gbxDiag As System.Windows.Forms.GroupBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblPresProveedor As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblVtoGrantia As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblGarantia As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblPresupuesto As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblIdCliente As System.Windows.Forms.Label
    Friend WithEvents lblOrigen As System.Windows.Forms.Label
End Class
