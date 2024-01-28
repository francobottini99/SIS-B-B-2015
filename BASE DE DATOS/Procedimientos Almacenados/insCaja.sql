CREATE DEFINER=`root`@`localhost` PROCEDURE `insCaja`(
	in codigC varchar(45),
	in fecC date,
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
	INSERT INTO Caja (
		CodUN,
		Fecha,
        Hora,
		TipoMovimiento,
        CtaEmisorDestinatario,
		EmisorDestinatario,
		Detalle,
		Ingreso,
		Egreso,
		Saldo,
		Observaciones,
		Usuario
)
	VALUES (codigC, fecC, TIME(Now()), tipmovC, ctaC, emisC, detC, ingC, egrC, saldC, obsC, usC);
END