CREATE DEFINER=`root`@`localhost` PROCEDURE `verFormaPago`(
	in idCta int(11)
)
BEGIN
	SELECT
		*
	FROM
		FormaPago
	WHERE VentaFacturas_idFacturas = idCta
	ORDER BY Vencimiento Asc;
END