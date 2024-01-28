CREATE DEFINER=`root`@`localhost` PROCEDURE `insDetalleFacCompra`(
	in idartDFC int(11),
    in cbDFC varchar(255),
	in detDFC varchar(255),
	in unDFC varchar(45),
	in cantDFC double,
	in precDFC double,
	in alivDFC double,
	in impDFC double,
    in usDFC varchar(250),
	in idfcDFC int(11)
	)
BEGIN
	INSERT INTO FacCompraDetalle (
		IdArticulo,
        CodBarra,
		Detalle,
		Unidad,
		Cantidad,
		Precio,
		AlIva,
		Importe,
        Usuario,
		CompraFacturas_idCompraFacturas
)
	VALUES (idartDFC, cbDFC, detDFC, unDFC, cantDFC, precDFC, alivDFC, impDFC, usDFC, idfcDFC);
END