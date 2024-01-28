CREATE DEFINER=`root`@`localhost` PROCEDURE `insStock`(
	in cunS varchar(45),
	in fecS date,
	in cbarS varchar(255),
	in cantS double,
	in enstkS int(11),
	in usS varchar(250),
    in idartS int(11)    
)
BEGIN
	INSERT INTO Stock (
		CodUN,
		FecAlta,
		CodBarra,
		Cantidad,
		EnStock,
        Usuario,
		Art_idArticulos
)
	VALUES (cunS, fecS, cbarS, cantS, enstkS, usS, idartS);
END