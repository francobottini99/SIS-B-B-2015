CREATE DEFINER=`root`@`localhost` PROCEDURE `consCtaCteVtaDetalleFac`(
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
        VentaFacturas.SubTotal,
        VentaFacturas.Descuento,
        VentaFacturas.BaseImponible,
        VentaFacturas.Iva1,
        VentaFacturas.ImpIva1,
        VentaFacturas.Iva2,
        VentaFacturas.ImpIva2,
        VentaFacturas.Iva3,
        VentaFacturas.ImpIva3,
        VentaFacturas.Total,
        VentaFacturas.Observaciones,
        FacVentaDetalle.Detalle,
        FacVentaDetalle.Unidad,
        FacVentaDetalle.Cantidad,
        FacVentaDetalle.Precio,
        FacVentaDetalle.AlIva,
        FacVentaDetalle.Importe,
        CtaCteVenta.Debito,
        CtaCteVenta.Credito,
        CtaCteVenta.Saldo,
        CtaCteVenta.Usuario,
        CtaCteVenta.Clientes_idClientes
	FROM
		Clientes JOIN CtaCteVenta ON Clientes.IdClientes = CtaCteVenta.Clientes_IdClientes
        JOIN VentaFacturas ON VentaFacturas.CtaCteVenta_idCtaCteVenta = CtaCteVenta.idCtaCteVenta
        JOIN FacVentaDetalle ON FacVentaDetalle.VentaFacturas_idFacturas = VentaFacturas.idFacturas
	WHERE
		CtaCteVenta.CodUN = unnST And Clientes.idClientes = idCli And CtaCteVenta.Fecha >= fecDesde And CtaCteVenta.Fecha <= fecHasta
	ORDER BY CtaCteVenta.Fecha Asc;
END