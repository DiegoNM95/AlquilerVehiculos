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
		//Colocar informacion de clientes en texboxs
		public Boolean AddTexBoxUsuarios(String principal)
		{
			NombreUsuario = principal;
			if (Conexion.CargarTexboxUsuarios(principal) != null)
			{
				Codigo = Convert.ToInt32(Conexion.CargarTexboxUsuarios(NombreUsuario).GetValue(0));
				Contraseña = Conexion.CargarTexboxUsuarios(NombreUsuario).GetValue(1).ToString();
				Tipo = Conexion.CargarTexboxUsuarios(NombreUsuario).GetValue(2).ToString();
				return true;
			}
			else
			{
				MessageBox.Show("No se encontró el usuario especificado.");
				return false;
			}
		}
		//MODIFICAR USUARIO
		public void ActualizarUsuario()
		{
			if (Conexion.BusquedaReg("Usuarios", "codigo", Codigo.ToString(), "codigo") != null && Conexion.CuentaRegistrosEsp("Usuarios","usuario",NombreUsuario,"codigo",Codigo)==0)
			{
				MessageBox.Show(Conexion.ModificarUsuario(Codigo,NombreUsuario,Contraseña,Tipo));
			}
			else
			{
				MessageBox.Show("No puede modificar estos datos, porque el usuario ya existe.");
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

		//Eliminar usuario
		public void Eliminarusuario()
		{
			if (Conexion.BusquedaReg("Usuarios", "codigo", Codigo.ToString(), "codigo") != null && Codigo == Convert.ToInt32((Conexion.BusquedaReg("Usuarios", "usuario", "'" + NombreUsuario + "'", "codigo"))))
			{
				MessageBox.Show(Conexion.EliminarUsuario(Codigo));
			}
			else
			{
				MessageBox.Show("Los datos seleccionados y el usuario que quiere eliminar no coinciden");
			}
		}
		//Actulizar 
	}
}