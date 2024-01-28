CREATE DEFINER=`root`@`localhost` PROCEDURE `conStock`(
	in idUN varchar(45)
)
BEGIN
	SELECT
		Articulos.FecAlta,
		Categorias.DescRubro,
		Categorias.DescSubRubro,
		Categorias.DescCategoria,
		Articulos.Descripcion,
		Articulos.Unidad,
		Articulos.Precio,
		Articulos.AlicuotaIVA,
		Articulos.PrecioFinal,
		Stock.CodBarra,
		Stock.Cantidad,
        Stock.IdStock,
        Articulos.IdArticulos
	FROM
		Stock JOIN Articulos ON Stock.Art_IdArticulos = Articulos.IdArticulos
		JOIN Categorias ON Articulos.Cat_idCategorias = Categorias.IdCategorias
	WHERE
		Articulos.CodUN = idUN And Stock.EnStock = 1
	ORDER BY Descripcion Asc;
END