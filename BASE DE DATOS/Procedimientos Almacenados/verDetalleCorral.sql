CREATE DEFINER=`root`@`localhost` PROCEDURE `verDetalleCorral`(
)
BEGIN
	SELECT
		*
	FROM
		detalle_corrales;
END