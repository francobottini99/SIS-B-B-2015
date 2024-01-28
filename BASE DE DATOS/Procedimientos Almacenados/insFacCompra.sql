CREATE DEFINER=`root`@`localhost` PROCEDURE `insFacCompra`(
	in unnFC varchar(45),
	in cdbarFC varchar(250),
	in nroFC varchar(45),
	in tipoFC varchar(45),
	in fecFC date,
	in subtFC double,
	in descFC double,
	in bimpFC double,
	in iv1FC double,
	in imiv1 double,
	in iv2FC double,
	in imiv2 double,
	in iv3FC double,
	in imiv3 double,
	in totFC double,
	in obsFC varchar(255),
    in usFC varchar(250),
	in idcccFC int(11)
	)
BEGIN
	INSERT INTO CompraFacturas (
		CodUN,
		CodBarra,
		NroComprobante,
		TipoComprobante,
		FechaFac,
		SubTotal,
		Descuento,
		BaseImponible,
		AlIva1,
		ImporteIva1,
		AlIva2,
		ImporteIva2,
		AlIva3,
		ImporteIva3,
		Total,
		Observaciones,
        Usuario,
		CtaCteCompra_idCtaCteCompra
)
	VALUES (unnFC, cdbarFC, nroFC, tipoFC, fecFC, subtFC, descFC, bimpFC, iv1FC, imiv1, iv2FC, imiv2, iv3FC, imiv3, totFC, obsFC, usFC, idcccFC);
END