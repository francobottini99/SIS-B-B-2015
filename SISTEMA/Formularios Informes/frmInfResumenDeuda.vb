Public Class frmInfResumenDeuda

    Private Sub frmInfResumenDeuda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Text = "INFORME DE DEUDAS PENDIENTES DE COBRAR - " & mdiFrmPpal.encForm

            Dim _Ds As New dsReportes

            'Agrego filas desde DGV
            Dim row As DataRow
            For i As Integer = 0 To frmResumenDeuda.dgvResumen.Rows.Count - 1
                row = _Ds.Tables("dtResumenDeuda").Rows.Add
                row.Item("idResumenDeuda") = frmResumenDeuda.dgvResumen.Rows.Item(i).Cells("idResumenDeuda").Value
                row.Item("NroCta") = Format(frmResumenDeuda.dgvResumen.Rows.Item(i).Cells("NroCta").Value, "##0")
                row.Item("RazonSocial") = frmResumenDeuda.dgvResumen.Rows.Item(i).Cells("RazonSocial").Value
                row.Item("Direccion") = frmResumenDeuda.dgvResumen.Rows.Item(i).Cells("Direccion").Value
                row.Item("Localidad") = frmResumenDeuda.dgvResumen.Rows.Item(i).Cells("Localidad").Value
                row.Item("TE") = frmResumenDeuda.dgvResumen.Rows.Item(i).Cells("TE").Value
                row.Item("UltimoMov") = Format(CDate(frmResumenDeuda.dgvResumen.Rows.Item(i).Cells("UltimoMov").Value), "dd/MM/yyyy")
                row.Item("Comprobante") = frmResumenDeuda.dgvResumen.Rows.Item(i).Cells("Comprobante").Value
                row.Item("SaldoCta") = Format(CDbl(frmResumenDeuda.dgvResumen.Rows.Item(i).Cells("SaldoCta").Value), "$ #,##0.00")
                row.Item("Total") = Format(CDbl(frmResumenDeuda.txtTotalDeuda.Text), "$ #,##0.00")
            Next

            rptResD.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            rptResD.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\rptConsDeudaPte.rdlc"
            rptResD.LocalReport.DataSources.Clear()
            rptResD.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsConsDeudaPte", _Ds.Tables("dtResumenDeuda")))
            rptResD.DocumentMapCollapsed = True
            Me.rptResD.RefreshReport()
        Catch ex As MySqlException
            MsgBox("Error al cargar el informe" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
        End Try

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Hide()
    End Sub
End Class