CREATE DEFINER=`root`@`localhost` PROCEDURE `verFacturaVenta`(
	in idCta int(11)
)
BEGIN
	SELECT
		*
	FROM
		VentaFacturas
	WHERE CtaCteVenta_idCtaCteVenta = idCta
	ORDER BY FechaFac Asc;
END