CREATE DEFINER=`root`@`localhost` PROCEDURE `modSTRecepcionTerceros`(
	in idST int(11),
	in fecreproST date,
	in estST varchar(45)
)
BEGIN
	UPDATE ServicioTecnico
	SET 
		FecRecepcionProv = fecreproST,
        Estado =estST
	WHERE 
		idServicioTecnico = idST;
END
