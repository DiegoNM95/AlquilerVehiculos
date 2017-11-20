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
	}
}
