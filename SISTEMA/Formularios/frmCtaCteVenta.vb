Public Class frmCtaCteVenta

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

    Private Sub txtCtaCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCtaCliente.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If txtCtaCliente.Text = "" Then
                e.Handled = True
                frmClientes.lblOrigen.Text = "Cta Cte Venta"
                frmClientes.txtBuscar.Text = ""
                frmClientes.txtBuscar.Select()
                frmClientes.ShowDialog()
            Else
                e.Handled = True
                LimpiarDGV()
                If IsNumeric(txtCtaCliente.Text) Then
                    Dim _Ver As New Mostrar
                    Dim _DsCli As New DataSet
                    Dim _Dt As New DataTable
                    _DsCli.Tables.Add(_Ver.verClientes(mdiFrmPpal.cdEmp).Copy)
                    Dim _Dv As New DataView(_DsCli.Tables(0))
                    _Dv.RowFilter = "IdClientes = " & CInt(txtCtaCliente.Text)
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
                        lblCredito.Text = Format(dgvCliente.SelectedCells.Item(15).Value, "$ #,##0.00")
                        If dgvCliente.SelectedCells.Item(16).Value = 1 Then
                            lblEstado.Text = "Habilitado"
                        Else
                            lblEstado.Text = "Inhabilitado"
                        End If

                        _Dt = _Ver.verCtaCteVentaIDCli(CInt(txtCtaCliente.Text), mdiFrmPpal.cdEmp)
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
                                If Columna.HeaderText = "idCtaCteVenta" Then
                                    Filas.Item("IdCtaCte") = dgvCtaCte.Rows.Item(i).Cells("idCtaCteVenta").Value
                                ElseIf Columna.HeaderText = "Fecha" Then
                                    Filas.Item("FECHA") = Format(dgvCtaCte.Rows.Item(i).Cells("Fecha").Value, "dd/MM/yyyy")
                                ElseIf Columna.HeaderText = "PtoVta" Then
                                    Filas.Item("PTO_VTA") = dgvCtaCte.Rows.Item(i).Cells("PtoVta").Value
                                ElseIf Columna.HeaderText = "TipoComprobante" Then
                                    Filas.Item("TIPO") = dgvCtaCte.Rows.Item(i).Cells("TipoComprobante").Value
                                ElseIf Columna.HeaderText = "ClaseComprobante" Then
                                    Filas.Item("CLASE") = dgvCtaCte.Rows.Item(i).Cells("ClaseComprobante").Value
                                ElseIf Columna.HeaderText = "NroComprobante" Then
                                    Filas.Item("NUMERO") = dgvCtaCte.Rows.Item(i).Cells("NroComprobante").Value
                                ElseIf Columna.HeaderText = "FormaPago" Then
                                    Filas.Item("FORMA_PAGO") = dgvCtaCte.Rows.Item(i).Cells("FormaPago").Value
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
                        lblSaldo.Text = Format(calcSaldo, "$ #,##0.00")
                    Else
                        MsgBox("Error: Nro de Cuenta no se corresponde con ningún cliente !", vbInformation, "Servicio de Alertas")
                        txtCtaCliente.Text = ""
                        txtCtaCliente.Select()
                    End If
                Else
                    MsgBox("Error: Nro de Cuenta no se corresponde con ningún cliente !", vbInformation, "Servicio de Alertas")
                    txtCtaCliente.Text = ""
                    txtCtaCliente.Select()
                End If
            End If
        End If
    End Sub

    Private Sub frmCtaCteVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _Ds As New dsReportes

        Dim _Ver As New Mostrar
        Dim _Dt As New DataTable

        dgvCtaCteMostrar.DataSource = Nothing

        _Dt = _Ver.verFacturaVenta(-99)
        dgvComp.DataSource = _Dt
        FormatoDeDGVComp()

        _Dt = _Ver.verDetalleFacturaVenta(-99)
        dgvDetalle.DataSource = _Dt
        FormatoDGVDetalle()

        _Dt = _Ver.verFormaPago(-99)
        dgvVencimientos.DataSource = _Dt
        FormatoDGVFromaPago()

        _Dt = _Ver.verReciboVenta(-99)
        dgvRecibos.DataSource = _Dt
        FormatoDeDGVRecibos()

        _Dt = _Ver.verDetalleRecibo(-99)
        dgvDetalleRec.DataSource = _Dt
        FormatoDeDGVDetalleRec()

        Me.Text = "CONSULTA DE CUENTA CORRIENTE CLIENTES - " & mdiFrmPpal.encForm

        txtCtaCliente.Select()

    End Sub

    Private Sub dgvCtaCteMostrar_Click(sender As Object, e As EventArgs) Handles dgvCtaCteMostrar.Click
        Try
            If dgvCtaCteMostrar.RowCount > 0 Then
                Dim _Ver As New Mostrar
                Dim _Dt As New DataTable

                If dgvCtaCteMostrar.SelectedCells.Item(4).Value = "Rc" Then
                    _Dt = _Ver.verReciboVenta(dgvCtaCteMostrar.SelectedCells.Item(10).Value)
                    dgvRecibos.DataSource = _Dt
                    dgvRecibos.Visible = True

                    _Dt = _Ver.verDetalleRecibo(dgvRecibos.SelectedCells.Item(0).Value)
                    dgvDetalleRec.DataSource = _Dt
                    dgvDetalleRec.Visible = True

                    _Dt = _Ver.verFormaPago(-99)
                    dgvVencimientos.DataSource = _Dt
                Else
                    _Dt = _Ver.verFacturaVenta(dgvCtaCteMostrar.SelectedCells.Item(10).Value)
                    dgvComp.DataSource = _Dt
                    dgvRecibos.Visible = False

                    _Dt = _Ver.verDetalleFacturaVenta(dgvComp.SelectedCells.Item(0).Value)
                    dgvDetalle.DataSource = _Dt
                    dgvDetalleRec.Visible = False

                    _Dt = _Ver.verFormaPago(dgvComp.SelectedCells.Item(0).Value)
                    dgvVencimientos.DataSource = _Dt
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: No se puden mostrar los datos correspondientes !", vbInformation, "Servicio de Alertas")
        End Try
    End Sub

    Private Sub Limpiar()
        Dim _Ver As New Mostrar
        Dim _Dt As New DataTable

        txtCtaCliente.Text = ""
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

        _Dt = _Ver.verFacturaVenta(-99)
        dgvComp.DataSource = _Dt
        FormatoDeDGVComp()

        _Dt = _Ver.verDetalleFacturaVenta(-99)
        dgvDetalle.DataSource = _Dt
        FormatoDGVDetalle()

        _Dt = _Ver.verFormaPago(-99)
        dgvVencimientos.DataSource = _Dt
        FormatoDGVFromaPago()

        txtCtaCliente.Select()
    End Sub

    Private Sub LimpiarDGV()
        Dim _Ver As New Mostrar
        Dim _Dt As New DataTable

        dgvCtaCteMostrar.DataSource = Nothing

        _Dt = _Ver.verFacturaVenta(-99)
        dgvComp.DataSource = _Dt
        FormatoDeDGVComp()

        _Dt = _Ver.verDetalleFacturaVenta(-99)
        dgvDetalle.DataSource = _Dt
        FormatoDGVDetalle()

        _Dt = _Ver.verFormaPago(-99)
        dgvVencimientos.DataSource = _Dt
        FormatoDGVFromaPago()

        _Dt = _Ver.verReciboVenta(-99)
        dgvRecibos.DataSource = _Dt
        FormatoDeDGVRecibos()

        _Dt = _Ver.verDetalleRecibo(-99)
        dgvDetalleRec.DataSource = _Dt
        FormatoDeDGVDetalleRec()

        txtCtaCliente.Select()
    End Sub

    Private Sub FormatoDeDGVComp()
        dgvComp.Columns.Item("IdFacturas").Visible = False
        dgvComp.Columns.Item("CodUN").Visible = False
        dgvComp.Columns.Item("CodBarra").Visible = False
        dgvComp.Columns.Item("TipoFactura").Visible = False
        dgvComp.Columns.Item("Iva1").Visible = False
        dgvComp.Columns.Item("Iva2").Visible = False
        dgvComp.Columns.Item("Iva3").Visible = False
        dgvComp.Columns.Item("Usuario").Visible = False
        dgvComp.Columns.Item("CtaCteVenta_idCtaCteVenta").Visible = False

        Dim estiloEnc As New DataGridViewCellStyle()
        Dim textEnc As String = ""

        dgvComp.Columns("FechaFac").HeaderText = "FECHA"
        dgvComp.Columns("FechaFac").Width = 80
        dgvComp.Columns("FechaFac").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvComp.Columns("FechaFac").DefaultCellStyle.Format = "dd/MM/yyyy"

        dgvComp.Columns("PtoVta").HeaderText = "PTO VTA"
        dgvComp.Columns("PtoVta").Width = 80
        dgvComp.Columns("PtoVta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvComp.Columns("NroFactura").HeaderText = "NUMERO"
        dgvComp.Columns("NroFactura").Width = 80
        dgvComp.Columns("NroFactura").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

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

        dgvComp.Columns("ImpIva1").HeaderText = "IVA 10.5%"
        dgvComp.Columns("ImpIva1").Width = 80
        dgvComp.Columns("ImpIva1").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvComp.Columns("ImpIva1").DefaultCellStyle.Format = "$ #,##0.00"

        dgvComp.Columns("ImpIva2").HeaderText = "IVA 21.0%"
        dgvComp.Columns("ImpIva2").Width = 80
        dgvComp.Columns("ImpIva2").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvComp.Columns("ImpIva2").DefaultCellStyle.Format = "$ #,##0.00"

        dgvComp.Columns("ImpIva3").HeaderText = "IVA 0.0%"
        dgvComp.Columns("ImpIva3").Width = 80
        dgvComp.Columns("ImpIva3").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvComp.Columns("ImpIva3").DefaultCellStyle.Format = "$ #,##0.00"

        dgvComp.Columns("Total").HeaderText = "TOTAL"
        dgvComp.Columns("Total").Width = 100
        dgvComp.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvComp.Columns("Total").DefaultCellStyle.Format = "$ #,##0.00"

        dgvComp.Columns("Observaciones").HeaderText = "OBSERVACIONES"
        dgvComp.Columns("Observaciones").Width = 200
        dgvComp.Columns("Observaciones").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgvComp.Columns("CAE").HeaderText = "CAE"
        dgvComp.Columns("CAE").Width = 100
        dgvComp.Columns("CAE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgvComp.Columns("VtoCAE").HeaderText = "VTO CAE"
        dgvComp.Columns("VtoCAE").Width = 80
        dgvComp.Columns("VtoCAE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvComp.Columns("VtoCAE").DefaultCellStyle.Format = "dd/MM/yyyy"

        dgvComp.Columns("Impreso").HeaderText = "IMPRESO"
        dgvComp.Columns("Impreso").Width = 50
        dgvComp.Columns("Impreso").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvComp.Columns("FecImpresion").HeaderText = "FEC IMPRESION"
        dgvComp.Columns("FecImpresion").Width = 80
        dgvComp.Columns("FecImpresion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvComp.Columns("FecImpresion").DefaultCellStyle.Format = "dd/MM/yyyy"

        dgvComp.Columns("Reimpreso").HeaderText = "REIMPRESO"
        dgvComp.Columns("Reimpreso").Width = 50
        dgvComp.Columns("Reimpreso").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvComp.Columns("FecReimpresion").HeaderText = "FEC REIMPRESION"
        dgvComp.Columns("FecReimpresion").Width = 80
        dgvComp.Columns("FecReimpresion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvComp.Columns("FecReimpresion").DefaultCellStyle.Format = "dd/MM/yyyy"

        estiloEnc.Font = New Font(dgvComp.Font, FontStyle.Bold)
        dgvComp.ColumnHeadersDefaultCellStyle = estiloEnc
        dgvComp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub FormatoDGVDetalle()
        dgvDetalle.Columns.Item("idFacturaDetalle").Visible = False
        dgvDetalle.Columns.Item("idArticulo").Visible = False
        dgvDetalle.Columns.Item("CodBarra").Visible = False
        dgvDetalle.Columns.Item("Usuario").Visible = False
        dgvDetalle.Columns.Item("VentaFacturas_idFacturas").Visible = False

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

    Private Sub FormatoDGVFromaPago()
        dgvVencimientos.Columns.Item("idFormaPago").Visible = False
        dgvVencimientos.Columns.Item("VentaFacturas_idFacturas").Visible = False

        Dim estiloEnc As New DataGridViewCellStyle()
        Dim textEnc As String = ""

        dgvVencimientos.Columns("PtoVta").HeaderText = "P VTA"
        dgvVencimientos.Columns("PtoVta").Width = 60
        dgvVencimientos.Columns("PtoVta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvVencimientos.Columns("NroFactura").HeaderText = "FACTURA"
        dgvVencimientos.Columns("NroFactura").Width = 60
        dgvVencimientos.Columns("NroFactura").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        dgvVencimientos.Columns("Cuotas").HeaderText = "CTAS"
        dgvVencimientos.Columns("Cuotas").Width = 50
        dgvVencimientos.Columns("Cuotas").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvVencimientos.Columns("Cuotas").DefaultCellStyle.Format = "#,##0"

        dgvVencimientos.Columns("Vencimiento").HeaderText = "VENCIM."
        dgvVencimientos.Columns("Vencimiento").Width = 80
        dgvVencimientos.Columns("Vencimiento").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvVencimientos.Columns("Vencimiento").DefaultCellStyle.Format = "dd/MM/yyyy"

        dgvVencimientos.Columns("Importe").HeaderText = "IMPORTE"
        dgvVencimientos.Columns("Importe").Width = 80
        dgvVencimientos.Columns("Importe").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvVencimientos.Columns("Importe").DefaultCellStyle.Format = "$ #,##0.00"

        dgvVencimientos.Columns("Observaciones").HeaderText = "OBSERVACIONES"
        dgvVencimientos.Columns("Observaciones").Width = 200
        dgvVencimientos.Columns("Observaciones").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        estiloEnc.Font = New Font(dgvVencimientos.Font, FontStyle.Bold)
        dgvVencimientos.ColumnHeadersDefaultCellStyle = estiloEnc
        dgvVencimientos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Private Sub FormatoDeDGVRecibos()
        dgvRecibos.Columns.Item("idVentaRecibos").Visible = False
        dgvRecibos.Columns.Item("CodUN").Visible = False
        dgvRecibos.Columns.Item("CodBarra").Visible = False
        dgvRecibos.Columns.Item("Usuario").Visible = False
        dgvRecibos.Columns.Item("CtaCteVenta_idCtaCteVenta").Visible = False

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
        dgvDetalleRec.Columns.Item("idReciboDetalle").Visible = False
        dgvDetalleRec.Columns.Item("VentaRecibos_idVentaRecibos").Visible = False

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

        dgvDetalleRec.Columns("SucursalPago").HeaderText = "SUCURSAL"
        dgvDetalleRec.Columns("SucursalPago").Width = 200
        dgvDetalleRec.Columns("SucursalPago").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

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
        'frmImpCtaCteVta.MdiParent = mdiFrmPpal
        frmImpCtaCteVta.ShowDialog()
    End Sub

End Class