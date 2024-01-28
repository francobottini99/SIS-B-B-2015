CREATE DEFINER=`root`@`localhost` PROCEDURE `consVentas`(
	in unnST varchar(45)
)
BEGIN
	SELECT
		VentaFacturas.idFacturas,
        VentaFacturas.CodUN CodUNFac,
        VentaFacturas.CodBarra CodBarraFac,
        VentaFacturas.FechaFac,
        VentaFacturas.PtoVta,
        VentaFacturas.NroFactura,
        VentaFacturas.TipoFactura,
        CtaCteVenta.ClaseComprobante,
        Clientes.idClientes,
        Clientes.RazonSocial,
        Clientes.CUIT,
        FacVentaDetalle.idFacturaDetalle,
        FacVentaDetalle.IdArticulo,
        Articulos.idArticulos,
        Articulos.CodUN CodUNArt,
        Articulos.FecAlta,
        Articulos.CodCategoria CodCatArt,
        Articulos.Cat_idCategorias,
        Categorias.idCategorias,
        Categorias.CodRubro,
        Categorias.CodSubRubro,
        Categorias.CodCategoria CodCatCategorias,
        Categorias.DescRubro,
        Categorias.DescSubRubro,
        Categorias.DescCategoria,
        Categorias.CodResumen,
        FacVentaDetalle.CodBarra,
        FacVentaDetalle.Detalle,
		FacVentaDetalle.Unidad,
		FacVentaDetalle.Cantidad,
        FacVentaDetalle.Precio,
        FacVentaDetalle.AlIva,
        FacVentaDetalle.Importe,
        FacVentaDetalle.VentaFacturas_idFacturas,
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
		VentaFacturas.CAE,
        VentaFacturas.VtoCAE,
        VentaFacturas.CtaCteVenta_idCtaCteVenta
 	FROM
        CtaCteVenta JOIN Clientes ON CtaCteVenta.Clientes_idClientes = Clientes.idClientes
        JOIN VentaFacturas ON CtaCteVenta.idCtaCteVenta = VentaFacturas.CtaCteVenta_idCtaCteVenta
        JOIN FacVentaDetalle ON VentaFacturas.idFacturas = FacVentaDetalle.VentaFacturas_idFacturas
        JOIN Articulos ON Articulos.idArticulos = FacVentaDetalle.IdArticulo
        JOIN Categorias ON Categorias.idCategorias = Articulos.Cat_idCategorias
	WHERE
		VentaFacturas.CodUN = unnST
	ORDER BY VentaFacturas.FechaFac Asc;
END