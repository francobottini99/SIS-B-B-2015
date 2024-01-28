CREATE DEFINER=`root`@`localhost` PROCEDURE `modDetalleCaja`(
	in idC int(11),
	in encartDC varchar(2)
)
BEGIN
	UPDATE CajaDetalle
	SET 
		EnCartera = encartDC
	WHERE 
		idCajaDetalle = idC;
END