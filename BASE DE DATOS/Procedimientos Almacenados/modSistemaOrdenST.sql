CREATE DEFINER=`root`@`localhost` PROCEDURE `modSistemaOrdenST`(
	in unnST varchar(45),
	in nrordST varchar(45)
)
BEGIN
	UPDATE Sistema
	SET 
		OrdServTecnico = nrordST
	WHERE 
		CodEmpresa = unnST;
END