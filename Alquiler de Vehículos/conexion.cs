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
		DataTable dt;
		SqlDataAdapter da;

		public conexion()
		{
			try
			{
				cn = new SqlConnection("workstation id=AlquilerVehiculo.mssql.somee.com;packet size=4096;user id=Ludieg8995_SQLLogin_1;pwd=ugd86mtoce;data source=AlquilerVehiculo.mssql.somee.com;persist security info=False;initial catalog=AlquilerVehiculo;MultipleActiveResultSets=true");
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

		///////////////////////////////////////////////////METODOS GENERALES////////////////////////////////////////////////////////////////////////////////////////////
		//Número de Registros existentes
		public Int32 CuentaRegistros(String nombretabla, String campo)
		{
			Int32 cont = 0;
			try
			{
				cmd = new SqlCommand("Select MAX("+campo+") As 'Number' From "+nombretabla, cn);
				dr = cmd.ExecuteReader();
				if (dr.Read())
				{
					cont = Convert.ToInt32(dr["Number"]);
					return cont;
				}
				dr.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se pudo realizar la consulta a la BD. \t\n" + ex.ToString());
			}
			return cont;
		}
		//Numero de registros específicos
		public Int32 CuentaRegistrosEsp(String nombretabla, String campo, String valor, String campo2, Int32 valor2)
		{
			Int32 cont = 0;
			try
			{
				cmd = new SqlCommand("Select Count(*) As 'Number' From "+nombretabla+" Where "+campo+" = '"+valor+"' And "+campo+"<>(Select ["+campo+"] From "+nombretabla+" Where ["+campo2+"] = "+valor2+")", cn);
				dr = cmd.ExecuteReader();
				if (dr.Read())
				{
					cont = Convert.ToInt32(dr["Number"]);
					return cont;
				}
				dr.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se pudo realizar la consulta a la BD. \t\n" + ex.ToString());
			}
			return cont;
		}
		//Cargar Registros a DataGridView
		public void CargarDtv(DataGridView dataGrid, String tabla)
		{
			try
			{
				da = new SqlDataAdapter("Select * From " + tabla, cn);
				dt = new DataTable();
				da.Fill(dt);
				dataGrid.DataSource = dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se pudo cargar los registros a la tabla. \t\n" + ex.ToString());
			}
		}
		
		///////////////////////////////////////////////////////////////////////Métodos de CLIENTES/////////////////////////////////////////////////////////////////////
		//Agregar Clientes
		public String AgregarClientes(Int32 codigo, String dui, String nit, String nombre1, String nombre2, String nombre3, String apellido1, String apellido2, String nacimiento, String direccion, String email, String tipolicencia, int telefono)
		{
			String salida = "Cliente agregado con exito";
			try
			{
				cmd = new SqlCommand("Insert Into Clientes([CodigoCliente],[DUI],[NIT],[Nombre1],[Nombre2],[Nombre3],[Apellido1],[Apellido2],[Nacimiento],[Direccion],[Correo],[Tipolicencia],[Telefono]) Values("+codigo+",'"+dui+"','"+nit+"','"+nombre1+"','"+nombre2+"','"+nombre3+"','"+apellido1+"','"+apellido2+"','"+nacimiento+"','"+direccion+"','"+email+"','"+tipolicencia+"',"+telefono+")", cn);
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				return salida = "Cliente no agregado. \t\n" + ex.ToString();
			}
			return salida;
		}
		//Validación de cliente existente por dui
		public String VDuiExistente(String dui, String campo)
		{
			try
			{
				cmd = new SqlCommand("Select * From Clientes Where [DUI] = '" + dui + "'", cn);
				dr = cmd.ExecuteReader();
				if (dr.Read())
				{
					return dr[campo].ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se pudo realizar la consulta1: \t\n" + ex.ToString());
			}
			return null;
		}
		//Validacion de cliente existente por codigo
		public String VClienteExistente(Int32 codigo, String campo)
		{
			try
			{
				cmd = new SqlCommand("Select * From Clientes Where [CodigoCLiente] = " + codigo + "", cn);
				dr = cmd.ExecuteReader();
				if (dr.Read())
				{
					//dr.Close();
					return dr[campo].ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se pudo realizar la consulta2: \t\n" + ex.ToString());
			}
			return null;
		}

		//Metodo para madificar cliente
		public String ActualizacionCliente(Int32 codigo, String dui, String nit, String nombre1, String nombre2, String nombre3, String apellido1, String apellido2, String nacimiento, String direccion, String email, String tipolicencia, int telefono)
		{
			String salida = "Datos de cliente actualizados con éxito.";
			try
			{
				cmd = new SqlCommand("UPDATE [Clientes] SET [DUI]= '"+dui+"',[NIT] ='"+nit+"',[Nombre1] ='"+nombre1+"',[Nombre2] ='"+nombre2+"',[Nombre3] ='"+nombre3+"',[Apellido1] ='"+apellido1+"',[Apellido2] ='"+apellido2+"',[Nacimiento] ='"+nacimiento+"',[Direccion] ='"+direccion+"',[Correo] ='"+email+"',[Tipolicencia] ='"+tipolicencia+"',[Telefono] ="+telefono+" WHERE [CodigoCliente]="+codigo+"", cn);
				cmd.ExecuteNonQuery();
				return salida;
			}
			catch (Exception ex)
			{
				salida = "Datos no agregados. \t\n" + ex.ToString();
			}
			return salida;
		}
		//Metodo para cargar informacion en texbox clientes
		public String[] CargarTexboxClientes(String dui/*, String nit, String nombre1, String nombre2, String nombre3, String apellido1, String apellido2, String nacimiento, String direccion, String email, String tipolicencia, int telefono*/)
		{
			try
			{
				cmd = new SqlCommand("Select * From Clientes Where [DUI] = '"+dui+"'", cn);
				dr = cmd.ExecuteReader();
				if (dr.Read())
				{
					String[] valores= new string[]  {dr["CodigoCliente"].ToString(), dr["NIT"].ToString(), dr["Nombre1"].ToString(), dr["Nombre2"].ToString(), dr["Nombre3"].ToString(), dr["Apellido1"].ToString(), dr["Apellido2"].ToString(), dr["Nacimiento"].ToString(), dr["Direccion"].ToString(), dr["Correo"].ToString(), dr["Tipolicencia"].ToString(), dr["Telefono"].ToString()};
					return valores;
				}
				dr.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show("No se pudo realizar la consulta a la BD. \t\n" + ex.ToString());
			}
			return null;
		}
		//Filtrar registros en listado clientes
		public void FiltrarRegistros(DataGridView dataGrid, String texto)
		{
			da = new SqlDataAdapter("Select * From Clientes Where Nombre1 like '%" + texto + "%' or Nombre2 like '%" + texto + "%' or Nombre3 like '%" + texto + "%' or Apellido1 like '%" + texto + "%' or Apellido2 like '%" + texto + "%' or DUI like '%" + texto + "%' or NIT like '%" + texto + "%'", cn);
			DataSet ds = new DataSet();
			da.Fill(ds, "DUI");
			dataGrid.DataSource = ds;
			dataGrid.DataMember = "DUI";
		}
		//Borrar cliente
		public String EliminarCliente(Int32 codigo)
		{
			try
			{

				cmd = new SqlCommand("Delete From Clientes Where [CodigoCliente] = '"+codigo+"'", cn);
				cmd.ExecuteNonQuery();
				return "El cliente fue eliminado con éxito";
			}
			catch (Exception ex)
			{
				return "El cliente no pudo ser eliminado. \t\n" + ex.ToString();
			}
		}
	}
}
