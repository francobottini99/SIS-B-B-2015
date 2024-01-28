CREATE DEFINER=`root`@`localhost` PROCEDURE `insMovimiento`(
	in mFecha date,
	in mTMov varchar(45),
    in mDetalle varchar(250),
    in mCab double,
    in mIdCorral int(11)

)
BEGIN
	INSERT INTO Movimientos (
		Fecha,
		TipoMovimiento,
		Detalle,
        Cabezas,
        DETCORR_idDetCorrales
)
	VALUES (mFecha, mTMov, mDetalle, mCab, mIdCorral);
END