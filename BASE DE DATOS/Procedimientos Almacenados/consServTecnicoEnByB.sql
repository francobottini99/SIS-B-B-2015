CREATE DEFINER=`root`@`localhost` PROCEDURE `consServTecnicoEnByB`(
	in unnST varchar(45)
)
BEGIN
	SELECT
		ServicioTecnico.IdServicioTecnico,
        ServicioTecnico.CodUN,
        ServicioTecnico.NroOrden,
        ServicioTecnico.CodBarra,
        ServicioTecnico.Fecha,
		Clientes.RazonSocial,
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
        ServicioTecnico.Clientes_IdClientes
	FROM
		Clientes JOIN ServicioTecnico ON Clientes.IdClientes = ServicioTecnico.Clientes_IdClientes
	WHERE
		ServicioTecnico.CodUN = unnST And ServicioTecnico.Estado <> "Devuelto Al Cliente" And ServicioTecnico.Estado <> "En Reparacion Terceros"
	ORDER BY ServicioTecnico.Fecha Asc;
END