CREATE DEFINER=`root`@`localhost` PROCEDURE `eliBuffDetalleCaja`(
	in idBufCaja int
)
BEGIN
	DELETE FROM BufferDetalleCaja WHERE idBufferCajaDetalle = idBufCaja;
END