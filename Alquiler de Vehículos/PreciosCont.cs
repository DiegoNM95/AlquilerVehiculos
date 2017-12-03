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
	public partial class frmPrecios : Form
	{
		Vehiculo vehiculo = new Vehiculo();
		public frmPrecios()
		{
			InitializeComponent();
		}

		private void frmPrecios_Load(object sender, EventArgs e)
		{
			vehiculo.FillTable(dgvListado);
		}

		private void txtbusqueda_TextChanged(object sender, EventArgs e)
		{
			vehiculo.FiltrarListado(dgvListado, txtbusqueda.Text);
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Está seguro que quiere agregar un nuevo precio?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes && Validaciones.TexBoxEmpty(txtPrecio, pbPrecio))
			{
				vehiculo.Codigo = Convert.ToInt32(dgvListado.CurrentRow.Cells[0].Value.ToString());
				vehiculo.Renta = Convert.ToDouble(txtPrecio.Text);
				vehiculo.ActualizarPrecioVehiculos();
				vehiculo.FillTable(dgvListado);
				txtbusqueda.Text = "";
			}
			else
			{
				MessageBox.Show("Debe ingresar un precio");
			}
		}

		private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Validaciones.TexBoxContent(2, txtPrecio, e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void tsmRegresar_Click(object sender, EventArgs e)
		{
			frmprincipal frmprincipal = new frmprincipal();
			this.Hide();
			frmprincipal.ShowDialog();
			this.Close();
		}

		private void txtPrecio_Leave(object sender, EventArgs e)
		{
			Validaciones.TexBoxEmpty(txtPrecio, pbPrecio);
		}
	}
}
