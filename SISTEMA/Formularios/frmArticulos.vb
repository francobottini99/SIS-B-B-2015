Imports MySql.Data.MySqlClient

Public Class frmArticulos

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim _Guardar As New GrabaDatos
        Dim resP As DialogResult

        Try
            If txtCodCategoria.Text = "" Then
                MsgBox("Error: Código de Categoría es un campo obligatorio.", vbInformation, "Servico de Alertas")
                txtCodCategoria.Select()
            Else
                If txtDescripcion.Text = "" Then
                    MsgBox("Error: Descripción es un campo obligatorio.", vbInformation, "Servico de Alertas")
                    txtDescripcion.Select()
                Else
                    If txtUnidad.Text = "" Then
                        MsgBox("Error: Unidad es un campo obligatorio.", vbInformation, "Servico de Alertas")
                        txtUnidad.Select()
                    Else
                        If txtPrecio.Text = "" Then
                            MsgBox("Error: Precio es un campo obligatorio.", vbInformation, "Servico de Alertas")
                            txtPrecio.Select()
                        Else
                            resP = MessageBox.Show("Grabar Alta/Modificación del Artículo ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                            If resP = Windows.Forms.DialogResult.OK Then
                                Dim _haB, atrB As Integer

                                If chbReqStk.Checked = True Then
                                    _haB = 1
                                Else
                                    _haB = 0
                                End If
                                If chkManual.Checked = True Then
                                    atrB = 1
                                Else
                                    atrB = 0
                                End If

                                If lblFuncion.Text = "Nuevo" Then
                                    _Guardar.Grabar("Artículos", "NoImagen", "insArticulo", txtCdEmp.Text, Format(CDate(txtFecAlta.Text), "yyyy/MM/dd"), _
                                                        txtCodCategoria.Text, txtDescripcion.Text, txtUnidad.Text, CDbl(txtPrecio.Text) * CDbl(txtTC.Text), _
                                                        (CDbl(txtAlicIva.Text) / 100), CDbl(txtPrecFinal.Text) * CDbl(txtTC.Text), _haB, mdiFrmPpal.usSis, _
                                                        CInt(txtIdCategoria.Text), CDbl(txtPrecio.Text), atrB)
                                    lblMsg.ForeColor = Color.LawnGreen
                                    lblMsg.Text = "Atículo Ingresado Exitosamente"
                                    lblMsg.Visible = True
                                    tmrMensaje.Enabled = True
                                Else
                                    _Guardar.Grabar("Artículos", "NoImagen", "modArticulo", CInt(lblIdUs.Text), txtCdEmp.Text, Format(CDate(txtFecAlta.Text), "yyyy/MM/dd"), _
                                                    txtCodCategoria.Text, txtDescripcion.Text, txtUnidad.Text, CDbl(txtPrecio.Text) * CDbl(txtTC.Text), _
                                                    (CDbl(txtAlicIva.Text) / 100), CDbl(txtPrecFinal.Text) * CDbl(txtTC.Text), _haB, mdiFrmPpal.usSis, _
                                                    CInt(txtIdCategoria.Text), CDbl(txtPrecio.Text), atrB)
                                    lblMsg.ForeColor = Color.LawnGreen
                                    lblMsg.Text = "Artículo Modificado Exitosamente"
                                    lblMsg.Visible = True
                                    tmrMensaje.Enabled = True
                                End If

                                'Actualizo el DataGridView
                                Dim _Ver As New Mostrar
                                Dim _Dt As New DataTable
                                _Dt = _Ver.verArticulos(mdifrmppal.cdEmp)
                                dgvArticulos.DataSource = _Dt

                                dgvArticulos.ClearSelection()
                                dgvArticulos.CurrentCell = dgvArticulos.Rows(CInt(lblNroFila.Text)).Cells("idArticulos")
                                Me.dgvArticulos.Refresh()

                                gbxClientes.Enabled = False
                                Limpiar()
                                btnNuevo.Enabled = True
                                btnModificar.Enabled = True
                                btnCancelar.Enabled = False
                                btnGuardar.Enabled = False
                                btnNuevo.Select()
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As MySqlException
            lblMsg.ForeColor = Color.Red
            lblMsg.Text = "Error: Artículo no ingresado y/o modificado."
            lblMsg.Visible = True
            tmrMensaje.Enabled = True
            MsgBox(ex.ToString)
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
            chbReqStk.CheckState = CheckState.Unchecked
            lblNroFila.Text = dgvArticulos.CurrentRow.Index
            lblIdUs.Text = dgvArticulos.SelectedCells.Item(1).Value
            txtCdEmp.Text = dgvArticulos.SelectedCells.Item(2).Value
            txtFecAlta.Text = dgvArticulos.SelectedCells.Item(3).Value
            txtCodCategoria.Text = dgvArticulos.SelectedCells.Item(4).Value
            txtDescripcion.Text = dgvArticulos.SelectedCells.Item(5).Value
            txtUnidad.Text = dgvArticulos.SelectedCells.Item(6).Value
            txtPrecio.Text = Format(dgvArticulos.SelectedCells.Item(13).Value, "0.00")
            txtAlicIva.Text = Format(CDbl(dgvArticulos.SelectedCells.Item(8).Value) * 100, "#,0.00")
            txtPrecFinal.Text = Format(dgvArticulos.SelectedCells.Item(9).Value / CDbl(txtTC.Text), "0.00")
            If dgvArticulos.SelectedCells.Item(10).Value <> 0 Then
                chbReqStk.CheckState = CheckState.Checked
            Else
                chbReqStk.CheckState = CheckState.Unchecked
            End If
            txtIdCategoria.Text = dgvArticulos.SelectedCells.Item(12).Value
            If dgvArticulos.SelectedCells.Item(14).Value <> 0 Then
                chkManual.CheckState = CheckState.Checked
            Else
                chkManual.CheckState = CheckState.Unchecked
            End If

            btnNuevo.Enabled = False
            btnModificar.Enabled = False
            btnCancelar.Enabled = True
            btnGuardar.Enabled = True
            txtDescripcion.Select()
        Catch ex As Exception
            lblFuncion.Text = "Modificar"
            btnNuevo.Enabled = False
            btnModificar.Enabled = False
            btnCancelar.Enabled = True
            btnGuardar.Enabled = True
            txtDescripcion.Select()
            MsgBox("Error al modificar Artículo !" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
        End Try
    End Sub

    Private Sub tmrMensaje_Tick(sender As Object, e As EventArgs) Handles tmrMensaje.Tick
        lblMsg.Visible = False
        tmrMensaje.Enabled = False
    End Sub

    Private Sub Limpiar()
        txtCdEmp.Text = ""
        txtFecAlta.Text = ""
        txtCodCategoria.Text = ""
        txtDescripcion.Text = ""
        txtUnidad.Text = ""
        txtPrecio.Text = Format(0, "#,##0.00")
        txtAlicIva.Text = Format(0, "#,##0.00")
        txtPrecio.Text = Format(0, "#,##0.00")
        txtPrecFinal.Text = Format(0, "#,##0.00")
        chbReqStk.CheckState = CheckState.Unchecked
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
        lblNroFila.Text = dgvArticulos.CurrentRow.Index
        chbReqStk.CheckState = CheckState.Unchecked
        Limpiar()
        txtCdEmp.Text = mdifrmppal.cdEmp
        txtFecAlta.Text = Date.Now.Date
        txtCodCategoria.Text = ""
        txtDescripcion.Text = ""
        txtUnidad.Text = ""
        txtPrecio.Text = Format(0, "$ 0.00")
        txtAlicIva.Text = Format(0, "#0.00")
        txtPrecFinal.Text = Format(0, "$ 0.00")
        chbReqStk.CheckState = CheckState.Checked

        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnCancelar.Enabled = True
        btnGuardar.Enabled = True
        txtCodCategoria.Select()
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

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim resP As DialogResult
        Dim _Elim As New GrabaDatos

        resP = MessageBox.Show("Elimar Artículos Seleccionados!?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If resP = Windows.Forms.DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dgvArticulos.Rows
                    Dim seL As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If seL = True Then
                        Dim clElim As Integer = Convert.ToInt32(row.Cells("IdArticulos").Value)
                        _Elim.Grabar("Clientes", "NoImagen", "eliArticulo", clElim)
                    End If
                Next

                'Actualizo el datagridview
                Dim _mAut As New Mostrar
                Dim _dT As New DataTable

                _dT = _mAut.verClientes(mdifrmppal.cdEmp)

                If _dT.Rows.Count <> 0 Then
                    dgvArticulos.DataSource = _dT
                    dgvArticulos.ColumnHeadersVisible = True
                    btnEliminar.Enabled = True
                Else
                    dgvArticulos.DataSource = Nothing
                    btnEliminar.Enabled = False
                End If
            Catch ex As MySqlException
                MsgBox("Error al Eliminar Artículos !" & vbCrLf & vbCrLf & ex.ToString, vbCritical, "Servicio de Alertas")
            End Try
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            Dim _mAut As New Mostrar
            Dim _Ds As New DataSet
            _Ds.Tables.Add(_mAut.verArticulos(mdifrmppal.cdEmp).Copy)
            Dim _Dv As New DataView(_Ds.Tables(0))

            _Dv.RowFilter = "Descripcion Like '%" & txtBuscar.Text & "%'"

            If _Dv.Count <> 0 Then
                dgvArticulos.DataSource = _Dv
            Else
                dgvArticulos.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox("Error de consulta de Artículos" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
        End Try
    End Sub

    Private Sub frmArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim _Ver As New Mostrar
            Dim _Dt As New DataTable

            _Dt = _Ver.verArticulos(mdifrmppal.cdEmp)
            dgvArticulos.DataSource = _Dt
            dgvArticulos.Columns.Item("Cat_idCategorias").Visible = False
            dgvArticulos.Columns.Item("RequiereStock").Visible = False
            dgvArticulos.Columns.Item("Usuario").Visible = False
            dgvArticulos.Columns.Item("Manual").Visible = False

            Dim estiloEnc As New DataGridViewCellStyle()
            Dim textEnc As String = ""
            Dim X As Integer

            estiloEnc.Font = New Font(dgvArticulos.Font, FontStyle.Bold)
            dgvArticulos.ColumnHeadersDefaultCellStyle = estiloEnc
            dgvArticulos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            For X = 1 To 13
                If X = 1 Or X = 2 Or X = 4 Or X = 6 Then
                    dgvArticulos.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                ElseIf X = 3 Then
                    dgvArticulos.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                ElseIf X = 5 Then
                    dgvArticulos.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                ElseIf X = 8 Then
                    dgvArticulos.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvArticulos.Columns(X).DefaultCellStyle.Format = "0.00 %"
                ElseIf X = 9 Then
                    dgvArticulos.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvArticulos.Columns(X).DefaultCellStyle.Format = "$ #,##0.00"
                ElseIf X = 13 Then
                    dgvArticulos.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvArticulos.Columns(X).DefaultCellStyle.Format = "U$S #,##0.00"
                Else
                    dgvArticulos.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvArticulos.Columns(X).DefaultCellStyle.Format = "$ #,##0.00"
                End If
                Select Case X
                    Case 1
                        textEnc = "ID"
                    Case 2
                        textEnc = "COD EMPRESA"
                    Case 3
                        textEnc = "ALTA"
                    Case 4
                        textEnc = "COD ARTICULO"
                    Case 5
                        textEnc = "DESCRIPCION"
                    Case 6
                        textEnc = "UNIDAD"
                    Case 7
                        textEnc = "PRECIO"
                    Case 8
                        textEnc = "% IVA"
                    Case 9
                        textEnc = "$ C/IVA"
                    Case 13
                        textEnc = "U$S + IVA"
                End Select
                dgvArticulos.Columns(X).HeaderText = textEnc
            Next

            If _Dt.Rows.Count <> 0 Then
                btnEliminar.Enabled = True
            Else
                btnEliminar.Enabled = False
            End If

            txtTC.Text = Format(mdifrmppal.tpCb, "$ #,##0.00")

            Me.Text = "ARTICULOS - " & mdifrmppal.encForm
        Catch ex As Exception
            Me.Text = "ARTICULOS - " & mdifrmppal.encForm
            MsgBox("No se puede mostrar Artículos !", vbInformation)
        End Try
    End Sub

    Private Sub txtCodCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodCategoria.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If txtCodCategoria.Text = "" Then
                e.Handled = True
                frmArtCategorias.lblOrigen.Text = "Articulos"
                frmArtCategorias.ShowDialog()
            Else
                e.Handled = True
                txtDescripcion.SelectionLength = Len(txtDescripcion.Text)
                txtDescripcion.Select()
            End If
        End If
    End Sub

    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtUnidad.SelectionLength = Len(txtUnidad.Text)
            txtUnidad.Select()
        End If
    End Sub

    Private Sub txtUnidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnidad.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtPrecio.SelectionLength = Len(txtPrecio.Text)
            txtPrecio.Select()
        End If
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtAlicIva.SelectionLength = Len(txtAlicIva.Text)
            txtAlicIva.Select()
        End If
    End Sub

    Private Sub txtPrecio_Validated(sender As Object, e As EventArgs) Handles txtPrecio.Validated
        If Not IsNumeric(txtPrecio.Text) Then
            MsgBox("Sólo datos numéricos !", vbInformation)
            txtPrecio.Text = Format(0, "0.00")
            txtPrecio.SelectionLength = Len(txtPrecio.Text)
            txtPrecio.Select()
        Else
            txtPrecio.Text = Format(CType(txtPrecio.Text, Double), "0.00")
            If txtAlicIva.Text <> "" Then
                txtPrecFinal.Text = Format(CDbl(txtPrecio.Text) + (CDbl(txtPrecio.Text) * CType(txtAlicIva.Text, Decimal) / 100), "0.00")
            Else
                txtPrecFinal.Text = Format(CDbl(txtPrecio.Text), "0.00")
            End If
        End If
    End Sub

    Private Sub txtAlicIva_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAlicIva.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnGuardar.Select()
        End If
    End Sub

    Private Sub txtAlicIva_Validated(sender As Object, e As EventArgs) Handles txtAlicIva.Validated
        If Not IsNumeric(txtAlicIva.Text) Then
            MsgBox("Sólo datos numéricos !", vbInformation)
            txtAlicIva.SelectionLength = Len(txtAlicIva.Text)
            txtAlicIva.Select()
        Else
            txtAlicIva.Text = Format(CDbl(txtAlicIva.Text), "#0.00")
            If txtPrecio.Text <> "" Then
                txtPrecFinal.Text = Format(CDbl(txtPrecio.Text) + (CDbl(txtPrecio.Text) * CDbl(txtAlicIva.Text) / 100), "0.00")
            Else
                txtPrecFinal.Text = Format(0, "0.00")
            End If
        End If
    End Sub

    Private Sub dgvArticulos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArticulos.CellContentClick
        If e.ColumnIndex = Me.dgvArticulos.Columns.Item("Eliminar").Index Then
            Dim celSel As DataGridViewCheckBoxCell = Me.dgvArticulos.Rows(e.RowIndex).Cells("Eliminar")
            celSel.Value = Not celSel.Value
        End If
    End Sub

    Private Sub dgvArticulos_DoubleClick(sender As Object, e As EventArgs) Handles dgvArticulos.DoubleClick
        Try
            If lblOrigen.Text = "Factura Compra" Then
                frmFacturaCompra.txtIdArt.Text = dgvArticulos.SelectedCells.Item(1).Value
                frmFacturaCompra.txtArticulo.Text = dgvArticulos.SelectedCells.Item(5).Value
                frmFacturaCompra.txtUnidad.Text = dgvArticulos.SelectedCells.Item(6).Value
                frmFacturaCompra.txtCdBarra.SelectionLength = Len(frmFacturaCompra.txtCdBarra.Text)
                frmFacturaCompra.txtCdBarra.Select()
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox("Error: Proveedor No fue transferido !", vbInformation)
        End Try
    End Sub

End Class