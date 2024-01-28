CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdVentaCtaCte`()
BEGIN
	SELECT
		Max(idCtaCteVenta) as UltimoId
	FROM
		CtaCteVenta;
END