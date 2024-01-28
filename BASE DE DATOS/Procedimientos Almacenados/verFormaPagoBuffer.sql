CREATE DEFINER=`root`@`localhost` PROCEDURE `verFormaPagoBuffer`(
	in ptovta varchar(45),
    in nrofac varchar(45)
)
BEGIN
	SELECT
		*
	FROM
		FormaPagoBuffer
	WHERE PtoVta = ptovta And NroFactura = nrofac
	ORDER BY Vencimiento Asc;
END