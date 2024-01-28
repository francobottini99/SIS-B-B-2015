CREATE DEFINER=`root`@`localhost` PROCEDURE `modStockResta`(
	in idStk int,
	in enstkS int(11),
    in usStk varchar(250)
)
BEGIN
	UPDATE Stock
	SET 
		EnStock = enstkS,
        Usuario = usStk
	WHERE 
		IdStock = idStk;
END