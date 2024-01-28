CREATE DEFINER=`root`@`localhost` PROCEDURE `eliServTecnico`(
	in idST int
)
BEGIN
	DELETE FROM ServicioTecnico WHERE idServicioTEcnico = idST;
END