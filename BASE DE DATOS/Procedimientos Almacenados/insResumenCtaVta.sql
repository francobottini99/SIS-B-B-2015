CREATE DEFINER=`root`@`localhost` PROCEDURE `insResumenCtaVta`(
	in nroctaR int(11),	
	in rsR varchar(255),
	in dirR varchar(255),
	in locR varchar(255),
	in teR varchar(255),
	in fumR date,
	in compR varchar(255),
    in saldoR double
)
BEGIN
	INSERT INTO ResumenDeuda (
		NroCta,
		RazonSocial,
		Direccion,
		Localidad,
		TE,
		UltimoMov,
		Comprobante,
        SaldoCta
)
	VALUES (nroctaR, rsR, dirR, locR, teR, fumR, compR, saldoR);
END