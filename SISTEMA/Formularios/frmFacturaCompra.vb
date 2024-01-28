Imports MySql.Data.MySqlClient

Public Class frmFacturaCompra

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

    Private Sub LimpiarTodo()
        txtIdArt.Text = ""
        txtArticulo.Text = ""
        txtUnidad.Text = ""
        txtCdBarra.Text = ""
        txtIdProveedor.Text = ""
        txtProveedor.Text = ""
        txtCuit.Text = ""
        txtDir.Text = ""
        txtLoc.Text = ""
        txtProv.Text = ""
        txtIIBB.Text = ""
        txtCatIva.Text = ""
        txtFecha.Text = Date.Now.Date
        txtComprobante.Text = ""
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
        txtTotal.Text = Format(0, "$ #,##0.00")
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
        txtIdProveedor.Select()
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

    Private Sub txtIdProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdProveedor.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If txtIdProveedor.Text = "" Then
                e.Handled = True
                frmProveedores.lblOrigen.Text = "Factura Compra"
                frmProveedores.txtBuscar.Text = ""
                frmProveedores.txtBuscar.Select()
                frmProveedores.ShowDialog()
            Else
                e.Handled = True
                If IsNumeric(txtIdProveedor.Text) Then
                    Dim _Ver As New Mostrar
                    Dim _Ds As New DataSet
                    _Ds.Tables.Add(_Ver.verProveedores(mdiFrmPpal.cdEmp).Copy)
                    Dim _Dv As New DataView(_Ds.Tables(0))
                    _Dv.RowFilter = "IdProveedores = " & CInt(txtIdProveedor.Text)
                    If _Dv.Count <> 0 Then
                        dgvProveedor.DataSource = _Dv
                        dgvProveedor.Select()
                        txtProveedor.Text = dgvProveedor.SelectedCells.Item(4).Value
                        txtCuit.Text = dgvProveedor.SelectedCells.Item(11).Value
                        txtDir.Text = dgvProveedor.SelectedCells.Item(5).Value
                        txtLoc.Text = dgvProveedor.SelectedCells.Item(6).Value
                        txtProv.Text = dgvProveedor.SelectedCells.Item(8).Value
                        txtIIBB.Text = dgvProveedor.SelectedCells.Item(12).Value
                        txtCatIva.Text = dgvProveedor.SelectedCells.Item(13).Value
                        txtFecha.SelectionLength = Len(txtFecha.Text)
                        txtFecha.Select()
                    Else
                        MsgBox("Error: Nro de Cuenta no se corresponde con ningún proveedor !", vbInformation, "Servicio de Alertas")
                        txtProveedor.Text = ""
                        txtIdProveedor.Text = ""
                        txtIdProveedor.Select()
                    End If
                End If
                If txtProveedor.Text <> "" Then
                    gbxFactura.Enabled = True
                    gbxLetra.Enabled = True
                    gbxTipoC.Enabled = True
                    gbxTipoVta.Enabled = True
                    gbxCarga.Enabled = True
                    gbxControles.Enabled = True
                    gbxDetalle.Enabled = True
                    gbxObserv.Enabled = True
                    gbxResumen.Enabled = True
                    txtFecha.SelectionLength = Len(txtFecha.Text)
                    txtFecha.Select()
                Else
                    gbxFactura.Enabled = False
                    gbxLetra.Enabled = False
                    gbxTipoC.Enabled = False
                    gbxTipoVta.Enabled = False
                    gbxCarga.Enabled = False
                    gbxControles.Enabled = False
                    gbxDetalle.Enabled = False
                    gbxObserv.Enabled = False
                    gbxResumen.Enabled = False
                End If
            End If
        End If
    End Sub

    Private Sub txtFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFecha.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtComprobante.SelectionLength = Len(txtComprobante.Text)
            txtComprobante.Select()
        End If
    End Sub

    Private Sub txtFecha_Validated(sender As Object, e As EventArgs) Handles txtFecha.Validated
        If Not txtFecha.Text = "" Then
            If Not IsDate(txtFecha.Text) Then
                MsgBox("Error: Fecha incorrecta !", vbInformation, "Servicio de Alertas")
                txtFecha.SelectionLength = Len(txtFecha.Text)
                txtFecha.Select()
            Else
                txtFecha.Text = Format(CDate(txtFecha.Text), "dd/MM/yyyy")
            End If
        End If
    End Sub

    Private Sub txtComprobante_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtComprobante.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtIdArt.SelectionLength = Len(txtIdArt.Text)
            txtIdArt.Select()
        End If
    End Sub

    Private Sub txtCdBarra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCdBarra.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCantidad.Text = Format(1, "#,##0.00")
            txtCantidad.SelectionLength = Len(txtCantidad.Text)
            txtCantidad.Select()
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtPrecio.SelectionLength = Len(txtPrecio.Text)
            txtPrecio.Select()
        End If
    End Sub

    Private Sub txtCantidad_Validated1(sender As Object, e As EventArgs) Handles txtCantidad.Validated
        If IsNumeric(txtCantidad.Text) Then
            txtCantidad.Text = Format(CDbl(txtCantidad.Text), "#,##0.00")
            txtPrecioFin.Text = CDbl(txtPrecio.Text) + (CDbl(txtPrecio.Text) * CDbl(txtAlIvaReal.Text))
            txtImporte.Text = Format(CDbl(txtCantidad.Text) * CDbl(txtPrecio.Text), "$ #,##0.00")
            txtImpFinal.Text = Format(CDbl(txtCantidad.Text) * CDbl(txtPrecioFin.Text), "$ #,##0.00")
        Else
            MsgBox("Error: Sólo se permiten valores numéricos !", vbInformation, "Servicio de Alertas")
            txtFecha.SelectionLength = Len(txtFecha.Text)
            txtFecha.Select()
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
            txtPrecio.Text = Format(CDbl(txtPrecio.Text), "$ #,##0.00")
            txtPrecioFin.Text = CDbl(txtPrecio.Text) + (CDbl(txtPrecio.Text) * CDbl(txtAlIvaReal.Text))
            txtImporte.Text = Format(CDbl(txtCantidad.Text) * CDbl(txtPrecio.Text), "$ #,##0.00")
            txtImpFinal.Text = Format(CDbl(txtCantidad.Text) * CDbl(txtPrecioFin.Text), "$ #,##0.00")
        Else
            MsgBox("Error: Sólo se permiten valores numéricos !", vbInformation, "Servicio de Alertas")
            txtPrecio.SelectionLength = Len(txtPrecio.Text)
            txtPrecio.Select()
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
            txtAlIvaReal.Text = CDbl(_alIva) / 100
            txtAlicIva.Text = Format(CDbl(_alIva) / 100, "0.00 %")
            txtPrecio.Text = Format(CDbl(txtPrecio.Text), "$ #,##0.00")
            txtPrecioFin.Text = CDbl(txtPrecio.Text) + (CDbl(txtPrecio.Text) * CDbl(txtAlIvaReal.Text))
            txtImporte.Text = Format(CDbl(txtCantidad.Text) * CDbl(txtPrecio.Text), "$ #,##0.00")
            txtImpFinal.Text = Format(CDbl(txtCantidad.Text) * CDbl(txtPrecioFin.Text), "$ #,##0.00")
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

    Private Sub txtUnidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnidad.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCantidad.Text = Format(1, "#,##0.00")
            txtCantidad.SelectionLength = Len(txtCantidad.Text)
            txtCantidad.Select()
        End If
    End Sub

    Private Sub txtArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtArticulo.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtUnidad.SelectionLength = Len(txtUnidad.Text)
            txtUnidad.Select()
        End If
    End Sub

    Private Sub txtIdArt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdArt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If txtIdArt.Text = "" Then
                e.Handled = True
                frmArticulos.lblOrigen.Text = "Factura Compra"
                frmArticulos.txtBuscar.Select()
                frmArticulos.Show()
            Else
                e.Handled = True
                If IsNumeric(txtIdArt.Text) Then
                    Dim _Ver As New Mostrar
                    Dim _Ds As New DataSet
                    _Ds.Tables.Add(_Ver.verArticulos(mdiFrmPpal.cdEmp).Copy)
                    Dim _Dv As New DataView(_Ds.Tables(0))
                    _Dv.RowFilter = "IdArticulos = " & CInt(txtIdArt.Text)
                    If _Dv.Count <> 0 Then
                        dgvArticulos.DataSource = _Dv
                        dgvArticulos.Select()
                        txtArticulo.Text = dgvArticulos.SelectedCells.Item(4).Value
                        txtUnidad.Text = dgvArticulos.SelectedCells.Item(5).Value
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

    Private Sub frmFacturaCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim _Ver As New Mostrar
            Dim _Dt As New DataTable
            Dim _Elim As New GrabaDatos

            _Elim.Grabar("Factura Venta", "NoImagen", "vaciaDetalleFac")
            _Dt = _Ver.verDetalleFac()
            dgvDetalle.DataSource = _Dt
            dgvDetalle.Columns.Item("IdArt").Visible = False
            dgvDetalle.Columns.Item("IdDF").Visible = False
            dgvDetalle.Columns.Item("IdStock").Visible = False
            dgvDetalle.Columns.Item("ImpFinal").Visible = False
            dgvDetalle.Columns.Item("PrecioConIva").Visible = False
            dgvDetalle.Columns.Item("TipoStock").Visible = False

            Dim estiloEnc As New DataGridViewCellStyle()
            Dim textEnc As String = ""
            Dim X As Integer

            estiloEnc.Font = New Font(dgvDetalle.Font, FontStyle.Bold)
            dgvDetalle.ColumnHeadersDefaultCellStyle = estiloEnc
            dgvDetalle.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            For X = 1 To 10
                If X = 1 Or X = 2 Or X = 3 Then
                    dgvDetalle.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                ElseIf X = 3 Then
                    dgvDetalle.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                ElseIf X = 4 Or X = 5 Then
                    dgvDetalle.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                ElseIf X = 8 Then
                    dgvDetalle.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvDetalle.Columns(X).DefaultCellStyle.Format = "0.00 %"
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
                        textEnc = "IMP C/IVA"
                        dgvDetalle.Columns(9).Width = 100
                End Select
                dgvDetalle.Columns(X).HeaderText = textEnc
            Next


            Me.Text = "REGISTRAR COMPROBANTES DE COMPRA - " & mdiFrmPpal.encForm
            txtCdEmp.Text = mdiFrmPpal.cdEmp

            txtIdProveedor.Select()
            txtFecha.Text = Date.Now.Date
        Catch ex As Exception
            MsgBox("Error: Parametros de facturación no pueden cargarse !", vbInformation, "Servicio de Alertas")
            txtFecha.SelectionLength = Len(txtFecha.Text)
            txtFecha.Select()
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim _Guardar As New GrabaDatos

        Try
            If txtArticulo.Text = "" Then
                MsgBox("Error: Seleccione un artículo !", vbInformation, "Servico de Alertas")
                txtIdArt.Select()
            Else
                If txtCdBarra.Text = "" Then
                    MsgBox("Error: Código de Barra es obligatorio !", vbInformation, "Servico de Alertas")
                    txtCdBarra.Select()
                Else
                    If CDbl(txtCantidad.Text) = 0 Or CDbl(txtPrecio.Text) = 0 Then
                        MsgBox("Error: Cantidad y/o Precio NO pueden ser cero !", vbInformation, "Servico de Alertas")
                        txtCantidad.Select()
                    Else
                        If lblManual.Text = "Manual" Then
                            txtIdArt.Text = -9999
                            txtCdBarra.Text = "CodigoBarraNoDisponible"
                        End If
                        If lblFuncion.Text = "Nuevo" Then
                            _Guardar.Grabar("Factura Compra", "NoImagen", "insLineaFacCompra", CInt(txtIdArt.Text), txtCdBarra.Text, txtArticulo.Text, _
                                            txtUnidad.Text, CDbl(txtCantidad.Text), CDbl(txtPrecio.Text), CDbl(txtAlIvaReal.Text), CDbl(txtImporte.Text), _
                                            -99, CDbl(txtImpFinal.Text))
                        Else
                            _Guardar.Grabar("Factura Compra", "NoImagen", "modLineaFacCompra", CInt(lblIdDet.Text), CInt(txtIdArt.Text), txtCdBarra.Text, txtArticulo.Text, _
                                            txtUnidad.Text, CDbl(txtCantidad.Text), CDbl(txtPrecio.Text), CDbl(txtAlIvaReal.Text), CDbl(txtImporte.Text), _
                                            -99, CDbl(txtImpFinal.Text))
                        End If

                        If lblLetra.Text = "A" Then
                            ActualizaTotalesA()
                        Else
                            ActualizaTotalesBCX()
                        End If

                        Limpiar()
                        lblFuncion.Text = "Nuevo"
                        btnModificar.Enabled = True
                        btnEliminar.Enabled = True
                        txtIdArt.Select()
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

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Limpiar()
        txtIdArt.Select()
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
                txtTotal.Text = Format(CDbl(txtSubTotal.Text) - CDbl(txtDescuento.Text) + CDbl(txtIva105.Text) + CDbl(txtIva21.Text), "$ #,##0.00")

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
                txtPrecio.Text = Format(CDbl(dgvDetalle.SelectedCells.Item(7).Value), "$ #,##0.00")
                txtAlicIva.Text = Format(CDbl(dgvDetalle.SelectedCells.Item(8).Value), "0.00 %")
                txtAlIvaReal.Text = dgvDetalle.SelectedCells.Item(8).Value
                txtImporte.Text = Format(CDbl(dgvDetalle.SelectedCells.Item(9).Value), "#,##0.00")
                txtIdArt.SelectionLength = Len(txtIdArt.Text)
                txtIdArt.Select()
            End If
        Catch ex As Exception
            MsgBox("Error: No se pueden cargar los datos para modificar !" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            txtIdArt.Select()
        End Try
    End Sub

    Private Sub btnManual_Click(sender As Object, e As EventArgs) Handles btnManual.Click
        If lblManual.Text = "Stock" Then
            lblManual.Text = "Manual"
            txtIdArt.Text = -9999
            txtArticulo.Enabled = True
            txtUnidad.Enabled = True
            txtCdBarra.Text = "CodigoBarraNoDisponible"
            txtArticulo.BackColor = Color.LightSkyBlue
            txtUnidad.BackColor = Color.LightSkyBlue
            txtArticulo.Select()
        Else
            lblManual.Text = "Stock"
            txtIdArt.Text = ""
            txtCdBarra.Text = ""
            txtArticulo.Enabled = False
            txtUnidad.Enabled = False
            txtArticulo.BackColor = Color.MediumTurquoise
            txtUnidad.BackColor = Color.MediumTurquoise
            txtIdArt.Select()
        End If
    End Sub

    Private Sub btnEmitirFactura_Click_1(sender As Object, e As EventArgs) Handles btnEmitirFactura.Click
        Dim resP As DialogResult
        Dim _Guardar As New GrabaDatos

        If txtIdProveedor.Text = "" Or txtProveedor.Text = "" Then
            MsgBox("Error: Falta cargar proveedor !", vbInformation, "Servico de Alertas")
            txtIdProveedor.Select()
        Else
            If txtFecha.Text = "" Then
                MsgBox("Error: Fecha comprobante es obligatorio !", vbInformation, "Servico de Alertas")
                txtCdBarra.Select()
            Else
                If txtComprobante.Text = "" Then
                    MsgBox("Error: Falta Número de Comprobante !", vbInformation, "Servico de Alertas")
                    txtCdBarra.Select()
                Else
                    If dgvDetalle.RowCount = 0 Then
                        MsgBox("Error: Factura sin detalle cargado !", vbInformation, "Servico de Alertas")
                        txtCdBarra.Select()
                    Else
                        resP = MessageBox.Show("Registra Comprobante de Compra ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                        If resP = Windows.Forms.DialogResult.OK Then
                            Try
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

                                Dim fPago As String
                                If rbtCdo.Checked = True Then
                                    fPago = "Contado"
                                Else
                                    fPago = "Cuenta Corriente"
                                End If

                                If lblManual.Text = "Stock" Then
                                    'STOCK
                                    For Each row As DataGridViewRow In dgvDetalle.Rows
                                        _Guardar.Grabar("Factura Compra", "NoImagen", "insStock", txtCdEmp.Text, Format(CDate(txtFecha.Text), "yyyy/MM/dd"), _
                                                        row.Cells(3).Value, Val(row.Cells(6).Value), 1, mdiFrmPpal.usSis, Val(row.Cells(2).Value))
                                    Next
                                End If

                                'CUENTA CORRIENTE COMPRA
                                If tipoComp = "Nota Credito" Then
                                    _Guardar.Grabar("Factura Compra", "NoImagen", "insCtaCteCompra", txtCdEmp.Text, "-cb-", Format(CDate(txtFecha.Text), "yyyy/MM/dd"), _
                                                   fPago, lblLetra.Text, tipoComp, txtComprobante.Text, 0, CDbl(txtTotal.Text), 0, mdiFrmPpal.usSis, CInt(txtIdProveedor.Text))
                                Else
                                    _Guardar.Grabar("Factura Compra", "NoImagen", "insCtaCteCompra", txtCdEmp.Text, "-cb-", Format(CDate(txtFecha.Text), "yyyy/MM/dd"), _
                                                   fPago, lblLetra.Text, tipoComp, txtComprobante.Text, CDbl(txtTotal.Text), 0, 0, mdiFrmPpal.usSis, CInt(txtIdProveedor.Text))
                                End If

                                'Obtener ultimo ID cargado de Cuenta Corriente de Compra
                                Dim ulTid As Integer
                                Dim _VerMax As New Mostrar
                                Dim _DtMax As New DataTable
                                _DtMax = _VerMax.verMaxIdCompraCtaCte()
                                Dim _Row As DataRow = _DtMax.Rows(_DtMax.Rows.Count - 1)
                                ulTid = _Row("UltimoId")

                                'FACTURA COMPRA
                                Dim _Bi As Double = CDbl(txtSubTotal.Text) - CDbl(txtDescuento.Text)
                                _Guardar.Grabar("Factura Compra", "NoImagen", "insFacCompra", txtCdEmp.Text, "-cb-", txtComprobante.Text, _
                                                 tipoComp, Format(CDate(txtFecha.Text), "yyyy/MM/dd"), CDbl(txtSubTotal.Text), CDbl(txtDescuento.Text), _
                                                _Bi, 0.105, CDbl(txtIva105.Text), 0.21, CDbl(txtIva21.Text), 0, 0, CDbl(txtTotal.Text), txtObserv.Text, mdiFrmPpal.usSis, ulTid)

                                'Obtener ultimo ID cargado de Factura de Compra
                                _DtMax = _VerMax.verMaxIdCompraFacturas()
                                _Row = _DtMax.Rows(_DtMax.Rows.Count - 1)
                                ulTid = _Row("UltimoId")

                                'DETALLE DE FACTURA DE COMPRA
                                For Each row As DataGridViewRow In dgvDetalle.Rows
                                    _Guardar.Grabar("Factura Compra", "NoImagen", "insDetalleFacCompra", Val(row.Cells(2).Value), row.Cells(3).Value, row.Cells(4).Value, _
                                                   row.Cells(5).Value, CDbl(Val(row.Cells(6).Value)), CDbl(Val(row.Cells(7).Value)), CDbl(Val(row.Cells(8).Value)), _
                                                   CDbl(Val(row.Cells(9).Value)), mdiFrmPpal.usSis, ulTid)
                                Next

                                'Limpio datagrid y pantalla
                                Dim _Ver As New Mostrar
                                Dim _Dt As New DataTable
                                Dim _Elim As New GrabaDatos
                                _Elim.Grabar("Factura Compra", "NoImagen", "vaciaDetalleFac")
                                _Dt = _Ver.verDetalleFac()
                                dgvDetalle.DataSource = _Dt

                                LimpiarTodo()
                                lblFuncion.Text = "Nuevo"
                                lblManual.Text = "Stock"
                                btnModificar.Enabled = True
                                btnEliminar.Enabled = True
                                txtIdArt.Select()
                            Catch ex As MySqlException
                                MsgBox("Error: Factura de Compra No fue Registrada correctamente !" & vbCrLf & vbCrLf & ex.ToString, vbCritical, "Servicio de Alertas")
                            End Try
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim _Elim As New GrabaDatos
        If dgvDetalle.RowCount <> 0 Then
            Dim resP As DialogResult
            resP = MessageBox.Show("Salir y vaciar contenido del detalle ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If resP = Windows.Forms.DialogResult.OK Then
                _Elim.Grabar("Factura Compra", "NoImagen", "vaciaDetalleFac")
            End If
        End If
        LimpiarTodo()
        Me.Hide()
    End Sub

    Private Sub dgvDetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalle.CellContentClick
        If e.ColumnIndex = Me.dgvDetalle.Columns.Item("Eliminar").Index Then
            Dim celSel As DataGridViewCheckBoxCell = Me.dgvDetalle.Rows(e.RowIndex).Cells("Eliminar")
            celSel.Value = Not celSel.Value
        End If
    End Sub

    Private Sub lblLetra_Click(sender As Object, e As EventArgs) Handles lblLetra.Click
        If lblLetra.Text = "A" Then
            lblLetra.Text = "B"
            txtImpFinal.Visible = True
            dgvDetalle.Columns.Item("ImpFinal").Visible = True
            dgvDetalle.Columns.Item("Importe").Visible = False
            dgvDetalle.Columns(11).HeaderText = "IMP C/IVA"
            dgvDetalle.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle.Columns(11).DefaultCellStyle.Format = "$ #,##0.00"
            ActualizaTotalesBCX()
        ElseIf lblLetra.Text = "B" Then
            lblLetra.Text = "C"
            txtImpFinal.Visible = True
            dgvDetalle.Columns.Item("ImpFinal").Visible = True
            dgvDetalle.Columns.Item("Importe").Visible = False
            dgvDetalle.Columns(11).HeaderText = "IMP C/IVA"
            dgvDetalle.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle.Columns(11).DefaultCellStyle.Format = "$ #,##0.00"
            ActualizaTotalesBCX()
        ElseIf lblLetra.Text = "C" Then
            lblLetra.Text = "X"
            txtImpFinal.Visible = True
            dgvDetalle.Columns.Item("ImpFinal").Visible = True
            dgvDetalle.Columns.Item("Importe").Visible = False
            dgvDetalle.Columns(11).HeaderText = "IMP C/IVA"
            dgvDetalle.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle.Columns(11).DefaultCellStyle.Format = "$ #,##0.00"
            ActualizaTotalesBCX()
        ElseIf lblLetra.Text = "X" Then
            lblLetra.Text = "A"
            txtImpFinal.Visible = False
            dgvDetalle.Columns.Item("ImpFinal").Visible = False
            dgvDetalle.Columns.Item("Importe").Visible = True
            dgvDetalle.Columns(9).HeaderText = "IMP S/IVA"
            dgvDetalle.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDetalle.Columns(9).DefaultCellStyle.Format = "$ #,##0.00"
            ActualizaTotalesA()
        End If
    End Sub

    Private Sub ActualizaTotalesBCX()
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
        txtTotal.Text = Format(CDbl(txtSubTotal.Text) - CDbl(txtDescuento.Text) + CDbl(txtIva105.Text) + CDbl(txtIva21.Text), "$ #,##0.00")
    End Sub

End Class