CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdRecVta`()
BEGIN
	SELECT
		Max(idVentaRecibos) as UltimoId
	FROM
		VentaRecibos;
END