CREATE DEFINER=`root`@`localhost` PROCEDURE `verCtaCteVenta`(
	in idCli int(11),
    in cdUNN varchar(45)
)
BEGIN
	SELECT
		*
	FROM
		CtaCteVenta
	WHERE Clientes_idClientes = idCli And CodUN = cdUNN
	ORDER BY Fecha Asc;
END