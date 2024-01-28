CREATE DEFINER=`root`@`localhost` PROCEDURE `insDetalleRecVta`(
	in tipovDC varchar(45),
	in nrovDC varchar(45),
	in fecobDC date,
	in librDC varchar(255),
	in bcoDC varchar(250),
	in sucpagDC varchar(250),
	in impDC double,
	in obsDC varchar(255),
    in idRVDC int(11)
)
BEGIN
	INSERT INTO VentaRecDetalle (
		TipoValor,
		NroValor,
		FecCobro,
		Librador,
		Banco,
		SucursalPago,
		ImporteValor,
		ObservValor,
        VentaRecibos_idVentaRecibos
)
	VALUES (tipovDC, nrovDC, fecobDC, librDC, bcoDC, sucpagDC, impDC, obsDC, idRVDC);
END