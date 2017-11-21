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
		public UsuariosCont()
		{
			InitializeComponent();
		}

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void UsuariosCont_Load(object sender, EventArgs e)
        {
            cmbusuario.Items.Add("Administrador");
            cmbusuario.Items.Add("Vendedor");
        }
    }
}
