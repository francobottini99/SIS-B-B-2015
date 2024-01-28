Imports MySql.Data.MySqlClient

Public Class frmArtCategorias

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim _Guardar As New GrabaDatos
        Dim resP As DialogResult
        resP = MessageBox.Show("Grabar Categoría?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        Try
            If resP = Windows.Forms.DialogResult.OK Then
                If txtCodRubro.Text = "" Or txtCodSubRubro.Text = "" Or txtCodCategoria.Text = "" Or txtRubro.Text = "" Or txtSubrubro.Text = "" Or txtCategoria.Text = "" Then
                    MsgBox("Error: Verifique que todos los items tengan su dato correspondiente.", vbInformation, "Servico de Alertas")
                    txtCodRubro.Select()
                Else
                    If lblFuncion.Text = "Nuevo" Then
                        _Guardar.Grabar("Categoria", "Imagen", "insCategoria", txtCodRubro.Text, txtCodSubRubro.Text, txtCodCategoria.Text, _
                                        txtRubro.Text, txtSubrubro.Text, txtCategoria.Text, txtCodResumen.Text, mdiFrmPpal.usSis)
                        lblMsg.ForeColor = Color.LawnGreen
                        lblMsg.Text = "Categoría Ingresada Exitosamente"
                        lblMsg.Visible = True
                        tmrMensaje.Enabled = True
                    Else
                        _Guardar.Grabar("Categoria", "Imagen", "modCategoria", CInt(lblIdUs.Text), txtCodRubro.Text, txtCodSubRubro.Text, _
                                        txtCodCategoria.Text, txtRubro.Text, txtSubrubro.Text, txtCategoria.Text, txtCodResumen.Text, mdiFrmPpal.usSis)
                        lblMsg.ForeColor = Color.LawnGreen
                        lblMsg.Text = "Categoría Modificada Exitosamente"
                        lblMsg.Visible = True
                        tmrMensaje.Enabled = True
                    End If

                    'Actualizo el DataGridView
                    Dim _Ver As New Mostrar
                    Dim _Dt As New DataTable
                    _Dt = _Ver.verCategorias()

                    dgvCategorias.DataSource = _Dt

                    btnNuevo.Enabled = True
                    btnModificar.Enabled = True
                    btnCancelar.Enabled = False
                    btnGuardar.Enabled = False
                    Limpiar()
                    btnNuevo.Select()
                End If
            End If
        Catch ex As MySqlException
            lblMsg.ForeColor = Color.Red
            lblMsg.Text = "Error: Categoría no se ingreso y/o modifico correctamente."
            lblMsg.Visible = True
            tmrMensaje.Enabled = True
            MsgBox("Error: Categoría no modificada !" & vbCrLf & vbCrLf & ex.ToString, vbCritical, "Servicio de Alertas")
        Finally
            BDxxx()
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            gbxCategorias.Enabled = True
            lblIdUs.Text = dgvCategorias.SelectedCells.Item(0).Value
            txtCodRubro.Text = dgvCategorias.SelectedCells.Item(1).Value
            txtCodSubRubro.Text = dgvCategorias.SelectedCells.Item(2).Value
            txtCodCategoria.Text = dgvCategorias.SelectedCells.Item(3).Value
            txtRubro.Text = dgvCategorias.SelectedCells.Item(4).Value
            txtSubrubro.Text = dgvCategorias.SelectedCells.Item(5).Value
            txtCategoria.Text = dgvCategorias.SelectedCells.Item(6).Value
            txtCodResumen.Text = dgvCategorias.SelectedCells.Item(7).Value

            btnNuevo.Enabled = False
            btnModificar.Enabled = False
            btnCancelar.Enabled = True
            btnGuardar.Enabled = True
            lblFuncion.Text = "Modificar"
            txtCodRubro.Select()
        Catch ex As Exception
            MsgBox("Error al modificar la Categoría !" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
        End Try
    End Sub

    Private Sub tmrMensaje_Tick(sender As Object, e As EventArgs) Handles tmrMensaje.Tick
        lblMsg.Visible = False
        tmrMensaje.Enabled = False
    End Sub

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

    Private Sub btnModificar_GotFocus(sender As Object, e As EventArgs) Handles btnModificar.GotFocus
        btnModificar.BackgroundImage = ByB_SI.My.Resources.ModifAc
    End Sub

    Private Sub btnModificar_LostFocus(sender As Object, e As EventArgs) Handles btnModificar.LostFocus
        btnModificar.BackgroundImage = ByB_SI.My.Resources.ModifIn
    End Sub
    Private Sub btnModificar_MouseEnter(sender As Object, e As EventArgs) Handles btnModificar.MouseEnter
        btnModificar.BackgroundImage = ByB_SI.My.Resources.ModifAc
    End Sub

    Private Sub btnModificar_MouseLeave(sender As Object, e As EventArgs) Handles btnModificar.MouseLeave
        btnModificar.BackgroundImage = ByB_SI.My.Resources.ModifIn
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        btnModificar.Enabled = True
        btnCancelar.Enabled = False
        btnGuardar.Enabled = False
        btnNuevo.Enabled = True
        gbxCategorias.Enabled = False
        Limpiar()
        btnNuevo.Select()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        gbxCategorias.Enabled = True
        btnModificar.Enabled = False
        btnCancelar.Enabled = True
        btnGuardar.Enabled = True
        btnNuevo.Enabled = False
        lblFuncion.Text = "Nuevo"
        Limpiar()
        txtCodRubro.Select()
    End Sub

    Private Sub Limpiar()
        txtCodRubro.Text = ""
        txtCodSubRubro.Text = ""
        txtCodCategoria.Text = ""
        txtRubro.Text = ""
        txtSubrubro.Text = ""
        txtCategoria.Text = ""
        txtCodResumen.Text = ""
    End Sub

    Private Sub frmArtCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim _Ver As New Mostrar
            Dim _Dt As New DataTable

            _Dt = _Ver.verCategorias()
            dgvCategorias.DataSource = _Dt

            Dim estiloEnc As New DataGridViewCellStyle()
            Dim textEnc As String = ""
            Dim X As Integer

            estiloEnc.Font = New Font(dgvCategorias.Font, FontStyle.Bold)
            dgvCategorias.ColumnHeadersDefaultCellStyle = estiloEnc
            dgvCategorias.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            For X = 0 To 7
                If X = 0 Or X = 1 Or X = 2 Or X = 3 Or X = 7 Then
                    dgvCategorias.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Else
                    dgvCategorias.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                End If
                Select Case X
                    Case 0
                        textEnc = "ID"
                    Case 1
                        textEnc = "COD RUBRO"
                    Case 2
                        textEnc = "COD SUBRUB"
                    Case 3
                        textEnc = "COD CATEG"
                    Case 4
                        textEnc = "RUBRO"
                    Case 5
                        textEnc = "SUBRUBRO"
                    Case 6
                        textEnc = "CATEGORIA"
                    Case 7
                        textEnc = "COD RESUMEN"
                End Select
                dgvCategorias.Columns(X).HeaderText = textEnc
            Next

            Me.Text = "CATEGORIAS - " & mdiFrmPpal.encForm
            btnNuevo.Select()
        Catch ex As Exception
            MsgBox("No se puede mostrar las Categorías !", vbInformation)
        End Try

    End Sub

    Private Sub txtCodRubro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodRubro.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtRubro.SelectionLength = Len(txtRubro.Text)
            txtRubro.Select()
        End If
    End Sub

    Private Sub txtCodRubro_Validated(sender As Object, e As EventArgs) Handles txtCodRubro.Validated
        txtCodRubro.Text = UCase(txtCodRubro.Text)
        txtCodResumen.Text = txtCodRubro.Text & "." & txtCodSubRubro.Text & "." & txtCodCategoria.Text
    End Sub

    Private Sub txtCodSubRubro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodSubRubro.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtSubrubro.SelectionLength = Len(txtSubrubro.Text)
            txtSubrubro.Select()
        End If
    End Sub

    Private Sub txtCodSubRubro_Validated(sender As Object, e As EventArgs) Handles txtCodSubRubro.Validated
        txtCodSubRubro.Text = UCase(txtCodSubRubro.Text)
        txtCodResumen.Text = txtCodRubro.Text & "." & txtCodSubRubro.Text & "." & txtCodCategoria.Text
    End Sub

    Private Sub txtCodCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodCategoria.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCategoria.SelectionLength = Len(txtCategoria.Text)
            txtCategoria.Select()
        End If
    End Sub

    Private Sub txtCodCategoria_Validated(sender As Object, e As EventArgs) Handles txtCodCategoria.Validated
        txtCodCategoria.Text = UCase(txtCodCategoria.Text)
        txtCodResumen.Text = txtCodRubro.Text & "." & txtCodSubRubro.Text & "." & txtCodCategoria.Text
    End Sub

    Private Sub txtRubro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRubro.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCodSubRubro.SelectionLength = Len(txtCodSubRubro.Text)
            txtCodSubRubro.Select()
        End If
    End Sub

    Private Sub txtSubrubro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSubrubro.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCodCategoria.SelectionLength = Len(txtCodCategoria.Text)
            txtCodCategoria.Select()
        End If
    End Sub

    Private Sub txtCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCategoria.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnGuardar.Select()
        End If
    End Sub

    Private Sub dgvCategorias_DoubleClick1(sender As Object, e As EventArgs) Handles dgvCategorias.DoubleClick
        If lblOrigen.Text = "Articulos" Then
            frmArticulos.txtCodCategoria.Text = dgvCategorias.SelectedCells.Item(7).Value
            frmArticulos.txtIdCategoria.Text = dgvCategorias.SelectedCells.Item(0).Value
            Me.Hide()
        End If
    End Sub
End Class