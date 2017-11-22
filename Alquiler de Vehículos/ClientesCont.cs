using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alquiler_de_Vehículos
{
	public partial class ClientesCont : Form
	{
		Clientes clientes = new Clientes();
		public ClientesCont()
		{
			InitializeComponent();
		}

		private void btnagregar_Click(object sender, EventArgs e)
		{
			clientes.DUI = txtDui.Text;
			clientes.NIT = txtNit.Text;
			clientes.Nombre1 = txtPnombre.Text;
			clientes.Nombre2 = txtSnombre.Text;
			clientes.Nombre3 = txttercernombre.Text;
			clientes.Apellido1 = txtPapellido.Text;
			clientes.Apellido2 = txtSapellido.Text;
			clientes.Nacimiento = dtpNacimiento.Text;
			clientes.Direccion = txtdireccion.Text;
			clientes.Email = txtcorreo.Text;
			clientes.TipoLicencia = cbtipolicencia.SelectedItem.ToString();
			clientes.Tel = Convert.ToInt32(txttelefono.Text);

			//MessageBox.Show(clientes.Nacimiento.ToString()+"\t\n"+clientes.TipoLicencia.ToString());
			clientes.AgregarCliente();
		}

		private void stsRegresar_Click(object sender, EventArgs e)
		{
			frmprincipal frmprincipal = new frmprincipal();
			this.Hide();
			frmprincipal.ShowDialog();
			this.Close();
			
		}
	}
}
