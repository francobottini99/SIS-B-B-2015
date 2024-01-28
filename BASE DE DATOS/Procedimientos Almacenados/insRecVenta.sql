CREATE DEFINER=`root`@`localhost` PROCEDURE `insRecVenta`(
	in codRV varchar(45),
	in cdbarRV varchar(250),
    in fecRV date,
	in nrRV varchar(45),
	in tipoRV varchar(45),
	in impRV double,
	in impletRV varchar(250),
	in obsRV varchar(255),
	in usRV varchar(250),
    in idccvRV int(11)
)
BEGIN
	INSERT INTO VentaRecibos (
		CodUN,
        CodBarra,
		FechaRec,
        NroRecibo,
		TipoRecibo,
		Importe,
		ImporteLetras,
		Observaciones,
		Usuario,
        CtaCteVenta_idCtaCteVenta
)
	VALUES (codRV, cdbarRV, fecRV, nrRV, tipoRV, impRV, impletRV, obsRV, usRV, idccvRV);
END