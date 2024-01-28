CREATE DEFINER=`root`@`localhost` PROCEDURE `modSTEntregaVto`(
	in idST int(11),
	in feentST date,
	in presST double,
    in garmesST int(11),
    in vtogarST date,	
    in obsST varchar(255),
    in estST varchar(45)
)
BEGIN
	UPDATE ServicioTecnico
	SET 
		FecEntrega = feentST,
		Presupuesto = presST,
        GarantiaMeses = garmesST,
        VtoGarantia = vtogarST,
  		Observaciones = obsST,
        Estado = estST
	WHERE 
		idServicioTecnico = idST;
END