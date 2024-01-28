CREATE DEFINER=`root`@`localhost` PROCEDURE `insCtaCteCompra`(
	in unnCCC varchar(45),
	in cdbarCCC varchar(250),
	in fecCCC date,
    in fpagoCCC varchar(45),
    in clacomCCC varchar(45),
	in tipoCCC varchar(45),
	in nroCCC varchar(45),
	in debCCC double,
	in credCCC double,
	in saldoCCC double,
    in usCCC varchar(250),
	in idprovCCC int(11)
	)
BEGIN
	INSERT INTO CtaCteCompra (
		CodUN,
		CodBarra,
		Fecha,
        FormaPago,
        ClaseComprobante,
		TipoComprobante,
		NroComprobante,
		Debito,
		Credito,
		Saldo,
        Usuario,
		Proveedores_idProveedores
)
	VALUES (unnCCC, cdbarCCC, fecCCC, fpagoCCC, clacomCCC, tipoCCC, nroCCC, debCCC, credCCC, saldoCCC, usCCC, idprovCCC);
END