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
	public partial class ConfiguracionCont : Form
	{
		Validaciones Validaciones = new Validaciones();
		public ConfiguracionCont()
		{
			InitializeComponent();
		}

		private void txtprueba_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Validaciones.TexBox(4, txtprueba, e.KeyChar) == false)
			{
				e.Handled = true;
			}
		}
	}
}
