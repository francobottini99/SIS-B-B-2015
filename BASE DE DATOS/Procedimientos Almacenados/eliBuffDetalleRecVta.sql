CREATE DEFINER=`root`@`localhost` PROCEDURE `eliBuffDetalleRecVta`(
	in idBufRV int
)
BEGIN
	DELETE FROM VentaRecDetalleBuff WHERE idReciboDetalle = idBufRV;
END