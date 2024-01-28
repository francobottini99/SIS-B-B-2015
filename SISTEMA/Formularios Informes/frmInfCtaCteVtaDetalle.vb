Public Class frmInfCtaCteVtaDetalle

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Hide()
    End Sub

    Private Sub frmInfCtaCteVtaDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Text = "CUENTA CORRIENTE DE VENTA DETALLADA - " & mdiFrmPpal.encForm
            Dim _Ver As New Mostrar
            Dim _DtFa, _DtRc As New DataTable
            Dim _Ds As New dsReportes

            _DtFa = _Ver.verCtaCteVtaDetalleFa(CInt(frmCtaCteVenta.txtCtaCliente.Text), mdiFrmPpal.cdEmp, CDate("1800/01/01"), CDate(Date.Now.Date))
            dgvFa.DataSource = _DtFa
            _DtRc = _Ver.verCtaCteVtaDetalleRc(CInt(frmCtaCteVenta.txtCtaCliente.Text), mdiFrmPpal.cdEmp, CDate("1800/01/01"), CDate(Date.Now.Date))
            dgvRec.DataSource = _DtRc

            'Agrego filas desde DGV FACTURAS
            Dim row As DataRow
            For i As Integer = 0 To dgvFa.Rows.Count - 1
                row = _Ds.Tables("dtCtaCteVentaDetallada").Rows.Add
                row.Item("idCtaCteVta") = dgvFa.Rows.Item(i).Cells("idCtaCteVenta").Value
                row.Item("CodUnico") = dgvFa.Rows.Item(i).Cells("CodUN").Value
                row.Item("CodBarra") = dgvFa.Rows.Item(i).Cells("Codbarra").Value
                row.Item("Fecha") = dgvFa.Rows.Item(i).Cells("Fecha").Value
                row.Item("idClientes") = dgvFa.Rows.Item(i).Cells("idClientes").Value
                row.Item("RazonSocial") = dgvFa.Rows.Item(i).Cells("RazonSocial").Value
                row.Item("Direccion") = dgvFa.Rows.Item(i).Cells("Direccion").Value
                row.Item("Localidad") = dgvFa.Rows.Item(i).Cells("Localidad").Value
                row.Item("CP") = dgvFa.Rows.Item(i).Cells("CP").Value
                row.Item("Provincia") = dgvFa.Rows.Item(i).Cells("Provincia").Value
                row.Item("Pais") = dgvFa.Rows.Item(i).Cells("Pais").Value
                row.Item("TE") = dgvFa.Rows.Item(i).Cells("TE").Value
                row.Item("IIBB") = dgvFa.Rows.Item(i).Cells("IIBB").Value
                row.Item("CategoriaIVA") = dgvFa.Rows.Item(i).Cells("CategoriaIVA").Value
                row.Item("CreditoCli") = 0
                row.Item("Estado") = dgvFa.Rows.Item(i).Cells("Estado").Value
                row.Item("FormaPago") = dgvFa.Rows.Item(i).Cells("FormaPago").Value
                row.Item("ClaseComprobante") = dgvFa.Rows.Item(i).Cells("ClaseComprobante").Value
                row.Item("TipoComprobante") = dgvFa.Rows.Item(i).Cells("TipoComprobante").Value
                row.Item("CodComprobante") = dgvFa.Rows.Item(i).Cells("CodComprobante").Value
                row.Item("PtoVta") = dgvFa.Rows.Item(i).Cells("PtoVta").Value
                row.Item("NroComprobante") = dgvFa.Rows.Item(i).Cells("NroComprobante").Value
                row.Item("SubTotal") = dgvFa.Rows.Item(i).Cells("SubTotal").Value
                row.Item("Descuento") = dgvFa.Rows.Item(i).Cells("Descuento").Value
                row.Item("BaseImponible") = dgvFa.Rows.Item(i).Cells("BaseImponible").Value
                row.Item("Iva1") = dgvFa.Rows.Item(i).Cells("Iva1").Value
                row.Item("ImpIva1") = dgvFa.Rows.Item(i).Cells("ImpIva1").Value
                row.Item("Iva2") = dgvFa.Rows.Item(i).Cells("Iva2").Value
                row.Item("ImpIva2") = dgvFa.Rows.Item(i).Cells("ImpIva2").Value
                row.Item("Iva3") = dgvFa.Rows.Item(i).Cells("Iva3").Value
                row.Item("ImpIva3") = dgvFa.Rows.Item(i).Cells("ImpIva3").Value
                row.Item("Total") = dgvFa.Rows.Item(i).Cells("Total").Value
                row.Item("Observaciones") = dgvFa.Rows.Item(i).Cells("Observaciones").Value
                row.Item("Detalle") = dgvFa.Rows.Item(i).Cells("Detalle").Value
                row.Item("Unidad") = dgvFa.Rows.Item(i).Cells("Unidad").Value
                row.Item("Cantidad") = dgvFa.Rows.Item(i).Cells("Cantidad").Value
                row.Item("Precio") = dgvFa.Rows.Item(i).Cells("Precio").Value
                row.Item("Iva") = dgvFa.Rows.Item(i).Cells("AlIva").Value
                row.Item("Importe") = dgvFa.Rows.Item(i).Cells("Importe").Value
                row.Item("TipoValor") = "Factura/NC/ND"
                row.Item("DetalleValor") = "-"
                row.Item("Debito") = dgvFa.Rows.Item(i).Cells("Debito").Value
                row.Item("Credito") = dgvFa.Rows.Item(i).Cells("Credito").Value
                row.Item("Saldo") = dgvFa.Rows.Item(i).Cells("Saldo").Value
                row.Item("Usuario") = dgvFa.Rows.Item(i).Cells("Usuario").Value
                row.Item("CtaCteidCli") = dgvFa.Rows.Item(i).Cells("Clientes_idClientes").Value
            Next

            'Agrego filas desde DGV RECIBOS
            For i As Integer = 0 To dgvRec.Rows.Count - 1
                row = _Ds.Tables("dtCtaCteVentaDetallada").Rows.Add
                row.Item("idCtaCteVta") = dgvRec.Rows.Item(i).Cells("idCtaCteVenta").Value
                row.Item("CodUnico") = dgvRec.Rows.Item(i).Cells("CodUN").Value
                row.Item("CodBarra") = dgvRec.Rows.Item(i).Cells("Codbarra").Value
                row.Item("Fecha") = dgvRec.Rows.Item(i).Cells("Fecha").Value
                row.Item("idClientes") = dgvRec.Rows.Item(i).Cells("idClientes").Value
                row.Item("RazonSocial") = dgvRec.Rows.Item(i).Cells("RazonSocial").Value
                row.Item("Direccion") = dgvRec.Rows.Item(i).Cells("Direccion").Value
                row.Item("Localidad") = dgvRec.Rows.Item(i).Cells("Localidad").Value
                row.Item("CP") = dgvRec.Rows.Item(i).Cells("CP").Value
                row.Item("Provincia") = dgvRec.Rows.Item(i).Cells("Provincia").Value
                row.Item("Pais") = dgvRec.Rows.Item(i).Cells("Pais").Value
                row.Item("TE") = dgvRec.Rows.Item(i).Cells("TE").Value
                row.Item("IIBB") = dgvRec.Rows.Item(i).Cells("IIBB").Value
                row.Item("CategoriaIVA") = dgvRec.Rows.Item(i).Cells("CategoriaIVA").Value
                row.Item("CreditoCli") = 0
                row.Item("Estado") = dgvRec.Rows.Item(i).Cells("Estado").Value
                row.Item("FormaPago") = dgvRec.Rows.Item(i).Cells("FormaPago").Value
                row.Item("ClaseComprobante") = dgvRec.Rows.Item(i).Cells("ClaseComprobante").Value
                row.Item("TipoComprobante") = dgvRec.Rows.Item(i).Cells("TipoComprobante").Value
                row.Item("CodComprobante") = dgvRec.Rows.Item(i).Cells("CodComprobante").Value
                row.Item("PtoVta") = dgvRec.Rows.Item(i).Cells("PtoVta").Value
                row.Item("NroComprobante") = dgvRec.Rows.Item(i).Cells("NroComprobante").Value
                row.Item("SubTotal") = Format(0, "$ #,##0.00")
                row.Item("Descuento") = Format(0, "$ #,##0.00")
                row.Item("BaseImponible") = Format(0, "$ #,##0.00")
                row.Item("Iva1") = Format(0, "$ #,##0.00")
                row.Item("ImpIva1") = Format(0, "$ #,##0.00")
                row.Item("Iva2") = Format(0, "$ #,##0.00")
                row.Item("ImpIva2") = Format(0, "$ #,##0.00")
                row.Item("Iva3") = Format(0, "$ #,##0.00")
                row.Item("ImpIva3") = Format(0, "$ #,##0.00")
                row.Item("Total") = dgvRec.Rows.Item(i).Cells("Importe").Value
                row.Item("Observaciones") = dgvRec.Rows.Item(i).Cells("Observaciones").Value
                row.Item("Detalle") = dgvRec.Rows.Item(i).Cells("NroValor").Value & "-" & Format(CDate(dgvRec.Rows.Item(i).Cells("FecCobro").Value), "dd/MM/yyyy") & "-" & Format(CDbl(dgvRec.Rows.Item(i).Cells("ImporteValor").Value), "$ #,##0.00")
                row.Item("Unidad") = "-"
                row.Item("Cantidad") = "-"
                row.Item("Precio") = "-"
                row.Item("Iva") = "-"
                row.Item("Importe") = "-"
                row.Item("TipoValor") = dgvRec.Rows.Item(i).Cells("TipoValor").Value
                row.Item("DetalleValor") = dgvRec.Rows.Item(i).Cells("Librador").Value & "-" & dgvRec.Rows.Item(i).Cells("Banco").Value & "-" & dgvRec.Rows.Item(i).Cells("SucursalPago").Value
                row.Item("Debito") = dgvRec.Rows.Item(i).Cells("Debito").Value
                row.Item("Credito") = dgvRec.Rows.Item(i).Cells("Credito").Value
                row.Item("Saldo") = dgvRec.Rows.Item(i).Cells("Saldo").Value
                row.Item("Usuario") = dgvRec.Rows.Item(i).Cells("Usuario").Value
                row.Item("CtaCteidCli") = dgvRec.Rows.Item(i).Cells("Clientes_idClientes").Value
            Next

            Dim _DtOrd = _Ds.Tables("dtCtaCteVentaDetallada")
            _DtOrd.DefaultView.Sort = "idCtaCteVta"
            _Ds.Tables.Remove("dtCtaCteVentaDetallada")
            _Ds.Tables.Add(_DtOrd.DefaultView.ToTable)
            _Ds.AcceptChanges()

            rptResD.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            rptResD.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\rptConsCtaCteVtaDetalle.rdlc"
            rptResD.LocalReport.DataSources.Clear()
            rptResD.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsCtaCteVtaDetalle", _Ds.Tables("dtCtaCteVentaDetallada")))
            rptResD.DocumentMapCollapsed = True
            Me.rptResD.RefreshReport()
        Catch ex As MySqlException
            MsgBox("Error al cargar el informe" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
        End Try
    End Sub
End Class