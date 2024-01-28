CREATE DEFINER=`root`@`localhost` PROCEDURE `verSistema`(
	in unnS varchar(45)
)
BEGIN
	SELECT
		*
	FROM
		Sistema
	WHERE CodEmpresa = unnS
	ORDER BY IdSistema Asc;
END