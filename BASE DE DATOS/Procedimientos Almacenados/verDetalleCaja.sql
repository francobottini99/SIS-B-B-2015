CREATE DEFINER=`root`@`localhost` PROCEDURE `verDetalleCaja`()
BEGIN
	SELECT
		*
	FROM
		BufferDetalleCaja
	ORDER BY idBufferCajaDetalle Asc;
END