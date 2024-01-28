CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdCajaPorFecha`(
	in fechasta date
)
BEGIN
	SELECT
		Max(idCaja) as UltimoId
	FROM
		Caja
	WHERE
		Fecha <= fechasta;
END