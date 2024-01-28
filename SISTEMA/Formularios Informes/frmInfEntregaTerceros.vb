Public Class frmInfEntregaTerceros

    Private Sub frmInfStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim _Ds As New dsReportes

            'Agrego filas desde DGV
            Dim row As DataRow
            'Dim colcount As Integer = frmServTecnico.dgvServTecnico.Columns.Count - 2
            For i As Integer = 0 To frmSTEntregaRecep.dgvServTecnico.Rows.Count - 1
                row = _Ds.Tables("dtServTecnico").Rows.Add
                For Each column As DataGridViewColumn In frmSTEntregaRecep.dgvServTecnico.Columns
                    If column.Index > 1 Then
                        If column.Index = 3 Then
                            row.Item(column.Index) = frmSTEntregaRecep.dgvServTecnico.Rows.Item(i).Cells(column.Index).Value
                        ElseIf column.Index = 5 Then
                            row.Item(column.Index) = Format(CDate(frmSTEntregaRecep.dgvServTecnico.Rows.Item(i).Cells(column.Index).Value), "dd/MM/yyyy")
                        ElseIf column.Index = 13 Or column.Index = 14 Or column.Index = 17 Or column.Index = 21 Or column.Index = 22 Then
                            row.Item(column.Index - 1) = Format(CDate(frmSTEntregaRecep.dgvServTecnico.Rows.Item(i).Cells(column.Index).Value), "dd/MM/yyyy")
                        ElseIf column.Index = 15 Or column.Index = 20 Then
                            row.Item(column.Index - 1) = Format(frmSTEntregaRecep.dgvServTecnico.Rows.Item(i).Cells(column.Index).Value, "$ #,##0.00")
                        ElseIf column.Index = 16 Then
                            row.Item(column.Index - 1) = Format(frmSTEntregaRecep.dgvServTecnico.Rows.Item(i).Cells(column.Index).Value, "#,##0.00")
                        Else
                            row.Item(column.Index - 1) = frmSTEntregaRecep.dgvServTecnico.Rows.Item(i).Cells(column.Index).Value
                        End If
                    End If
                Next
            Next

            rptEntregaTerceros.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            rptEntregaTerceros.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\rptEntregaSTterc.rdlc"
            rptEntregaTerceros.LocalReport.DataSources.Clear()
            rptEntregaTerceros.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsEntregaSTterceros", _Ds.Tables("dtServTecnico")))
            rptEntregaTerceros.DocumentMapCollapsed = True
            Me.rptEntregaTerceros.RefreshReport()
        Catch ex As MySqlException
            MsgBox("Error al cargar stocks" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Hide()
    End Sub
End Class