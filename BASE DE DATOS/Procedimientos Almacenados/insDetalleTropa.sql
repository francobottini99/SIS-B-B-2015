CREATE DEFINER=`root`@`localhost` PROCEDURE `insDetalleTropa`(
	in dtCab double,
	in dtObser varchar(250),
	in dtIDTropa int(11),
	in dtIDCatg int(11)
)
BEGIN
	INSERT INTO Detalle_Tropa (
		Cabezas,
		Observaciones,
		TROPA_idTropa,
		CATEGORIAS_idCategorias
)
	VALUES (dtCab, dtObser, dtIDTropa, dtIDCatg);
END