CREATE DEFINER=`root`@`localhost` PROCEDURE `verDetalleRecibo`(
	in idRec int(11)
)
BEGIN
	SELECT
		*
	FROM
		VentaRecDetalle
	WHERE VentaRecibos_idVentaRecibos = idRec
	ORDER BY idReciboDetalle Asc;
END
