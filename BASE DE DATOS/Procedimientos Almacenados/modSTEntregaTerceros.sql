CREATE DEFINER=`root`@`localhost` PROCEDURE `modSTEntregaTerceros`(
	in idST int(11),
	in tercST varchar(2),
	in fecenproST date,
	in estST varchar(45)
)
BEGIN
	UPDATE ServicioTecnico
	SET 
		Tercerizado = tercST,
		FecEntregaProv = fecenproST,
        Estado =estST
	WHERE 
		idServicioTecnico = idST;
END