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
	}
}
