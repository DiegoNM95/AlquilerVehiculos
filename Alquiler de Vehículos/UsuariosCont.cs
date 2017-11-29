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
	public partial class UsuariosCont : Form
	{
		Usuario usuario = new Usuario();
		public UsuariosCont()
		{
			InitializeComponent();
		}

        private void UsuariosCont_Load(object sender, EventArgs e)
        {
            cmbusuario.Items.Add("Administrador");
            cmbusuario.Items.Add("Vendedor");
			usuario.Listado(dgvListado);
			btnModificar.Enabled = false;
			btbeliminar.Enabled = false;
        }

		private void btbcrear_Click(object sender, EventArgs e)
		{
			if (txtusuario.Text != "" && txtcontraseña.Text != "" && cmbusuario.SelectedIndex != -1)
			{
				usuario.NombreUsuario = txtusuario.Text;
				usuario.Contraseña = txtcontraseña.Text;
				usuario.Tipo = cmbusuario.Text;
				usuario.AgregarUsuario();
				usuario.Listado(dgvListado);
			}
			else
			{
				MessageBox.Show("Faltan datos por ingresar.");
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			usuario.FiltrarListado(dgvListado, textBox1.Text);
		}

		private void tsmRegresar_Click(object sender, EventArgs e)
		{
			frmprincipal frmprincipal = new frmprincipal();
			this.Hide();
			frmprincipal.ShowDialog();
			this.Close();
		}

		private void btnbuscar_Click(object sender, EventArgs e)
		{
			if (usuario.AddTexBoxUsuarios(txtusuario.Text))
			{
				txtcodigo.Text = usuario.Codigo.ToString();
				txtcontraseña.Text = usuario.Contraseña.ToString();
				cmbusuario.Text = usuario.Tipo.ToString();
				btnModificar.Enabled = true;
				btbeliminar.Enabled = true;
			}
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			if ((txtusuario.Text != "" && txtcontraseña.Text != "") && cmbusuario.SelectedIndex != -1)
			{
				usuario.Codigo = Convert.ToInt32(txtcodigo.Text);
				usuario.NombreUsuario = txtusuario.Text;
				usuario.Contraseña = txtcontraseña.Text;
				usuario.Tipo = cmbusuario.Text;
				usuario.ActualizarUsuario();
				usuario.Listado(dgvListado);
			}
			else {
				MessageBox.Show("Falta información por completar");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (usuario.AddTexBoxUsuarios(dgvListado.CurrentRow.Cells[1].Value.ToString()))
			{
				txtcodigo.Text = usuario.Codigo.ToString();
				txtusuario.Text = usuario.NombreUsuario.ToString();
				txtcontraseña.Text = usuario.Contraseña.ToString();
				cmbusuario.Text = usuario.Tipo.ToString();
				btnModificar.Enabled = true;
				btbeliminar.Enabled = true;
				tdadministracion.SelectedTab = tabPage1;
				tabPage1.Show();
				tabPage1.Focus();

			}
		}

		private void tsmLimpiar_Click(object sender, EventArgs e)
		{
			txtcodigo.Text = "";
			txtusuario.Text = "";
			txtcontraseña.Text = "";
			cmbusuario.SelectedIndex = -1;
			btnModificar.Enabled = false;
			btbeliminar.Enabled = false;
			
		}

		private void btbeliminar_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Seguro que quiere borrar el usuario placa: " + txtusuario.Text, "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				//Asignamos el valor de Dui y de Codigo
				usuario.Codigo = Convert.ToInt32(txtcodigo.Text);
				usuario.NombreUsuario = txtusuario.Text;
				//Eliminar Cliente
				usuario.Eliminarusuario();
				//Actulizar Listado
				usuario.Listado(dgvListado);
				//Limpiar Campos
				txtcodigo.Text = "";
				txtusuario.Text = "";
				txtcontraseña.Text = "";
				cmbusuario.SelectedIndex = -1;
				btnModificar.Enabled = false;
				btbeliminar.Enabled = false;
			}
		}
	}
}
