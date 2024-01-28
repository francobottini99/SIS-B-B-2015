Public Class frmSTPresupuestoTerceros

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

    Private Sub btnLimpiar_GotFocus(sender As Object, e As EventArgs) Handles btnLimpiar.GotFocus
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

    Private Sub frmSTDiagPresupuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim _Ver As New Mostrar
            Dim _Dt As New DataTable

            _Dt = _Ver.verServicioTecnicoTerceros(mdifrmppal.cdEmp)
            dgvServTecnico.DataSource = _Dt
            dgvServTecnico.Columns.Item("Eliminar").Visible = False
            dgvServTecnico.Columns.Item("idServicioTecnico").Visible = False
            dgvServTecnico.Columns.Item("CodUN").Visible = False
            dgvServTecnico.Columns.Item("CodBarra").Visible = False
            dgvServTecnico.Columns.Item("TE").Visible = False
            dgvServTecnico.Columns.Item("FecEntrega").Visible = False
            dgvServTecnico.Columns.Item("GarantiaMeses").Visible = False
            dgvServTecnico.Columns.Item("VtoGarantia").Visible = False
            dgvServTecnico.Columns.Item("Facturado").Visible = False
            dgvServTecnico.Columns.Item("Tercerizado").Visible = False
            dgvServTecnico.Columns.Item("Presupuesto").Visible = False
            dgvServTecnico.Columns.Item("Clientes_IdClientes").Visible = False
            dgvServTecnico.Columns.Item("Proveedores_IdProveedores").Visible = False

            Dim estiloEnc As New DataGridViewCellStyle()
            Dim textEnc As String = ""
            Dim X As Integer

            'estiloEnc.Font = New Font(dgvServTecnico.Font, FontStyle.Bold)
            dgvServTecnico.ColumnHeadersDefaultCellStyle = estiloEnc
            dgvServTecnico.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            For X = 1 To 28
                If X = 1 Or X = 2 Or X = 17 Or X = 19 Or X = 20 Or X = 27 Or X = 28 Then
                    dgvServTecnico.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                ElseIf X = 5 Or X = 14 Or X = 15 Or X = 18 Or X = 22 Or X = 23 Then
                    dgvServTecnico.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                ElseIf X = 16 Or X = 21 Then
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
                        textEnc = "TE"
                    Case 8
                        textEnc = "TIPO EQUIPO"
                    Case 9
                        textEnc = "DETALLE EQ"
                    Case 10
                        textEnc = "ACCESORIOS"
                    Case 11
                        textEnc = "COD BARRA EQ"
                    Case 12
                        textEnc = "PROBLEMA"
                    Case 13
                        textEnc = "DIAGNOSTICO"
                    Case 14
                        textEnc = "EST. ENTREGA"
                    Case 15
                        textEnc = "FEC ENTREGA"
                    Case 16
                        textEnc = "PRESUPUESTO"
                    Case 17
                        textEnc = "GARANT MESES"
                    Case 18
                        textEnc = "VTO GARANT"
                    Case 19
                        textEnc = "FACTURADO"
                    Case 20
                        textEnc = "TERCERIZADO"
                    Case 21
                        textEnc = "PRESUP PROV"
                    Case 22
                        textEnc = "ENTR PROVEED"
                    Case 23
                        textEnc = "RECEP PROVEED"
                    Case 24
                        textEnc = "OBSERVACIONES"
                    Case 25
                        textEnc = "USUARIO"
                    Case 26
                        textEnc = "ESTADO"
                    Case 27
                        textEnc = "ID PROVEEDOR"
                    Case 28
                        textEnc = "ID CLIENTE"
                End Select
                dgvServTecnico.Columns(X).HeaderText = textEnc
            Next

            Me.Text = "SERVICIO TECNICO DE TERCEROS: DIAGNOSTICO Y PRESUPUESTO - " & mdifrmppal.encForm
        Catch ex As Exception
            MsgBox("No se puede mostrar Servico Técnico !", vbInformation)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Limpiar()
        Me.Hide()
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
        txtPresupuesto.Text = ""
        txtPresClietne.Text = ""
        txtDiagnostico.Text = ""
        txtBuscCdBarra.Text = ""
        cbxBuscTEq.Text = ""
        txtBuscDescripcion.Text = ""
        txtBuscProblema.Text = ""
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If dgvServTecnico.RowCount > 0 Then
                lblFuncion.Text = "Modificar"
                gbxDatos.Enabled = True
                lblIdServTecnico.Text = dgvServTecnico.SelectedCells.Item(1).Value
                txtCdEmp.Text = dgvServTecnico.SelectedCells.Item(2).Value
                txtNroOrden.Text = dgvServTecnico.SelectedCells.Item(3).Value
                txtFecAlta.Text = dgvServTecnico.SelectedCells.Item(5).Value
                txtIdCliente.Text = dgvServTecnico.SelectedCells.Item(28).Value

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
                    txtTE.Text = dgvCliente.SelectedCells.Item(11).Value
                Else
                    MsgBox("Error: Nro de Cuenta no se corresponde con ningún cliente !", vbInformation, "Servicio de Alertas")
                    txtCliente.Text = ""
                    txtIdCliente.Text = ""
                    txtTE.Text = ""
                    txtDiagnostico.Select()
                End If

                cbxTipoEq.Text = dgvServTecnico.SelectedCells.Item(8).Value
                txtDescripcion.Text = dgvServTecnico.SelectedCells.Item(9).Value
                txtAccesorios.Text = dgvServTecnico.SelectedCells.Item(10).Value
                txtCdBarrEq.Text = dgvServTecnico.SelectedCells.Item(11).Value
                txtProblema.Text = dgvServTecnico.SelectedCells.Item(12).Value
                txtDiagnostico.Text = dgvServTecnico.SelectedCells.Item(13).Value
                txtFecEntrega.Text = dgvServTecnico.SelectedCells.Item(14).Value
                If mdifrmppal.catUsSis = "Administrador" Then
                    txtPresClietne.Visible = True
                    lblPresCli.Visible = True
                    txtPresClietne.Text = Format(CDbl(dgvServTecnico.SelectedCells.Item(16).Value), "$ #,##0.00")
                End If
                txtPresupuesto.Text = Format(CDbl(dgvServTecnico.SelectedCells.Item(21).Value), "$ #,##0.00")
                txtObaserv.Text = dgvServTecnico.SelectedCells.Item(24).Value

                btnModificar.Enabled = False
                btnCancelar.Enabled = True
                btnGuardar.Enabled = True
                txtDiagnostico.Select()
            Else
                MsgBox("Error: No hay Servicio Técnico para modificar.", vbInformation, "Servico de Alertas")
            End If
        Catch ex As Exception
            lblFuncion.Text = "Modificar"
            btnModificar.Enabled = False
            btnCancelar.Enabled = True
            btnGuardar.Enabled = True
            MsgBox("Error al modificar el Servicio Técnico !" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
        End Try
    End Sub

    Private Sub txtDiagnostico_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiagnostico.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtFecEntrega.SelectionLength = Len(txtFecEntrega.Text)
            txtFecEntrega.Select()
        End If
    End Sub

    Private Sub txtDiagnostico_Validated(sender As Object, e As EventArgs) Handles txtDiagnostico.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errP.SetError(sender, "")
        Else
            Me.errP.SetError(sender, "El campo Descripción no puede quedar vacío !")
            txtDiagnostico.Select()
        End If
    End Sub

    Private Sub txtFecEntrega_Validated(sender As Object, e As EventArgs) Handles txtFecEntrega.Validated
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

    Private Sub txtFecEntrega_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFecEntrega.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtPresupuesto.SelectionLength = Len(txtPresupuesto.Text)
            txtPresupuesto.Select()
        End If
    End Sub

    Private Sub txtObaserv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtObaserv.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnGuardar.Select()
        End If
    End Sub

    Private Sub txtPresupuesto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPresupuesto.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtObaserv.SelectionLength = Len(txtObaserv.Text)
            txtObaserv.Select()
        End If
    End Sub

    Private Sub txtPresupuesto_Validated(sender As Object, e As EventArgs) Handles txtPresupuesto.Validated
        If Not txtPresupuesto.Text = "" Then
            If Not IsNumeric(txtPresupuesto.Text) Then
                MsgBox("Error: Formato de Numérico incorrecto.", vbInformation, "Servico de Alertas")
                txtPresupuesto.Text = ""
                txtPresupuesto.Select()
            Else
                txtPresupuesto.Text = Format(CDbl(txtPresupuesto.Text), "$ #,##0.00")
            End If
        Else
            MsgBox("Error: El campo no puede quedar vacío.", vbInformation, "Servico de Alertas")
            txtPresupuesto.Text = ""
            txtPresupuesto.Select()
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim _Guardar As New GrabaDatos
        Dim resP As DialogResult

        Try
            resP = MessageBox.Show("Modificar Servico Técnico ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If txtObaserv.Text = "" Then
                txtObaserv.Text = "-"
            End If
            If txtPresClietne.Text = "" Then
                txtPresClietne.Text = 0
            End If
            If resP = Windows.Forms.DialogResult.OK Then
                _Guardar.Grabar("Servivio Tecnico", "NoImagen", "modDiagyPresupuestoProv", CInt(lblIdServTecnico.Text), txtDiagnostico.Text, _
                                Format(CDate(txtFecEntrega.Text), "yyyy/MM/dd"), CDbl(txtPresupuesto.Text), CDbl(txtPresClietne.Text), txtObaserv.Text)

                'Actualizo el DataGridView
                Dim _Ver As New Mostrar
                Dim _Dt As New DataTable
                _Dt = _Ver.verServicioTecnicoTerceros(mdifrmppal.cdEmp)
                dgvServTecnico.DataSource = _Dt

                gbxDatos.Enabled = False
                Limpiar()
                lblPresCli.Visible = False
                txtPresClietne.Visible = False
                btnModificar.Enabled = True
                btnCancelar.Enabled = False
                btnGuardar.Enabled = False
                btnModificar.Select()

                lblMsg.ForeColor = Color.LawnGreen
                lblMsg.Text = "Servicio Técnico Modificado Exitosamente"
                lblMsg.Visible = True
                tmrMensaje.Enabled = True
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

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        gbxDatos.Enabled = False
        Limpiar()
        lblPresCli.Visible = False
        txtPresClietne.Visible = False
        btnModificar.Enabled = True
        btnCancelar.Enabled = False
        btnGuardar.Enabled = False
        btnModificar.Select()
    End Sub

    Private Sub tmrMensaje_Tick(sender As Object, e As EventArgs) Handles tmrMensaje.Tick
        lblMsg.Visible = False
        tmrMensaje.Enabled = False
    End Sub

    Private Sub txtBuscCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscCliente.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                If txtBuscCliente.Text = "" Then
                    e.Handled = True
                    frmClientes.lblOrigen.Text = "Servicio Tecnico Buscar Terceros"
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

    Private Sub btnBuscar_Click_1(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim _Ver As New Mostrar
            Dim _Ds As New DataSet
            _Ds.Tables.Add(_Ver.verServicioTecnicoTerceros(mdifrmppal.cdEmp).Copy)
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
                _Dv.RowFilter = "CodBarra Like '%" & Mid(txtBuscCdBarra.Text, 5, 8) & "%'"
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
                dgvServTecnico.Columns.Item("Eliminar").Visible = False
                dgvServTecnico.Columns.Item("idServicioTecnico").Visible = False
                dgvServTecnico.Columns.Item("CodBarra").Visible = False
                dgvServTecnico.Columns.Item("FecEntrega").Visible = False
                dgvServTecnico.Columns.Item("GarantiaMeses").Visible = False
                dgvServTecnico.Columns.Item("VtoGarantia").Visible = False
                dgvServTecnico.Columns.Item("Facturado").Visible = False
                dgvServTecnico.Columns.Item("Tercerizado").Visible = False
                dgvServTecnico.Columns.Item("Presupuesto").Visible = False
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

            _Dt = _Ver.verServicioTecnicoTerceros(mdifrmppal.cdEmp)
            dgvServTecnico.DataSource = _Dt
            dgvServTecnico.Columns.Item("Eliminar").Visible = False
            dgvServTecnico.Columns.Item("CodUN").Visible = False
            dgvServTecnico.Columns.Item("idServicioTecnico").Visible = False
            dgvServTecnico.Columns.Item("CodBarra").Visible = False
            dgvServTecnico.Columns.Item("FecEntrega").Visible = False
            dgvServTecnico.Columns.Item("GarantiaMeses").Visible = False
            dgvServTecnico.Columns.Item("VtoGarantia").Visible = False
            dgvServTecnico.Columns.Item("Facturado").Visible = False
            dgvServTecnico.Columns.Item("Tercerizado").Visible = False
            dgvServTecnico.Columns.Item("Presupuesto").Visible = False
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

    Private Sub dgvServTecnico_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServTecnico.CellContentDoubleClick
        frmServTecnicoResumen.lblOrigen.Text = "Terceros"
        frmServTecnicoResumen.ShowDialog()
    End Sub

    Private Sub txtPresClietne_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPresClietne.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnGuardar.Select()
        End If
    End Sub

    Private Sub txtPresClietne_Validated(sender As Object, e As EventArgs) Handles txtPresClietne.Validated
        If Not txtPresClietne.Text = "" Then
            If Not IsNumeric(txtPresClietne.Text) Then
                MsgBox("Error: Formato de Numérico incorrecto.", vbInformation, "Servico de Alertas")
                txtPresClietne.Text = ""
                txtPresClietne.Select()
            Else
                txtPresClietne.Text = Format(CDbl(txtPresClietne.Text), "$ #,##0.00")
            End If
        Else
            MsgBox("Error: El campo no puede quedar vacío.", vbInformation, "Servico de Alertas")
            txtPresClietne.Text = ""
            txtPresClietne.Select()
        End If
    End Sub

    Private Sub dgvServTecnico_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServTecnico.CellContentClick

    End Sub
End Class