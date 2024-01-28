CREATE DEFINER=`root`@`localhost` PROCEDURE `insSistema`(
	in cempS varchar(45),
    in nfcda varchar(45),
    in nfcdb varchar(45),
    in nrec varchar(45)
)
BEGIN
	INSERT INTO Sistema (
		CodEmpresa,
        NroFacturaNCND_A,
        NroFacturaNCND_X,
        NroRecibo
)
	VALUES (cempS, nfcda, nfcdb, nrec);
END