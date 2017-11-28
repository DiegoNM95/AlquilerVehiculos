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
        }

		private void btbcrear_Click(object sender, EventArgs e)
		{
			usuario.NombreUsuario = txtusuario.Text;
			usuario.Contraseña = txtcontraseña.Text;
			usuario.Tipo = cmbusuario.Text;
			usuario.AgregarUsuario();
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
	}
}
