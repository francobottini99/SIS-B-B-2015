CREATE DEFINER=`root`@`localhost` PROCEDURE `modServTecnico`(
	in idST int(11),
	in cdunST varchar(45),
	in nrordST varchar(45),
	in cdbarST varchar(250),
	in fecST date,
	in tpeqST varchar(45),
	in deteqST varchar(255),
	in acceqST varchar(250),
	in eqcdbarST varchar(250),
	in probST longtext,
	in diagST longtext,
	in feestST date,
	in tercST varchar(2),
    in obsST varchar(255),
    in idprovST int(11),
    in idclST int(11)
)
BEGIN
	UPDATE ServicioTecnico
	SET 
		CodUN = cdunST,
		NroOrden = nrordST,
        CodBarra =cdbarST,
		Fecha =fecST,
		TipoEquipo = tpeqST,
		DetalleEquipo =deteqST,
		AccesoriosEquipo= acceqST,
		EquipoCodBarra = eqcdbarST,
		Problema = probST,
		Diagnostico = diagST,
		FecEstEntrega = feestST,
		Tercerizado = tercST,
  		Observaciones = obsST,
        Proveedores_IdProveedores = idprovST,
        Clientes_IdClientes = idclST
	WHERE 
		idServicioTecnico = idST;
END