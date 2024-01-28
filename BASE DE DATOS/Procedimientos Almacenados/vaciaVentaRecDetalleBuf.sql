CREATE DEFINER=`root`@`localhost` PROCEDURE `vaciaVentaRecDetalleBuf`()
BEGIN
	TRUNCATE TABLE VentaRecDetalleBuff;
END