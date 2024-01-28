CREATE DEFINER=`root`@`localhost` PROCEDURE `insCtaCteVenta`(
	in unnCCV varchar(45),
	in cdbarCCV varchar(250),
	in fecCCV date,
    in forpagCCV varchar(45),
    in clacomCCV varchar(45),
	in tipoCCV varchar(45),
    in cdcomCCV varchar(45),
    in ptovtaCCV varchar(45),
	in nroCCV varchar(45),
	in debCCV double,
	in credCCV double,
	in saldoCCV double,
    in usCCV varchar(250),
	in idcliCCV int(11)
	)
BEGIN
	INSERT INTO CtaCteVenta (
		CodUN,
		CodBarra,
		Fecha,
        FormaPago,
        ClaseComprobante,
		TipoComprobante,
        CodComprobante,
        PtoVta,
		NroComprobante,
		Debito,
		Credito,
		Saldo,
        Usuario,
		Clientes_idClientes
)
	VALUES (unnCCV, cdbarCCV, fecCCV, forpagCCV, clacomCCV, tipoCCV, cdcomCCV, ptovtaCCV, nroCCV, debCCV, credCCV, saldoCCV, usCCV, idcliCCV);
END