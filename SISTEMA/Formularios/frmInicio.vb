Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class frmInicio
    Private Sub frmIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            BDcnn()
            lblCnn.Text = "Conección al servidor: OK !"
            lblCnn.ForeColor = Color.LawnGreen

            Dim _cMd As New MySqlCommand("Select * From Usuarios Where Estado = 1", _cX)
            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Ds As New DataSet
            _dA.Fill(_Ds, "Usuarios")

            cbxUsuario.Refresh()
            cbxUsuario.DataSource = _Ds.Tables("Usuarios")
            cbxUsuario.DisplayMember = "Nombre"
            cbxUsuario.Text = ""

            Dim _cMd1 As New MySqlCommand("Select CodEmpresa, RazonSocial, CUIT From Empresa", _cX)
            Dim _dA1 As New MySqlDataAdapter(_cMd1)
            Dim _Dt As New DataTable
            _dA1.Fill(_Dt)

            dgvEmpresas.DataSource = _Dt
            If dgvEmpresas.RowCount <> 0 Then
                dgvEmpresas.Columns("CodEmpresa").Visible = False
                txtCodE.Text = dgvEmpresas.SelectedCells.Item(0).Value
                mdifrmppal.cuitEmp = dgvEmpresas.SelectedCells.Item(2).Value
            End If

            cbxUsuario.Select()

            'Configurando mis separadores personales
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-AR")
            System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","

        Catch ex As MySqlException
            lblCnn.Text = "Error de conexión con el servidor"
            lblCnn.ForeColor = Color.Red
            btnIngreso.Enabled = False
            cbxUsuario.Enabled = False
            txtContraseña.Enabled = False
            MsgBox("Servidor no disponible!" & vbCrLf & vbCrLf & ex.ToString, vbCritical, "Servicio de Alertas")
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        End
    End Sub

    Private Sub btnIngreso_Click(sender As Object, e As EventArgs) Handles btnIngreso.Click
        Try
            mdifrmppal.tcErr = "Ok"
            Select Case cbxUsuario.Text
                Case ""
                    MsgBox("Usuario y/o Contraseña incorrecto", vbInformation)
                Case "cjb"
                    If txtContraseña.Text = "cjb23" Then
                        Me.Hide()
                        mdifrmppal.ShowDialog()
                        mdifrmppal.Text = "Administrador General - CJB"
                    Else
                        MsgBox("Usuario y/o Contraseña incorrecto", vbInformation)
                    End If
                Case Else
                    BDcnn()
                    Dim _cMd As New MySqlCommand("Select * From Usuarios Where Nombre = '" & cbxUsuario.Text & "' And Contraseña = '" & txtContraseña.Text & "'", _cX)
                    Dim _dA As New MySqlDataAdapter(_cMd)
                    Dim _Dt As New DataTable
                    _dA.Fill(_Dt)

                    If _Dt.Rows.Count <> 0 Then
                        Dim Fila As DataRow = _Dt.Rows(_Dt.Rows.Count - 1)
                        Dim _Dt2 As New DataTable
                        Dim _DtMax As New DataTable
                        Dim _Ver As New Mostrar
                        Dim _VerMax As New Mostrar
                        Dim uS, cat, emP, cuitE, reMot As String
                        Dim fecH As Date
                        Dim idCj As Integer = 0

                        uS = ""
                        emP = ""
                        cuitE = ""
                        reMot = ""
                        Me.Hide()
                        uS = Fila("Nombre").ToString
                        cat = Fila("Categoria").ToString
                        reMot = Fila("Remoto").ToString
                        emP = dgvEmpresas.SelectedCells.Item(1).Value
                        cuitE = dgvEmpresas.SelectedCells.Item(2).Value

                        'Obtener Ultimo TC Cargado
                        fecH = Date.Now.Date
                        _DtMax = _VerMax.verMaxIdTC()
                        Dim _Row1 As DataRow = _DtMax.Rows(_DtMax.Rows.Count - 1)
                        If IsDBNull(_Row1("UltimoId")) Then
                            idCj = 0
                            mdifrmppal.tpCb = 1
                            mdifrmppal.tcErr = "Error"
                        Else
                            idCj = _Row1("UltimoId")
                            _Dt2 = _VerMax.verTipoCambioUltimoId(idCj)
                            dgvTipoCambio.DataSource = _Dt2
                            mdifrmppal.ulTfecTc = CType(dgvTipoCambio.SelectedCells.Item(1).Value, Date)

                            If mdifrmppal.ulTfecTc >= fecH Then
                                mdifrmppal.tpCb = dgvTipoCambio.SelectedCells.Item(2).Value
                                mdifrmppal.tcErr = "Ok"
                            Else
                                mdifrmppal.tpCb = dgvTipoCambio.SelectedCells.Item(2).Value
                                mdifrmppal.tcErr = "Error"
                            End If
                        End If

                        If reMot = "Si" Then
                            mdifrmppal.encForm = "Empresa: " & emP & " - Usuario: " & uS
                            mdifrmppal.cdEmp = txtCodE.Text
                            mdifrmppal.cuitEmp = cuitE
                            mdifrmppal.usSis = uS
                            mdifrmppal.catUsSis = cat

                            mdifrmppal.SistemaToolStripMenuItem.Enabled = False
                            mdifrmppal.MantenimientoToolStripMenuItem.Enabled = False
                            mdifrmppal.VentasToolStripMenuItem.Enabled = False
                            mdifrmppal.ComprasToolStripMenuItem.Enabled = False
                            mdifrmppal.StockToolStripMenuItem.Enabled = False
                            mdifrmppal.CajaToolStripMenuItem.Enabled = False
                            mdifrmppal.OrdenDeServicioTécnicoToolStripMenuItem.Enabled = False
                            mdifrmppal.DiagnósticoYPresupuestosToolStripMenuItem.Enabled = False
                            mdifrmppal.EntregaYRecpciónServTécnicoTercerizadoToolStripMenuItem.Enabled = False
                            mdifrmppal.EntregasYGarantiasToolStripMenuItem1.Enabled = False
                            mdifrmppal.ConsultasDeOrdenesToolStripMenuItem.Enabled = False

                            Select Case txtCodE.Text
                                Case "UNN-001"
                                    mdiFrmPpal.BackgroundImage = ByB_SI.My.Resources.Fondo_15
                                Case "UNN-002"
                                    mdiFrmPpal.BackgroundImage = ByB_SI.My.Resources.Tranqueras
                            End Select
                        Else
                            mdifrmppal.encForm = "Empresa: " & emP & " - Usuario: " & uS
                            mdifrmppal.cdEmp = txtCodE.Text
                            mdifrmppal.cuitEmp = cuitE
                            mdifrmppal.usSis = uS
                            mdifrmppal.catUsSis = cat

                            Select Case txtCodE.Text
                                Case "UNN-001"
                                    mdiFrmPpal.BackgroundImage = ByB_SI.My.Resources.Fondo_15
                                Case "UNN-002"
                                    mdiFrmPpal.BackgroundImage = ByB_SI.My.Resources.Tranqueras
                            End Select
                        End If
                        mdifrmppal.ShowDialog()
                    Else
                        MsgBox("Usuario y/o Contraseña incorrecto", vbInformation)
                    End If
            End Select
        Catch ex As MySqlException
            MsgBox("Error: Servidor no disponible ! " & vbCrLf & vbCrLf & ex.ToString, vbCritical, "Servicio de Alertas")
        End Try
    End Sub

    Private Sub cbxUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxUsuario.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtContraseña.SelectionLength = Len(txtContraseña.Text)
            txtContraseña.Select()
        End If
    End Sub

    Private Sub txtContraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContraseña.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            Try
                mdifrmppal.tcErr = "Ok"
                Select Case cbxUsuario.Text
                    Case ""
                        MsgBox("Usuario y/o Contraseña incorrecto", vbInformation)
                    Case "cjb"
                        If txtContraseña.Text = "cjb23" Then
                            Me.Hide()
                            mdifrmppal.ShowDialog()
                            mdifrmppal.Text = "Administrador General - CJB"
                        Else
                            MsgBox("Usuario y/o Contraseña incorrecto", vbInformation)
                        End If
                    Case Else
                        BDcnn()
                        Dim _cMd As New MySqlCommand("Select * From Usuarios Where Nombre = '" & cbxUsuario.Text & "' And Contraseña = '" & txtContraseña.Text & "'", _cX)
                        Dim _dA As New MySqlDataAdapter(_cMd)
                        Dim _Dt As New DataTable
                        _dA.Fill(_Dt)

                        If _Dt.Rows.Count <> 0 Then
                            Dim Fila As DataRow = _Dt.Rows(_Dt.Rows.Count - 1)
                            Dim _Dt2 As New DataTable
                            Dim _DtMax As New DataTable
                            Dim _Ver As New Mostrar
                            Dim _VerMax As New Mostrar
                            Dim uS, cat, emP, cuitE, reMot As String
                            Dim fecH As Date
                            Dim idCj As Integer = 0

                            uS = ""
                            emP = ""
                            cuitE = ""
                            reMot = ""
                            Me.Hide()
                            uS = Fila("Nombre").ToString
                            cat = Fila("Categoria").ToString
                            reMot = Fila("Remoto").ToString
                            emP = dgvEmpresas.SelectedCells.Item(1).Value
                            cuitE = dgvEmpresas.SelectedCells.Item(2).Value

                            'Obtener Ultimo TC Cargado
                            fecH = Date.Now.Date
                            _DtMax = _VerMax.verMaxIdTC()
                            Dim _Row1 As DataRow = _DtMax.Rows(_DtMax.Rows.Count - 1)
                            If IsDBNull(_Row1("UltimoId")) Then
                                idCj = 0
                                mdifrmppal.tpCb = 1
                                mdifrmppal.tcErr = "Error"
                            Else
                                idCj = _Row1("UltimoId")
                                _Dt2 = _VerMax.verTipoCambioUltimoId(idCj)
                                dgvTipoCambio.DataSource = _Dt2
                                mdifrmppal.ulTfecTc = CType(dgvTipoCambio.SelectedCells.Item(1).Value, Date)

                                If mdifrmppal.ulTfecTc >= fecH Then
                                    mdifrmppal.tpCb = dgvTipoCambio.SelectedCells.Item(2).Value
                                    mdifrmppal.tcErr = "Ok"
                                Else
                                    mdifrmppal.tpCb = dgvTipoCambio.SelectedCells.Item(2).Value
                                    mdifrmppal.tcErr = "Error"
                                End If
                            End If

                            If reMot = "Si" Then
                                mdifrmppal.encForm = "Empresa: " & emP & " - Usuario: " & uS
                                mdifrmppal.cdEmp = txtCodE.Text
                                mdifrmppal.cuitEmp = cuitE
                                mdifrmppal.usSis = uS
                                mdifrmppal.catUsSis = cat

                                mdifrmppal.SistemaToolStripMenuItem.Enabled = False
                                mdifrmppal.MantenimientoToolStripMenuItem.Enabled = False
                                mdifrmppal.VentasToolStripMenuItem.Enabled = False
                                mdifrmppal.ComprasToolStripMenuItem.Enabled = False
                                mdifrmppal.StockToolStripMenuItem.Enabled = False
                                mdifrmppal.CajaToolStripMenuItem.Enabled = False
                                mdifrmppal.OrdenDeServicioTécnicoToolStripMenuItem.Enabled = False
                                mdifrmppal.DiagnósticoYPresupuestosToolStripMenuItem.Enabled = False
                                mdifrmppal.EntregaYRecpciónServTécnicoTercerizadoToolStripMenuItem.Enabled = False
                                mdifrmppal.EntregasYGarantiasToolStripMenuItem1.Enabled = False
                                mdifrmppal.ConsultasDeOrdenesToolStripMenuItem.Enabled = False

                                Select Case txtCodE.Text
                                    Case "UNN-001"
                                        mdiFrmPpal.BackgroundImage = ByB_SI.My.Resources.Fondo_15
                                    Case "UNN-002"
                                        mdiFrmPpal.BackgroundImage = ByB_SI.My.Resources.Tranqueras
                                End Select
                            Else
                                mdifrmppal.encForm = "Empresa: " & emP & " - Usuario: " & uS
                                mdifrmppal.cdEmp = txtCodE.Text
                                mdifrmppal.cuitEmp = cuitE
                                mdifrmppal.usSis = uS
                                mdifrmppal.catUsSis = cat

                                Select Case txtCodE.Text
                                    Case "UNN-001"
                                        mdiFrmPpal.BackgroundImage = ByB_SI.My.Resources.Fondo_15
                                    Case "UNN-002"
                                        mdiFrmPpal.BackgroundImage = ByB_SI.My.Resources.Tranqueras
                                End Select
                            End If
                            mdifrmppal.ShowDialog()
                        Else
                            MsgBox("Usuario y/o Contraseña incorrecto", vbInformation)
                        End If
                End Select
            Catch ex As MySqlException
                MsgBox("Error: Servidor no disponible !" & vbCrLf & vbCrLf & ex.ToString, vbCritical, "Servicio de Alertas")
            End Try
        End If
    End Sub

    Private Sub btnIngreso_MouseEnter(sender As Object, e As EventArgs) Handles btnIngreso.MouseEnter
        btnIngreso.BackgroundImage = ByB_SI.My.Resources.OkAc
    End Sub

    Private Sub btnIngreso_MouseLeave(sender As Object, e As EventArgs) Handles btnIngreso.MouseLeave
        btnIngreso.BackgroundImage = ByB_SI.My.Resources.OkIn
    End Sub

    Private Sub btnCancelar_MouseEnter(sender As Object, e As EventArgs) Handles btnCancelar.MouseEnter
        btnCancelar.BackgroundImage = ByB_SI.My.Resources.SalirAc
    End Sub

    Private Sub btnCancelar_MouseLeave(sender As Object, e As EventArgs) Handles btnCancelar.MouseLeave
        btnCancelar.BackgroundImage = ByB_SI.My.Resources.SalirIn
    End Sub

    Private Sub cbxUsuario_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxUsuario.SelectedValueChanged
        txtContraseña.Select()
    End Sub

    Private Sub dgvEmpresas_Click(sender As Object, e As EventArgs) Handles dgvEmpresas.Click
        txtCodE.Text = dgvEmpresas.SelectedCells.Item(0).Value
    End Sub

End Class