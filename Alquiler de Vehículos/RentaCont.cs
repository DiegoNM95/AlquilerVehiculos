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
	public partial class frmRenta : Form
	{
		Renta renta = new Renta();
		public frmRenta()
		{
			InitializeComponent();
		}

		private void frmRenta_Load(object sender, EventArgs e)
		{
			renta.CargarClientes(dgvUser);
			renta.CargarVehiculos(dgvVehiculo);
			renta.ListadoRenta(dgvListadoRenta);
		}

		private void txtUser_TextChanged(object sender, EventArgs e)
		{
			renta.FiltrarClientes(dgvUser, txtUser.Text);
		}

		private void txtVehiculo_TextChanged(object sender, EventArgs e)
		{
			renta.FiltrarVehiculos(dgvVehiculo, txtVehiculo.Text);
		}

		private void btnselectU_Click(object sender, EventArgs e)
		{
			txtCodigoCliente.Text = dgvUser.CurrentRow.Cells[0].Value.ToString();
			txtnombreclientes.Text = dgvUser.CurrentRow.Cells[3].Value.ToString() + " " + dgvUser.CurrentRow.Cells[4].Value.ToString() + " " + dgvUser.CurrentRow.Cells[5].Value.ToString() + " " + dgvUser.CurrentRow.Cells[6].Value.ToString() + " " + dgvUser.CurrentRow.Cells[7].Value.ToString();
			txtDui.Text = dgvUser.CurrentRow.Cells[1].Value.ToString();
			txtNit.Text = dgvUser.CurrentRow.Cells[2].Value.ToString();
		}

		private void btnSelectV_Click(object sender, EventArgs e)
		{
			txtCodigoVehiculo.Text = dgvVehiculo.CurrentRow.Cells[0].Value.ToString();
			txtPlaca.Text = dgvVehiculo.CurrentRow.Cells[1].Value.ToString();
			txtMarca.Text = dgvVehiculo.CurrentRow.Cells[2].Value.ToString();
			txtModelo.Text = dgvVehiculo.CurrentRow.Cells[3].Value.ToString();
			txtClase.Text = dgvVehiculo.CurrentRow.Cells[6].Value.ToString();
		}

		private void btnRentar_Click(object sender, EventArgs e)
		{
			if (txtCodigoCliente.Text != "" && txtCodigoVehiculo.Text != "")
			{
				//Asignacion de valores
				DateTime fdevol = new DateTime(dtpDevolucion.Value.Year, dtpDevolucion.Value.Month, dtpDevolucion.Value.Day, 0, 0, 0);
				renta.Fechadevolucion = fdevol;
				DateTime frenta = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 0, 0, 0);
				renta.Fecharenta = frenta;
				renta.Fianza = Convert.ToDouble(txtFianza.Text);
				renta.CodigoVehiculo = Convert.ToInt32(txtCodigoVehiculo.Text);
				renta.CodigoCliente = Convert.ToInt32(txtCodigoCliente.Text);
				renta.Monto = renta.MontoVehiculo();
				txtMonto.Text = renta.Monto.ToString();
				//Agrego la renta
				renta.AgregarRenta();
				//Actualizo listado
				renta.ListadoRenta(dgvListadoRenta);
			}
			else
			{
				MessageBox.Show("Tiene que seleccionar un cliente y un vehículo");
			}
		}

		private void tsmRegresar_Click(object sender, EventArgs e)
		{
			frmprincipal frmprincipal = new frmprincipal();
			this.Hide();
			frmprincipal.ShowDialog();
			this.Close();
		}
	}
}
