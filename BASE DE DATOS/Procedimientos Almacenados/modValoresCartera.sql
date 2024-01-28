CREATE DEFINER=`root`@`localhost` PROCEDURE `modValoresCartera`(
	in idDC int(11),
    in encartDC varchar(2)
)
BEGIN
	UPDATE CajaDetalle
	SET 
		EnCartera = encartDC
	WHERE 
		idCajaDetalle = idDC;
END