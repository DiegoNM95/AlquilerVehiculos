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
	public partial class frmVehiculos : Form
	{
		Vehiculo vehiculo = new Vehiculo();
		public frmVehiculos()
		{
			InitializeComponent();
		}

		private void txtAño_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Validaciones.TexBoxContent(1, txtAño, e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Validaciones.VDocument(3,txtPlaca,e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtPlaca_Leave(object sender, EventArgs e)
		{
			Validaciones.TexBoxEmpty(txtPlaca, pbPlaca);
		}

		private void txtColor_Leave(object sender, EventArgs e)
		{
			Validaciones.TexBoxEmpty(txtColor, pbColor);
		}

		private void txtPropietario_Leave(object sender, EventArgs e)
		{
			Validaciones.TexBoxEmpty(txtPropietario, pbPropietario);
		}

		private void txtMarca_Leave(object sender, EventArgs e)
		{
			Validaciones.TexBoxEmpty(txtMarca, pbMarca);
		}

		private void txtModelo_Leave(object sender, EventArgs e)
		{
			Validaciones.TexBoxEmpty(txtModelo, pbModelo);
		}

		private void cboClaseVehiculo_Leave(object sender, EventArgs e)
		{
			Validaciones.ComboBoxEmpty(cboClaseVehiculo, pbClasevehiculo);
		}

		private void cboEmbrague_Leave(object sender, EventArgs e)
		{
			Validaciones.ComboBoxEmpty(cboEmbrague, pbEmbrague);
		}

		private void txtAño_Leave(object sender, EventArgs e)
		{
			Validaciones.TexBoxEmpty(txtAño, pbAño);
		}

		private void tsmRegresar_Click(object sender, EventArgs e)
		{
			frmprincipal frmprincipal = new frmprincipal();
			this.Hide();
			frmprincipal.ShowDialog();
			this.Close();
		}

		private void txtPlaca_TextChanged(object sender, EventArgs e)
		{
			Validaciones.TexBoxEmpty(txtPlaca, pbPlaca);
		}

		private void txtColor_TextChanged(object sender, EventArgs e)
		{
			Validaciones.TexBoxEmpty(txtColor, pbColor);
		}

		private void txtPropietario_TextChanged(object sender, EventArgs e)
		{
			Validaciones.TexBoxEmpty(txtPropietario, pbPropietario);
		}

		private void txtMarca_TextChanged(object sender, EventArgs e)
		{
			Validaciones.TexBoxEmpty(txtMarca, pbMarca);
		}

		private void txtModelo_TextChanged(object sender, EventArgs e)
		{
			Validaciones.TexBoxEmpty(txtModelo, pbModelo);
		}

		private void txtAño_TextChanged(object sender, EventArgs e)
		{
			Validaciones.TexBoxEmpty(txtAño, pbAño);
		}

		private void cboClaseVehiculo_SelectedIndexChanged(object sender, EventArgs e)
		{
			Validaciones.ComboBoxEmpty(cboClaseVehiculo, pbClasevehiculo);
		}

		private void cboEmbrague_SelectedIndexChanged(object sender, EventArgs e)
		{
			Validaciones.ComboBoxEmpty(cboEmbrague, pbEmbrague);
		}

		private void tsmLimpiarcampos_Click(object sender, EventArgs e)
		{
			txtPlaca.Text = "";
			pbPlaca.Visible = false;
			txtColor.Text = "";
			pbColor.Visible = false;
			txtPropietario.Text = "";
			pbPropietario.Visible = false;
			txtMarca.Text = "";
			pbMarca.Visible = false;
			txtModelo.Text = "";
			pbModelo.Visible = false;
			txtAño.Text = "";
			pbAño.Visible = false;
			cboClaseVehiculo.SelectedIndex = -1;
			pbClasevehiculo.Visible = false;
			cboEmbrague.SelectedIndex = -1;
			pbEmbrague.Visible = false;
			btnmodificar.Enabled = false;
			btneliminar.Enabled = false;
		}

		private void frmVehiculos_Load(object sender, EventArgs e)
		{
			btnmodificar.Enabled = false;
			btneliminar.Enabled = false;
			vehiculo.FillTable(dgvlistadodeautos);
		}

		private void btnagregar_Click(object sender, EventArgs e)
		{
			//Asignación de valores
			vehiculo.Placa = txtPlaca.Text;
			vehiculo.Color = txtColor.Text;
			vehiculo.Propietario = txtPropietario.Text;
			vehiculo.Marca = txtMarca.Text;
			vehiculo.Modelo = txtModelo.Text;
			vehiculo.Año = Convert.ToInt32(txtAño.Text);
			vehiculo.Clase = cboClaseVehiculo.Text;
			vehiculo.Tipoembrague = cboEmbrague.Text;
			vehiculo.Renta = 0.00;
			//Agregar vehículo
			vehiculo.AgregarVehiculo();
			//Actualizar listados
			vehiculo.FillTable(dgvlistadodeautos);
			//Limpiar campos
			txtPlaca.Text = "";
			pbPlaca.Visible = false;
			txtColor.Text = "";
			pbColor.Visible = false;
			txtPropietario.Text = "";
			pbPropietario.Visible = false;
			txtMarca.Text = "";
			pbMarca.Visible = false;
			txtModelo.Text = "";
			pbModelo.Visible = false;
			txtAño.Text = "";
			pbAño.Visible = false;
			cboClaseVehiculo.SelectedIndex = -1;
			pbClasevehiculo.Visible = false;
			cboEmbrague.SelectedIndex = -1;
			pbEmbrague.Visible = false;
			btnmodificar.Enabled = false;
			btneliminar.Enabled = false;
		}

		private void btnbuscar_Click(object sender, EventArgs e)
		{
			if (vehiculo.AddTexBoxVehiculos(txtPlaca.Text))
			{
				txtCodigo.Text = vehiculo.Codigo.ToString();
				txtPlaca.Text = vehiculo.Placa;
				txtColor.Text = vehiculo.Color;
				txtPropietario.Text = vehiculo.Propietario;
				txtMarca.Text = vehiculo.Marca;
				txtModelo.Text = vehiculo.Modelo;
				txtAño.Text = vehiculo.Año.ToString();
				cboClaseVehiculo.Text = vehiculo.Clase;
				cboEmbrague.Text = vehiculo.Tipoembrague;
				btnmodificar.Enabled = true;
				btneliminar.Enabled = true;

			}
		}

		private void btnbuscarlistado_Click(object sender, EventArgs e)
		{
			if (vehiculo.AddTexBoxVehiculos(dgvlistadodeautos.CurrentRow.Cells[1].Value.ToString()))
			{
				txtCodigo.Text = vehiculo.Codigo.ToString();
				txtPlaca.Text = vehiculo.Placa;
				txtColor.Text = vehiculo.Color;
				txtPropietario.Text = vehiculo.Propietario;
				txtMarca.Text = vehiculo.Marca;
				txtModelo.Text = vehiculo.Modelo;
				txtAño.Text = vehiculo.Año.ToString();
				cboClaseVehiculo.Text = vehiculo.Clase;
				cboEmbrague.Text = vehiculo.Tipoembrague;
				btnmodificar.Enabled = true;
				btneliminar.Enabled = true;
				tbvehiculos.SelectedTab = tbpvehiculos;
				tbpvehiculos.Show();
				tbpvehiculos.Focus();
			}
		}

		private void txtbuscarlistado_TextChanged(object sender, EventArgs e)
		{
			vehiculo.FiltrarListado(dgvlistadodeautos, txtbuscarlistado.Text);
		}

		private void btnmodificar_Click(object sender, EventArgs e)
		{
			if ((Validaciones.TexBoxEmpty(txtPlaca, pbPlaca) && Validaciones.TexBoxEmpty(txtColor, pbColor) && Validaciones.TexBoxEmpty(txtPropietario, pbPropietario) && Validaciones.TexBoxEmpty(txtMarca, pbMarca) && Validaciones.TexBoxEmpty(txtModelo, pbModelo) && Validaciones.ComboBoxEmpty(cboClaseVehiculo, pbClasevehiculo) && Validaciones.TexBoxEmpty(txtAño, pbAño) && Validaciones.ComboBoxEmpty(cboEmbrague, pbEmbrague)) == false)
			{
				MessageBox.Show("Debe completar la información para modificar el vehiculo");
			}
			else
			{
				vehiculo.Codigo = Convert.ToInt32(txtCodigo.Text);
				vehiculo.Placa = txtPlaca.Text;
				vehiculo.Marca = txtMarca.Text;
				vehiculo.Modelo = txtModelo.Text;
				vehiculo.Color = txtColor.Text;
				vehiculo.Propietario = txtPropietario.Text;
				vehiculo.Clase = cboClaseVehiculo.SelectedItem.ToString();
				vehiculo.Tipoembrague = cboEmbrague.SelectedItem.ToString();
				vehiculo.Año = Convert.ToInt32(txtAño.Text);

				vehiculo.ActualizarVehiculos();
				vehiculo.FillTable(dgvlistadodeautos);
			}
		}

		private void btneliminar_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Seguro que quiere borrar el vehiculo placa: " + txtPlaca.Text, "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				//Asignamos el valor de Dui y de Codigo
				vehiculo.Codigo = Convert.ToInt32(txtCodigo.Text);
				vehiculo.Placa = txtPlaca.Text;
				//Eliminar Cliente
				vehiculo.EliminarVehiculos();
				//Actulizar Listado
				vehiculo.FillTable(dgvlistadodeautos);
				//Limpiar Campos
				txtPlaca.Text = "";
				pbPlaca.Visible = false;
				txtColor.Text = "";
				pbColor.Visible = false;
				txtPropietario.Text = "";
				pbPropietario.Visible = false;
				txtMarca.Text = "";
				pbMarca.Visible = false;
				txtModelo.Text = "";
				pbModelo.Visible = false;
				txtAño.Text = "";
				pbAño.Visible = false;
				cboClaseVehiculo.SelectedIndex = -1;
				pbClasevehiculo.Visible = false;
				cboEmbrague.SelectedIndex = -1;
				pbEmbrague.Visible = false;
				btnmodificar.Enabled = false;
				btneliminar.Enabled = false;
			}
		}
	}
}
