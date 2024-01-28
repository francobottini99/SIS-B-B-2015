CREATE DEFINER=`root`@`localhost` PROCEDURE `insLineaFacCompra`(
	in idartDF int(11),
	in cdbarDF varchar(255),
	in detDF varchar(255),
	in unDF varchar(45),
	in cantDF double,
	in precDF double,
	in alivaDF double,
	in impDF double,
    in idstDF int(11),
    in impfinDF double
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
        ImpFinal
)
	VALUES (idartDF, cdbarDF, detDF, unDF, cantDF, precDF, alivaDF, impDF, idstDF, impfinDF);
END