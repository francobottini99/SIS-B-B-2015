CREATE DEFINER=`root`@`localhost` PROCEDURE `modBufferDetalleCaja`(
	in idDC int(11),
	in tipovDC varchar(45),
	in nrovDC varchar(45),
    in fecDC date,
	in librDC varchar(255),
	in bcoDC varchar(250),
	in sucpDC varchar(250),
	in impDC double,
    in encartDC varchar(2),
	in obsDC varchar(255),
    in valcarDC int(11)
)
BEGIN
	UPDATE BufferDetalleCaja
	SET 
		TipoValor = tipovDC,
		NroValor = nrovDC,
		FecCobro = fecDC,
		Librador = librDC,
		Banco = bcoDC,
		SucursalPago = sucpDC,
		Importe = impDC,
		EnCartera = encartDC,
		Observaciones = obsDC,
        IdValCart = valcarDC
	WHERE 
		idBufferCajaDetalle = idDC;
END