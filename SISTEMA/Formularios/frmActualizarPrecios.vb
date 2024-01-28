Public Class frmActualizarPrecios

    Private Sub btnActualizar_GotFocus(sender As Object, e As EventArgs) Handles btnActualizar.GotFocus
        btnActualizar.BackgroundImage = ByB_SI.My.Resources.Emitir1Ac
    End Sub

    Private Sub btnActualizar_LostFocus(sender As Object, e As EventArgs) Handles btnActualizar.LostFocus
        btnActualizar.BackgroundImage = ByB_SI.My.Resources.Emitir1In
    End Sub

    Private Sub btnActualizar_MouseEnter(sender As Object, e As EventArgs) Handles btnActualizar.MouseEnter
        btnActualizar.BackgroundImage = ByB_SI.My.Resources.Emitir1Ac
    End Sub

    Private Sub btnActualizar_MouseLeave(sender As Object, e As EventArgs) Handles btnActualizar.MouseLeave
        btnActualizar.BackgroundImage = ByB_SI.My.Resources.Emitir1In
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
        Me.Hide()
    End Sub

    Private Sub frmActualizarPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtFecha.Text = Format(CDate(mdiFrmPpal.ulTfecTc), "dd/MM/yyyy")
            txtTC.Text = Format(CDbl(mdiFrmPpal.tpCb), "#,##0.00")
            txtTCAct.Text = Format(CDbl(mdiFrmPpal.tpCb), "#,##0.00")
            txtTCAct.SelectionLength = Len(txtTCAct.Text)
            txtTCAct.Select()

            Me.Text = "ACTUALIZAR PRECIOS SEGUN TIPO CAMBIO - " & mdiFrmPpal.encForm
        Catch ex As Exception
            MsgBox("Error: Problemas para cargar el formulario !", vbInformation, "Servicio de Alertas")
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim _Ver As New Mostrar
        Dim _Dt As New DataTable
        Dim _Guardar As New GrabaDatos
        Dim idArt As Integer = 0
        Dim precArt As Double = 0
        Dim precFinArt As Double = 0
        Dim ctDor As Integer = 0
        Dim avAnce As Double = 0
        Dim resP As String

        _Dt = _Ver.verArticulos(mdiFrmPpal.cdEmp)
        pbrActualizacion.Maximum = _Dt.Rows.Count
        pbrActualizacion.Value = 0

        resP = MessageBox.Show("Comienza proceso de actualización de precios ?", "Servico de Alertas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resP = Windows.Forms.DialogResult.Yes Then
            lblAvance.Text = "0 %"
            For Each Fila As DataRow In _Dt.Rows
                idArt = Fila.Item("idArticulos")
                precArt = CDbl(Fila.Item("PrecioU$S")) * CDbl(txtTCAct.Text)
                precFinArt = precArt + (precArt * CDbl(Fila.Item("AlicuotaIVA")))
                _Guardar.Grabar("Artículos", "NoImagen", "modPrecios", CInt(idArt), precArt, precFinArt)
                avAnce += 1
                lblAvance.Text = CStr(CInt(avAnce / _Dt.Rows.Count * 100)) & " %"
                lblAvance.Refresh()
                pbrActualizacion.Value = avAnce
            Next

            MsgBox("Fin de actualización de precions !", vbInformation)
        End If
    End Sub

    Private Sub txtTCAct_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTCAct.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnActualizar.Select()
        End If
    End Sub

    Private Sub txtTCAct_Validated(sender As Object, e As EventArgs) Handles txtTCAct.Validated
        If Not IsNumeric(txtTCAct.Text) Then
            MsgBox("Sólo datos numéricos !", vbInformation)
            txtTCAct.SelectionLength = Len(txtTCAct.Text)
            txtTCAct.Select()
        Else
            txtTCAct.Text = Format(CDbl(txtTCAct.Text), "$ #,##0.00")
        End If
    End Sub
End Class