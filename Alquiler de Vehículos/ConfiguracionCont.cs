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
		public ConfiguracionCont()
		{
			InitializeComponent();
		}

		private void txtprueba_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Validaciones.TexBoxContent(4, txtprueba, e.KeyChar) == false)
			{
				e.Handled = true;
			}
		}

		private void txtprueba_Leave(object sender, EventArgs e)
		{
			/*if (!Validaciones.TexBoxEmpty(txtprueba))
			{
				MessageBox.Show("Debe ingresar un valor");
			}*/
		}

		private void txtprueba2_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Validaciones.TexBoxContent(1, txtprueba2, e.KeyChar))
			{
				MessageBox.Show("Solo puede ingresar valores enteros positivos.");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			/*if (Validaciones.TexBoxEmpty(txtprueba) && Validaciones.TexBoxEmpty(txtprueba2))
			{
				MessageBox.Show("Validación correcta");
			}
			else
			{
				MessageBox.Show("Validaciones incorrectas, faltan valores.");
			}*/
		}

		private void txtprueba2_Leave(object sender, EventArgs e)
		{
			/*if (!Validaciones.TexBoxEmpty(txtprueba2))
			{
				MessageBox.Show("Debe ingresar un valor");
			}*/
		}

		private void ConfiguracionCont_Load(object sender, EventArgs e)
		{
			button1.Focus();
		}
	}
}
