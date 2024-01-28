Public Class frmInfFacturaVenta

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Hide()
    End Sub

    Private Sub frmInfFacturaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim _Ds As New dsReportes
            Dim _DtE, _Dt As New DataTable
            Dim _Ver As New Mostrar

            _DtE = _Ver.verEmpresaFiltrada(mdiFrmPpal.cdEmp)
            Dim Fila As DataRow = _DtE.Rows(_DtE.Rows.Count - 1)
            If lblOrigen.Text = "Factura Venta" Then
                _Dt = _Ver.verEmisionFacVta(mdiFrmPpal.cdEmp, CInt(frmFacturaVentas.lblIdFactura.Text))
            ElseIf lblOrigen.Text = "Cta Cte Venta" Then
                _Dt = _Ver.verEmisionFacVta(mdiFrmPpal.cdEmp, CInt(frmCtaCteVenta.dgvComp.SelectedCells.Item(0).Value))
            Else
                _Dt = Nothing
            End If
            dgvFactura.DataSource = _Dt

            If lblTipo.Text = "A" Or lblTipo.Text = "B" Then
                'Agrego filas desde DGV
                Dim row As DataRow
                For i As Integer = 0 To dgvFactura.Rows.Count - 2
                    row = _Ds.Tables("dtEmisionFacVta").Rows.Add
                    For Each column As DataGridViewColumn In dgvFactura.Columns
                        If column.Index = 3 Or column.Index = 41 Or column.Index = 43 Then
                            row.Item(column.Index) = Format(CDate(dgvFactura.Rows.Item(i).Cells(column.Index).Value), "dd/MM/yyyy")
                        ElseIf column.Index = 25 Or column.Index = 27 Or column.Index = 28 Or column.Index = 29 Or column.Index = 30 Or column.Index = 32 Or column.Index = 34 Or column.Index = 36 Or column.Index = 37 Then
                            row.Item(column.Index) = Format(dgvFactura.Rows.Item(i).Cells(column.Index).Value, "$ #,##0.00")
                        ElseIf column.Index = 24 Then
                            row.Item(column.Index) = Format(dgvFactura.Rows.Item(i).Cells(column.Index).Value, "#,##0.00")
                        ElseIf column.Index = 26 Or column.Index = 31 Or column.Index = 33 Or column.Index = 35 Then
                            row.Item(column.Index) = Format(dgvFactura.Rows.Item(i).Cells(column.Index).Value, "##0.00 %")
                        Else
                            row.Item(column.Index) = dgvFactura.Rows.Item(i).Cells(column.Index).Value
                        End If
                        row.Item(44) = Fila("RazonSocial").ToString
                        row.Item(45) = Fila("Direccion").ToString
                        row.Item(46) = Fila("Localidad").ToString
                        row.Item(47) = Fila("CP").ToString
                        row.Item(48) = Fila("Provincia").ToString
                        row.Item(49) = Fila("Pais").ToString
                        row.Item(50) = Fila("Telefono").ToString
                        row.Item(51) = Fila("Mail").ToString
                        row.Item(52) = Fila("Web").ToString
                        row.Item(53) = Fila("Propietario").ToString
                        row.Item(55) = Fila("Eslogan").ToString
                        row.Item(56) = Format(CDate(Fila("InicioActividades").ToString), "dd/MM/yyyy")
                        row.Item(57) = Fila("CUIT").ToString
                        row.Item(58) = Fila("IIBB").ToString
                        row.Item(59) = Fila("IVA").ToString
                    Next
                Next

                rptFacVenta.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                If lblTipo.Text = "A" Then
                    rptFacVenta.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\rptEmisionFacVtaA.rdlc"
                Else
                    rptFacVenta.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\rptEmisionFacVtaB.rdlc"
                End If
                rptFacVenta.LocalReport.DataSources.Clear()
                rptFacVenta.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsEmisionFacVta", _Ds.Tables("dtEmisionFacVta")))
                rptFacVenta.DocumentMapCollapsed = True
                Me.rptFacVenta.RefreshReport()
            ElseIf lblTipo.Text = "X" Then
                'Agrego filas desde DGV
                Dim row As DataRow
                For i As Integer = 0 To dgvFactura.Rows.Count - 2
                    row = _Ds.Tables("dtEmisionFacVta").Rows.Add
                    For Each column As DataGridViewColumn In dgvFactura.Columns
                        If column.Index = 3 Or column.Index = 41 Or column.Index = 43 Then
                            row.Item(column.Index) = Format(CDate(dgvFactura.Rows.Item(i).Cells(column.Index).Value), "dd/MM/yyyy")
                        ElseIf column.Index = 25 Or column.Index = 27 Or column.Index = 28 Or column.Index = 29 Or column.Index = 30 Or column.Index = 32 Or column.Index = 34 Or column.Index = 36 Or column.Index = 37 Then
                            row.Item(column.Index) = Format(CDbl(dgvFactura.Rows.Item(i).Cells(column.Index).Value), "$ #,##0.00")
                        ElseIf column.Index = 24 Then
                            row.Item(column.Index) = Format(dgvFactura.Rows.Item(i).Cells(column.Index).Value, "#,##0.00")
                        ElseIf column.Index = 26 Or column.Index = 31 Or column.Index = 33 Or column.Index = 35 Then
                            row.Item(column.Index) = Format(dgvFactura.Rows.Item(i).Cells(column.Index).Value, "##0.00 %")
                        Else
                            row.Item(column.Index) = dgvFactura.Rows.Item(i).Cells(column.Index).Value
                        End If
                        row.Item(7) = "Presupuesto"
                        row.Item(44) = Fila("RazonSocial").ToString
                        row.Item(45) = Fila("Direccion").ToString
                        row.Item(46) = Fila("Localidad").ToString
                        row.Item(47) = Fila("CP").ToString
                        row.Item(48) = Fila("Provincia").ToString
                        row.Item(49) = Fila("Pais").ToString
                        row.Item(50) = Fila("Telefono").ToString
                        row.Item(51) = Fila("Mail").ToString
                        row.Item(52) = Fila("Web").ToString
                        row.Item(53) = Fila("Propietario").ToString
                        row.Item(55) = Fila("Eslogan").ToString
                        row.Item(56) = Format(CDate(Fila("InicioActividades").ToString), "dd/MM/yyyy")
                        row.Item(57) = Fila("CUIT").ToString
                        row.Item(58) = Fila("IIBB").ToString
                        row.Item(59) = Fila("IVA").ToString
                    Next
                Next

                rptFacVenta.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
                rptFacVenta.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\rptEmisionFacVtaX.rdlc"
                rptFacVenta.LocalReport.DataSources.Clear()
                rptFacVenta.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsEmisionFacVta", _Ds.Tables("dtEmisionFacVta")))
                rptFacVenta.DocumentMapCollapsed = True
                Me.rptFacVenta.RefreshReport()

            End If
        Catch ex As MySqlException
            MsgBox("Error la cargar datos de factura venta para imprimir" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
        End Try
    End Sub

End Class