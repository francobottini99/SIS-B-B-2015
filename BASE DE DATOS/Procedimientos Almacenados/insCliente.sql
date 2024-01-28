CREATE DEFINER=`root`@`localhost` PROCEDURE `insCliente`(
	in cdunC varchar(45),
	in cbC varchar(250),
	in fecC date,
	in rsC varchar(250),
	in dirC varchar(250),
	in locC varchar(100),
	in cpC varchar(30),
	in provC varchar(50),
	in paisC varchar(100),
	in teC varchar(250),
	in cuitC varchar(13),
	in ibC varchar(10),
	in cativC varchar(45),
	in codivC varchar(45),
	in credC double,
	in estC int(11),
	in obsC varchar(255),
    in usC varchar(250)
)
BEGIN
	INSERT INTO Clientes (
		CodUN,
		CodBarra,
		FecAlta,
		RazonSocial,
		Direccion,
		Localidad,
		CP,
		Provincia,
		Pais,
		TE,
		CUIT,
		IIBB,
		CategoriaIVA,
		CodCategoriaIVA,
		Credito,
		Estado,
		Observaciones,
        Usuario
)
	VALUES (cdunC, cbC, fecC, rsC, dirC, locC, cpC, provC, paisC, teC, cuitC, ibC, cativC, codivC, credC, estC, obsC, usC);
END