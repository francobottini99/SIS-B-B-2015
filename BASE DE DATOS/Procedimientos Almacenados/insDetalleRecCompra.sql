CREATE DEFINER=`root`@`localhost` PROCEDURE `insDetalleRecCompra`(
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
	INSERT INTO CompraRecDetalle (
		TipoValor,
		NroValor,
		FecCobro,
		Librador,
		Banco,
		Sucursal,
		ImporteValor,
		ObservValor,
        CompraRecibos_idCompraRecibos
)
	VALUES (tipovDC, nrovDC, fecobDC, librDC, bcoDC, sucpagDC, impDC, obsDC, idRVDC);
END