using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alquiler_de_Vehículos
{
	public class Vehiculo
	{
		//Instancia de la clase conexion
		conexion conexion = new conexion();

		//Atributos del objeto vehículo
		public Int32 Codigo { get; set; }
		public String Placa { get; set; }
		public String Marca { get; set; }
		public String Modelo { get; set; }
		public String Color { get; set; }
		public Int32 Año { get; set; }
		public String Clase { get; set; }
		public String Tipoembrague { get; set; }
		public String Propietario { get; set; }
		public Double Renta { get; set; }

		//Método para agregar vehículos
		public void AgregarVehiculo()
		{
			if (conexion.BusquedaReg("Vehiculos", "Placa", "'" + Placa + "'", "Placa") == null)
			{
				Codigo = conexion.CuentaRegistros("Vehiculos", "CodigoVehiculo")+1;
				MessageBox.Show(conexion.AgregarVehiculo(Codigo, Placa, Marca, Modelo, Color, Año, Clase, Tipoembrague, Propietario, Renta));
			}
			else
			{
				MessageBox.Show("Vehículo no agregado porque ya existe un vehículo con la misma placa");
			}
		}

		//Llenar listado vehiculos
		public void FillTable(DataGridView dataGrid)
		{
			conexion.CargarDtv(dataGrid, "Vehiculos");
		}

		//Colocar informacion de clientes en texboxs
		public Boolean AddTexBoxVehiculos(String principal)
		{
			Placa = principal;
			if (conexion.CargarTexboxVehiculos(Placa) != null)
			{
				Codigo = Convert.ToInt32(conexion.CargarTexboxVehiculos(Placa).GetValue(0));
				Marca = conexion.CargarTexboxVehiculos(Placa).GetValue(1).ToString();
				Modelo = conexion.CargarTexboxVehiculos(Placa).GetValue(2).ToString();
				Color = conexion.CargarTexboxVehiculos(Placa).GetValue(3).ToString();
				Año = Convert.ToInt32(conexion.CargarTexboxVehiculos(Placa).GetValue(4));
				Clase = conexion.CargarTexboxVehiculos(Placa).GetValue(5).ToString();
				Tipoembrague = conexion.CargarTexboxVehiculos(Placa).GetValue(6).ToString();
				Propietario = conexion.CargarTexboxVehiculos(Placa).GetValue(7).ToString();
				Renta = Convert.ToDouble(conexion.CargarTexboxVehiculos(Placa).GetValue(8));
				return true;
			}
			else
			{
				MessageBox.Show("No se encontró el vehículo especificado.");
				return false;
			}
		}
		//Filtrar Listado
		public void FiltrarListado(DataGridView dataGrid, String texto)
		{
			conexion.FiltrarRegistrosVehiculos(dataGrid, texto);
		}
		//Actulizar datos de vehiculos
		public void ActualizarVehiculos()
		{
			if (conexion.BusquedaReg("Vehiculos", "CodigoVehiculo", Codigo.ToString(), "CodigoVehiculo") != null && conexion.CuentaRegistrosEsp("Vehiculos", "Placa", Placa, "CodigoVehiculo", Codigo) == 0)
			{
				MessageBox.Show(conexion.ActualizacionVehiculo(Codigo, Placa, Marca, Modelo, Color, Año, Clase, Tipoembrague, Propietario));
			}
			else
			{
				MessageBox.Show("No puede modificar estos datos, porque el vehiculo ya existe.");
			}
		}
		//Eliminar vehiculos
		public void EliminarVehiculos()
		{
			if (conexion.BusquedaReg("Vehiculos", "CodigoVehiculo", Codigo.ToString(), "CodigoVehiculo") != null && Codigo == Convert.ToInt32((conexion.BusquedaReg("Vehiculos", "Placa", "'" + Placa + "'", "CodigoVehiculo"))))
			{
				MessageBox.Show(conexion.EliminarVehiculo(Codigo));
			}
			else
			{
				MessageBox.Show("Los datos seleccionados y el vehiculo que quiere eliminar no coinciden");
			}
		}
	}
}
