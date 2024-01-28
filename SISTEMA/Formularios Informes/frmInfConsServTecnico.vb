Public Class frmInfConsServTecnico

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Hide()
    End Sub

    Private Sub frmInfConsServTecnico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Text = "CONSULTA SERVICIO TECNICO - " & mdiFrmPpal.encForm
            Dim _Ds As New dsReportes

            Dim calcSaldo As Double = 0

            'Agrego filas desde DGV
            Dim Filas As DataRow
            Dim CantCol As Integer = frmConsServicioTecnico.dgvServTecnico.Columns.Count - 1
            For i As Integer = 0 To frmConsServicioTecnico.dgvServTecnico.Rows.Count - 1
                Filas = _Ds.Tables("dtServTecnicoTodo").Rows.Add
                For Each Columna As DataGridViewColumn In frmConsServicioTecnico.dgvServTecnico.Columns
                    If Columna.HeaderText = "idServicioTecnico" Then
                        Filas.Item("idServicioTecnico") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("idServicioTecnico").Value
                    ElseIf Columna.HeaderText = "CodUN" Then
                        Filas.Item("CodUN") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("CodUN").Value
                    ElseIf Columna.HeaderText = "NroOrden" Then
                        Filas.Item("NroOrden") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("NroOrden").Value
                    ElseIf Columna.HeaderText = "CodBarra" Then
                        Filas.Item("CodBarra") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("CodBarra").Value
                    ElseIf Columna.HeaderText = "Fecha" Then
                        Filas.Item("Fecha") = Format(frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("Fecha").Value, "dd/MM/yyyy")
                    ElseIf Columna.HeaderText = "Clientes_IdClientes" Then
                        Filas.Item("Clientes_idClientes") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("Clientes_IdClientes").Value
                    ElseIf Columna.HeaderText = "CliRS" Then
                        Filas.Item("CliRazonSocial") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("CliRS").Value
                    ElseIf Columna.HeaderText = "CliDir" Then
                        Filas.Item("CliDireccion") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("CliDir").Value
                    ElseIf Columna.HeaderText = "CliLoc" Then
                        Filas.Item("CliLocalidad") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("CliLoc").Value
                    ElseIf Columna.HeaderText = "CliCp" Then
                        Filas.Item("CliCP") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("CliCp").Value
                    ElseIf Columna.HeaderText = "CliProv" Then
                        Filas.Item("CliProvincia") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("CliProv").Value
                    ElseIf Columna.HeaderText = "CliPais" Then
                        Filas.Item("CliPais") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("CliPais").Value
                    ElseIf Columna.HeaderText = "CliTE" Then
                        Filas.Item("CliTE") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("CliTE").Value
                    ElseIf Columna.HeaderText = "CliCuit" Then
                        Filas.Item("CliCUIT") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("CliCuit").Value
                    ElseIf Columna.HeaderText = "TipoEquipo" Then
                        Filas.Item("TipoEquipo") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("TipoEquipo").Value
                    ElseIf Columna.HeaderText = "DetalleEquipo" Then
                        Filas.Item("DetalleEquipo") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("DetalleEquipo").Value
                    ElseIf Columna.HeaderText = "AccesoriosEquipo" Then
                        Filas.Item("AccesoriosEquipo") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("AccesoriosEquipo").Value
                    ElseIf Columna.HeaderText = "EquipoCodBarra" Then
                        Filas.Item("EquipoCodBarra") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("EquipoCodBarra").Value
                    ElseIf Columna.HeaderText = "Problema" Then
                        Filas.Item("Problema") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("Problema").Value
                    ElseIf Columna.HeaderText = "Diagnostico" Then
                        Filas.Item("Diagnostico") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("Diagnostico").Value
                    ElseIf Columna.HeaderText = "FecEstEntrega" Then
                        Filas.Item("FecEstEntrega") = Format(frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("FecEstEntrega").Value, "dd/MM/yyyy")
                    ElseIf Columna.HeaderText = "FecEntrega" Then
                        Filas.Item("FecEntrega") = Format(frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("FecEntrega").Value, "dd/MM/yyyy")
                    ElseIf Columna.HeaderText = "Presupuesto" Then
                        Filas.Item("Presupuesto") = Format(frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("Presupuesto").Value, "$ #,##0.00")
                    ElseIf Columna.HeaderText = "GarantiaMeses" Then
                        Filas.Item("GarantiaMeses") = Format(frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("GarantiaMeses").Value, "#,##0")
                    ElseIf Columna.HeaderText = "VtoGarantia" Then
                        Filas.Item("VtoGarantia") = Format(frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("VtoGarantia").Value, "dd/MM/yyyy")
                    ElseIf Columna.HeaderText = "Facturado" Then
                        Filas.Item("Facturado") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("Facturado").Value
                    ElseIf Columna.HeaderText = "Tercerizado" Then
                        Filas.Item("Tercerizado") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("Tercerizado").Value
                    ElseIf Columna.HeaderText = "PresupuestoProv" Then
                        Filas.Item("PresupuestoProv") = Format(frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("PresupuestoProv").Value, "$ #,##0.00")
                    ElseIf Columna.HeaderText = "FecEntregaProv" Then
                        Filas.Item("FecEntregaProv") = Format(frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("FecEntregaProv").Value, "dd/MM/yyyy")
                    ElseIf Columna.HeaderText = "FecRecepcionProv" Then
                        Filas.Item("FecRecepcionProv") = Format(frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("FecRecepcionProv").Value, "dd/MM/yyyy")
                    ElseIf Columna.HeaderText = "Observaciones" Then
                        Filas.Item("Observaciones") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("Observaciones").Value
                    ElseIf Columna.HeaderText = "Usuario" Then
                        Filas.Item("Usuario") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("Usuario").Value
                    ElseIf Columna.HeaderText = "Estado" Then
                        Filas.Item("Estado") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("Estado").Value
                    ElseIf Columna.HeaderText = "Proveedores_idProveedores" Then
                        Filas.Item("Proveedores_idProveedores") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("Proveedores_idProveedores").Value
                    ElseIf Columna.HeaderText = "ProvRS" Then
                        Filas.Item("ProvRazonSocial") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("ProvRS").Value
                    ElseIf Columna.HeaderText = "ProvDir" Then
                        Filas.Item("ProvDireccion") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("ProvDir").Value
                    ElseIf Columna.HeaderText = "ProvLoc" Then
                        Filas.Item("ProvLocalidad") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("ProvLoc").Value
                    ElseIf Columna.HeaderText = "ProvCP" Then
                        Filas.Item("ProvCp") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("ProvCP").Value
                    ElseIf Columna.HeaderText = "ProvProv" Then
                        Filas.Item("ProvProvincia") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("ProvProv").Value
                    ElseIf Columna.HeaderText = "ProvPais" Then
                        Filas.Item("ProvPais") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("ProvPais").Value
                    ElseIf Columna.HeaderText = "ProvTE" Then
                        Filas.Item("ProvTE") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("ProvTE").Value
                    ElseIf Columna.HeaderText = "ProvCUIT" Then
                        Filas.Item("ProvCUIT") = frmConsServicioTecnico.dgvServTecnico.Rows.Item(i).Cells("ProvCUIT").Value
                    End If
                Next
            Next

            rptST.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            If lblOrigen.Text = "Estado" Then
                rptST.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\rptConSTporEstado.rdlc"
                rptST.LocalReport.DataSources.Clear()
                rptST.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsSTporEstado", _Ds.Tables("dtServTecnicoTodo")))
                rptST.DocumentMapCollapsed = True
                Me.rptST.RefreshReport()
            ElseIf lblOrigen.Text = "Cliente" Then
                rptST.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\rptConsSTporCliente.rdlc"
                rptST.LocalReport.DataSources.Clear()
                rptST.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsSTporCliente", _Ds.Tables("dtServTecnicoTodo")))
                rptST.DocumentMapCollapsed = True
                Me.rptST.RefreshReport()
            ElseIf lblOrigen.Text = "Equipo" Then
                rptST.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\rptConsSTporEquipo.rdlc"
                rptST.LocalReport.DataSources.Clear()
                rptST.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsSTporEquipo", _Ds.Tables("dtServTecnicoTodo")))
                rptST.DocumentMapCollapsed = True
                Me.rptST.RefreshReport()
            End If
        Catch ex As MySqlException
            MsgBox("Error al cargar el informe" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
        End Try

    End Sub
End Class