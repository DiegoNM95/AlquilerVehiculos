using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Alquiler_de_Vehículos
{
	public class Usuario
	{
		conexion Conexion = new conexion();

		public Int32 Codigo { get; set; }
		public String NombreUsuario { get; set; }
		public String Contraseña { get; set; }
		public String Tipo { get; set; }

		public static String UsuarioEtiqueta{ get; set; }
		public static String TipoEtiqueta { get; set; }

		public void Loguear(Form origen, Form destino)
		{
			if (Conexion.LoguearUsuario(NombreUsuario, Contraseña))
			{
				UsuarioEtiqueta = NombreUsuario;
				TipoEtiqueta = Conexion.BusquedaReg("Usuarios", "usuario", "'"+NombreUsuario+"'", "tipo");
				origen.Hide();
				destino.ShowDialog();
				origen.Close();
			}
		}

		//MÉTODO AGREGAR USUARIO
		public void AgregarUsuario()
		{
			Codigo = Conexion.CuentaRegistros("Usuarios", "codigo")+1;
			if (Conexion.BusquedaReg("Usuarios", "usuario", "'" + NombreUsuario + "'", "usuario") != null)
			{
				MessageBox.Show("El usuario ya existe");
			}
			else
			{
				MessageBox.Show(Conexion.AgregarUsuario(Codigo, NombreUsuario, Contraseña, Tipo));
			}	
		}

		public void Listado(DataGridView dataGrid)
		{
			Conexion.CargarDtv(dataGrid, "Usuarios");
		}

		public void FiltrarListado(DataGridView dataGrid, String texto)
		{
			Conexion.FiltrarRegistrosUsuarios(dataGrid, texto);
		}
	}
}