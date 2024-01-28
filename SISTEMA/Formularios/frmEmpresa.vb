Imports MySql.Data.MySqlClient

Public Class frmEmpresa
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim _Guardar As New GrabaDatos
        Dim resP As DialogResult
        resP = MessageBox.Show("Grabar Datos de la Empresa?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        Try
            If resP = Windows.Forms.DialogResult.OK Then
                If txtRazonSocial.Text = "" Or txtDireccion.Text = "" Or txtLocalidad.Text = "" Or txtCP.Text = "" Or txtCuit.Text = "" Or txtFechaInicio.Text = "" Or txtIIBB.Text = "" Or txtPropietario.Text = "" Or txtPais.Text = "" Or txtProvincia.Text = "" Then
                    MsgBox("Error: Verifique que todos los items tengan su dato correspondiente.", vbInformation, "Servico de Alertas")
                    txtRazonSocial.Select()
                Else
                    If lblFuncion.Text = "Nuevo" Then
                        'Grabar datos de la empresa
                        _Guardar.Grabar("Empresa", "Imagen", "insEmpresa", txtCodEmpresa.Text, txtRazonSocial.Text, txtDireccion.Text, _
                                        txtLocalidad.Text, txtCP.Text, txtProvincia.Text, txtPais.Text, txtTE.Text, txtMail.Text, _
                                        txtWeb.Text, txtPropietario.Text, txtEslogan.Text, Format(CDate(txtFechaInicio.Text), "yyyy/MM/dd"), _
                                        txtCuit.Text, txtIIBB.Text, cbxCatIva.Text, mdiFrmPpal.usSis)

                        'Agregar nuevo registro de sistema
                        _Guardar.Grabar("Sistema", "NoImagen", "insSistema", txtCodEmpresa.Text, "", "", "")

                        lblMsg.ForeColor = Color.LawnGreen
                        lblMsg.Text = "Datos de la Empresa Ingresados Exitosamente"
                        lblMsg.Visible = True
                        tmrMensaje.Enabled = True

                    Else
                        _Guardar.Grabar("Empresa", "Imagen", "modEmpresa", txtCodEmpresa.Text, txtRazonSocial.Text, txtDireccion.Text, _
                                        txtLocalidad.Text, txtCP.Text, txtProvincia.Text, txtPais.Text, txtTE.Text, txtMail.Text, _
                                        txtWeb.Text, txtPropietario.Text, txtEslogan.Text, Format(CDate(txtFechaInicio.Text), "yyyy/MM/dd"), _
                                        txtCuit.Text, txtIIBB.Text, cbxCatIva.Text, mdiFrmPpal.usSis)
                        lblMsg.ForeColor = Color.LawnGreen
                        lblMsg.Text = "Datos de la Empresa Modificados Exitosamente"
                        lblMsg.Visible = True
                        tmrMensaje.Enabled = True
                    End If

                    'Actualizo el DataGridView
                    Dim _Ver As New Mostrar
                    Dim _Dt As New DataTable
                    _Dt = _Ver.verEmpresa()

                    dgvempresas.DataSource = _Dt

                    btnModificar.Enabled = True
                    btnCancelar.Enabled = False
                    btnGuardar.Enabled = False
                    Desactivar()
                    Limpiar()
                    btnNuevo.Select()
                End If
            End If
        Catch ex As MySqlException
            lblMsg.ForeColor = Color.Red
            lblMsg.Text = "Error: Empresa no se ingreso y/o modifico correctamente."
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
            Dim _Dt, _Dt1 As New DataTable

            _Dt = _Ver.verEmpresa()
            dgvempresas.DataSource = _Dt

            Dim estiloEnc As New DataGridViewCellStyle()
            Dim textEnc As String = ""
            Dim X As Integer

            estiloEnc.Font = New Font(dgvEmpresas.Font, FontStyle.Bold)
            dgvEmpresas.ColumnHeadersDefaultCellStyle = estiloEnc
            dgvEmpresas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            For X = 0 To 17
                If X = 0 Or X = 1 Then
                    dgvEmpresas.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Else
                    dgvEmpresas.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                End If
                Select Case X
                    Case 0
                        textEnc = "ID"
                    Case 1
                        textEnc = "COD EMPRESA"
                    Case 2
                        textEnc = "RAZON SOCIAL"
                    Case 3
                        textEnc = "DIRECCION"
                    Case 4
                        textEnc = "LOCALIDAD"
                    Case 5
                        textEnc = "C. P."
                    Case 6
                        textEnc = "PROVINCIA"
                    Case 7
                        textEnc = "PAIS"
                    Case 8
                        textEnc = "TE"
                    Case 0
                        textEnc = "MAIL"
                    Case 10
                        textEnc = "WEB"
                    Case 11
                        textEnc = "PROPIETARIO"
                    Case 12
                        textEnc = "LOGOTIPO"
                    Case 13
                        textEnc = "ESLOGAN"
                    Case 14
                        textEnc = "INIC. ACTIV."
                    Case 15
                        textEnc = "CUIT"
                    Case 16
                        textEnc = "II BB"
                    Case 17
                        textEnc = "IVA"
                End Select
                dgvEmpresas.Columns(X).HeaderText = textEnc
            Next


            _Dt1 = _Ver.verSistema(mdiFrmPpal.cdEmp)
            Dim Fila As DataRow = _Dt1.Rows(_Dt1.Rows.Count - 1)
            txtCodEmpresa.Text = Fila("CodEmpresa")

            Me.Text = "CARGAR EMPRESAS (UNIDADES DE NEGOCIO) - " & mdiFrmPpal.encForm
        Catch ex As Exception
            MsgBox("No se puede mostrar datos de la Empresa !", vbInformation)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            txtCodEmpresa.Text = dgvEmpresas.SelectedCells.Item(1).Value
            txtRazonSocial.Text = dgvEmpresas.SelectedCells.Item(2).Value
            txtDireccion.Text = dgvEmpresas.SelectedCells.Item(3).Value
            txtLocalidad.Text = dgvEmpresas.SelectedCells.Item(4).Value
            txtCP.Text = dgvEmpresas.SelectedCells.Item(5).Value
            txtProvincia.Text = dgvEmpresas.SelectedCells.Item(6).Value
            txtPais.Text = dgvEmpresas.SelectedCells.Item(7).Value
            txtTE.Text = dgvEmpresas.SelectedCells.Item(8).Value
            txtMail.Text = dgvEmpresas.SelectedCells.Item(9).Value
            txtWeb.Text = dgvEmpresas.SelectedCells.Item(10).Value
            txtPropietario.Text = dgvEmpresas.SelectedCells.Item(11).Value
            txtEslogan.Text = dgvEmpresas.SelectedCells.Item(13).Value
            txtFechaInicio.Text = Format(CDate(dgvEmpresas.SelectedCells.Item(14).Value), "dd/MM/yyyy")
            txtCuit.Text = dgvEmpresas.SelectedCells.Item(15).Value
            txtIIBB.Text = dgvEmpresas.SelectedCells.Item(16).Value
            cbxCatIva.Text = dgvEmpresas.SelectedCells.Item(17).Value
            If dgvEmpresas.SelectedCells.Item(12).Value.ToString <> "" Then
                pbxLogo.BackgroundImage = Nothing
                Dim b() As Byte = dgvEmpresas.SelectedCells.Item(12).Value
                Dim mS As New IO.MemoryStream(b)

                pbxLogo.Image = Image.FromStream(mS)
                pbxLogo.SizeMode = PictureBoxSizeMode.StretchImage
            End If

            btnNuevo.Enabled = False
            btnModificar.Enabled = False
            btnCancelar.Enabled = True
            btnGuardar.Enabled = True
            lblFuncion.Text = "Modificar"
            Activar()
            txtRazonSocial.Select()
        Catch ex As Exception
            MsgBox("Error al modificar la Empresa !" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
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
        Dim _Ver As New Mostrar
        Dim _Dt As New DataTable

        _Dt = _Ver.verSistema(mdiFrmPpal.cdEmp)
        Dim Fila As DataRow = _Dt.Rows(_Dt.Rows.Count - 1)
        txtCodEmpresa.Text = Fila("CodEmpresa")

        btnModificar.Enabled = True
        btnCancelar.Enabled = False
        btnGuardar.Enabled = False
        btnNuevo.Enabled = True
        Desactivar()
        Limpiar()
        btnNuevo.Select()
    End Sub

    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click
        If ofdImagen.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbxLogo.BackgroundImage = Nothing
            pbxLogo.Image = New Bitmap(ofdImagen.FileName)
            pbxLogo.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Activar()
        txtRazonSocial.Enabled = True
        txtDireccion.Enabled = True
        txtLocalidad.Enabled = True
        txtCP.Enabled = True
        txtProvincia.Enabled = True
        txtPais.Enabled = True
        txtTE.Enabled = True
        txtMail.Enabled = True
        txtWeb.Enabled = True
        txtPropietario.Enabled = True
        txtEslogan.Enabled = True
        txtFechaInicio.Enabled = True
        txtCuit.Enabled = True
        txtIIBB.Enabled = True
        cbxCatIva.Enabled = True
        pbxLogo.Enabled = True
        btnLogo.Enabled = True
    End Sub
    Private Sub Desactivar()
        txtRazonSocial.Enabled = False
        txtDireccion.Enabled = False
        txtLocalidad.Enabled = False
        txtCP.Enabled = False
        txtProvincia.Enabled = False
        txtPais.Enabled = False
        txtTE.Enabled = False
        txtMail.Enabled = False
        txtWeb.Enabled = False
        txtPropietario.Enabled = False
        txtEslogan.Enabled = False
        txtFechaInicio.Enabled = False
        txtCuit.Enabled = False
        txtIIBB.Enabled = False
        cbxCatIva.Enabled = False
        pbxLogo.Enabled = False
        btnLogo.Enabled = False
    End Sub

    Private Sub txtFechaInicio_Validated(sender As Object, e As EventArgs) Handles txtFechaInicio.Validated
        If Not txtFechaInicio.Text = "" Then
            If Not IsDate(txtFechaInicio.Text) Then
                MsgBox("Fecha incorrecta", vbInformation, "Servicio de Alertas")
                txtFechaInicio.Text = ""
                txtFechaInicio.Select()
            Else
                txtFechaInicio.Text = Format(CDate(txtFechaInicio.Text), "dd/MM/yyyy")
            End If
        End If

    End Sub

    Private Sub txtCuit_TextChanged(sender As Object, e As EventArgs) Handles txtCuit.TextChanged

    End Sub

    Private Sub txtCuit_Validated(sender As Object, e As EventArgs) Handles txtCuit.Validated
        If Len(txtCuit.Text) <> 11 Then
            MsgBox("Error: Cuit Inválido!", vbExclamation)
            txtCuit.Text = ""
            txtCuit.Select()
        Else
            Dim Ct1, Ct2, Ct3 As String
            Ct1 = Mid(txtCuit.Text, 1, 2)
            Ct2 = Mid(txtCuit.Text, 3, 8)
            Ct3 = Mid(txtCuit.Text, 11, 1)
            txtCuit.Text = Ct1 & "-" & Ct2 & "-" & Ct3
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim X, _inC As Integer
        Dim _reSto As String

        For X = 5 To 7
            If Mid(txtCodEmpresa.Text, X, 1) <> "0" Then
                _reSto = Mid(txtCodEmpresa.Text, 1, X - 1)
                _inC = Mid(txtCodEmpresa.Text, X, 8 - X)
                _inC = _inC + 1
                txtCodEmpresa.Text = _reSto & CStr(_inC)
            End If
        Next

        btnModificar.Enabled = False
        btnCancelar.Enabled = True
        btnGuardar.Enabled = True
        btnNuevo.Enabled = False
        lblFuncion.Text = "Nuevo"
        Activar()
        Limpiar()
        txtRazonSocial.Select()
    End Sub

    Private Sub Limpiar()
        txtRazonSocial.Text = ""
        txtDireccion.Text = ""
        txtLocalidad.Text = ""
        txtCP.Text = ""
        txtProvincia.Text = ""
        txtPais.Text = ""
        txtTE.Text = ""
        txtMail.Text = ""
        txtWeb.Text = ""
        txtPropietario.Text = ""
        txtEslogan.Text = ""
        txtFechaInicio.Text = ""
        txtCuit.Text = ""
        txtIIBB.Text = ""
        cbxCatIva.Text = ""
    End Sub

    Private Sub dgvempresas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.ColumnIndex = Me.dgvempresas.Columns.Item("Eliminar").Index Then
            Dim celSel As DataGridViewCheckBoxCell = Me.dgvempresas.Rows(e.RowIndex).Cells("Eliminar")
            celSel.Value = Not celSel.Value
        End If
    End Sub
End Class