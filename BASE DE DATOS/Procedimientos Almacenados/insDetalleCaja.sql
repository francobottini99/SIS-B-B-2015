CREATE DEFINER=`root`@`localhost` PROCEDURE `insDetalleCaja`(
	in tipovDC varchar(45),
	in nrovDC varchar(45),
	in fecobDC date,
	in librDC varchar(255),
	in bcoDC varchar(250),
	in sucpagDC varchar(250),
	in impDC double,
	in encartDC varchar(2),
	in obsDC varchar(255),
    in idCjDC int(11)
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
		Observaciones,
        Caja_idCaja
)
	VALUES (tipovDC, nrovDC, fecobDC, librDC, bcoDC, sucpagDC, impDC, encartDC, obsDC, idCjDC);
END