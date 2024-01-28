CREATE DEFINER=`root`@`localhost` PROCEDURE `verCtaCteVtaSaldo`(
	in idCta int(11)
)
BEGIN
	SELECT
		*
	FROM
		CtaCteVenta
	WHERE idCtaCteVenta = idCta;
END