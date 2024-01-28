CREATE DEFINER=`root`@`localhost` PROCEDURE `vaciaFormaPagoBuf`()
BEGIN
	TRUNCATE TABLE FormaPagoBuffer;
END