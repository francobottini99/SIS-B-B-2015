CREATE DEFINER=`root`@`localhost` PROCEDURE `verDetalleOrdPago`(
	in idRec int(11)
)
BEGIN
	SELECT
		*
	FROM
		CompraRecDetalle
	WHERE CompraRecibos_idCompraRecibos = idRec
	ORDER BY idCompraRecDetalle Asc;
END