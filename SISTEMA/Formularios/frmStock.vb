Imports MySql.Data.MySqlClient

Public Class frmStock

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim _Guardar As New GrabaDatos
        Dim resP As DialogResult

        Try
            If txtArtSeleccionado.Text = "" Or txtCdBarra.Text = "" Then
                MsgBox("Error: No seleccionó Artículo o falta Código de Barra !", vbInformation, "Servico de Alertas")
                txtCdBarra.Select()
            Else
                If lblFuncion.Text = "Modificar" And lblIdStk.Text = "" Then
                    MsgBox("Error: Debe Seleccionar un Item de Stock !", vbExclamation, "Servicio de Alertas")
                Else
                    resP = MessageBox.Show("Modifica Stock ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    If resP = Windows.Forms.DialogResult.OK Then
                        Dim _haB As Integer

                        If lblFuncion.Text = "Suma" Then
                            _haB = 1
                            _Guardar.Grabar("Stock", "NoImagen", "insStock", txtCdEmp.Text, Format(CDate(txtFecAlta.Text), "yyyy/MM/dd"), _
                                                txtCdBarra.Text, CDbl(txtCantidad.Text), _haB, mdifrmppal.usSis, CInt(lblId.Text))
                            lblMsg.ForeColor = Color.LawnGreen
                            lblMsg.Text = "Stock Modificado = SUMA"
                            lblMsg.Visible = True
                            tmrMensaje.Enabled = True
                        ElseIf lblFuncion.Text = "Resta" Then
                            If CDbl(txtCantAnt.Text) - CDbl(txtCantidad.Text) <= 0 Then
                                _haB = 0
                                _Guardar.Grabar("Stock", "NoImagen", "modStockResta", CInt(lblIdStk.Text), _haB, mdifrmppal.usSis)
                                lblMsg.ForeColor = Color.LawnGreen
                                lblMsg.Text = "Stock Modificado = RESTA"
                                lblMsg.Visible = True
                                tmrMensaje.Enabled = True
                            Else
                                Dim cantSTK As Double
                                cantSTK = CDbl(txtCantAnt.Text) - CDbl(txtCantidad.Text)
                                _Guardar.Grabar("Stock", "NoImagen", "modStockRestaParcial", CInt(lblIdStk.Text), cantSTK, mdifrmppal.usSis)
                                lblMsg.ForeColor = Color.LawnGreen
                                lblMsg.Text = "Stock Modificado = RESTA"
                                lblMsg.Visible = True
                                tmrMensaje.Enabled = True
                            End If
                        Else
                            _haB = 1
                            _Guardar.Grabar("Stock", "NoImagen", "modStock", CInt(lblIdStk.Text), mdifrmppal.cdEmp, Format(CDate(txtFecAlta.Text), "yyyy/MM/dd"), _
                                                txtCdBarra.Text, CDbl(txtCantidad.Text), _haB, mdifrmppal.usSis, CInt(lblId.Text))
                            lblMsg.ForeColor = Color.LawnGreen
                            lblMsg.Text = "Stock Modificado = MODIFICACION"
                            lblMsg.Visible = True
                            tmrMensaje.Enabled = True
                        End If

                        'Actualizo el DataGridView
                        Dim _Ver As New Mostrar
                        Dim _Dt As New DataTable
                        Dim Total As Double
                        _Dt = _Ver.verStock(CInt(lblId.Text))

                        dgvStock.DataSource = _Dt
                        If dgvStock.RowCount <> 0 Then
                            For Each row As DataGridViewRow In dgvStock.Rows
                                Total += Val(row.Cells(5).Value)
                            Next
                            lblTotalStk.Text = Format(Total, "#,##0.00")
                        Else
                            dgvStock.DataSource = Nothing
                            lblTotalStk.Text = Format(0, "#,##0.00")
                        End If

                        Limpiar()
                        btnSuma.Enabled = True
                        btnResta.Enabled = True
                        btnModificar.Enabled = True
                        btnCancelar.Enabled = False
                        btnGuardar.Enabled = False
                        gbxArticulos.Enabled = False
                        btnSuma.Select()
                    End If
                End If
            End If
        Catch ex As MySqlException
            lblMsg.ForeColor = Color.Red
            lblMsg.Text = "Error: Stock no fue Modificado !"
            lblMsg.Visible = True
            tmrMensaje.Enabled = True
            MsgBox(ex.ToString)
            BDxxx()
        Finally
            BDxxx()
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
    End Sub

    Private Sub tmrMensaje_Tick(sender As Object, e As EventArgs) Handles tmrMensaje.Tick
        lblMsg.Visible = False
        tmrMensaje.Enabled = False
    End Sub

    Private Sub Limpiar()
        txtCdEmp.Text = ""
        lblId.Text = ""
        txtCodCategoria.Text = ""
        txtCdBarra.Text = ""
        txtArtSeleccionado.Text = ""
        lblOperacion.Text = ""
        txtCantidad.Text = Format(0, "#,##0.00")
        txtBuscar.Text = ""
    End Sub

    Private Sub btnSuma_GotFocus(sender As Object, e As EventArgs) Handles btnSuma.GotFocus
        btnSuma.BackgroundImage = ByB_SI.My.Resources.AgregarAc
    End Sub

    Private Sub btnSuma_MouseEnter(sender As Object, e As EventArgs) Handles btnSuma.MouseEnter
        btnSuma.BackgroundImage = ByB_SI.My.Resources.AgregarAc
    End Sub

    Private Sub btnSuma_LostFocus(sender As Object, e As EventArgs) Handles btnSuma.LostFocus
        btnSuma.BackgroundImage = ByB_SI.My.Resources.AgregarIn
    End Sub

    Private Sub btnSuma_MouseLeave(sender As Object, e As EventArgs) Handles btnSuma.MouseLeave
        btnSuma.BackgroundImage = ByB_SI.My.Resources.AgregarIn
    End Sub

    Private Sub btnResta_GotFocus(sender As Object, e As EventArgs) Handles btnResta.GotFocus
        btnResta.BackgroundImage = ByB_SI.My.Resources.RestarAc
    End Sub

    Private Sub btnResta_LostFocus(sender As Object, e As EventArgs) Handles btnResta.LostFocus
        btnResta.BackgroundImage = ByB_SI.My.Resources.RestarIn
    End Sub

    Private Sub btnResta_MouseEnter(sender As Object, e As EventArgs) Handles btnResta.MouseEnter
        btnResta.BackgroundImage = ByB_SI.My.Resources.RestarAc
    End Sub

    Private Sub btnResta_MouseLeave(sender As Object, e As EventArgs) Handles btnResta.MouseLeave
        btnResta.BackgroundImage = ByB_SI.My.Resources.RestarIn
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
        Limpiar()
        btnSuma.Enabled = True
        btnResta.Enabled = True
        btnModificar.Enabled = True
        btnCancelar.Enabled = False
        btnGuardar.Enabled = False
        gbxArticulos.Enabled = False
        btnSuma.Select()
    End Sub

    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtArtSeleccionado.Text = dgvArticulos.SelectedCells.Item(4).Value
            lblId.Text = dgvArticulos.SelectedCells.Item(0).Value
            txtCodCategoria.Text = dgvArticulos.SelectedCells.Item(3).Value
            txtCdBarra.Select()
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            Dim _mAut As New Mostrar
            Dim _Ds As New DataSet

            _Ds.Tables.Add(_mAut.verArticulos(mdifrmppal.cdEmp).Copy)
            Dim _Dv As New DataView(_Ds.Tables(0))

            _Dv.RowFilter = "Descripcion Like '%" & txtBuscar.Text & "%'"

            If _Dv.Count <> 0 Then
                dgvArticulos.DataSource = _Dv
                dgvArticulos.Columns.Item("idArticulos").Visible = False
                dgvArticulos.Columns.Item("CodUN").Visible = False
                dgvArticulos.Columns.Item("FecAlta").Visible = False
                dgvArticulos.Columns.Item("CodCategoria").Visible = False
                dgvArticulos.Columns.Item("Unidad").Visible = False
                dgvArticulos.Columns.Item("Precio").Visible = False
                dgvArticulos.Columns.Item("AlicuotaIVA").Visible = False
                dgvArticulos.Columns.Item("PrecioFinal").Visible = False
                dgvArticulos.Columns.Item("Usuario").Visible = False
                dgvArticulos.Columns.Item("RequiereStock").Visible = False
                dgvArticulos.Columns.Item("Cat_idCategorias").Visible = False
                dgvArticulos.Columns.Item("Manual").Visible = False
            Else
                dgvArticulos.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox("Error de consulta de Artículos" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
        End Try
    End Sub

    Private Sub frmArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim _Ver As New Mostrar
            Dim _Dt, _DtStk As New DataTable

            _Dt = _Ver.verArticulos(mdifrmppal.cdEmp)
            dgvArticulos.DataSource = _Dt
            dgvArticulos.Columns.Item("idArticulos").Visible = False
            dgvArticulos.Columns.Item("CodUN").Visible = False
            dgvArticulos.Columns.Item("FecAlta").Visible = False
            dgvArticulos.Columns.Item("CodCategoria").Visible = False
            dgvArticulos.Columns.Item("Unidad").Visible = False
            dgvArticulos.Columns.Item("Precio").Visible = False
            dgvArticulos.Columns.Item("AlicuotaIVA").Visible = False
            dgvArticulos.Columns.Item("PrecioFinal").Visible = False
            dgvArticulos.Columns.Item("RequiereStock").Visible = False
            dgvArticulos.Columns.Item("Usuario").Visible = False
            dgvArticulos.Columns.Item("Cat_idCategorias").Visible = False
            dgvArticulos.Columns.Item("Manual").Visible = False

            _DtStk = _Ver.verStock(-99)
            dgvStock.DataSource = _DtStk
            dgvStock.Columns.Item("IdStock").Visible = False
            dgvStock.Columns.Item("CodUN").Visible = False
            dgvStock.Columns.Item("EnStock").Visible = False
            dgvStock.Columns.Item("Art_idArticulos").Visible = False

            dgvStock.DataSource = Nothing

            txtFecAlta.Text = Date.Now.Date()
            txtCdEmp.Text = mdiFrmPpal.cdEmp
            Me.Text = "MANTENIMIENTO DE STOCK - " & mdifrmppal.encForm
        Catch ex As Exception
            Me.Text = "MANTENIMIENTO DE STOCK - " & mdifrmppal.encForm
            MsgBox("No se puede mostrar Artículos !", vbInformation)
        End Try
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnGuardar.Select()
        End If
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        btnSuma.Enabled = False
        btnResta.Enabled = False
        btnModificar.Enabled = False
        btnCancelar.Enabled = True
        btnGuardar.Enabled = True
        gbxArticulos.Enabled = True
        lblOperacion.Text = "RESTA"
        lblFuncion.Text = "Resta"
        txtBuscar.Select()
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        gbxArticulos.Enabled = True
        btnSuma.Enabled = False
        btnResta.Enabled = False
        btnModificar.Enabled = False
        btnCancelar.Enabled = True
        btnGuardar.Enabled = True
        gbxArticulos.Enabled = True
        lblOperacion.Text = "SUMA"
        lblFuncion.Text = "Suma"
        txtCantidad.Text = Format(0, "#,##0.00")
        txtBuscar.Select()
    End Sub

    Private Sub txtCdBarra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCdBarra.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCantidad.SelectionLength = Len(txtCantidad.Text)
            txtCantidad.Select()
        End If
    End Sub

    Private Sub txtCantidad_Validated(sender As Object, e As EventArgs) Handles txtCantidad.Validated
        If Not IsNumeric(txtCantidad.Text) Then
            MsgBox("Sólo valores numéricos", vbInformation)
            txtCantidad.Text = Format(0, "#,##0.00")
            txtCantidad.SelectionLength = Len(txtCantidad.Text)
            txtCantidad.Select()
        Else
            txtCantidad.Text = Format(CDbl(txtCantidad.Text), "#,##0.00")
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        btnSuma.Enabled = False
        btnResta.Enabled = False
        btnModificar.Enabled = False
        btnCancelar.Enabled = True
        btnGuardar.Enabled = True
        gbxArticulos.Enabled = True
        txtFecAlta.Text = Date.Now.Date
        lblOperacion.Text = "MODIFICAR"
        lblFuncion.Text = "Modificar"
        txtCantidad.Text = Format(0, "#,##0.00")
        txtBuscar.Select()
    End Sub

    Private Sub dgvStock_Click(sender As Object, e As EventArgs)
        If lblFuncion.Text = "Modificar" Or lblFuncion.Text = "Resta" Then
            lblIdStk.Text = dgvStock.SelectedCells.Item(0).Value
            txtCdBarra.Text = dgvStock.SelectedCells.Item(3).Value
            txtCantidad.Text = dgvStock.SelectedCells.Item(4).Value
            txtCdBarra.SelectionLength = Len(txtCdBarra.Text)
            txtCdBarra.Select()
        End If
    End Sub

    Private Sub dgvArticulos_Click1(sender As Object, e As EventArgs) Handles dgvArticulos.Click
        Try
            If dgvArticulos.RowCount <> 0 Then
                txtArtSeleccionado.Text = dgvArticulos.SelectedCells.Item(4).Value
                lblId.Text = dgvArticulos.SelectedCells.Item(0).Value
                txtCodCategoria.Text = dgvArticulos.SelectedCells.Item(3).Value

                'Actualizo el DataGridView
                Dim _Ver As New Mostrar
                Dim _Dt As New DataTable
                Dim Total As Double

                _Dt = _Ver.verStock(CInt(lblId.Text))

                dgvStock.DataSource = _Dt
                If dgvStock.RowCount <> 0 Then
                    Dim estiloEnc As New DataGridViewCellStyle()
                    Dim textEnc As String = ""
                    Dim X As Integer

                    dgvStock.ColumnHeadersVisible = True
                    dgvStock.Columns.Item("IdStock").Visible = False
                    dgvStock.Columns.Item("CodUN").Visible = False
                    dgvStock.Columns.Item("EnStock").Visible = False
                    dgvStock.Columns.Item("Art_idArticulos").Visible = False

                    estiloEnc.Font = New Font(dgvArticulos.Font, FontStyle.Bold)
                    dgvStock.ColumnHeadersDefaultCellStyle = estiloEnc
                    dgvStock.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    For X = 0 To 6
                        If X = 0 Or X = 1 Or X = 3 Or X = 6 Then
                            dgvStock.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        ElseIf X = 2 Then
                            dgvStock.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        Else
                            dgvStock.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            dgvStock.Columns(X).DefaultCellStyle.Format = "#,##0.00"
                        End If
                        Select Case X
                            Case 0
                                textEnc = "ID"
                            Case 1
                                textEnc = "COD EMPRESA"
                            Case 2
                                textEnc = "ALTA"
                            Case 3
                                textEnc = "COD BARRA"
                            Case 4
                                textEnc = "STOCK"
                            Case 5
                                textEnc = "0=NO STK 1=EN STK"
                            Case 6
                                textEnc = "ID ARTICULO"
                        End Select
                        dgvStock.Columns(X).HeaderText = textEnc
                    Next

                    For Each row As DataGridViewRow In dgvStock.Rows
                        Total += Val(row.Cells(4).Value)
                    Next
                    lblTotalStk.Text = Format(Total, "#,##0.00")
                Else
                    dgvStock.DataSource = Nothing
                    dgvStock.ColumnHeadersVisible = False
                    lblTotalStk.Text = Format(0, "#,##0.00")
                End If

                txtCdBarra.Select()
            End If
        Catch ex As Exception
            MsgBox("Error: Stock No disponible!", vbInformation)
        End Try
    End Sub

    Private Sub dgvStock_Click1(sender As Object, e As EventArgs) Handles dgvStock.Click
        lblIdStk.Text = dgvStock.SelectedCells.Item(0).Value
        txtCdBarra.Text = dgvStock.SelectedCells.Item(3).Value
        txtCantidad.Text = Format(CDbl(dgvStock.SelectedCells.Item(4).Value), "#,##0.00")
        txtCantAnt.Text = dgvStock.SelectedCells.Item(4).Value
    End Sub
End Class