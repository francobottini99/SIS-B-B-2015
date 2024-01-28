CREATE DEFINER=`root`@`localhost` PROCEDURE `insCajaDetalle`(
	in tipovDC varchar(45),
	in nrovDC varchar(45),
	in fecobDC date,
	in librDC varchar(255),
	in bcoDC varchar(250),
	in sucpagDC varchar(250),
	in impDC double,
	in encartDC varchar(2),
	in obsDC varchar(255)
)
BEGIN
	INSERT INTO CajaDetalle (
		TipoValor,
		NroValor,
		FecCobro,
		Librador,
		Banco,
		SucursalPago,
		Importe,
		EnCartera,
		Observaciones
)
	VALUES (tipovDC, nrovDC, fecobDC, librDC, bcoDC, sucpagDC, impDC, encartDC, obsC);
END