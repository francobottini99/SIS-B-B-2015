Public Class frmServTecnico

    Private Sub btnNuevo_GotFocus(sender As Object, e As EventArgs) Handles btnNuevo.GotFocus
        btnNuevo.BackgroundImage = ByB_SI.My.Resources.NuevoAc
    End Sub

    Private Sub btnNuevo_LostFocus(sender As Object, e As EventArgs) Handles btnNuevo.LostFocus
        btnNuevo.BackgroundImage = ByB_SI.My.Resources.NuevoIn
    End Sub

    Private Sub btnNuevo_MouseEnter(sender As Object, e As EventArgs) Handles btnNuevo.MouseEnter
        btnNuevo.BackgroundImage = ByB_SI.My.Resources.NuevoAc
    End Sub

    Private Sub btnNuevo_MouseLeave(sender As Object, e As EventArgs) Handles btnNuevo.MouseLeave
        btnNuevo.BackgroundImage = ByB_SI.My.Resources.NuevoIn
    End Sub

    Private Sub btnGuardar_GotFocus(sender As Object, e As EventArgs) Handles btnGuardar.GotFocus
        btnGuardar.BackgroundImage = ByB_SI.My.Resources.GuardarAc
    End Sub

    Private Sub btnGuardar_LostFocus(sender As Object, e As EventArgs) Handles btnGuardar.LostFocus
        btnGuardar.BackgroundImage = ByB_SI.My.Resources.GuardarIn
    End Sub

    Private Sub btnGuardar_MouseEnter(sender As Object, e As EventArgs) Handles btnGuardar.MouseEnter
        btnGuardar.BackgroundImage = ByB_SI.My.Resources.GuardarAc
    End Sub

    Private Sub btnGuardar_MouseLeave(sender As Object, e As EventArgs) Handles btnGuardar.MouseLeave
        btnGuardar.BackgroundImage = ByB_SI.My.Resources.GuardarIn
    End Sub

    Private Sub btnCancelar_GotFocus(sender As Object, e As EventArgs) Handles btnCancelar.GotFocus
        btnCancelar.BackgroundImage = ByB_SI.My.Resources.CancelarAc
    End Sub

    Private Sub btnCancelar_LostFocus(sender As Object, e As EventArgs) Handles btnCancelar.LostFocus
        btnCancelar.BackgroundImage = ByB_SI.My.Resources.CancelarIn
    End Sub

    Private Sub btnCancelar_MouseEnter(sender As Object, e As EventArgs) Handles btnCancelar.MouseEnter
        btnCancelar.BackgroundImage = ByB_SI.My.Resources.CancelarAc
    End Sub

    Private Sub btnCancelar_MouseLeave(sender As Object, e As EventArgs) Handles btnCancelar.MouseLeave
        btnCancelar.BackgroundImage = ByB_SI.My.Resources.CancelarIn
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

    Private Sub btnModificar_GotFocus(sender As Object, e As EventArgs) Handles btnModificar.GotFocus
        btnModificar.BackgroundImage = ByB_SI.My.Resources.ModifAc
    End Sub

    Private Sub btnModificar_LostFocus(sender As Object, e As EventArgs) Handles btnModificar.LostFocus
        btnModificar.BackgroundImage = ByB_SI.My.Resources.ModifIn
    End Sub
    Private Sub btnModificar_MouseEnter(sender As Object, e As EventArgs) Handles btnModificar.MouseEnter
        btnModificar.BackgroundImage = ByB_SI.My.Resources.ModifAc
    End Sub

    Private Sub btnModificar_MouseLeave(sender As Object, e As EventArgs) Handles btnModificar.MouseLeave
        btnModificar.BackgroundImage = ByB_SI.My.Resources.ModifIn
    End Sub

    Private Sub btnEliminar_GotFocus(sender As Object, e As EventArgs) Handles btnEliminar.GotFocus
        btnEliminar.BackgroundImage = ByB_SI.My.Resources.EliminarAc
    End Sub

    Private Sub btnEliminar_LostFocus(sender As Object, e As EventArgs) Handles btnEliminar.LostFocus
        btnEliminar.BackgroundImage = ByB_SI.My.Resources.EliminarIn
    End Sub

    Private Sub btnEliminar_MouseEnter(sender As Object, e As EventArgs) Handles btnEliminar.MouseEnter
        btnEliminar.BackgroundImage = ByB_SI.My.Resources.EliminarAc
    End Sub

    Private Sub btnEliminar_MouseLeave(sender As Object, e As EventArgs) Handles btnEliminar.MouseLeave
        btnEliminar.BackgroundImage = ByB_SI.My.Resources.EliminarIn
    End Sub

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

    Private Sub frmSevTecnico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim _Ver As New Mostrar
            Dim _Dt As New DataTable

            _Dt = _Ver.verServicioTecnico(mdifrmppal.cdEmp)
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

            'ACTUALIZO NUMERO ORDEN
            Dim _Ver1 As New Mostrar
            Dim _Dt1 As New DataTable
            _Dt1 = _Ver1.verSistema(mdifrmppal.cdEmp)
            Dim _Row1 As DataRow = _Dt1.Rows(_Dt1.Rows.Count - 1)
            txtNroOrden.Text = CStr(_Row1("OrdServTecnico"))
            txtCodBarra.Text = "*" & txtNroOrden.Text & "*"
            lblOrdNueva.Text = txtNroOrden.Text

            Me.Text = "ALTAS DE SERVICIO TECNICO - " & mdifrmppal.encForm
        Catch ex As Exception
            MsgBox("No se puede mostrar Servico Técnico !", vbInformation)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Limpiar()
        Me.Hide()
    End Sub

    Private Sub txtIdCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdCliente.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If txtIdCliente.Text = "" Then
                e.Handled = True
                frmClientes.lblOrigen.Text = "Servicio Tecnico"
                frmClientes.txtBuscar.Select()
                frmClientes.ShowDialog()
            Else
                e.Handled = True
                If IsNumeric(txtIdCliente.Text) Then
                    Dim _Ver As New Mostrar
                    Dim _Ds As New DataSet
                    _Ds.Tables.Add(_Ver.verClientes(mdifrmppal.cdEmp).Copy)
                    Dim _Dv As New DataView(_Ds.Tables(0))
                    _Dv.RowFilter = "IdClientes = " & CInt(txtIdCliente.Text)
                    If _Dv.Count <> 0 Then
                        dgvCliente.DataSource = _Dv
                        dgvCliente.Select()
                        txtCliente.Text = dgvCliente.SelectedCells.Item(4).Value
                        txtTE.Text = dgvCliente.SelectedCells.Item(10).Value
                        txtCdBarrEq.Select()
                    Else
                        MsgBox("Error: Nro de Cuenta no se corresponde con ningún cliente !", vbInformation, "Servicio de Alertas")
                        txtCliente.Text = ""
                        txtIdCliente.Text = ""
                        txtTE.Text = ""
                        txtIdCliente.Select()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtIdProv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdProv.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If txtIdProv.Text = "" Then
                e.Handled = True
                frmProveedores.lblOrigen.Text = "Servicio Tecnico"
                frmProveedores.txtBuscar.Select()
                frmProveedores.Show()
            Else
                e.Handled = True
                If IsNumeric(txtIdProv.Text) Then
                    Dim _Ver As New Mostrar
                    Dim _Ds As New DataSet
                    _Ds.Tables.Add(_Ver.verProveedores(mdifrmppal.cdEmp).Copy)
                    Dim _Dv As New DataView(_Ds.Tables(0))
                    _Dv.RowFilter = "IdProveedores = " & CInt(txtIdProv.Text)
                    If _Dv.Count <> 0 Then
                        dgvProveedor.DataSource = _Dv
                        dgvProveedor.Select()
                        txtProveedor.Text = dgvProveedor.SelectedCells.Item(4).Value
                        btnGuardar.Select()
                    Else
                        MsgBox("Error: Nro de Cuenta no se corresponde con ningún proveedor !", vbInformation, "Servicio de Alertas")
                        txtProveedor.Text = ""
                        txtIdProv.Text = ""
                        txtIdProv.Select()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        gbxDatos.Enabled = True
        Limpiar()
        txtCdEmp.Text = mdifrmppal.cdEmp
        txtFecAlta.Text = Date.Now.Date
        txtFecEntrega.Text = DateAdd(DateInterval.Day, 7, CDate(txtFecAlta.Text))
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnCancelar.Enabled = True
        btnGuardar.Enabled = True
        txtIdCliente.Select()
        lblFuncion.Text = "Nuevo"
    End Sub

    Private Sub Limpiar()
        txtCdEmp.Text = ""
        txtIdCliente.Text = ""
        txtFecAlta.Text = ""
        txtCliente.Text = ""
        txtTE.Text = ""
        txtCdBarrEq.Text = ""
        cbxTipoEq.Text = ""
        txtDescripcion.Text = ""
        txtProblema.Text = ""
        txtAccesorios.Text = ""
        txtFecEntrega.Text = ""
        txtObaserv.Text = ""
        cbxTercero.Text = ""
        txtIdProv.Text = ""
        txtProveedor.Text = ""
    End Sub

    Private Sub txtCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCliente.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtTE.SelectionLength = Len(txtTE.Text)
            txtTE.Select()
        End If
    End Sub

    Private Sub txtTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTE.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCdBarrEq.SelectionLength = Len(txtCdBarrEq.Text)
            txtCdBarrEq.Select()
        End If
    End Sub

    Private Sub txtCdBarrEq_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCdBarrEq.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            cbxTipoEq.SelectionLength = Len(cbxTipoEq.Text)
            cbxTipoEq.Select()
        End If
    End Sub

    Private Sub cbxTipoEq_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxTipoEq.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtDescripcion.SelectionLength = Len(txtDescripcion.Text)
            txtDescripcion.Select()
        End If
    End Sub

    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtAccesorios.SelectionLength = Len(txtAccesorios.Text)
            txtAccesorios.Select()
        End If
    End Sub

    Private Sub txtAccesorios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAccesorios.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtProblema.SelectionLength = Len(txtProblema.Text)
            txtProblema.Select()
        End If
    End Sub

    Private Sub txtProblema_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProblema.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtFecEntrega.SelectionLength = Len(txtFecEntrega.Text)
            txtFecEntrega.Select()
        End If
    End Sub

    Private Sub txtFecEntrega_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFecEntrega.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtObaserv.SelectionLength = Len(txtObaserv.Text)
            txtObaserv.Select()
        End If
    End Sub

    Private Sub txtObaserv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtObaserv.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            cbxTercero.SelectionLength = Len(cbxTercero.Text)
            cbxTercero.Select()
        End If
    End Sub

    Private Sub cbxTercero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxTercero.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtIdProv.Enabled = True
            txtIdProv.SelectionLength = Len(txtIdProv.Text)
            txtIdProv.Select()
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim _Guardar As New GrabaDatos
        Dim resP As DialogResult
        Dim ulTid As Integer
        Dim _VerMax As New Mostrar
        Dim _DtMax As New DataTable
        Dim _Ver As New Mostrar
        Dim _Dt As New DataTable

        Try
            If txtCliente.Text = "" Then
                MsgBox("Error: Razón Social es un campo obligatorio.", vbInformation, "Servico de Alertas")
                txtCliente.Select()
            Else
                If txtIdProv.Text = "" Then
                    MsgBox("Error: Proveedor es un campo obligatorio.", vbInformation, "Servico de Alertas")
                    txtIdProv.Select()
                Else
                    If lblFuncion.Text = "Nuevo" Then
                        resP = MessageBox.Show("Grabar Alta de Servico Técnico ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    Else
                        resP = MessageBox.Show("Modifica Orden de Servico Técnico ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    End If
                    If resP = Windows.Forms.DialogResult.OK Then
                        If txtCdBarrEq.Text = "" Then
                            txtCdBarrEq.Text = "CodigoBarraNoIngresado"
                        End If
                        If txtObaserv.Text = "" Then
                            txtObaserv.Text = "-"
                        End If
                        If txtIdProv.Text = "" Then
                            txtIdProv.Text = "-99"
                        End If

                        'ACTUALIZO NUMERO ORDEN
                        Dim _Ver1 As New Mostrar
                        Dim _Dt1 As New DataTable
                        _Dt1 = _Ver1.verSistema(mdiFrmPpal.cdEmp)
                        Dim _Row1 As DataRow = _Dt1.Rows(_Dt1.Rows.Count - 1)
                        txtNroOrden.Text = CStr(_Row1("OrdServTecnico"))
                        txtCodBarra.Text = "*" & txtNroOrden.Text & "*"

                        If lblFuncion.Text = "Nuevo" Then
                            _Guardar.Grabar("Servivio Tecnico", "NoImagen", "insServTecnico", txtCdEmp.Text, txtNroOrden.Text, txtCodBarra.Text, _
                                            Format(CDate(txtFecAlta.Text), "yyyy/MM/dd"), cbxTipoEq.Text, txtDescripcion.Text, _
                                            txtAccesorios.Text, txtCdBarrEq.Text, txtProblema.Text, " ", _
                                            Format(CDate(txtFecEntrega.Text), "yyyy/MM/dd"), Format(CDate(txtFecEntrega.Text), "yyyy/MM/dd"), _
                                            0, 0, Format(CDate(txtFecAlta.Text), "yyyy/MM/dd"), "No", cbxTercero.Text, 0, _
                                            Format(CDate(txtFecAlta.Text), "yyyy/MM/dd"), Format(CDate(txtFecAlta.Text), "yyyy/MM/dd"), _
                                            txtObaserv.Text, mdiFrmPpal.usSis, "En Reparacion ByB", CInt(txtIdProv.Text), CInt(txtIdCliente.Text))
                            lblMsg.ForeColor = Color.LawnGreen
                            lblMsg.Text = "Servicio Técnico Ingresado Exitosamente"
                            lblMsg.Visible = True
                            tmrMensaje.Enabled = True
                        Else
                            _Guardar.Grabar("Servivio Tecnico", "NoImagen", "modServTecnico", CInt(lblIdServTecnico.Text), txtCdEmp.Text, _
                                            txtNroOrden.Text, txtCodBarra.Text, _
                                            Format(CDate(txtFecAlta.Text), "yyyy/MM/dd"), cbxTipoEq.Text, txtDescripcion.Text, _
                                            txtAccesorios.Text, txtCdBarrEq.Text, txtProblema.Text, " ", _
                                            Format(CDate(txtFecEntrega.Text), "yyyy/MM/dd"), cbxTercero.Text, txtObaserv.Text, _
                                            CInt(txtIdProv.Text), CInt(txtIdCliente.Text))
                            lblMsg.ForeColor = Color.LawnGreen
                            lblMsg.Text = "Servicio Técnico Modificado Exitosamente"
                            lblMsg.Visible = True
                            tmrMensaje.Enabled = True
                        End If

                        'Actualizo el TE del Cliente
                        _Guardar.Grabar("Servivio Tecnico", "NoImagen", "modTEClienteST", CInt(txtIdCliente.Text), txtTE.Text)

                        If lblFuncion.Text = "Nuevo" Then
                            'ACTUALIZO NUMERO ORDEN SERVICIO TECNICO
                            Dim X, _inC, _Dig As Integer
                            Dim _reSto As String

                            For X = 5 To 12
                                If Mid(txtNroOrden.Text, X, 1) <> "0" Then
                                    _Dig = 13 - X
                                    Exit For
                                End If
                            Next
                            _inC = Mid(txtNroOrden.Text, 13 - _Dig, _Dig)
                            _inC = _inC + 1
                            _Dig = Len(CStr(_inC))
                            _reSto = Mid(txtNroOrden.Text, 1, 12 - _Dig)
                            txtNroOrden.Text = _reSto & CStr(_inC)
                            lblOrdNueva.Text = txtNroOrden.Text

                            _Guardar.Grabar("Factura Venta", "NoImagen", "modSistemaOrdenST", txtCdEmp.Text, txtNroOrden.Text)

                            'Obtener ultimo ID cargado de Servicio Tecnico
                            _DtMax = _VerMax.verMaxIdServTecnico()
                            Dim _Row As DataRow = _DtMax.Rows(_DtMax.Rows.Count - 1)
                            ulTid = _Row("UltimoId")

                            'Filtro el ultimo registro de Servicio Tecnico
                            _Dt = _Ver.verServicioTecnicoID(ulTid)
                            dgvServTecnico.DataSource = _Dt

                            ImprimirServicioTecnico()
                        Else
                            resP = MessageBox.Show("Reimprime Orden Servicio Tecnico ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                            If resP = Windows.Forms.DialogResult.OK Then
                                ulTid = dgvServTecnico.SelectedCells.Item(1).Value

                                'Filtro el ultimo registro de Servicio Tecnico
                                _Dt = _Ver.verServicioTecnicoID(ulTid)
                                dgvServTecnico.DataSource = _Dt

                                ImprimirServicioTecnico()
                            End If
                            txtNroOrden.Text = lblOrdNueva.Text
                        End If

                        'Actualizo el DataGridView
                        _Dt = _Ver.verServicioTecnico(mdiFrmPpal.cdEmp)
                        dgvServTecnico.DataSource = _Dt

                        gbxDatos.Enabled = False
                        txtIdProv.Enabled = False
                        Limpiar()
                        btnNuevo.Enabled = True
                        btnModificar.Enabled = True
                        btnCancelar.Enabled = False
                        btnGuardar.Enabled = False
                        btnNuevo.Select()
                    End If
                End If
            End If
        Catch ex As MySqlException
            lblMsg.ForeColor = Color.Red
            lblMsg.Text = "Error: Servicio Técnico no ingresado y/o modificado."
            lblMsg.Visible = True
            tmrMensaje.Enabled = True
            MsgBox("Error: Base de datos no fue modificada !" & vbCrLf & vbCrLf & ex.ToString, vbCritical, "Servicio de Alertas")
            BDxxx()
        Finally
            BDxxx()
        End Try
    End Sub

    Private Sub txtTE_Validated(sender As Object, e As EventArgs) Handles txtTE.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errP.SetError(sender, "")
        Else
            Me.errP.SetError(sender, "El campo Teléfono no puede quedar vacío !")
            txtTE.Select()
        End If
    End Sub

    Private Sub cbxTipoEq_Validated(sender As Object, e As EventArgs) Handles cbxTipoEq.Validated
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.errP.SetError(sender, "")
        Else
            Me.errP.SetError(sender, "El campo Tipo de Equipo no puede quedar vacío !")
            cbxTipoEq.Select()
        End If
    End Sub

    Private Sub txtDescripcion_Validated(sender As Object, e As EventArgs) Handles txtDescripcion.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errP.SetError(sender, "")
        Else
            Me.errP.SetError(sender, "El campo Descripción no puede quedar vacío !")
            txtDescripcion.Select()
        End If
    End Sub

    Private Sub txtAccesorios_Validated(sender As Object, e As EventArgs) Handles txtAccesorios.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errP.SetError(sender, "")
        Else
            Me.errP.SetError(sender, "El campo Accesorios no puede quedar vacío !")
            txtAccesorios.Select()
        End If
    End Sub

    Private Sub txtProblema_Validated(sender As Object, e As EventArgs) Handles txtProblema.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errP.SetError(sender, "")
        Else
            Me.errP.SetError(sender, "El campo Problema no puede quedar vacío !")
            txtProblema.Select()
        End If
    End Sub

    Private Sub txtFecAlta_Validated(sender As Object, e As EventArgs) Handles txtFecAlta.Validated
        If Not txtFecAlta.Text = "" Then
            If Not IsDate(txtFecAlta.Text) Then
                MsgBox("Error: Formato de Fecha incorrecto.", vbInformation, "Servico de Alertas")
                txtFecAlta.Text = ""
                txtFecAlta.Select()
            Else
                txtFecAlta.Text = Format(CDate(txtFecAlta.Text), "dd/MM/yyyy")
            End If
        End If
    End Sub

    Private Sub txtFecEntrega_Validated(sender As Object, e As EventArgs) Handles txtFecEntrega.Validated
        If Not txtFecEntrega.Text = "" Then
            If Not IsDate(txtFecEntrega.Text) Then
                MsgBox("Error: Formato de Fecha incorrecto.", vbInformation, "Servico de Alertas")
                txtFecEntrega.Text = ""
                txtFecEntrega.Select()
            Else
                txtFecEntrega.Text = Format(CDate(txtFecEntrega.Text), "dd/MM/yyyy")
            End If
        End If
    End Sub

    Private Sub tmrMensaje_Tick(sender As Object, e As EventArgs) Handles tmrMensaje.Tick
        lblMsg.Visible = False
        tmrMensaje.Enabled = False
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If dgvServTecnico.RowCount > 0 Then
                lblFuncion.Text = "Modificar"
                gbxDatos.Enabled = True
                txtIdProv.Enabled = True
                txtNroOrden.Text = dgvServTecnico.SelectedCells.Item(3).Value
                lblIdServTecnico.Text = dgvServTecnico.SelectedCells.Item(1).Value
                txtCdEmp.Text = dgvServTecnico.SelectedCells.Item(2).Value
                txtNroOrden.Text = dgvServTecnico.SelectedCells.Item(3).Value
                txtFecAlta.Text = dgvServTecnico.SelectedCells.Item(5).Value
                txtIdCliente.Text = dgvServTecnico.SelectedCells.Item(27).Value

                'BUSCO EL CLIENTE EN LA TABLA DE CLIENTES
                Dim _Ver As New Mostrar
                Dim _Ds As New DataSet
                _Ds.Tables.Add(_Ver.verClientes(mdifrmppal.cdEmp).Copy)
                Dim _Dv As New DataView(_Ds.Tables(0))
                _Dv.RowFilter = "IdClientes = " & CInt(txtIdCliente.Text)
                If _Dv.Count <> 0 Then
                    dgvCliente.DataSource = _Dv
                    dgvCliente.Select()
                    txtCliente.Text = dgvCliente.SelectedCells.Item(4).Value
                    txtTE.Text = dgvCliente.SelectedCells.Item(10).Value
                Else
                    MsgBox("Error: Nro de Cuenta no se corresponde con ningún cliente !", vbInformation, "Servicio de Alertas")
                    txtCliente.Text = ""
                    txtIdCliente.Text = ""
                    txtTE.Text = ""
                    txtIdCliente.Select()
                End If

                cbxTipoEq.Text = dgvServTecnico.SelectedCells.Item(7).Value
                txtDescripcion.Text = dgvServTecnico.SelectedCells.Item(8).Value
                txtAccesorios.Text = dgvServTecnico.SelectedCells.Item(9).Value
                txtCdBarrEq.Text = dgvServTecnico.SelectedCells.Item(10).Value
                txtProblema.Text = dgvServTecnico.SelectedCells.Item(11).Value
                txtFecEntrega.Text = dgvServTecnico.SelectedCells.Item(13).Value
                cbxTercero.Text = dgvServTecnico.SelectedCells.Item(19).Value
                txtObaserv.Text = dgvServTecnico.SelectedCells.Item(23).Value
                txtIdProv.Text = dgvServTecnico.SelectedCells.Item(26).Value

                If cbxTercero.Text = "Si" Then
                    Dim _Ver1 As New Mostrar
                    Dim _Ds1 As New DataSet
                    _Ds1.Tables.Add(_Ver.verProveedores(mdifrmppal.cdEmp).Copy)
                    Dim _Dv1 As New DataView(_Ds1.Tables(0))
                    _Dv1.RowFilter = "IdProveedores = " & CInt(txtIdProv.Text)
                    If _Dv1.Count <> 0 Then
                        dgvProveedor.DataSource = _Dv1
                        dgvProveedor.Select()
                        txtProveedor.Text = dgvProveedor.SelectedCells.Item(4).Value
                    Else
                        MsgBox("Error: Nro de Cuenta no se corresponde con ningún proveedor !", vbInformation, "Servicio de Alertas")
                        txtProveedor.Text = ""
                        txtIdProv.Text = ""
                    End If
                End If

                btnNuevo.Enabled = False
                btnModificar.Enabled = False
                btnCancelar.Enabled = True
                btnGuardar.Enabled = True
                txtIdCliente.Select()
            Else
                MsgBox("Error: No hay Servicio Técnico para modificar.", vbInformation, "Servico de Alertas")
            End If
        Catch ex As Exception
            lblFuncion.Text = "Modificar"
            btnNuevo.Enabled = False
            btnModificar.Enabled = False
            btnCancelar.Enabled = True
            btnGuardar.Enabled = True
            MsgBox("Error al modificar el Servicio Técnico !" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        gbxDatos.Enabled = False
        Limpiar()
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnCancelar.Enabled = False
        btnGuardar.Enabled = False
        btnNuevo.Select()
        txtNroOrden.Text = lblOrdNueva.Text
    End Sub

    Private Sub cbxTercero_Validated(sender As Object, e As EventArgs) Handles cbxTercero.Validated
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.errP.SetError(sender, "")
        Else
            Me.errP.SetError(sender, "El campo Tercerizado no puede quedar vacío !")
            cbxTercero.Select()
        End If
    End Sub

    Private Sub dgvServTecnico_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServTecnico.CellContentClick
        If e.ColumnIndex = Me.dgvServTecnico.Columns.Item("Eliminar").Index Then
            Dim celSel As DataGridViewCheckBoxCell = Me.dgvServTecnico.Rows(e.RowIndex).Cells("Eliminar")
            celSel.Value = Not celSel.Value
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim resP As DialogResult
        Dim _Elim As New GrabaDatos

        resP = MessageBox.Show("Elimar Servicio Tecnico Seleccionado!?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If resP = Windows.Forms.DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dgvServTecnico.Rows
                    Dim seL As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If seL = True Then
                        Dim clElim As Integer = Convert.ToInt32(row.Cells("IdServicioTecnico").Value)
                        _Elim.Grabar("Clientes", "NoImagen", "eliServTecnico", clElim)
                    End If
                Next

                'Actualizo el datagridview
                Dim _mAut As New Mostrar
                Dim _dT As New DataTable

                _dT = _mAut.verServicioTecnico(mdifrmppal.cdEmp)

                If _dT.Rows.Count <> 0 Then
                    dgvServTecnico.DataSource = _dT
                    dgvServTecnico.ColumnHeadersVisible = True
                    btnEliminar.Enabled = True
                Else
                    dgvServTecnico.DataSource = Nothing
                    btnEliminar.Enabled = False
                End If
            Catch ex As MySqlException
                MsgBox("Error al Eliminar Servicio Técnico !" & vbCrLf & vbCrLf & ex.ToString, vbCritical, "Servicio de Alertas")
            End Try
        End If

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim _Ver As New Mostrar
            Dim _Ds As New DataSet
            _Ds.Tables.Add(_Ver.verServicioTecnico(mdifrmppal.cdEmp).Copy)
            Dim _Dv As New DataView(_Ds.Tables(0))

            If txtBuscCliente.Text = "" And txtBuscCdBarra.Text = "" And cbxBuscTEq.Text = "" And txtBuscDescripcion.Text = "" And txtBuscProblema.Text = "" Then
                MsgBox("Debe ingresar al menos un dato de búsqueda !", vbInformation)
            ElseIf txtBuscCliente.Text <> "" And txtBuscCdBarra.Text = "" And cbxBuscTEq.Text = "" And txtBuscDescripcion.Text = "" And txtBuscProblema.Text = "" Then
                If IsNumeric(txtBuscCliente.Text) Then
                    _Dv.RowFilter = "Clientes_IdClientes = " & CInt(txtBuscCliente.Text)
                Else
                    MsgBox("Error: Solo se admiten números !", vbInformation, "Servicio de Alertas")
                    txtBuscCliente.Text = ""
                    txtBuscCliente.Select()
                End If
            ElseIf txtBuscCliente.Text = "" And txtBuscCdBarra.Text <> "" And cbxBuscTEq.Text = "" And txtBuscDescripcion.Text = "" And txtBuscProblema.Text = "" Then
                _Dv.RowFilter = "EquipoCodBarra Like '%" & Mid(txtBuscCdBarra.Text, 5, 8) & "%'"
            ElseIf txtBuscCliente.Text = "" And txtBuscCdBarra.Text = "" And cbxBuscTEq.Text <> "" And txtBuscDescripcion.Text = "" And txtBuscProblema.Text = "" Then
                _Dv.RowFilter = "TipoEquipo Like '%" & cbxBuscTEq.Text & "%'"
            ElseIf txtBuscCliente.Text = "" And txtBuscCdBarra.Text = "" And cbxBuscTEq.Text = "" And txtBuscDescripcion.Text <> "" And txtBuscProblema.Text = "" Then
                _Dv.RowFilter = "DetalleEquipo Like '%" & txtBuscDescripcion.Text & "%'"
            ElseIf txtBuscCliente.Text = "" And txtBuscCdBarra.Text = "" And cbxBuscTEq.Text = "" And txtBuscDescripcion.Text = "" And txtBuscProblema.Text <> "" Then
                _Dv.RowFilter = "Problema Like '%" & txtBuscProblema.Text & "%'"
            Else
                MsgBox("Sólo se permite un dato de búsqueda !", vbInformation)
            End If

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
        Catch ex As Exception
            MsgBox("Error: Problemas con la consulta de Servicio Técnico !", vbInformation)
        End Try
    End Sub

    Private Sub btnTodo_Click_1(sender As Object, e As EventArgs) Handles btnTodo.Click
        Try
            Dim _Ver As New Mostrar
            Dim _Dt As New DataTable

            _Dt = _Ver.verServicioTecnico(mdifrmppal.cdEmp)
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
            MsgBox("No se puede mostrar Servico Técnico !", vbInformation)
        End Try
    End Sub

    Private Sub btnLimpiar_Click_1(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtBuscCliente.Text = ""
        txtBuscCdBarra.Text = ""
        cbxBuscTEq.Text = ""
        txtBuscDescripcion.Text = ""
        txtBuscProblema.Text = ""
    End Sub

    Private Sub txtBuscCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscCliente.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                If txtBuscCliente.Text = "" Then
                    e.Handled = True
                    frmClientes.lblOrigen.Text = "Servicio Tecnico Buscar"
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
                            btnBuscar.Select()
                        Else
                            MsgBox("Error: Nro de Cuenta no se corresponde con ningún cliente !", vbInformation, "Servicio de Alertas")
                            txtBuscCliente.Text = ""
                            txtBuscCliente.Select()
                        End If
                    Else
                        MsgBox("Error: Solo se admiten números !", vbInformation, "Servicio de Alertas")
                        txtBuscCliente.Text = ""
                        txtBuscCliente.Select()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: Problemas para realizar la consulta !", vbInformation, "Servicio de Alertas")
        End Try
    End Sub

    Private Sub ImprimirServicioTecnico()
        frmInfServTecnico.ShowDialog()
    End Sub

    Private Sub dgvServTecnico_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServTecnico.CellContentDoubleClick
        frmServTecnicoResumen.lblOrigen.Text = "Alta Servicio Tecnico"
        frmServTecnicoResumen.ShowDialog()
    End Sub

End Class