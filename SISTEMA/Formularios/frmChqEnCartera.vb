Public Class frmChqEnCartera
    Private Sub btnModificar_GotFocus(sender As Object, e As EventArgs) Handles btnTranf.GotFocus
        btnTranf.BackgroundImage = ByB_SI.My.Resources.EmitirAc
    End Sub

    Private Sub btnTranf_LostFocus(sender As Object, e As EventArgs) Handles btnTranf.LostFocus
        btnTranf.BackgroundImage = ByB_SI.My.Resources.EmitirIn
    End Sub

    Private Sub btnTranf_MouseEnter(sender As Object, e As EventArgs) Handles btnTranf.MouseEnter
        btnTranf.BackgroundImage = ByB_SI.My.Resources.EmitirAc
    End Sub

    Private Sub btnTranf_MouseLeave(sender As Object, e As EventArgs) Handles btnTranf.MouseLeave
        btnTranf.BackgroundImage = ByB_SI.My.Resources.EmitirIn
    End Sub

    Private Sub frmChqEnCartera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim _Ver As New Mostrar
            Dim _Dt As New DataTable
            Dim Total As Double

            _Dt = _Ver.verVAloresEnVartera()
            dgvValEnCartera.DataSource = _Dt
            dgvValEnCartera.Columns.Item("EnCartera").Visible = False
            dgvValEnCartera.Columns.Item("idCajaDetalle").Visible = False
            dgvValEnCartera.Columns.Item("Caja_idCaja").Visible = False

            Dim estiloEnc As New DataGridViewCellStyle()
            Dim textEnc As String = ""
            Dim X As Integer

            estiloEnc.Font = New Font(dgvValEnCartera.Font, FontStyle.Bold)
            dgvValEnCartera.ColumnHeadersDefaultCellStyle = estiloEnc
            dgvValEnCartera.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            For X = 1 To 10
                If X = 1 Or X = 9 Then
                    dgvValEnCartera.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                ElseIf X = 4 Then
                    dgvValEnCartera.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                ElseIf X = 8 Then
                    dgvValEnCartera.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvValEnCartera.Columns(X).DefaultCellStyle.Format = "$ #,##0.00"
                Else
                    dgvValEnCartera.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                End If
                Select Case X
                    Case 0
                        textEnc = "ELIM"
                        dgvValEnCartera.Columns(0).Width = 30
                    Case 1
                        textEnc = "ITEM"
                        dgvValEnCartera.Columns(1).Width = 30
                    Case 2
                        textEnc = "VALOR"
                        dgvValEnCartera.Columns(2).Width = 100
                    Case 3
                        textEnc = "NUMERO"
                        dgvValEnCartera.Columns(3).Width = 100
                    Case 4
                        textEnc = "FEC COBRO"
                        dgvValEnCartera.Columns(4).Width = 150
                    Case 5
                        textEnc = "LIBRADOR"
                        dgvValEnCartera.Columns(5).Width = 150
                    Case 6
                        textEnc = "BANCO"
                        dgvValEnCartera.Columns(6).Width = 100
                    Case 7
                        textEnc = "SUCURSAL"
                        dgvValEnCartera.Columns(7).Width = 100
                    Case 8
                        textEnc = "IMPORTE"
                        dgvValEnCartera.Columns(8).Width = 70
                    Case 9
                        textEnc = "EN CARTERA"
                        dgvValEnCartera.Columns(9).Width = 100
                    Case 10
                        textEnc = "OBSERVACIONES"
                        dgvValEnCartera.Columns(9).Width = 100
                End Select
                dgvValEnCartera.Columns(X).HeaderText = textEnc
            Next
            If dgvValEnCartera.RowCount > 0 Then
                btnTranf.Enabled = True
                For Each row As DataGridViewRow In dgvValEnCartera.Rows
                    Total += Val(row.Cells(8).Value)
                Next

                txtTotVal.Text = Format(Total, "$ #,##0.00")
            Else
                btnTranf.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Error: Valores en cartera no pueden cargarse !", vbInformation, "Servicio de Alertas")
        End Try
    End Sub

    Private Sub dgvValEnCartera_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvValEnCartera.CellContentClick
        If e.ColumnIndex = Me.dgvValEnCartera.Columns.Item("Seleccion").Index Then
            Dim celSel As DataGridViewCheckBoxCell = Me.dgvValEnCartera.Rows(e.RowIndex).Cells("Seleccion")
            celSel.Value = Not celSel.Value
        End If
    End Sub

    Private Sub btnTranf_Click(sender As Object, e As EventArgs) Handles btnTranf.Click
        Dim resP As DialogResult
        Dim _Guardar As New GrabaDatos

        resP = MessageBox.Show("Transfiere Valores Seleccionados ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If resP = Windows.Forms.DialogResult.OK Then
            Try
                If lblOrigen.Text = "Caja" Then
                    For Each row As DataGridViewRow In dgvValEnCartera.Rows
                        Dim seL As Boolean = Convert.ToBoolean(row.Cells("Seleccion").Value)

                        If seL = True Then
                            _Guardar.Grabar("Caja", "NoImagen", "insBufferDetalleCaja", row.Cells(2).Value, row.Cells(3).Value, _
                                            Format(CDate(row.Cells(4).Value), "yyyy/MM/dd"), row.Cells(5).Value, row.Cells(6).Value, _
                                            row.Cells(7).Value, CDbl(Val(row.Cells(8).Value)), row.Cells(9).Value, row.Cells(10).Value, _
                                            row.Cells(1).Value)
                        End If
                    Next

                    Dim _Dt As New DataTable
                    Dim _Ver As New Mostrar
                    Dim TotalValores As Double
                    _Dt = _Ver.verDetalleValoresCaja()
                    frmCaja.dgvBufDetalle.DataSource = _Dt

                    'Actualizo el DataGridView y sumo valores
                    For Each row As DataGridViewRow In frmCaja.dgvBufDetalle.Rows
                        TotalValores += Val(row.Cells(8).Value)
                    Next
                    frmCaja.txtTotVal.Text = Format(TotalValores, "$ #,##0.00")
                    Me.Hide()
                Else
                    For Each row As DataGridViewRow In dgvValEnCartera.Rows
                        Dim seL As Boolean = Convert.ToBoolean(row.Cells("Seleccion").Value)

                        If seL = True Then
                            _Guardar.Grabar("Orden Pago Proveedores", "NoImagen", "insBufferDetalleCaja", row.Cells(2).Value, row.Cells(3).Value, _
                                            Format(CDate(row.Cells(4).Value), "yyyy/MM/dd"), row.Cells(5).Value, row.Cells(6).Value, _
                                            row.Cells(7).Value, CDbl(Val(row.Cells(8).Value)), row.Cells(9).Value, row.Cells(10).Value, _
                                            row.Cells(1).Value)
                        End If
                    Next

                    Dim _Dt As New DataTable
                    Dim _Ver As New Mostrar
                    Dim TotalValores As Double
                    _Dt = _Ver.verDetalleValoresCaja()
                    frmReciboCompra.dgvBufDetalle.DataSource = _Dt

                    'Actualizo el DataGridView y sumo valores
                    For Each row As DataGridViewRow In frmReciboCompra.dgvBufDetalle.Rows
                        TotalValores += Val(row.Cells(8).Value)
                    Next
                    frmReciboCompra.txtTotVal.Text = Format(TotalValores, "$ #,##0.00")
                    Me.Hide()
                End If
            Catch ex As MySqlException
                MsgBox("Error al Eliminar Items de Valores !" & vbCrLf & vbCrLf & ex.ToString, vbCritical, "Servicio de Alertas")
            End Try
        End If
    End Sub
End Class