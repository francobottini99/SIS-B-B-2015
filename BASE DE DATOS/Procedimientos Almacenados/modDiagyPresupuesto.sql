CREATE DEFINER=`root`@`localhost` PROCEDURE `modDiagyPresupuesto`(
	in idST int(11),
	in diagST longtext,
	in feestST date,
	in presST double,
    in obsST varchar(255)
)
BEGIN
	UPDATE ServicioTecnico
	SET 
		Diagnostico = diagST,
		FecEstEntrega = feestST,
		Presupuesto = presST,
  		Observaciones = obsST
	WHERE 
		idServicioTecnico = idST;
END