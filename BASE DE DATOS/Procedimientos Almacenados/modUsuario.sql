CREATE DEFINER=`root`@`localhost` PROCEDURE `modUsuario`(
	in idU int,
	in nombU varchar(250),
	in catU varchar(45),
	in contU varchar(250),
	in estU int,
    in remU varchar(2),
    in menhabU longtext
)
BEGIN
	UPDATE Usuarios
	SET 
		Nombre = nombU,
		Categoria = catU,
		Contraseña = contU,
		Estado = estU,
        Remoto = remU,
        MenuHab = menhabU
	WHERE 
		idUsuarios = idU;
END