CREATE DEFINER=`root`@`localhost` PROCEDURE `verStock`(
	in ID int(11)
)
BEGIN
	SELECT
		*
	FROM
		Stock
	WHERE TROPA_idTropa = ID
	ORDER BY Fecha Asc;
END