CREATE DEFINER=`root`@`localhost` PROCEDURE `insBufferDetalleRecVta`(
	in tipovRV varchar(45),
	in nrovRV varchar(45),
	in fecobRV date,
	in librRV varchar(255),
	in bcoRV varchar(250),
	in sucpagRV varchar(250),
	in impRV double,
	in obsRV varchar(255)
)
BEGIN
	INSERT INTO VentaRecDetalleBuff (
		TipoValor,
		NroValor,
		FecCobro,
		Librador,
		Banco,
		SucursalPago,
		ImporteValor,
		ObservValor
)
	VALUES (tipovRV, nrovRV, fecobRV, librRV, bcoRV, sucpagRV, impRV, obsRV);
END