CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdCompraCtaCte`()
BEGIN
	SELECT
		Max(idCtaCteCompra) as UltimoId
	FROM
		CtaCteCompra;
END