CREATE DEFINER=`root`@`localhost` PROCEDURE `insDetalleFacVenta`(
	in idartDFV int(11),
    in cbDFV varchar(255),
	in detDFV varchar(255),
	in unDFV varchar(45),
	in cantDFV double,
	in precDFV double,
	in alivDFV double,
	in impDFV double,
    in usDFV varchar(250),
	in idfcDFV int(11)
	)
BEGIN
	INSERT INTO FacVentaDetalle (
		IdArticulo,
        CodBarra,
		Detalle,
		Unidad,
		Cantidad,
		Precio,
		AlIva,
		Importe,
        Usuario,
		VentaFacturas_idFacturas
)
	VALUES (idartDFV, cbDFV, detDFV, unDFV, cantDFV, precDFV, alivDFV, impDFV, usDFV, idfcDFV);
END