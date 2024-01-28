CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdCompraFacturas`()
BEGIN
	SELECT
		Max(idCompraFacturas) as UltimoId
	FROM
		CompraFacturas;
END