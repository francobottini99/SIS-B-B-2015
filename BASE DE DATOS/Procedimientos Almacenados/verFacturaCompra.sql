CREATE DEFINER=`root`@`localhost` PROCEDURE `verFacturaCompra`(
	in idCta int(11)
)
BEGIN
	SELECT
		*
	FROM
		CompraFacturas
	WHERE CtaCteCompra_idCtaCteCompra = idCta
	ORDER BY FechaFac Asc;
END