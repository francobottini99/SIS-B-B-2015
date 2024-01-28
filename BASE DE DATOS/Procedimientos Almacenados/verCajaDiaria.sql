CREATE DEFINER=`root`@`localhost` PROCEDURE `verCajaDiaria`(
	in fecdesdeCD date,
    in fechastaCD date
)
BEGIN
	SELECT
		*
	FROM
		Caja
	WHERE
		Fecha >= fecdesdeCD AND Fecha <= fechastaCD
	ORDER BY idCaja Asc;
END