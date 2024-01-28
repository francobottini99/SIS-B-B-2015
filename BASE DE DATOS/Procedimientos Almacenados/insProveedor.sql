CREATE DEFINER=`root`@`localhost` PROCEDURE `insProveedor`(
	in cdunP varchar(45),
	in cbP varchar(250),
	in fecP date,
	in rsP varchar(250),
	in dirP varchar(250),
	in locP varchar(100),
	in cpP varchar(30),
	in provP varchar(50),
	in paisP varchar(100),
	in teP varchar(250),
	in cuitP varchar(13),
	in ibP varchar(10),
	in cativP varchar(45),
	in codivP varchar(45),
	in correP varchar(250),
	in webP varchar(250),
	in contP varchar(250),
	in teconP varchar(250),
    in usP varchar(250)
)
BEGIN
	INSERT INTO Proveedores (
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
		CorreoElectronico,
		PaginaWeb,
		Contacto,
		TEContacto,
        Usuario
)
	VALUES (cdunP, cbP, fecP, rsP, dirP, locP, cpP, provP, paisP, teP, cuitP, ibP, cativP, codivP, correP, webP, contP, teconP, usP);
END