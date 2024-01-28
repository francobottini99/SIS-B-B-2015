CREATE DEFINER=`root`@`localhost` PROCEDURE `modSistemaTiketAcceso`(
	in unnS varchar(45),
	in tktAcc longtext
)
BEGIN
	UPDATE Sistema
	SET 
		TiketAcceso = tktAcc
	WHERE 
		CodEmpresa = unnS;
END