CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdRecCompra`()
BEGIN
	SELECT
		Max(idCompraRecibos) as UltimoId
	FROM
		CompraRecibos;
END