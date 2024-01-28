Public Class frmServTecnicoResumen

  
    Private Sub frmServTecnicoResumen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        Dim _Ver As New Mostrar
        Dim _Dt As New DataTable

        If lblOrigen.Text = "Terceros" Then
            _Dt = _Ver.verServicioTecnicoTodoPorid(frmSTPresupuestoTerceros.dgvServTecnico.SelectedCells.Item(1).Value)
        ElseIf lblOrigen.Text = "Entrea, Garantia y Otros" Then
            _Dt = _Ver.verServicioTecnicoTodoPorid(frmSTGarantiayOtros.dgvServTecnico.SelectedCells.Item(1).Value)
        ElseIf lblOrigen.Text = "Consulta Servico Tecnico" Then
            _Dt = _Ver.verServicioTecnicoTodoPorid(frmConsServicioTecnico.dgvServTecnico.SelectedCells.Item(0).Value)
        ElseIf lblOrigen.Text = "Alta Servicio Tecnico" Then
            _Dt = _Ver.verServicioTecnicoTodoPorid(frmServTecnico.dgvServTecnico.SelectedCells.Item(1).Value)
        End If

        If _Dt.Rows.Count > 0 Then
            lblNroOrden.Text = _Dt.Rows(0).Item(2).ToString
            lblFecAlta.Text = _Dt.Rows(0).Item(4).ToString
            lblRazonSocial.Text = _Dt.Rows(0).Item(6).ToString
            lblTE.Text = _Dt.Rows(0).Item(12).ToString
            lblIdCliente.Text = _Dt.Rows(0).Item(5).ToString
            lblCodBarra.Text = _Dt.Rows(0).Item(3).ToString
            lblTipoEq.Text = _Dt.Rows(0).Item(14).ToString
            lblDetalleEq.Text = _Dt.Rows(0).Item(15).ToString
            lblAccesorios.Text = _Dt.Rows(0).Item(16).ToString
            lblTercerizado.Text = _Dt.Rows(0).Item(26).ToString
            If lblTercerizado.Text = "Si" Then
                lblEntregaAProv.Text = Format(CDate(_Dt.Rows(0).Item(28).ToString), "dd/MM/yyyy")
                If lblEstado.Text = "En Reparacion Terceros" Then
                    lblDevProv.Text = "No Devuelto Por Teceros"
                Else
                    lblDevProv.Text = Format(CDate(_Dt.Rows(0).Item(29).ToString), "dd/MM/yyyy")
                End If
            Else
                lblEntregaAProv.Text = ""
                lblDevProv.Text = ""
            End If
            lblEstEntrega.Text = _Dt.Rows(0).Item(20).ToString
            lblFecEntrega.Text = _Dt.Rows(0).Item(21).ToString
            lblObservaciones.Text = _Dt.Rows(0).Item(30).ToString
            lblPresProveedor.Text = Format(CDbl(_Dt.Rows(0).Item(27).ToString), "$ #,##0.00")
            lblPresupuesto.Text = Format(CDbl(_Dt.Rows(0).Item(22).ToString), "$ #,##0.00")
            lblGarantia.Text = _Dt.Rows(0).Item(23).ToString
            lblVtoGrantia.Text = _Dt.Rows(0).Item(24).ToString
            lblEstado.Text = _Dt.Rows(0).Item(31).ToString
            txtProblema.Text = _Dt.Rows(0).Item(18).ToString
            txtDiagnostico.Text = _Dt.Rows(0).Item(19).ToString
        Else
            MsgBox("Error: No se pueden cargar los datos del Servicio Técnico.", vbInformation, "Servico de Alertas")
        End If



        'Catch ex As Exception
        'MsgBox("No se pueden cargar los datos del Servicio Técnico !" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
        'End Try

    End Sub
End Class