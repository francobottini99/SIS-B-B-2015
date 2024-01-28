CREATE DEFINER=`root`@`localhost` PROCEDURE `modEmpresa`(
	in cempE varchar(45),
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
	UPDATE Empresa
	SET 
		RazonSocial = rsE,
		Direccion = dirE,
		Localidad = locE,
		CP = cpE,
		Provincia = provE,
		Pais = paisE,
		Telefono = teE,
		Mail = mailE,
		Web = webE,
		Propietario = propE,
		Eslogan = eslE,
		InicioActividades = iniE,
		CUIT = cuitE,
		IIBB = ibE,
		IVA = ivaE,
        Usuario = usuarE,
		Logotipo = logoE
	WHERE 
		CodEmpresa = cempE;
END