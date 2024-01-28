CREATE DEFINER=`root`@`localhost` PROCEDURE `vaciaDetalleReciboVta`()
BEGIN
	TRUNCATE TABLE VentaRecDetalleBuff;
END