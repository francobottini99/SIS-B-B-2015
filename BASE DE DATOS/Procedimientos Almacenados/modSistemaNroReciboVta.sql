CREATE DEFINER=`root`@`localhost` PROCEDURE `modSistemaNroReciboVta`(
	in unnS varchar(45),
	in nroRV varchar(45)
)
BEGIN
	UPDATE Sistema
	SET 
		NroRecibo = nroRV
	WHERE 
		CodEmpresa = unnS;
END