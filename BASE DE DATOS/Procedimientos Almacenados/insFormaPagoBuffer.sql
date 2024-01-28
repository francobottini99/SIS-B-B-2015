CREATE DEFINER=`root`@`localhost` PROCEDURE `insFormaPagoBuffer`(
	in ptovtaFP varchar(45),
    in nfacFP varchar(45),
    in cuotFP int(11),
    in fecvFP date,
	in impFP double,
    in obsFP varchar(255)
	)
BEGIN
	INSERT INTO FormaPagoBuffer (
		PtoVta,
        NroFactura,
		Cuotas,
        Vencimiento,
		Importe,
        Observaciones
)
	VALUES (ptovtaFP, nfacFP, cuotFP, fecvFP, impFP, obsFP);
END