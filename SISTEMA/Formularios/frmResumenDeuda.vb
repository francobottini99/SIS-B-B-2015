Public Class frmResumenDeuda

    Private Sub btnLimpiar_DragOver(sender As Object, e As DragEventArgs) Handles btnLimpiar.DragOver
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
        btnBuscar.BackgroundImage = ByB_SI.My.Resources.Emitir1Ac
    End Sub

    Private Sub btnBuscar_LostFocus(sender As Object, e As EventArgs) Handles btnBuscar.LostFocus
        btnBuscar.BackgroundImage = ByB_SI.My.Resources.Emitir1In
    End Sub

    Private Sub btnBuscar_MouseEnter(sender As Object, e As EventArgs) Handles btnBuscar.MouseEnter
        btnBuscar.BackgroundImage = ByB_SI.My.Resources.Emitir1Ac
    End Sub

    Private Sub btnBuscar_MouseLeave(sender As Object, e As EventArgs) Handles btnBuscar.MouseLeave
        btnBuscar.BackgroundImage = ByB_SI.My.Resources.Emitir1In
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


    Private Sub frmResumenDeuda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dgvResumen.DataSource = Nothing
            FormatoDeDGVresumen()
            pbrConsulta.Value = 0
            lblAvance.Text = "0 %"
            txtTotalDeuda.Text = Format(0, "$ #,##0.00")
            txtLimite.Text = Format(-10, "$ #,##0")
            cbxOperador.Text = "<"

            Me.Text = "CONSULTA DE DEUDA PENDIENTE DE COBRAR - " & mdiFrmPpal.encForm

            txtFecDesde.Select()
        Catch ex As Exception
            MsgBox("Error al cargar la tabla de consulta !", vbInformation)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim _Elim As New GrabaDatos

        _Elim.Grabar("Resumen Cta", "NoImagen", "vaciaResumenCtaVta")

        Me.Hide()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim _Guardar, _Elim As New GrabaDatos
            Dim _Ver, _VerC As New Mostrar
            Dim _DtC As New DataTable
            Dim _Dt, _DtR As New DataTable
            Dim resP As DialogResult

            _Elim.Grabar("Resumen Cta", "NoImagen", "vaciaResumenCtaVta")
            pbrConsulta.Value = 0

            If cbxOperador.Text = "" Then
                MsgBox("No ha definido el Operador para Límite de búsqueda !", vbInformation, "Servicio de Alertas")
                cbxOperador.Select()
            Else
                resP = MessageBox.Show("Comienza proceso de consula ?", "Servico de Alertas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If resP = Windows.Forms.DialogResult.Yes Then

                    If txtFecDesde.Text = "" And txtFecHasta.Text = "" And txtCta.Text = "" Then
                        _DtC = _VerC.verClientes(mdiFrmPpal.cdEmp)
                        pbrConsulta.Maximum = _DtC.Rows.Count
                        txtTotalDeuda.Text = Format(0, "$ #,##0.00")
                        Dim avAnce As Integer = 0
                        Dim deudaTotal As Double = 0

                        For Each fiLaCli As DataRow In _DtC.Rows
                            _Dt = _VerC.verCtaCteVentaIDCli(CInt(fiLaCli("idClientes")), mdiFrmPpal.cdEmp)

                            'Recorro la Cta Cte del Cliente filtrado para sacar el saldo
                            Dim idCli As Integer = 0
                            Dim rsCli As String = ""
                            Dim dirCli As String = ""
                            Dim locCli As String = ""
                            Dim teCli As String = ""
                            Dim fecUltMov As Date
                            Dim ulTcomp As String = ""
                            Dim calcSaldo As Double = 0

                            For Each fiLaCta As DataRow In _Dt.Rows
                                idCli = fiLaCli("idClientes")
                                rsCli = fiLaCli("RazonSocial")
                                dirCli = fiLaCli("Direccion")
                                locCli = fiLaCli("Localidad")
                                teCli = fiLaCli("TE")
                                fecUltMov = CDate(fiLaCta("Fecha"))
                                ulTcomp = CStr(fiLaCta("TipoComprobante")) & " -> " & CStr(fiLaCta("PtoVta")) & "-" & CStr(fiLaCta("NroComprobante"))
                                calcSaldo = calcSaldo + CDbl(fiLaCta("Credito")) - CDbl(fiLaCta("Debito"))
                            Next

                            Select Case cbxOperador.Text
                                Case ">"
                                    If calcSaldo > CInt(txtLimite.Text) Then
                                        _Guardar.Grabar("Resumen", "NoImagen", "insResumenCtaVta", idCli, rsCli, dirCli, locCli, teCli, _
                                                        Format(CDate(fecUltMov), "yyyy/MM/dd"), ulTcomp, calcSaldo)
                                        txtTotalDeuda.Text = Format(CDbl(txtTotalDeuda.Text) + calcSaldo, "$ #,##0.00")
                                        txtTotalDeuda.Refresh()
                                    End If
                                Case "<"
                                    If calcSaldo < CInt(txtLimite.Text) Then
                                        _Guardar.Grabar("Resumen", "NoImagen", "insResumenCtaVta", idCli, rsCli, dirCli, locCli, teCli, _
                                                        Format(CDate(fecUltMov), "yyyy/MM/dd"), ulTcomp, calcSaldo)
                                        txtTotalDeuda.Text = Format(CDbl(txtTotalDeuda.Text) + calcSaldo, "$ #,##0.00")
                                        txtTotalDeuda.Refresh()
                                    End If
                                Case "="
                                    If calcSaldo = CInt(txtLimite.Text) Then
                                        _Guardar.Grabar("Resumen", "NoImagen", "insResumenCtaVta", idCli, rsCli, dirCli, locCli, teCli, _
                                                        Format(CDate(fecUltMov), "yyyy/MM/dd"), ulTcomp, calcSaldo)
                                        txtTotalDeuda.Text = Format(CDbl(txtTotalDeuda.Text) + calcSaldo, "$ #,##0.00")
                                        txtTotalDeuda.Refresh()
                                    End If
                            End Select
                            avAnce += 1
                            lblAvance.Text = CStr(CInt(avAnce / _DtC.Rows.Count * 100)) & " %"
                            lblAvance.Refresh()
                            pbrConsulta.Value = avAnce
                        Next

                    ElseIf txtFecDesde.Text <> "" And txtFecHasta.Text = "" And txtCta.Text = "" Then

                        _DtC = _VerC.verClientes(mdiFrmPpal.cdEmp)
                        pbrConsulta.Maximum = _DtC.Rows.Count
                        txtTotalDeuda.Text = Format(0, "$ #,##0.00")
                        Dim avAnce As Integer = 0
                        Dim deudaTotal As Double = 0

                        For Each fiLaCli As DataRow In _DtC.Rows
                            _Dt = _VerC.consCtaCteVentaIDfecDesde(CInt(fiLaCli("idClientes")), mdiFrmPpal.cdEmp, Format(CDate(txtFecDesde.Text), "yyyy/MM/dd"))

                            'Recorro la Cta Cte del Cliente filtrado para sacar el saldo
                            Dim idCli As Integer = 0
                            Dim rsCli As String = ""
                            Dim dirCli As String = ""
                            Dim locCli As String = ""
                            Dim teCli As String = ""
                            Dim fecUltMov As Date
                            Dim ulTcomp As String = ""
                            Dim calcSaldo As Double = 0

                            For Each fiLaCta As DataRow In _Dt.Rows
                                idCli = fiLaCli("idClientes")
                                rsCli = fiLaCli("RazonSocial")
                                dirCli = fiLaCli("Direccion")
                                locCli = fiLaCli("Localidad")
                                teCli = fiLaCli("TE")
                                fecUltMov = CDate(fiLaCta("Fecha"))
                                ulTcomp = CStr(fiLaCta("TipoComprobante")) & " -> " & CStr(fiLaCta("PtoVta")) & "-" & CStr(fiLaCta("NroComprobante"))
                                calcSaldo = calcSaldo + CDbl(fiLaCta("Credito")) - CDbl(fiLaCta("Debito"))
                            Next

                            Select Case cbxOperador.Text
                                Case ">"
                                    If calcSaldo > CInt(txtLimite.Text) Then
                                        _Guardar.Grabar("Resumen", "NoImagen", "insResumenCtaVta", idCli, rsCli, dirCli, locCli, teCli, _
                                                        Format(CDate(fecUltMov), "yyyy/MM/dd"), ulTcomp, calcSaldo)
                                        txtTotalDeuda.Text = Format(CDbl(txtTotalDeuda.Text) + calcSaldo, "$ #,##0.00")
                                        txtTotalDeuda.Refresh()
                                    End If
                                Case "<"
                                    If calcSaldo < CInt(txtLimite.Text) Then
                                        _Guardar.Grabar("Resumen", "NoImagen", "insResumenCtaVta", idCli, rsCli, dirCli, locCli, teCli, _
                                                        Format(CDate(fecUltMov), "yyyy/MM/dd"), ulTcomp, calcSaldo)
                                        txtTotalDeuda.Text = Format(CDbl(txtTotalDeuda.Text) + calcSaldo, "$ #,##0.00")
                                        txtTotalDeuda.Refresh()
                                    End If
                                Case "="
                                    If calcSaldo = CInt(txtLimite.Text) Then
                                        _Guardar.Grabar("Resumen", "NoImagen", "insResumenCtaVta", idCli, rsCli, dirCli, locCli, teCli, _
                                                        Format(CDate(fecUltMov), "yyyy/MM/dd"), ulTcomp, calcSaldo)
                                        txtTotalDeuda.Text = Format(CDbl(txtTotalDeuda.Text) + calcSaldo, "$ #,##0.00")
                                        txtTotalDeuda.Refresh()
                                    End If
                            End Select
                            avAnce += 1
                            lblAvance.Text = CStr(CInt(avAnce / _DtC.Rows.Count * 100)) & " %"
                            lblAvance.Refresh()
                            pbrConsulta.Value = avAnce
                        Next



                    End If

                    _DtR = _Ver.verResumenCtaVta()
                    dgvResumen.DataSource = _DtR

                    FormatoDeDGVresumen()
                End If


            End If
        Catch ex As Exception
            MsgBox("Error: No se puede ejecutar la consulta !", vbInformation, "Servicio de Alertas")
            btnBuscar.Select()
        End Try
    End Sub

    Private Sub FormatoDeDGVresumen()
        Dim _Ver As New Mostrar
        Dim _Dt As New DataTable

        _Dt = _Ver.verResumenCtaVta()
        dgvResumen.DataSource = _Dt

        dgvResumen.Columns.Item("idResumenDeuda").Visible = False

        Dim estiloEnc As New DataGridViewCellStyle()
        Dim textEnc As String = ""

        dgvResumen.Columns("NroCta").HeaderText = "CTA"
        dgvResumen.Columns("NroCta").Width = 50
        dgvResumen.Columns("NroCta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvResumen.Columns("RazonSocial").HeaderText = "RAZON SOCIAL"
        dgvResumen.Columns("RazonSocial").Width = 250
        dgvResumen.Columns("RazonSocial").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgvResumen.Columns("Direccion").HeaderText = "DIRECCION"
        dgvResumen.Columns("Direccion").Width = 150
        dgvResumen.Columns("Direccion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgvResumen.Columns("Localidad").HeaderText = "LOCALIDAD"
        dgvResumen.Columns("Localidad").Width = 100
        dgvResumen.Columns("Localidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgvResumen.Columns("TE").HeaderText = "TE"
        dgvResumen.Columns("TE").Width = 150
        dgvResumen.Columns("TE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgvResumen.Columns("UltimoMov").HeaderText = "ULT MOV"
        dgvResumen.Columns("UltimoMov").Width = 90
        dgvResumen.Columns("UltimoMov").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvResumen.Columns("UltimoMov").DefaultCellStyle.Format = "dd/MM/yyyy"

        dgvResumen.Columns("Comprobante").HeaderText = "COMPROBANE"
        dgvResumen.Columns("Comprobante").Width = 150
        dgvResumen.Columns("Comprobante").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgvResumen.Columns("SaldoCta").HeaderText = "SALDO"
        dgvResumen.Columns("SaldoCta").Width = 80
        dgvResumen.Columns("SaldoCta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvResumen.Columns("SaldoCta").DefaultCellStyle.Format = "$ #,##0.00"

        estiloEnc.Font = New Font(dgvResumen.Font, FontStyle.Bold)
        dgvResumen.ColumnHeadersDefaultCellStyle = estiloEnc
        dgvResumen.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub txtLimite_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLimite.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnBuscar.Select()
        End If
    End Sub

    Private Sub txtLimite_Validated(sender As Object, e As EventArgs) Handles txtLimite.Validated
        If Not IsNumeric(txtLimite.Text) Then
            MsgBox("Solo valores numéricos!", vbExclamation)
            txtLimite.Text = ""
            txtLimite.Select()
        Else
            txtLimite.Text = Format(CInt(txtLimite.Text), "$ #,##0")
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        dgvResumen.DataSource = Nothing
        txtFecDesde.Text = ""
        txtFecHasta.Text = ""
        txtCta.Text = ""
        txtRazonSocial.Text = ""
        cbxOperador.Text = "<"
        txtLimite.Text = Format(-10, "$ #,##0")
    End Sub

    Private Sub txtFecDesde_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFecDesde.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtFecHasta.SelectionLength = Len(txtFecHasta.Text)
            txtFecHasta.Select()
        End If
    End Sub

    Private Sub txtFecDesde_Validated(sender As Object, e As EventArgs) Handles txtFecDesde.Validated
        If Not txtFecDesde.Text = "" Then
            If Not IsDate(txtFecDesde.Text) Then
                MsgBox("Error: Fecha incorrecta !", vbInformation, "Servicio de Alertas")
                txtFecDesde.Text = ""
                txtFecDesde.Select()
            Else
                txtFecDesde.Text = Format(CDate(txtFecDesde.Text), "dd/MM/yyyy")
            End If
        End If
    End Sub

    Private Sub btnImpComprobante_Click(sender As Object, e As EventArgs) Handles btnImpComprobante.Click
        If dgvResumen.Rows.Count > 0 Then
            frmInfResumenDeuda.ShowDialog()
        Else
            MsgBox("No hay registros para imprimir !", vbInformation, "Servicio de Alertas")
        End If
    End Sub
End Class