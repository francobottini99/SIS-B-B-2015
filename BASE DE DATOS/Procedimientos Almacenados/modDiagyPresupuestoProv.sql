CREATE DEFINER=`root`@`localhost` PROCEDURE `modDiagyPresupuestoProv`(
	in idST int(11),
	in diagST longtext,
	in feestST date,
	in presST double,
    in presCl double,
    in obsST varchar(255)
)
BEGIN
	UPDATE ServicioTecnico
	SET 
		Diagnostico = diagST,
		FecEstEntrega = feestST,
		PresupuestoProv = presST,
        Presupuesto = presCl,
  		Observaciones = obsST
	WHERE 
		idServicioTecnico = idST;
END