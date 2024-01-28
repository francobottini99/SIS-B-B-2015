CREATE DEFINER=`root`@`localhost` PROCEDURE `verValoresEnCartera`()
BEGIN
	SELECT
		*
	FROM
		CajaDetalle
	WHERE
		EnCartera = "Si"
	ORDER BY FecCobro Asc;
END