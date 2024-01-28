CREATE DEFINER=`root`@`localhost` PROCEDURE `insCategoria`(
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
	INSERT INTO Categorias (
		CodRubro,
		CodSubRubro,
		CodCategoria,
		DescRubro,
		DescSubRubro,
		DescCategoria,
		CodResumen,
        Usuario
)
	VALUES (crubC, csrubC, ccatC, rubC, subrC, catC, cresC, usC);
END