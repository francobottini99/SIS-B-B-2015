Public Class frmSTEntregaRecep

    Private Sub btnLimpiar_DragOver(sender As Object, e As DragEventArgs) Handles btnLimpiar.DragOver
        btnLimpiar.BackgroundImage = ByB_SI.My.Resources.CancelarAc
    End Sub

    Private Sub btnLimpiar_LostFocus(sender As Object, e As EventArgs) Handles btnLimpiar.LostFocus
        btnLimpiar.BackgroundImage = ByB_SI.My.Resources.CancelarIn
    End Sub

    Private Sub btnLimpiar_MouseEnter(sender As Object, e As EventArgs) Handles btnLimpiar.MouseEnter
        btnLimpiar.BackgroundImage = ByB_SI.My.Resources.CancelarAc
    End Sub

    Private Sub btnLimpiar_MouseLeave(sender As Object, e As EventArgs) Handles btnLimpiar.MouseLeave
        btnLimpiar.BackgroundImage = ByB_SI.My.Resources.CancelarIn
    End Sub

    Private Sub btnTodo_GotFocus(sender As Object, e As EventArgs) Handles btnTodo.GotFocus
        btnTodo.BackgroundImage = ByB_SI.My.Resources.TodosArtAc
    End Sub

    Private Sub btnTodo_LostFocus(sender As Object, e As EventArgs) Handles btnTodo.LostFocus
        btnTodo.BackgroundImage = ByB_SI.My.Resources.TodosArtIn
    End Sub

    Private Sub btnTodo_MouseEnter(sender As Object, e As EventArgs) Handles btnTodo.MouseEnter
        btnTodo.BackgroundImage = ByB_SI.My.Resources.TodosArtAc
    End Sub

    Private Sub btnTodo_MouseLeave(sender As Object, e As EventArgs) Handles btnTodo.MouseLeave
        btnTodo.BackgroundImage = ByB_SI.My.Resources.TodosArtIn
    End Sub

    Private Sub btnBuscar_GotFocus(sender As Object, e As EventArgs) Handles btnBuscar.GotFocus
        btnBuscar.BackgroundImage = ByB_SI.My.Resources.ConsultaAc
    End Sub

    Private Sub btnBuscar_LostFocus(sender As Object, e As EventArgs) Handles btnBuscar.LostFocus
        btnBuscar.BackgroundImage = ByB_SI.My.Resources.ConsultaIn
    End Sub

    Private Sub btnBuscar_MouseEnter(sender As Object, e As EventArgs) Handles btnBuscar.MouseEnter
        btnBuscar.BackgroundImage = ByB_SI.My.Resources.ConsultaAc
    End Sub

    Private Sub btnBuscar_MouseLeave(sender As Object, e As EventArgs) Handles btnBuscar.MouseLeave
        btnBuscar.BackgroundImage = ByB_SI.My.Resources.ConsultaIn
    End Sub

    Private Sub btnSalir_GotFocus(sender As Object, e As EventArgs) Handles btnSalir.GotFocus
        btnSalir.BackgroundImage = ByB_SI.My.Resources.SalirAc
    End Sub

    Private Sub btnSalir_LostFocus(sender As Object, e As EventArgs) Handles btnSalir.LostFocus
        btnSalir.BackgroundImage = ByB_SI.My.Resources.SalirIn
    End Sub

    Private Sub btnSalir_MouseEnter(sender As Object, e As EventArgs) Handles btnSalir.MouseEnter
        btnSalir.BackgroundImage = ByB_SI.My.Resources.SalirAc
    End Sub

    Private Sub btnSalir_MouseLeave(sender As Object, e As EventArgs) Handles btnSalir.MouseLeave
        btnSalir.BackgroundImage = ByB_SI.My.Resources.SalirIn
    End Sub

    Private Sub btnEntregado_GotFocus(sender As Object, e As EventArgs) Handles btnEntregado.GotFocus
        btnEntregado.BackgroundImage = ByB_SI.My.Resources.EntregaAc
    End Sub

    Private Sub btnEntregado_LostFocus(sender As Object, e As EventArgs) Handles btnEntregado.LostFocus
        btnEntregado.BackgroundImage = ByB_SI.My.Resources.EntregaIn
    End Sub

    Private Sub btnEntregado_MouseEnter(sender As Object, e As EventArgs) Handles btnEntregado.MouseEnter
        btnEntregado.BackgroundImage = ByB_SI.My.Resources.EntregaAc
    End Sub

    Private Sub btnEntregado_MouseLeave(sender As Object, e As EventArgs) Handles btnEntregado.MouseLeave
        btnEntregado.BackgroundImage = ByB_SI.My.Resources.EntregaIn
    End Sub

    Private Sub btnRecibido_GotFocus(sender As Object, e As EventArgs) Handles btnRecibido.GotFocus
        btnRecibido.BackgroundImage = ByB_SI.My.Resources.RecepcionAc
    End Sub

    Private Sub btnRecibido_LostFocus(sender As Object, e As EventArgs) Handles btnRecibido.LostFocus
        btnRecibido.BackgroundImage = ByB_SI.My.Resources.RecepcionIn
    End Sub

    Private Sub btnRecibido_MouseEnter(sender As Object, e As EventArgs) Handles btnRecibido.MouseEnter
        btnRecibido.BackgroundImage = ByB_SI.My.Resources.RecepcionAc
    End Sub

    Private Sub btnRecibido_MouseLeave(sender As Object, e As EventArgs) Handles btnRecibido.MouseLeave
        btnRecibido.BackgroundImage = ByB_SI.My.Resources.RecepcionIn
    End Sub

    Private Sub btnImpStock_GotFocus(sender As Object, e As EventArgs) Handles btnImpStock.GotFocus
        btnImpStock.BackgroundImage = ByB_SI.My.Resources.ImpresoraAc
    End Sub

    Private Sub btnImpStock_LostFocus(sender As Object, e As EventArgs) Handles btnImpStock.LostFocus
        btnImpStock.BackgroundImage = ByB_SI.My.Resources.ImpresoraIn
    End Sub

    Private Sub btnImpStock_MouseEnter(sender As Object, e As EventArgs) Handles btnImpStock.MouseEnter
        btnImpStock.BackgroundImage = ByB_SI.My.Resources.ImpresoraAc
    End Sub

    Private Sub btnImpStock_MouseLeave(sender As Object, e As EventArgs) Handles btnImpStock.MouseLeave
        btnImpStock.BackgroundImage = ByB_SI.My.Resources.ImpresoraIn
    End Sub

    Private Sub frmSTEntregaRecep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim _Ver As New Mostrar
            Dim _Dt As New DataTable

            _Dt = _Ver.verServicioTecEntregaRecpcionProv(mdifrmppal.cdEmp)
            dgvServTecnico.DataSource = _Dt
            dgvServTecnico.Columns.Item("CodUN").Visible = False
            dgvServTecnico.Columns.Item("CodBarra").Visible = False
            dgvServTecnico.Columns.Item("Facturado").Visible = False
            dgvServTecnico.Columns.Item("Clientes_IdClientes").Visible = False
            dgvServTecnico.Columns.Item("Proveedores_IdProveedores").Visible = False

            Dim estiloEnc As New DataGridViewCellStyle()
            Dim textEnc As String = ""
            Dim X As Integer

            'estiloEnc.Font = New Font(dgvServTecnico.Font, FontStyle.Bold)
            dgvServTecnico.ColumnHeadersDefaultCellStyle = estiloEnc
            dgvServTecnico.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            For X = 1 To 27
                If X = 1 Or X = 2 Or X = 16 Or X = 18 Or X = 19 Or X = 26 Or X = 27 Then
                    dgvServTecnico.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                ElseIf X = 13 Or X = 14 Or X = 17 Or X = 21 Or X = 22 Then
                    dgvServTecnico.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                ElseIf X = 15 Or X = 20 Then
                    dgvServTecnico.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvServTecnico.Columns(X).DefaultCellStyle.Format = "$ #,##0.00"
                Else
                    dgvServTecnico.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                End If
                Select Case X
                    Case 1
                        textEnc = "ID"
                    Case 2
                        textEnc = "COD EMPRESA"
                    Case 3
                        textEnc = "ORDEN"
                    Case 4
                        textEnc = "COD BARRA"
                    Case 5
                        textEnc = "FECHA"
                    Case 6
                        textEnc = "CLIENTE"
                    Case 7
                        textEnc = "TIPO EQUIPO"
                    Case 8
                        textEnc = "DETALLE EQ"
                    Case 9
                        textEnc = "ACCESORIOS"
                    Case 10
                        textEnc = "COD BARRA EQ"
                    Case 11
                        textEnc = "PROBLEMA"
                    Case 12
                        textEnc = "DIAGNOSTICO"
                    Case 13
                        textEnc = "EST. ENTREGA"
                    Case 14
                        textEnc = "FEC ENTREGA"
                    Case 15
                        textEnc = "PRESUPUESTO"
                    Case 16
                        textEnc = "GARANT MESES"
                    Case 17
                        textEnc = "VTO GARANT"
                    Case 18
                        textEnc = "FACTURADO"
                    Case 19
                        textEnc = "TERCERIZADO"
                    Case 20
                        textEnc = "PRESUP PROV"
                    Case 21
                        textEnc = "ENTR PROVEED"
                    Case 22
                        textEnc = "RECEP PROVEED"
                    Case 23
                        textEnc = "OBSERVACIONES"
                    Case 24
                        textEnc = "USUARIO"
                    Case 25
                        textEnc = "ESTADO"
                    Case 26
                        textEnc = "ID PROVEEDOR"
                    Case 27
                        textEnc = "ID CLIENTE"
                End Select
                dgvServTecnico.Columns(X).HeaderText = textEnc
            Next

            txtFecEntrega.Text = Date.Now.Date

            Me.Text = "ENTREGA Y RECEPCION DE SERVICIO TECNICO TERCERIZADO - " & mdifrmppal.encForm
            txtBuscCliente.Select()
        Catch ex As Exception
            MsgBox("No se puede mostrar Servico Técnico !", vbInformation)
        End Try

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim _Ver As New Mostrar
            Dim _Dt As New DataTable
            Dim _Ds As New DataSet
            _Ds.Tables.Add(_Ver.verServicioTecEntregaRecpcionProv(mdifrmppal.cdEmp).Copy)
            Dim _Dv As New DataView(_Ds.Tables(0))

            If chbEntrega.Checked = True Then
                Dim fEn As Date
                fEn = DateAdd(DateInterval.Day, -nudDias.Value, CDate(txtFecEntrega.Text))
                _Dt = _Ver.verServicioTecEntregaRecpcionProvHoy(mdifrmppal.cdEmp, fEn)
                dgvServTecnico.DataSource = _Dt
            Else
                If txtBuscCliente.Text = "" And cbxTercerizado.Text = "" And cbxEstado.Text = "" And txtBuscCdBarra.Text = "" And cbxBuscTEq.Text = "" And txtBuscDescripcion.Text = "" And txtBuscProblema.Text = "" Then
                    MsgBox("Debe ingresar al menos un dato de búsqueda !", vbInformation)
                ElseIf txtBuscCliente.Text <> "" And cbxTercerizado.Text = "" And cbxEstado.Text = "" And txtBuscCdBarra.Text = "" And cbxBuscTEq.Text = "" And txtBuscDescripcion.Text = "" And txtBuscProblema.Text = "" Then
                    If IsNumeric(txtBuscCliente.Text) Then
                        _Dv.RowFilter = "Clientes_IdClientes = " & CInt(txtBuscCliente.Text)
                    Else
                        MsgBox("Error: Solo se admiten números !", vbInformation, "Servicio de Alertas")
                        txtBuscCliente.Text = ""
                        txtBuscCliente.Select()
                    End If
                ElseIf txtBuscCliente.Text = "" And cbxTercerizado.Text <> "" And cbxEstado.Text = "" And txtBuscCdBarra.Text = "" And cbxBuscTEq.Text = "" And txtBuscDescripcion.Text = "" And txtBuscProblema.Text = "" Then
                    _Dv.RowFilter = "Tercerizado Like '%" & cbxTercerizado.Text & "%'"
                ElseIf txtBuscCliente.Text = "" And cbxTercerizado.Text = "" And cbxEstado.Text <> "" And txtBuscCdBarra.Text = "" And cbxBuscTEq.Text = "" And txtBuscDescripcion.Text = "" And txtBuscProblema.Text = "" Then
                    _Dv.RowFilter = "Estado Like '%" & cbxEstado.Text & "%'"
                ElseIf txtBuscCliente.Text = "" And cbxTercerizado.Text = "" And cbxEstado.Text = "" And txtBuscCdBarra.Text <> "" And cbxBuscTEq.Text = "" And txtBuscDescripcion.Text = "" And txtBuscProblema.Text = "" Then
                    _Dv.RowFilter = "CodBarra Like '%" & Mid(txtBuscCdBarra.Text, 5, 8) & "%'"
                ElseIf txtBuscCliente.Text = "" And cbxTercerizado.Text = "" And cbxEstado.Text = "" And txtBuscCdBarra.Text = "" And cbxBuscTEq.Text <> "" And txtBuscDescripcion.Text = "" And txtBuscProblema.Text = "" Then
                    _Dv.RowFilter = "TipoEquipo Like '%" & cbxBuscTEq.Text & "%'"
                ElseIf txtBuscCliente.Text = "" And cbxTercerizado.Text = "" And cbxEstado.Text = "" And txtBuscCdBarra.Text = "" And cbxBuscTEq.Text = "" And txtBuscDescripcion.Text <> "" And txtBuscProblema.Text = "" Then
                    _Dv.RowFilter = "DetalleEquipo Like '%" & txtBuscDescripcion.Text & "%'"
                ElseIf txtBuscCliente.Text = "" And cbxTercerizado.Text = "" And cbxEstado.Text = "" And txtBuscCdBarra.Text = "" And cbxBuscTEq.Text = "" And txtBuscDescripcion.Text = "" And txtBuscProblema.Text <> "" Then
                    _Dv.RowFilter = "Problema Like '%" & txtBuscProblema.Text & "%'"
                Else
                    MsgBox("Sólo se permite un dato de búsqueda !", vbInformation)
                End If
            End If

            If chbEntrega.Checked = True Then
                dgvServTecnico.Columns.Item("CodUN").Visible = False
                dgvServTecnico.Columns.Item("CodBarra").Visible = False
                dgvServTecnico.Columns.Item("Facturado").Visible = False
                dgvServTecnico.Columns.Item("Clientes_IdClientes").Visible = False
                dgvServTecnico.Columns.Item("Proveedores_IdProveedores").Visible = False

                Dim estiloEnc As New DataGridViewCellStyle()
                Dim textEnc As String = ""
                Dim X As Integer

                'estiloEnc.Font = New Font(dgvServTecnico.Font, FontStyle.Bold)
                dgvServTecnico.ColumnHeadersDefaultCellStyle = estiloEnc
                dgvServTecnico.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                For X = 1 To 27
                    If X = 1 Or X = 2 Or X = 16 Or X = 18 Or X = 19 Or X = 26 Or X = 27 Then
                        dgvServTecnico.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    ElseIf X = 13 Or X = 14 Or X = 17 Or X = 21 Or X = 22 Then
                        dgvServTecnico.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    ElseIf X = 15 Or X = 20 Then
                        dgvServTecnico.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvServTecnico.Columns(X).DefaultCellStyle.Format = "$ #,##0.00"
                    Else
                        dgvServTecnico.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    End If
                    Select Case X
                        Case 1
                            textEnc = "ID"
                        Case 2
                            textEnc = "COD EMPRESA"
                        Case 3
                            textEnc = "ORDEN"
                        Case 4
                            textEnc = "COD BARRA"
                        Case 5
                            textEnc = "FECHA"
                        Case 6
                            textEnc = "CLIENTE"
                        Case 7
                            textEnc = "TIPO EQUIPO"
                        Case 8
                            textEnc = "DETALLE EQ"
                        Case 9
                            textEnc = "ACCESORIOS"
                        Case 10
                            textEnc = "COD BARRA EQ"
                        Case 11
                            textEnc = "PROBLEMA"
                        Case 12
                            textEnc = "DIAGNOSTICO"
                        Case 13
                            textEnc = "EST. ENTREGA"
                        Case 14
                            textEnc = "FEC ENTREGA"
                        Case 15
                            textEnc = "PRESUPUESTO"
                        Case 16
                            textEnc = "GARANT MESES"
                        Case 17
                            textEnc = "VTO GARANT"
                        Case 18
                            textEnc = "FACTURADO"
                        Case 19
                            textEnc = "TERCERIZADO"
                        Case 20
                            textEnc = "PRESUP PROV"
                        Case 21
                            textEnc = "ENTR PROVEED"
                        Case 22
                            textEnc = "RECEP PROVEED"
                        Case 23
                            textEnc = "OBSERVACIONES"
                        Case 24
                            textEnc = "USUARIO"
                        Case 25
                            textEnc = "ESTADO"
                        Case 26
                            textEnc = "ID PROVEEDOR"
                        Case 27
                            textEnc = "ID CLIENTE"
                    End Select
                    dgvServTecnico.Columns(X).HeaderText = textEnc
                Next
            Else
                If _Dv.Count <> 0 Then
                    dgvServTecnico.DataSource = _Dv
                    dgvServTecnico.Columns.Item("CodUN").Visible = False
                    dgvServTecnico.Columns.Item("CodBarra").Visible = False
                    dgvServTecnico.Columns.Item("Diagnostico").Visible = False
                    dgvServTecnico.Columns.Item("FecEntrega").Visible = False
                    dgvServTecnico.Columns.Item("Presupuesto").Visible = False
                    dgvServTecnico.Columns.Item("GarantiaMeses").Visible = False
                    dgvServTecnico.Columns.Item("VtoGarantia").Visible = False
                    dgvServTecnico.Columns.Item("Facturado").Visible = False
                    dgvServTecnico.Columns.Item("Tercerizado").Visible = False
                    dgvServTecnico.Columns.Item("PresupuestoProv").Visible = False
                    dgvServTecnico.Columns.Item("FecEntregaProv").Visible = False
                    dgvServTecnico.Columns.Item("FecRecepcionProv").Visible = False
                    dgvServTecnico.Columns.Item("Clientes_IdClientes").Visible = False
                    dgvServTecnico.Columns.Item("Proveedores_IdProveedores").Visible = False

                    Dim estiloEnc As New DataGridViewCellStyle()
                    Dim textEnc As String = ""
                    Dim X As Integer

                    'estiloEnc.Font = New Font(dgvServTecnico.Font, FontStyle.Bold)
                    dgvServTecnico.ColumnHeadersDefaultCellStyle = estiloEnc
                    dgvServTecnico.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    For X = 1 To 27
                        If X = 1 Or X = 2 Or X = 16 Or X = 18 Or X = 19 Or X = 26 Or X = 27 Then
                            dgvServTecnico.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        ElseIf X = 13 Or X = 14 Or X = 17 Or X = 21 Or X = 22 Then
                            dgvServTecnico.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        ElseIf X = 15 Or X = 20 Then
                            dgvServTecnico.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            dgvServTecnico.Columns(X).DefaultCellStyle.Format = "$ #,##0.00"
                        Else
                            dgvServTecnico.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        End If
                        Select Case X
                            Case 1
                                textEnc = "ID"
                            Case 2
                                textEnc = "COD EMPRESA"
                            Case 3
                                textEnc = "ORDEN"
                            Case 4
                                textEnc = "COD BARRA"
                            Case 5
                                textEnc = "FECHA"
                            Case 6
                                textEnc = "CLIENTE"
                            Case 7
                                textEnc = "TIPO EQUIPO"
                            Case 8
                                textEnc = "DETALLE EQ"
                            Case 9
                                textEnc = "ACCESORIOS"
                            Case 10
                                textEnc = "COD BARRA EQ"
                            Case 11
                                textEnc = "PROBLEMA"
                            Case 12
                                textEnc = "DIAGNOSTICO"
                            Case 13
                                textEnc = "EST. ENTREGA"
                            Case 14
                                textEnc = "FEC ENTREGA"
                            Case 15
                                textEnc = "PRESUPUESTO"
                            Case 16
                                textEnc = "GARANT MESES"
                            Case 17
                                textEnc = "VTO GARANT"
                            Case 18
                                textEnc = "FACTURADO"
                            Case 19
                                textEnc = "TERCERIZADO"
                            Case 20
                                textEnc = "PRESUP PROV"
                            Case 21
                                textEnc = "ENTR PROVEED"
                            Case 22
                                textEnc = "RECEP PROVEED"
                            Case 23
                                textEnc = "OBSERVACIONES"
                            Case 24
                                textEnc = "USUARIO"
                            Case 25
                                textEnc = "ESTADO"
                            Case 26
                                textEnc = "ID PROVEEDOR"
                            Case 27
                                textEnc = "ID CLIENTE"
                        End Select
                        dgvServTecnico.Columns(X).HeaderText = textEnc
                    Next
                Else
                    dgvServTecnico.DataSource = Nothing
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: Problemas con la consulta de Servicio Técnico !", vbInformation)
        End Try
    End Sub

    Private Sub btnTodo_Click(sender As Object, e As EventArgs) Handles btnTodo.Click
        Try
            Dim _Ver As New Mostrar
            Dim _Dt As New DataTable

            _Dt = _Ver.verServicioTecEntregaRecpcionProv(mdifrmppal.cdEmp)
            dgvServTecnico.DataSource = _Dt

            dgvServTecnico.Columns.Item("CodUN").Visible = False
            dgvServTecnico.Columns.Item("CodBarra").Visible = False
            dgvServTecnico.Columns.Item("Diagnostico").Visible = False
            dgvServTecnico.Columns.Item("FecEntrega").Visible = False
            dgvServTecnico.Columns.Item("Presupuesto").Visible = False
            dgvServTecnico.Columns.Item("GarantiaMeses").Visible = False
            dgvServTecnico.Columns.Item("VtoGarantia").Visible = False
            dgvServTecnico.Columns.Item("Facturado").Visible = False
            dgvServTecnico.Columns.Item("Tercerizado").Visible = False
            dgvServTecnico.Columns.Item("PresupuestoProv").Visible = False
            dgvServTecnico.Columns.Item("FecEntregaProv").Visible = False
            dgvServTecnico.Columns.Item("FecRecepcionProv").Visible = False
            dgvServTecnico.Columns.Item("Clientes_IdClientes").Visible = False
            dgvServTecnico.Columns.Item("Proveedores_IdProveedores").Visible = False

            Dim estiloEnc As New DataGridViewCellStyle()
            Dim textEnc As String = ""
            Dim X As Integer

            'estiloEnc.Font = New Font(dgvServTecnico.Font, FontStyle.Bold)
            dgvServTecnico.ColumnHeadersDefaultCellStyle = estiloEnc
            dgvServTecnico.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            For X = 1 To 27
                If X = 1 Or X = 2 Or X = 16 Or X = 18 Or X = 19 Or X = 26 Or X = 27 Then
                    dgvServTecnico.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                ElseIf X = 13 Or X = 14 Or X = 17 Or X = 21 Or X = 22 Then
                    dgvServTecnico.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                ElseIf X = 15 Or X = 20 Then
                    dgvServTecnico.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvServTecnico.Columns(X).DefaultCellStyle.Format = "$ #,##0.00"
                Else
                    dgvServTecnico.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                End If
                Select Case X
                    Case 1
                        textEnc = "ID"
                    Case 2
                        textEnc = "COD EMPRESA"
                    Case 3
                        textEnc = "ORDEN"
                    Case 4
                        textEnc = "COD BARRA"
                    Case 5
                        textEnc = "FECHA"
                    Case 6
                        textEnc = "CLIENTE"
                    Case 7
                        textEnc = "TIPO EQUIPO"
                    Case 8
                        textEnc = "DETALLE EQ"
                    Case 9
                        textEnc = "ACCESORIOS"
                    Case 10
                        textEnc = "COD BARRA EQ"
                    Case 11
                        textEnc = "PROBLEMA"
                    Case 12
                        textEnc = "DIAGNOSTICO"
                    Case 13
                        textEnc = "EST. ENTREGA"
                    Case 14
                        textEnc = "FEC ENTREGA"
                    Case 15
                        textEnc = "PRESUPUESTO"
                    Case 16
                        textEnc = "GARANT MESES"
                    Case 17
                        textEnc = "VTO GARANT"
                    Case 18
                        textEnc = "FACTURADO"
                    Case 19
                        textEnc = "TERCERIZADO"
                    Case 20
                        textEnc = "PRESUP PROV"
                    Case 21
                        textEnc = "ENTR PROVEED"
                    Case 22
                        textEnc = "RECEP PROVEED"
                    Case 23
                        textEnc = "OBSERVACIONES"
                    Case 24
                        textEnc = "USUARIO"
                    Case 25
                        textEnc = "ESTADO"
                    Case 26
                        textEnc = "ID PROVEEDOR"
                    Case 27
                        textEnc = "ID CLIENTE"
                End Select
                dgvServTecnico.Columns(X).HeaderText = textEnc
            Next
        Catch ex As Exception
            MsgBox("Error: Problemas con la consulta de Servicio Técnico !", vbInformation)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtBuscCliente.Text = ""
        txtCliente.Text = ""
        cbxTercerizado.Text = ""
        cbxEstado.Text = ""
        txtBuscCdBarra.Text = ""
        cbxBuscTEq.Text = ""
        txtBuscDescripcion.Text = ""
        txtBuscProblema.Text = ""
    End Sub

    Private Sub dgvServTecnico_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServTecnico.CellContentClick
        If e.ColumnIndex = Me.dgvServTecnico.Columns.Item("Marcar").Index Then
            Dim celSel As DataGridViewCheckBoxCell = Me.dgvServTecnico.Rows(e.RowIndex).Cells("Marcar")
            celSel.Value = Not celSel.Value
        End If
    End Sub

    Private Sub btnEntregado_Click(sender As Object, e As EventArgs) Handles btnEntregado.Click
        Dim resP As DialogResult
        Dim _Elim As New GrabaDatos

        resP = MessageBox.Show("Registra ENTREGA A TERCEROS de Equipos y/o Artículos Seleccionados!?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If resP = Windows.Forms.DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dgvServTecnico.Rows
                    Dim seL As Boolean = Convert.ToBoolean(row.Cells("Marcar").Value)

                    If seL = True Then
                        Dim IdSTent As Integer = Convert.ToInt32(row.Cells("IdServicioTecnico").Value)
                        _Elim.Grabar("Servcio Tecnico", "NoImagen", "modSTEntregaTerceros", IdSTent, "Si", _
                                     Format(CDate(Date.Now.Date), "yyyy/MM/dd"), "En Reparacion Terceros")
                    End If
                Next

                'Actualizo el datagridview
                Dim _Ver As New Mostrar
                Dim _Dt As New DataTable

                _Dt = _Ver.verServicioTecEntregaRecpcionProv(mdifrmppal.cdEmp)
                dgvServTecnico.DataSource = _Dt

                dgvServTecnico.Columns.Item("CodUN").Visible = False
                dgvServTecnico.Columns.Item("CodBarra").Visible = False
                dgvServTecnico.Columns.Item("Diagnostico").Visible = False
                dgvServTecnico.Columns.Item("FecEntrega").Visible = False
                dgvServTecnico.Columns.Item("Presupuesto").Visible = False
                dgvServTecnico.Columns.Item("GarantiaMeses").Visible = False
                dgvServTecnico.Columns.Item("VtoGarantia").Visible = False
                dgvServTecnico.Columns.Item("Facturado").Visible = False
                dgvServTecnico.Columns.Item("Tercerizado").Visible = False
                dgvServTecnico.Columns.Item("PresupuestoProv").Visible = False
                dgvServTecnico.Columns.Item("FecEntregaProv").Visible = False
                dgvServTecnico.Columns.Item("FecRecepcionProv").Visible = False
                dgvServTecnico.Columns.Item("Clientes_IdClientes").Visible = False
                dgvServTecnico.Columns.Item("Proveedores_IdProveedores").Visible = False

                Dim estiloEnc As New DataGridViewCellStyle()
                Dim textEnc As String = ""
                Dim X As Integer

                'estiloEnc.Font = New Font(dgvServTecnico.Font, FontStyle.Bold)
                dgvServTecnico.ColumnHeadersDefaultCellStyle = estiloEnc
                dgvServTecnico.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                For X = 1 To 27
                    If X = 1 Or X = 2 Or X = 16 Or X = 18 Or X = 19 Or X = 26 Or X = 27 Then
                        dgvServTecnico.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    ElseIf X = 13 Or X = 14 Or X = 17 Or X = 21 Or X = 22 Then
                        dgvServTecnico.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    ElseIf X = 15 Or X = 20 Then
                        dgvServTecnico.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvServTecnico.Columns(X).DefaultCellStyle.Format = "$ #,##0.00"
                    Else
                        dgvServTecnico.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    End If
                    Select Case X
                        Case 1
                            textEnc = "ID"
                        Case 2
                            textEnc = "COD EMPRESA"
                        Case 3
                            textEnc = "ORDEN"
                        Case 4
                            textEnc = "COD BARRA"
                        Case 5
                            textEnc = "FECHA"
                        Case 6
                            textEnc = "CLIENTE"
                        Case 7
                            textEnc = "TIPO EQUIPO"
                        Case 8
                            textEnc = "DETALLE EQ"
                        Case 9
                            textEnc = "ACCESORIOS"
                        Case 10
                            textEnc = "COD BARRA EQ"
                        Case 11
                            textEnc = "PROBLEMA"
                        Case 12
                            textEnc = "DIAGNOSTICO"
                        Case 13
                            textEnc = "EST. ENTREGA"
                        Case 14
                            textEnc = "FEC ENTREGA"
                        Case 15
                            textEnc = "PRESUPUESTO"
                        Case 16
                            textEnc = "GARANT MESES"
                        Case 17
                            textEnc = "VTO GARANT"
                        Case 18
                            textEnc = "FACTURADO"
                        Case 19
                            textEnc = "TERCERIZADO"
                        Case 20
                            textEnc = "PRESUP PROV"
                        Case 21
                            textEnc = "ENTR PROVEED"
                        Case 22
                            textEnc = "RECEP PROVEED"
                        Case 23
                            textEnc = "OBSERVACIONES"
                        Case 24
                            textEnc = "USUARIO"
                        Case 25
                            textEnc = "ESTADO"
                        Case 26
                            textEnc = "ID PROVEEDOR"
                        Case 27
                            textEnc = "ID CLIENTE"
                    End Select
                    dgvServTecnico.Columns(X).HeaderText = textEnc
                Next
            Catch ex As MySqlException
                MsgBox("Error al Eliminar Clientes !" & vbCrLf & vbCrLf & ex.ToString, vbCritical, "Servicio de Alertas")
            End Try
        End If
    End Sub

    Private Sub btnRecibido_Click(sender As Object, e As EventArgs) Handles btnRecibido.Click
        Dim resP As DialogResult
        Dim _Elim As New GrabaDatos

        resP = MessageBox.Show("Registra RECEPCION DE TERCEROS de Equipos y/o Artículos Seleccionados!?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If resP = Windows.Forms.DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dgvServTecnico.Rows

                    Dim seL As Boolean = Convert.ToBoolean(row.Cells("Marcar").Value)

                    If seL = True Then
                        Dim IdSTent As Integer = Convert.ToInt32(row.Cells("IdServicioTecnico").Value)
                        _Elim.Grabar("Servcio Tecnico", "NoImagen", "modSTRecepcionTerceros", IdSTent, _
                                     Format(CDate(Date.Now.Date), "yyyy/MM/dd"), "Devuelto Por Terceros")
                    End If
                Next

                'Actualizo el datagridview
                Dim _Ver As New Mostrar
                Dim _Dt As New DataTable

                _Dt = _Ver.verServicioTecEntregaRecpcionProv(mdifrmppal.cdEmp)
                dgvServTecnico.DataSource = _Dt

                dgvServTecnico.Columns.Item("CodUN").Visible = False
                dgvServTecnico.Columns.Item("CodBarra").Visible = False
                dgvServTecnico.Columns.Item("Diagnostico").Visible = False
                dgvServTecnico.Columns.Item("FecEntrega").Visible = False
                dgvServTecnico.Columns.Item("Presupuesto").Visible = False
                dgvServTecnico.Columns.Item("GarantiaMeses").Visible = False
                dgvServTecnico.Columns.Item("VtoGarantia").Visible = False
                dgvServTecnico.Columns.Item("Facturado").Visible = False
                dgvServTecnico.Columns.Item("Tercerizado").Visible = False
                dgvServTecnico.Columns.Item("PresupuestoProv").Visible = False
                dgvServTecnico.Columns.Item("FecEntregaProv").Visible = False
                dgvServTecnico.Columns.Item("FecRecepcionProv").Visible = False
                dgvServTecnico.Columns.Item("Clientes_IdClientes").Visible = False
                dgvServTecnico.Columns.Item("Proveedores_IdProveedores").Visible = False

                Dim estiloEnc As New DataGridViewCellStyle()
                Dim textEnc As String = ""
                Dim X As Integer

                'estiloEnc.Font = New Font(dgvServTecnico.Font, FontStyle.Bold)
                dgvServTecnico.ColumnHeadersDefaultCellStyle = estiloEnc
                dgvServTecnico.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                For X = 1 To 27
                    If X = 1 Or X = 2 Or X = 16 Or X = 18 Or X = 19 Or X = 26 Or X = 27 Then
                        dgvServTecnico.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    ElseIf X = 13 Or X = 14 Or X = 17 Or X = 21 Or X = 22 Then
                        dgvServTecnico.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    ElseIf X = 15 Or X = 20 Then
                        dgvServTecnico.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvServTecnico.Columns(X).DefaultCellStyle.Format = "$ #,##0.00"
                    Else
                        dgvServTecnico.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    End If
                    Select Case X
                        Case 1
                            textEnc = "ID"
                        Case 2
                            textEnc = "COD EMPRESA"
                        Case 3
                            textEnc = "ORDEN"
                        Case 4
                            textEnc = "COD BARRA"
                        Case 5
                            textEnc = "FECHA"
                        Case 6
                            textEnc = "CLIENTE"
                        Case 7
                            textEnc = "TIPO EQUIPO"
                        Case 8
                            textEnc = "DETALLE EQ"
                        Case 9
                            textEnc = "ACCESORIOS"
                        Case 10
                            textEnc = "COD BARRA EQ"
                        Case 11
                            textEnc = "PROBLEMA"
                        Case 12
                            textEnc = "DIAGNOSTICO"
                        Case 13
                            textEnc = "EST. ENTREGA"
                        Case 14
                            textEnc = "FEC ENTREGA"
                        Case 15
                            textEnc = "PRESUPUESTO"
                        Case 16
                            textEnc = "GARANT MESES"
                        Case 17
                            textEnc = "VTO GARANT"
                        Case 18
                            textEnc = "FACTURADO"
                        Case 19
                            textEnc = "TERCERIZADO"
                        Case 20
                            textEnc = "PRESUP PROV"
                        Case 21
                            textEnc = "ENTR PROVEED"
                        Case 22
                            textEnc = "RECEP PROVEED"
                        Case 23
                            textEnc = "OBSERVACIONES"
                        Case 24
                            textEnc = "USUARIO"
                        Case 25
                            textEnc = "ESTADO"
                        Case 26
                            textEnc = "ID PROVEEDOR"
                        Case 27
                            textEnc = "ID CLIENTE"
                    End Select
                    dgvServTecnico.Columns(X).HeaderText = textEnc
                Next
            Catch ex As MySqlException
                MsgBox("Error al Eliminar Clientes !" & vbCrLf & vbCrLf & ex.ToString, vbCritical, "Servicio de Alertas")
            End Try
        End If
    End Sub

    Private Sub txtBuscCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscCliente.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                If txtBuscCliente.Text = "" Then
                    e.Handled = True
                    frmClientes.lblOrigen.Text = "Servicio Tecnico Entrega Prov"
                    frmClientes.txtBuscar.Text = ""
                    frmClientes.txtBuscar.Select()
                    frmClientes.ShowDialog()
                Else
                    e.Handled = True
                    If IsNumeric(txtBuscCliente.Text) Then
                        Dim _Ver As New Mostrar
                        Dim _Ds As New DataSet
                        _Ds.Tables.Add(_Ver.verClientes(mdifrmppal.cdEmp).Copy)
                        Dim _Dv As New DataView(_Ds.Tables(0))
                        _Dv.RowFilter = "IdClientes = " & CInt(txtBuscCliente.Text)
                        If _Dv.Count <> 0 Then
                            dgvCliente.DataSource = _Dv
                            dgvCliente.Select()
                            txtCliente.Text = dgvCliente.SelectedCells.Item(4).Value
                            btnBuscar.Select()
                        Else
                            MsgBox("Error: Nro de Cuenta no se corresponde con ningún cliente !", vbInformation, "Servicio de Alertas")
                            txtCliente.Text = ""
                            txtBuscCliente.Text = ""
                            txtBuscCliente.Select()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: Problemas con la consulta de Servicio Técnico !", vbInformation)
        End Try
    End Sub

    Private Sub btnImpStock_Click(sender As Object, e As EventArgs) Handles btnImpStock.Click
        frmInfEntregaTerceros.ShowDialog()
    End Sub

    Private Sub btnMarcarTodo_Click(sender As Object, e As EventArgs) Handles btnMarcarTodo.Click
        For i As Integer = 0 To dgvServTecnico.Rows.Count - 1
            Dim celSel As DataGridViewCheckBoxCell = dgvServTecnico.Rows(i).Cells("Marcar")
            celSel.Value = True
        Next
    End Sub

 
    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        For i As Integer = 0 To dgvServTecnico.Rows.Count - 1
            Dim celSel As DataGridViewCheckBoxCell = dgvServTecnico.Rows(i).Cells("Marcar")
            celSel.Value = False
        Next
    End Sub

    Private Sub txtBuscCliente_TextChanged(sender As Object, e As EventArgs) Handles txtBuscCliente.TextChanged

    End Sub
End Class