CREATE DEFINER=`root`@`localhost` PROCEDURE `verMaxIdProveedor`()
BEGIN
	SELECT
		Max(idProveedores) as UltimoId
	FROM
		Proveedores;
END