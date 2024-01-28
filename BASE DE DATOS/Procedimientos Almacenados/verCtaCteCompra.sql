CREATE DEFINER=`root`@`localhost` PROCEDURE `verCtaCteCompra`(
	in idProv int(11),
    in cdUNN varchar(45)
)
BEGIN
	SELECT
		*
	FROM
		CtaCteCompra
	WHERE Proveedores_idProveedores = idProv And CodUN = cdUNN
	ORDER BY Fecha Asc;
END