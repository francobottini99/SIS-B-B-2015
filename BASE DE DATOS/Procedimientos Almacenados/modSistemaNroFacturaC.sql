CREATE DEFINER=`root`@`localhost` PROCEDURE `modSistemaNroFacturaC`(
	in unnS varchar(45),
	in nrofacS varchar(45)
)
BEGIN
	UPDATE Sistema
	SET 
		NroFacturaNCND_C = nrofacS
	WHERE 
		CodEmpresa = unnS;
END