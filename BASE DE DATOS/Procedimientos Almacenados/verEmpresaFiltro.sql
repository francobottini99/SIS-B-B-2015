CREATE DEFINER=`root`@`localhost` PROCEDURE `verEmpresaFiltro`(
	in cdEmp varchar(45)
)
BEGIN
	SELECT
		*
	FROM
		Empresa
	WHERE CodEmpresa = cdEmp
	ORDER BY RazonSocial Asc;
END