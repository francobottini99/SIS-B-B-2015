CREATE DEFINER=`root`@`localhost` PROCEDURE `insFormaPago`(
	in ptovtaFP varchar(45),
    in nfacFP varchar(45),
    in cuotFP int(11),
    in fecvFP date,
	in impFP double,
    in obsFP varchar(255),
    in idfacFP int(11)
	)
BEGIN
	INSERT INTO FormaPago(
		PtoVta,
        NroFactura,
		Cuotas,
        Vencimiento,
		Importe,
        Observaciones,
        VentaFacturas_idFacturas
)
	VALUES (ptovtaFP, nfacFP, cuotFP, fecvFP, impFP, obsFP, idfacFP);
END