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

		public String NombreUsuario { get; set; }
		public String Contraseña { get; set; }

		public static String UsuarioEtiqueta{ get; set; }

		public void Loguear(Form origen, Form destino)
		{
			if (Conexion.LoguearUsuario(NombreUsuario, Contraseña))
			{
				UsuarioEtiqueta = NombreUsuario;
				origen.Hide();
				destino.ShowDialog();
				origen.Close();
			}
		}
	}
}
