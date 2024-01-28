Imports System.Windows.Forms

Public Class mdiFrmPpal

    Public cdEmp, cuitEmp, rutaCertPC, certificadoPC, usSis, catUsSis As String
    Public tcErr As String
    Public tpCb As Double
    Public ulTfecTc As Date

    Public encForm As String

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub frmPpal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Me.tcErr = "Ok" Then
                BDcnn()
                ssEstado.Items(0).Text = "| Status = Sistema Ok, conección al servidor exitosa ! |"
                ssEstado.Items(1).Text = " Fecha =  " & Date.Now.Date & " |"
                ssEstado.Items(2).Text = " Hora =  " & Date.Now.ToString("HH:mm:ss") & " |"
                ssEstado.Items(3).Text = " Tipo Cambio: =  [ " & Format(Me.tpCb, "$ #,##0.00") & " ]  |"
                Me.Text = encForm
                BDxxx()

                rutaCertPC = "C:\Sistema B&B\Certificados\"
                certificadoPC = "CertificadoByBServidorWebService.pfx"
            Else
                BDcnn()
                ssEstado.Items(0).Text = "| Status = Sistema Ok, conección al servidor exitosa ! |"
                ssEstado.Items(1).Text = " Fecha =  " & Date.Now.Date & " |"
                ssEstado.Items(2).Text = " Hora =  " & Date.Now.ToString("HH:mm:ss") & " |"
                ssEstado.Items(3).ForeColor = Color.Red
                ssEstado.Items(3).Text = " Tipo Cambio: =  [ " & Format(Me.tpCb, "$ #,##0.00") & " ] -> [ " & Me.ulTfecTc & " ] -> ¡NO ACTUALIZADO!  |"
                Me.Text = encForm
                BDxxx()

                rutaCertPC = "C:\Sistema B&B\Certificados\"
                certificadoPC = "CertificadoByBServidorWebService.pfx"
            End If
        Catch ex As Exception
            ssEstado.Items(0).ForeColor = Color.Red
            ssEstado.Items(0).Text = "| Status = Sistema sin conexión al servidor ! |"
            ssEstado.Items(1).Text = " Fecha =  " & Date.Now.Date & " |"
            ssEstado.Items(2).Text = " Hora =  " & Now.ToString("HH:mm:ss") & " |"
            ssEstado.Items(3).ForeColor = Color.Red
            ssEstado.Items(3).Text = " Tipo Cambio: =  [ " & Format(Me.tpCb, "$ #,##0.00") & " ] -> ¡NO ACTUALIZADO!  |"
        End Try
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        End
    End Sub

    Private Sub PruebaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PruebaToolStripMenuItem.Click
        frmUsuarios.MdiParent = Me
        frmUsuarios.Show()
    End Sub

    Private Sub EmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresaToolStripMenuItem.Click
        frmEmpresa.MdiParent = Me
        frmEmpresa.Show()
    End Sub

    Private Sub AltaBajaModificacionesToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles AltaBajaModificacionesToolStripMenuItem3.Click
        frmClientes.MdiParent = Me
        frmClientes.Show()
    End Sub

    Private Sub AltaBajaModificacionesToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles AltaBajaModificacionesToolStripMenuItem4.Click
        frmProveedores.MdiParent = Me
        frmProveedores.Show()
    End Sub

    Private Sub CategoríasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoríasToolStripMenuItem.Click
        frmArtCategorias.MdiParent = Me
        frmArtCategorias.Show()
    End Sub

    Private Sub AltaBajaModificacionesToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles AltaBajaModificacionesToolStripMenuItem5.Click
        frmArticulos.MdiParent = Me
        frmArticulos.Show()
    End Sub

    Private Sub MantenimientoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MantenimientoToolStripMenuItem1.Click
        frmStock.MdiParent = Me
        frmStock.Show()
    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultasToolStripMenuItem.Click
        frmConsStock.MdiParent = Me
        frmConsStock.Show()
    End Sub

    Private Sub RegistraFacturaNCNDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistraFacturaNCNDToolStripMenuItem.Click
        frmFacturaCompra.MdiParent = Me
        frmFacturaCompra.Show()
    End Sub

    Private Sub FacturaNDNCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturaNDNCToolStripMenuItem.Click
        frmFacturaVentas.MdiParent = Me
        frmFacturaVentas.Show()
    End Sub

    Private Sub OrdenDeServicioTécnicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenDeServicioTécnicoToolStripMenuItem.Click
        frmServTecnico.MdiParent = Me
        frmServTecnico.Show()
    End Sub

    Private Sub DiagnósticoYPresupuestosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiagnósticoYPresupuestosToolStripMenuItem.Click
        frmSTDiagPresupuesto.MdiParent = Me
        frmSTDiagPresupuesto.Show()
    End Sub

    Private Sub tmrHora_Tick(sender As Object, e As EventArgs) Handles tmrHora.Tick
        ssEstado.Items(2).Text = " Hora =  " & Date.Now.ToString("HH:mm:ss") & " |"
    End Sub

    Private Sub ConsultasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EntregasYGarantiasToolStripMenuItem1.Click
        frmSTGarantiayOtros.MdiParent = Me
        frmSTGarantiayOtros.Show()
    End Sub

    Private Sub EntregaYRecpciónServTécnicoTercerizadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntregaYRecpciónServTécnicoTercerizadoToolStripMenuItem.Click
        frmSTEntregaRecep.MdiParent = Me
        frmSTEntregaRecep.Show()
    End Sub

    Private Sub TercerizacionDeServTécnicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TercerizacionDeServTécnicoToolStripMenuItem.Click
        frmSTPresupuestoTerceros.MdiParent = Me
        frmSTPresupuestoTerceros.Show()
    End Sub

    Private Sub ModificacionesDeOrdenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultasDeOrdenesToolStripMenuItem.Click
        frmConsServicioTecnico.MdiParent = Me
        frmConsServicioTecnico.Show()
    End Sub

    Private Sub RegistroManualDeMovimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroManualDeMovimientosToolStripMenuItem.Click
        frmCaja.MdiParent = Me
        frmCaja.Show()
    End Sub

    Private Sub EmitirRecibosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmitirRecibosToolStripMenuItem.Click
        frmRecibosVenta.MdiParent = Me
        frmRecibosVenta.Show()
    End Sub

    Private Sub OrdenDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenDePagoToolStripMenuItem.Click
        frmReciboCompra.MdiParent = Me
        frmReciboCompra.Show()
    End Sub

    Private Sub CuentaCorrienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentaCorrienteToolStripMenuItem.Click
        frmCtaCteVenta.MdiParent = Me
        frmCtaCteVenta.Show()
    End Sub

    Private Sub IngresoChequeraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoChequeraToolStripMenuItem.Click
        frmIngresoChequera.MdiParent = Me
        frmIngresoChequera.Show()
    End Sub

    Private Sub CuentaCorrienteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CuentaCorrienteToolStripMenuItem1.Click
        frmCtaCteCompra.MdiParent = Me
        frmCtaCteCompra.Show()
    End Sub

    Private Sub TipoCambioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoCambioToolStripMenuItem.Click
        frmTipoCambio.MdiParent = Me
        frmTipoCambio.Show()
    End Sub

    Private Sub ResumenDeDeudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResumenDeDeudaToolStripMenuItem.Click
        frmResumenDeuda.MdiParent = Me
        frmResumenDeuda.Show()
    End Sub

    Private Sub ConsultaDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeVentasToolStripMenuItem.Click
        frmConsVentas.MdiParent = Me
        frmConsVentas.Show()
    End Sub

    Private Sub ActualizarPreciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarPreciosToolStripMenuItem.Click
        frmActualizarPrecios.MdiParent = Me
        frmActualizarPrecios.Show()
    End Sub

    Private Sub ConsultaDeComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeComprasToolStripMenuItem.Click
        frmConsCompras.MdiParent = Me
        frmConsCompras.Show()
    End Sub
End Class
