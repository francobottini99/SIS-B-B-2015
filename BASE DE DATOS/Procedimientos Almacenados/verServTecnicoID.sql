CREATE DEFINER=`root`@`localhost` PROCEDURE `verServTecnicoID`(
	in ID int(11)
)
BEGIN
	SELECT
		*
	FROM
		ServicioTecnico
	WHERE idServicioTecnico = ID
	ORDER BY Fecha Asc;
END