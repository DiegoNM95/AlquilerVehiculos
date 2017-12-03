
SELECT	V.CodigoVehiculo,
		V.Placa,
		V.Marca,
		V.Modelo,
		V.Renta
  FROM	Vehiculos As V
  WHERE	V.Renta<>0
  And ((Select COUNT(CodigoRenta) From Renta Where CodigoVehiculo=V.CodigoVehiculo And FechaEntrega is null)=0
  Or (Select COUNT(CodigoVehiculo) From Renta Where CodigoVehiculo = V.CodigoVehiculo)=0)



