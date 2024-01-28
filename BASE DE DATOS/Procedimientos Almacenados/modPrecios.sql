CREATE DEFINER=`root`@`localhost` PROCEDURE `modPrecios`(
	in idaA int,
	in precA double,
	in pfinA double
)
BEGIN
	UPDATE Articulos
	SET 
		Precio = precA,
		PrecioFinal = pfinA
	WHERE 
		IdArticulos = idaA;
END