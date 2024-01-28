CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdCliente`()
BEGIN
	SELECT
		Max(idClientes) as UltimoId
	FROM
		Clientes;
END