CREATE DEFINER=`root`@`localhost` PROCEDURE `modStock`(
	in idStk int,
	in cunnS varchar(45),
	in fecaS date,
	in cdbarS varchar(255),
	in cantS double,
	in enstkS int(11),
    in usStk varchar(250),
	in idartS int(11)
)
BEGIN
	UPDATE Stock
	SET 
		CodUN = cunnS,
		FecAlta = fecaS,
		CodBarra = cdbarS,
		Cantidad = cantS,
		EnStock = enstkS,
        Usuario = usStk,
		Art_idArticulos = idartS
	WHERE 
		IdStock = idStk;
END