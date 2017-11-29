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
		public Double Fianza { get; set; }
		public Double Monto { get; set; }

		//Cargar clientes
		public void CargarClientes(DataGridView dataGrid)
		{
			conexion.CargarDtv(dataGrid, "Clientes");
		}
		//cargar vehiculos
		public void CargarVehiculos(DataGridView dataGrid)
		{
			conexion.CargarDtvVehiculos(dataGrid, "Vehiculos", "Renta","0");
		}

		//Filtrar clients
		public void FiltrarClientes(DataGridView dataGrid, String texto)
		{
			conexion.FiltrarRegistrosClientes(dataGrid, texto);
		}
		//Filtrar vehiculos
		public void FiltrarVehiculos(DataGridView dataGrid, String texto)
		{
			conexion.FiltrarRegistrosVehiculos(dataGrid, texto);
		}

		//Buscar precio de vehiculo
		public Double MontoVehiculo()
		{
			//MessageBox.Show(conexion.BusquedaReg("Vehiculos", "CodigoVehiculo", CodigoVehiculo.ToString(), "Renta"));
			int dias = (Fechadevolucion - Fecharenta).Days;
			//MessageBox.Show(dias.ToString());
			Double precio = Convert.ToDouble(conexion.BusquedaReg("Vehiculos", "CodigoVehiculo", CodigoVehiculo.ToString(), "Renta"));
			return  (precio * dias) + Fianza;
		}
		//Agregar renta
		public void AgregarRenta()
		{
			if (Fechadevolucion > Fecharenta)
			{
				CodigoRenta = conexion.CuentaRegistros("Renta", "CodigoRenta") + 1;
				string frenta, fdevol;
				frenta = Fecharenta.Month.ToString() + "/" + Fecharenta.Day.ToString() + "/" + Fecharenta.Year.ToString() + " 00:00:00";
				fdevol = Fechadevolucion.Month.ToString() + "/" + Fechadevolucion.Day.ToString() + "/" + Fechadevolucion.Year.ToString() + " 00:00:00";
				MessageBox.Show(conexion.AgregarRenta(CodigoRenta, CodigoCliente, CodigoVehiculo, frenta, fdevol, Fianza, Monto));
;			}
			else
			{
				MessageBox.Show("La fecha de devolucion no puede ser menor que la fecha de renta.");
			}
		}
		//LLenar listado Renta
		public void ListadoRenta(DataGridView dataGrid)
		{
			conexion.ConsultaRenta(dataGrid);
		}
	}
}
