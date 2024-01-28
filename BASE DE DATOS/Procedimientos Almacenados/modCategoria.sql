CREATE DEFINER=`root`@`localhost` PROCEDURE `modCategoria`(
	in IdC int,
	in crubC varchar(3),	
	in csrubC varchar(3),
	in ccatC varchar(3),
	in rubC varchar(100),
	in subrC varchar(100),
	in catC varchar(100),
	in cresC varchar(11),
    in usC varchar(250)
)
BEGIN
	UPDATE Categorias
	SET 
		CodRubro = crubC,
		CodSubRubro = csrubC,
		CodCategoria = ccatC,
		DescRubro = rubC,
		DescSubRubro = subrC,
		DescCategoria = catC,
		CodResumen = cresC,
        Usuario = usC
	WHERE 
		IdCategorias = IdC;
END