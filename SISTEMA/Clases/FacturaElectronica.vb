Public Class FacturaElectronica

    Public respAFIP As String
    Public nroCAE As String
    Public vtoCAE As String
    Public nroAutorizado As Integer

    Public Function PedirCAE(ByVal ModoTrabajo As Integer, ByVal UNN As String, ByVal cuitEmp As String, ByVal rutaCert As String, _
                             ByVal certPC As String, ByVal tkAcc As String, ByVal ParamArray dtoFe() As String)

        ' DETALLE DE PARAMETROS QUE RECIBE LA FUNCIÓN EN LA VARIABLE dtoFe()
        '------------------------------------------------------------------------------------------------------
        ' 01 - Cantidad de Registros a autorizar
        ' 02 - Tipo de Comprobante (Factura A, Factura B, ND, NC, etc)
        ' 03 - Punto de Venta
        ' 04 - Concepto (1 - Productos, 2 - Servicios, 3 - Productos y Servicios)
        ' 05 - Tipo de Documento (Cuit)
        ' 06 - Número de Documento (Nro Cuit)
        ' 07 - Comprobante Desde (Número desde)
        ' 08 - Comprobante Hasta (Número hasta)
        ' 09 - Fecha del Comprobante
        ' 10 - Importe Total (Neto No Gravado + Exento + Neto Gravado + Todos los IVAs + Tributos)
        ' 11 - Importe Neto No Gravado
        ' 12 - Importe Neto Gravado
        ' 13 - Importe Exento
        ' 14 - Importe IVA (Suma de todos los IVAS)
        ' 15 - Importe Tributos (Suma de todos los tributos)
        ' 16 - Fecha Servicio Desde (Fecha de INICIO abono para el servicio facturado)
        ' 17 - Fecha Servicio Hasta (Fecha de FIN abono para el servicio facturado)
        ' 18 - Fecha Vencimiento de Pago (Fecha de VENCIMIENTO para el servicio facturado)
        ' 19 - Moneda ID (Código de Moneda con la quie se factura)
        ' 20 - Cotización de Moneda
        ' 21 - Comprobantes Asociados (Array que informa comprobantes asociados)
        ' 22 al 32 - Tributos Asociados (Array que informa tributos asociados; hasta 3 tributos)
        ' 33 al 42 - IVA (Array que informa alicuotas y sus importes asociados; hasta 5 tipo de iva)
        ' 43 -  Opcionales
        '------------------------------------------------------------------------------------------------------

        'Creo el objeto (factura electronica) para operar
        '--------------------------------------------------------------------------------------------------------
        Dim FE As New WSAFIPFE.Factura
        Dim _Guardar As New GrabaDatos

        'Variables para iniciar seción
        '--------------------------------------------------------------------------------------------------------
        Dim CAEresultado As Boolean = True 'True = todo OK, False = Error en algún paso
        Dim X As Integer
        Dim cuitSinGuionE As String = ""
        Dim cuitSinGuion As String = ""
        Dim fecSinGuion As String = ""
        Dim Nn As String
        Dim tktOK As Boolean = True
        respAFIP = "R"
        nroCAE = ""
        nroAutorizado = 0

        ' 01 CantReg
        '--------------------------------------------------------------------------------------------------------
        FE.F1CabeceraCantReg = 1

        ' 02 CbteTipo
        '--------------------------------------------------------------------------------------------------------
        Select Case dtoFe(2)
            Case "Factura A"
                dtoFe(2) = WSAFIPFE.Factura.TipoComprobante.FacturaA
            Case "Factura B"
                dtoFe(2) = WSAFIPFE.Factura.TipoComprobante.FacturaB
            Case "Factura C"
                dtoFe(2) = WSAFIPFE.Factura.TipoComprobante.FacturaC
            Case "Nota Credito A"
                dtoFe(2) = WSAFIPFE.Factura.TipoComprobante.NotaCreditoA
            Case "Nota Credito B"
                dtoFe(2) = WSAFIPFE.Factura.TipoComprobante.NotaCreditoB
            Case "Nota Credito C"
                dtoFe(2) = WSAFIPFE.Factura.TipoComprobante.NotaCreditoC
            Case "Nota Debito A"
                dtoFe(2) = WSAFIPFE.Factura.TipoComprobante.NotaDebitoA
            Case "Nota Debito B"
                dtoFe(2) = WSAFIPFE.Factura.TipoComprobante.NotaDebitoB
            Case "Nota Debito C"
                dtoFe(2) = WSAFIPFE.Factura.TipoComprobante.NotaDebitoC
        End Select
        FE.F1CabeceraCbteTipo = CInt(dtoFe(2))

        ' 03 PtoVta
        '--------------------------------------------------------------------------------------------------------
        FE.F1CabeceraPtoVta = CInt(dtoFe(3))

        ' Quito los guiones del cuit de la empresa
        '--------------------------------------------------------------------------------------------------------
        For X = 1 To Len(cuitEmp)
            Nn = Mid(cuitEmp, X, 1)
            If IsNumeric(Nn) Then
                cuitSinGuionE = cuitSinGuionE & Nn
            End If
        Next X

        If ModoTrabajo = 0 Then
            'Inicio Seción modo prueba
            '--------------------------------------------------------------------------------------------------------
            CAEresultado = FE.iniciar(0, cuitSinGuionE, rutaCert & certPC, "")
        Else
            'Inicio Seción modo WebService operativo
            '--------------------------------------------------------------------------------------------------------
            CAEresultado = FE.iniciar(1, cuitSinGuionE, rutaCert & certPC, "C:\Sistema B&B\Certificados\WSAFIPFE.lic")
            FE.ArchivoCertificadoPassword = "cjb23"
        End If

        If CAEresultado Then 'Si inicio seción correctamente
            FE.f1RestaurarTicketAcceso(tkAcc)
            If Not FE.f1TicketEsValido() Then 'Si tiket NO está vigente
                If FE.f1ObtenerTicketAcceso() Then 'Pido nuevo tiket
                    tkAcc = FE.f1GuardarTicketAcceso()
                    'Guardo nuevo tiket obtenido
                    _Guardar.Grabar("Factura Electronica", "NoImagen", "modSistemaTiketAcceso", UNN, tkAcc)
                Else 'Si falla obtener tiket de acceso
                    tktOK = False
                End If
            End If

            If tktOK = True Then
                'Obtener Número de Orden (ultimo autorizado)
                '-----------------------------------------------------------------------------------------------------
                nroAutorizado = FE.F1CompUltimoAutorizado(CInt(dtoFe(3)), CInt(dtoFe(2)))
                nroAutorizado += 1
                dtoFe(7) = nroAutorizado
                dtoFe(8) = nroAutorizado
            End If

            If nroAutorizado > 0 Then 'Si otorga número
                'Comienza procedimiento para pedir CAE
                '-----------------------------------------------------------------------------------------------------
                FE.f1Indice = 0

                ' 04 Concepto
                '--------------------------------------------------------------------------------------------------------
                FE.F1DetalleConcepto = CInt(dtoFe(4))

                ' 05 TipoDoc
                '--------------------------------------------------------------------------------------------------------
                FE.F1DetalleDocTipo = WSAFIPFE.Factura.TipoDocumento.CUIT

                ' 06 NroDoc sin guiones
                '--------------------------------------------------------------------------------------------------------
                For X = 1 To Len(dtoFe(6))
                    Nn = Mid(dtoFe(6), X, 1)
                    If IsNumeric(Nn) Then
                        cuitSinGuion = cuitSinGuion & Nn
                    End If
                Next X
                FE.F1DetalleDocNro = CDbl(cuitSinGuion)

                ' 07 CbteDesde
                '--------------------------------------------------------------------------------------------------------
                FE.F1DetalleCbteDesde = CInt(dtoFe(7))

                ' 08 CbteHasta
                '--------------------------------------------------------------------------------------------------------
                FE.F1DetalleCbteHasta = CInt(dtoFe(8))

                ' 09 FecCbte
                '--------------------------------------------------------------------------------------------------------
                For X = 1 To Len(dtoFe(9))
                    Nn = Mid(dtoFe(9), X, 1)
                    If IsNumeric(Nn) Then
                        fecSinGuion = fecSinGuion & Nn
                    End If
                Next X
                FE.F1DetalleCbteFch = fecSinGuion

                ' 10 ImpTotal
                '--------------------------------------------------------------------------------------------------------
                FE.F1DetalleImpTotal = Math.Round(CDbl(dtoFe(10)), 2)

                ' 11 ImpNoGrav
                '--------------------------------------------------------------------------------------------------------
                FE.F1DetalleImpTotalConc = Math.Round(CDbl(dtoFe(11)), 2)

                ' 12 ImpGravado
                '--------------------------------------------------------------------------------------------------------
                FE.F1DetalleImpNeto = Math.Round(CDbl(dtoFe(12)), 2)

                ' 13 ImpExento
                '--------------------------------------------------------------------------------------------------------
                FE.F1DetalleImpOpEx = Math.Round(CDbl(dtoFe(13)), 2)

                ' 14 ImpIva
                '--------------------------------------------------------------------------------------------------------
                FE.F1DetalleImpIva = Math.Round(CDbl(dtoFe(14)), 2)

                ' 15 ImpTrib
                '--------------------------------------------------------------------------------------------------------
                FE.F1DetalleImpTrib = Math.Round(CDbl(dtoFe(15)), 2)

                If CInt(dtoFe(4)) > 1 Then

                    ' 16 FecServDesde
                    '--------------------------------------------------------------------------------------------------------
                    fecSinGuion = ""
                    For X = 1 To Len(dtoFe(16))
                        Nn = Mid(dtoFe(16), X, 1)
                        If IsNumeric(Nn) Then
                            fecSinGuion = fecSinGuion & Nn
                        End If
                    Next X
                    FE.F1DetalleFchServDesde = fecSinGuion

                    ' 17 FecServHasta
                    '--------------------------------------------------------------------------------------------------------
                    fecSinGuion = ""
                    For X = 1 To Len(dtoFe(17))
                        Nn = Mid(dtoFe(17), X, 1)
                        If IsNumeric(Nn) Then
                            fecSinGuion = fecSinGuion & Nn
                        End If
                    Next X
                    FE.F1DetalleFchServHasta = fecSinGuion

                    ' 18 FecVtoPago
                    '--------------------------------------------------------------------------------------------------------
                    fecSinGuion = ""
                    For X = 1 To Len(dtoFe(18))
                        Nn = Mid(dtoFe(18), X, 1)
                        If IsNumeric(Nn) Then
                            fecSinGuion = fecSinGuion & Nn
                        End If
                    Next X
                    FE.F1DetalleFchVtoPago = fecSinGuion

                End If

                ' 19 MonId
                '--------------------------------------------------------------------------------------------------------
                FE.F1DetalleMonId = dtoFe(19)

                ' 20 MonCotiz
                '--------------------------------------------------------------------------------------------------------
                FE.F1DetalleMonCotiz = Math.Round(CDbl(dtoFe(20)), 2)

                ' 21 CbtesAsoc
                '--------------------------------------------------------------------------------------------------------
                FE.F1DetalleCbtesAsocItemCantidad = CInt(dtoFe(21))
                FE.f1IndiceItem = 0
                FE.F1DetalleCbtesAsocTipo = Factura.TipoComprobante.FacturaA
                FE.F1DetalleCbtesAsocPtoVta = 6
                FE.F1DetalleCbtesAsocNro = 710
                FE.F1DetalleCbtesAsocCUIT = "20135200655"
                FE.F1DetalleCbtesAsocCbteFch = "20210725"

                If CDbl(dtoFe(15)) > 0 Then
                    ' 22 Tributos
                    '--------------------------------------------------------------------------------------------------------
                    Dim Y As Integer = 0
                    FE.F1DetalleTributoItemCantidad = CInt(dtoFe(22)) 'Cantidad de tributos
                    For X = 0 To CInt(dtoFe(22)) - 1
                        FE.f1IndiceItem = X
                        FE.F1DetalleTributoId = CInt(dtoFe(23 + Y))
                        FE.F1DetalleTributoDesc = dtoFe(24 + Y)
                        FE.F1DetalleTributoBaseImp = Math.Round(CDbl(dtoFe(25 + Y)), 2)
                        FE.F1DetalleTributoAlic = Math.Round(CDbl(dtoFe(26 + Y)), 2)
                        FE.F1DetalleTributoImporte = Math.Round(CDbl(dtoFe(27 + Y)), 2)
                        Y = Y + 5
                    Next
                End If

                If CDbl(dtoFe(14)) > 0 Then
                    ' 23 IVA
                    '--------------------------------------------------------------------------------------------------------
                    Dim Y As Integer = 0
                    FE.F1DetalleIvaItemCantidad = CInt(dtoFe(33)) 'Cantidad de tributos
                    For X = 0 To CInt(dtoFe(33)) - 1
                        FE.f1IndiceItem = X
                        FE.F1DetalleIvaId = CInt(dtoFe(34 + Y))
                        FE.F1DetalleIvaBaseImp = Math.Round(CDbl(dtoFe(35 + Y)), 2)
                        FE.F1DetalleIvaImporte = Math.Round(CDbl(dtoFe(36 + Y)), 2)
                        Y = Y + 3
                    Next
                End If

                ' 24 Opcionales
                '--------------------------------------------------------------------------------------------------------
                FE.F1DetalleOpcionalItemCantidad = CDbl(dtoFe(43))

                ' Solicito CAE y analizo resultados
                '--------------------------------------------------------------------------------------------------------
                CAEresultado = FE.F1CAESolicitar()

                If CAEresultado Then
                    respAFIP = FE.F1RespuestaDetalleResultado
                    If respAFIP = "R" Then
                        MsgBox("Respuesta Servidor: " & FE.F1RespuestaDetalleObservacionMsg1 & " *-* " & FE.UltimoMensajeError)
                    Else
                        nroCAE = FE.F1RespuestaDetalleCae
                        vtoCAE = FE.F1RespuestaDetalleCAEFchVto
                    End If
                Else
                    respAFIP = FE.F1RespuestaDetalleResultado
                    MsgBox("Respuesta Servidor: " & FE.F1RespuestaDetalleObservacionMsg1 & " *-* " & FE.UltimoMensajeError)
                End If

                Return respAFIP

            Else 'No otorgo comprobante. Error en tiket acceso o en obtencion de número comprobante
                FE.f1Indice = 0
                If tktOK = False Then
                    MsgBox("Error Tiket de Acceso: " & FE.UltimoMensajeError & " - " & FE.F1RespuestaDetalleObservacionMsg1)
                Else
                    MsgBox("Error Numero de Comprobante: " & FE.UltimoMensajeError & " - " & FE.F1RespuestaDetalleObservacionMsg1)
                End If

                Return respAFIP

            End If
        Else 'No pudo iniciar seción
            MsgBox("Error Inicion Seción con Servidor AFIP: " & FE.UltimoMensajeError & " - " & FE.F1RespuestaDetalleObservacionMsg1)

            Return respAFIP

        End If

    End Function

End Class
