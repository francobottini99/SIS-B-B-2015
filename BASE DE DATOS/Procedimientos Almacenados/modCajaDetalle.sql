CREATE DEFINER=`root`@`localhost` PROCEDURE `modCajaDetalle`(
	in idDC int(11),
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
	UPDATE CajaDetalle
	SET 
		TipoValor = tipovDC,
		NroValor = nrovDC,
		FecCobro = fecobDC,
		Librador = librDC,
		Banco = bcoDC,
		SucursalPago = sucpagDC,
		Importe = impDC,
		EnCartera = encartDC,
		Observaciones = obsDC
	WHERE 
		idCajaDetalle = idDC;
END