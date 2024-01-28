CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdVentaFacturas`()
BEGIN
	SELECT
		Max(idFacturas) as UltimoId
	FROM
		VentaFacturas;
END