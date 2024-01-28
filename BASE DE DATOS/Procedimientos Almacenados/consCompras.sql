CREATE DEFINER=`root`@`localhost` PROCEDURE `consCompras`(
	in unnST varchar(45)
)
BEGIN
	SELECT
		CompraFacturas.idCompraFacturas,
        CompraFacturas.CodUN CodUNFac,
        CompraFacturas.CodBarra CodBarraFac,
        CompraFacturas.FechaFac,
        CompraFacturas.NroComprobante,
        CompraFacturas.TipoComprobante,
        CtaCteCompra.ClaseComprobante,
        Proveedores.idProveedores,
        Proveedores.RazonSocial,
        Proveedores.CUIT,
        FacCompraDetalle.idFacCompraDetalle,
        FacCompraDetalle.IdArticulo,
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
        FacCompraDetalle.CodBarra,
        FacCompraDetalle.Detalle,
		FacCompraDetalle.Unidad,
		FacCompraDetalle.Cantidad,
        FacCompraDetalle.Precio,
        FacCompraDetalle.AlIva,
        FacCompraDetalle.Importe,
        FacCompraDetalle.CompraFacturas_idCompraFacturas,
        CompraFacturas.SubTotal,
        CompraFacturas.Descuento,
        CompraFacturas.BaseImponible,
        CompraFacturas.Iva1,
        CompraFacturas.ImpIva1,
        CompraFacturas.Iva2,
        CompraFacturas.ImpIva2,
        CompraFacturas.Iva3,
        CompraFacturas.ImpIva3,
        CompraFacturas.Total,
        CompraFacturas.Observaciones,
		CompraFacturas.CtaCteCompra_idCtaCteCompra
 	FROM
        CtaCteCompra JOIN Proveedores ON CtaCteCompra.Proveedores_idProveedores = Proveedores.ideProveedores
        JOIN CompraFacturas ON CtaCteCompra.idCtaCteCompra = CompraFacturas.CtaCteCompra_idCtaCteCompra
        JOIN FacCompraDetalle ON CompraFacturas.idCompraFacturas = FacCompraDetalle.CompraFacturas_idCompraFacturas
        JOIN Articulos ON Articulos.idArticulos = FacCompraDetalle.IdArticulo
        JOIN Categorias ON Categorias.idCategorias = Articulos.Cat_idCategorias
	WHERE
		CompraFacturas.CodUN = unnST
	ORDER BY CompraFacturas.FechaFac Asc;
END