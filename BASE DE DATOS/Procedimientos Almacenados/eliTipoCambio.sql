CREATE DEFINER=`root`@`localhost` PROCEDURE `eliTipoCambio`(
	in idTC int
)
BEGIN
	DELETE FROM TipoCambio WHERE idTC = idTC;
END