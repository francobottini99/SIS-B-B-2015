CREATE DEFINER=`root`@`localhost` PROCEDURE `modFacturaVtaReimpresion`(
	in idFV int(11),
	in reimpFV varchar(2),
    in fecriFV date
)
BEGIN
	UPDATE VentaFacturas
	SET
		Reimpreso = reimpFV,
		FecReimpresion = fecriFV
	WHERE 
		idFacturas = idFV;
END