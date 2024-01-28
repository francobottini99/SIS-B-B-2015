CREATE DEFINER=`root`@`localhost` PROCEDURE `insLineaFacVenta`(
	in idartDF int(11),
	in cdbarDF varchar(255),
	in detDF varchar(255),
	in unDF varchar(45),
	in cantDF double,
	in precDF double,
	in alivaDF double,
	in impDF double,
    in idstDF int(11),
    in impfinDF double,
    in prfinDF double,
    in tipostDF varchar(45)
	)
BEGIN
	INSERT INTO DetalleFacturacion (
		IdArt,
		CodigoBarra,
		Detalle,
		Unidad,
		Cantidad,
		Precio,
		AlIVA,
		Importe,
        IdStock,
        ImpFinal,
        PrecioConIva,
        TipoStock
)
	VALUES (idartDF, cdbarDF, detDF, unDF, cantDF, precDF, alivaDF, impDF, idstDF, impfinDF, prfinDF, tipostDF);
END