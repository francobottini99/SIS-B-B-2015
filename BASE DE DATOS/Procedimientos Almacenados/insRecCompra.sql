CREATE DEFINER=`root`@`localhost` PROCEDURE `insRecCompra`(
	in codRC varchar(45),
	in cdbarRC varchar(250),
    in fecRC date,
	in nrRC varchar(45),
	in tipoRC varchar(45),
	in impRC double,
	in impletRC varchar(250),
	in obsRC varchar(255),
	in usRC varchar(250),
    in idcccRC int(11)
)
BEGIN
	INSERT INTO CompraRecibos (
		CodUN,
        CodBarra,
		FechaRec,
        NroRecibo,
		TipoRecibo,
		Importe,
		ImporteLetras,
		Observaciones,
		Usuario,
        CtaCteCompra_idCtaCteCompra
)
	VALUES (codRC, cdbarRC, fecRC, nrRC, tipoRC, impRC, impletRC, obsRC, usRC, idcccRC);
END