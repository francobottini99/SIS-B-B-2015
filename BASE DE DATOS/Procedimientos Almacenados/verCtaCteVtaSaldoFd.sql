CREATE DEFINER=`root`@`localhost` PROCEDURE `verCtaCteVtaSaldoFd`(
	in idCli int(11),
    in cdUNN varchar(45),
    in fecD date
)
BEGIN
	SELECT
		*
	FROM
		CtaCteVenta
	WHERE Clientes_idClientes = idCli And CodUN = cdUNN And Fecha >= fecD
	ORDER BY Fecha Asc;
END