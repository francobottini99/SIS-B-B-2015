Public Class frmConsStock
    Private Sub btnTodos_GotFocus(sender As Object, e As EventArgs) Handles btnTodos.GotFocus
        btnTodos.BackgroundImage = ByB_SI.My.Resources.TodosArtAc
    End Sub

    Private Sub btnTodos_LostFocus(sender As Object, e As EventArgs) Handles btnTodos.LostFocus
        btnTodos.BackgroundImage = ByB_SI.My.Resources.TodosArtIn
    End Sub

    Private Sub btnTodos_MouseEnter(sender As Object, e As EventArgs) Handles btnTodos.MouseEnter
        btnTodos.BackgroundImage = ByB_SI.My.Resources.TodosArtAc
    End Sub

    Private Sub btnTodos_MouseLeave(sender As Object, e As EventArgs) Handles btnTodos.MouseLeave
        btnTodos.BackgroundImage = ByB_SI.My.Resources.TodosArtIn
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
    Private Sub btnImpStock_GotFocus(sender As Object, e As EventArgs) Handles btnImpStock.GotFocus
        btnImpStock.BackgroundImage = ByB_SI.My.Resources.ImpresoraAc
    End Sub

    Private Sub btnImpStock_LostFocus(sender As Object, e As EventArgs) Handles btnImpStock.LostFocus
        btnImpStock.BackgroundImage = ByB_SI.My.Resources.ImpresoraIn
    End Sub

    Private Sub btnImpStock_MouseEnter(sender As Object, e As EventArgs) Handles btnImpStock.MouseEnter
        btnImpStock.BackgroundImage = ByB_SI.My.Resources.ImpresoraAc
    End Sub

    Private Sub btnImpStock_MouseLeave(sender As Object, e As EventArgs) Handles btnImpStock.MouseLeave
        btnImpStock.BackgroundImage = ByB_SI.My.Resources.ImpresoraIn
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
    End Sub

    Private Sub txtRubro_TextChanged(sender As Object, e As EventArgs) Handles txtRubro.TextChanged
        Filtro()
    End Sub

    Private Sub txtSubRubro_TextChanged(sender As Object, e As EventArgs) Handles txtSubRubro.TextChanged
        Filtro()
    End Sub

    Private Sub txtCategoria_TextChanged(sender As Object, e As EventArgs) Handles txtCategoria.TextChanged
        Filtro()
    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged
        Filtro()
    End Sub

 
    Private Sub frmConsStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim _Dt As New DataTable
            Dim _Ver As New Mostrar

            _Dt = _Ver.consStock(mdiFrmPpal.cdEmp)
            dgvStock.DataSource = _Dt

            Dim estiloEnc As New DataGridViewCellStyle()
            Dim textEnc As String = ""
            Dim X As Integer
            Dim Total, impSiva, impCiva As Double

            estiloEnc.Font = New Font(dgvStock.Font, FontStyle.Bold)
            dgvStock.ColumnHeadersDefaultCellStyle = estiloEnc
            dgvStock.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            For X = 0 To 12
                If X = 0 Then
                    dgvStock.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                ElseIf X = 1 Or X = 2 Or X = 3 Or X = 4 Or X = 5 Then
                    dgvStock.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                ElseIf X = 0 Or X = 9 Or X = 11 Or X = 12 Then
                    dgvStock.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                ElseIf X = 7 Then
                    dgvStock.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvStock.Columns(X).DefaultCellStyle.Format = "0.00 %"
                ElseIf X = 10 Then
                    dgvStock.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvStock.Columns(X).DefaultCellStyle.Format = "#,##0.00"
                Else
                    dgvStock.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvStock.Columns(X).DefaultCellStyle.Format = "$ #,##0.00"
                End If
                Select Case X
                    Case 0
                        textEnc = "ALTA"
                    Case 1
                        textEnc = "RUBRO"
                    Case 2
                        textEnc = "SUBRUBRO"
                    Case 3
                        textEnc = "CATEGORIA"
                    Case 4
                        textEnc = "DESCRIPCION"
                    Case 5
                        textEnc = "UNIDAD"
                    Case 6
                        textEnc = "PRECIO"
                    Case 7
                        textEnc = "ALIC. IVA"
                    Case 8
                        textEnc = "PREC. FINAL"
                    Case 9
                        textEnc = "COD BARRA"
                    Case 10
                        textEnc = "CANTIDAD"
                    Case 11
                        textEnc = "ID STK"
                    Case 12
                        textEnc = "ID ART"
                End Select
                dgvStock.Columns(X).HeaderText = textEnc
            Next

            For Each row As DataGridViewRow In dgvStock.Rows
                Total += Val(row.Cells(10).Value)
                impSiva += (Val(row.Cells(6).Value) * Val(row.Cells(10).Value))
                impCiva += (Val(row.Cells(8).Value) * Val(row.Cells(10).Value))
            Next

            lblTotalStk.Text = Format(Total, "#,##0.00")
            lblImpSiva.Text = Format(impSiva, "$ #,##0.00")
            lblImpCiva.Text = Format(impCiva, "$ #,##0.00")

            Me.Text = "CONSULTA DE STOCK - " & mdiFrmPpal.encForm
            txtId.Text = ""
            txtCdBarra.Text = ""
            txtRubro.Text = ""
            txtSubRubro.Text = ""
            txtCategoria.Text = ""
            txtDescripcion.Text = ""
            txtDescripcion.Select()
        Catch ex As Exception
            MsgBox("No se puede mostrar Clientes !", vbInformation)
        End Try
    End Sub

    Private Sub Filtro()
        Try
            Dim _Ver As New Mostrar
            Dim _Ds As New DataSet
            _Ds.Tables.Add(_Ver.consStock(mdiFrmPpal.cdEmp).Copy)
            Dim _Dv As New DataView(_Ds.Tables(0))

            If txtId.Text = "" And txtCdBarra.Text = "" And txtRubro.Text = "" And txtSubRubro.Text = "" And txtCategoria.Text = "" And txtDescripcion.Text = "" Then
                dgvStock.DataSource = Nothing
            ElseIf txtId.Text <> "" And txtCdBarra.Text = "" And txtRubro.Text = "" And txtSubRubro.Text = "" And txtCategoria.Text = "" And txtDescripcion.Text = "" Then
                _Dv.RowFilter = "idArticulos = " & txtId.Text
            ElseIf txtId.Text = "" And txtCdBarra.Text <> "" And txtRubro.Text = "" And txtSubRubro.Text = "" And txtCategoria.Text = "" And txtDescripcion.Text = "" Then
                _Dv.RowFilter = "CodBarra ='" & txtCdBarra.Text & "'"
            ElseIf txtId.Text = "" And txtCdBarra.Text = "" And txtRubro.Text <> "" And txtSubRubro.Text = "" And txtCategoria.Text = "" And txtDescripcion.Text = "" Then
                _Dv.RowFilter = "DescRubro Like '%" & txtRubro.Text & "%'"
            ElseIf txtId.Text = "" And txtCdBarra.Text = "" And txtRubro.Text = "" And txtSubRubro.Text <> "" And txtCategoria.Text = "" And txtDescripcion.Text = "" Then
                _Dv.RowFilter = "DescSubRubro Like '%" & txtSubRubro.Text & "%'"
            ElseIf txtId.Text = "" And txtCdBarra.Text = "" And txtRubro.Text = "" And txtSubRubro.Text = "" And txtCategoria.Text <> "" And txtDescripcion.Text = "" Then
                _Dv.RowFilter = "DescCategoria Like '%" & txtCategoria.Text & "%'"
            ElseIf txtId.Text = "" And txtCdBarra.Text = "" And txtRubro.Text = "" And txtSubRubro.Text = "" And txtCategoria.Text = "" And txtDescripcion.Text <> "" Then
                _Dv.RowFilter = "Descripcion Like '%" & txtDescripcion.Text & "%'"
            Else
                MsgBox("No se admite consulta combinada", vbInformation)
            End If

            If _Dv.Count <> 0 Then
                dgvStock.DataSource = _Dv
                Dim estiloEnc As New DataGridViewCellStyle()
                Dim textEnc As String = ""
                Dim X As Integer
                Dim Total, impSiva, impCiva As Double

                estiloEnc.Font = New Font(dgvStock.Font, FontStyle.Bold)
                dgvStock.ColumnHeadersDefaultCellStyle = estiloEnc
                dgvStock.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                For X = 0 To 12
                    If X = 0 Then
                        dgvStock.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    ElseIf X = 1 Or X = 2 Or X = 3 Or X = 4 Or X = 5 Then
                        dgvStock.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    ElseIf X = 0 Or X = 9 Or X = 11 Or X = 12 Then
                        dgvStock.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    ElseIf X = 7 Then
                        dgvStock.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvStock.Columns(X).DefaultCellStyle.Format = "0.00 %"
                    ElseIf X = 10 Then
                        dgvStock.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvStock.Columns(X).DefaultCellStyle.Format = "#,##0.00"
                    Else
                        dgvStock.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvStock.Columns(X).DefaultCellStyle.Format = "$ #,##0.00"
                    End If
                    Select Case X
                        Case 0
                            textEnc = "ALTA"
                        Case 1
                            textEnc = "RUBRO"
                        Case 2
                            textEnc = "SUBRUBRO"
                        Case 3
                            textEnc = "CATEGORIA"
                        Case 4
                            textEnc = "DESCRIPCION"
                        Case 5
                            textEnc = "UNIDAD"
                        Case 6
                            textEnc = "PRECIO"
                        Case 7
                            textEnc = "ALIC. IVA"
                        Case 8
                            textEnc = "PREC. FINAL"
                        Case 9
                            textEnc = "COD BARRA"
                        Case 10
                            textEnc = "CANTIDAD"
                        Case 11
                            textEnc = "ID STK"
                        Case 12
                            textEnc = "ID ART"
                    End Select
                    dgvStock.Columns(X).HeaderText = textEnc
                Next
                For Each row As DataGridViewRow In dgvStock.Rows
                    Total += Val(row.Cells(10).Value)
                    impSiva += (Val(row.Cells(6).Value) * Val(row.Cells(10).Value))
                    impCiva += (Val(row.Cells(8).Value) * Val(row.Cells(10).Value))
                Next
                lblTotalStk.Text = Format(Total, "#,##0.00")
                lblImpSiva.Text = Format(impSiva, "$ #,##0.00")
                lblImpCiva.Text = Format(impCiva, "$ #,##0.00")
            Else
                dgvStock.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox("Error: No se puede mostrar Stock !", vbExclamation)
        End Try

    End Sub

    Private Sub btnTodos_Click(sender As Object, e As EventArgs) Handles btnTodos.Click
        Try
            Dim _Ver As New Mostrar
            Dim _Dt As New DataTable

            txtRubro.Text = ""
            txtSubRubro.Text = ""
            txtCategoria.Text = ""
            txtDescripcion.Text = ""

            _Dt = _Ver.consStock(mdiFrmPpal.cdEmp)
            dgvStock.DataSource = _Dt

            Dim estiloEnc As New DataGridViewCellStyle()
            Dim textEnc As String = ""
            Dim X As Integer
            Dim Total, impSiva, impCiva As Double

            estiloEnc.Font = New Font(dgvStock.Font, FontStyle.Bold)
            dgvStock.ColumnHeadersDefaultCellStyle = estiloEnc
            dgvStock.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            For X = 0 To 12
                If X = 0 Then
                    dgvStock.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                ElseIf X = 1 Or X = 2 Or X = 3 Or X = 4 Or X = 5 Then
                    dgvStock.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                ElseIf X = 0 Or X = 9 Or X = 11 Or X = 12 Then
                    dgvStock.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                ElseIf X = 7 Then
                    dgvStock.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvStock.Columns(X).DefaultCellStyle.Format = "0.00 %"
                ElseIf X = 10 Then
                    dgvStock.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvStock.Columns(X).DefaultCellStyle.Format = "#,##0.00"
                Else
                    dgvStock.Columns(X).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgvStock.Columns(X).DefaultCellStyle.Format = "$ #,##0.00"
                End If
                Select Case X
                    Case 0
                        textEnc = "ALTA"
                    Case 1
                        textEnc = "RUBRO"
                    Case 2
                        textEnc = "SUBRUBRO"
                    Case 3
                        textEnc = "CATEGORIA"
                    Case 4
                        textEnc = "DESCRIPCION"
                    Case 5
                        textEnc = "UNIDAD"
                    Case 6
                        textEnc = "PRECIO"
                    Case 7
                        textEnc = "ALIC. IVA"
                    Case 8
                        textEnc = "PREC. FINAL"
                    Case 9
                        textEnc = "COD BARRA"
                    Case 10
                        textEnc = "CANTIDAD"
                    Case 11
                        textEnc = "ID STK"
                    Case 12
                        textEnc = "ID ART"
                End Select
                dgvStock.Columns(X).HeaderText = textEnc
            Next
            For Each row As DataGridViewRow In dgvStock.Rows
                Total += Val(row.Cells(10).Value)
                impSiva += (Val(row.Cells(6).Value) * Val(row.Cells(10).Value))
                impCiva += (Val(row.Cells(8).Value) * Val(row.Cells(10).Value))
            Next
            lblTotalStk.Text = Format(Total, "#,##0.00")
            lblImpSiva.Text = Format(impSiva, "$ #,##0.00")
            lblImpCiva.Text = Format(impCiva, "$ #,##0.00")
        Catch ex As Exception
            MsgBox("Error: No se puede mostrar Stock !", vbExclamation)
        End Try
    End Sub

    Private Sub dgvStock_DoubleClick(sender As Object, e As EventArgs) Handles dgvStock.DoubleClick
        Try
            If lblOrigen.Text = "Factura Venta" Then
                frmFacturaVentas.txtIdArt.Text = dgvStock.SelectedCells.Item(12).Value
                frmFacturaVentas.txtIdStock.Text = dgvStock.SelectedCells.Item(11).Value
                frmFacturaVentas.txtArticulo.Text = dgvStock.SelectedCells.Item(4).Value
                frmFacturaVentas.txtUnidad.Text = dgvStock.SelectedCells.Item(5).Value
                frmFacturaVentas.txtCdBarra.Text = dgvStock.SelectedCells.Item(9).Value
                frmFacturaVentas.txtCantidad.Text = Format(dgvStock.SelectedCells.Item(10).Value, "#,##0.00")
                If frmFacturaVentas.lblLetra.Text = "A" Or frmFacturaVentas.lblLetra.Text = "B" Then
                    frmFacturaVentas.txtPrecio.Text = Format(dgvStock.SelectedCells.Item(6).Value, "$ #,##0.00")
                    frmFacturaVentas.txtPrecioFin.Text = dgvStock.SelectedCells.Item(8).Value
                    frmFacturaVentas.txtAlIvaReal.Text = dgvStock.SelectedCells.Item(7).Value
                    frmFacturaVentas.txtAlicIva.Text = Format(CDbl(dgvStock.SelectedCells.Item(7).Value), "0.00 %")
                    frmFacturaVentas.txtImporte.Text = Format(CDbl(dgvStock.SelectedCells.Item(10).Value) * CDbl(dgvStock.SelectedCells.Item(6).Value), "$ #,##0.00")
                    frmFacturaVentas.txtImpFinal.Text = Format(CDbl(dgvStock.SelectedCells.Item(10).Value) * CDbl(dgvStock.SelectedCells.Item(8).Value), "$ #,##0.00")
                    'ElseIf frmFacturaVentas.lblLetra.Text = "B" Then
                    '    frmFacturaVentas.txtPrecio.Text = Format(dgvStock.SelectedCells.Item(8).Value, "$ #,##0.00")
                    '    frmFacturaVentas.txtPrecioFin.Text = dgvStock.SelectedCells.Item(8).Value
                    '    frmFacturaVentas.txtAlIvaReal.Text = dgvStock.SelectedCells.Item(7).Value
                    '    frmFacturaVentas.txtAlicIva.Text = Format(0, "0.00 %")
                    '    frmFacturaVentas.txtImporte.Text = Format(CDbl(dgvStock.SelectedCells.Item(10).Value) * CDbl(dgvStock.SelectedCells.Item(6).Value), "$ #,##0.00")
                    '    frmFacturaVentas.txtImpFinal.Text = Format(CDbl(dgvStock.SelectedCells.Item(10).Value) * CDbl(dgvStock.SelectedCells.Item(8).Value), "$ #,##0.00")
                Else
                    frmFacturaVentas.txtPrecio.Text = Format(dgvStock.SelectedCells.Item(8).Value, "$ #,##0.00")
                    frmFacturaVentas.txtPrecioFin.Text = dgvStock.SelectedCells.Item(8).Value
                    frmFacturaVentas.txtAlIvaReal.Text = 0
                    frmFacturaVentas.txtAlicIva.Text = Format(0, "0.00 %")
                    frmFacturaVentas.txtImporte.Text = Format(CDbl(dgvStock.SelectedCells.Item(10).Value) * CDbl(dgvStock.SelectedCells.Item(6).Value), "$ #,##0.00")
                    frmFacturaVentas.txtImpFinal.Text = Format(CDbl(dgvStock.SelectedCells.Item(10).Value) * CDbl(dgvStock.SelectedCells.Item(8).Value), "$ #,##0.00")
                End If
                frmFacturaVentas.lblLetra.Enabled = False
                frmFacturaVentas.btnGuardar.Select()
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox("Error: Articulo No fue transferido !", vbInformation)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtId.Text = ""
        txtCdBarra.Text = ""
        txtRubro.Text = ""
        txtSubRubro.Text = ""
        txtCategoria.Text = ""
        txtDescripcion.Text = ""
    End Sub

    Private Sub btnImpStock_Click(sender As Object, e As EventArgs) Handles btnImpStock.Click
        frmInfStock.ShowDialog()
    End Sub

    Private Sub btnId_Click(sender As Object, e As EventArgs) Handles btnId.Click
        Filtro()
    End Sub

    Private Sub btnCdB_Click(sender As Object, e As EventArgs) Handles btnCdB.Click
        Filtro()
    End Sub

    Private Sub dgvStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgvStock.KeyPress
        Try
            If lblOrigen.Text = "Factura Venta" Then
                frmFacturaVentas.txtIdArt.Text = dgvStock.SelectedCells.Item(12).Value
                frmFacturaVentas.txtIdStock.Text = dgvStock.SelectedCells.Item(11).Value
                frmFacturaVentas.txtArticulo.Text = dgvStock.SelectedCells.Item(4).Value
                frmFacturaVentas.txtUnidad.Text = dgvStock.SelectedCells.Item(5).Value
                frmFacturaVentas.txtCdBarra.Text = dgvStock.SelectedCells.Item(9).Value
                frmFacturaVentas.txtCantidad.Text = Format(dgvStock.SelectedCells.Item(10).Value, "#,##0.00")
                If frmFacturaVentas.lblLetra.Text = "A" Then
                    frmFacturaVentas.txtPrecio.Text = Format(dgvStock.SelectedCells.Item(6).Value, "$ #,##0.00")
                    frmFacturaVentas.txtPrecioFin.Text = dgvStock.SelectedCells.Item(8).Value
                    frmFacturaVentas.txtAlIvaReal.Text = dgvStock.SelectedCells.Item(7).Value
                    frmFacturaVentas.txtAlicIva.Text = Format(CDbl(dgvStock.SelectedCells.Item(7).Value), "0.00 %")
                    frmFacturaVentas.txtImporte.Text = Format(CDbl(dgvStock.SelectedCells.Item(10).Value) * CDbl(dgvStock.SelectedCells.Item(6).Value), "$ #,##0.00")
                    frmFacturaVentas.txtImpFinal.Text = Format(CDbl(dgvStock.SelectedCells.Item(10).Value) * CDbl(dgvStock.SelectedCells.Item(8).Value), "$ #,##0.00")
                ElseIf frmFacturaVentas.lblLetra.Text = "B" Then
                    frmFacturaVentas.txtPrecio.Text = Format(dgvStock.SelectedCells.Item(8).Value, "$ #,##0.00")
                    frmFacturaVentas.txtPrecioFin.Text = dgvStock.SelectedCells.Item(8).Value
                    frmFacturaVentas.txtAlIvaReal.Text = dgvStock.SelectedCells.Item(7).Value
                    frmFacturaVentas.txtAlicIva.Text = Format(0, "0.00 %")
                    frmFacturaVentas.txtImporte.Text = Format(CDbl(dgvStock.SelectedCells.Item(10).Value) * CDbl(dgvStock.SelectedCells.Item(6).Value), "$ #,##0.00")
                    frmFacturaVentas.txtImpFinal.Text = Format(CDbl(dgvStock.SelectedCells.Item(10).Value) * CDbl(dgvStock.SelectedCells.Item(8).Value), "$ #,##0.00")
                Else
                    frmFacturaVentas.txtPrecio.Text = Format(dgvStock.SelectedCells.Item(8).Value, "$ #,##0.00")
                    frmFacturaVentas.txtPrecioFin.Text = dgvStock.SelectedCells.Item(8).Value
                    frmFacturaVentas.txtAlIvaReal.Text = 0
                    frmFacturaVentas.txtAlicIva.Text = Format(0, "0.00 %")
                    frmFacturaVentas.txtImporte.Text = Format(CDbl(dgvStock.SelectedCells.Item(10).Value) * CDbl(dgvStock.SelectedCells.Item(6).Value), "$ #,##0.00")
                    frmFacturaVentas.txtImpFinal.Text = Format(CDbl(dgvStock.SelectedCells.Item(10).Value) * CDbl(dgvStock.SelectedCells.Item(8).Value), "$ #,##0.00")
                End If
                frmFacturaVentas.btnGuardar.Select()
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox("Error: Articulo No fue transferido !", vbInformation)
        End Try
    End Sub
End Class