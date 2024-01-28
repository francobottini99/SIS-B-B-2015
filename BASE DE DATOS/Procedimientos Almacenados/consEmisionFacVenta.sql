CREATE DEFINER=`root`@`localhost` PROCEDURE `consEmisionFacVenta`(
	in idUN varchar(45),
    in IdCC int(11)
)
BEGIN
	SELECT
		VentaFacturas.IdFacturas,
		VentaFacturas.CodUN,
		VentaFacturas.CodBarra,
		VentaFacturas.FechaFac,
		VentaFacturas.PtoVta,
		VentaFacturas.NroFactura,
		CtaCteVenta.TipoComprobante,
        CtaCteVenta.ClaseComprobante,
        CtaCteVenta.CodComprobante,
		Clientes.IdClientes,
		Clientes.RazonSocial,
		Clientes.Direccion,
		Clientes.Localidad,
        Clientes.CP,
        Clientes.Provincia,
        Clientes.Pais,
        Clientes.CUIT,
        Clientes.IIBB,
        Clientes.CategoriaIVA,
        FacVentaDetalle.IdArticulo,
        FacVentaDetalle.CodBarra,
        FacVentaDetalle.Detalle,
        FacVentaDetalle.Unidad,
        FacVentaDetalle.Cantidad,
        FacVentaDetalle.Precio,
        FacVentaDetalle.AlIva,
        FacVentaDetalle.Importe,
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
        VentaFacturas.Usuario,
        VentaFacturas.CAE,
        VentaFacturas.VtoCAE,
        VentaFacturas.Impreso,
        VentaFacturas.FecImpresion
	FROM
		Clientes JOIN CtaCteVenta ON CtaCteVenta.Clientes_idClientes = Clientes.idClientes
		JOIN VentaFacturas ON VentaFacturas.CtaCteVenta_idCtaCteVenta = CtaCteVenta.idCtaCteVenta
		JOIN FacVentaDetalle ON FacVentaDetalle.VentaFacturas_idFacturas = VentaFacturas.idFacturas
	WHERE
		Clientes.CodUN = idUN And VentaFacturas.idFacturas = IdCC
	ORDER BY FacVentaDetalle.idFacturaDetalle Asc;
END