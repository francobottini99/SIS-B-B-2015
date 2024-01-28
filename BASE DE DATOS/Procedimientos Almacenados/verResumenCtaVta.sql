CREATE DEFINER=`root`@`localhost` PROCEDURE `verResumenCtaVta`(
)
BEGIN
	SELECT
		*
	FROM
		ResumenDeuda
	ORDER BY RazonSocial Asc;
END