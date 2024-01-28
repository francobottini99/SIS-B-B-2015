CREATE DEFINER=`root`@`localhost` PROCEDURE `consCtaCteVtaDetalleRec`(
	in unnST varchar(45),
    in idCli int(11),
    in fecDesde date,
    in fecHasta date
)
BEGIN
	SELECT
		CtaCteVenta.idCtaCteVenta,
        CtaCteVenta.CodUN,
        CtaCteVenta.CodBarra,
        CtaCteVenta.Fecha,
        Clientes.idClientes,
        Clientes.RazonSocial,
        Clientes.Direccion,
        Clientes.Localidad,
        Clientes.CP,
        Clientes.Provincia,
        Clientes.Pais,
		Clientes.TE,
		Clientes.CUIT,
        Clientes.IIBB,
        Clientes.CategoriaIVA,
        Clientes.Credito,
        Clientes.Estado,
        CtaCteVenta.FormaPago,
        CtaCteVenta.ClaseComprobante,
        CtaCteVenta.TipoComprobante,
        CtaCteVenta.CodComprobante,
        CtaCteVenta.PtoVta,
        CtaCteVenta.NroComprobante,
        VentaRecibos.TipoRecibo,
        VentaRecibos.Importe,
        VentaRecibos.Observaciones,
        VentaRecDetalle.TipoValor,
        VentaRecDetalle.NroValor,
        VentaRecDetalle.FecCobro,
        VentaRecDetalle.Librador,
        VentaRecDetalle.Banco,
        VentaRecDetalle.SucursalPago,
        VentaRecDetalle.ImporteValor,
        CtaCteVenta.Debito,
        CtaCteVenta.Credito,
        CtaCteVenta.Saldo,
        CtaCteVenta.Usuario,
        CtaCteVenta.Clientes_idClientes
	FROM
		Clientes JOIN CtaCteVenta ON Clientes.IdClientes = CtaCteVenta.Clientes_IdClientes
        JOIN VentaRecibos ON VentaRecibos.CtaCteVenta_idCtaCteVenta = CtaCteVenta.idCtaCteVenta
        JOIN VentaRecDetalle ON VentaRecDetalle.VentaRecibos_idVentaRecibos = VentaRecibos.idVentaRecibos
	WHERE
		CtaCteVenta.CodUN = unnST And Clientes.idClientes = idCli And CtaCteVenta.Fecha >= fecDesde And CtaCteVenta.Fecha <= fecHasta
	ORDER BY CtaCteVenta.Fecha Asc;
END