CREATE DEFINER=`root`@`localhost` PROCEDURE `verDetalleRecVta`()
BEGIN
	SELECT
		*
	FROM
		VentaRecDetalleBuff
	ORDER BY idReciboDetalle Asc;
END