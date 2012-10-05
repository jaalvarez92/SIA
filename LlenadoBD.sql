INSERT INTO dbo.TIPOCUENTA(Nombre, NumeroTipoCuenta) 
	SELECT 'Activo',1 UNION ALL
	SELECT 'Pasivo',2 UNION ALL
	SELECT 'Patrimonio',3 UNION ALL
	SELECT 'Ingresos',4 UNION ALL
	SELECT 'Costos',5 UNION ALL
	SELECT 'Gastos',6 UNION ALL
	SELECT 'Otros Ingresos',7 UNION ALL
	SELECT 'Otros Gastos',8