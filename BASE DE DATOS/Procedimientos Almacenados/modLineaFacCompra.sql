CREATE DEFINER=`root`@`localhost` PROCEDURE `modLineaFacCompra`(
	in iddetDF int(11),
	in idartDF varchar(45),
	in cdbarDF varchar(255),
	in detDF varchar(255),
	in unDF varchar(45),
	in cantDF double,
	in precDF double,
	in alivaDF double,
	in impDF double,
    in idstkDF int(11),
    in impfDF double
)
BEGIN
	UPDATE DetalleFacturacion
	SET 
		IdArt = idartDF,
		CodigoBarra = cdbarDF,
		Detalle = detDF,
		Unidad = unDF,
		Cantidad = cantDF,
		Precio = precDF,
		AlIVA = alivaDF,
		Importe = impDF,
        IdStock = idstkDF,
        ImpFinal = impfDF
	WHERE 
		IdDF = iddetDF;
END