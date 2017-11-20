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
	public partial class frmlogin : Form
	{
		Usuario usuario = new Usuario();
		public frmlogin()
		{
			InitializeComponent();
		}

		private void btnEntrar_Click_1(object sender, EventArgs e)
		{
			usuario.NombreUsuario = txtusuario.Text;
			usuario.Contraseña = txtcontra.Text;
			frmprincipal destino = new frmprincipal();
			usuario.Loguear(this, destino);
		}
	}
}
