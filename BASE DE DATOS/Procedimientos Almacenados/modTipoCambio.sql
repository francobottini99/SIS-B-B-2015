CREATE DEFINER=`root`@`localhost` PROCEDURE `modTipoCambio`(
	in idTC int,
	in fecTC varchar(250),
	in impTC double,
    in usTC varchar(250)
)
BEGIN
	UPDATE TipoCambio
	SET 
		Fecha = fecTC,
		TC = impTC,
		Usuario = usTC
	WHERE 
		idTipoCambio = idTC;
END