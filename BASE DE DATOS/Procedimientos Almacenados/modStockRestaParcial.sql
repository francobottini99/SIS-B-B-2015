CREATE DEFINER=`root`@`localhost` PROCEDURE `modStockRestaParcial`(
	in idStk int,
	in cantStk double,
    in usStk varchar(250)
)
BEGIN
	UPDATE Stock
	SET 
		Cantidad = cantStk,
        Usuario = usStk
	WHERE 
		IdStock = idStk;
END