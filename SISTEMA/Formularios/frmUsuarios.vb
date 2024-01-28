Imports MySql.Data.MySqlClient

Public Class frmUsuarios
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim _Guardar As New GrabaDatos
        Dim resP As DialogResult
        resP = MessageBox.Show("Grabar Datos del Usuario?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        Try
            If resP = Windows.Forms.DialogResult.OK Then
                If txtNombre.Text = "" Or cbxCategoria.Text = "" Or txtContraseña.Text = "" Then
                    MsgBox("Error: Verifique que todos los items tengan su dato correspondiente.", vbInformation, "Servico de Alertas")
                    txtNombre.Select()
                Else
                    If txtContraseña.Text <> txtReContrseña.Text Then
                        MsgBox("Error: Verifique contraseña ingresada, no coinciden.", vbInformation, "Servico de Alertas")
                        txtContraseña.Select()
                    Else
                        Dim _haB As Integer
                        If chbHabilitacion.CheckState = CheckState.Checked Then
                            _haB = 1
                        Else
                            _haB = 0
                        End If
                        If cbxRemoto.Text = "No" Then
                            txtMneuHab.Text = "-"
                        End If
                        If lblFuncion.Text = "Nuevo" Then
                            _Guardar.Grabar("Usuarios", "NoImagen", "insUsuario", txtNombre.Text, cbxCategoria.Text, _
                                            txtContraseña.Text, _haB, cbxRemoto.Text, txtMneuHab.Text)
                            lblMsg.ForeColor = Color.LawnGreen
                            lblMsg.Text = "Usuario Ingresado Exitosamente"
                            lblMsg.Visible = True
                            tmrMensaje.Enabled = True
                        Else
                            _Guardar.Grabar("Usuarios", "NoImagen", "modUsuario", lblIdUs.Text, txtNombre.Text, _
                                            cbxCategoria.Text, txtContraseña.Text, _haB, cbxRemoto.Text, txtMneuHab.Text)
                            lblMsg.ForeColor = Color.LawnGreen
                            lblMsg.Text = "Usuario Modificado Exitosamente"
                            lblMsg.Visible = True
                            tmrMensaje.Enabled = True
                        End If

                        'Actualizo el DataGridView
                        Dim _Ver As New Mostrar
                        Dim _Dt As New DataTable
                        _Dt = _Ver.verUsuarios()
                        dgvUsuarios.DataSource = _Dt

                        Limpiar()
                        btnNuevo.Enabled = True
                        btnModificar.Enabled = True
                        btnCancelar.Enabled = False
                        btnGuardar.Enabled = False
                        gbxUsuarios.Enabled = False
                        btnNuevo.Select()
                    End If
                End If
            End If
        Catch ex As MySqlException
            lblMsg.ForeColor = Color.Red
            lblMsg.Text = "Error: Usuario no ingresado y/o modificado."
            lblMsg.Visible = True
            tmrMensaje.Enabled = True
            MsgBox(ex.ToString)
        Finally
            BDxxx()
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
    End Sub

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim _Ver As New Mostrar
            Dim _Dt As New DataTable

            _Dt = _Ver.verUsuarios()

            dgvUsuarios.DataSource = _Dt
            dgvUsuarios.Columns.Item("Contraseña").Visible = False

            If _Dt.Rows.Count <> 0 Then
                btnEliminar.Enabled = True
            Else
                btnEliminar.Enabled = False
            End If
            Me.Text = "USUARIOS - " & mdiFrmPpal.encForm
        Catch ex As Exception
            MsgBox("No se puede mostrar Usuarios !", vbInformation)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            lblIdUs.Text = dgvUsuarios.SelectedCells.Item(1).Value
            txtNombre.Text = dgvUsuarios.SelectedCells.Item(2).Value
            cbxCategoria.Text = dgvUsuarios.SelectedCells.Item(3).Value
            txtContraseña.Text = dgvUsuarios.SelectedCells.Item(4).Value
            txtReContrseña.Text = dgvUsuarios.SelectedCells.Item(4).Value
            If dgvUsuarios.SelectedCells.Item(5).Value = 0 Then
                chbHabilitacion.CheckState = CheckState.Unchecked
            Else
                chbHabilitacion.CheckState = CheckState.Checked
            End If
            txtReContrseña.Text = dgvUsuarios.SelectedCells.Item(6).Value
            txtReContrseña.Text = dgvUsuarios.SelectedCells.Item(7).Value
            btnNuevo.Enabled = False
            btnModificar.Enabled = False
            btnCancelar.Enabled = True
            btnGuardar.Enabled = True
            gbxUsuarios.Enabled = True
            txtNombre.Select()
            lblFuncion.Text = "Modificar"
        Catch ex As Exception
            btnNuevo.Enabled = False
            btnModificar.Enabled = False
            btnCancelar.Enabled = True
            btnGuardar.Enabled = True
            txtNombre.Select()
            lblFuncion.Text = "Modificar"
            MsgBox("Error al modificar Usuario !" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
        End Try
    End Sub

    Private Sub tmrMensaje_Tick(sender As Object, e As EventArgs) Handles tmrMensaje.Tick
        lblMsg.Visible = False
        tmrMensaje.Enabled = False
    End Sub

    Private Sub Limpiar()
        txtNombre.Text = ""
        cbxCategoria.Text = ""
        txtContraseña.Text = ""
        txtReContrseña.Text = ""
        chbHabilitacion.CheckState = CheckState.Unchecked
        cbxRemoto.Text = ""
        txtMneuHab.Text = ""
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

    Private Sub btnEliminar_GotFocus(sender As Object, e As EventArgs) Handles btnEliminar.GotFocus
        btnEliminar.BackgroundImage = ByB_SI.My.Resources.EliminarAc
    End Sub

    Private Sub btnEliminar_LostFocus(sender As Object, e As EventArgs) Handles btnEliminar.LostFocus
        btnEliminar.BackgroundImage = ByB_SI.My.Resources.EliminarIn
    End Sub

    Private Sub btnEliminar_MouseEnter(sender As Object, e As EventArgs) Handles btnEliminar.MouseEnter
        btnEliminar.BackgroundImage = ByB_SI.My.Resources.EliminarAc
    End Sub

    Private Sub btnEliminar_MouseLeave(sender As Object, e As EventArgs) Handles btnEliminar.MouseLeave
        btnEliminar.BackgroundImage = ByB_SI.My.Resources.EliminarIn
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpiar()
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnCancelar.Enabled = True
        btnGuardar.Enabled = True
        gbxUsuarios.Enabled = True
        txtNombre.Select()
        lblFuncion.Text = "Nuevo"
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Limpiar()
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnCancelar.Enabled = False
        btnGuardar.Enabled = False
        gbxUsuarios.Enabled = False
        btnNuevo.Select()
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            cbxCategoria.SelectionLength = Len(cbxCategoria.Text)
            cbxCategoria.Select()
        End If
    End Sub

    Private Sub cbxCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCategoria.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtContraseña.SelectionLength = Len(txtContraseña.Text)
            txtContraseña.Select()
        End If
    End Sub

    Private Sub txtContraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContraseña.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtReContrseña.SelectionLength = Len(txtReContrseña.Text)
            txtReContrseña.Select()
        End If
    End Sub

    Private Sub txtReContrseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReContrseña.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            cbxRemoto.SelectionLength = Len(cbxRemoto.Text)
            cbxRemoto.Select()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim resP As DialogResult
        Dim _Elim As New GrabaDatos

        resP = MessageBox.Show("Elimar Usuarios Seleccionados!?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If resP = Windows.Forms.DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dgvUsuarios.Rows
                    Dim seL As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If seL Then
                        Dim clElim As Integer = Convert.ToInt32(row.Cells("IdUsuarios").Value)
                        _Elim.Grabar("Usuarios", "NoImagen", "eliUsuario", clElim)
                    End If
                Next

                'Actualizo el datagridview
                Dim _mAut As New Mostrar
                Dim _dT As New DataTable

                _dT = _mAut.verUsuarios()

                If _dT.Rows.Count <> 0 Then
                    dgvUsuarios.DataSource = _dT
                    dgvUsuarios.ColumnHeadersVisible = True
                Else
                    dgvUsuarios.DataSource = Nothing
                    dgvUsuarios.ColumnHeadersVisible = False
                    btnEliminar.Enabled = False
                End If
            Catch ex As Exception
                MsgBox("Error al Eliminar Usuarios !" & vbCrLf & vbCrLf & ex.ToString, vbCritical, "Servicio de Alertas")
            End Try
        End If
    End Sub

    Private Sub dgvUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.ColumnIndex = Me.dgvUsuarios.Columns.Item("Eliminar").Index Then
            Dim celSel As DataGridViewCheckBoxCell = Me.dgvUsuarios.Rows(e.RowIndex).Cells("Eliminar")
            celSel.Value = Not celSel.Value
        End If
    End Sub

    Private Sub cbxRemoto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxRemoto.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtMneuHab.SelectionLength = Len(txtMneuHab.Text)
            txtMneuHab.Select()
        End If
    End Sub

    Private Sub txtMneuHab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMneuHab.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnGuardar.Select()
        End If
    End Sub

End Class