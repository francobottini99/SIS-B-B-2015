CREATE DEFINER=`root`@`localhost` PROCEDURE `insTipoCambio`(
	in fecTC varchar(250),
	in impTC double,
    in usTC varchar(250)
)
BEGIN
	INSERT INTO TipoCambio (
		Fecha,
		TC,
		Usuario
)
	VALUES (fecTC, impTC, usTC);
END