CREATE DEFINER=`root`@`localhost` PROCEDURE `modBufferDetalleRecVta`(
	in idDC int(11),
	in tipovDC varchar(45),
	in nrovDC varchar(45),
    in fecDC date,
	in librDC varchar(255),
	in bcoDC varchar(250),
	in sucpDC varchar(250),
	in impDC double,
	in obsDC varchar(255)
)
BEGIN
	UPDATE VentaRecDetalleBuff
	SET 
		TipoValor = tipovDC,
		NroValor = nrovDC,
		FecCobro = fecDC,
		Librador = librDC,
		Banco = bcoDC,
		SucursalPago = sucpDC,
		ImporteValor = impDC,
		ObservValor = obsDC
	WHERE 
		idReciboDetalle = idDC;
END