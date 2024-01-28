Imports MySql.Data.MySqlClient

Public Class frmProveedores

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim _Guardar As New GrabaDatos
        Dim resP As DialogResult

        Try
            If txtNombre.Text = "" Then
                MsgBox("Error: Razón Social es un campo obligatorio.", vbInformation, "Servico de Alertas")
                txtNombre.Select()
            Else
                resP = MessageBox.Show("Grabar Alta del Proveedor ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If resP = Windows.Forms.DialogResult.OK Then

                    If lblFuncion.Text = "Nuevo" Then
                        _Guardar.Grabar("Proveedores", "NoImagen", "insProveedor", txtCdEmp.Text, txtCodBarra.Text, Format(CDate(txtFecAlta.Text), "yyyy/MM/dd"), txtNombre.Text, txtDireccion.Text, _
                                        txtLocalidad.Text, txtCP.Text, txtProvincia.Text, txtPais.Text, txtTE.Text, txtCuit.Text, txtIB.Text, cbxCatIva.Text, _
                                        txtCodCat.Text, txtMail.Text, txtWeb.Text, txtContacto.Text, txtTEContacto.Text, mdifrmppal.usSis)
                        lblMsg.ForeColor = Color.LawnGreen
                        lblMsg.Text = "Proveedor Ingresado Exitosamente"
                        lblMsg.Visible = True
                        tmrMensaje.Enabled = True
                    Else
                        _Guardar.Grabar("Proveedores", "NoImagen", "modProveedor", lblIdUs.Text, txtCdEmp.Text, txtCodBarra.Text, Format(CDate(txtFecAlta.Text), "yyyy/MM/dd"), txtNombre.Text, txtDireccion.Text, _
                                        txtLocalidad.Text, txtCP.Text, txtProvincia.Text, txtPais.Text, txtTE.Text, txtCuit.Text, txtIB.Text, cbxCatIva.Text, _
                                        txtCodCat.Text, txtMail.Text, txtWeb.Text, txtContacto.Text, txtTEContacto.Text, mdifrmppal.usSis)
                        lblMsg.ForeColor = Color.LawnGreen
                        lblMsg.Text = "Proveedor Modificado Exitosamente"
                        lblMsg.Visible = True
                        tmrMensaje.Enabled = True
                    End If

                    'Actualizo el DataGridView
                    Dim _Ver As New Mostrar
                    Dim _Dt As New DataTable
                    _Dt = _Ver.verProveedores(mdifrmppal.cdEmp)
                    dgvProveedores.DataSource = _Dt

                    'Obtener ultimo ID de proveedores
                    Dim ulTid As Integer
                    If _Dt.Rows.Count <> 0 Then
                        btnEliminar.Enabled = True
                        Dim _VerMax As New Mostrar
                        Dim _DtMax As New DataTable
                        _DtMax = _VerMax.verMaxIdProveedor()
                        Dim _Row As DataRow = _DtMax.Rows(_DtMax.Rows.Count - 1)
                        ulTid = _Row("UltimoId")
                    Else
                        btnEliminar.Enabled = False
                        ulTid = 0
                    End If

                    txtCodBarra.Text = "*" & ulTid + 1 & "*"

                    gbxClientes.Enabled = False
                    Limpiar()
                    btnNuevo.Enabled = True
                    btnModificar.Enabled = True
                    btnCancelar.Enabled = False
                    btnGuardar.Enabled = False
                    btnNuevo.Select()
                End If
            End If
        Catch ex As MySqlException
            lblMsg.ForeColor = Color.Red
            lblMsg.Text = "Error: Proveedor no ingresado y/o modificado."
            lblMsg.Visible = True
            tmrMensaje.Enabled = True
            MsgBox(ex.ToString)
            BDxxx()
        Finally
            BDxxx()
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Limpiar()
        Me.Hide()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            lblFuncion.Text = "Modificar"
            gbxClientes.Enabled = True
            lblIdUs.Text = dgvProveedores.SelectedCells.Item(1).Value
            txtCdEmp.Text = dgvProveedores.SelectedCells.Item(2).Value
            txtFecAlta.Text = dgvProveedores.SelectedCells.Item(4).Value
            txtNombre.Text = dgvProveedores.SelectedCells.Item(5).Value
            txtDireccion.Text = dgvProveedores.SelectedCells.Item(6).Value
            txtLocalidad.Text = dgvProveedores.SelectedCells.Item(7).Value
            txtCP.Text = dgvProveedores.SelectedCells.Item(8).Value
            txtProvincia.Text = dgvProveedores.SelectedCells.Item(9).Value
            txtPais.Text = dgvProveedores.SelectedCells.Item(10).Value
            txtTE.Text = dgvProveedores.SelectedCells.Item(11).Value
            txtCuit.Text = dgvProveedores.SelectedCells.Item(12).Value
            txtIB.Text = dgvProveedores.SelectedCells.Item(13).Value
            cbxCatIva.Text = dgvProveedores.SelectedCells.Item(14).Value
            txtCodCat.Text = dgvProveedores.SelectedCells.Item(15).Value
            txtMail.Text = dgvProveedores.SelectedCells.Item(16).Value
            txtWeb.Text = dgvProveedores.SelectedCells.Item(17).Value
            txtContacto.Text = dgvProveedores.SelectedCells.Item(18).Value
            txtTEContacto.Text = dgvProveedores.SelectedCells.Item(19).Value

            btnNuevo.Enabled = False
            btnModificar.Enabled = False
            btnCancelar.Enabled = True
            btnGuardar.Enabled = True
            txtNombre.Select()
        Catch ex As Exception
            lblFuncion.Text = "Modificar"
            btnNuevo.Enabled = False
            btnModificar.Enabled = False
            btnCancelar.Enabled = True
            btnGuardar.Enabled = True
            txtNombre.Select()
            MsgBox("Error al modificar Proveedor !" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
        End Try
    End Sub

    Private Sub tmrMensaje_Tick(sender As Object, e As EventArgs) Handles tmrMensaje.Tick
        lblMsg.Visible = False
        tmrMensaje.Enabled = False
    End Sub

    Private Sub Limpiar()
        txtCdEmp.Text = ""
        txtNombre.Text = ""
        txtFecAlta.Text = ""
        txtDireccion.Text = ""
        txtLocalidad.Text = ""
        txtCP.Text = ""
        txtProvincia.Text = ""
        txtPais.Text = ""
        txtTE.Text = ""
        txtCuit.Text = ""
        txtIB.Text = ""
        txtCodCat.Text = ""
        cbxCatIva.Text = ""
        txtMail.Text = ""
        txtWeb.Text = ""
        txtContacto.Text = ""
        txtTEContacto.Text = ""
    End Sub

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

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        gbxClientes.Enabled = True
        Limpiar()
        txtCdEmp.Text = mdifrmppal.cdEmp
        txtFecAlta.Text = Date.Now.Date
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnCancelar.Enabled = True
        btnGuardar.Enabled = True
        txtNombre.Select()
        lblFuncion.Text = "Nuevo"
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        gbxClientes.Enabled = False
        Limpiar()
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnCancelar.Enabled = False
        btnGuardar.Enabled = False
        btnNuevo.Select()
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtDireccion.SelectionLength = Len(txtDireccion.Text)
            txtDireccion.Select()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim resP As DialogResult
        Dim _Elim As New GrabaDatos

        resP = MessageBox.Show("Elimar Proveedores Seleccionados!?", "Servicio de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If resP = Windows.Forms.DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dgvProveedores.Rows
                    Dim seL As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If seL = True Then
                        Dim clElim As Integer = Convert.ToInt32(row.Cells("IdClientes").Value)
                        _Elim.Grabar("Proveedores", "NoImagen", "eliProveedor", clElim)
                    End If
                Next

                'Actualizo el datagridview
                Dim _mAut As New Mostrar
                Dim _dT As New DataTable

                _dT = _mAut.verProveedores(mdifrmppal.cdEmp)

                If _dT.Rows.Count <> 0 Then
                    dgvProveedores.DataSource = _dT
                    dgvProveedores.ColumnHeadersVisible = True
                    btnEliminar.Enabled = True
                Else
                    dgvProveedores.DataSource = Nothing
                    btnEliminar.Enabled = False
                End If
            Catch ex As MySqlException
                MsgBox("Error al Eliminar Proveedores !" & vbCrLf & vbCrLf & ex.ToString, vbCritical, "Servicio de Alertas")
            End Try
        End If
    End Sub

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim _Ver As New Mostrar
            Dim _Dt As New DataTable

            _Dt = _Ver.verProveedores(mdifrmppal.cdEmp)
            dgvProveedores.DataSource = _Dt
            dgvProveedores.Columns.Item("CodBarra").Visible = False

            Dim estiloEnc As New DataGridViewCellStyle()
            Dim textEnc As String = ""
            Dim X As Integer

            estiloEnc.Font = New Font(dgvProveedores.Font, FontStyle.Bold)
            dgvProveedores.ColumnHeadersDefaultCellStyle = estiloEnc
            dgvProveedores.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            For X = 1 To 19
                If X = 1 Or X = 2 Or X = 3 Or X = 12 Or X = 13 Or X = 15 Then
                    dgvProveedores.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                ElseIf X = 4 Then
                    dgvProveedores.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Else 'If X = 5 Or X = 6 Or X = 7 Or X = 8 Or X = 9 Or X = 10 Or X = 11 Or X = 14 Or X = 16 Or X = 17 Or X = 18 Or X = 19 Then
                    dgvProveedores.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                End If
                Select Case X
                    Case 1
                        textEnc = "ID"
                    Case 2
                        textEnc = "COD EMPRESA"
                    Case 3
                        textEnc = "COD BARRA"
                    Case 4
                        textEnc = "ALTA"
                    Case 5
                        textEnc = "RAZON SOCIAL"
                    Case 6
                        textEnc = "DIRECCION"
                    Case 7
                        textEnc = "LOCALIDAD"
                    Case 8
                        textEnc = "C. P."
                    Case 9
                        textEnc = "PROVINCIA"
                    Case 10
                        textEnc = "PAIS"
                    Case 11
                        textEnc = "TE"
                    Case 12
                        textEnc = "CUIT"
                    Case 13
                        textEnc = "II BB"
                    Case 14
                        textEnc = "CATEG. IVA"
                    Case 15
                        textEnc = "COD CAT IVA"
                    Case 16
                        textEnc = "MAIL"
                    Case 17
                        textEnc = "PAGINA WEB"
                    Case 18
                        textEnc = "CONTACTO"
                    Case 19
                        textEnc = "TE CONTACTO"
                End Select
                dgvProveedores.Columns(X).HeaderText = textEnc
            Next

            If _Dt.Rows.Count <> 0 Then
                btnEliminar.Enabled = True
            Else
                btnEliminar.Enabled = False
            End If

            'Obtener ultimo ID de proveedores
            Dim ulTid As Integer
            If _Dt.Rows.Count <> 0 Then
                btnEliminar.Enabled = True
                Dim _VerMax As New Mostrar
                Dim _DtMax As New DataTable
                _DtMax = _VerMax.verMaxIdProveedor()
                Dim _Row As DataRow = _DtMax.Rows(_DtMax.Rows.Count - 1)
                ulTid = _Row("UltimoId")
            Else
                btnEliminar.Enabled = False
                ulTid = 0
            End If

            txtCodBarra.Text = "*" & ulTid + 1 & "*"

            Me.Text = "PROVEEDORES - " & mdifrmppal.encForm
        Catch ex As Exception
            MsgBox("No se puede mostrar Proveedores !", vbInformation)
        End Try
    End Sub

    Private Sub txtCuit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuit.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtIB.SelectionLength = Len(txtIB.Text)
            txtIB.Select()
        End If
    End Sub

    Private Sub txtCuit_Validated(sender As Object, e As EventArgs) Handles txtCuit.Validated
        If Len(txtCuit.Text) <> 11 Then
            MsgBox("Error: Cuit Inválido!", vbExclamation)
            txtCuit.Text = ""
            txtCuit.Select()
        Else
            Dim Ct1, Ct2, Ct3 As String
            Ct1 = Mid(txtCuit.Text, 1, 2)
            Ct2 = Mid(txtCuit.Text, 3, 8)
            Ct3 = Mid(txtCuit.Text, 11, 1)
            txtCuit.Text = Ct1 & "-" & Ct2 & "-" & Ct3
        End If
    End Sub

    Private Sub txtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDireccion.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtLocalidad.SelectionLength = Len(txtLocalidad.Text)
            txtLocalidad.Select()
        End If
    End Sub

    Private Sub txtLocalidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLocalidad.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCP.SelectionLength = Len(txtCP.Text)
            txtCP.Select()
        End If
    End Sub

    Private Sub txtCP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCP.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtProvincia.SelectionLength = Len(txtProvincia.Text)
            txtProvincia.Select()
        End If
    End Sub

    Private Sub txtProvincia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProvincia.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtPais.SelectionLength = Len(txtPais.Text)
            txtPais.Select()
        End If
    End Sub

    Private Sub txtPais_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPais.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtTE.SelectionLength = Len(txtTE.Text)
            txtTE.Select()
        End If
    End Sub

    Private Sub txtTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTE.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            cbxCatIva.SelectionLength = Len(cbxCatIva.Text)
            cbxCatIva.Select()
        End If
    End Sub

    Private Sub txtIB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIB.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtMail.SelectionLength = Len(txtMail.Text)
            txtMail.Select()
        End If
    End Sub

    Private Sub cbxCatIva_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCatIva.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            If cbxCatIva.Text = "" Then
                MsgBox("Error: Categoría IVA no puede quedar vacío!", vbExclamation)
                cbxCatIva.Select()
            Else
                If txtCodCat.Text = "CI-05" Or txtCodCat.Text = "CI-07" Then 'Consumidor Final o Sujeto No Categorizado
                    txtCuit.Text = "-"
                    txtIB.SelectionLength = Len(txtIB.Text)
                    txtIB.Select()
                Else
                    txtCuit.SelectionLength = Len(txtCuit.Text)
                    txtCuit.Select()
                End If
            End If
        End If
    End Sub

    Private Sub txtMail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMail.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtWeb.SelectionLength = Len(txtWeb.Text)
            txtWeb.Select()
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            Dim _Ver As New Mostrar
            Dim _Ds As New DataSet
            _Ds.Tables.Add(_Ver.verProveedores(mdifrmppal.cdEmp).Copy)
            Dim _Dv As New DataView(_Ds.Tables(0))

            _Dv.RowFilter = "RazonSocial Like '%" & txtBuscar.Text & "%'"

            If _Dv.Count <> 0 Then
                dgvProveedores.DataSource = _Dv
            Else
                dgvProveedores.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox("Error de consulta de proveedores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
        End Try
    End Sub

    Private Sub txtWeb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWeb.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtContacto.SelectionLength = Len(txtContacto.Text)
            txtContacto.Select()
        End If
    End Sub

    Private Sub txtContacto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContacto.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtTEContacto.SelectionLength = Len(txtTEContacto.Text)
            txtTEContacto.Select()
        End If
    End Sub

    Private Sub txtTEContacto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTEContacto.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnGuardar.Select()
        End If
    End Sub

    Private Sub dgvProveedores_DoubleClick(sender As Object, e As EventArgs) Handles dgvProveedores.DoubleClick
        Try
            If lblOrigen.Text = "Factura Compra" Then
                frmFacturaCompra.txtIdProveedor.Text = dgvProveedores.SelectedCells.Item(1).Value
                frmFacturaCompra.txtProveedor.Text = dgvProveedores.SelectedCells.Item(5).Value
                frmFacturaCompra.txtFecha.SelectionLength = Len(frmFacturaCompra.txtFecha.Text)
                frmFacturaCompra.txtFecha.Select()
                Me.Hide()
            ElseIf lblOrigen.Text = "Servicio Tecnico" Then
                frmServTecnico.txtIdProv.Text = dgvProveedores.SelectedCells.Item(1).Value
                frmServTecnico.txtProveedor.Text = dgvProveedores.SelectedCells.Item(5).Value
                frmServTecnico.btnGuardar.Select()
                Me.Hide()
            ElseIf lblOrigen.Text = "Caja" Then
                frmCaja.txtIdProv.Text = dgvProveedores.SelectedCells.Item(1).Value
                frmCaja.txtProveedor.Text = dgvProveedores.SelectedCells.Item(5).Value
                frmCaja.txtDetalle.Select()
                Me.Hide()
            ElseIf lblOrigen.Text = "Recibo Proveedor" Then
                frmReciboCompra.txtIdProv.Text = dgvProveedores.SelectedCells.Item(1).Value
                frmReciboCompra.txtProveedor.Text = dgvProveedores.SelectedCells.Item(5).Value
                frmReciboCompra.txtDetalle.Select()
                Me.Hide()
            ElseIf lblOrigen.Text = "Cta Cte Compra" Then
                frmCtaCteCompra.txtCtaProv.Text = dgvProveedores.SelectedCells.Item(1).Value
                frmCtaCteCompra.lblRazonSocial.Text = dgvProveedores.SelectedCells.Item(5).Value
                frmCtaCteCompra.txtCtaProv.Select()
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox("Error: Proveedor No fue transferido !", vbInformation)
        End Try
    End Sub

    Private Sub dgvProveedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProveedores.CellContentClick
        If e.ColumnIndex = Me.dgvProveedores.Columns.Item("Eliminar").Index Then
            Dim celSel As DataGridViewCheckBoxCell = Me.dgvProveedores.Rows(e.RowIndex).Cells("Eliminar")
            celSel.Value = Not celSel.Value
        End If
    End Sub

    Private Sub cbxCatIva_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCatIva.SelectedIndexChanged
        If cbxCatIva.Text = "IVA Responsable Inscripto" Then
            txtCodCat.Text = "CI-01"
        ElseIf cbxCatIva.Text = "IVA Responsable No Inscripto" Then
            txtCodCat.Text = "CI-02"
        ElseIf cbxCatIva.Text = "IVA No Responsable" Then
            txtCodCat.Text = "CI-03"
        ElseIf cbxCatIva.Text = "IVA Sujeto Exento" Then
            txtCodCat.Text = "CI-04"
        ElseIf cbxCatIva.Text = "Consumidor Final" Then
            txtCodCat.Text = "CI-05"
        ElseIf cbxCatIva.Text = "Responsable Monotributo" Then
            txtCodCat.Text = "CI-06"
        ElseIf cbxCatIva.Text = "Sujeto No Categorizado" Then
            txtCodCat.Text = "CI-07"
        ElseIf cbxCatIva.Text = "Proveedor del Exterior" Then
            txtCodCat.Text = "CI-08"
        ElseIf cbxCatIva.Text = "Cliente del Exterior" Then
            txtCodCat.Text = "CI-09"
        ElseIf cbxCatIva.Text = "IVA Liberado – Ley Nº 19.640" Then
            txtCodCat.Text = "CI-10"
        ElseIf cbxCatIva.Text = "IVA Responsable Inscripto – Agente de Percepción" Then
            txtCodCat.Text = "CI-11"
        ElseIf cbxCatIva.Text = "Pequeño Contribuyente Eventual" Then
            txtCodCat.Text = "CI-12"
        ElseIf cbxCatIva.Text = "Monotributista Social" Then
            txtCodCat.Text = "CI-13"
        ElseIf cbxCatIva.Text = "Pequeño Contribuyente Eventual Social" Then
            txtCodCat.Text = "CI-14"
        Else
            MsgBox("Error categoría de IVA no existe!", vbExclamation, "Servicio de Alertas")
        End If
    End Sub
End Class