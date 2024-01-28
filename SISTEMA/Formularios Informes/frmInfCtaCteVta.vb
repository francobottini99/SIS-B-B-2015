Public Class frmInfCtaCteVta

    Private Sub frmInfCtaCteVta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Text = "CUENTA CORRIENTE DE VENTA - " & mdiFrmPpal.encForm
            Dim _Ver As New Mostrar
            Dim _Dt As New DataTable
            Dim _Ds As New dsReportes
            Dim calcSaldo As Double = 0
            Dim salDcta As Double = 0

            _Dt = _Ver.consCtaCteVtaporCli(CInt(frmCtaCteVenta.txtCtaCliente.Text), mdiFrmPpal.cdEmp, CDate("1800/01/01"), Date.Now.Date)
            dgvCta.DataSource = _Dt

            'Agrego filas desde DGV
            Dim Filas As DataRow
            Dim CantCol As Integer = dgvCta.Columns.Count - 1

            For i As Integer = 0 To dgvCta.Rows.Count - 1
                salDcta = salDcta + CDbl(dgvCta.Rows.Item(i).Cells("Credito").Value) - CDbl(dgvCta.Rows.Item(i).Cells("Debito").Value)
            Next

            For i As Integer = 0 To dgvCta.Rows.Count - 1
                calcSaldo = calcSaldo + CDbl(dgvCta.Rows.Item(i).Cells("Credito").Value) - CDbl(dgvCta.Rows.Item(i).Cells("Debito").Value)
                Filas = _Ds.Tables("dtCtaCteVtaImp").Rows.Add
                For Each Columna As DataGridViewColumn In dgvCta.Columns
                    If Columna.HeaderText = "idClientes" Then
                        Filas.Item("idCliente") = dgvCta.Rows.Item(i).Cells("idClientes").Value
                    ElseIf Columna.HeaderText = "RazonSocial" Then
                        Filas.Item("RazonSocial") = dgvCta.Rows.Item(i).Cells("RazonSocial").Value
                    ElseIf Columna.HeaderText = "Direccion" Then
                        Filas.Item("Direccion") = dgvCta.Rows.Item(i).Cells("Direccion").Value
                    ElseIf Columna.HeaderText = "Localidad" Then
                        Filas.Item("Localidad") = dgvCta.Rows.Item(i).Cells("Localidad").Value
                    ElseIf Columna.HeaderText = "CP" Then
                        Filas.Item("CP") = dgvCta.Rows.Item(i).Cells("CP").Value
                    ElseIf Columna.HeaderText = "Provincia" Then
                        Filas.Item("Provincia") = dgvCta.Rows.Item(i).Cells("Provincia").Value
                    ElseIf Columna.HeaderText = "Pais" Then
                        Filas.Item("Pais") = dgvCta.Rows.Item(i).Cells("Pais").Value
                    ElseIf Columna.HeaderText = "TE" Then
                        Filas.Item("TE") = dgvCta.Rows.Item(i).Cells("TE").Value
                    ElseIf Columna.HeaderText = "CUIT" Then
                        Filas.Item("CUIT") = dgvCta.Rows.Item(i).Cells("CUIT").Value
                    ElseIf Columna.HeaderText = "Fecha" Then
                        Filas.Item("Fecha") = Format(CDate(dgvCta.Rows.Item(i).Cells("Fecha").Value), "dd/MM/yyyy")
                    ElseIf Columna.HeaderText = "PtoVta" Then
                        Filas.Item("PtoVta") = dgvCta.Rows.Item(i).Cells("PtoVta").Value
                    ElseIf Columna.HeaderText = "FormaPago" Then
                        Filas.Item("FormaPago") = dgvCta.Rows.Item(i).Cells("FormaPago").Value
                    ElseIf Columna.HeaderText = "ClaseComprobante" Then
                        Filas.Item("Clase") = dgvCta.Rows.Item(i).Cells("claseComprobante").Value
                    ElseIf Columna.HeaderText = "TipoComprobante" Then
                        Filas.Item("Tipo") = dgvCta.Rows.Item(i).Cells("TipoComprobante").Value
                    ElseIf Columna.HeaderText = "NroComprobante" Then
                        Filas.Item("Numero") = dgvCta.Rows.Item(i).Cells("NroComprobante").Value
                    ElseIf Columna.HeaderText = "Credito" Then
                        Filas.Item("Haber") = Format(dgvCta.Rows.Item(i).Cells("Credito").Value, "$ #,##0.00")
                    ElseIf Columna.HeaderText = "Debito" Then
                        Filas.Item("Debe") = Format(dgvCta.Rows.Item(i).Cells("Debito").Value, "$ #,##0.00")
                    ElseIf Columna.HeaderText = "Saldo" Then
                        Filas.Item("Saldo") = Format(calcSaldo, "$ #,##0.00")
                    End If
                Next
                Filas.Item("SaldoCta") = Format(salDcta, "$ #,##0.00")
            Next

            rptResD.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            rptResD.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\rptConsCtaCteVenta.rdlc"
            rptResD.LocalReport.DataSources.Clear()
            rptResD.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsConsCtaCteVenta", _Ds.Tables("dtCtaCteVtaImp")))
            rptResD.DocumentMapCollapsed = True
            Me.rptResD.RefreshReport()
        Catch ex As MySqlException
            MsgBox("Error al cargar el informe" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
        End Try

    End Sub

    Private Sub btnCerrar_Click_1(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Hide()
    End Sub
End Class