CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdTC`()
BEGIN
	SELECT
		Max(idTipoCambio) as UltimoId
	FROM
		TipoCambio;
END