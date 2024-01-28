CREATE DEFINER=`root`@`localhost` PROCEDURE `modDetalleCorral`(
	in  IdCorral int(11),
	in CabTropa double
)
BEGIN
	UPDATE detalle_corrales
	SET 
		CabezasTropa = CabTropa,
        Observaciones = Observaciones,
        CORRALES_idCorrales = CORRALES_idCorrales,
        TROPA_idTropa = TROPA_idTropa
	WHERE 
		CORRALES_idCorrales = IdCorral;
END