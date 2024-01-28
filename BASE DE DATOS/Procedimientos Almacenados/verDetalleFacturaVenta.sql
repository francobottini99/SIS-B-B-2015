CREATE DEFINER=`root`@`localhost` PROCEDURE `verDetalleFacturaVenta`(
	in idFac int(11)
)
BEGIN
	SELECT
		*
	FROM
		FacVentaDetalle
	WHERE VentaFacturas_idFacturas = idFac
	ORDER BY idFacturaDetalle Asc;
END