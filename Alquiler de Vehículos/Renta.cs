using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alquiler_de_Vehículos
{
	public class Renta
	{
		conexion conexion = new conexion();

		public Int32 CodigoRenta { get; set; }
		public Int32 CodigoCliente { get; set; }
		public Int32 CodigoVehiculo { get; set; } 
		public DateTime Fecharenta { get; set; }
		public DateTime Fechadevolucion { get; set; }
		public DateTime FechaEntrega { get; set; }
		public Double Fianza { get; set; }
		public Double Monto { get; set; }
		public Double Mora { get; set; }

		//Cargar clientes
		public void CargarClientes(DataGridView dataGrid)
		{
			conexion.CargarDtvClientes(dataGrid);
		}
		//cargar vehiculos
		public void CargarVehiculos(DataGridView dataGrid)
		{
			conexion.CargarDtvVehiculos(dataGrid);
		}

		//Filtrar clients
		public void FiltrarClientes(DataGridView dataGrid, String texto)
		{
			conexion.FiltrarClientesRenta(dataGrid, texto);
		}
		//Filtrar vehiculos
		public void FiltrarVehiculos(DataGridView dataGrid, String texto)
		{
			conexion.FiltrarVehiculosRenta(dataGrid, texto);
		}

		//Calcular monto de vehiculo
		public Double MontoVehiculo()
		{
			//MessageBox.Show(conexion.BusquedaReg("Vehiculos", "CodigoVehiculo", CodigoVehiculo.ToString(), "Renta"));
			int dias = (Fechadevolucion.Date - Fecharenta.Date).Days;
			//MessageBox.Show(dias.ToString());
			Double precio = Convert.ToDouble(conexion.BusquedaReg("Vehiculos", "CodigoVehiculo", CodigoVehiculo.ToString(), "Renta"));
			return  (precio * dias) + Fianza;
		}
		//Calcular mora de vehiculo
		public Double Saldomora(Double porcentaje)
		{
			if ((FechaEntrega <= Fechadevolucion)==false)
			{
				int dias = (FechaEntrega.Date - Fechadevolucion.Date).Days;
				Double mora = dias*(Convert.ToDouble(conexion.BusquedaReg("Vehiculos", "CodigoVehiculo", CodigoVehiculo.ToString(), "Renta"))+(Convert.ToDouble(conexion.BusquedaReg("Vehiculos", "CodigoVehiculo", CodigoVehiculo.ToString(), "Renta"))*porcentaje));
				return mora;
			}
			else
			{
				return 0;
			}
		}
		//Agregar renta
		public void AgregarRenta()
		{
			if (Fechadevolucion > Fecharenta)
			{
				CodigoRenta = conexion.CuentaRegistros("Renta", "CodigoRenta") + 1;
				string frenta, fdevol;
				frenta = Fecharenta.Month.ToString() + "/" + Fecharenta.Day.ToString() + "/" + Fecharenta.Year.ToString() +" "+Fecharenta.Hour.ToString()+":"+Fecharenta.Minute.ToString()+":"+Fecharenta.Second.ToString();
				fdevol = Fechadevolucion.Month.ToString() + "/" + Fechadevolucion.Day.ToString() + "/" + Fechadevolucion.Year.ToString() + " 00:00:00";
				MessageBox.Show(conexion.AgregarRenta(CodigoRenta, CodigoCliente, CodigoVehiculo, frenta, fdevol, Fianza, Monto,Mora));
;			}
			else
			{
				MessageBox.Show("La fecha de devolucion no puede ser menor que la fecha de renta.");
			}
		}
		//Agregar Entrega de Vehículo
		public void AgregarEntrega(String placa)
		{
			String fechaentrega = FechaEntrega.Month.ToString() + "/" + FechaEntrega.Day.ToString() + "/" + FechaEntrega.Year.ToString() + " " + FechaEntrega.Hour.ToString() + ":" + FechaEntrega.Minute.ToString() + ":" + FechaEntrega.Second.ToString();
			CodigoVehiculo = Convert.ToInt32(conexion.BusquedaReg("Vehiculos", "Placa", "'" + placa + "'", "CodigoVehiculo"));
			Fecharenta = Convert.ToDateTime(conexion.BusquedaReg("Renta", "CodigoRenta", CodigoRenta.ToString(), "FechaRenta"));
			Fechadevolucion = Convert.ToDateTime(conexion.BusquedaReg("Renta", "CodigoRenta", CodigoRenta.ToString(), "FechaDevolucion"));
			Fianza = Convert.ToDouble(conexion.BusquedaReg("Renta", "CodigoRenta", CodigoRenta.ToString(), "Fianza"));
			Mora = Saldomora(0.5);
			Monto = MontoVehiculo() + Mora;
			MessageBox.Show(conexion.AgregarEntrega(CodigoRenta, fechaentrega, Mora,Monto));
		}
		//LLenar listado Renta
		public void ListadoRenta(DataGridView dataGrid)
		{
			conexion.ConsultaRenta(dataGrid);
		}
		//Filtrar listado de Renta
		public void FiltrarListadoRenta(DataGridView dataGrid,String texto)
		{
			conexion.FiltrarListadoRenta(dataGrid, texto);
		}
	}
}
