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
	public partial class frmprincipal : Form
	{
		public frmprincipal()
		{
			InitializeComponent();
		}

		private void btnconfiguracion_Click(object sender, EventArgs e)
		{
			ConfiguracionCont frmconfiguracion = new ConfiguracionCont();
			this.Hide();
			frmconfiguracion.ShowDialog();
			this.Close();
		}

		private void btnprecios_Click(object sender, EventArgs e)
		{
			PreciosCont preciosCont = new PreciosCont();
			this.Hide();
			preciosCont.ShowDialog();
			this.Close();
		}

		private void btnclientes_Click(object sender, EventArgs e)
		{
			ClientesCont clientes = new ClientesCont();
			this.Hide();
			clientes.ShowDialog();
			this.Close();
		}

		private void btnvehiculos_Click(object sender, EventArgs e)
		{
			VehiculosCont vehiculosCont = new VehiculosCont();
			this.Hide();
			vehiculosCont.ShowDialog();
			this.Close();
		}

		private void btnrenta_Click(object sender, EventArgs e)
		{
			RentaCont rentaCont = new RentaCont();
			this.Hide();
			rentaCont.ShowDialog();
			this.Close();
		}

		private void btnusuarios_Click(object sender, EventArgs e)
		{
			UsuariosCont usuariosCont = new UsuariosCont();
			this.Hide();
			usuariosCont.ShowDialog();
			this.Close();
		}

		private void frmprincipal_Load(object sender, EventArgs e)
		{
			lblnameuser.Text = Usuario.UsuarioEtiqueta;
		}
	}
}
