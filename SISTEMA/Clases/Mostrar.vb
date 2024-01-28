Imports MySql.Data.MySqlClient

Public Class Mostrar
    Public Function verUsuarios()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verUsuario"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Usuarios" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verEmpresa()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verEmpresa"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar datos de las Empresas" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verEmpresaFiltrada(ByVal CdE As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verEmpresaFiltro"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@cdEmp"), MySqlParameter).Value = CdE

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar datos de las Empresas" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function


    Public Function verClientes(ByVal uNN As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verCliente"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@unnC"), MySqlParameter).Value = uNN

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Clientes" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verProveedores(ByVal uNN As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verProveedor"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@unnP"), MySqlParameter).Value = uNN

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Proveedores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verSistema(ByVal uNN As String)
            Try
                Dim _cMd As New MySqlCommand

                BDcnn()
                _cMd.CommandText = "verSistema"
                _cMd.CommandType = CommandType.StoredProcedure
                _cMd.Connection = _cX

                MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@unnS"), MySqlParameter).Value = uNN

                Dim _dA As New MySqlDataAdapter(_cMd)
                Dim _Dt As New DataTable
                _dA.Fill(_Dt)
                BDxxx()

            Return _Dt
            Catch ex As MySqlException
                MsgBox("Error al cargar datos del Sistema" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
                Return Nothing
            Finally
                BDxxx()
            End Try
    End Function

    Public Function verCategorias()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verCategoria"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar Categorías" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verArticulos(ByVal uNN As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verArticulo"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@unnA"), MySqlParameter).Value = uNN

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Artículos" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verStock(ByVal uNN As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verStock"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idartS"), MySqlParameter).Value = uNN

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar stocks" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consStock(ByVal uNN As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "conStock"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idUN"), MySqlParameter).Value = uNN

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar stocks" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consStockID(ByVal ID As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "conStockID"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idStk"), MySqlParameter).Value = ID

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar stocks" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consCtaCteVentaID(ByVal ID As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verCtaCteVtaSaldo"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idCta"), MySqlParameter).Value = ID

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al consultar Cuenta Corriente Venta" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function


    Public Function consCtaCteVentaIDfecDesde(ByVal ID As String, ByVal UNN As String, ByVal FD As Date)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verCtaCteVtaSaldoFd"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idCli"), MySqlParameter).Value = ID
            CType(_cMd.Parameters("@cdUNN"), MySqlParameter).Value = UNN
            CType(_cMd.Parameters("@fecD"), MySqlParameter).Value = FD

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al consultar Cuenta Corriente Venta" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consCtaCteCompraID(ByVal ID As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verCtaCteCompraSaldo"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idCta"), MySqlParameter).Value = ID

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al consultar Cuenta Corriente Venta" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verDetalleFac()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verDetalleFac"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar detalle de factua" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verMaxIdCompraCtaCte()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verMaxIdCompraCtaCte"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Id Cuenta Corriente no identificado" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verMaxIdCompraFacturas()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verMaxIdCompraFacturas"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Id Factura Compra no identificado" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verMaxIdVentaFacturas()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verMaxIdVentaFacturas"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Id Factura Venta no identificado" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verMaxIdVentaCtaCte()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verMaxIdVentaCtaCte"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Id Cuenta Corriente no identificado" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verMaxIdCliente()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verMaxIdCliente"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Id Cliente no identificado" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verMaxIdProveedor()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verMaxIdProveedor"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Id Cliente no identificado" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verMaxIdServTecnico()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verMaxIdServTecnico"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Id Servicio Técnico no identificado" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verMaxIdCaja()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verMaxIdCaja"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Id Cliente no identificado" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verMaxIdCajaPorFecha(ByVal fH As Date)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verMaxIdCajaPorFecha"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@fechasta"), MySqlParameter).Value = fH

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar movimientos de caja diario !" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verMaxIdReciboVta()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verMaxIdRecVta"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar movimientos de caja diario !" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verMaxIdReciboCompra()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verMaxIdRecCompra"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar movimientos de caja diario !" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verMaxIdTC()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verMaxIdTC"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al acceder a la tabla de tipos de cambio !" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function


    Public Function verFormaPagoBf(ByVal PtVt As String, ByVal Nfac As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verFormaPagoBuffer"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@ptovta"), MySqlParameter).Value = PtVt
            CType(_cMd.Parameters("@nrofac"), MySqlParameter).Value = Nfac

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar forma de pago" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verServicioTecnico(ByVal uNN As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "consServTecnico"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@unnST"), MySqlParameter).Value = uNN

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Servicios Tecnicos" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function
    Public Function verServicioTecnicoTodo(ByVal uNN As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "consServTecnicoTodo"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@unnST"), MySqlParameter).Value = uNN

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Servicios Tecnicos" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verServicioTecnicoTodoPorid(ByVal STid As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "consServTecnicoTodoIDst"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@stID"), MySqlParameter).Value = STid

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Servicios Tecnicos" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verServicioTecnicoID(ByVal idST As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verServTecnicoID"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@ID"), MySqlParameter).Value = idST

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Servicios Tecnicos" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verServicioTecnicoEnByB(ByVal uNN As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "consServTecnicoEnByB"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@unnST"), MySqlParameter).Value = uNN

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Servicios Tecnicos" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verServicioTecEntregaRecpcionProv(ByVal uNN As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "consServTecEntRecepProv"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@unnST"), MySqlParameter).Value = uNN

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Servicios Tecnicos" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verServicioTecEntregaRecpcionProvHoy(ByVal uNN As String, ByVal fE As Date)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "consServTecEntRecepProvHoy"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@unnST"), MySqlParameter).Value = uNN
            CType(_cMd.Parameters("@fecEnt"), MySqlParameter).Value = fE

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Servicios Tecnicos" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verServicioTecnicoTerceros(ByVal uNN As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "consServTecnicoTerceros"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@unnST"), MySqlParameter).Value = uNN

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Servicios Tecnicos" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verServicioTecnicoTercerosID(ByVal ST As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "consServTecnicoTercerosPorID"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idST"), MySqlParameter).Value = ST

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Servicios Tecnicos" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verDetalleValoresCaja()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verDetalleCaja"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar detalle de Valores de Caja" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verDetalleValoresRecVta()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verDetalleRecVta"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar detalle de Valores de Recibo Ventas" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verSaldoCajaUltimoId(ByVal iDC As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verSaldoCaja"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idCj"), MySqlParameter).Value = iDC

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los movimientos de caja del día" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verCajaDelDia(ByVal fD As Date, ByVal fH As Date)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verCajaDiaria"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@fecdesdeCD"), MySqlParameter).Value = fD
            CType(_cMd.Parameters("@fechastaCD"), MySqlParameter).Value = fH

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los movimientos de caja del día" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verVAloresEnVartera()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verValoresEnCartera"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar valores en cartera !" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verTipoCambioUltimoId(ByVal iDC As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verTipoCambio"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idCj"), MySqlParameter).Value = iDC

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los movimientos de caja del día" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function



    Public Function infStock(ByVal uNN As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "conStock"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idUN"), MySqlParameter).Value = uNN

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Ds As New dsReportes
            _dA.Fill(_Ds.Tables(0))

            BDxxx()

            Return _Ds
        Catch ex As MySqlException
            MsgBox("Error al cargar stocks" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verEmisionFacVta(ByVal uNN As String, ByVal IDf As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "consEmisionFacVenta"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idUN"), MySqlParameter).Value = uNN
            CType(_cMd.Parameters("@IdCC"), MySqlParameter).Value = IDf

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar Facturas de Venta" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verCtaCteVentaIDCli(ByVal ID As String, ByVal UNN As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verCtaCteVenta"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idCli"), MySqlParameter).Value = ID
            CType(_cMd.Parameters("@cdUNN"), MySqlParameter).Value = UNN

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al consultar Cuenta Corriente Venta" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verCtaCteCompraIDProv(ByVal ID As String, ByVal UNN As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verCtaCteCompra"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idProv"), MySqlParameter).Value = ID
            CType(_cMd.Parameters("@cdUNN"), MySqlParameter).Value = UNN

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al consultar Cuenta Corriente Compra" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verFacturaVenta(ByVal ID As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verFacturaVenta"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idCta"), MySqlParameter).Value = ID

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al consultar Facturas de Venta" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verFacturaCompra(ByVal ID As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verFacturaCompra"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idCta"), MySqlParameter).Value = ID

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al consultar Facturas de Compra" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verDetalleFacturaVenta(ByVal ID As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verDetalleFacturaVenta"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idFac"), MySqlParameter).Value = ID

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al consultar Detalle de Facturas de Venta" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verDetalleFacturaCompra(ByVal ID As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verDetalleFacturaCompra"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idFac"), MySqlParameter).Value = ID

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al consultar Detalle de Facturas de Venta" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verFormaPago(ByVal ID As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verFormaPago"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idCta"), MySqlParameter).Value = ID

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al consultar Detalle de Vencimientos de Facturas de Venta" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verDetalleRecibo(ByVal ID As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verDetalleRecibo"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idRec"), MySqlParameter).Value = ID

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al consultar Detalle de Recibos de Venta" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verDetalleOedenPago(ByVal ID As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verDetalleOrdPago"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idRec"), MySqlParameter).Value = ID

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al consultar Detalle de Orden De Pago A Proveedores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verReciboVenta(ByVal ID As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verReciboVentas"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idRec"), MySqlParameter).Value = ID

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al consultar Recibos de Venta" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verReciboCompra(ByVal ID As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verReciboCompras"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idRec"), MySqlParameter).Value = ID

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al consultar Recibos de Compra" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verTipoCambio()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verTipoCambioTodo"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Tipos de Cambio" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verResumenCtaVta()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verResumenCtaVta"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar Categorías" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verCtaCteVtaDetalleFa(ByVal iDC As Integer, ByVal UN As String, ByVal FD As Date, ByVal FH As Date)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "consCtaCteVtaDetalleFac"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@unnST"), MySqlParameter).Value = UN
            CType(_cMd.Parameters("@idCli"), MySqlParameter).Value = iDC
            CType(_cMd.Parameters("@fecDesde"), MySqlParameter).Value = FD
            CType(_cMd.Parameters("@fecHasta"), MySqlParameter).Value = FH

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar la consulta de cuenta corriente detallada" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verCtaCteVtaDetalleRc(ByVal iDC As Integer, ByVal UN As String, ByVal FD As Date, ByVal FH As Date)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "consCtaCteVtaDetalleRec"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@unnST"), MySqlParameter).Value = UN
            CType(_cMd.Parameters("@idCli"), MySqlParameter).Value = iDC
            CType(_cMd.Parameters("@fecDesde"), MySqlParameter).Value = FD
            CType(_cMd.Parameters("@fecHasta"), MySqlParameter).Value = FH

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar la consulta de cuenta corriente detallada" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consCtaCteVtaporCli(ByVal iDC As Integer, ByVal UN As String, ByVal FD As Date, ByVal FH As Date)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "consCtaCteVentaPorCliente"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@unnST"), MySqlParameter).Value = UN
            CType(_cMd.Parameters("@idCli"), MySqlParameter).Value = iDC
            CType(_cMd.Parameters("@fecDesde"), MySqlParameter).Value = FD
            CType(_cMd.Parameters("@fecHasta"), MySqlParameter).Value = FH

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar la consulta de cuenta corriente detallada" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consVenta(ByVal UN As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "consVentas"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@unnST"), MySqlParameter).Value = UN

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al consultar Detalle de Facturas de Venta" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consCompra(ByVal UN As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "consCompras"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@unnST"), MySqlParameter).Value = UN

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al consultar Detalle de Facturas de Venta" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verArticuloManual()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "verArticuloManual"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Artículos Manuales" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

End Class
