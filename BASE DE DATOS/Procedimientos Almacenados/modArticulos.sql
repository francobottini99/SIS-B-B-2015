CREATE DEFINER=`root`@`localhost` PROCEDURE `modArticulo`(
	in idaA int,
	in cunA varchar(45),
	in fecA date,
	in ccatA varchar(11),
	in descA varchar(255),
	in uniA varchar(10),
	in precA double,
	in alivaA double,
	in pfinA double,
	in restA int(11),
    in usA varchar(250),
	in idcatA int(11)
)
BEGIN
	UPDATE Articulos
	SET 
		CodUN = cunA,
		FecAlta = fecA,
		CodCategoria = ccatA,
		Descripcion = descA,
		Unidad = uniA,
		Precio = precA,
		AlicuotaIVA = alivaA,
		PrecioFinal = pfinA,
		RequiereStock = restA,
        Usuario = usA,
		Cat_idCategorias = idcatA
	WHERE 
		IdArticulos = idaA;
END