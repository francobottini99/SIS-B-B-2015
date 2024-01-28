Imports MySql.Data.MySqlClient

Public Class frmFacturaVentas
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

    Private Sub btnEmitirFactura_GotFocus(sender As Object, e As EventArgs) Handles btnEmitirFactura.GotFocus
        btnEmitirFactura.BackgroundImage = ByB_SI.My.Resources.Emitir1Ac
    End Sub

    Private Sub btnEmitirFactura_LostFocus(sender As Object, e As EventArgs) Handles btnEmitirFactura.LostFocus
        btnEmitirFactura.BackgroundImage = ByB_SI.My.Resources.Emitir1In
    End Sub

    Private Sub btnEmitirFactura_MouseEnter(sender As Object, e As EventArgs) Handles btnEmitirFactura.MouseEnter
        btnEmitirFactura.BackgroundImage = ByB_SI.My.Resources.Emitir1Ac
    End Sub

    Private Sub btnEmitirFactura_MouseLeave(sender As Object, e As EventArgs) Handles btnEmitirFactura.MouseLeave
        btnEmitirFactura.BackgroundImage = ByB_SI.My.Resources.Emitir1In
    End Sub

    Private Sub btnManual_GotFocus(sender As Object, e As EventArgs) Handles btnManual.GotFocus
        btnManual.BackgroundImage = ByB_SI.My.Resources.CargaManualAc
    End Sub

    Private Sub btnManual_LostFocus(sender As Object, e As EventArgs) Handles btnManual.LostFocus
        btnManual.BackgroundImage = ByB_SI.My.Resources.CargaManualIn
    End Sub

    Private Sub btnManual_MouseEnter(sender As Object, e As EventArgs) Handles btnManual.MouseEnter
        btnManual.BackgroundImage = ByB_SI.My.Resources.CargaManualAc
    End Sub

    Private Sub btnManual_MouseLeave(sender As Object, e As EventArgs) Handles btnManual.MouseLeave
        btnManual.BackgroundImage = ByB_SI.My.Resources.CargaManualIn
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

    Private Sub btnCargaCuota_GotFocus(sender As Object, e As EventArgs) Handles btnCargaCuota.GotFocus
        btnCargaCuota.BackgroundImage = ByB_SI.My.Resources.IngresoAc
    End Sub

    Private Sub btnCargaCuota_LostFocus(sender As Object, e As EventArgs) Handles btnCargaCuota.LostFocus
        btnCargaCuota.BackgroundImage = ByB_SI.My.Resources.IngresoIn
    End Sub

    Private Sub btnCargaCuota_MouseEnter(sender As Object, e As EventArgs) Handles btnCargaCuota.MouseEnter
        btnCargaCuota.BackgroundImage = ByB_SI.My.Resources.IngresoAc
    End Sub

    Private Sub btnCargaCuota_MouseLeave(sender As Object, e As EventArgs) Handles btnCargaCuota.MouseLeave
        btnCargaCuota.BackgroundImage = ByB_SI.My.Resources.IngresoIn
    End Sub

    Private Sub txtIdCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdCliente.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If txtIdCliente.Text = "" Then
                e.Handled = True
                frmClientes.lblOrigen.Text = "Factura Venta"
                frmClientes.txtBuscar.Text = ""
                frmClientes.txtBuscar.Select()
                frmClientes.ShowDialog()
            Else
                e.Handled = True
                If IsNumeric(txtIdCliente.Text) Then
                    Dim _Ver As New Mostrar
                    Dim _Ds As New DataSet
                    _Ds.Tables.Add(_Ver.verClientes(mdiFrmPpal.cdEmp).Copy)
                    Dim _Dv As New DataView(_Ds.Tables(0))
                    _Dv.RowFilter = "IdClientes = " & CInt(txtIdCliente.Text)
                    If _Dv.Count <> 0 Then
                        dgvCliente.DataSource = _Dv
                        dgvCliente.Select()
                        txtCliente.Text = dgvCliente.SelectedCells.Item(4).Value
                        txtCuit.Text = dgvCliente.SelectedCells.Item(11).Value
                        txtDir.Text = dgvCliente.SelectedCells.Item(5).Value
                        txtLoc.Text = dgvCliente.SelectedCells.Item(6).Value
                        txtProv.Text = dgvCliente.SelectedCells.Item(8).Value
                        txtIIBB.Text = dgvCliente.SelectedCells.Item(12).Value
                        txtCatIva.Text = dgvCliente.SelectedCells.Item(13).Value
                        If dgvCliente.SelectedCells.Item(16).Value = 1 Then
                            txtEst.Text = "Habilitado"
                        Else
                            txtEst.Text = "Inhabilitado"
                        End If
                        txtCred.Text = Format(dgvCliente.SelectedCells.Item(15).Value, "$ #,##0.00")
                    Else
                        MsgBox("Error: Nro de Cuenta no se corresponde con ningún cliente !", vbInformation, "Servicio de Alertas")
                        txtCliente.Text = ""
                        txtIdCliente.Text = ""
                        txtIdCliente.Select()
                    End If

                    If txtCliente.Text <> "" Then

                        If txtCliente.Text = "Consumidor Final" Then
                            Dim _Dt As New DataTable

                            _Dt = _Ver.verSistema(mdifrmppal.cdEmp)
                            Dim _Row As DataRow = _Dt.Rows(_Dt.Rows.Count - 1)

                            lblLetra.Text = "X"
                            lblCodComprobante.Text = "00"
                            lblComprobante.Text = CStr(_Row("NroFacturaNCND_X"))
                            txtImpFinal.Visible = True
                            dgvDetalle.Columns.Item("ImpFinal").Visible = True
                            dgvDetalle.Columns.Item("Importe").Visible = False
                            dgvDetalle.Columns.Item("Precio").Visible = False
                            dgvDetalle.Columns.Item("PrecioConIva").Visible = True
                            dgvDetalle.Columns(11).Width = 100
                            dgvDetalle.Columns(11).HeaderText = "IMP C/IVA"
                            dgvDetalle.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            dgvDetalle.Columns(11).DefaultCellStyle.Format = "$ #,##0.00"
                            dgvDetalle.Columns(12).Width = 70
                            dgvDetalle.Columns(12).HeaderText = "$ C/IVA"
                            dgvDetalle.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            dgvDetalle.Columns(12).DefaultCellStyle.Format = "$ #,##0.00"
                            ActualizaTotalesCX()

                            gbxFactura.Enabled = True
                            gbxLetra.Enabled = True
                            gbxTipoC.Enabled = True
                            gbxTipoVta.Enabled = True
                            gbxConceptos.Enabled = True
                            gbxCarga.Enabled = True
                            gbxControles.Enabled = True
                            gbxDetalle.Enabled = True
                            gbxObserv.Enabled = True
                            gbxResumen.Enabled = True
                            txtFecha.SelectionLength = Len(txtFecha.Text)
                            txtFecha.Select()
                        Else
                            gbxFactura.Enabled = True
                            gbxLetra.Enabled = True
                            gbxTipoC.Enabled = True
                            gbxTipoVta.Enabled = True
                            gbxConceptos.Enabled = True
                            gbxCarga.Enabled = True
                            gbxControles.Enabled = True
                            gbxDetalle.Enabled = True
                            gbxObserv.Enabled = True
                            gbxResumen.Enabled = True
                            txtFecha.SelectionLength = Len(txtFecha.Text)
                            txtFecha.Select()
                        End If
                    Else
                        gbxFactura.Enabled = False
                        gbxLetra.Enabled = False
                        gbxTipoC.Enabled = False
                        gbxTipoVta.Enabled = False
                        gbxConceptos.Enabled = False
                        gbxCarga.Enabled = False
                        gbxControles.Enabled = False
                        gbxDetalle.Enabled = False
                        gbxObserv.Enabled = False
                        gbxResumen.Enabled = False
                    End If

                Else
                    MsgBox("Error: Nro de Cuenta no se corresponde con ningún cliente !", vbInformation, "Servicio de Alertas")
                    txtCliente.Text = ""
                    txtIdCliente.Text = ""
                    txtIdCliente.Select()
                End If
            End If
        End If
    End Sub

    Private Sub txtFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFecha.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCdBarra.SelectionLength = Len(txtCdBarra.Text)
            txtCdBarra.Select()
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

    Private Sub txtComprobante_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCdBarra.SelectionLength = Len(txtCdBarra.Text)
            txtCdBarra.Select()
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtPrecio.SelectionLength = Len(txtPrecio.Text)
            txtPrecio.Select()
        End If
    End Sub

    Private Sub txtCantidad_Validated(sender As Object, e As EventArgs) Handles txtCantidad.Validated
        If IsNumeric(txtCantidad.Text) Then
            If lblLetra.Text = "A" Or lblLetra.Text = "B" Then
                txtPrecioFin.Text = CDbl(txtPrecio.Text) + (CDbl(txtPrecio.Text) * CDbl(txtAlIvaReal.Text))
                txtCantidad.Text = Format(CDbl(txtCantidad.Text), "#,##0.00")
                txtImporte.Text = Format(CDbl(txtCantidad.Text) * CDbl(txtPrecio.Text), "$ #,##0.00")
                txtImpFinal.Text = Format(CDbl(txtCantidad.Text) * CDbl(txtPrecioFin.Text), "$ #,##0.00")
            Else
                txtCantidad.Text = Format(CDbl(txtCantidad.Text), "#,##0.00")
                txtImporte.Text = Format(CDbl(txtCantidad.Text) * CDbl(txtPrecio.Text), "$ #,##0.00")
                txtImpFinal.Text = Format(CDbl(txtImporte.Text), "$ #,##0.00")
            End If
        Else
            MsgBox("Error: Sólo se permiten valores numéricos !", vbInformation, "Servicio de Alertas")
            txtCantidad.SelectionLength = Len(txtCantidad.Text)
            txtCantidad.Select()
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
        If IsNumeric(txtPrecio.Text) Then
            If lblManual.Text = "Stock" Then
                If lblLetra.Text = "A" Or lblLetra.Text = "B" Then
                    txtCantidad.Text = Format(CDbl(txtCantidad.Text), "#,##0.00")
                    txtImporte.Text = Format(CDbl(txtCantidad.Text) * CDbl(txtPrecio.Text), "$ #,##0.00")
                    txtImpFinal.Text = Format(CDbl(txtCantidad.Text) * CDbl(txtPrecioFin.Text), "$ #,##0.00")
                Else
                    txtCantidad.Text = Format(CDbl(txtCantidad.Text), "#,##0.00")
                    txtImporte.Text = Format(CDbl(txtCantidad.Text) * CDbl(txtPrecio.Text), "$ #,##0.00")
                    txtImpFinal.Text = Format(CDbl(txtImporte.Text), "$ #,##0.00")
                End If
            Else
                If lblLetra.Text = "A" Or lblLetra.Text = "B" Then
                    txtPrecioFin.Text = CDbl(txtPrecio.Text) + (CDbl(txtPrecio.Text) * CDbl(txtAlIvaReal.Text))
                    txtCantidad.Text = Format(CDbl(txtCantidad.Text), "#,##0.00")
                    txtImporte.Text = Format(CDbl(txtCantidad.Text) * CDbl(txtPrecio.Text), "$ #,##0.00")
                    txtImpFinal.Text = Format(CDbl(txtCantidad.Text) * CDbl(txtPrecioFin.Text), "$ #,##0.00")
                Else
                    txtPrecioFin.Text = txtPrecio.Text
                    txtCantidad.Text = Format(CDbl(txtCantidad.Text), "#,##0.00")
                    txtImporte.Text = Format(CDbl(txtCantidad.Text) * CDbl(txtPrecio.Text), "$ #,##0.00")
                    txtImpFinal.Text = Format(CDbl(txtImporte.Text), "$ #,##0.00")
                End If
            End If
        Else
            MsgBox("Error: Sólo se permiten valores numéricos !", vbInformation, "Servicio de Alertas")
            txtPrecio.SelectionLength = Len(txtPrecio.Text)
            txtPrecio.Select()
        End If
    End Sub

    Private Sub txtIdArt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdArt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If txtIdArt.Text = "" Then
                e.Handled = True
                frmConsStock.lblOrigen.Text = "Factura Venta"
                frmStock.txtBuscar.Select()
                frmConsStock.ShowDialog()
            Else
                e.Handled = True
                If IsNumeric(txtIdArt.Text) Then
                    Dim _Ver As New Mostrar
                    Dim _Ds As New DataSet
                    _Ds.Tables.Add(_Ver.verArticulos(mdifrmppal.cdEmp).Copy)
                    Dim _Dv As New DataView(_Ds.Tables(0))
                    _Dv.RowFilter = "IdArticulos = " & CInt(txtIdArt.Text)
                    If _Dv.Count <> 0 Then
                        dgvStock.DataSource = _Dv
                        dgvStock.Select()
                        txtArticulo.Text = dgvStock.SelectedCells.Item(4).Value
                        txtUnidad.Text = dgvStock.SelectedCells.Item(5).Value
                        txtCdBarra.SelectionLength = Len(txtCdBarra.Text)
                        txtCdBarra.Select()
                    Else
                        MsgBox("Error: Código de Artículo no se corresponde con ningún artículo !", vbInformation, "Servicio de Alertas")
                        txtArticulo.Text = ""
                        txtIdArt.Text = ""
                        txtIdArt.Select()
                    End If
                End If
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
        Dim _alIva As String = ""

        If txtAlicIva.Text = "" Then
            _alIva = "0"
        ElseIf Mid(txtAlicIva.Text, Len(txtAlicIva.Text), 1) = "%" Then
            _alIva = Mid(txtAlicIva.Text, 1, Len(txtAlicIva.Text) - 2)
        Else
            _alIva = txtAlicIva.Text
        End If

        If Not IsNumeric(_alIva) Then
            MsgBox("Error: Sólo se admiten números !", vbInformation, "Servicio de Alertas")
            txtAlicIva.Text = ""
            txtAlicIva.Select()
        Else
            If lblManual.Text = "Manual" Then
                txtAlIvaReal.Text = CDbl(_alIva) / 100
            End If
            txtAlicIva.Text = Format(CDbl(_alIva) / 100, "0.00 %")
            If lblLetra.Text = "A" Or lblLetra.Text = "B" Then
                txtPrecioFin.Text = CDbl(txtPrecio.Text) + (CDbl(txtPrecio.Text) * CDbl(txtAlIvaReal.Text))
                txtCantidad.Text = Format(CDbl(txtCantidad.Text), "#,##0.00")
                txtImporte.Text = Format(CDbl(txtCantidad.Text) * CDbl(txtPrecio.Text), "$ #,##0.00")
                txtImpFinal.Text = Format(CDbl(txtCantidad.Text) * CDbl(txtPrecioFin.Text), "$ #,##0.00")
            Else
                txtCantidad.Text = Format(CDbl(txtCantidad.Text), "#,##0.00")
                txtImporte.Text = Format(CDbl(txtCantidad.Text) * CDbl(txtPrecio.Text), "$ #,##0.00")
                txtImpFinal.Text = Format(CDbl(txtImporte.Text), "$ #,##0.00")
            End If
        End If
    End Sub

    Private Sub txtDescuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescuento.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtDescuento.SelectionLength = Len(txtDescuento.Text)
            txtIdArt.Select()
        End If
    End Sub

    Private Sub txtDescuento_Validated(sender As Object, e As EventArgs) Handles txtDescuento.Validated
        Try
            If Not IsNumeric(txtDescuento.Text) Then
                MsgBox("Error: Sólo se admiten números !", vbInformation, "Servicio de Alertas")
                txtDescuento.Text = ""
                txtDescuento.Select()
            Else
                If lblLetra.Text = "A" Then
                    txtDescuento.Text = Format(CDbl(txtDescuento.Text), "$ #,##0.00")
                    txtSubTotal.Text = Format(CDbl(txtSubTotalIva1050.Text) + CDbl(txtSubTotalIva2100.Text), "$ #,##0.00")
                    txtIva105.Text = Format(CDbl(txtSubTotalIva1050.Text) * 0.105, "$ #,##0.00")
                    txtIva21.Text = Format(CDbl(txtSubTotalIva2100.Text) * 0.21, "$ #,##0.00")
                    txtTotal.Text = Format(CDbl(txtSubTotal.Text) - CDbl(txtDescuento.Text) + CDbl(txtIva105.Text) + CDbl(txtIva21.Text), "$ #,##0.00")
                Else
                    txtDescuento.Text = Format(CDbl(txtDescuento.Text), "$ #,##0.00")
                    txtSubTotal.Text = Format(CDbl(txtSubTotalIva1050.Text) + CDbl(txtSubTotalIva2100.Text), "$ #,##0.00")
                    txtIva105.Text = Format(CDbl(txtSubTotalIva1050.Text) * 0, "$ #,##0.00")
                    txtIva21.Text = Format(CDbl(txtSubTotalIva2100.Text) * 0, "$ #,##0.00")
                    txtTotal.Text = Format(CDbl(txtSubTotal.Text) - CDbl(txtDescuento.Text) + CDbl(txtIva105.Text) + CDbl(txtIva21.Text), "$ #,##0.00")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al calcular descuento !" & vbCrLf & vbCrLf & ex.ToString, vbCritical, "Servicio de Alertas")
            txtDescuento.Text = Format(0, "$ #,##0.00")
            txtDescuento.SelectionLength = Len(txtDescuento.Text)
            txtDescuento.Select()
        End Try
    End Sub

    Private Sub txtArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtArticulo.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtUnidad.SelectionLength = Len(txtUnidad.Text)
            txtUnidad.Select()
        End If
    End Sub

    Private Sub txtUnidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnidad.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCantidad.Text = Format(1, "#,##0.00")
            txtCantidad.SelectionLength = Len(txtCantidad.Text)
            txtCantidad.Select()
        End If
    End Sub

    Private Sub dgvDetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalle.CellContentClick
        If e.ColumnIndex = Me.dgvDetalle.Columns.Item("Eliminar").Index Then
            Dim celSel As DataGridViewCheckBoxCell = Me.dgvDetalle.Rows(e.RowIndex).Cells("Eliminar")
            celSel.Value = Not celSel.Value
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim _Guardar As New GrabaDatos
        Dim ErrStk As String = "No"

        Try
            If txtArticulo.Text = "" Then
                MsgBox("Error: Seleccione un artículo !", vbInformation, "Servico de Alertas")
                If lblManual.Text = "Stock" Then
                    txtCdBarra.Select()
                Else
                    txtArticulo.Select()
                End If
            Else
                If txtCdBarra.Text = "" Then
                    MsgBox("Error: Código de Barra es obligatorio !", vbInformation, "Servico de Alertas")
                    txtCdBarra.Select()
                Else
                    If CDbl(txtCantidad.Text) = 0 Or CDbl(txtPrecio.Text) = 0 Then
                        MsgBox("Error: Cantidad y/o Precio NO pueden ser cero !", vbInformation, "Servico de Alertas")
                        txtCantidad.Select()
                    Else
                        If lblEnter.Text = "No" And lblManual.Text <> "Manual" Then
                            Dim _Ver As New Mostrar
                            Dim _Ds As New DataSet
                            _Ds.Tables.Add(_Ver.consStock(mdifrmppal.cdEmp).Copy)
                            Dim _Dv As New DataView(_Ds.Tables(0))
                            _Dv.RowFilter = "CodBarra = '" & txtCdBarra.Text & "'"

                            If _Dv.Count <> 0 Then
                                dgvStock.DataSource = _Dv
                                dgvStock.Select()
                                txtIdStock.Text = dgvStock.SelectedCells.Item(11).Value
                            Else
                                MsgBox("Error: Código de Barra no se corresponde con ningún artículo en Stock !", vbInformation, "Servicio de Alertas")
                                txtCdBarra.Text = ""
                                txtCdBarra.Select()
                                ErrStk = "Si"
                            End If
                        Else
                            lblEnter.Text = "No"
                        End If

                        If ErrStk = "No" Then
                            If lblManual.Text = "Manual" Then
                                txtIdArt.Text = -9999
                                txtCdBarra.Text = "CodigoBarraNoDisponible"
                            End If
                            If lblFuncion.Text = "Nuevo" Then
                                _Guardar.Grabar("Factura Venta", "NoImagen", "insLineaFacVenta", CInt(txtIdArt.Text), txtCdBarra.Text, txtArticulo.Text, _
                                                txtUnidad.Text, CDbl(txtCantidad.Text), CDbl(txtPrecio.Text), CDbl(txtAlIvaReal.Text), CDbl(txtImporte.Text), _
                                                CInt(txtIdStock.Text), CDbl(txtImpFinal.Text), CDbl(txtPrecioFin.Text), lblManual.Text)
                            Else
                                _Guardar.Grabar("Factura Venta", "NoImagen", "modLineaFacVenta", CInt(lblIdDet.Text), CInt(txtIdArt.Text), txtCdBarra.Text, txtArticulo.Text, _
                                                txtUnidad.Text, CDbl(txtCantidad.Text), CDbl(txtPrecio.Text), CDbl(txtAlIvaReal.Text), CDbl(txtImporte.Text), _
                                                CInt(txtIdStock.Text), CDbl(txtImpFinal.Text), CDbl(txtPrecioFin.Text), lblManual.Text)
                            End If

                            If lblLetra.Text = "A" Then
                                ActualizaTotalesA()
                            ElseIf lblLetra.Text = "B" Then
                                ActualizaTotalesB()
                            Else
                                ActualizaTotalesCX()
                            End If

                            lblManual.Text = "Stock"
                            txtIdArt.Text = ""
                            txtCdBarra.Text = ""
                            txtIdArt.Enabled = False
                            txtArticulo.Enabled = False
                            txtUnidad.Enabled = False
                            txtIdArt.BackColor = Color.MediumTurquoise
                            txtArticulo.BackColor = Color.MediumTurquoise
                            txtUnidad.BackColor = Color.MediumTurquoise
                            txtIdArt.ForeColor = Color.Teal
                            txtArticulo.ForeColor = Color.Teal
                            txtUnidad.ForeColor = Color.Teal
                            Limpiar()
                            lblFuncion.Text = "Nuevo"
                            btnModificar.Enabled = True
                            btnEliminar.Enabled = True
                            lblLetra.Enabled = True
                            txtCdBarra.Select()
                        End If
                    End If
                End If
            End If
        Catch ex As MySqlException
            MsgBox("Error: Tabla Detalle no fue modificada !" & vbCrLf & vbCrLf & ex.ToString, vbCritical, "Servicio de Alertas")
            BDxxx()
        Finally
            BDxxx()
        End Try
    End Sub

    Private Sub LimpiarTodo()
        txtIdArt.Text = ""
        txtArticulo.Text = ""
        txtUnidad.Text = ""
        txtCdBarra.Text = ""
        txtIdCliente.Text = ""
        txtCliente.Text = ""
        txtCuit.Text = ""
        txtDir.Text = ""
        txtLoc.Text = ""
        txtProv.Text = ""
        txtIIBB.Text = ""
        txtCatIva.Text = ""
        txtEst.Text = ""
        txtIdStock.Text = ""
        txtObserv.Text = ""
        txtPrecioFin.Text = "0"
        txtCred.Text = Format(0, "$ #,##0.00")
        rbtFactura.Checked = True
        rbtnNC.Checked = False
        rbnND.Checked = False
        txtCantidad.Text = Format(0, "#,##0.00")
        txtPrecio.Text = Format(0, "$ #,##0.00")
        txtAlicIva.Text = Format(0, "0.00 ")
        txtImporte.Text = Format(0, "$ #,##0.00")
        txtSubTotalIva1050.Text = Format(0, "$ #,##0.00")
        txtSubTotalIva2100.Text = Format(0, "$ #,##0.00")
        txtSubTotal.Text = Format(0, "$ #,##0.00")
        txtDescuento.Text = Format(0, "$ #,##0.00")
        txtIva105.Text = Format(0, "$ #,##0.00")
        txtIva21.Text = Format(0, "$ #,##0.00")
        txtIva105Contable.Text = Format(0, "$ #,##0.00")
        txtIva21Contable.Text = Format(0, "$ #,##0.00")
        txtTotal.Text = Format(0, "$ #,##0.00")
        txtCuotas.Text = "0"
        txtVto.Text = Date.Now.Date
        txtImpCta.Text = Format(0, "$ #,##0.00")
        lblLetra.Text = "A"
        rbtFactura.Checked = True
        rbtCdo.Checked = True
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        gbxFactura.Enabled = False
        gbxLetra.Enabled = False
        gbxTipoC.Enabled = False
        gbxTipoVta.Enabled = False
        gbxCarga.Enabled = False
        gbxControles.Enabled = False
        gbxDetalle.Enabled = False
        gbxObserv.Enabled = False
        gbxResumen.Enabled = False
        txtIdCliente.Select()
    End Sub

    Private Sub Limpiar()
        txtIdArt.Text = ""
        txtArticulo.Text = ""
        txtUnidad.Text = ""
        txtCdBarra.Text = ""
        txtCantidad.Text = Format(0, "#,##0.00")
        txtPrecio.Text = Format(0, "$ #,##0.00")
        txtAlicIva.Text = Format(0, "0.00 ")
        txtImporte.Text = Format(0, "$ #,##0.00")
        txtImpFinal.Text = Format(0, "$ #,##0.00")
        txtIdArt.Select()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Limpiar()
        txtIdArt.Select()
        lblLetra.Enabled = True
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim resP As DialogResult
        Dim _Elim As New GrabaDatos

        resP = MessageBox.Show("Elimar Items Selcionados!?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If resP = Windows.Forms.DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dgvDetalle.Rows
                    Dim seL As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If seL = True Then
                        Dim clElim As Integer = Convert.ToInt32(row.Cells("IdDF").Value)
                        _Elim.Grabar("Factura Compra", "NoImagen", "eliDetalleFac", clElim)
                    End If
                Next

                If lblLetra.Text = "A" Then
                    ActualizaTotalesA()
                ElseIf lblLetra.Text = "B" Then
                    ActualizaTotalesB()
                Else
                    ActualizaTotalesCX()
                End If

                Limpiar()
                btnModificar.Enabled = True
                btnEliminar.Enabled = True
                txtIdArt.Select()
            Catch ex As MySqlException
                MsgBox("Error al Eliminar Items de Factura !" & vbCrLf & vbCrLf & ex.ToString, vbCritical, "Servicio de Alertas")
            End Try
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If dgvDetalle.RowCount <> 0 Then
                lblFuncion.Text = "Modificar"
                lblIdDet.Text = dgvDetalle.SelectedCells.Item(1).Value
                txtIdArt.Text = dgvDetalle.SelectedCells.Item(2).Value
                txtCdBarra.Text = dgvDetalle.SelectedCells.Item(3).Value
                txtArticulo.Text = dgvDetalle.SelectedCells.Item(4).Value
                txtUnidad.Text = dgvDetalle.SelectedCells.Item(5).Value
                txtCantidad.Text = Format(CDbl(dgvDetalle.SelectedCells.Item(6).Value), "#,##0.00")
                If lblLetra.Text = "A" Or lblLetra.Text = "B" Then
                    txtPrecio.Text = Format(CDbl(dgvDetalle.SelectedCells.Item(7).Value), "$ #,##0.00")
                    txtAlicIva.Text = Format(CDbl(dgvDetalle.SelectedCells.Item(8).Value), "0.00 %")
                    txtAlIvaReal.Text = CDbl(dgvDetalle.SelectedCells.Item(8).Value)
                    txtImporte.Text = Format(CDbl(dgvDetalle.SelectedCells.Item(9).Value), "#,##0.00")
                    txtImpFinal.Text = Format(CDbl(dgvDetalle.SelectedCells.Item(11).Value), "#,##0.00")
                    txtPrecioFin.Text = Format(CDbl(dgvDetalle.SelectedCells.Item(12).Value), "#,##0.00")
                Else
                    txtPrecio.Text = Format(CDbl(dgvDetalle.SelectedCells.Item(11).Value), "$ #,##0.00")
                    txtAlicIva.Text = Format(CDbl(0), "0.00 %")
                    txtAlIvaReal.Text = CDbl(dgvDetalle.SelectedCells.Item(8).Value)
                    txtImporte.Text = Format(CDbl(dgvDetalle.SelectedCells.Item(9).Value), "#,##0.00")
                    txtImpFinal.Text = Format(CDbl(dgvDetalle.SelectedCells.Item(11).Value), "#,##0.00")
                    txtPrecioFin.Text = Format(CDbl(dgvDetalle.SelectedCells.Item(12).Value), "#,##0.00")
                End If
                If dgvDetalle.SelectedCells.Item(13).Value = "Manual" Then
                    lblManual.Text = "Manual"
                    txtIdArt.Text = -9999
                    txtIdArt.Enabled = True
                    txtArticulo.Enabled = True
                    txtUnidad.Enabled = True
                    txtCdBarra.Text = "CodigoBarraNoDisponible"
                    txtArticulo.Text = "Servicio Técnico"
                    txtUnidad.Text = "Sv.Tec."
                    txtAlIvaReal.Text = "1"
                    txtIdStock.Text = "-99"
                    txtIdArt.BackColor = Color.Orange
                    txtArticulo.BackColor = Color.Orange
                    txtUnidad.BackColor = Color.Orange
                    txtIdArt.ForeColor = Color.White
                    txtArticulo.ForeColor = Color.White
                    txtUnidad.ForeColor = Color.White
                    txtArticulo.Select()
                Else
                    lblManual.Text = "Stock"
                    txtIdArt.Text = ""
                    txtCdBarra.Text = ""
                    txtIdArt.Enabled = False
                    txtArticulo.Enabled = False
                    txtUnidad.Enabled = False
                    txtIdArt.BackColor = Color.MediumTurquoise
                    txtArticulo.BackColor = Color.MediumTurquoise
                    txtUnidad.BackColor = Color.MediumTurquoise
                    txtIdArt.ForeColor = Color.Teal
                    txtArticulo.ForeColor = Color.Teal
                    txtUnidad.ForeColor = Color.Teal
                    txtIdArt.SelectionLength = Len(txtIdArt.Text)
                    txtIdArt.Select()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: No se pueden cargar los datos para modificar !" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            txtIdArt.Select()
        End Try
    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim _Elim As New GrabaDatos
        If dgvDetalle.RowCount <> 0 Then
            Dim resP As DialogResult
            resP = MessageBox.Show("Salir y vaciar contenido del detalle ?", "Servico de Alertas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If resP = Windows.Forms.DialogResult.Yes Then
                _Elim.Grabar("Factura Venta", "NoImagen", "vaciaDetalleFac")
                _Elim.Grabar("Factura Venta", "NoImagen", "vaciaFormaPagoBuf")
                LimpiarTodo()
                lblManual.Text = "Stock"
                lblLetra.Enabled = True
                Me.Hide()
            End If
        Else
            LimpiarTodo()
            lblManual.Text = "Stock"
            lblLetra.Enabled = True
            Me.Hide()
        End If
    End Sub

    Private Sub btnEmitirFactura_Click(sender As Object, e As EventArgs) Handles btnEmitirFactura.Click
        Dim resP As DialogResult
        Dim _Guardar As New GrabaDatos
        Dim _Fe As New FacturaElectronica
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar
        Dim obtenerCAE As String
        Dim _CAE, _nroAut As String
        Dim _vtoCAE As Date
        Dim salTar As String = "NO"

        If txtIdCliente.Text = "" Or txtCliente.Text = "" Then
            MsgBox("Error: Falta cargar cliente !", vbInformation, "Servico de Alertas")
            txtIdCliente.Select()
        Else
            If txtFecha.Text = "" Then
                MsgBox("Error: Fecha comprobante es obligatoria !", vbInformation, "Servico de Alertas")
                txtCdBarra.Select()
            Else
                If lblComprobante.Text = "" Then
                    MsgBox("Error: Falta Número de Comprobante !", vbInformation, "Servico de Alertas")
                    txtCdBarra.Select()
                Else
                    If dgvDetalle.RowCount = 0 Then
                        MsgBox("Error: Factura sin detalle cargado !", vbInformation, "Servico de Alertas")
                        txtCdBarra.Select()
                    Else
                        resP = MessageBox.Show("Registra Comprobante de Venta ?", "Servico de Alertas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                        If resP = Windows.Forms.DialogResult.Yes Then
                            Try
                                'Comienza pedido de CAE
                                '---------------------------------------------------------------------------
                                Dim tipoComp As String
                                If rbtFactura.Checked = True Then
                                    tipoComp = "Factura"
                                ElseIf rbtnNC.Checked = True Then
                                    tipoComp = "Nota Credito"
                                ElseIf rbnND.Checked = True Then
                                    tipoComp = "Nota Debito"
                                Else
                                    tipoComp = "Comprobante"
                                End If

                                Dim cnpTo As String = ""
                                Select Case cbxConceptos.Text
                                    Case "1 - Productos"
                                        cnpTo = "1"
                                    Case "2 - Servicios"
                                        cnpTo = "2"
                                    Case "3 - Productos y Servicos"
                                        cnpTo = "3"
                                End Select

                                Dim triB(11) As String 'Lo cargo todo vacio ya que no tengo tributos extras
                                triB(0) = "0" 'Cantidad de tributos
                                'Tributo 1
                                triB(1) = "0"
                                triB(2) = " "
                                triB(3) = "0"
                                triB(4) = "0"
                                triB(5) = "0"
                                'Tributo 2
                                triB(6) = "0"
                                triB(7) = " "
                                triB(8) = "0"
                                triB(9) = "0"
                                triB(10) = "0"

                                Dim ivaSuma As Double
                                Dim subTcont As Double
                                Dim ivArray(10) As String
                                If CDbl(txtIva105Contable.Text) > 0 And CDbl(txtIva21Contable.Text) > 0 Then
                                    ivArray(0) = "2"
                                    ivArray(1) = "4"
                                    ivArray(2) = CDbl(txtSubTotalIva1050.Text).ToString
                                    ivArray(3) = CDbl(txtIva105Contable.Text).ToString
                                    ivArray(4) = "5"
                                    ivArray(5) = CDbl(txtSubTotalIva2100.Text).ToString
                                    ivArray(6) = CDbl(txtIva21Contable.Text).ToString
                                    'Dejo un item en blanco por si hay que agregar despues
                                    ivArray(7) = "3"
                                    ivArray(8) = CDbl(0).ToString
                                    ivArray(9) = CDbl(0).ToString
                                ElseIf CDbl(txtIva105Contable.Text) > 0 And CDbl(txtIva21Contable.Text) = 0 Then
                                    ivArray(0) = "1"
                                    ivArray(1) = "4"
                                    ivArray(2) = CDbl(txtSubTotalIva1050.Text).ToString
                                    ivArray(3) = CDbl(txtIva105Contable.Text).ToString
                                    'En blanco por que hay un solo iva
                                    ivArray(4) = "3"
                                    ivArray(5) = CDbl(0).ToString
                                    ivArray(6) = CDbl(0).ToString
                                    'Dejo un item en blanco por si hay que agregar despues
                                    ivArray(7) = "3"
                                    ivArray(8) = CDbl(0).ToString
                                    ivArray(9) = CDbl(0).ToString
                                ElseIf CDbl(txtIva105Contable.Text) = 0 And CDbl(txtIva21Contable.Text) > 0 Then
                                    ivArray(0) = "1"
                                    ivArray(1) = "5"
                                    ivArray(2) = CDbl(txtSubTotalIva2100.Text).ToString
                                    ivArray(3) = CDbl(txtIva21Contable.Text).ToString
                                    'En blanco por que hay un solo iva
                                    ivArray(4) = "3"
                                    ivArray(5) = CDbl(0).ToString
                                    ivArray(6) = CDbl(0).ToString
                                    'Dejo un item en blanco por si hay que agregar despues
                                    ivArray(7) = "3"
                                    ivArray(8) = CDbl(0).ToString
                                    ivArray(9) = CDbl(0).ToString
                                Else 'Factura sin iva
                                    ivArray(0) = "0"
                                    ivArray(1) = "3"
                                    ivArray(2) = CDbl(0).ToString
                                    ivArray(3) = CDbl(0).ToString
                                    ivArray(4) = "3"
                                    ivArray(5) = CDbl(0).ToString
                                    ivArray(6) = CDbl(0).ToString
                                    'Dejo un item en blanco por si hay que agregar despues
                                    ivArray(7) = "3"
                                    ivArray(8) = CDbl(0).ToString
                                    ivArray(9) = CDbl(0).ToString
                                End If
                                ivaSuma = CDbl(txtIva105Contable.Text) + CDbl(txtIva21Contable.Text)
                                subTcont = CDbl(txtSubTotalIva1050.Text) + CDbl(txtSubTotalIva2100.Text)

                                If lblLetra.Text <> "X" Then
                                    obtenerCAE = _Fe.PedirCAE(1, txtCdEmp.Text, mdiFrmPpal.cuitEmp, mdiFrmPpal.rutaCertPC,
                                                         mdiFrmPpal.certificadoPC, lblTiket.Text, "Libre", "1",
                                                         tipoComp & " " & lblLetra.Text,
                                                          CInt(lblPtoVta.Text), cnpTo, "Cuit", txtCuit.Text, " ", " ",
                                                         Format(CDate(txtFecha.Text), "yyyy/MM/dd"),
                                                         CDbl(txtTotal.Text).ToString, "0", subTcont.ToString,
                                                         "0", ivaSuma.ToString, "0",
                                                         Format(CDate(txtFecha.Text), "yyyy/MM/dd"),
                                                         Format(CDate(txtFecha.Text), "yyyy/MM/dd"),
                                                         Format(CDate(txtFecha.Text), "yyyy/MM/dd"),
                                                         "PES", "1", "1",
                                                         triB(0), triB(1), triB(2), triB(3), triB(4), triB(5),
                                                         triB(6), triB(7), triB(8), triB(9), triB(10),
                                                         ivArray(0), ivArray(1), ivArray(2), ivArray(3),
                                                         ivArray(4), ivArray(5), ivArray(6),
                                                         ivArray(7), ivArray(8), ivArray(9),
                                                         "0")
                                    'Fin pedido de CAE
                                    '---------------------------------------------------------------------------

                                    If obtenerCAE = "A" Then
                                        Dim convFec As String
                                        Dim lenNraut As Integer
                                        Dim Relleno As String = ""
                                        Dim Xaut As Integer

                                        convFec = Mid(_Fe.vtoCAE, 1, 4) & "/" & Mid(_Fe.vtoCAE, 5, 2) & "/" & Mid(_Fe.vtoCAE, 7, 2)

                                        _CAE = _Fe.nroCAE
                                        _vtoCAE = CDate(convFec)
                                        _nroAut = _Fe.nroAutorizado
                                        lenNraut = Len(_nroAut)
                                        For Xaut = 1 To 8 - lenNraut
                                            Relleno = Relleno & "0"
                                        Next
                                        _nroAut = Relleno & _nroAut
                                        lblComprobante.Text = _nroAut
                                    Else
                                        resP = MessageBox.Show("El comprobante fue Rechazado por AFIP, lo registra de todos modos ?", "Servico de Alertas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                                        If resP = Windows.Forms.DialogResult.No Then
                                            salTar = "SI"
                                        End If
                                        _CAE = " "
                                        _vtoCAE = Date.Now
                                        _nroAut = "0"
                                    End If
                                Else
                                    _CAE = "99999999999999"
                                    _vtoCAE = Date.Now.Date

                                    _Dt = _Ver.verSistema(mdifrmppal.cdEmp)
                                    Dim _Row As DataRow = _Dt.Rows(_Dt.Rows.Count - 1)
                                    lblComprobante.Text = CStr(_Row("NroFacturaNCND_X"))

                                    _nroAut = lblComprobante.Text
                                End If

                                If salTar = "NO" Then
                                    Dim fPago As String
                                    If rbtCdo.Checked = True Then
                                        fPago = "Contado"
                                    Else
                                        fPago = "Cuenta Corriente"
                                    End If

                                    'STOCK
                                    Dim _Dtstk As New DataTable
                                    Dim _Verstk As New Mostrar
                                    Dim CantStk As Double
                                    For Each row As DataGridViewRow In dgvDetalle.Rows
                                        If rbtnNC.Checked = True Then
                                            If row.Cells(13).Value = "Stock" Then
                                                _Dtstk = _Verstk.consStockID(Val(row.Cells(10).Value))
                                                dgvStock.DataSource = _Dtstk
                                                _Guardar.Grabar("Factura Venta", "NoImagen", "insStock", mdifrmppal.cdEmp, Format(CDate(txtFecha.Text), "yyyy/MM/dd"), _
                                                                    row.Cells(3).Value, Val(row.Cells(6).Value), 1, mdifrmppal.usSis, Val(row.Cells(2).Value))
                                            End If
                                        Else
                                            If row.Cells(13).Value = "Stock" Then
                                                _Dtstk = _Verstk.consStockID(Val(row.Cells(10).Value))
                                                dgvStock.DataSource = _Dtstk
                                                CantStk = CDbl(dgvStock.SelectedCells.Item(4).Value) - Val(row.Cells(6).Value)
                                                If CantStk = 0 Then
                                                    _Guardar.Grabar("Factura Venta", "NoImagen", "modStockResta", Val(row.Cells(10).Value), 0, mdifrmppal.usSis)
                                                Else
                                                    _Guardar.Grabar("Factura Venta", "NoImagen", "modStockRestaParcial", Val(row.Cells(10).Value), CantStk, mdifrmppal.usSis)
                                                End If
                                            End If
                                        End If
                                    Next

                                    Dim cdBar As String
                                    cdBar = "*" & lblCodComprobante.Text & lblLetra.Text & Mid(lblComprobante.Text, 1, 4) & Mid(lblComprobante.Text, 6, 8) & Mid(txtFecha.Text, 1, 2) & Mid(txtFecha.Text, 4, 2) & Mid(txtFecha.Text, 7, 4) & "*"

                                    'CUENTA CORRIENTE VENTA
                                    'Obtener saldo de Cuenta Corriente de Venta
                                    Dim ulTid As Integer
                                    Dim _VerMax As New Mostrar
                                    Dim _DtMax As New DataTable
                                    Dim saldoCta As Double
                                    _DtMax = _VerMax.verMaxIdVentaCtaCte()

                                    Dim _Row As DataRow = _DtMax.Rows(_DtMax.Rows.Count - 1)
                                    If _Row("UltimoId").ToString = "" Then
                                        ulTid = 0
                                        saldoCta = 0
                                    Else
                                        ulTid = _Row("UltimoId")
                                        _DtMax = _VerMax.consCtaCteVentaID(ulTid)
                                        dgvCtaCte.DataSource = _DtMax
                                        saldoCta = CDbl(dgvCtaCte.SelectedCells.Item(12).Value)
                                    End If

                                    If tipoComp = "Nota Credito" Then
                                        saldoCta = saldoCta - CDbl(txtTotal.Text)
                                        _Guardar.Grabar("Factura Venta", "NoImagen", "insCtaCteVenta", txtCdEmp.Text, cdBar, Format(CDate(txtFecha.Text), "yyyy/MM/dd"), _
                                                       fPago, lblLetra.Text, tipoComp, lblCodComprobante.Text, lblPtoVta.Text, lblComprobante.Text, 0, CDbl(txtTotal.Text), saldoCta, mdifrmppal.usSis, CInt(txtIdCliente.Text))
                                    Else
                                        saldoCta = saldoCta + CDbl(txtTotal.Text)
                                        _Guardar.Grabar("Factura Venta", "NoImagen", "insCtaCteVenta", txtCdEmp.Text, cdBar, Format(CDate(txtFecha.Text), "yyyy/MM/dd"), _
                                                       fPago, lblLetra.Text, tipoComp, lblCodComprobante.Text, lblPtoVta.Text, lblComprobante.Text, CDbl(txtTotal.Text), 0, saldoCta, mdifrmppal.usSis, CInt(txtIdCliente.Text))
                                    End If

                                    'Obtener ultimo ID cargado de Cuenta Corriente de Venta
                                    _DtMax = _VerMax.verMaxIdVentaCtaCte()
                                    _Row = _DtMax.Rows(_DtMax.Rows.Count - 1)
                                    ulTid = _Row("UltimoId")
                                    cdBar = "*" & lblCodComprobante.Text & lblLetra.Text & Mid(lblComprobante.Text, 1, 4) & Mid(lblComprobante.Text, 6, 8) & Mid(txtFecha.Text, 1, 2) & Mid(txtFecha.Text, 4, 2) & Mid(txtFecha.Text, 7, 4) & ulTid & "*"

                                    'FACTURA VENTA
                                    Dim _Bi As Double = CDbl(txtSubTotal.Text) - CDbl(txtDescuento.Text)
                                    Dim alI105, alI21 As Double
                                    If lblLetra.Text = "X" Then
                                        alI105 = 0
                                        alI21 = 0
                                    Else
                                        alI105 = 0.105
                                        alI21 = 0.21
                                    End If
                                    _Guardar.Grabar("Factura Venta", "NoImagen", "insFacVenta", txtCdEmp.Text, cdBar, Format(CDate(txtFecha.Text), "yyyy/MM/dd"), lblPtoVta.Text, lblComprobante.Text, _
                                                     tipoComp, CDbl(txtSubTotal.Text), CDbl(txtDescuento.Text), _Bi, alI105, CDbl(txtIva105Contable.Text), alI21, CDbl(txtIva21Contable.Text), 0, 0, _
                                                     CDbl(txtTotal.Text), txtObserv.Text, mdifrmppal.usSis, _CAE, Format(CDate(_vtoCAE), "yyyy/MM/dd"), "Si", _
                                                     Format(CDate(txtFecha.Text), "yyyy/MM/dd"), "No", Format(CDate(txtFecha.Text), "yyyy/MM/dd"), ulTid)

                                    'Obtener ultimo ID cargado de Factura de Venta
                                    _DtMax = _VerMax.verMaxIdVentaFacturas()
                                    _Row = _DtMax.Rows(_DtMax.Rows.Count - 1)
                                    ulTid = _Row("UltimoId")
                                    lblIdFactura.Text = ulTid

                                    'DETALLE DE FACTURA DE VENTA
                                    If lblLetra.Text = "B" Then
                                        Dim precCiva As Double
                                        Dim impCiva As Double
                                        For Each row As DataGridViewRow In dgvDetalle.Rows
                                            precCiva = CDbl(Val(row.Cells(7).Value)) + (CDbl(Val(row.Cells(7).Value)) * CDbl(Val(row.Cells(8).Value)))
                                            impCiva = CDbl(Val(row.Cells(6).Value)) * precCiva
                                            _Guardar.Grabar("Factura Venta", "NoImagen", "insDetalleFacVenta", Val(row.Cells(2).Value), row.Cells(3).Value, row.Cells(4).Value, _
                                                           row.Cells(5).Value, CDbl(Val(row.Cells(6).Value)), precCiva, CDbl(Val(row.Cells(8).Value)), _
                                                           impCiva, mdifrmppal.usSis, ulTid)
                                        Next
                                    Else
                                        For Each row As DataGridViewRow In dgvDetalle.Rows
                                            _Guardar.Grabar("Factura Venta", "NoImagen", "insDetalleFacVenta", Val(row.Cells(2).Value), row.Cells(3).Value, row.Cells(4).Value, _
                                                           row.Cells(5).Value, CDbl(Val(row.Cells(6).Value)), CDbl(Val(row.Cells(7).Value)), CDbl(Val(row.Cells(8).Value)), _
                                                           CDbl(Val(row.Cells(9).Value)), mdifrmppal.usSis, ulTid)
                                        Next
                                    End If

                                    'FORMA DE PAGO FACTURA DE VENTA
                                    If rbtCtaCte.Checked = True Then
                                        For Each row As DataGridViewRow In dgvPago.Rows
                                            _Guardar.Grabar("Factura Venta", "NoImagen", "insFormaPago", row.Cells(1).Value, row.Cells(2).Value, CInt(Val(row.Cells(3).Value)), Format(CDate(row.Cells(4).Value), "yyyy/MM/dd"), _
                                                            CDbl(Val(row.Cells(5).Value)), row.Cells(6).Value, ulTid)
                                        Next
                                    Else
                                        _Guardar.Grabar("Factura Venta", "NoImagen", "insFormaPago", lblPtoVta.Text, lblComprobante.Text, 0, Format(CDate(txtFecha.Text), "yyyy/MM/dd"), _
                                                        CDbl(txtTotal.Text), txtObserv.Text, ulTid)
                                    End If

                                    If txtCliente.Text = "Consumidor Final" Then
                                        'Compenso Cta Cte
                                        If tipoComp = "Factura" Then
                                            saldoCta = saldoCta - CDbl(txtTotal.Text)
                                            _Guardar.Grabar("Factura Venta", "NoImagen", "insCtaCteVenta", txtCdEmp.Text, cdBar, Format(CDate(txtFecha.Text), "yyyy/MM/dd"), _
                                                           fPago, lblLetra.Text, "Compensacion Cta Cte", lblCodComprobante.Text, lblPtoVta.Text, lblComprobante.Text, 0, CDbl(txtTotal.Text), saldoCta, mdifrmppal.usSis, CInt(txtIdCliente.Text))
                                        End If

                                        'Obtener saldo de caja del día actual
                                        Dim idCj As Integer
                                        Dim saldoCj As Double
                                        _DtMax = _VerMax.verMaxIdCaja()
                                        Dim _Row1 As DataRow = _DtMax.Rows(_DtMax.Rows.Count - 1)

                                        If rbtnNC.Checked = True Then
                                            If _Row1("UltimoId").ToString = "" Then
                                                idCj = 0
                                                saldoCj = 0 - CDbl(txtTotal.Text)
                                            Else
                                                idCj = _Row1("UltimoId")
                                                _DtMax = _VerMax.verSaldoCajaUltimoId(idCj)
                                                dgvCaja.DataSource = _DtMax
                                                saldoCj = Format(CDbl(dgvCaja.SelectedCells.Item(10).Value), "$ #,##0.00")
                                                saldoCj = saldoCj - CDbl(txtTotal.Text)
                                            End If
                                        Else
                                            If _Row1("UltimoId").ToString = "" Then
                                                idCj = 0
                                                saldoCj = 0 + CDbl(txtTotal.Text)
                                            Else
                                                idCj = _Row1("UltimoId")
                                                _DtMax = _VerMax.verSaldoCajaUltimoId(idCj)
                                                dgvCaja.DataSource = _DtMax
                                                saldoCj = Format(CDbl(dgvCaja.SelectedCells.Item(10).Value), "$ #,##0.00")
                                                saldoCj = saldoCj + CDbl(txtTotal.Text)
                                            End If
                                        End If

                                        'Grabar caja
                                        Dim recV As String

                                        If rbtnNC.Checked = True Then
                                            recV = "Nota Credito N° " & lblPtoVta.Text & "-" & lblComprobante.Text
                                            _Guardar.Grabar("Factura Venta", "NoImagen", "insCaja", txtCdEmp.Text, Format(CDate(txtFecha.Text), "yyyy/MM/dd"), _
                                                            "Egreso", CInt(txtIdCliente.Text), txtCliente.Text, recV, 0, CDbl(txtTotal.Text), _
                                                            saldoCj, "-", mdifrmppal.usSis)
                                        Else
                                            If rbnND.Checked = True Then
                                                recV = "Nota Débito N° " & lblPtoVta.Text & "-" & lblComprobante.Text
                                            Else
                                                recV = "Factura N° " & lblPtoVta.Text & "-" & lblComprobante.Text
                                            End If
                                            _Guardar.Grabar("Factura Venta", "NoImagen", "insCaja", txtCdEmp.Text, Format(CDate(txtFecha.Text), "yyyy/MM/dd"), _
                                                            "Ingreso", CInt(txtIdCliente.Text), txtCliente.Text, recV, CDbl(txtTotal.Text), 0, _
                                                            saldoCj, "-", mdifrmppal.usSis)
                                        End If

                                        resP = MessageBox.Show("Imprime Comprobante ?", "Servico de Alertas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                        If resP = Windows.Forms.DialogResult.Yes Then
                                            frmInfFacturaVenta.lblOrigen.Text = "Factura Venta"
                                            frmInfFacturaVenta.lblTipo.Text = lblLetra.Text
                                            ImprimirFacturaVenta()
                                        End If
                                    End If

                                    If lblLetra.Text <> "X" Then
                                        frmInfFacturaVenta.lblOrigen.Text = "Factura Venta"
                                        frmInfFacturaVenta.lblTipo.Text = lblLetra.Text
                                        ImprimirFacturaVenta()
                                    Else
                                        If txtCliente.Text <> "Consumidor Final" Then
                                            resP = MessageBox.Show("Imprime Comprobante?", "Servico de Alertas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                            If resP = Windows.Forms.DialogResult.Yes Then
                                                frmInfFacturaVenta.lblOrigen.Text = "Factura Venta"
                                                frmInfFacturaVenta.lblTipo.Text = lblLetra.Text
                                                ImprimirFacturaVenta()
                                            End If
                                        End If
                                    End If

                                    'ACTUALIZO NUMERO FACTURA
                                    Dim X, _inC, _Dig As Integer
                                    Dim _reSto As String

                                    For X = 1 To 8
                                        If Mid(lblComprobante.Text, X, 1) <> "0" Then
                                            _Dig = 9 - X
                                            Exit For
                                        End If
                                    Next

                                    _inC = Mid(lblComprobante.Text, 9 - _Dig, _Dig)
                                    _inC = _inC + 1
                                    _Dig = Len(CStr(_inC))
                                    _reSto = Mid(lblComprobante.Text, 1, 8 - _Dig)
                                    lblComprobante.Text = _reSto & CStr(_inC)

                                    If lblLetra.Text = "A" Then
                                        _Guardar.Grabar("Factura Venta", "NoImagen", "modSistemaNroFacturaA", txtCdEmp.Text, lblComprobante.Text)
                                    ElseIf lblLetra.Text = "B" Then
                                        _Guardar.Grabar("Factura Venta", "NoImagen", "modSistemaNroFacturaB", txtCdEmp.Text, lblComprobante.Text)
                                    ElseIf lblLetra.Text = "C" Then
                                        _Guardar.Grabar("Factura Venta", "NoImagen", "modSistemaNroFacturaC", txtCdEmp.Text, lblComprobante.Text)
                                    Else
                                        _Guardar.Grabar("Factura Venta", "NoImagen", "modSistemaNroFacturaX", txtCdEmp.Text, lblComprobante.Text)
                                    End If

                                    'Limpio datagrid y pantalla
                                    Dim _Elim As New GrabaDatos
                                    _Elim.Grabar("Factura Venta", "NoImagen", "vaciaDetalleFac")
                                    _Dt = _Ver.verDetalleFac()
                                    dgvDetalle.DataSource = _Dt
                                    _Elim.Grabar("Factura Venta", "NoImagen", "vaciaFormaPagoBuf")
                                    _Dt = _Ver.verFormaPagoBf(lblPtoVta.Text, lblComprobante.Text)
                                    dgvPago.DataSource = _Dt

                                    LimpiarTodo()
                                    lblFuncion.Text = "Nuevo"
                                    lblManual.Text = "Stock"
                                    btnModificar.Enabled = True
                                    btnEliminar.Enabled = True
                                    txtIdArt.Select()
                                End If
                            Catch ex As MySqlException
                                MsgBox("Error: Factura de Venta No fue Registrada correctamente !" & vbCrLf & vbCrLf & ex.ToString, vbCritical, "Servicio de Alertas")
                            End Try
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnManual_Click(sender As Object, e As EventArgs) Handles btnManual.Click
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        _Dt = _Ver.verArticuloManual()

        If _Dt.Rows.Count > 0 Then
            If lblManual.Text = "Stock" Then
                lblManual.Text = "Manual"
                txtIdArt.Text = _Dt.Rows(0).Item(0)
                txtArticulo.Enabled = True
                txtUnidad.Enabled = True
                txtCdBarra.Text = _Dt.Rows(0).Item(17)
                txtArticulo.Text = _Dt.Rows(0).Item(4)
                txtUnidad.Text = _Dt.Rows(0).Item(5)
                txtAlIvaReal.Text = "1"
                txtIdStock.Text = _Dt.Rows(0).Item(14)
                'txtIdArt.BackColor = Color.Orange
                'txtArticulo.BackColor = Color.Orange
                'txtUnidad.BackColor = Color.Orange
                'txtIdArt.ForeColor = Color.White
                'txtArticulo.ForeColor = Color.White
                'txtUnidad.ForeColor = Color.White
                txtArticulo.Select()
            Else
                lblManual.Text = "Stock"
                txtIdArt.Text = ""
                txtArticulo.Text = ""
                txtUnidad.Text = ""
                txtCdBarra.Text = ""
                txtIdArt.Enabled = False
                txtArticulo.Enabled = False
                txtUnidad.Enabled = False
                'txtIdArt.BackColor = Color.MediumTurquoise
                'txtArticulo.BackColor = Color.MediumTurquoise
                'txtUnidad.BackColor = Color.MediumTurquoise
                'txtIdArt.ForeColor = Color.Teal
                'txtArticulo.ForeColor = Color.Teal
                'txtUnidad.ForeColor = Color.Teal
                txtIdArt.Select()
            End If
        Else
            MsgBox("Error: No ha cargado ningún artrículo con atributos especiales para facturar manualmente!", vbCritical, "Servicio de Alertas")
        End If
    End Sub

    Private Sub frmFacturaVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim _Ver, _Ver1, _Ver2 As New Mostrar
            Dim _Dt, _Dt1, _Dt2 As New DataTable
            Dim _Elim As New GrabaDatos

            _Dt = _Ver.verDetalleFac()
            dgvDetalle.DataSource = _Dt
            dgvDetalle.Columns.Item("IdArt").Visible = False
            dgvDetalle.Columns.Item("IdDF").Visible = False
            dgvDetalle.Columns.Item("IdStock").Visible = False
            dgvDetalle.Columns.Item("ImpFinal").Visible = False
            dgvDetalle.Columns.Item("PrecioConIva").Visible = False
            dgvDetalle.Columns.Item("TipoStock").Visible = False

            _Dt1 = _Ver1.verSistema(mdifrmppal.cdEmp)
            Dim _Row As DataRow = _Dt1.Rows(_Dt1.Rows.Count - 1)
            lblComprobante.Text = CStr(_Row("NroFacturaNCND_A"))
            lblPtoVta.Text = CStr(_Row("PtoVta"))
            lblTiket.Text = CStr(_Row("TiketAcceso"))

            Dim estiloEnc As New DataGridViewCellStyle()
            Dim textEnc As String = ""
            Dim X As Integer

            estiloEnc.Font = New Font(dgvDetalle.Font, FontStyle.Bold)
            dgvDetalle.ColumnHeadersDefaultCellStyle = estiloEnc
            dgvDetalle.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            For X = 1 To 13
                If X = 1 Or X = 2 Or X = 3 Or X = 10 Or X = 13 Then
                    dgvDetalle.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                ElseIf X = 4 Or X = 5 Then
                    dgvDetalle.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                ElseIf X = 8 Then
                    dgvDetalle.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle.Columns(X).DefaultCellStyle.Format = "0.00 %"
                ElseIf X = 6 Then
                    dgvDetalle.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle.Columns(X).DefaultCellStyle.Format = "#,##0.00"
                Else
                    dgvDetalle.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle.Columns(X).DefaultCellStyle.Format = "$ #,##0.00"
                End If
                Select Case X
                    Case 0
                        textEnc = "ELIM"
                        dgvDetalle.Columns(0).Width = 40
                    Case 1
                        textEnc = "ITEM"
                        dgvDetalle.Columns(1).Width = 60
                    Case 2
                        textEnc = "ID ART"
                        dgvDetalle.Columns(2).Width = 50
                    Case 3
                        textEnc = "COD BARRA"
                        dgvDetalle.Columns(3).Width = 130
                    Case 4
                        textEnc = "DETALLE"
                        dgvDetalle.Columns(4).Width = 250
                    Case 5
                        textEnc = "UNID"
                        dgvDetalle.Columns(5).Width = 50
                    Case 6
                        textEnc = "CANT."
                        dgvDetalle.Columns(6).Width = 70
                    Case 7
                        textEnc = "PRECIO"
                        dgvDetalle.Columns(7).Width = 70
                    Case 8
                        textEnc = "% IVA"
                        dgvDetalle.Columns(8).Width = 70
                    Case 9
                        textEnc = "IMP S/IVA"
                        dgvDetalle.Columns(9).Width = 100
                    Case 10
                        textEnc = "ID STOCK"
                        dgvDetalle.Columns(10).Width = 50
                    Case 12
                        textEnc = "IMP C/IVA"
                        dgvDetalle.Columns(11).Width = 100
                    Case 13
                        textEnc = "PRECIO"
                        dgvDetalle.Columns(12).Width = 70
                End Select
                dgvDetalle.Columns(X).HeaderText = textEnc
            Next

            _Dt2 = _Ver.verFormaPagoBf(lblPtoVta.Text, lblComprobante.Text)
            dgvPago.DataSource = _Dt2
            dgvPago.Columns.Item("IdFormaPago").Visible = False
            dgvPago.Columns.Item("NroFactura").Visible = False
            dgvPago.Columns.Item("Observaciones").Visible = False

            estiloEnc.Font = New Font(dgvPago.Font, FontStyle.Bold)
            dgvPago.ColumnHeadersDefaultCellStyle = estiloEnc
            dgvPago.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            For X = 1 To 5
                If X = 2 Then
                    dgvPago.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                ElseIf X = 5 Then
                    dgvPago.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                ElseIf X = 1 Or X = 3 Then
                    dgvPago.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Else
                    dgvPago.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvPago.Columns(X).DefaultCellStyle.Format = "$ #,##0.00"
                End If
                Select Case X
                    Case 0
                        textEnc = "ID"
                        dgvPago.Columns(0).Width = 40
                    Case 1
                        textEnc = "FAC"
                        dgvPago.Columns(1).Width = 100
                    Case 2
                        textEnc = "CTA"
                        dgvPago.Columns(2).Width = 40
                    Case 3
                        textEnc = "VTO"
                        dgvPago.Columns(3).Width = 80
                    Case 4
                        textEnc = "IMP"
                        dgvPago.Columns(4).Width = 80
                    Case 5
                        textEnc = "OBSERV"
                        dgvPago.Columns(5).Width = 100
                End Select
                dgvPago.Columns(X).HeaderText = textEnc
            Next


            Me.Text = "EMITIR COMPROBANTES DE VENTA - " & mdifrmppal.encForm
            txtCdEmp.Text = mdifrmppal.cdEmp
            lblCodComprobante.Text = "01"
            txtIdCliente.Select()
            txtFecha.Text = Date.Now.Date
            txtVto.Text = Date.Now.Date
        Catch ex As Exception
            MsgBox("Error: Parametros de facturación no pueden cargarse !", vbInformation, "Servicio de Alertas")
            txtFecha.SelectionLength = Len(txtFecha.Text)
            txtFecha.Select()
        End Try
    End Sub

    Private Sub txtCdBarra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCdBarra.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            lblEnter.Text = "Si"
            If txtCdBarra.Text = "" Then
                e.Handled = True
                frmConsStock.lblOrigen.Text = "Factura Venta"
                frmConsStock.txtDescripcion.Select()
                frmConsStock.ShowDialog()
            Else
                If txtIdArt.Text = "" Then
                    e.Handled = True
                    Dim _Ver As New Mostrar
                    Dim _Ds As New DataSet
                    _Ds.Tables.Add(_Ver.consStock(mdifrmppal.cdEmp).Copy)
                    Dim _Dv As New DataView(_Ds.Tables(0))
                    _Dv.RowFilter = "CodBarra = '" & txtCdBarra.Text & "'"

                    If _Dv.Count <> 0 Then
                        dgvStock.DataSource = _Dv
                        dgvStock.Select()
                        txtIdStock.Text = dgvStock.SelectedCells.Item(11).Value
                        txtIdArt.Text = dgvStock.SelectedCells.Item(12).Value
                        txtArticulo.Text = dgvStock.SelectedCells.Item(4).Value
                        txtUnidad.Text = dgvStock.SelectedCells.Item(5).Value
                        txtCantidad.Text = Format(dgvStock.SelectedCells.Item(10).Value, "#,##0.00")

                        If lblLetra.Text = "A" Then
                            txtPrecio.Text = Format(dgvStock.SelectedCells.Item(6).Value, "$ #,##0.00")
                            txtAlIvaReal.Text = dgvStock.SelectedCells.Item(7).Value
                            txtPrecioFin.Text = dgvStock.SelectedCells.Item(8).Value
                            txtAlicIva.Text = Format(CDbl(dgvStock.SelectedCells.Item(7).Value), "0.00 %")
                            txtImporte.Text = Format(CDbl(dgvStock.SelectedCells.Item(10).Value) * CDbl(dgvStock.SelectedCells.Item(6).Value), "$ #,##0.00")
                            txtImpFinal.Text = Format(CDbl(dgvStock.SelectedCells.Item(10).Value) * CDbl(txtPrecioFin.Text), "$ #,##0.00")
                        ElseIf lblLetra.Text = "B" Then
                            txtPrecio.Text = Format(dgvStock.SelectedCells.Item(8).Value, "$ #,##0.00")
                            txtAlIvaReal.Text = dgvStock.SelectedCells.Item(7).Value
                            txtPrecioFin.Text = dgvStock.SelectedCells.Item(8).Value
                            txtAlicIva.Text = Format(0, "0.00 %")
                            txtImporte.Text = Format(CDbl(dgvStock.SelectedCells.Item(10).Value) * CDbl(dgvStock.SelectedCells.Item(6).Value), "$ #,##0.00")
                            txtImpFinal.Text = Format(CDbl(dgvStock.SelectedCells.Item(10).Value) * CDbl(txtPrecioFin.Text), "$ #,##0.00")
                        Else
                            txtPrecio.Text = Format(dgvStock.SelectedCells.Item(8).Value, "$ #,##0.00")
                            txtAlIvaReal.Text = 0
                            txtPrecioFin.Text = dgvStock.SelectedCells.Item(8).Value
                            txtAlicIva.Text = Format(0, "0.00 %")
                            txtImporte.Text = Format(CDbl(dgvStock.SelectedCells.Item(10).Value) * CDbl(dgvStock.SelectedCells.Item(8).Value), "$ #,##0.00")
                            txtImpFinal.Text = Format(CDbl(dgvStock.SelectedCells.Item(10).Value) * CDbl(txtPrecioFin.Text), "$ #,##0.00")
                        End If
                        txtCantidad.SelectionLength = Len(txtCantidad.Text)
                        txtCantidad.Select()
                        lblEnter.Enabled = False
                    Else
                        MsgBox("Error: Código de Barra no se corresponde con ningún artículo en Stock !", vbInformation, "Servicio de Alertas")
                        txtCdBarra.Text = ""
                        txtCdBarra.Select()
                    End If
                Else
                    txtCantidad.SelectionLength = Len(txtCantidad.Text)
                    txtCantidad.Select()
                End If
            End If
        End If
    End Sub

    Private Sub lblLetra_Click(sender As Object, e As EventArgs) Handles lblLetra.Click
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        _Dt = _Ver.verSistema(mdifrmppal.cdEmp)
        Dim _Row As DataRow = _Dt.Rows(_Dt.Rows.Count - 1)

        If lblLetra.Text = "A" Then
            lblLetra.Text = "B"
            If rbtFactura.Checked = True Then
                lblCodComprobante.Text = "06"
            ElseIf rbnND.Checked = True Then
                lblCodComprobante.Text = "07"
            ElseIf rbtnNC.Checked = True Then
                lblCodComprobante.Text = "08"
            Else
                lblCodComprobante.Text = "00"
            End If
            lblComprobante.Text = CStr(_Row("NroFacturaNCND_B"))
            txtImpFinal.Visible = True
            ActualizaTotalesB()
        ElseIf lblLetra.Text = "B" Then
            lblLetra.Text = "X"
            lblCodComprobante.Text = "00"
            lblComprobante.Text = CStr(_Row("NroFacturaNCND_X"))
            txtImpFinal.Visible = True
            ActualizaTotalesCX()
        ElseIf lblLetra.Text = "X" Then
            lblLetra.Text = "A"
            If rbtFactura.Checked = True Then
                lblCodComprobante.Text = "01"
            ElseIf rbnND.Checked = True Then
                lblCodComprobante.Text = "02"
            ElseIf rbtnNC.Checked = True Then
                lblCodComprobante.Text = "03"
            Else
                lblCodComprobante.Text = "00"
            End If
            lblComprobante.Text = CStr(_Row("NroFacturaNCND_A"))
            txtImpFinal.Visible = False
            ActualizaTotalesA()
        End If
    End Sub

    Private Sub rbtCdo_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCdo.CheckedChanged
        If rbtCdo.Checked = True Then
            gbxCondPago.Enabled = False
        Else
            gbxCondPago.Enabled = True
        End If
    End Sub

    Private Sub ActualizaTotalesCX()
        'Actualizo el DataGridView y sumo subtotales
        Dim _Ver As New Mostrar
        Dim _Dt As New DataTable
        Dim Total105, Total21 As Double

        _Dt = _Ver.verDetalleFac()
        dgvDetalle.DataSource = _Dt
        For Each row As DataGridViewRow In dgvDetalle.Rows
            If Val(row.Cells(8).Value) = 0.105 Then
                Total105 += Val(row.Cells(11).Value)
            Else
                Total21 += Val(row.Cells(11).Value)
            End If
        Next
        txtSubTotalIva1050.Text = Format(Total105, "$ #,##0.00")
        txtSubTotalIva2100.Text = Format(Total21, "$ #,##0.00")
        txtSubTotal.Text = Format(Total105 + Total21, "$ #,##0.00")
        txtIva105.Text = Format(Total105 * 0, "$ #,##0.00")
        txtIva21.Text = Format(Total21 * 0, "$ #,##0.00")
        txtIva105Contable.Text = Format(0, "$ #,##0.00")
        txtIva21Contable.Text = Format(0, "$ #,##0.00")
        txtTotal.Text = Format(CDbl(txtSubTotal.Text) - CDbl(txtDescuento.Text) + CDbl(txtIva105.Text) + CDbl(txtIva21.Text), "$ #,##0.00")
    End Sub

    Private Sub ActualizaTotalesA()
        'Actualizo el DataGridView y sumo subtotales
        Dim _Ver As New Mostrar
        Dim _Dt As New DataTable
        Dim Total105, Total21 As Double

        _Dt = _Ver.verDetalleFac()
        dgvDetalle.DataSource = _Dt
        For Each row As DataGridViewRow In dgvDetalle.Rows
            If Val(row.Cells(8).Value) = 0.105 Then
                Total105 += Val(row.Cells(9).Value)
            Else
                Total21 += Val(row.Cells(9).Value)
            End If
        Next
        txtSubTotalIva1050.Text = Format(Total105, "$ #,##0.00")
        txtSubTotalIva2100.Text = Format(Total21, "$ #,##0.00")
        txtSubTotal.Text = Format(Total105 + Total21, "$ #,##0.00")
        txtIva105.Text = Format(Total105 * 0.105, "$ #,##0.00")
        txtIva21.Text = Format(Total21 * 0.21, "$ #,##0.00")
        txtIva105Contable.Text = Format(Total105 * 0.105, "$ #,##0.00")
        txtIva21Contable.Text = Format(Total21 * 0.21, "$ #,##0.00")
        txtTotal.Text = Format(CDbl(txtSubTotal.Text) - CDbl(txtDescuento.Text) + CDbl(txtIva105Contable.Text) + CDbl(txtIva21Contable.Text), "$ #,##0.00")
    End Sub

    Private Sub ActualizaTotalesB()
        'Actualizo el DataGridView y sumo subtotales
        Dim _Ver As New Mostrar
        Dim _Dt As New DataTable
        Dim Total105, Total21 As Double

        _Dt = _Ver.verDetalleFac()
        dgvDetalle.DataSource = _Dt
        For Each row As DataGridViewRow In dgvDetalle.Rows
            If Val(row.Cells(8).Value) = 0.105 Then
                Total105 += Val(row.Cells(9).Value)
            Else
                Total21 += Val(row.Cells(9).Value)
            End If
        Next
        txtSubTotalIva1050.Text = Format(Total105, "$ #,##0.00")
        txtSubTotalIva2100.Text = Format(Total21, "$ #,##0.00")
        txtSubTotal.Text = Format(Total105 + Total21, "$ #,##0.00")
        txtIva105.Text = Format(0, "$ #,##0.00")
        txtIva21.Text = Format(0, "$ #,##0.00")
        txtIva105Contable.Text = Format(Total105 * 0.105, "$ #,##0.00")
        txtIva21Contable.Text = Format(Total21 * 0.21, "$ #,##0.00")
        txtSubTotal.Text = Format(CDbl(txtSubTotal.Text) + CDbl(txtIva105Contable.Text) + CDbl(txtIva21Contable.Text), "$ #,##0.00")
        txtTotal.Text = Format(CDbl(txtSubTotal.Text) - CDbl(txtDescuento.Text), "$ #,##0.00")
    End Sub

    Private Sub btnCargaCuota_Click(sender As Object, e As EventArgs) Handles btnCargaCuota.Click
        Try
            If dgvPago.RowCount <= CInt(txtCuotas.Text) - 1 Then
                Dim _Guardar As New GrabaDatos
                Dim _Ver As New Mostrar
                Dim _Dt As New DataTable

                'FORMA DE PAGO
                _Guardar.Grabar("Forma Pago", "NoImagen", "insFormaPagoBuffer", lblPtoVta.Text, lblComprobante.Text, CInt(txtCuotas.Text), _
                                Format(CDate(txtVto.Text), "yyyy/MM/dd"), CDbl(txtImpCta.Text), txtObserv.Text)

                _Dt = _Ver.verFormaPagoBf(lblPtoVta.Text, lblComprobante.Text)
                dgvPago.DataSource = _Dt

                txtVto.SelectionLength = Len(txtVto.Text)
                txtVto.Select()
            Else
                MsgBox("Error: Ya se cargaron todas las cuotas !", vbInformation, "Servicio de Alertas")
                btnCargaCuota.Select()
            End If
        Catch ex As Exception
            MsgBox("Error: No se pueden cargar las cuotas !", vbInformation, "Servicio de Alertas")
            btnCargaCuota.Select()
        End Try

    End Sub

    Private Sub txtCuotas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuotas.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtVto.SelectionLength = Len(txtVto.Text)
            txtVto.Select()
        End If
    End Sub

    Private Sub txtCuotas_Validated(sender As Object, e As EventArgs) Handles txtCuotas.Validated
        If IsNumeric(txtCuotas.Text) Then
            txtCuotas.Text = Format(CDbl(txtCuotas.Text), "#,##0")
        Else
            MsgBox("Error: Sólo se permiten valores numéricos !", vbInformation, "Servicio de Alertas")
            txtCuotas.SelectionLength = Len(txtCuotas.Text)
            txtCuotas.Select()
        End If
    End Sub

    Private Sub txtVto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVto.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtImpCta.SelectionLength = Len(txtImpCta.Text)
            txtImpCta.Select()
        End If
    End Sub

    Private Sub txtVto_Validated(sender As Object, e As EventArgs) Handles txtVto.Validated
        If Not txtVto.Text = "" Then
            If Not IsDate(txtVto.Text) Then
                MsgBox("Error: Fecha incorrecta !", vbInformation, "Servicio de Alertas")
                txtVto.Text = ""
                txtVto.Select()
            Else
                txtVto.Text = Format(CDate(txtVto.Text), "dd/MM/yyyy")
            End If
        End If
    End Sub

    Private Sub txtImpCta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImpCta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnCargaCuota.Select()
        End If
    End Sub

    Private Sub txtImpCta_Validated(sender As Object, e As EventArgs) Handles txtImpCta.Validated
        If IsNumeric(txtImpCta.Text) Then
            txtImpCta.Text = Format(CDbl(txtImpCta.Text), "$ #,##0.00")
        Else
            MsgBox("Error: Sólo se permiten valores numéricos !", vbInformation, "Servicio de Alertas")
            txtImpCta.SelectionLength = Len(txtImpCta.Text)
            txtImpCta.Select()
        End If
    End Sub

    Private Sub tmrActNroComp_Tick(sender As Object, e As EventArgs) Handles tmrActNroComp.Tick
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        _Dt = _Ver.verSistema(mdifrmppal.cdEmp)
        Dim _Row As DataRow = _Dt.Rows(_Dt.Rows.Count - 1)
        If lblLetra.Text = "X" Then
            lblComprobante.Text = CStr(_Row("NroFacturaNCND_X"))
        Else
            lblComprobante.Text = CStr(_Row("NroFacturaNCND_A"))
        End If
    End Sub

    Private Sub rbtFactura_CheckedChanged(sender As Object, e As EventArgs) Handles rbtFactura.CheckedChanged
        If rbtFactura.Checked = True Then
            If lblLetra.Text = "A" Then
                lblCodComprobante.Text = "01"
            ElseIf lblLetra.Text = "B" Then
                lblCodComprobante.Text = "06"
            ElseIf lblLetra.Text = "C" Then
                lblCodComprobante.Text = "11"
            Else
                lblCodComprobante.Text = "00"
            End If
        End If
    End Sub

    Private Sub rbtnNC_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnNC.CheckedChanged
        If rbtnNC.Checked = True Then
            If lblLetra.Text = "A" Then
                lblCodComprobante.Text = "03"
            ElseIf lblLetra.Text = "B" Then
                lblCodComprobante.Text = "08"
            ElseIf lblLetra.Text = "C" Then
                lblCodComprobante.Text = "13"
            Else
                lblCodComprobante.Text = "00"
            End If
        End If
    End Sub

    Private Sub rbnND_CheckedChanged(sender As Object, e As EventArgs) Handles rbnND.CheckedChanged
        If rbnND.Checked = True Then
            If lblLetra.Text = "A" Then
                lblCodComprobante.Text = "02"
            ElseIf lblLetra.Text = "B" Then
                lblCodComprobante.Text = "07"
            ElseIf lblLetra.Text = "C" Then
                lblCodComprobante.Text = "12"
            Else
                lblCodComprobante.Text = "00"
            End If
        End If
    End Sub

    Private Sub rbtnOtras_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnOtras.CheckedChanged
        If rbtnOtras.Checked = True Then
            lblCodComprobante.Text = "00"
        End If
    End Sub

    Private Sub ImprimirFacturaVenta()
        frmInfFacturaVenta.ShowDialog()
    End Sub

End Class