CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdServTecnico`()
BEGIN
	SELECT
		Max(idServicioTecnico) as UltimoId
	FROM
		ServicioTecnico;
END