using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alquiler_de_Vehículos
{
	public class Validaciones
	{
		//public TextBox GetTextBox { get; set; }

		//Metodo de validaciones de contenido de texboxs
		public static Boolean TexBoxContent(int caso, TextBox txt, char k)
		{
			if (caso == 1)//VALDIDACION ENTEROS POSITIVOS
			{
				if (Char.IsNumber(k) == false && char.IsControl(k) == false)
				{
					MessageBox.Show(txt, "Solo puede ingresar valores enteros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					txt.Focus();
					return false;
				}
				else
				{
					return true;
				}
			}
			if (caso == 2)//VALIDACION DECIMALES POSITVOS
			{
				if (Char.IsNumber(k) == false && Char.IsControl(k) == false && k != Char.Parse("."))
				{
					MessageBox.Show(txt, "Solo puede ingresar valores decimales.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					txt.Focus();
					return false;
				}
				else
				{
					if (txt.Text.Contains(".") && Convert.ToString(k) == ".")
					{
						MessageBox.Show(txt, "El número que está ingresando ya contiene punto decimal", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return false;
					}
					return true;
				}
			}
			if (caso == 3) //VALIDACION DE NUMEROS REALES
			{
				if (Char.IsNumber(k) == false && Char.IsControl(k) == false && k != Char.Parse(".") && k != Char.Parse("-"))
				{
					MessageBox.Show(txt, "No puede ingresar letras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					txt.Focus();
					return false;
				}
				else
				{
					if (txt.Text.Contains(".") && Convert.ToString(k) == ".")
					{
						MessageBox.Show(txt, "El número que está ingresando ya contiene punto decimal", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return false;
					}
					return true;
				}
			}
			if (caso == 4)//VALIDACION DE LETRAS
			{
				if (!Char.IsLetter(k) && !Char.IsControl(k))
				{
					MessageBox.Show(txt, "Solo puede ingresar letras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					txt.Focus();
					return false;
				}
			}
			return true;
		}

		//Método de texbox vacíos
		public static Boolean TexBoxEmpty(TextBox textBox)
		{
			if (textBox.Text != "")
			{
				return true;
			}
			textBox.Focus();
			return false;
		}
	}
}
