CREATE DEFINER=`root`@`localhost` PROCEDURE `verReciboVentas`(
	in idRec int(11)
)
BEGIN
	SELECT
		*
	FROM
		VentaRecibos
	WHERE CtaCteVenta_idCtaCteVenta= idRec
	ORDER BY FechaRec Asc;
END