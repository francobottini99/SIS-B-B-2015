CREATE DEFINER=`root`@`localhost` PROCEDURE `vaciaResumenCtaVta`()
BEGIN
	TRUNCATE TABLE ResumenDeuda;
END