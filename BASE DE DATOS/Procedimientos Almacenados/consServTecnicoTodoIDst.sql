CREATE DEFINER=`root`@`localhost` PROCEDURE `consServTecnicoTodoIDst`(
    in stID int (11)
)
BEGIN
	SELECT
		ServicioTecnico.IdServicioTecnico,
        ServicioTecnico.CodUN,
        ServicioTecnico.NroOrden,
        ServicioTecnico.CodBarra,
        ServicioTecnico.Fecha,
        ServicioTecnico.Clientes_IdClientes,
		Clientes.RazonSocial CliRS,
        Clientes.Direccion CliDir,
        Clientes.Localidad CliLoc,
        Clientes.CP CliCp,
        Clientes.Provincia CliProv,
        Clientes.Pais CliPais,
        Clientes.TE CliTE,
        Clientes.CUIT CliCuit,
        ServicioTecnico.TipoEquipo,
        ServicioTecnico.DetalleEquipo,
        ServicioTecnico.AccesoriosEquipo,
        ServicioTecnico.EquipoCodBarra,
        ServicioTecnico.Problema,
		ServicioTecnico.Diagnostico,
		ServicioTecnico.FecEstEntrega,
        ServicioTecnico.FecEntrega,
        ServicioTecnico.Presupuesto,
        ServicioTecnico.GarantiaMeses,
        ServicioTecnico.VtoGarantia,
        ServicioTecnico.Facturado,
        ServicioTecnico.Tercerizado,
        ServicioTecnico.PresupuestoProv,
        ServicioTecnico.FecEntregaProv,
        ServicioTecnico.FecRecepcionProv,
        ServicioTecnico.Observaciones,
        ServicioTecnico.Usuario,
        ServicioTecnico.Estado,
        ServicioTecnico.Proveedores_IdProveedores,
        Proveedores.RazonSocial ProvRS,
        Proveedores.Direccion ProvDir,
        Proveedores.Localidad ProvLoc,
        Proveedores.CP ProvCP,
        Proveedores.Provincia ProvProv,
        Proveedores.Pais ProvPais,
        Proveedores.TE ProvTE,
        Proveedores.CUIT ProvCuit
	FROM
		Clientes JOIN ServicioTecnico ON Clientes.IdClientes = ServicioTecnico.Clientes_IdClientes
        JOIN Proveedores ON Proveedores.idProveedores = ServicioTecnico.Proveedores_idProveedores
	WHERE
		ServicioTecnico.IdServicioTecnico = stID
	ORDER BY ServicioTecnico.idServicioTecnico Asc;
END