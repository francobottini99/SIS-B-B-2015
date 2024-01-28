Public Class frmIngresoChequera
    Private Sub btnNuevo_GotFocus(sender As Object, e As EventArgs) Handles btnNuevo.GotFocus
        btnNuevo.BackgroundImage = ByB_SI.My.Resources.NuevoAc
    End Sub

    Private Sub btnNuevo_LostFocus(sender As Object, e As EventArgs) Handles btnNuevo.LostFocus
        btnNuevo.BackgroundImage = ByB_SI.My.Resources.NuevoIn
    End Sub

    Private Sub btnNuevo_MouseEnter(sender As Object, e As EventArgs) Handles btnNuevo.MouseEnter
        btnNuevo.BackgroundImage = ByB_SI.My.Resources.NuevoAc
    End Sub

    Private Sub btnNuevo_MouseLeave(sender As Object, e As EventArgs) Handles btnNuevo.MouseLeave
        btnNuevo.BackgroundImage = ByB_SI.My.Resources.NuevoIn
    End Sub

    Private Sub btnGuardar_GotFocus(sender As Object, e As EventArgs) Handles btnGuardar.GotFocus
        btnGuardar.BackgroundImage = ByB_SI.My.Resources.GuardarAc
    End Sub

    Private Sub btnGuardar_LostFocus(sender As Object, e As EventArgs) Handles btnGuardar.LostFocus
        btnGuardar.BackgroundImage = ByB_SI.My.Resources.GuardarIn
    End Sub

    Private Sub btnGuardar_MouseEnter(sender As Object, e As EventArgs) Handles btnGuardar.MouseEnter
        btnGuardar.BackgroundImage = ByB_SI.My.Resources.GuardarAc
    End Sub

    Private Sub btnGuardar_MouseLeave(sender As Object, e As EventArgs) Handles btnGuardar.MouseLeave
        btnGuardar.BackgroundImage = ByB_SI.My.Resources.GuardarIn
    End Sub

    Private Sub btnCancelar_GotFocus(sender As Object, e As EventArgs) Handles btnCancelar.GotFocus
        btnCancelar.BackgroundImage = ByB_SI.My.Resources.CancelarAc
    End Sub

    Private Sub btnCancelar_LostFocus(sender As Object, e As EventArgs) Handles btnCancelar.LostFocus
        btnCancelar.BackgroundImage = ByB_SI.My.Resources.CancelarIn
    End Sub

    Private Sub btnCancelar_MouseEnter(sender As Object, e As EventArgs) Handles btnCancelar.MouseEnter
        btnCancelar.BackgroundImage = ByB_SI.My.Resources.CancelarAc
    End Sub

    Private Sub btnCancelar_MouseLeave(sender As Object, e As EventArgs) Handles btnCancelar.MouseLeave
        btnCancelar.BackgroundImage = ByB_SI.My.Resources.CancelarIn
    End Sub

    Private Sub btnSalir_GotFocus(sender As Object, e As EventArgs) Handles btnSalir.GotFocus
        btnSalir.BackgroundImage = ByB_SI.My.Resources.SalirAc
    End Sub

    Private Sub btnSalir_LostFocus(sender As Object, e As EventArgs) Handles btnSalir.LostFocus
        btnSalir.BackgroundImage = ByB_SI.My.Resources.SalirIn
    End Sub

    Private Sub btnSalir_MouseEnter(sender As Object, e As EventArgs) Handles btnSalir.MouseEnter
        btnSalir.BackgroundImage = ByB_SI.My.Resources.SalirAc
    End Sub

    Private Sub btnSalir_MouseLeave(sender As Object, e As EventArgs) Handles btnSalir.MouseLeave
        btnSalir.BackgroundImage = ByB_SI.My.Resources.SalirIn
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Limpiar()
        Me.Hide()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnCancelar.Enabled = True
        btnGuardar.Enabled = True
        btnNuevo.Enabled = False
        gbxClientes.Enabled = True
        txtFecAlta.Text = Date.Now.Date
        txtSucursal.Text = "Berrotarán"
        txtTitular.Text = "Bottini Cristian - Bima Angela Belén"
        cbxBanco.Text = "Nación Argentina"
        txtCta.Text = "016300245/35"
        txtCantidad.Text = 0
        txtNroChq.Select()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        btnCancelar.Enabled = False
        btnGuardar.Enabled = False
        btnNuevo.Enabled = True
        gbxClientes.Enabled = False
        Limpiar()
    End Sub

    Private Sub Limpiar()
        txtFecAlta.Text = ""
        cbxBanco.Text = ""
        txtSucursal.Text = ""
        txtCta.Text = ""
        txtTitular.Text = ""
        txtNroChq.Text = ""
        txtCantidad.Text = ""
    End Sub

    Private Sub txtNroChq_Validated(sender As Object, e As EventArgs) Handles txtNroChq.Validated
        If IsNumeric(txtNroChq.Text) = False Then
            MsgBox("Error: Solo se permiten números !", vbInformation, "Servicio de Alertas")
            txtNroChq.SelectionLength = Len(txtNroChq.Text)
            txtNroChq.Select()
        End If
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged

    End Sub

    Private Sub txtCantidad_Validated(sender As Object, e As EventArgs) Handles txtCantidad.Validated
        If IsNumeric(txtCantidad.Text) = False Then
            MsgBox("Error: Solo se permiten números !", vbInformation, "Servicio de Alertas")
            txtCantidad.SelectionLength = Len(txtCantidad.Text)
            txtCantidad.Select()
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim resP As DialogResult
            resP = MessageBox.Show("Registra Nueva Chequera ?", "Servico de Alertas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If resP = Windows.Forms.DialogResult.Yes Then






            End If
        Catch ex As Exception
            MsgBox("Error: Chequera nueva No fue Registrada correctamente !" & vbCrLf & vbCrLf & ex.ToString, vbCritical, "Servicio de Alertas")
        End Try
    End Sub
End Class