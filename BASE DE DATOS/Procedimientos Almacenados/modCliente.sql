CREATE DEFINER=`root`@`localhost` PROCEDURE `modCliente`(
	in idC int(11),
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
	UPDATE Clientes
	SET 
		CodUN = cdunC,
		CodBarra = cbC,
		FecAlta = fecC,
		RazonSocial = rsC,
		Direccion = dirC,
		Localidad = locC,
		CP = cpC,
		Provincia = provC,
		Pais = paisC,
		TE = teC,
		CUIT = cuitC,
		IIBB = ibC,
		CategoriaIVA = cativC,
		CodCategoriaIVA = codivC,
		Credito = credC,
		Estado = estC,
		Observaciones = obsC,
        Usuario = usC
	WHERE 
		idClientes = idC;
END