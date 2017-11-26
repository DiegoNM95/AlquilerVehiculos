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
		//public Int32 cont { get; set; }

		private void btnagregar_Click(object sender, EventArgs e)
		{
			if ((Validaciones.TexBoxEmpty(txtPnombre, pbNombre1) && Validaciones.TexBoxEmpty(txtPapellido, pbApellido1) && Validaciones.TexBoxEmpty(txtSapellido, pbApellido2) && Validaciones.TexBoxEmpty(txtDui, pbDui) && Validaciones.TexBoxEmpty(txtNit, pbNit) && Validaciones.ComboBoxEmpty(cbtipolicencia, pbLicencia) && Validaciones.TexBoxEmpty(txtdireccion, pbDireccion) && Validaciones.TexBoxEmpty(txttelefono, pbTelefono) && Validaciones.VDate(dtpNacimiento, pbNacimiento, 18)) == false)
			{
				MessageBox.Show("Debe completar la información para agregar el cliente");
			}
			else
			{
				//Asignacion de valores
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
				//Agrega el cliente
				clientes.AgregarCliente();
				//Recarga el listado
				clientes.FillTable(dtgListadoClientes);
				//Limpiar Campos
				txtcodigo.Text = "";
				txtPnombre.Text = "";
				txtSnombre.Text = "";
				txttercernombre.Text = "";
				txtPapellido.Text = "";
				txtSapellido.Text = "";
				txtDui.Text = "";
				txtNit.Text = "";
				cbtipolicencia.SelectedIndex = -1;
				dtpNacimiento.Text = DateTime.Today.ToString();
				txtdireccion.Text = "";
				txttelefono.Text = "";
				txtcorreo.Text = "";
				btnmodificar.Enabled = false;
				btnborrar.Enabled = false;
			}
		}

		private void stsRegresar_Click(object sender, EventArgs e)
		{
			frmprincipal frmprincipal = new frmprincipal();
			this.Hide();
			frmprincipal.ShowDialog();
			this.Close();
			
		}

		private void btnmodificar_Click(object sender, EventArgs e)
		{
			if ((Validaciones.TexBoxEmpty(txtPnombre, pbNombre1) && Validaciones.TexBoxEmpty(txtPapellido, pbApellido1) && Validaciones.TexBoxEmpty(txtSapellido, pbApellido2) && Validaciones.TexBoxEmpty(txtDui, pbDui) && Validaciones.TexBoxEmpty(txtNit, pbNit) && Validaciones.ComboBoxEmpty(cbtipolicencia, pbLicencia) && Validaciones.TexBoxEmpty(txtdireccion, pbDireccion) && Validaciones.TexBoxEmpty(txttelefono, pbTelefono) && Validaciones.VDate(dtpNacimiento, pbNacimiento, 18)) == false)
			{
				MessageBox.Show("Debe completar la información para modificar el cliente");
			}
			else
			{
				clientes.Codigo = Convert.ToInt32(txtcodigo.Text);
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

				clientes.ActualizarCliente();
				clientes.FillTable(dtgListadoClientes);
			}
		}

		private void btnbuscar_Click(object sender, EventArgs e)
		{
			if (clientes.AddTexBoxClientes(txtDui.Text))
			{
				txtcodigo.Text = clientes.Codigo.ToString();
				txtNit.Text = clientes.NIT;
				txtPnombre.Text = clientes.Nombre1;
				txtSnombre.Text = clientes.Nombre2;
				txttercernombre.Text = clientes.Nombre3;
				txtPapellido.Text = clientes.Apellido1;
				txtSapellido.Text = clientes.Apellido2;
				dtpNacimiento.Text = clientes.Nacimiento;
				txtdireccion.Text = clientes.Direccion;
				txtcorreo.Text = clientes.Email;
				cbtipolicencia.SelectedItem = clientes.TipoLicencia;
				txttelefono.Text = clientes.Tel.ToString();
				btnmodificar.Enabled = true;
				btnborrar.Enabled = true;
			}	
		}

		private void txtPnombre_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Validaciones.TexBoxContent(4, txtPnombre, e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtSnombre_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Validaciones.TexBoxContent(4, txtSnombre, e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txttercernombre_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Validaciones.TexBoxContent(4, txttercernombre, e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtPapellido_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Validaciones.TexBoxContent(4, txtPapellido, e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtSapellido_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Validaciones.TexBoxContent(4, txtSapellido, e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Validaciones.TexBoxContent(1, txttelefono, e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtPnombre_Leave(object sender, EventArgs e)
		{
			Validaciones.TexBoxEmpty(txtPnombre, pbNombre1);
		}

		private void txtPapellido_Leave(object sender, EventArgs e)
		{
			Validaciones.TexBoxEmpty(txtPapellido, pbApellido1);
		}

		private void txtSapellido_Leave(object sender, EventArgs e)
		{
			Validaciones.TexBoxEmpty(txtSapellido, pbApellido2);
		}

		private void txtDui_Leave(object sender, EventArgs e)
		{
			if (Validaciones.TexBoxEmpty(txtDui, pbDui))
			{
				if (!Validaciones.MinCaracter(txtDui, 10))
				{
					MessageBox.Show("No se reconoce el número de DUI");
					txtDui.Focus();
				}
			}
		}

		private void cbtipolicencia_Leave(object sender, EventArgs e)
		{
			Validaciones.ComboBoxEmpty(cbtipolicencia, pbLicencia);
		}

		private void txtdireccion_Leave(object sender, EventArgs e)
		{
			Validaciones.TexBoxEmpty(txtdireccion, pbDireccion);
		}

		private void txttelefono_Leave(object sender, EventArgs e)
		{
			Validaciones.TexBoxEmpty(txttelefono, pbTelefono);
		}

		private void txtNit_Leave(object sender, EventArgs e)
		{
			if (Validaciones.TexBoxEmpty(txtNit, pbNit))
			{
				if (!Validaciones.MinCaracter(txtNit, 17))
				{
					MessageBox.Show("No se reconoce el número de NIT");
					txtNit.Focus();
				}
			}
		}

		private void dtpNacimiento_Leave(object sender, EventArgs e)
		{
			Validaciones.VDate(dtpNacimiento, pbNacimiento, 18);
		}

		private void txtPnombre_TextChanged(object sender, EventArgs e)
		{
			Validaciones.TexBoxEmpty(txtPnombre, pbNombre1);
		}

		private void txtPapellido_TextChanged(object sender, EventArgs e)
		{
			Validaciones.TexBoxEmpty(txtPapellido, pbApellido1);
		}

		private void txtSapellido_TextChanged(object sender, EventArgs e)
		{
			Validaciones.TexBoxEmpty(txtSapellido, pbApellido2);
		}

		private void txtDui_TextChanged(object sender, EventArgs e)
		{
			Validaciones.TexBoxEmpty(txtDui, pbDui);
		}

		private void txtNit_TextChanged(object sender, EventArgs e)
		{
			Validaciones.TexBoxEmpty(txtNit, pbNit);
		}

		private void cbtipolicencia_SelectedIndexChanged(object sender, EventArgs e)
		{
			Validaciones.ComboBoxEmpty(cbtipolicencia, pbLicencia);
		}

		private void txtdireccion_TextChanged(object sender, EventArgs e)
		{
			Validaciones.TexBoxEmpty(txtdireccion, pbLicencia);
		}

		private void txttelefono_TextChanged(object sender, EventArgs e)
		{
			Validaciones.TexBoxEmpty(txttelefono, pbTelefono);
		}

		private void txtDui_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Validaciones.VDocument(1,txtDui, e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Validaciones.VDocument(2, txtNit, e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void ClientesCont_Load(object sender, EventArgs e)
		{
			btnmodificar.Enabled = false;
			btnborrar.Enabled = false;
			clientes.FillTable(dtgListadoClientes);
		}

		private void stsLimpiarcampos_Click(object sender, EventArgs e)
		{
			txtcodigo.Text = "";
			txtPnombre.Text = "";
			txtSnombre.Text = "";
			txttercernombre.Text = "";
			txtPapellido.Text = "";
			txtSapellido.Text = "";
			txtDui.Text = "";
			txtNit.Text = "";
			cbtipolicencia.SelectedIndex = -1;
			dtpNacimiento.Text = DateTime.Today.ToString();
			txtdireccion.Text = "";
			txttelefono.Text = "";
			txtcorreo.Text = "";
			btnmodificar.Enabled = false;
			btnborrar.Enabled = false;
		}

		private void txtbuscarcodigo_TextChanged(object sender, EventArgs e)
		{
			clientes.Filtrarlistado(dtgListadoClientes, txtbuscarcodigo.Text);
		}

		private void btnmodificar2_Click(object sender, EventArgs e)
		{
			//MessageBox.Show(dtgListadoClientes.CurrentRow.Cells[1].Value.ToString());
			if (clientes.AddTexBoxClientes(dtgListadoClientes.CurrentRow.Cells[1].Value.ToString()))
			{
				txtcodigo.Text = clientes.Codigo.ToString();
				txtDui.Text = clientes.DUI;
				txtNit.Text = clientes.NIT;
				txtPnombre.Text = clientes.Nombre1;
				txtSnombre.Text = clientes.Nombre2;
				txttercernombre.Text = clientes.Nombre3;
				txtPapellido.Text = clientes.Apellido1;
				txtSapellido.Text = clientes.Apellido2;
				dtpNacimiento.Text = clientes.Nacimiento;
				txtdireccion.Text = clientes.Direccion;
				txtcorreo.Text = clientes.Email;
				cbtipolicencia.SelectedItem = clientes.TipoLicencia;
				txttelefono.Text = clientes.Tel.ToString();
				btnmodificar.Enabled = true;
				btnborrar.Enabled = true;
				tbcClientes.SelectedTab = tbpAdminClientes;
				tbpAdminClientes.Show();
				tbpAdminClientes.Focus();
			}
		}

		private void btnborrar_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Seguro que quiere borrar al cliente: " + txtPnombre.Text + " " + txtPapellido.Text, "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				//Asignamos el valor de Dui y de Codigo
				clientes.Codigo = Convert.ToInt32(txtcodigo.Text);
				clientes.DUI = txtDui.Text;
				//Eliminar Cliente
				clientes.EliminarCliente();
				//Actulizar Listado
				clientes.FillTable(dtgListadoClientes);
				//Limpiar Campos
				txtcodigo.Text = "";
				txtPnombre.Text = "";
				txtSnombre.Text = "";
				txttercernombre.Text = "";
				txtPapellido.Text = "";
				txtSapellido.Text = "";
				txtDui.Text = "";
				txtNit.Text = "";
				cbtipolicencia.SelectedIndex = -1;
				dtpNacimiento.Text = DateTime.Today.ToString();
				txtdireccion.Text = "";
				txttelefono.Text = "";
				txtcorreo.Text = "";
				btnmodificar.Enabled = false;
				btnborrar.Enabled = false;
			}
		}
	}
}
