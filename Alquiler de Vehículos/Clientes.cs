using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alquiler_de_Vehículos
{
	public class Clientes
	{
		conexion conexion = new conexion();

		public Int32 Codigo{ get; set; }
		public String DUI { get; set; }
		public String NIT { get; set; }
		public String Nombre1 { get; set; }
		public String Nombre2 { get; set; }
		public String Nombre3 { get; set; }
		public String Apellido1 { get; set; }
		public String Apellido2 { get; set; }
		public String Nacimiento { get; set; }
		public String Direccion { get; set; }
		public String Email { get; set; }
		public String TipoLicencia { get; set; }
		public int Tel { get; set; }

		
		public void AgregarCliente()
		{
			if (conexion.BusquedaReg("Clientes","DUI","'"+DUI+"'","DUI")==null)
			{
				Codigo = conexion.CuentaRegistros("Clientes","CodigoCliente")+1;
				MessageBox.Show(conexion.AgregarClientes(Codigo,DUI, NIT, Nombre1, Nombre2, Nombre3, Apellido1, Apellido2, Nacimiento, Direccion, Email, TipoLicencia, Tel));
			}
			else
			{
				MessageBox.Show("El cliente ya existe, no se puede agregar a la base de datos.");
			}			
		}

		public void ActualizarCliente()
		{
			if (conexion.BusquedaReg("Clientes", "CodigoCliente",Codigo.ToString(),"CodigoCliente")!=null&&conexion.CuentaRegistrosEsp("Clientes","DUI",DUI,"CodigoCliente",Codigo)==0)
			{
				MessageBox.Show(conexion.ActualizacionCliente(Codigo, DUI, NIT, Nombre1, Nombre2, Nombre3, Apellido1, Apellido2, Nacimiento, Direccion, Email, TipoLicencia, Tel));
			}
			else
			{
				MessageBox.Show("No puede modificar estos datos, porque el cliente ya existe.");
			}
		}

		public void EliminarCliente()
		{
			if (conexion.BusquedaReg("Clientes", "CodigoCliente",Codigo.ToString(),"CodigoCliente") != null && Codigo==Convert.ToInt32((conexion.BusquedaReg("Clientes","DUI","'"+DUI+"'","CodigoCliente"))))
			{
				MessageBox.Show(conexion.EliminarCliente(Codigo));
			}
			else
			{
				MessageBox.Show("Los datos seleccionados y el cliente que quiere eliminar no coinciden");
			}
		}
		//Colocar informacion de clientes en texboxs
		public Boolean AddTexBoxClientes(String principal)
		{
			DUI = principal;
			if (conexion.CargarTexboxClientes(DUI) != null)
			{
				Codigo = Convert.ToInt32(conexion.CargarTexboxClientes(DUI).GetValue(0));
				NIT = conexion.CargarTexboxClientes(DUI).GetValue(1).ToString();
				Nombre1 = conexion.CargarTexboxClientes(DUI).GetValue(2).ToString();
				Nombre2 = conexion.CargarTexboxClientes(DUI).GetValue(3).ToString();
				Nombre3 = conexion.CargarTexboxClientes(DUI).GetValue(4).ToString();
				Apellido1 = conexion.CargarTexboxClientes(DUI).GetValue(5).ToString();
				Apellido2 = conexion.CargarTexboxClientes(DUI).GetValue(6).ToString();
				Nacimiento = conexion.CargarTexboxClientes(DUI).GetValue(7).ToString();
				Direccion = conexion.CargarTexboxClientes(DUI).GetValue(8).ToString();
				Email = conexion.CargarTexboxClientes(DUI).GetValue(9).ToString();
				TipoLicencia = conexion.CargarTexboxClientes(DUI).GetValue(10).ToString();
				Tel = Convert.ToInt32(conexion.CargarTexboxClientes(DUI).GetValue(11));
				return true;
			}
			else
			{
				MessageBox.Show("No se encontró el cliente especificado.");
				return false;
			}
		}

		//Colocar registro en Tabla
		public void FillTable(DataGridView dataGrid)
		{
			conexion.CargarDtv(dataGrid, "Clientes");
		}
		////Filtrar registros en listado clientes
		public void Filtrarlistado(DataGridView dataGrid, String texto)
		{
			conexion.FiltrarRegistrosClientes(dataGrid, texto);
		}
	}
}
