CREATE DEFINER=`root`@`localhost` PROCEDURE `verCtaCteCompraSaldo`(
	in idCta int(11)
)
BEGIN
	SELECT
		*
	FROM
		CtaCteCompra
	WHERE idCtaCteCompra = idCta;
END