Public Class frmImpServTecnico

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub btnSTEstado_Click(sender As Object, e As EventArgs) Handles btnSTEstado.Click
        frmInfConsServTecnico.lblOrigen.Text = "Estado"
        frmInfConsServTecnico.ShowDialog()
    End Sub

    Private Sub btnCtaCteDetallada_Click(sender As Object, e As EventArgs) Handles btnCtaCteDetallada.Click
        frmInfConsServTecnico.lblOrigen.Text = "Cliente"
        frmInfConsServTecnico.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmInfConsServTecnico.lblOrigen.Text = "Equipo"
        frmInfConsServTecnico.ShowDialog()
    End Sub

End Class