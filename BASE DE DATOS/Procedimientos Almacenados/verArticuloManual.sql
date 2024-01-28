CREATE DEFINER=`root`@`localhost` PROCEDURE `verArticuloManual`()
BEGIN
	SELECT
		*
	FROM
		Articulos JOIN Stock ON Articulos.idArticulos = Stock.Art_idArticulos
	WHERE Articulos.Manual = 1
	ORDER BY Articulos.FecAlta Asc;
END