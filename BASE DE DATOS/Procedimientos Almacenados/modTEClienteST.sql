CREATE DEFINER=`root`@`localhost` PROCEDURE `modTEClienteST`(
	in idcliST int(11),
	in tecliST varchar(250)
)
BEGIN
	UPDATE Clientes
	SET 
		TE = tecliST
	WHERE
		idClientes = idcliST;
END