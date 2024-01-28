CREATE DEFINER=`root`@`localhost` PROCEDURE `verDetalleFacturaCompra`(
	in idFac int(11)
)
BEGIN
	SELECT
		*
	FROM
		FacCompraDetalle
	WHERE CompraFacturas_idCompraFacturas = idFac
	ORDER BY idFacCompraDetalle Asc;
END