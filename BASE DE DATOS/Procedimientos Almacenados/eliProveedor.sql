CREATE DEFINER=`root`@`localhost` PROCEDURE `eliProveedor`(
	in idProv int
)
BEGIN
	DELETE FROM Proveedores WHERE idProveedores = idProv;
END