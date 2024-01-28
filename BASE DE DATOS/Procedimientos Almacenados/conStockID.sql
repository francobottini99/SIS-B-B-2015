CREATE DEFINER=`root`@`localhost` PROCEDURE `conStockID`(
	in idStk int(11)
)
BEGIN
	SELECT
		*
	FROM
		Stock
	WHERE idStock = idStk;
END