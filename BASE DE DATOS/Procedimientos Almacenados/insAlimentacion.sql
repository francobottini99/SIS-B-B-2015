CREATE DEFINER=`root`@`localhost` PROCEDURE `insAlimentacion`(
	in aFecha date,
	in aKgRacion double,
    in aTurno varchar(250),
    in aObser varchar(250),
    in aIdRacion int(11),
    in aIdCorral int(11)
)
BEGIN
	INSERT INTO Alimentacion (
		Fecha,
		KgRacion,
		Turno,
        Observaciones,
        RACIONES_idRaciones,
        CORRALES_idCorrales
)
	VALUES (aFecha, aKgRacion, aTurno, aObser, aIdRacion, aIdCorral);
END