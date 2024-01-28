CREATE DEFINER=`root`@`localhost` PROCEDURE `modSistemaNroFacturaX`(
	in unnS varchar(45),
	in nrofacS varchar(45)
)
BEGIN
	UPDATE Sistema
	SET 
		NroFacturaNCND_X = nrofacS
	WHERE 
		CodEmpresa = unnS;
END