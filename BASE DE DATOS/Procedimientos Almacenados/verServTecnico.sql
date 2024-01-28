CREATE DEFINER=`root`@`localhost` PROCEDURE `verServTecnico`(
	in unnST varchar(45)
)
BEGIN
	SELECT
		*
	FROM
		ServicioTecnico
	WHERE CodUN = unnST 
	ORDER BY Fecha Asc;
END