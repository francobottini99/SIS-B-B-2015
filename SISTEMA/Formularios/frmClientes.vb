Imports MySql.Data.MySqlClient

Public Class frmClientes

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim _Guardar As New GrabaDatos
        Dim resP As DialogResult

        Try
            If txtNombre.Text = "" Then
                MsgBox("Error: Razón Social es un campo obligatorio.", vbInformation, "Servico de Alertas")
                txtNombre.Select()
            Else
                resP = MessageBox.Show("Grabar Alta del Cliente ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If resP = Windows.Forms.DialogResult.OK Then
                    Dim _haB As Integer
                    If rdbHab.Checked = True Then
                        _haB = 1
                    Else
                        _haB = 0
                    End If
                    Dim cdBar As String
                    cdBar = "*" & txtIdCli.Text & Mid(txtCuit.Text, 1, 2) & Mid(txtCuit.Text, 4, 8) & Mid(txtCuit.Text, 13, 1) & "*"

                    If lblFuncion.Text = "Nuevo" Then
                        _Guardar.Grabar("Clientes", "NoImagen", "insCliente", txtCdEmp.Text, cdBar, Format(CDate(txtFecAlta.Text), "yyyy/MM/dd"), txtNombre.Text, txtDireccion.Text, _
                                        txtLocalidad.Text, txtCP.Text, txtProvincia.Text, txtPais.Text, txtTE.Text, txtCuit.Text, txtIB.Text, cbxCatIva.Text, _
                                        txtCodCat.Text, CDbl(txtCredito.Text), _haB, txtObserv.Text, mdifrmppal.usSis)
                        lblMsg.ForeColor = Color.LawnGreen
                        lblMsg.Text = "Cliente Ingresado Exitosamente"
                        lblMsg.Visible = True
                        tmrMensaje.Enabled = True
                    Else
                        _Guardar.Grabar("Clientes", "NoImagen", "modCliente", CInt(lblIdUs.Text), txtCdEmp.Text, cdBar, Format(CDate(txtFecAlta.Text), "yyyy/MM/dd"), txtNombre.Text, txtDireccion.Text, _
                                        txtLocalidad.Text, txtCP.Text, txtProvincia.Text, txtPais.Text, txtTE.Text, txtCuit.Text, txtIB.Text, cbxCatIva.Text, _
                                        txtCodCat.Text, CDbl(txtCredito.Text), _haB, txtObserv.Text, mdifrmppal.usSis)
                        lblMsg.ForeColor = Color.LawnGreen
                        lblMsg.Text = "Cliente Modificado Exitosamente"
                        lblMsg.Visible = True
                        tmrMensaje.Enabled = True
                    End If

                    'Actualizo el DataGridView
                    Dim _Ver As New Mostrar
                    Dim _Dt As New DataTable
                    _Dt = _Ver.verClientes(mdifrmppal.cdEmp)
                    dgvClientes.DataSource = _Dt

                    'Obtener ultimo ID de cliente
                    Dim ulTid As Integer
                    If _Dt.Rows.Count <> 0 Then
                        btnEliminar.Enabled = True
                        Dim _VerMax As New Mostrar
                        Dim _DtMax As New DataTable
                        _DtMax = _VerMax.verMaxIdCliente()
                        Dim _Row As DataRow = _DtMax.Rows(_DtMax.Rows.Count - 1)
                        ulTid = _Row("UltimoId")
                    Else
                        btnEliminar.Enabled = False
                        ulTid = 0
                    End If

                    txtIdCli.Text = ulTid + 1

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
            lblMsg.Text = "Error: Cliente no ingresado y/o modificado."
            lblMsg.Visible = True
            tmrMensaje.Enabled = True
            MsgBox("Error: Base de datos no fue modificada !" & vbCrLf & vbCrLf & ex.ToString, vbCritical, "Servicio de Alertas")
            BDxxx()
        Finally
            BDxxx()
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            lblFuncion.Text = "Modificar"
            gbxClientes.Enabled = True
            lblIdUs.Text = dgvClientes.SelectedCells.Item(1).Value
            txtCdEmp.Text = dgvClientes.SelectedCells.Item(2).Value
            txtFecAlta.Text = dgvClientes.SelectedCells.Item(4).Value
            txtNombre.Text = dgvClientes.SelectedCells.Item(5).Value
            txtDireccion.Text = dgvClientes.SelectedCells.Item(6).Value
            txtLocalidad.Text = dgvClientes.SelectedCells.Item(7).Value
            txtCP.Text = dgvClientes.SelectedCells.Item(8).Value
            txtProvincia.Text = dgvClientes.SelectedCells.Item(9).Value
            txtPais.Text = dgvClientes.SelectedCells.Item(10).Value
            txtTE.Text = dgvClientes.SelectedCells.Item(11).Value
            txtCuit.Text = dgvClientes.SelectedCells.Item(12).Value
            txtIB.Text = dgvClientes.SelectedCells.Item(13).Value
            cbxCatIva.Text = dgvClientes.SelectedCells.Item(14).Value
            txtCodCat.Text = dgvClientes.SelectedCells.Item(15).Value
            txtCredito.Text = Format(dgvClientes.SelectedCells.Item(16).Value, "#,##0.00")
            If dgvClientes.SelectedCells.Item(17).Value <> 0 Then
                rdbHab.Checked = True
                rdbInhab.Checked = False
            Else
                rdbHab.Checked = False
                rdbInhab.Checked = True
            End If
            txtObserv.Text = dgvClientes.SelectedCells.Item(18).Value

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
            MsgBox("Error al modificar Cliente !" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
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
        txtCredito.Text = Format(0, "#,##0.00")
        rdbHab.Checked = False
        rdbInhab.Checked = False
        txtObserv.Text = ""
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
        txtLocalidad.Text = "Berrotarán"
        txtCP.Text = "5817"
        txtProvincia.Text = "Córdoba"
        txtPais.Text = "Argentina"
        txtCredito.Text = Format(10000, "#,##0.00")
        rdbHab.Checked = True
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

        resP = MessageBox.Show("Elimar Clientes Seleccionados!?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If resP = Windows.Forms.DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dgvClientes.Rows
                    Dim seL As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If seL = True Then
                        Dim clElim As Integer = Convert.ToInt32(row.Cells("IdClientes").Value)
                        _Elim.Grabar("Clientes", "NoImagen", "eliCliente", clElim)
                    End If
                Next

                'Actualizo el datagridview
                Dim _mAut As New Mostrar
                Dim _dT As New DataTable

                _dT = _mAut.verClientes(mdifrmppal.cdEmp)

                If _dT.Rows.Count <> 0 Then
                    dgvClientes.DataSource = _dT
                    dgvClientes.ColumnHeadersVisible = True
                    btnEliminar.Enabled = True
                Else
                    dgvClientes.DataSource = Nothing
                    btnEliminar.Enabled = False
                End If
            Catch ex As MySqlException
                MsgBox("Error al Eliminar Clientes !" & vbCrLf & vbCrLf & ex.ToString, vbCritical, "Servicio de Alertas")
            End Try
        End If
    End Sub

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim _Ver As New Mostrar
            Dim _Dt As New DataTable

            _Dt = _Ver.verClientes(mdifrmppal.cdEmp)
            dgvClientes.DataSource = _Dt
            dgvClientes.Columns.Item("CodBarra").Visible = False

            Dim estiloEnc As New DataGridViewCellStyle()
            Dim textEnc As String = ""
            Dim X As Integer

            estiloEnc.Font = New Font(dgvClientes.Font, FontStyle.Bold)
            dgvClientes.ColumnHeadersDefaultCellStyle = estiloEnc
            dgvClientes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            For X = 1 To 18
                If X = 1 Or X = 2 Or X = 3 Or X = 12 Or X = 13 Or X = 15 Or X = 17 Then
                    dgvClientes.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                ElseIf X = 4 Then
                    dgvClientes.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                ElseIf X = 5 Or X = 6 Or X = 7 Or X = 8 Or X = 9 Or X = 10 Or X = 11 Or X = 14 Or X = 18 Then
                    dgvClientes.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Else
                    dgvClientes.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvClientes.Columns(X).DefaultCellStyle.Format = "$ #,##0.00"
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
                        textEnc = "CREDITO"
                    Case 17
                        textEnc = "EST. 1=HAB 0= INHAB"
                    Case 18
                        textEnc = "OBSERVACIONES"
                End Select
                dgvClientes.Columns(X).HeaderText = textEnc
            Next

            'Obtener ultimo ID de cliente
            Dim ulTid As Integer
            If _Dt.Rows.Count <> 0 Then
                btnEliminar.Enabled = True
                Dim _VerMax As New Mostrar
                Dim _DtMax As New DataTable
                _DtMax = _VerMax.verMaxIdCliente()
                Dim _Row As DataRow = _DtMax.Rows(_DtMax.Rows.Count - 1)
                ulTid = _Row("UltimoId")
            Else
                btnEliminar.Enabled = False
                ulTid = 0
            End If

            txtIdCli.Text = ulTid + 1

            Me.Text = "CLIENTES - " & mdifrmppal.encForm
        Catch ex As Exception
            MsgBox("No se puede mostrar Clientes !", vbInformation)
        End Try
    End Sub

    Private Sub txtCredito_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCredito.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtObserv.SelectionLength = Len(txtObserv.Text)
            txtObserv.Select()
        End If
    End Sub

    Private Sub txtCredito_Validated(sender As Object, e As EventArgs) Handles txtCredito.Validated
        If Not IsNumeric(txtCredito.Text) Then
            MsgBox("Solo valores numéricos!", vbExclamation)
            txtCredito.Text = ""
            txtCredito.Select()
        End If
    End Sub

    Private Sub txtCuit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuit.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtIB.SelectionLength = Len(txtIB.Text)
            txtIB.Select()
        End If
    End Sub

    Private Sub txtCuit_Validated(sender As Object, e As EventArgs) Handles txtCuit.Validated
        Dim X As Integer
        Dim cuitSinGuion As String = ""
        Dim caracTer As String = ""
        Dim valCuit As New ValidaCUIT

        For X = 1 To Len(txtCuit.Text)
            caracTer = Mid(txtCuit.Text, X, 1)
            If IsNumeric(caracTer) Then
                cuitSinGuion = cuitSinGuion & caracTer
            End If
        Next X

        If Len(cuitSinGuion) <> 11 Then
            MsgBox("Error: Cuit Inválido!", vbExclamation)
            txtCuit.Text = ""
            txtCuit.Select()
        Else
            If valCuit.CUIT(cuitSinGuion) Then
                Dim Ct1, Ct2, Ct3 As String
                Ct1 = Mid(cuitSinGuion, 1, 2)
                Ct2 = Mid(cuitSinGuion, 3, 8)
                Ct3 = Mid(cuitSinGuion, 11, 1)
                txtCuit.Text = Ct1 & "-" & Ct2 & "-" & Ct3
            Else
                MsgBox("Error: Cuit Inválido!", vbExclamation)
                txtCuit.Text = ""
                txtCuit.Select()
            End If
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
            txtCredito.SelectionLength = Len(txtCredito.Text)
            txtCredito.Select()
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
                    txtCuit.Text = "99-99999999-9"
                    txtIB.SelectionLength = Len(txtIB.Text)
                    txtIB.Select()
                Else
                    txtCuit.SelectionLength = Len(txtCuit.Text)
                    txtCuit.Select()
                End If
            End If
        End If
    End Sub

    Private Sub txtObserv_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnGuardar.Select()
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

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            Dim _mAut As New Mostrar
            Dim _Ds As New DataSet
            _Ds.Tables.Add(_mAut.verClientes(mdifrmppal.cdEmp).Copy)
            Dim _Dv As New DataView(_Ds.Tables(0))

            _Dv.RowFilter = "RazonSocial Like '%" & txtBuscar.Text & "%'"

            If _Dv.Count <> 0 Then
                dgvClientes.DataSource = _Dv
            Else
                dgvClientes.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox("Error de consulta de clientes" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
        End Try
    End Sub

    Private Sub dgvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellContentClick
        If e.ColumnIndex = Me.dgvClientes.Columns.Item("Eliminar").Index Then
            Dim celSel As DataGridViewCheckBoxCell = Me.dgvClientes.Rows(e.RowIndex).Cells("Eliminar")
            celSel.Value = Not celSel.Value
        End If
    End Sub

    Private Sub dgvClientes_DoubleClick(sender As Object, e As EventArgs) Handles dgvClientes.DoubleClick
        Try
            If lblOrigen.Text = "Factura Venta" Then
                frmFacturaVentas.txtIdCliente.Text = dgvClientes.SelectedCells.Item(1).Value
                frmFacturaVentas.txtCliente.Text = dgvClientes.SelectedCells.Item(5).Value
                frmFacturaVentas.txtFecha.SelectionLength = Len(frmFacturaVentas.txtFecha.Text)
                frmFacturaVentas.txtFecha.Select()
                Me.Hide()
            ElseIf lblOrigen.Text = "Servicio Tecnico" Then
                frmServTecnico.txtIdCliente.Text = dgvClientes.SelectedCells.Item(1).Value
                frmServTecnico.txtCliente.Text = dgvClientes.SelectedCells.Item(5).Value
                frmServTecnico.txtTE.Text = dgvClientes.SelectedCells.Item(11).Value
                frmServTecnico.txtCdBarrEq.Select()
                Me.Hide()
            ElseIf lblOrigen.Text = "Servicio Tecnico Buscar" Then
                frmServTecnico.txtBuscCliente.Text = dgvClientes.SelectedCells.Item(1).Value
                frmServTecnico.txtBuscCliente.Select()
                Me.Hide()
            ElseIf lblOrigen.Text = "Servicio Tecnico Buscar Terceros" Then
                frmSTPresupuestoTerceros.txtBuscCliente.Text = dgvClientes.SelectedCells.Item(1).Value
                frmSTPresupuestoTerceros.txtBuscCliente.Select()
                Me.Hide()
            ElseIf lblOrigen.Text = "Servicio Tecnico Buscar Diagnostico" Then
                frmSTDiagPresupuesto.txtBuscCliente.Text = dgvClientes.SelectedCells.Item(1).Value
                frmSTDiagPresupuesto.txtBuscCliente.Select()
                Me.Hide()
            ElseIf lblOrigen.Text = "Servicio Tecnico Buscar Garantia" Then
                frmSTGarantiayOtros.txtBuscCliente.Text = dgvClientes.SelectedCells.Item(1).Value
                frmSTGarantiayOtros.txtBuscCliente.Select()
                Me.Hide()
            ElseIf lblOrigen.Text = "Servicio Tecnico Entrega Prov" Then
                frmSTEntregaRecep.txtBuscCliente.Text = dgvClientes.SelectedCells.Item(1).Value
                frmSTEntregaRecep.txtCliente.Text = dgvClientes.SelectedCells.Item(5).Value
                frmSTEntregaRecep.btnBuscar.Select()
                Me.Hide()
            ElseIf lblOrigen.Text = "Servicio Tecnico Consultas" Then
                frmConsServicioTecnico.txtBuscCliente.Text = dgvClientes.SelectedCells.Item(1).Value
                frmConsServicioTecnico.txtCliente.Text = dgvClientes.SelectedCells.Item(5).Value
                frmConsServicioTecnico.btnBuscar.Select()
                Me.Hide()
            ElseIf lblOrigen.Text = "Caja" Then
                frmCaja.txtIdCli.Text = dgvClientes.SelectedCells.Item(1).Value
                frmCaja.txtCliente.Text = dgvClientes.SelectedCells.Item(5).Value
                frmCaja.txtIdProv.Select()
                Me.Hide()
            ElseIf lblOrigen.Text = "Recibo Venta" Then
                frmRecibosVenta.txtIdCli.Text = dgvClientes.SelectedCells.Item(1).Value
                frmRecibosVenta.txtCliente.Text = dgvClientes.SelectedCells.Item(5).Value
                frmRecibosVenta.txtIdCli.Select()
                Me.Hide()
            ElseIf lblOrigen.Text = "Cta Cte Venta" Then
                frmCtaCteVenta.txtCtaCliente.Text = dgvClientes.SelectedCells.Item(1).Value
                frmCtaCteVenta.lblRazonSocial.Text = dgvClientes.SelectedCells.Item(5).Value
                frmCtaCteVenta.txtCtaCliente.Select()
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox("Error: Proveedor No fue transferido !", vbInformation)
        End Try
    End Sub
 
    Private Sub cbxCatIva_Validated(sender As Object, e As EventArgs) Handles cbxCatIva.Validated
        If cbxCatIva.Text = "" Then
            MsgBox("Error: Categoría IVA no puede quedar vacío!", vbExclamation)
            cbxCatIva.Select()
        Else
            If txtCodCat.Text = "CI-05" Or txtCodCat.Text = "CI-07" Then 'Consumidor Final o Sujeto No Categorizado
                txtCuit.Text = "99-99999999-9"
                txtIB.SelectionLength = Len(txtIB.Text)
                txtIB.Select()
            Else
                txtCuit.SelectionLength = Len(txtCuit.Text)
                txtCuit.Select()
            End If
        End If
    End Sub
End Class