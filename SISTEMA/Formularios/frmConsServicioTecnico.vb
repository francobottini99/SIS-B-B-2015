Public Class frmConsServicioTecnico

    Private Sub btnLimpiar_GotFocus(sender As Object, e As EventArgs) Handles btnLimpiar.GotFocus
        btnLimpiar.BackgroundImage = ByB_SI.My.Resources.CancelarAc
    End Sub

    Private Sub btnLimpiar_LostFocus(sender As Object, e As EventArgs) Handles btnLimpiar.LostFocus
        btnLimpiar.BackgroundImage = ByB_SI.My.Resources.CancelarIn
    End Sub

    Private Sub btnLimpiar_MouseEnter(sender As Object, e As EventArgs) Handles btnLimpiar.MouseEnter
        btnLimpiar.BackgroundImage = ByB_SI.My.Resources.CancelarAc
    End Sub

    Private Sub btnLimpiar_MouseLeave(sender As Object, e As EventArgs) Handles btnLimpiar.MouseLeave
        btnLimpiar.BackgroundImage = ByB_SI.My.Resources.CancelarIn
    End Sub

    Private Sub btnImpComprobante_GotFocus(sender As Object, e As EventArgs) Handles btnImpComprobante.GotFocus
        btnImpComprobante.BackgroundImage = ByB_SI.My.Resources.ImpresoraAc
    End Sub

    Private Sub btnImpComprobante_LostFocus(sender As Object, e As EventArgs) Handles btnImpComprobante.LostFocus
        btnImpComprobante.BackgroundImage = ByB_SI.My.Resources.ImpresoraIn
    End Sub

    Private Sub btnImpComprobante_MouseEnter(sender As Object, e As EventArgs) Handles btnImpComprobante.MouseEnter
        btnImpComprobante.BackgroundImage = ByB_SI.My.Resources.ImpresoraAc
    End Sub

    Private Sub btnImpComprobante_MouseLeave(sender As Object, e As EventArgs) Handles btnImpComprobante.MouseLeave
        btnImpComprobante.BackgroundImage = ByB_SI.My.Resources.ImpresoraIn
    End Sub

    Private Sub btnBuscar_GotFocus(sender As Object, e As EventArgs) Handles btnBuscar.GotFocus
        btnBuscar.BackgroundImage = ByB_SI.My.Resources.ConsultaAc
    End Sub

    Private Sub btnBuscar_LostFocus(sender As Object, e As EventArgs) Handles btnBuscar.LostFocus
        btnBuscar.BackgroundImage = ByB_SI.My.Resources.ConsultaIn
    End Sub

    Private Sub btnBuscar_MouseEnter(sender As Object, e As EventArgs) Handles btnBuscar.MouseEnter
        btnBuscar.BackgroundImage = ByB_SI.My.Resources.ConsultaAc
    End Sub

    Private Sub btnBuscar_MouseLeave(sender As Object, e As EventArgs) Handles btnBuscar.MouseLeave
        btnBuscar.BackgroundImage = ByB_SI.My.Resources.ConsultaIn
    End Sub

    Private Sub btnTodo_GotFocus(sender As Object, e As EventArgs) Handles btnTodo.GotFocus
        btnTodo.BackgroundImage = ByB_SI.My.Resources.TodosArtAc
    End Sub

    Private Sub btnTodo_LostFocus(sender As Object, e As EventArgs) Handles btnTodo.LostFocus
        btnTodo.BackgroundImage = ByB_SI.My.Resources.TodosArtIn
    End Sub

    Private Sub btnTodo_MouseEnter(sender As Object, e As EventArgs) Handles btnTodo.MouseEnter
        btnTodo.BackgroundImage = ByB_SI.My.Resources.TodosArtAc
    End Sub

    Private Sub btnTodo_MouseLeave(sender As Object, e As EventArgs) Handles btnTodo.MouseLeave
        btnTodo.BackgroundImage = ByB_SI.My.Resources.TodosArtIn
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

    Private Sub frmConsServicioTecnico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim _Ver As New Mostrar
            Dim _Dt, _DtTodo As New DataTable

            _DtTodo = _Ver.verServicioTecnicoTodo(mdiFrmPpal.cdEmp)
            dgvServTecnico.DataSource = _DtTodo
            lblReg.Text = Format(_DtTodo.Rows.Count, "#,##0")
            dgvServTecnico.Columns.Item("idServicioTecnico").Visible = False
            dgvServTecnico.Columns.Item("CodUN").Visible = False
            dgvServTecnico.Columns.Item("CodBarra").Visible = False
            dgvServTecnico.Columns.Item("Clientes_IdClientes").Visible = False
            dgvServTecnico.Columns.Item("Proveedores_IdProveedores").Visible = False

            Me.Text = "CONSULTA GENERAL DE SERVICIO TECNICO - " & mdiFrmPpal.encForm
        Catch ex As Exception
            MsgBox("No se puede mostrar Servico Técnico !", vbInformation)
        End Try

    End Sub

    Private Sub dgvServTecnico_DoubleClick(sender As Object, e As EventArgs) Handles dgvServTecnico.DoubleClick
        frmServTecnicoResumen.lblOrigen.Text = "Consulta Servico Tecnico"
        frmServTecnicoResumen.ShowDialog()
    End Sub

    Private Sub btnImpComprobante_Click(sender As Object, e As EventArgs) Handles btnImpComprobante.Click
        frmImpServTecnico.ShowDialog()
    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
    End Sub

    Private Sub btnTodo_Click(sender As Object, e As EventArgs) Handles btnTodo.Click
        Try
            Dim _Ver As New Mostrar
            Dim _DtTodo As New DataTable

            _DtTodo = _Ver.verServicioTecnicoTodo(mdiFrmPpal.cdEmp)
            dgvServTecnico.DataSource = _DtTodo
            Limpiar()
            lblReg.Text = Format(_DtTodo.Rows.Count, "#,##0")
        Catch ex As Exception
            MsgBox("Error: Problemas con la consulta de Servicio Técnico !", vbInformation)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim _Ver As New Mostrar
            Dim _Ds As New DataSet
            _Ds.Tables.Add(_Ver.verServicioTecnicoTodo(mdiFrmPpal.cdEmp).Copy)
            Dim _Dv As New DataView(_Ds.Tables(0))

            If txtBuscCliente.Text = "" And cbxTercerizado.Text = "" And cbxEstado.Text = "" And txtBuscCdBarra.Text = "" And cbxBuscTEq.Text = "" And txtBuscDescripcion.Text = "" And txtBuscProblema.Text = "" Then
                MsgBox("Debe ingresar al menos un dato de búsqueda !", vbInformation)
            ElseIf txtBuscCliente.Text <> "" And cbxTercerizado.Text = "" And cbxEstado.Text = "" And txtBuscCdBarra.Text = "" And cbxBuscTEq.Text = "" And txtBuscDescripcion.Text = "" And txtBuscProblema.Text = "" Then
                If IsNumeric(txtBuscCliente.Text) Then
                    _Dv.RowFilter = "Clientes_IdClientes = " & CInt(txtBuscCliente.Text)
                Else
                    MsgBox("Error: Solo se admiten números !", vbInformation, "Servicio de Alertas")
                    txtBuscCliente.Text = ""
                    txtBuscCliente.Select()
                End If
            ElseIf txtBuscCliente.Text = "" And cbxTercerizado.Text <> "" And cbxEstado.Text = "" And txtBuscCdBarra.Text = "" And cbxBuscTEq.Text = "" And txtBuscDescripcion.Text = "" And txtBuscProblema.Text = "" Then
                _Dv.RowFilter = "Tercerizado Like '%" & cbxTercerizado.Text & "%'"
            ElseIf txtBuscCliente.Text = "" And cbxTercerizado.Text = "" And cbxEstado.Text <> "" And txtBuscCdBarra.Text = "" And cbxBuscTEq.Text = "" And txtBuscDescripcion.Text = "" And txtBuscProblema.Text = "" Then
                _Dv.RowFilter = "Estado Like '%" & cbxEstado.Text & "%'"
            ElseIf txtBuscCliente.Text = "" And cbxTercerizado.Text = "" And cbxEstado.Text = "" And txtBuscCdBarra.Text <> "" And cbxBuscTEq.Text = "" And txtBuscDescripcion.Text = "" And txtBuscProblema.Text = "" Then
                _Dv.RowFilter = "CodBarra Like '%" & Mid(txtBuscCdBarra.Text, 5, 8) & "%'"
            ElseIf txtBuscCliente.Text = "" And cbxTercerizado.Text = "" And cbxEstado.Text = "" And txtBuscCdBarra.Text = "" And cbxBuscTEq.Text <> "" And txtBuscDescripcion.Text = "" And txtBuscProblema.Text = "" Then
                _Dv.RowFilter = "TipoEquipo Like '%" & cbxBuscTEq.Text & "%'"
            ElseIf txtBuscCliente.Text = "" And cbxTercerizado.Text = "" And cbxEstado.Text = "" And txtBuscCdBarra.Text = "" And cbxBuscTEq.Text = "" And txtBuscDescripcion.Text <> "" And txtBuscProblema.Text = "" Then
                _Dv.RowFilter = "DetalleEquipo Like '%" & txtBuscDescripcion.Text & "%'"
            ElseIf txtBuscCliente.Text = "" And cbxTercerizado.Text = "" And cbxEstado.Text = "" And txtBuscCdBarra.Text = "" And cbxBuscTEq.Text = "" And txtBuscDescripcion.Text = "" And txtBuscProblema.Text <> "" Then
                _Dv.RowFilter = "Problema Like '%" & txtBuscProblema.Text & "%'"
            Else
                MsgBox("Sólo se permite un dato de búsqueda !", vbInformation)
            End If

            lblReg.Text = Format(_Dv.Count, "#,##0")

            If _Dv.Count <> 0 Then
                dgvServTecnico.DataSource = _Dv
            Else
                dgvServTecnico.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox("Error: Problemas con la consulta de Servicio Técnico !", vbInformation)
        End Try
    End Sub

    Private Sub txtBuscCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscCliente.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                If txtBuscCliente.Text = "" Then
                    e.Handled = True
                    frmClientes.lblOrigen.Text = "Servicio Tecnico Consultas"
                    frmClientes.txtBuscar.Select()
                    frmClientes.ShowDialog()
                Else
                    e.Handled = True
                    If IsNumeric(txtBuscCliente.Text) Then
                        Dim _Ver As New Mostrar
                        Dim _Ds As New DataSet
                        _Ds.Tables.Add(_Ver.verClientes(mdiFrmPpal.cdEmp).Copy)
                        Dim _Dv As New DataView(_Ds.Tables(0))
                        _Dv.RowFilter = "IdClientes = " & CInt(txtBuscCliente.Text)
                        If _Dv.Count <> 0 Then
                            dgvCliente.DataSource = _Dv
                            dgvCliente.Select()
                            txtCliente.Text = dgvCliente.SelectedCells.Item(4).Value
                            btnBuscar.Select()
                        Else
                            MsgBox("Error: Nro de Cuenta no se corresponde con ningún cliente !", vbInformation, "Servicio de Alertas")
                            txtCliente.Text = ""
                            txtBuscCliente.Text = ""
                            txtBuscCliente.Select()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: Problemas con la consulta de Servicio Técnico !", vbInformation)
        End Try
    End Sub

    Private Sub Limpiar()
        txtBuscCliente.Text = ""
        txtCliente.Text = ""
        cbxTercerizado.Text = ""
        cbxEstado.Text = ""
        txtBuscCdBarra.Text = ""
        cbxBuscTEq.Text = ""
        txtBuscDescripcion.Text = ""
        txtBuscProblema.Text = ""
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub

End Class