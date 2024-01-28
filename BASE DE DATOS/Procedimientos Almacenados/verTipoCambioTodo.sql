CREATE DEFINER=`root`@`localhost` PROCEDURE `verTipoCambioTodo`(
)
BEGIN
	SELECT
		*
	FROM
		TipoCambio
	ORDER BY Fecha Asc;
END