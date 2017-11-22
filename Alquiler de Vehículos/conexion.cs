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
	class conexion
	{
		SqlConnection cn;
		SqlCommand cmd;
		SqlDataReader dr;

		public conexion()
		{
			try
			{
				cn = new SqlConnection("workstation id=AlquilerVehiculo.mssql.somee.com;packet size=4096;user id=Ludieg8995_SQLLogin_1;pwd=ugd86mtoce;data source=AlquilerVehiculo.mssql.somee.com;persist security info=False;initial catalog=AlquilerVehiculo");
				cn.Open();
				MessageBox.Show("Conexion exitosa.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al conectar con la base de datos. \t\n Error: " + ex.ToString());
			}
		}


		//Logueo del usuario
		public Boolean LoguearUsuario(String usuario, String contra)
		{
			try
			{
				cmd = new SqlCommand("Select * From Usuarios Where [usuario] = '" + usuario + "' And [password] = '" + contra + "'",cn);
				dr = cmd.ExecuteReader();
				if (dr.Read())
				{
					return true;
				}
				else
				{
					MessageBox.Show("Datos ingresados incorrectos.");
				}
				dr.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Datos ingresados incorrectos: " + ex.ToString());
			}
			return false;
		}

		//Métodos de CLIENTES
		//Agregar Clientes
		public String AgregarClientes(String dui, String nit, String nombre1, String nombre2, String nombre3, String apellido1, String apellido2, String nacimiento, String direccion, String email, String tipolicencia, int telefono)
		{
			String salida = "Cliente agregado con exito";
			try
			{
				cmd = new SqlCommand("Insert Into Clientes([DUI],[NIT],[Nombre1],[Nombre2],[Nombre3],[Apellido1],[Apellido2],[Nacimiento],[Direccion],[Correo],[Tipolicencia],[Telefono]) Values('"+dui+"','"+nit+"','"+nombre1+"','"+nombre2+"','"+nombre3+"','"+apellido1+"','"+apellido2+"','"+nacimiento+"','"+direccion+"','"+email+"','"+tipolicencia+"',"+telefono+")", cn);
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				return salida = "Cliente no agregado. \t\n" + ex.ToString();
			}
			return salida;
		}
		//Validación de cliente existente
		public Boolean VClienteExistente(String dui)
		{
			try
			{
				cmd = new SqlCommand("Select * From Clientes Where [DUI] = '" + dui + "'", cn);
				dr = cmd.ExecuteReader();
				while (dr.Read())
				{
					return true;
				}
				dr.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se pudo realizar la consulta: \t\n" + ex.ToString());
			}
			return false;
		}
	}
}
