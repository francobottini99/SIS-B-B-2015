Public Class frmImpCtaCteVta

    Private Sub btnImpFactura_Click(sender As Object, e As EventArgs) Handles btnImpFactura.Click
        Dim _Guardar As New GrabaDatos
        Try
            If frmCtaCteVenta.dgvComp.RowCount > 0 Or frmCtaCteVenta.dgvRecibos.RowCount > 0 Then
                frmInfFacturaVenta.lblOrigen.Text = "Cta Cte Venta"
                frmInfFacturaVenta.lblTipo.Text = frmCtaCteVenta.dgvCtaCteMostrar.SelectedCells.Item(4).Value
                _Guardar.Grabar("Reimpresion", "NoImagen", "modFacturaVtaReimpresion", CInt(frmCtaCteVenta.dgvComp.SelectedCells.Item(0).Value), _
                                "Si", Format(CDate(Date.Now.Date), "yyyy/MM/dd"))
                frmInfFacturaVenta.ShowDialog()
            Else
                MsgBox("Error: Sin comprobates para imprimir !", vbInformation, "Servicio de Alertas")
            End If
        Catch ex As Exception
            MsgBox("Error: No se puden mostrar los datos para imprimir !", vbInformation, "Servicio de Alertas")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub btnCtaCteDetallada_Click(sender As Object, e As EventArgs) Handles btnCtaCteDetallada.Click
        frmInfCtaCteVtaDetalle.ShowDialog()
    End Sub

    Private Sub btnCtaCteResumida_Click(sender As Object, e As EventArgs) Handles btnCtaCteResumida.Click
        frmInfCtaCteVta.ShowDialog()
    End Sub
End Class