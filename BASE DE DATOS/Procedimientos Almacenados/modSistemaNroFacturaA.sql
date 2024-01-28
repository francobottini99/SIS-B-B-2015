CREATE DEFINER=`root`@`localhost` PROCEDURE `modSistemaNroFacturaA`(
	in unnS varchar(45),
	in nrofacS varchar(45)
)
BEGIN
	UPDATE Sistema
	SET 
		NroFacturaNCND_A = nrofacS
	WHERE 
		CodEmpresa = unnS;
END