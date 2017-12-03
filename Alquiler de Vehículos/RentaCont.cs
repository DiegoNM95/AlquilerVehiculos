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
			dtpDevolucion.Value = DateTime.Today;
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
			txtnombreclientes.Text = dgvUser.CurrentRow.Cells[3].Value.ToString() + " " + dgvUser.CurrentRow.Cells[4].Value.ToString() + " " + dgvUser.CurrentRow.Cells[5].Value.ToString() + " " + dgvUser.CurrentRow.Cells[6].Value.ToString();
			txtDui.Text = dgvUser.CurrentRow.Cells[1].Value.ToString();
			txtNit.Text = dgvUser.CurrentRow.Cells[2].Value.ToString();
		}

		private void btnSelectV_Click(object sender, EventArgs e)
		{
			txtCodigoVehiculo.Text = dgvVehiculo.CurrentRow.Cells[0].Value.ToString();
			txtPlaca.Text = dgvVehiculo.CurrentRow.Cells[1].Value.ToString();
			txtMarca.Text = dgvVehiculo.CurrentRow.Cells[2].Value.ToString();
			txtModelo.Text = dgvVehiculo.CurrentRow.Cells[3].Value.ToString();
			txtClase.Text = dgvVehiculo.CurrentRow.Cells[5].Value.ToString();
		}

		private void btnRentar_Click(object sender, EventArgs e)
		{
			if (txtCodigoCliente.Text != "" && txtCodigoVehiculo.Text != "")
			{
				//Asignacion de valores
				DateTime fdevol = new DateTime(dtpDevolucion.Value.Year, dtpDevolucion.Value.Month, dtpDevolucion.Value.Day, 0, 0, 0);
				renta.Fechadevolucion = fdevol;
				DateTime frenta = DateTime.Now;
				renta.Fecharenta = frenta;
				renta.Fianza = Convert.ToDouble(txtFianza.Text);
				renta.CodigoVehiculo = Convert.ToInt32(txtCodigoVehiculo.Text);
				renta.CodigoCliente = Convert.ToInt32(txtCodigoCliente.Text);
				//txtMonto.Text = renta.Monto.ToString();
				renta.Mora = 0;
				renta.Monto = renta.MontoVehiculo();
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

		private void tsmLimpiar_Click(object sender, EventArgs e)
		{
			txtClase.Text = "";
			txtCodigoCliente.Text = "";
			txtCodigoVehiculo.Text = "";
			txtDui.Text = "";
			txtMarca.Text = "";
			txtModelo.Text = "";
			txtNit.Text = "";
			txtnombreclientes.Text = "";
			txtPlaca.Text = "";
			txtUser.Text = "";
			txtVehiculo.Text = "";
		}

		private void btnEntrega_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Desea agregar la entrega de este auto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				renta.CodigoRenta = Convert.ToInt32(dgvListadoRenta.CurrentRow.Cells[0].Value.ToString());
				renta.FechaEntrega = DateTime.Now;
				renta.AgregarEntrega(dgvListadoRenta.CurrentRow.Cells[6].Value.ToString());
				//MessageBox.Show(renta.CodigoRenta.ToString() + "," + renta.FechaEntrega.ToString() + "," + renta.CodigoVehiculo.ToString() + "," + renta.Mora.ToString() + "," + renta.Monto.ToString());
				textBox1.Text = "";
				txtUser.Text = "";
				txtVehiculo.Text = "";
				renta.ListadoRenta(dgvListadoRenta);
				renta.CargarVehiculos(dgvVehiculo);
				renta.CargarClientes(dgvUser);
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			renta.FiltrarListadoRenta(dgvListadoRenta, textBox1.Text);
		}
	}
}
