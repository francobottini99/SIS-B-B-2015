Public Class frmTipoCambio

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

    Private Sub frmTipoCambio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim _Ver As New Mostrar
            Dim _Dt As New DataTable

            _Dt = _Ver.verTipoCambio()
            dgvTC.DataSource = _Dt

            dgvTC.CurrentCell = dgvTC.Rows(_Dt.Rows.Count - 1).Cells(0)

            dgvTC.Columns.Item("IdTipoCambio").Visible = False

            Dim estiloEnc As New DataGridViewCellStyle()
            Dim textEnc As String = ""

            dgvTC.Columns("Fecha").HeaderText = "FECHA"
            dgvTC.Columns("Fecha").Width = 120
            dgvTC.Columns("Fecha").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvTC.Columns("Fecha").DefaultCellStyle.Format = "dd/MM/yyyy"

            dgvTC.Columns("TC").HeaderText = "TIPO CAMBIO"
            dgvTC.Columns("TC").Width = 120
            dgvTC.Columns("TC").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvTC.Columns("TC").DefaultCellStyle.Format = "$ #,##0.00"

            dgvTC.Columns("Usuario").HeaderText = "USUARIO"
            dgvTC.Columns("Usuario").Width = 200
            dgvTC.Columns("Usuario").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            estiloEnc.Font = New Font(dgvTC.Font, FontStyle.Bold)
            dgvTC.ColumnHeadersDefaultCellStyle = estiloEnc
            dgvTC.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


            Me.Text = "ALTAS Y MODIFICACIONES DE TIPO DE CAMBIO - " & mdifrmppal.encForm
        Catch ex As Exception
            MsgBox("Error: Tipo Cambio no puede cargarse !", vbInformation, "Servicio de Alertas")
        End Try

    End Sub

    Private Sub Limpiar()
        txtFecha.Text = ""
        txtTC.Text = Format(1, "$ #,##0.00")
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        gbxTC.Enabled = True
        Limpiar()
        txtFecha.Text = Date.Now.Date
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnCancelar.Enabled = True
        btnGuardar.Enabled = True
        txtFecha.Select()
        lblFuncion.Text = "Nuevo"
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        gbxTC.Enabled = False
        Limpiar()
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnCancelar.Enabled = False
        btnGuardar.Enabled = False
        btnNuevo.Select()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        gbxTC.Enabled = False
        Limpiar()
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnCancelar.Enabled = False
        btnGuardar.Enabled = False

        Me.Hide()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            lblFuncion.Text = "Modificar"
            gbxTC.Enabled = True
            lblidTC.Text = dgvTC.SelectedCells.Item(1).Value
            txtFecha.Text = dgvTC.SelectedCells.Item(2).Value
            txtTC.Text = Format(dgvTC.SelectedCells.Item(3).Value, "$ #,##0.00")

            btnNuevo.Enabled = False
            btnModificar.Enabled = False
            btnCancelar.Enabled = True
            btnGuardar.Enabled = True
            txtFecha.Select()
        Catch ex As Exception
            lblFuncion.Text = "Modificar"
            btnNuevo.Enabled = False
            btnModificar.Enabled = False
            btnCancelar.Enabled = True
            btnGuardar.Enabled = True
            MsgBox("Error al modificar Cliente !" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim _Guardar As New GrabaDatos
        Dim resP As DialogResult

        Try
            If txtTC.Text = "" Then
                MsgBox("Error: Tipo de Cambio es un campo obligatorio.", vbInformation, "Servico de Alertas")
                txtTC.Select()
            Else
                resP = MessageBox.Show("Grabar Alta de Tipo de Cambio ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If resP = Windows.Forms.DialogResult.OK Then

                    If lblFuncion.Text = "Nuevo" Then
                        _Guardar.Grabar("TipoCambio", "NoImagen", "insTipoCambio", Format(CDate(txtFecha.Text), "yyyy/MM/dd"), _
                                        CDbl(txtTC.Text), mdifrmppal.usSis)
                        lblMsg.ForeColor = Color.LawnGreen
                        lblMsg.Text = "Tipo de Cambio Ingresado Exitosamente"
                        lblMsg.Visible = True
                        tmrMensaje.Enabled = True
                    Else
                        _Guardar.Grabar("TipoCambio", "NoImagen", "modTipoCambio", CInt(lblidTC.Text), _
                                        Format(CDate(txtFecha.Text), "yyyy/MM/dd"), CDbl(txtTC.Text), mdifrmppal.usSis)
                        lblMsg.ForeColor = Color.LawnGreen
                        lblMsg.Text = "Tipo de Cambio Modificado Exitosamente"
                        lblMsg.Visible = True
                        tmrMensaje.Enabled = True
                    End If

                    'Obtener Ultimo TC Cargado
                    Dim _DtMax, _Dt2 As New DataTable
                    Dim _VerMax As New Mostrar
                    Dim idCj As Integer
                    Dim fecH As Date

                    fecH = Date.Now.Date
                    _DtMax = _VerMax.verMaxIdTC()
                    Dim _Row1 As DataRow = _DtMax.Rows(_DtMax.Rows.Count - 1)
                    If IsDBNull(_Row1("UltimoId")) Then
                        idCj = 0
                        mdifrmppal.tpCb = 1
                        mdifrmppal.ssEstado.Items(3).ForeColor = Color.Red
                        mdifrmppal.ssEstado.Items(3).Text = " Tipo Cambio: =  [ " & Format(mdifrmppal.tpCb, "$ #,##0.00") & " ] -> [ " & mdifrmppal.ulTfecTc & " ] -> ¡NO ACTUALIZADO!  |"
                    Else
                        idCj = _Row1("UltimoId")
                        _Dt2 = _VerMax.verTipoCambioUltimoId(idCj)
                        dgvTC.DataSource = _Dt2
                        mdifrmppal.ulTfecTc = CType(dgvTC.SelectedCells.Item(2).Value, Date)

                        If mdifrmppal.ulTfecTc >= fecH Then
                            mdifrmppal.tpCb = dgvTC.SelectedCells.Item(3).Value
                            mdifrmppal.ssEstado.Items(3).ForeColor = Color.GreenYellow
                            mdifrmppal.ssEstado.Items(3).Text = " Tipo Cambio: =  [ " & Format(mdifrmppal.tpCb, "$ #,##0.00") & " ]  |"
                        Else
                            mdifrmppal.tpCb = dgvTC.SelectedCells.Item(3).Value
                            mdifrmppal.ssEstado.Items(3).ForeColor = Color.Red
                            mdifrmppal.ssEstado.Items(3).Text = " Tipo Cambio: =  [ " & Format(mdifrmppal.tpCb, "$ #,##0.00") & " ] -> [ " & mdifrmppal.ulTfecTc & " ] -> ¡NO ACTUALIZADO!  |"
                        End If
                    End If

                    'Actualizo el DataGridView
                    Dim _Ver As New Mostrar
                    Dim _Dt As New DataTable
                    _Dt = _Ver.verTipoCambio()
                    dgvTC.DataSource = _Dt

                    gbxTC.Enabled = False
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
            lblMsg.Text = "Error: Tipo de Cambio no ingresado y/o modificado."
            lblMsg.Visible = True
            tmrMensaje.Enabled = True
            MsgBox("Error: Base de datos no fue modificada !" & vbCrLf & vbCrLf & ex.ToString, vbCritical, "Servicio de Alertas")
            BDxxx()
        Finally
            BDxxx()
        End Try
    End Sub

    Private Sub tmrMensaje_Tick(sender As Object, e As EventArgs) Handles tmrMensaje.Tick
        lblMsg.Visible = False
        tmrMensaje.Enabled = False
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim resP As DialogResult
        Dim _Elim As New GrabaDatos

        resP = MessageBox.Show("Tipo de Cambio Seleccionados!?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If resP = Windows.Forms.DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dgvTC.Rows
                    Dim seL As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If seL = True Then
                        Dim tcElim As Integer = Convert.ToInt32(row.Cells("IdTipoCambio").Value)
                        _Elim.Grabar("Tipo Cambio", "NoImagen", "eliTipoCambio", tcElim)
                    End If
                Next

                'Actualizo el DataGridView
                Dim _Ver As New Mostrar
                Dim _Dt As New DataTable
                _Dt = _Ver.verTipoCambio()
                dgvTC.DataSource = _Dt

                If _dT.Rows.Count <> 0 Then
                    dgvTC.DataSource = _dT
                    dgvTC.ColumnHeadersVisible = True
                    btnEliminar.Enabled = True
                Else
                    dgvTC.DataSource = Nothing
                    btnEliminar.Enabled = False
                End If
            Catch ex As MySqlException
                MsgBox("Error al Eliminar Tipo de Cambio !" & vbCrLf & vbCrLf & ex.ToString, vbCritical, "Servicio de Alertas")
            End Try
        End If
    End Sub

    Private Sub txtFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFecha.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtTC.SelectionLength = Len(txtTC.Text)
            txtTC.Select()
        End If
    End Sub

    Private Sub txtFecha_Validated(sender As Object, e As EventArgs) Handles txtFecha.Validated
        If Not txtFecha.Text = "" Then
            If Not IsDate(txtFecha.Text) Then
                MsgBox("Error: Fecha incorrecta !", vbInformation, "Servicio de Alertas")
                txtFecha.Text = ""
                txtFecha.Select()
            Else
                txtFecha.Text = Format(CDate(txtFecha.Text), "dd/MM/yyyy")
            End If
        End If
    End Sub

    Private Sub txtTC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTC.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnGuardar.Select()
        End If
    End Sub

    Private Sub txtTC_Validated(sender As Object, e As EventArgs) Handles txtTC.Validated
        If Not IsNumeric(txtTC.Text) Then
            MsgBox("Solo valores numéricos!", vbExclamation)
            txtTC.Text = ""
            txtTC.Select()
        Else
            txtTC.Text = Format(CDbl(txtTC.Text), "$ #,##0.00")
        End If
    End Sub

    Private Sub dgvTC_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTC.CellContentClick
        If e.ColumnIndex = Me.dgvTC.Columns.Item("Eliminar").Index Then
            Dim celSel As DataGridViewCheckBoxCell = Me.dgvTC.Rows(e.RowIndex).Cells("Eliminar")
            celSel.Value = Not celSel.Value
        End If
    End Sub

    Private Sub txtFecDesde_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFecDesde.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtFecHasta.SelectionLength = Len(txtFecHasta.Text)
            txtFecHasta.Select()
        End If
    End Sub

    Private Sub txtFecDesde_Validated(sender As Object, e As EventArgs) Handles txtFecDesde.Validated
        If Not txtFecDesde.Text = "" Then
            If Not IsDate(txtFecDesde.Text) Then
                MsgBox("Error: Fecha incorrecta !", vbInformation, "Servicio de Alertas")
                txtFecDesde.Text = ""
                txtFecDesde.Select()
            Else
                txtFecDesde.Text = Format(CDate(txtFecDesde.Text), "dd/MM/yyyy")
            End If
        End If
    End Sub

    Private Sub txtFecHasta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFecHasta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnBuscar.Select()
        End If
    End Sub

    Private Sub txtFecHasta_Validated(sender As Object, e As EventArgs) Handles txtFecHasta.Validated
        If Not txtFecHasta.Text = "" Then
            If Not IsDate(txtFecHasta.Text) Then
                MsgBox("Error: Fecha incorrecta !", vbInformation, "Servicio de Alertas")
                txtFecHasta.Text = ""
                txtFecHasta.Select()
            Else
                txtFecHasta.Text = Format(CDate(txtFecHasta.Text), "dd/MM/yyyy")
            End If
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim _Ver As New Mostrar
            Dim _Ds As New DataSet
            _Ds.Tables.Add(_Ver.verTipoCambio().Copy)
            Dim _Dv As New DataView(_Ds.Tables(0))

            If txtFecDesde.Text = "" And txtFecHasta.Text = "" Then
                MsgBox("Debe ingresar al menos una fecha de búsqueda !", vbInformation)
            ElseIf txtFecDesde.Text <> "" And txtFecHasta.Text = "" Then
                If IsDate(txtFecDesde.Text) Then
                    _Dv.RowFilter = "Fecha >= #" & Format(CDate(txtFecDesde.Text), "yyyy/MM/dd") & "#"
                Else
                    MsgBox("Error: Solo se admiten fechas válidas !", vbInformation, "Servicio de Alertas")
                    txtFecDesde.Text = ""
                    txtFecDesde.Select()
                End If
            ElseIf txtFecDesde.Text = "" And txtFecHasta.Text <> "" Then
                If IsDate(txtFecHasta.Text) Then
                    _Dv.RowFilter = "Fecha <= #" & Format(CDate(txtFecHasta.Text), "yyyy/MM/dd") & "#"
                Else
                    MsgBox("Error: Solo se admiten fechas válidas !", vbInformation, "Servicio de Alertas")
                    txtFecHasta.Text = ""
                    txtFecHasta.Select()
                End If
            ElseIf txtFecDesde.Text <> "" And txtFecHasta.Text <> "" Then
                If IsDate(txtFecHasta.Text) Then
                    _Dv.RowFilter = "Fecha >= #" & Format(CDate(txtFecDesde.Text), "yyyy/MM/dd") & "# And Fecha <= #" & Format(CDate(txtFecHasta.Text), "yyyy/MM/dd") & "#"
                Else
                    MsgBox("Error: Solo se admiten fechas válidas !", vbInformation, "Servicio de Alertas")
                    txtFecHasta.Text = ""
                    txtFecHasta.Select()
                End If
            End If

            dgvTC.DataSource = _Dv

        Catch ex As Exception
            MsgBox("Error: Problemas con la consulta de Servicio Técnico !", vbInformation)
        End Try

    End Sub

    Private Sub btnTodo_Click(sender As Object, e As EventArgs) Handles btnTodo.Click
        Try
            Dim _Ver As New Mostrar
            Dim _Dt As New DataTable

            _Dt = _Ver.verTipoCambio()
            dgvTC.DataSource = _Dt

        Catch ex As Exception
            MsgBox("Error: Tipo Cambio no puede cargarse !", vbInformation, "Servicio de Alertas")
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Try
            Dim _Ver As New Mostrar
            Dim _Dt As New DataTable

            _Dt = _Ver.verTipoCambio()
            dgvTC.DataSource = _Dt

            txtFecDesde.Text = ""
            txtFecHasta.Text = ""

        Catch ex As Exception
            MsgBox("Error: Tipo Cambio no puede cargarse !", vbInformation, "Servicio de Alertas")
        End Try
    End Sub
End Class