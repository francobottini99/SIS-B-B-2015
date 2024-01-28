CREATE DEFINER=`root`@`localhost` PROCEDURE `modSistemaNroFacturaB`(
	in unnS varchar(45),
	in nrofacS varchar(45)
)
BEGIN
	UPDATE Sistema
	SET 
		NroFacturaNCND_B = nrofacS
	WHERE 
		CodEmpresa = unnS;
END