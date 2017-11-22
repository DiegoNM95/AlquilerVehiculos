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
		conexion conexion;

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

		/*public void ClienteExistente()
		{
			if (conexion.VClienteExistente(DUI))
			{
				MessageBox.Show(")
			}
		}*/
		public void AgregarCliente()
		{
			conexion = new conexion();
			if (!conexion.VClienteExistente(DUI))
			{
				MessageBox.Show(conexion.AgregarClientes(DUI, NIT, Nombre1, Nombre2, Nombre3, Apellido1, Apellido2, Nacimiento, Direccion, Email, TipoLicencia, Tel));
			}
			else
			{
				MessageBox.Show("El cliente ya existe, no se puede agregar a la base de datos.");
				conexion = null;
			}			
		}
	}
}
