CREATE DEFINER=`root`@`localhost` PROCEDURE `insDetalleCorral`(
	in dcCab double,
	in dcObser varchar(250),
	in dcIDCorral int(11),
	in dcIDTropa int(11)
)
BEGIN
	INSERT INTO Detalle_Corrales (
		CabezasTropa,
		Observaciones,
		CORRALES_idCorrales,
		TROPA_idTropa
)
	VALUES (dcCab, dcObser, dcIDCorral, dcIDTropa);
END