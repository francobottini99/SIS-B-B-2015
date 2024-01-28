CREATE DEFINER=`root`@`localhost` PROCEDURE `modCaja`(
	in idC int(11),
	in codigC varchar(45),
	in fecC date,
	in horC time,
	in tipmovC varchar(45),
    in ctaC int(11),
	in emisC varchar(255),
	in detC varchar(255),
	in ingC double,
	in egrC double,
	in saldC double,
	in obsC varchar(255),
	in usC varchar(250)
)
BEGIN
	UPDATE Caja
	SET 
		CodUN = codigC,
		Fecha = fecC,
		Hora = horC,
		TipoMovimiento = tipmovC,
        CtaEmisorDestinatario = ctaC,
		EmisorDestinatario = emisC,
		Detalle = detC,
		Ingreso = ingC,
		Egreso = egrC,
		Saldo = saldC,
		Observaciones = obsC,
		Usuario = usC
	WHERE 
		idCaja = idC;
END