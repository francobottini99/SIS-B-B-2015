Public Class frmInfStock
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Hide()
    End Sub

    Private Sub frmInfStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim _Ds As New dsReportes

            'Agrego filas desde DGV
            Dim row As DataRow
            Dim colcount As Integer = frmConsStock .dgvStock.Columns.Count - 1
            For i As Integer = 0 To frmConsStock.dgvStock.Rows.Count - 1
                row = _Ds.Tables("dtConsStock").Rows.Add
                For Each column As DataGridViewColumn In frmConsStock.dgvStock.Columns
                    If column.Index = 7 Then
                        row.Item(column.Index) = Format(frmConsStock.dgvStock.Rows.Item(i).Cells(column.Index).Value, "##0.00 %")
                    ElseIf column.Index = 8 Then
                        row.Item(column.Index) = Format(frmConsStock.dgvStock.Rows.Item(i).Cells(column.Index).Value, "$ #,##0.00")
                    ElseIf column.Index = 10 Then
                        row.Item(column.Index) = Format(frmConsStock.dgvStock.Rows.Item(i).Cells(column.Index).Value, "#,##0.00")
                    Else
                        row.Item(column.Index) = frmConsStock.dgvStock.Rows.Item(i).Cells(column.Index).Value
                    End If
                    row.Item(column.Index + 1) = Format(CDbl(frmConsStock.lblTotalStk.Text), "#,##0.00")
                    row.Item(column.Index + 2) = Format(CDbl(frmConsStock.lblImpSiva.Text), "$ #,##0.00")
                    row.Item(column.Index + 3) = Format(CDbl(frmConsStock.lblImpCiva.Text), "$ #,##0.00")
                Next
            Next

            rptStockVal.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            rptStockVal.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\rptConsStock.rdlc"
            rptStockVal.LocalReport.DataSources.Clear()
            rptStockVal.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsInfStock", _Ds.Tables("dtConsStock")))
            rptStockVal.DocumentMapCollapsed = True
            Me.rptStockVal.RefreshReport()
        Catch ex As MySqlException
            MsgBox("Error al cargar stocks" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
        End Try
    End Sub

End Class