Public Class frmCtaCteCompra

    Private Sub btnImpComprobante_GotFocus(sender As Object, e As EventArgs) Handles btnImpComprobante.GotFocus
        btnImpComprobante.BackgroundImage = ByB_SI.My.Resources.ImpresoraAc
    End Sub

    Private Sub btnImpComprobante_LostFocus(sender As Object, e As EventArgs) Handles btnImpComprobante.LostFocus
        btnImpComprobante.BackgroundImage = ByB_SI.My.Resources.ImpresoraIn
    End Sub

    Private Sub btnImpComprobante_MouseEnter(sender As Object, e As EventArgs) Handles btnImpComprobante.MouseEnter
        btnImpComprobante.BackgroundImage = ByB_SI.My.Resources.ImpresoraAc
    End Sub

    Private Sub btnImpComprobante_MouseLeave(sender As Object, e As EventArgs) Handles btnImpComprobante.MouseLeave
        btnImpComprobante.BackgroundImage = ByB_SI.My.Resources.ImpresoraIn
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

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Limpiar()
        Me.Hide()
    End Sub

    Private Sub frmCtaCteVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _Ds As New dsReportes

        Dim _Ver As New Mostrar
        Dim _Dt As New DataTable

        dgvCtaCteMostrar.DataSource = Nothing

        _Dt = _Ver.verFacturaCompra(-99)
        dgvComp.DataSource = _Dt
        FormatoDeDGVComp()

        _Dt = _Ver.verDetalleFacturaCompra(-99)
        dgvDetalle.DataSource = _Dt
        FormatoDGVDetalle()

        _Dt = _Ver.verReciboCompra(-99)
        dgvRecibos.DataSource = _Dt
        FormatoDeDGVRecibos()

        _Dt = _Ver.verDetalleOedenPago(-99)
        dgvDetalleRec.DataSource = _Dt
        FormatoDeDGVDetalleRec()

        Me.Text = "CONSULTA DE CUENTA CORRIENTE CLIENTES - " & mdifrmppal.encForm

        txtCtaProv.Select()

    End Sub

    Private Sub dgvCtaCteMostrar_Click(sender As Object, e As EventArgs) Handles dgvCtaCteMostrar.Click
        Try
            If dgvCtaCteMostrar.RowCount > 0 Then
                Dim _Ver As New Mostrar
                Dim _Dt As New DataTable

                If dgvCtaCteMostrar.SelectedCells.Item(3).Value = "OPP" Then
                    _Dt = _Ver.verReciboCompra(dgvCtaCteMostrar.SelectedCells.Item(9).Value)
                    dgvRecibos.DataSource = _Dt
                    dgvRecibos.Visible = True

                    _Dt = _Ver.verDetalleOedenPago(dgvRecibos.SelectedCells.Item(0).Value)
                    dgvDetalleRec.DataSource = _Dt
                    dgvDetalleRec.Visible = True

                Else
                    _Dt = _Ver.verFacturaCompra(dgvCtaCteMostrar.SelectedCells.Item(9).Value)
                    dgvComp.DataSource = _Dt
                    dgvRecibos.Visible = False

                    _Dt = _Ver.verDetalleFacturaCompra(dgvComp.SelectedCells.Item(0).Value)
                    dgvDetalle.DataSource = _Dt
                    dgvDetalleRec.Visible = False

                End If
            End If
        Catch ex As Exception
            MsgBox("Error: No se puden mostrar los datos correspondientes !", vbInformation, "Servicio de Alertas")
        End Try
    End Sub

    Private Sub Limpiar()
        Dim _Ver As New Mostrar
        Dim _Dt As New DataTable

        txtCtaProv.Text = ""
        lblRazonSocial.Text = ""
        lblCUIT.Text = ""
        lblTipoIva.Text = ""
        lblDireccion.Text = ""
        lblLocalidad.Text = ""
        lblCP.Text = ""
        lblProvincia.Text = ""
        lblTE.Text = ""
        lblIIBB.Text = ""
        lblCredito.Text = ""
        lblEstado.Text = ""

        dgvCtaCteMostrar.DataSource = Nothing

        _Dt = _Ver.verFacturaCompra(-99)
        dgvComp.DataSource = _Dt
        FormatoDeDGVComp()

        _Dt = _Ver.verDetalleFacturaCompra(-99)
        dgvDetalle.DataSource = _Dt
        FormatoDGVDetalle()

        txtCtaProv.Select()
    End Sub

    Private Sub LimpiarDGV()
        Dim _Ver As New Mostrar
        Dim _Dt As New DataTable

        dgvCtaCteMostrar.DataSource = Nothing

        _Dt = _Ver.verFacturaCompra(-99)
        dgvComp.DataSource = _Dt
        FormatoDeDGVComp()

        _Dt = _Ver.verDetalleFacturaCompra(-99)
        dgvDetalle.DataSource = _Dt
        FormatoDGVDetalle()

        _Dt = _Ver.verReciboCompra(-99)
        dgvRecibos.DataSource = _Dt
        FormatoDeDGVRecibos()

        _Dt = _Ver.verDetalleOedenPago(-99)
        dgvDetalleRec.DataSource = _Dt
        FormatoDeDGVDetalleRec()

        txtCtaProv.Select()
    End Sub

    Private Sub FormatoDeDGVComp()
        dgvComp.Columns.Item("IdCompraFacturas").Visible = False
        dgvComp.Columns.Item("CodUN").Visible = False
        dgvComp.Columns.Item("CodBarra").Visible = False
        dgvComp.Columns.Item("AlIva1").Visible = False
        dgvComp.Columns.Item("AlIva2").Visible = False
        dgvComp.Columns.Item("AlIva3").Visible = False
        dgvComp.Columns.Item("Usuario").Visible = False
        dgvComp.Columns.Item("CtaCteCompra_idCtaCteCompra").Visible = False

        Dim estiloEnc As New DataGridViewCellStyle()
        Dim textEnc As String = ""

        dgvComp.Columns("FechaFac").HeaderText = "FECHA"
        dgvComp.Columns("FechaFac").Width = 80
        dgvComp.Columns("FechaFac").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvComp.Columns("FechaFac").DefaultCellStyle.Format = "dd/MM/yyyy"

        dgvComp.Columns("NroComprobante").HeaderText = "NUMERO"
        dgvComp.Columns("NroComprobante").Width = 80
        dgvComp.Columns("NroComprobante").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dgvComp.Columns("SubTotal").HeaderText = "SUBTOTAL"
        dgvComp.Columns("SubTotal").Width = 80
        dgvComp.Columns("SubTotal").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvComp.Columns("SubTotal").DefaultCellStyle.Format = "$ #,##0.00"

        dgvComp.Columns("Descuento").HeaderText = "DESCUENTO"
        dgvComp.Columns("Descuento").Width = 80
        dgvComp.Columns("Descuento").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvComp.Columns("Descuento").DefaultCellStyle.Format = "$ #,##0.00"

        dgvComp.Columns("BaseImponible").HeaderText = "BASE IMP"
        dgvComp.Columns("BaseImponible").Width = 80
        dgvComp.Columns("BaseImponible").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvComp.Columns("BaseImponible").DefaultCellStyle.Format = "$ #,##0.00"

        dgvComp.Columns("ImporteIva1").HeaderText = "IVA 10.5%"
        dgvComp.Columns("ImporteIva1").Width = 80
        dgvComp.Columns("ImporteIva1").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvComp.Columns("ImporteIva1").DefaultCellStyle.Format = "$ #,##0.00"

        dgvComp.Columns("ImporteIva2").HeaderText = "IVA 21.0%"
        dgvComp.Columns("ImporteIva2").Width = 80
        dgvComp.Columns("ImporteIva2").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvComp.Columns("ImporteIva2").DefaultCellStyle.Format = "$ #,##0.00"

        dgvComp.Columns("ImporteIva3").HeaderText = "IVA 0.0%"
        dgvComp.Columns("ImporteIva3").Width = 80
        dgvComp.Columns("ImporteIva3").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvComp.Columns("ImporteIva3").DefaultCellStyle.Format = "$ #,##0.00"

        dgvComp.Columns("Total").HeaderText = "TOTAL"
        dgvComp.Columns("Total").Width = 100
        dgvComp.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvComp.Columns("Total").DefaultCellStyle.Format = "$ #,##0.00"

        dgvComp.Columns("Observaciones").HeaderText = "OBSERVACIONES"
        dgvComp.Columns("Observaciones").Width = 200
        dgvComp.Columns("Observaciones").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        estiloEnc.Font = New Font(dgvComp.Font, FontStyle.Bold)
        dgvComp.ColumnHeadersDefaultCellStyle = estiloEnc
        dgvComp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub FormatoDGVDetalle()
        dgvDetalle.Columns.Item("idFacCompraDetalle").Visible = False
        dgvDetalle.Columns.Item("idArticulo").Visible = False
        dgvDetalle.Columns.Item("CodBarra").Visible = False
        dgvDetalle.Columns.Item("Usuario").Visible = False
        dgvDetalle.Columns.Item("CompraFacturas_idCompraFacturas").Visible = False

        Dim estiloEnc As New DataGridViewCellStyle()
        Dim textEnc As String = ""

        dgvDetalle.Columns("Detalle").HeaderText = "DETALLE"
        dgvDetalle.Columns("Detalle").Width = 250
        dgvDetalle.Columns("Detalle").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgvDetalle.Columns("Unidad").HeaderText = "UNIDAD"
        dgvDetalle.Columns("Unidad").Width = 80
        dgvDetalle.Columns("Unidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvDetalle.Columns("Cantidad").HeaderText = "CANT"
        dgvDetalle.Columns("Cantidad").Width = 60
        dgvDetalle.Columns("Cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDetalle.Columns("Cantidad").DefaultCellStyle.Format = "#,##0.00"

        dgvDetalle.Columns("Precio").HeaderText = "PRECIO"
        dgvDetalle.Columns("Precio").Width = 80
        dgvDetalle.Columns("Precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDetalle.Columns("Precio").DefaultCellStyle.Format = "$ #,##0.00"

        dgvDetalle.Columns("AlIva").HeaderText = "IVA %"
        dgvDetalle.Columns("AlIva").Width = 50
        dgvDetalle.Columns("AlIva").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDetalle.Columns("AlIva").DefaultCellStyle.Format = "##0.00 %"

        dgvDetalle.Columns("Importe").HeaderText = "IMPORTE"
        dgvDetalle.Columns("Importe").Width = 100
        dgvDetalle.Columns("Importe").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDetalle.Columns("Importe").DefaultCellStyle.Format = "$ #,##0.00"

        estiloEnc.Font = New Font(dgvDetalle.Font, FontStyle.Bold)
        dgvDetalle.ColumnHeadersDefaultCellStyle = estiloEnc
        dgvDetalle.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub FormatoDeDGVRecibos()
        dgvRecibos.Columns.Item("idCompraRecibos").Visible = False
        dgvRecibos.Columns.Item("CodUN").Visible = False
        dgvRecibos.Columns.Item("CodBarra").Visible = False
        dgvRecibos.Columns.Item("Usuario").Visible = False
        dgvRecibos.Columns.Item("CtaCteCompra_idCtaCteCompra").Visible = False

        Dim estiloEnc As New DataGridViewCellStyle()
        Dim textEnc As String = ""

        dgvRecibos.Columns("FechaRec").HeaderText = "FECHA"
        dgvRecibos.Columns("FechaRec").Width = 80
        dgvRecibos.Columns("FechaRec").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvRecibos.Columns("FechaRec").DefaultCellStyle.Format = "dd/MM/yyyy"

        dgvRecibos.Columns("NroRecibo").HeaderText = "NUMERO"
        dgvRecibos.Columns("NroRecibo").Width = 80
        dgvRecibos.Columns("NroRecibo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvRecibos.Columns("TipoRecibo").HeaderText = "TIPO"
        dgvRecibos.Columns("TipoRecibo").Width = 120
        dgvRecibos.Columns("TipoRecibo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgvRecibos.Columns("Importe").HeaderText = "IMPORTE"
        dgvRecibos.Columns("Importe").Width = 120
        dgvRecibos.Columns("Importe").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvRecibos.Columns("Importe").DefaultCellStyle.Format = "$ #,##0.00"

        dgvRecibos.Columns("ImporteLetras").HeaderText = "IMPORTE TEXTO"
        dgvRecibos.Columns("ImporteLetras").Width = 400
        dgvRecibos.Columns("ImporteLetras").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgvRecibos.Columns("Observaciones").HeaderText = "OBSERVACIONES"
        dgvRecibos.Columns("Observaciones").Width = 230
        dgvRecibos.Columns("Observaciones").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        estiloEnc.Font = New Font(dgvRecibos.Font, FontStyle.Bold)
        dgvRecibos.ColumnHeadersDefaultCellStyle = estiloEnc
        dgvDetalleRec.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub FormatoDeDGVDetalleRec()
        dgvDetalleRec.Columns.Item("idCompraRecDetalle").Visible = False
        dgvDetalleRec.Columns.Item("CompraRecibos_idCompraRecibos").Visible = False

        Dim estiloEnc As New DataGridViewCellStyle()
        Dim textEnc As String = ""

        dgvDetalleRec.Columns("TipoValor").HeaderText = "TIPO VAL"
        dgvDetalleRec.Columns("TipoValor").Width = 80
        dgvDetalleRec.Columns("TipoValor").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgvDetalleRec.Columns("NroValor").HeaderText = "NUMERO"
        dgvDetalleRec.Columns("NroValor").Width = 80
        dgvDetalleRec.Columns("NroValor").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dgvDetalleRec.Columns("FecCobro").HeaderText = "FECHA COBRO"
        dgvDetalleRec.Columns("FecCobro").Width = 100
        dgvDetalleRec.Columns("FecCobro").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDetalleRec.Columns("FecCobro").DefaultCellStyle.Format = "dd/MM/yyyy"

        dgvDetalleRec.Columns("Librador").HeaderText = "LIBRADOR"
        dgvDetalleRec.Columns("Librador").Width = 200
        dgvDetalleRec.Columns("Librador").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgvDetalleRec.Columns("Banco").HeaderText = "BANCO"
        dgvDetalleRec.Columns("Banco").Width = 200
        dgvDetalleRec.Columns("Banco").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgvDetalleRec.Columns("Sucursal").HeaderText = "SUCURSAL"
        dgvDetalleRec.Columns("Sucursal").Width = 200
        dgvDetalleRec.Columns("Sucursal").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgvDetalleRec.Columns("ImporteValor").HeaderText = "IMPORTE"
        dgvDetalleRec.Columns("ImporteValor").Width = 80
        dgvDetalleRec.Columns("ImporteValor").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDetalleRec.Columns("ImporteValor").DefaultCellStyle.Format = "$ #,##0.00"

        dgvDetalleRec.Columns("ObservValor").HeaderText = "OBSERVACIONES"
        dgvDetalleRec.Columns("ObservValor").Width = 200
        dgvDetalleRec.Columns("ObservValor").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        estiloEnc.Font = New Font(dgvDetalleRec.Font, FontStyle.Bold)
        dgvDetalleRec.ColumnHeadersDefaultCellStyle = estiloEnc
        dgvDetalleRec.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub


    Private Sub btnImpComprobante_Click(sender As Object, e As EventArgs) Handles btnImpComprobante.Click
        Dim _Guardar As New GrabaDatos

        Try
            If dgvComp.RowCount > 0 Or dgvRecibos.RowCount > 0 Then
                frmInfFacturaVenta.lblOrigen.Text = "Cta Cte Venta"
                frmInfFacturaVenta.lblTipo.Text = dgvCtaCteMostrar.SelectedCells.Item(3).Value
                _Guardar.Grabar("Reimpresion", "NoImagen", "modFacturaVtaReimpresion", CInt(dgvComp.SelectedCells.Item(0).Value), _
                                "Si", Format(CDate(Date.Now.Date), "yyyy/MM/dd"))
                frmInfFacturaVenta.ShowDialog()
            Else
                MsgBox("Error: Sin comprobates para imprimir !", vbInformation, "Servicio de Alertas")
            End If
        Catch ex As Exception
            MsgBox("Error: No se puden mostrar los datos para imprimir !", vbInformation, "Servicio de Alertas")
        End Try
    End Sub

    Private Sub txtCtaProv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCtaProv.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If txtCtaProv.Text = "" Then
                e.Handled = True
                frmProveedores.lblOrigen.Text = "Cta Cte Compra"
                frmProveedores.txtBuscar.Text = ""
                frmProveedores.txtBuscar.Select()
                frmProveedores.ShowDialog()
            Else
                e.Handled = True
                LimpiarDGV()
                If IsNumeric(txtCtaProv.Text) Then
                    Dim _Ver As New Mostrar
                    Dim _DsCli As New DataSet
                    Dim _Dt As New DataTable
                    _DsCli.Tables.Add(_Ver.verProveedores(mdifrmppal.cdEmp).Copy)
                    Dim _Dv As New DataView(_DsCli.Tables(0))
                    _Dv.RowFilter = "IdProveedores = " & CInt(txtCtaProv.Text)
                    If _Dv.Count <> 0 Then
                        dgvCliente.DataSource = _Dv
                        dgvCliente.Select()
                        lblRazonSocial.Text = dgvCliente.SelectedCells.Item(4).Value
                        lblCUIT.Text = dgvCliente.SelectedCells.Item(11).Value
                        lblTipoIva.Text = dgvCliente.SelectedCells.Item(13).Value
                        lblDireccion.Text = dgvCliente.SelectedCells.Item(5).Value
                        lblLocalidad.Text = dgvCliente.SelectedCells.Item(6).Value
                        lblCP.Text = dgvCliente.SelectedCells.Item(7).Value
                        lblProvincia.Text = dgvCliente.SelectedCells.Item(8).Value
                        lblTE.Text = dgvCliente.SelectedCells.Item(10).Value
                        lblIIBB.Text = dgvCliente.SelectedCells.Item(12).Value
                        lblCredito.Text = Format(0, "$ #,##0.00")
                        lblEstado.Text = "Habilitado"

                        _Dt = _Ver.verCtaCteCompraIDProv(CInt(txtCtaProv.Text), mdifrmppal.cdEmp)
                        dgvCtaCte.DataSource = _Dt

                        Dim _Ds As New dsReportes
                        Dim calcSaldo As Double = 0

                        'Agrego filas desde DGV
                        Dim Filas As DataRow
                        Dim CantCol As Integer = dgvCtaCte.Columns.Count - 1
                        For i As Integer = 0 To dgvCtaCte.Rows.Count - 1
                            calcSaldo = calcSaldo + dgvCtaCte.Rows.Item(i).Cells("Credito").Value - dgvCtaCte.Rows.Item(i).Cells("Debito").Value
                            Filas = _Ds.Tables("dtCtaCteVenta").Rows.Add
                            For Each Columna As DataGridViewColumn In dgvCtaCte.Columns
                                If Columna.HeaderText = "idCtaCteCompra" Then
                                    Filas.Item("IdCtaCte") = dgvCtaCte.Rows.Item(i).Cells("idCtaCteCompra").Value
                                ElseIf Columna.HeaderText = "Fecha" Then
                                    Filas.Item("FECHA") = Format(dgvCtaCte.Rows.Item(i).Cells("Fecha").Value, "dd/MM/yyyy")
                                ElseIf Columna.HeaderText = "PtoVta" Then
                                    Filas.Item("PTO VTA") = dgvCtaCte.Rows.Item(i).Cells("PtoVta").Value
                                ElseIf Columna.HeaderText = "TipoComprobante" Then
                                    Filas.Item("TIPO") = dgvCtaCte.Rows.Item(i).Cells("TipoComprobante").Value
                                ElseIf Columna.HeaderText = "ClaseComprobante" Then
                                    Filas.Item("CLASE") = dgvCtaCte.Rows.Item(i).Cells("ClaseComprobante").Value
                                ElseIf Columna.HeaderText = "NroComprobante" Then
                                    Filas.Item("NUMERO") = dgvCtaCte.Rows.Item(i).Cells("NroComprobante").Value
                                ElseIf Columna.HeaderText = "FormaPago" Then
                                    Filas.Item("FORMA PAGO") = dgvCtaCte.Rows.Item(i).Cells("FormaPago").Value
                                ElseIf Columna.HeaderText = "Debito" Then
                                    Filas.Item("DEBE") = Format(dgvCtaCte.Rows.Item(i).Cells("Debito").Value, "$ #,##0.00")
                                ElseIf Columna.HeaderText = "Credito" Then
                                    Filas.Item("HABER") = Format(dgvCtaCte.Rows.Item(i).Cells("Credito").Value, "$ #,##0.00")
                                ElseIf Columna.HeaderText = "Saldo" Then
                                    Filas.Item("SALDO") = Format(calcSaldo, "$ #,##0.00")
                                End If
                            Next
                        Next
                        dgvCtaCteMostrar.DataSource = _Ds.Tables("dtCtaCteVenta")

                    Else
                        MsgBox("Error: Nro de Cuenta no se corresponde con ningún proveedor !", vbInformation, "Servicio de Alertas")
                        txtCtaProv.Text = ""
                        txtCtaProv.Select()
                    End If
                Else
                    MsgBox("Error: Nro de Cuenta no se corresponde con ningún proveedor !", vbInformation, "Servicio de Alertas")
                    txtCtaProv.Text = ""
                    txtCtaProv.Select()
                End If
            End If
        End If
    End Sub

End Class