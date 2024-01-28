CREATE DEFINER=`root`@`localhost` PROCEDURE `insEmpresa`(
	in codigE varchar(45),	
	in rsE varchar(255),
	in dirE varchar(255),
	in locE varchar(100),
	in cpE varchar(45),
	in provE varchar(45),
	in paisE varchar(45),
	in teE varchar(255),
	in mailE varchar(255),
	in webE varchar(255),
	in propE varchar(255),
	in eslE varchar(255),
	in iniE date,
	in cuitE varchar(13),
	in ibE varchar(20),
	in ivaE varchar(45),
    in usuarE varchar(250),
	in logoE blob
)
BEGIN
	INSERT INTO Empresa (
		CodEmpresa,
		RazonSocial,
		Direccion,
		Localidad,
		CP,
		Provincia,
		Pais,
		Telefono,
		Mail,
		Web,
		Propietario,
		Eslogan,
		InicioActividades,
		CUIT,
		IIBB,
		IVA,
        Usuario,
		Logotipo
)
	VALUES (codigE, rsE, dirE, locE, cpE, provE, paisE, teE, mailE, webE, propE, eslE, iniE, cuitE, ibE, ivaE, usuarE, logoE);
END