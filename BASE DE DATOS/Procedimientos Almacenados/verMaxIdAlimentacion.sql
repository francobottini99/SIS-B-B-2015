CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdAlimentacion`()
BEGIN
	SELECT
		Max(idAlimentacion) as UltimoId
	FROM
		Alimentacion;
END