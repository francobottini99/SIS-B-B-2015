CREATE DEFINER=`root`@`localhost` PROCEDURE `insArticulo`(
	in cunA varchar(45),
	in fecA date,
	in ccatA varchar(11),
	in descA varchar(255),
	in uniA varchar(100),
	in precA double,
	in alivaA double,
	in pfinA double,
	in restA int(11),
	in usA varchar(250),
    in idcatA int(11),
    in ussPrec double,
    in manA int(11)
    
)
BEGIN
	INSERT INTO Articulos (
		CodUN,
		FecAlta,
		CodCategoria,
		Descripcion,
		Unidad,
		Precio,
		AlicuotaIVA,
		PrecioFinal,
		RequiereStock,
        Usuario,
		Cat_idCategorias,
        PrecioU$S,
        Manual
)
	VALUES (cunA, fecA, ccatA, descA, uniA, precA, alivaA, pfinA, restA, usA, idcatA, ussPrec,manA);
END