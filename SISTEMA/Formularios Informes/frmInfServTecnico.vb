Public Class frmInfServTecnico

    Private Sub frmInfStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim _Ds As New dsReportes

            'Agrego filas desde DGV
            Dim row As DataRow
            For i As Integer = 0 To frmServTecnico.dgvServTecnico.Rows.Count - 1
                row = _Ds.Tables("dtServTecnico").Rows.Add
                For Each column As DataGridViewColumn In frmServTecnico.dgvServTecnico.Columns
                    If column.Index = 5 Or column.Index = 12 Or column.Index = 13 Or column.Index = 16 Or column.Index = 20 Or column.Index = 21 Then
                        row.Item(column.Index) = Format(CDate(frmServTecnico.dgvServTecnico.Rows.Item(i).Cells(column.Index).Value), "dd/MM/yyyy")
                    ElseIf column.Index = 14 Then
                        row.Item(column.Index) = Format(frmServTecnico.dgvServTecnico.Rows.Item(i).Cells(column.Index).Value, "$ #,##0.00")
                    ElseIf column.Index = 15 Then
                        row.Item(column.Index) = Format(frmServTecnico.dgvServTecnico.Rows.Item(i).Cells(column.Index).Value, "#,##0.00")
                    Else
                        row.Item(column.Index) = frmServTecnico.dgvServTecnico.Rows.Item(i).Cells(column.Index).Value
                    End If
                    row.Item(26) = frmServTecnico.txtCliente.Text
                    row.Item(25) = frmServTecnico.txtTE.Text
                Next
            Next

            rptServicioTecnico.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            rptServicioTecnico.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\rptServTecnico.rdlc"
            rptServicioTecnico.LocalReport.DataSources.Clear()
            rptServicioTecnico.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsServTecnico", _Ds.Tables("dtServTecnico")))
            rptServicioTecnico.DocumentMapCollapsed = True
            Me.rptServicioTecnico.RefreshReport()
        Catch ex As MySqlException
            MsgBox("Error al cargar stocks" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Hide()
    End Sub
End Class