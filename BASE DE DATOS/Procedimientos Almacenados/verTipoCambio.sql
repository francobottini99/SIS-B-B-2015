CREATE DEFINER=`root`@`localhost` PROCEDURE `verTipoCambio`(
	in idCj int(11)
)
BEGIN
	SELECT
		*
	FROM
		TipoCambio
	WHERE idTipoCambio = idCj;
END