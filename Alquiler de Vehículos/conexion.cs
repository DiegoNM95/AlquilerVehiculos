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
				//MessageBox.Show("Conexion exitosa.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al conectar con la base de datos. \t\n Error: " + ex.ToString());
			}
		}


		/*///////////////////////////////////////////////////////////////////////USUARIOS///////////////////////////////////////////////////////////////////////////////////////////*/

		//Agregar Usuarios
		public String AgregarUsuario(Int32 codigo, String usuario, String pass, String tipo)
		{
			try
			{
				cmd = new SqlCommand("Insert Into Usuarios(codigo,usuario,password,tipo) Values(" + codigo + ",'" + usuario + "','" + pass + "','" + tipo + "')", cn);
				cmd.ExecuteNonQuery();
				return "Usuario agregado con éxito.";
			}
			catch (Exception ex)
			{
				return "No se pudo agregar el usuario. \t\n" + ex.ToString();
			}
		}
		//Modificar Usuarios
		public String ModificarUsuario(Int32 codigo, String usuario, String pass, String tipo)
		{
			try
			{
				cmd = new SqlCommand("Update Usuarios SET [usuario] ='"+usuario+"',[password]='"+pass+"', [tipo]='"+tipo+"' WHERE codigo = "+codigo+"", cn);
				cmd.ExecuteNonQuery();
				return "Datos modificados con éxito.";
			}
			catch (Exception ex)
			{
				return "No se pudo modificar el usuario. \t\n" + ex.ToString();
			}
		}
		//Metodo para cargar informacion en texbox usuario
		public String[] CargarTexboxUsuarios(String usuario)
		{
			try
			{
				cmd = new SqlCommand("Select * From Usuarios Where [usuario] = '" + usuario + "'", cn);
				dr = cmd.ExecuteReader();
				if (dr.Read())
				{
					String[] valores = new string[] { dr["codigo"].ToString(), dr["password"].ToString(), dr["tipo"].ToString()};
					return valores;
				}
				dr.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se pudo realizar la consulta de usuarios a la BD. \t\n" + ex.ToString());
			}
			return null;
		}
		//Borrar usUARIO
		public String EliminarUsuario(Int32 codigo)
		{
			try
			{

				cmd = new SqlCommand("Delete From Usuarios Where [codigo] = '" + codigo + "'", cn);
				cmd.ExecuteNonQuery();
				return "El usuario fue eliminado con éxito";
			}
			catch (Exception ex)
			{
				return "El cliente no pudo ser eliminado. \t\n" + ex.ToString();
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
		//Filtrar registros en listado clientes
		public void FiltrarRegistrosUsuarios(DataGridView dataGrid, String texto)
		{
			da = new SqlDataAdapter("Select * From Usuarios Where usuario like '%" + texto + "%' or tipo like '%" + texto + "%'", cn);
			DataSet ds = new DataSet();
			da.Fill(ds, "usuario");
			dataGrid.DataSource = ds;
			dataGrid.DataMember = "usuario";
		}

		///////////////////////////////////////////////////METODOS GENERALES////////////////////////////////////////////////////////////////////////////////////////////
		//Número de Registros existentes
		public Int32 CuentaRegistros(String nombretabla, String campo)
		{
			Int32 cont;
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
			catch
			{
				//MessageBox.Show("No se pudo realizar la consulta a la BD. \t\n" + ex.ToString());
			}
			return cont=0;
		}
		//Busca los registros de x tabla en un campo definido con el valor asignado, y devuel el valor del campo solicitado
		public String BusquedaReg(String tabla, String campocondicion, String valor, String campo)
		{
			try
			{
				cmd = new SqlCommand("Select * From " + tabla + " Where [" + campocondicion + "] = " + valor + "", cn);
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
				salida = "Datos no actualizados. \t\n" + ex.ToString();
			}
			return salida;
		}
		//Metodo para cargar informacion en texbox clientes
		public String[] CargarTexboxClientes(String dui)
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
		public void FiltrarRegistrosClientes(DataGridView dataGrid, String texto)
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

		//////////////////////////////////////////////////////////////METODOS DE VEHICULOS/////////////////////////////////////////////////////////////////////////////////////////////////

		//Agregar Vehiculo
		public String AgregarVehiculo(Int32 codigo, String placa, String marca, String modelo,String color, Int32 año, String clase, String embrague, String propietario, Double renta)
		{
			String salida = "Vehículo agregado con exito";
			try
			{
				cmd = new SqlCommand("Insert Into Vehiculos([CodigoVehiculo],[Placa],[Marca],[Modelo],[Color],[Año],[Clase],[Tipoembrague],[Propietario],[Renta]) Values(" + codigo + ",'" + placa + "','" + marca + "','" + modelo + "','" + color + "'," + año + ",'" + clase + "','" + embrague + "','" + propietario + "'," + renta + ")", cn);
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				return salida = "Vehiculo no agregado. \t\n" + ex.ToString();
			}
			return salida;
		}
		//Metodo para cargar informacion en texbox vehiculos
		public String[] CargarTexboxVehiculos(String placa)
		{
			try
			{
				cmd = new SqlCommand("Select * From Vehiculos Where [Placa] = '" + placa + "'", cn);
				dr = cmd.ExecuteReader();
				if (dr.Read())
				{
					String[] valores = new string[] { dr["CodigoVehiculo"].ToString(), dr["Marca"].ToString(), dr["Modelo"].ToString(), dr["Color"].ToString(), dr["Año"].ToString(), dr["Clase"].ToString(), dr["Tipoembrague"].ToString(), dr["Propietario"].ToString(), dr["Renta"].ToString()};
					return valores;
				}
				dr.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se pudo realizar la consulta a la BD. \t\n" + ex.ToString());
			}
			return null;
		}
		//Filtrar registros en listado vehiculos
		public void FiltrarRegistrosVehiculos(DataGridView dataGrid, String texto)
		{
			da = new SqlDataAdapter("Select * From Vehiculos Where Placa like '%" + texto + "%' or Marca like '%" + texto + "%' or Modelo like '%" + texto + "%' or Año like '%" + texto + "%' or Clase like '%" + texto + "%' or Tipoembrague like '%" + texto + "%' or Propietario like '%" + texto + "%'", cn);
			DataSet ds = new DataSet();
			da.Fill(ds, "Placa");
			dataGrid.DataSource = ds;
			dataGrid.DataMember = "Placa";
		}
		//Metodo para madificar vehiculo
		public String ActualizacionVehiculo(Int32 codigo, String placa, String marca, String modelo, String color, Int32 año, String clase, String embrague, String propietario)
		{
			String salida = "Datos de vehiculo actualizados con éxito.";
			try
			{
				cmd = new SqlCommand("UPDATE [Vehiculos] SET [Placa]= '" + placa + "',[Marca] ='" + marca + "',[Modelo] ='" + modelo + "',[Color] ='" + color + "',[Año] ='" + año + "',[Clase] ='" + clase + "',[Tipoembrague] ='" + embrague + "',[Propietario] ='" + propietario + "' WHERE [CodigoVehiculo]=" + codigo + "", cn);
				cmd.ExecuteNonQuery();
				return salida;
			}
			catch (Exception ex)
			{
				salida = "Datos no actualizados. \t\n" + ex.ToString();
			}
			return salida;
		}
		//Borrar vehiculo
		public String EliminarVehiculo(Int32 codigo)
		{
			try
			{

				cmd = new SqlCommand("Delete From Vehiculos Where [CodigoVehiculo] = '" + codigo + "'", cn);
				cmd.ExecuteNonQuery();
				return "El vehiculo fue eliminado con éxito";
			}
			catch (Exception ex)
			{
				return "El vehiculo no pudo ser eliminado. \t\n" + ex.ToString();
			}
		}
		//Modificar precio
		public String ActualizacionPrecioVehiculo(Int32 codigo, Double renta)
		{
			String salida = "Precio de vehículo actualizado con éxito.";
			try
			{
				cmd = new SqlCommand("UPDATE [Vehiculos] SET [Renta]= " + renta + " WHERE [CodigoVehiculo]=" + codigo + "", cn);
				cmd.ExecuteNonQuery();
				return salida;
			}
			catch (Exception ex)
			{
				salida = "Precio no actualizados. \t\n" + ex.ToString();
			}
			return salida;
		}

		////////////////////////////////////////////////////////////////////////////RENTA///////////////////////////////////////////////////////////////////////

		//Agregar renta
		public String AgregarRenta(Int32 codigorenta, Int32 codigocliente, Int32 codigovehiculo, String Fecharenta, String Fechadevolucion, Double Fianza, Double Monto, Double Mora)
		{
			String salida = "Renta realizada con éxito";
			try
			{
				cmd = new SqlCommand("Insert Into Renta([CodigoRenta],[CodigoCliente],[CodigoVehiculo],[FechaRenta],[FechaDevolucion],[Fianza],[Monto],[Mora]) Values(" + codigorenta + "," + codigocliente + "," + codigovehiculo + ",'" + Fecharenta + "','" + Fechadevolucion + "'," + Fianza + "," + Monto +","+Mora+")", cn);
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				return salida = "Renta no realizada. \t\n" + ex.ToString();
			}
			return salida;
		}
		//Consultar Renta
		public void ConsultaRenta(DataGridView dataGrid)
		{
			try
			{
				da = new SqlDataAdapter("SELECT [Renta].[CodigoRenta],[Clientes].[DUI],[Clientes].[Nombre1],[Clientes].[Nombre2],[Clientes].[Apellido1],[Clientes].[Apellido2],[Vehiculos].[Placa],[Vehiculos].[Marca],[Vehiculos].[Modelo],[Renta].[FechaRenta],[Renta].[FechaDevolucion],[Renta].[FechaEntrega],[Renta].[Fianza],[Renta].[Mora],[Renta].[Monto]  FROM [Renta]  INNER JOIN [Clientes] ON Clientes.CodigoCliente = Renta.CodigoCliente INNER JOIN[Vehiculos] ON Vehiculos.CodigoVehiculo = Renta.CodigoVehiculo", cn);
				dt = new DataTable();
				da.Fill(dt);
				dataGrid.DataSource = dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se pudo cargar los registros a la tabla Renta. \t\n" + ex.ToString());
			}
		}
		//Agregar entrega
		public String AgregarEntrega(Int32 codigorenta, String fechaentrega, Double mora, Double monto)
		{
			try
			{
				cmd = new SqlCommand("UPDATE Renta SET FechaEntrega='" + fechaentrega + "', Mora=" + mora + ", Monto=" + monto + " WHERE CodigoRenta=" + codigorenta + "", cn);
				cmd.ExecuteNonQuery();
				return "Entrega de vehículo realizada con éxito.";
			}
			catch (Exception ex)
			{
				return "No pudo agregarse la entraga del vehículo. \t\n" + ex.ToString();
			}
		}
		//Cargar vehiculos sin rentar o que tengan precio de renta distinto de cero
		public void CargarDtvVehiculos(DataGridView dataGrid)
		{
			try
			{
				da = new SqlDataAdapter("SELECT	V.CodigoVehiculo,V.Placa,V.Marca,V.Modelo,V.Color,V.Renta FROM  Vehiculos As V WHERE V.Renta <> 0 And((Select COUNT(CodigoRenta) From Renta Where CodigoVehiculo = V.CodigoVehiculo And FechaEntrega is null) = 0 Or(Select COUNT(CodigoVehiculo) From Renta Where CodigoVehiculo = V.CodigoVehiculo) = 0)", cn);
				dt = new DataTable();
				da.Fill(dt);
				dataGrid.DataSource = dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se pudo cargar los registros a la tabla. \t\n" + ex.ToString());
			}
		}
		//Cargar Clientes sin rentar o que tengan precio de renta distinto de cero
		public void CargarDtvClientes(DataGridView dataGrid)
		{
			try
			{
				da = new SqlDataAdapter("SELECT	C.CodigoCliente,C.DUi,C.NIT,C.Nombre1,C.Nombre2,C.Apellido1,C.Apellido2 from Clientes As C Where (Select Count(CodigoRenta) From Renta As R Where R.CodigoCliente = C.CodigoCliente And R.FechaEntrega Is Null) = 0 Or(Select Count(CodigoRenta) From Renta As R Where R.CodigoCliente = C.CodigoCliente And R.CodigoRenta is not null) = 0", cn);
				dt = new DataTable();
				da.Fill(dt);
				dataGrid.DataSource = dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se pudo cargar los registros a la tabla. \t\n" + ex.ToString());
			}
		}
		//Filtrar Clientes en renta
		public void FiltrarClientesRenta(DataGridView dataGrid, String texto)
		{
			da = new SqlDataAdapter("SELECT	C.CodigoCliente,C.DUi,C.NIT,C.Nombre1,C.Nombre2,C.Apellido1,C.Apellido2 From Clientes As C Where ((Select Count(CodigoRenta) From Renta As R Where R.CodigoCliente = C.CodigoCliente And R.FechaEntrega Is Null) = 0 Or(Select Count(CodigoRenta) From Renta As R Where R.CodigoCliente = C.CodigoCliente And R.CodigoRenta is not null) = 0) And(C.DUI like '%"+texto+"%' or C.NIT like '%"+texto+ "%' or C.Nombre1 like '" + texto + "%' or C.Nombre2 like '" + texto + "%' or C.Apellido1 like '" + texto + "%' or C.Apellido2 like '" + texto + "%')", cn);
			DataSet ds = new DataSet();
			da.Fill(ds, "CodigoCliente");
			dataGrid.DataSource = ds;
			dataGrid.DataMember = "CodigoCliente";
		}
		//Filtrar vehiculos en renta
		public void FiltrarVehiculosRenta(DataGridView dataGrid, String texto)
		{
			da = new SqlDataAdapter("SELECT	V.CodigoVehiculo,V.Placa,V.Marca,V.Modelo,V.Color,V.Renta FROM  Vehiculos As V WHERE V.Renta <> 0 And((Select COUNT(CodigoRenta) From Renta Where CodigoVehiculo = V.CodigoVehiculo And FechaEntrega is null) = 0 Or(Select COUNT(CodigoVehiculo) From Renta Where CodigoVehiculo = V.CodigoVehiculo) = 0) And(Placa like '%"+texto+"%' or Marca like '"+texto+"%' or Modelo like '"+texto+"%' or Color like '"+texto+"%' or Renta like '%"+texto+"%')", cn);
			DataSet ds = new DataSet();
			da.Fill(ds, "CodigoVehiculo");
			dataGrid.DataSource = ds;
			dataGrid.DataMember = "CodigoVehiculo";
		}
		//Filtrar el listado de renta
		public void FiltrarListadoRenta(DataGridView dataGrid, String texto)
		{
			try
			{
				da = new SqlDataAdapter("SELECT [Renta].[CodigoRenta],[Clientes].[DUI],[Clientes].[Nombre1],[Clientes].[Nombre2],[Clientes].[Apellido1],[Clientes].[Apellido2],[Vehiculos].[Placa],[Vehiculos].[Marca],[Vehiculos].[Modelo],[Renta].[FechaRenta],[Renta].[FechaDevolucion],[Renta].[FechaEntrega],[Renta].[Fianza],[Renta].[Mora],[Renta].[Monto] FROM[Renta] INNER JOIN[Clientes] ON Clientes.CodigoCliente = Renta.CodigoCliente INNER JOIN[Vehiculos] ON Vehiculos.CodigoVehiculo = Renta.CodigoVehiculo WHERE[Clientes].[DUI] like '%"+texto+ "%' OR[Clientes].[Nombre1] like '" + texto + "%' OR[Clientes].[Nombre2] like '" + texto + "%' OR[Clientes].[Apellido1] like '" + texto + "%' OR[Clientes].[Apellido2] like '" + texto + "%' OR[Vehiculos].[Placa] like '%" + texto + "%' OR[Vehiculos].[Marca] like '" + texto + "%' OR[Vehiculos].[Modelo] like '" + texto + "%'", cn);
				dt = new DataTable();
				da.Fill(dt);
				dataGrid.DataSource = dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se pudo cargar los registros a la tabla Renta. \t\n" + ex.ToString());
			}
		}
	}
}
