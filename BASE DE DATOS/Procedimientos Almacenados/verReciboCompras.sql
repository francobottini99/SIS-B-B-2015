CREATE DEFINER=`root`@`localhost` PROCEDURE `verReciboCompras`(
	in idRec int(11)
)
BEGIN
	SELECT
		*
	FROM
		CompraRecibos
	WHERE CtaCteCompra_idCtaCteCompra = idRec
	ORDER BY FechaRec Asc;
END