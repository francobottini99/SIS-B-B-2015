CREATE DEFINER=`root`@`localhost` PROCEDURE `insBufferDetalleCaja`(
	in tipovDC varchar(45),
	in nrovDC varchar(45),
	in fecobDC date,
	in librDC varchar(255),
	in bcoDC varchar(250),
	in sucpagDC varchar(250),
	in impDC double,
	in encartDC varchar(2),
	in obsDC varchar(255),
    in valcarDC int(11)
)
BEGIN
	INSERT INTO BufferDetalleCaja (
		TipoValor,
		NroValor,
		FecCobro,
		Librador,
		Banco,
		SucursalPago,
		Importe,
		EnCartera,
		Observaciones,
        IdValCart
)
	VALUES (tipovDC, nrovDC, fecobDC, librDC, bcoDC, sucpagDC, impDC, encartDC, obsDC, valcarDC);
END