Public Class frmInfSTEntregaAClietne

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Hide()
    End Sub

    Private Sub frmInfSTEntregaAClietne_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Text = "EMISION DE TIKET ENTREGA DE EQUIPOS - " & mdiFrmPpal.encForm
            Dim _Ds As New dsReportes

            'Agrego filas desde DGV
            Dim Filas As DataRow
            Filas = _Ds.Tables("dtServTecnicoTodo").Rows.Add
            Filas.Item("Clientes_idClientes") = frmSTGarantiayOtros.txtIdCliente.Text
            Filas.Item("CliRazonSocial") = frmSTGarantiayOtros.txtCliente.Text
            Filas.Item("TipoEquipo") = frmSTGarantiayOtros.cbxTipoEq.Text
            Filas.Item("DetalleEquipo") = frmSTGarantiayOtros.txtDescripcion.Text
            Filas.Item("AccesoriosEquipo") = frmSTGarantiayOtros.txtAccesorios.Text
            Filas.Item("Problema") = frmSTGarantiayOtros.txtProblema.Text
            Filas.Item("Diagnostico") = frmSTGarantiayOtros.txtDiagnostico.Text
            Filas.Item("GarantiaMeses") = Format(CInt(frmSTGarantiayOtros.txtGarantia.Text), "#,##0")
            Filas.Item("VtoGarantia") = Format(CDate(frmSTGarantiayOtros.txtVtoGar.Text), "dd/MM/yyyy")

            rptST.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            rptST.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\rptEmisionTiketEntrega.rdlc"
            rptST.LocalReport.DataSources.Clear()
            rptST.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsTiketEntrega", _Ds.Tables("dtServTecnicoTodo")))
            rptST.DocumentMapCollapsed = True
            Me.rptST.RefreshReport()

        Catch ex As MySqlException
            MsgBox("Error al cargar el informe" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
        End Try
    End Sub
End Class