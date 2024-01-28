CREATE DEFINER=`root`@`localhost` PROCEDURE `vaciaDetalleCaja`()
BEGIN
	TRUNCATE TABLE BufferDetalleCaja;
END