CREATE DEFINER=`root`@`localhost` PROCEDURE `insUsuario`(
	in nombU varchar(250),
	in catU varchar(45),
	in contU varchar(250),
	in estU int,
    in remU varchar(2),
    in menhabU longtext
)
BEGIN
	INSERT INTO Usuarios (
		Nombre,
		Categoria,
		Contraseña,
		Estado,
        Remoto,
        MenuHab
)
	VALUES (nombU, catU, contU, estU, remU, menhabU);
END