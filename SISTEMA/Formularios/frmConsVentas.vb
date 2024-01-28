Public Class frmConsVentas

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

    Private Sub frmConsVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _Ver As New Mostrar
        Dim _Dt As New DataTable
        Dim canT, sbT, ivA, toT As Double
        canT = 0
        sbT = 0
        ivA = 0
        toT = 0

        _Dt = _Ver.consVenta(mdiFrmPpal.cdEmp)
        dgvVentas.DataSource = _Dt

        dgvVentas.Columns.Item("idFacturas").Visible = False
        dgvVentas.Columns.Item("CodUNFac").Visible = False
        dgvVentas.Columns.Item("idClientes").Visible = False
        dgvVentas.Columns.Item("idFacturaDetalle").Visible = False
        dgvVentas.Columns.Item("IdArticulo").Visible = False
        dgvVentas.Columns.Item("IdArticulos").Visible = False
        dgvVentas.Columns.Item("CodUNArt").Visible = False
        dgvVentas.Columns.Item("FecAlta").Visible = False
        dgvVentas.Columns.Item("CodCatArt").Visible = False
        dgvVentas.Columns.Item("Cat_idCategorias").Visible = False
        dgvVentas.Columns.Item("idCategorias").Visible = False
        dgvVentas.Columns.Item("CodCatCategorias").Visible = False
        dgvVentas.Columns.Item("CodRubro").Visible = False
        dgvVentas.Columns.Item("CodSubRubro").Visible = False
        dgvVentas.Columns.Item("CodResumen").Visible = False
        dgvVentas.Columns.Item("VentaFacturas_idFacturas").Visible = False
        dgvVentas.Columns.Item("CtaCteVenta_idCtaCteVenta").Visible = False

        dgvVentas.Columns(2).HeaderText = "Cod Barra"
        dgvVentas.Columns(2).Width = 150
        dgvVentas.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvVentas.Columns(3).Width = 70
        dgvVentas.Columns(3).HeaderText = "Fecha"
        dgvVentas.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvVentas.Columns(3).DefaultCellStyle.Format = "dd/MM/yyyy"
        dgvVentas.Columns(4).Width = 50
        dgvVentas.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvVentas.Columns(5).Width = 70
        dgvVentas.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvVentas.Columns(6).Width = 75
        dgvVentas.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvVentas.Columns(7).Width = 40
        dgvVentas.Columns(7).HeaderText = "Clase"
        dgvVentas.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvVentas.Columns(9).Width = 250
        dgvVentas.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvVentas.Columns(10).Width = 80
        dgvVentas.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvVentas.Columns(22).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvVentas.Columns(23).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvVentas.Columns(24).Width = 120
        dgvVentas.Columns(24).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvVentas.Columns(26).Width = 150
        dgvVentas.Columns(26).HeaderText = "Cod Barra Art"
        dgvVentas.Columns(26).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvVentas.Columns(27).Width = 300
        dgvVentas.Columns(27).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvVentas.Columns(28).Width = 60
        dgvVentas.Columns(28).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvVentas.Columns(29).Width = 50
        dgvVentas.Columns(29).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvVentas.Columns(29).DefaultCellStyle.Format = "#,##0.00"
        dgvVentas.Columns(30).Width = 70
        dgvVentas.Columns(30).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvVentas.Columns(30).DefaultCellStyle.Format = "$ #,##0.00"
        dgvVentas.Columns(31).Width = 50
        dgvVentas.Columns(31).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvVentas.Columns(31).DefaultCellStyle.Format = "0.00 %"
        dgvVentas.Columns(32).Width = 70
        dgvVentas.Columns(32).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvVentas.Columns(32).DefaultCellStyle.Format = "$ #,##0.00"
        dgvVentas.Columns(34).Width = 80
        dgvVentas.Columns(34).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvVentas.Columns(34).DefaultCellStyle.Format = "$ #,##0.00"
        dgvVentas.Columns(35).Width = 60
        dgvVentas.Columns(35).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvVentas.Columns(35).DefaultCellStyle.Format = "$ #,##0.00"
        dgvVentas.Columns(36).Width = 80
        dgvVentas.Columns(36).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvVentas.Columns(36).DefaultCellStyle.Format = "$ #,##0.00"
        dgvVentas.Columns(37).Width = 70
        dgvVentas.Columns(37).HeaderText = "Al Iva 1"
        dgvVentas.Columns(37).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvVentas.Columns(37).DefaultCellStyle.Format = "0.00 %"
        dgvVentas.Columns(38).Width = 60
        dgvVentas.Columns(38).HeaderText = "Iva 1"
        dgvVentas.Columns(38).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvVentas.Columns(38).DefaultCellStyle.Format = "$ #,##0.00"
        dgvVentas.Columns(39).Width = 70
        dgvVentas.Columns(39).HeaderText = "Al Iva 2"
        dgvVentas.Columns(39).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvVentas.Columns(39).DefaultCellStyle.Format = "0.00 %"
        dgvVentas.Columns(40).Width = 60
        dgvVentas.Columns(40).HeaderText = "Iva 2"
        dgvVentas.Columns(40).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvVentas.Columns(40).DefaultCellStyle.Format = "$ #,##0.00"
        dgvVentas.Columns(41).Width = 70
        dgvVentas.Columns(41).HeaderText = "Al Iva 3"
        dgvVentas.Columns(41).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvVentas.Columns(41).DefaultCellStyle.Format = "0.00 %"
        dgvVentas.Columns(42).Width = 60
        dgvVentas.Columns(42).HeaderText = "Iva 3"
        dgvVentas.Columns(42).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvVentas.Columns(42).DefaultCellStyle.Format = "$ #,##0.00"
        dgvVentas.Columns(43).Width = 80
        dgvVentas.Columns(43).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvVentas.Columns(43).DefaultCellStyle.Format = "$ #,##0.00"
        dgvVentas.Columns(44).Width = 150
        dgvVentas.Columns(44).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvVentas.Columns(45).Width = 105
        dgvVentas.Columns(45).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvVentas.Columns(46).Width = 70
        dgvVentas.Columns(46).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvVentas.Columns(46).DefaultCellStyle.Format = "dd/MM/yyyy"

        Dim nroF As String = ""

        lblReg.Text = _Dt.Rows.Count - 1
        'Primero sumo cantidades
        For Each Fila As DataRow In _Dt.Rows
            canT = canT + CDbl(Fila("Cantidad"))
        Next

        'Luego calculo el resto
        For Each Fila As DataRow In _Dt.Rows
            If Not (nroF = Fila("CodBarraFac")) Then
                If Fila("TipoFactura") = "Nota Credito" Then
                    sbT = sbT - CDbl(Fila("BaseImponible"))
                    ivA = ivA - (CDbl(Fila("ImpIva1")) + CDbl(Fila("ImpIva2"))) + CDbl(Fila("ImpIva3"))
                Else
                    sbT = sbT + CDbl(Fila("BaseImponible"))
                    ivA = ivA + (CDbl(Fila("ImpIva1")) + CDbl(Fila("ImpIva2"))) + CDbl(Fila("ImpIva3"))
                End If
            End If
            nroF = Fila("CodBarraFac")
        Next
        toT = sbT + ivA

        lblCant.Text = Format(canT, "#,##0")
        lblSubT.Text = Format(sbT, "$ #,##0.00")
        lblIva.Text = Format(ivA, "$ #,##0.00")
        lblTotal.Text = Format(toT, "$ #,##0.00")

        Me.Text = "CONSULTA DE VENTAS - " & mdiFrmPpal.encForm
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
    End Sub

    Private Sub chkFecDesde_CheckedChanged(sender As Object, e As EventArgs) Handles chkFecDesde.CheckedChanged
        If chkFecDesde.Checked Then
            chkFecDesde.Checked = True
            txtFecDesde.Enabled = True
            txtFecDesde.BackColor = Color.Gold
            txtFecDesde.ForeColor = Color.DarkRed
            txtFecDesde.SelectionLength = Len(txtFecDesde.Text)
            txtFecDesde.Select()
        Else
            chkFecDesde.Checked = False
            txtFecDesde.Enabled = False
            txtFecDesde.BackColor = Color.LightGray
            txtFecDesde.ForeColor = Color.Black
            txtFecDesde.SelectionLength = Len(txtFecDesde.Text)
            txtFecDesde.Select()
        End If
    End Sub

    Private Sub chkFecHasta_CheckedChanged(sender As Object, e As EventArgs) Handles chkFecHasta.CheckedChanged
        If chkFecHasta.Checked Then
            chkFecHasta.Checked = True
            txtFecHasta.Enabled = True
            txtFecHasta.BackColor = Color.Gold
            txtFecHasta.ForeColor = Color.DarkRed
            txtFecHasta.SelectionLength = Len(txtFecHasta.Text)
            txtFecHasta.Select()
        Else
            chkFecHasta.Checked = False
            txtFecHasta.Enabled = False
            txtFecHasta.BackColor = Color.LightGray
            txtFecHasta.ForeColor = Color.Black
            txtFecHasta.SelectionLength = Len(txtFecHasta.Text)
            txtFecHasta.Select()
        End If
    End Sub

    Private Sub chkNroFac_CheckedChanged(sender As Object, e As EventArgs) Handles chkNroFac.CheckedChanged
        If chkNroFac.Checked Then
            chkNroFac.Checked = True
            txtNroFac.Enabled = True
            txtNroFac.BackColor = Color.Gold
            txtNroFac.ForeColor = Color.DarkRed
            txtNroFac.SelectionLength = Len(txtNroFac.Text)
            txtNroFac.Select()
        Else
            chkNroFac.Checked = False
            txtNroFac.Enabled = False
            txtNroFac.BackColor = Color.LightGray
            txtNroFac.ForeColor = Color.Black
            txtNroFac.SelectionLength = Len(txtNroFac.Text)
            txtNroFac.Select()
        End If
    End Sub

    Private Sub chkTipoFac_CheckedChanged(sender As Object, e As EventArgs) Handles chkTipoFac.CheckedChanged
        If chkTipoFac.Checked Then
            chkTipoFac.Checked = True
            txtTipoFac.Enabled = True
            txtTipoFac.BackColor = Color.Gold
            txtTipoFac.ForeColor = Color.DarkRed
            txtTipoFac.SelectionLength = Len(txtTipoFac.Text)
            txtTipoFac.Select()
        Else
            chkTipoFac.Checked = False
            txtTipoFac.Enabled = False
            txtTipoFac.BackColor = Color.LightGray
            txtTipoFac.ForeColor = Color.Black
            txtTipoFac.SelectionLength = Len(txtTipoFac.Text)
            txtTipoFac.Select()
        End If
    End Sub

    Private Sub chkClaseFac_CheckedChanged(sender As Object, e As EventArgs) Handles chkClaseFac.CheckedChanged
        If chkClaseFac.Checked Then
            chkClaseFac.Checked = True
            cbxClaseFac.Enabled = True
            cbxClaseFac.BackColor = Color.Gold
            cbxClaseFac.ForeColor = Color.DarkRed
            cbxClaseFac.SelectionLength = Len(txtCli.Text)
            cbxClaseFac.Select()
        Else
            chkClaseFac.Checked = False
            cbxClaseFac.Enabled = False
            cbxClaseFac.BackColor = Color.LightGray
            cbxClaseFac.ForeColor = Color.Black
            cbxClaseFac.SelectionLength = Len(txtCli.Text)
            cbxClaseFac.Select()
        End If
    End Sub

    Private Sub chkRub_CheckedChanged(sender As Object, e As EventArgs) Handles chkRub.CheckedChanged
        If chkRub.Checked Then
            chkRub.Checked = True
            txtRub.Enabled = True
            txtRub.BackColor = Color.Gold
            txtRub.ForeColor = Color.DarkRed
            txtRub.SelectionLength = Len(txtRub.Text)
            txtRub.Select()
        Else
            chkRub.Checked = False
            txtRub.Enabled = False
            txtRub.BackColor = Color.LightGray
            txtRub.ForeColor = Color.Black
            txtRub.SelectionLength = Len(txtRub.Text)
            txtRub.Select()
        End If
    End Sub

    Private Sub chkSubR_CheckedChanged(sender As Object, e As EventArgs) Handles chkSubR.CheckedChanged
        If chkSubR.Checked Then
            chkSubR.Checked = True
            txtSubR.Enabled = True
            txtSubR.BackColor = Color.Gold
            txtSubR.ForeColor = Color.DarkRed
            txtSubR.SelectionLength = Len(txtSubR.Text)
            txtSubR.Select()
        Else
            chkSubR.Checked = False
            txtSubR.Enabled = False
            txtSubR.BackColor = Color.LightGray
            txtSubR.ForeColor = Color.Black
            txtSubR.SelectionLength = Len(txtSubR.Text)
            txtSubR.Select()
        End If
    End Sub

    Private Sub chkCat_CheckedChanged(sender As Object, e As EventArgs) Handles chkCat.CheckedChanged
        If chkCat.Checked Then
            chkCat.Checked = True
            txtCat.Enabled = True
            txtCat.BackColor = Color.Gold
            txtCat.ForeColor = Color.DarkRed
            txtCat.SelectionLength = Len(txtCat.Text)
            txtCat.Select()
        Else
            chkCat.Checked = False
            txtCat.Enabled = False
            txtCat.BackColor = Color.LightGray
            txtCat.ForeColor = Color.Black
            txtCat.SelectionLength = Len(txtCat.Text)
            txtCat.Select()
        End If
    End Sub

    Private Sub chkCli_CheckedChanged(sender As Object, e As EventArgs) Handles chkCli.CheckedChanged
        If chkCli.Checked Then
            chkCli.Checked = True
            txtCli.Enabled = True
            txtCli.BackColor = Color.Gold
            txtCli.ForeColor = Color.DarkRed
            txtCli.SelectionLength = Len(txtCli.Text)
            txtCli.Select()
        Else
            chkCli.Checked = False
            txtCli.Enabled = False
            txtCli.BackColor = Color.LightGray
            txtCli.ForeColor = Color.Black
            txtCli.SelectionLength = Len(txtCli.Text)
            txtCli.Select()
        End If
    End Sub

    Private Sub chkDet_CheckedChanged(sender As Object, e As EventArgs) Handles chkDet.CheckedChanged
        If chkDet.Checked Then
            chkDet.Checked = True
            txtDet.Enabled = True
            txtDet.BackColor = Color.Gold
            txtDet.ForeColor = Color.DarkRed
            txtDet.SelectionLength = Len(txtDet.Text)
            txtDet.Select()
        Else
            chkDet.Checked = False
            txtDet.Enabled = False
            txtDet.BackColor = Color.LightGray
            txtDet.ForeColor = Color.Black
            txtDet.SelectionLength = Len(txtDet.Text)
            txtDet.Select()
        End If
    End Sub

    Private Sub chkCdBarr_CheckedChanged(sender As Object, e As EventArgs) Handles chkCdBarr.CheckedChanged
        If chkCdBarr.Checked Then
            chkCdBarr.Checked = True
            txtCdBarr.Enabled = True
            txtCdBarr.BackColor = Color.Gold
            txtCdBarr.ForeColor = Color.DarkRed
            txtCdBarr.SelectionLength = Len(txtCdBarr.Text)
            txtCdBarr.Select()
        Else
            chkCdBarr.Checked = False
            txtCdBarr.Enabled = False
            txtCdBarr.BackColor = Color.LightGray
            txtCdBarr.ForeColor = Color.Black
            txtCdBarr.SelectionLength = Len(txtCdBarr.Text)
            txtCdBarr.Select()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            If chkFecDesde.Checked = False And chkFecHasta.Checked = False And chkNroFac.Checked = False And _
                chkTipoFac.Checked = False And chkClaseFac.Checked = False And chkRub.Checked = False And chkSubR.Checked = False And _
                chkCat.Checked = False And chkCli.Checked = False And chkDet.Checked = False And chkCdBarr.Checked = False Then

                MsgBox("No hay campos habilitados para consultar !" & vbCrLf & vbCrLf, vbExclamation, "Servicio de Alertas")

            Else
                Dim _Ver As New Mostrar
                Dim _Ds As New DataSet
                _Ds.Tables.Add(_Ver.consVenta(mdiFrmPpal.cdEmp).Copy)
                Dim _Dv As New DataView(_Ds.Tables(0))
                Dim cadCons As String = ""

                If chkFecDesde.Checked Then
                    If cadCons = "" Then
                        cadCons = "FechaFac >= #" & Format(CDate(txtFecDesde.Text), "yyyy/MM/dd") & "#"
                    Else
                        cadCons = cadCons & " And FechaFac >= #" & Format(CDate(txtFecDesde.Text), "yyyy/MM/dd") & "#"
                    End If
                End If

                If chkFecHasta.Checked Then
                    If cadCons = "" Then
                        cadCons = "FechaFac <= #" & Format(CDate(txtFecHasta.Text), "yyyy/MM/dd") & "#"
                    Else
                        cadCons = cadCons & " And FechaFac <= #" & Format(CDate(txtFecHasta.Text), "yyyy/MM/dd") & "#"
                    End If
                End If

                If chkNroFac.Checked Then
                    If cadCons = "" Then
                        cadCons = "NroFactura Like '%" & txtNroFac.Text & "%'"
                    Else
                        cadCons = cadCons & " And NroFactura Like '%" & txtNroFac.Text & "%'"
                    End If
                End If

                If chkTipoFac.Checked Then
                    If cadCons = "" Then
                        cadCons = "TipoFactura Like '%" & txtTipoFac.Text & "%'"
                    Else
                        cadCons = cadCons & " And TipoFactura Like '%" & txtTipoFac.Text & "%'"
                    End If
                End If

                If chkClaseFac.Checked Then
                    If cbxClaseFac.Text = "A" Then
                        If cadCons = "" Then
                            cadCons = "ClaseComprobante = 'A'"
                        Else
                            cadCons = cadCons & " And ClaseComprobante = 'A'"
                        End If
                    ElseIf cbxClaseFac.Text = "B" Then
                        If cadCons = "" Then
                            cadCons = "ClaseComprobante = 'B'"
                        Else
                            cadCons = cadCons & " And ClaseComprobante = 'B'"
                        End If
                    ElseIf cbxClaseFac.Text = "X" Then
                        If cadCons = "" Then
                            cadCons = "ClaseComprobante = 'X'"
                        Else
                            cadCons = cadCons & " And ClaseComprobante = 'X'"
                        End If
                    ElseIf cbxClaseFac.Text = "A y B" Then
                        If cadCons = "" Then
                            cadCons = "(ClaseComprobante = 'A' Or ClaseComprobante = 'B')"
                        Else
                            cadCons = cadCons & " And (ClaseComprobante = 'A' Or ClaseComprobante = 'B')"
                        End If
                    ElseIf cbxClaseFac.Text = "A y X" Then
                        If cadCons = "" Then
                            cadCons = "(ClaseComprobante = 'A' Or ClaseComprobante = 'X')"
                        Else
                            cadCons = cadCons & " And (ClaseComprobante = 'A' Or ClaseComprobante = 'X')"
                        End If
                    ElseIf cbxClaseFac.Text = "B y X" Then
                        If cadCons = "" Then
                            cadCons = "(ClaseComprobante = 'B' Or ClaseComprobante = 'X')"
                        Else
                            cadCons = cadCons & " And (ClaseComprobante = 'B' Or ClaseComprobante = 'X')"
                        End If
                    End If
                End If

                If chkRub.Checked Then
                    If cadCons = "" Then
                        cadCons = "DescRubro Like '%" & txtRub.Text & "%'"
                    Else
                        cadCons = cadCons & " And DescRubro Like '%" & txtRub.Text & "%'"
                    End If
                End If

                If chkSubR.Checked Then
                    If cadCons = "" Then
                        cadCons = "DescSubRubro Like '%" & txtSubR.Text & "%'"
                    Else
                        cadCons = cadCons & " And DescSubRubro Like '%" & txtSubR.Text & "%'"
                    End If
                End If

                If chkCat.Checked Then
                    If cadCons = "" Then
                        cadCons = "DescCategoria Like '%" & txtCat.Text & "%'"
                    Else
                        cadCons = cadCons & " And DescCategoria Like '%" & txtCat.Text & "%'"
                    End If
                End If

                If chkCli.Checked Then
                    If cadCons = "" Then
                        cadCons = "RazonSocial Like '%" & txtCli.Text & "%'"
                    Else
                        cadCons = cadCons & " And RazonSocial Like '%" & txtCli.Text & "%'"
                    End If
                End If

                If chkDet.Checked Then
                    If cadCons = "" Then
                        cadCons = "Detalle Like '%" & txtDet.Text & "%'"
                    Else
                        cadCons = cadCons & " And Detalle Like '%" & txtDet.Text & "%'"
                    End If
                End If

                If chkCdBarr.Checked Then
                    If cadCons = "" Then
                        cadCons = "CodBarraFac Like '%" & txtCdBarr.Text & "%'"
                    Else
                        cadCons = cadCons & " And CodBarraFac Like '%" & txtCdBarr.Text & "%'"
                    End If
                End If

                _Dv.RowFilter = cadCons

                If _Dv.Count <> 0 Then
                    Dim canT, sbT, ivA, toT As Double
                    canT = 0
                    sbT = 0
                    ivA = 0
                    toT = 0

                    Dim _Dt1 As DataTable = _Dv.ToTable()
                    Dim nroF As String = ""

                    dgvVentas.DataSource = _Dt1

                    lblReg.Text = dgvVentas.RowCount - 1
                    'Primero sumo cantidades
                    For Each Fila As DataRow In _Dt1.Rows
                        canT = canT + CDbl(Fila("Cantidad"))
                    Next

                    'Luego calculo el resto
                    For Each Fila As DataRow In _Dt1.Rows
                        If Not (nroF = Fila("CodBarraFac")) Then
                            If Fila("TipoFactura") = "Nota Credito" Then
                                sbT = sbT - CDbl(Fila("BaseImponible"))
                                ivA = ivA - (CDbl(Fila("ImpIva1")) + CDbl(Fila("ImpIva2"))) + CDbl(Fila("ImpIva3"))
                            Else
                                sbT = sbT + CDbl(Fila("BaseImponible"))
                                ivA = ivA + (CDbl(Fila("ImpIva1")) + CDbl(Fila("ImpIva2"))) + CDbl(Fila("ImpIva3"))
                            End If
                        End If
                        nroF = Fila("CodBarraFac")
                    Next
                    toT = sbT + ivA

                    lblCant.Text = Format(canT, "#,##0")
                    lblSubT.Text = Format(sbT, "$ #,##0.00")
                    lblIva.Text = Format(ivA, "$ #,##0.00")
                    lblTotal.Text = Format(toT, "$ #,##0.00")
                Else
                    dgvVentas.DataSource = Nothing
                    lblReg.Text = 0
                    lblCant.Text = Format(0, "#,##0")
                    lblSubT.Text = Format(0, "$ #,##0.00")
                    lblIva.Text = Format(0, "$ #,##0.00")
                    lblTotal.Text = Format(0, "$ #,##0.00")
                    MsgBox("No hay registros para esta consulta !" & vbCrLf & vbCrLf, vbExclamation, "Servicio de Alertas")
                End If
            End If
        Catch ex As Exception
            MsgBox("No hay campos habilitados para consultar !" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
        End Try

    End Sub

    Private Sub txtFecDesde_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFecDesde.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnBuscar.Select()
        End If
    End Sub

    Private Sub txtFecDesde_Validated(sender As Object, e As EventArgs) Handles txtFecDesde.Validated
        If Not txtFecDesde.Text = "" Then
            If Not IsDate(txtFecDesde.Text) Then
                MsgBox("Error: Formato de Fecha incorrecto.", vbInformation, "Servico de Alertas")
                txtFecDesde.Text = ""
                txtFecDesde.Select()
            Else
                txtFecDesde.Text = Format(CDate(txtFecDesde.Text), "dd/MM/yyyy")
            End If
        End If
    End Sub

    Private Sub txtFecHasta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFecHasta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnBuscar.Select()
        End If
    End Sub

    Private Sub txtFecHasta_Validated(sender As Object, e As EventArgs) Handles txtFecHasta.Validated
        If Not txtFecHasta.Text = "" Then
            If Not IsDate(txtFecHasta.Text) Then
                MsgBox("Error: Formato de Fecha incorrecto.", vbInformation, "Servico de Alertas")
                txtFecHasta.Text = ""
                txtFecHasta.Select()
            Else
                txtFecHasta.Text = Format(CDate(txtFecHasta.Text), "dd/MM/yyyy")
            End If
        End If
    End Sub

    Private Sub Limpiar()
        chkFecDesde.Checked = False
        txtFecDesde.Text = ""
        chkFecHasta.Checked = False
        txtFecHasta.Text = ""
        chkNroFac.Checked = False
        txtNroFac.Text = ""
        chkTipoFac.Checked = False
        txtTipoFac.Text = ""
        chkClaseFac.Checked = False
        cbxClaseFac.Text = ""
        chkRub.Checked = False
        txtRub.Text = ""
        chkSubR.Checked = False
        txtSubR.Text = ""
        chkCat.Checked = False
        txtCat.Text = ""
        chkCli.Checked = False
        txtCli.Text = ""
        chkDet.Checked = False
        txtDet.Text = ""
        chkCdBarr.Checked = False
        txtCdBarr.Text = ""
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar
        Dim canT, sbT, ivA, toT As Double
        Dim nroF As String = ""
        canT = 0
        sbT = 0
        ivA = 0
        toT = 0

        Limpiar()
        _Dt = _Ver.consVenta(mdiFrmPpal.cdEmp)
        dgvVentas.DataSource = _Dt

        lblReg.Text = _Dt.Rows.Count - 1
        'Primero sumo cantidades
        For Each Fila As DataRow In _Dt.Rows
            canT = canT + CDbl(Fila("Cantidad"))
        Next

        'Luego calculo el resto
        For Each Fila As DataRow In _Dt.Rows
            If Not (nroF = Fila("CodBarraFac")) Then
                If Fila("TipoFactura") = "Nota Credito" Then
                    sbT = sbT - CDbl(Fila("BaseImponible"))
                    ivA = ivA - (CDbl(Fila("ImpIva1")) + CDbl(Fila("ImpIva2"))) + CDbl(Fila("ImpIva3"))
                Else
                    sbT = sbT + CDbl(Fila("BaseImponible"))
                    ivA = ivA + (CDbl(Fila("ImpIva1")) + CDbl(Fila("ImpIva2"))) + CDbl(Fila("ImpIva3"))
                End If
            End If
            nroF = Fila("CodBarraFac")
        Next
        toT = sbT + ivA

        lblCant.Text = Format(canT, "#,##0")
        lblSubT.Text = Format(sbT, "$ #,##0.00")
        lblIva.Text = Format(ivA, "$ #,##0.00")
        lblTotal.Text = Format(toT, "$ #,##0.00")
    End Sub

    Private Sub btnTodo_Click(sender As Object, e As EventArgs) Handles btnTodo.Click
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar
        Dim canT, sbT, ivA, toT As Double
        Dim nroF As String = ""
        canT = 0
        sbT = 0
        ivA = 0
        toT = 0

        _Dt = _Ver.consVenta(mdiFrmPpal.cdEmp)
        dgvVentas.DataSource = _Dt

        lblReg.Text = _Dt.Rows.Count - 1
        'Primero sumo cantidades
        For Each Fila As DataRow In _Dt.Rows
            canT = canT + CDbl(Fila("Cantidad"))
        Next

        'Luego calculo el resto
        For Each Fila As DataRow In _Dt.Rows
            If Not (nroF = Fila("CodBarraFac")) Then
                If Fila("TipoFactura") = "Nota Credito" Then
                    sbT = sbT - CDbl(Fila("BaseImponible"))
                    ivA = ivA - (CDbl(Fila("ImpIva1")) + CDbl(Fila("ImpIva2"))) + CDbl(Fila("ImpIva3"))
                Else
                    sbT = sbT + CDbl(Fila("BaseImponible"))
                    ivA = ivA + (CDbl(Fila("ImpIva1")) + CDbl(Fila("ImpIva2"))) + CDbl(Fila("ImpIva3"))
                End If
            End If
            nroF = Fila("CodBarraFac")
        Next
        toT = sbT + ivA

        lblCant.Text = Format(canT, "#,##0")
        lblSubT.Text = Format(sbT, "$ #,##0.00")
        lblIva.Text = Format(ivA, "$ #,##0.00")
        lblTotal.Text = Format(toT, "$ #,##0.00")
    End Sub

End Class