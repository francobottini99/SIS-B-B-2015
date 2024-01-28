CREATE DEFINER=`root`@`localhost` PROCEDURE `verSaldoCaja`(
	in idCj int(11)
)
BEGIN
	SELECT
		*
	FROM
		Caja
	WHERE idCaja = idCj;
END