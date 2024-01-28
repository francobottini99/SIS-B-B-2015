CREATE DEFINER=`root`@`localhost` PROCEDURE `modSistemaNroReciboCompra`(
	in unnS varchar(45),
	in nroRV varchar(45)
)
BEGIN
	UPDATE Sistema
	SET 
		NroOrdenPago = nroRV
	WHERE 
		CodEmpresa = unnS;
END