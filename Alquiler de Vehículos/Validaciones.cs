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
		public int cont { get; set; }

		//VALIDACIONES DE NUMEROS DE DOCUMENTOS

		//Contenido de documentos.
		public static Boolean VDocument(int caso, TextBox text, Char k)
		{
			if (caso == 1)//DUI
			{
				if (Char.IsNumber(k) || Char.IsControl(k))
				{
					if (char.IsNumber(k))
					{
						for (int i = 0; i < text.TextLength; i++)
						{
							if (i == 7 && !text.Text.Contains("-"))
							{
								text.Text = text.Text + "-";
								text.Select(text.MaxLength, text.MaxLength);
							}
						}
					}
					return true;
				}
				else
				{
					MessageBox.Show(text, "Solo puede ingresar numeros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					text.Focus();
				}
			}
			if (caso == 2)//NIT
			{
				if (Char.IsNumber(k) || Char.IsControl(k))
				{
					if (char.IsNumber(k))
					{
						for (int i = 0; i <= text.TextLength; i++)
						{
							if (i == 4 && !text.Text.Contains("-"))
							{
								text.Text = text.Text + "-";
								text.Select(text.MaxLength, text.MaxLength);
							}
							if (i == 11)
							{
								Char[] cadena = text.Text.ToCharArray();
								int cont = 0;
								for (int a = 0; a <= text.TextLength - 1; a++)
								{
									if (cadena[a] == Char.Parse("-"))
									{
										cont++;
									}
								}
								if (cont < 2)
								{
									text.Text = text.Text + "-";
									text.Select(text.MaxLength, text.MaxLength);
								}
							}
							if (i == 15)
							{
								Char[] cadena = text.Text.ToCharArray();
								int cont = 0;
								for (int a = 0; a <= text.TextLength - 1; a++)
								{
									if (cadena[a] == Char.Parse("-"))
									{
										cont++;
									}
								}
								if (cont < 3)
								{
									text.Text = text.Text + "-";
									text.Select(text.MaxLength, text.MaxLength);
								}
							}
						}
					}
					return true;
				}
				else
				{
					MessageBox.Show(text, "Solo puede ingresar numeros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					text.Focus();
				}
			}
			if (caso == 3)//Número de placa de vehículo
			{
				if (Char.IsNumber(k) || Char.IsControl(k))
				{
					if (Char.IsNumber(k))
					{
						for (int i = 0; i <= text.TextLength; i++)
						{
							if (text.TextLength == 0)
							{
								text.Text = "P";
								text.Select(text.MaxLength, text.MaxLength);
							}
							if (text.TextLength == 4)
							{
								text.Text = text.Text + "-";
								text.Select(text.MaxLength, text.MaxLength);
							}
						}
					}
					return true;
				}
				else
				{
					MessageBox.Show(text, "Solo puede ingresar numeros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					text.Focus();
				}
			}
			return false;
		}
		//Minimo de caracteres de documentos
		public static Boolean MinCaracter(TextBox text, Int32 min)
		{
			if (text.TextLength < min)
			{
				return false;
			}
			return true;
		}

		//METODOS DE CONTENIDO VACÍO
		public static Boolean TexBoxEmpty(TextBox textBox, PictureBox marco)
		{
			if (textBox.Text != "")
			{
				marco.Visible = false;
				return true;
			}
			marco.Visible = true;
			return false;
		}
		public static Boolean ComboBoxEmpty(ComboBox comboBox, PictureBox marco)
		{
			if (comboBox.SelectedIndex != -1)
			{
				marco.Visible = false;
				return true;
			}
			marco.Visible = true;
			return false;
		}

		//VALIDACIONES DATETIMEPICKER
		public static Boolean VDate(DateTimePicker dateTimePicker, PictureBox marco, int limiteaños)
		{
			DateTime ahora = DateTime.Today;
			if ((ahora.Year - dateTimePicker.Value.Year) < limiteaños)
			{
				marco.Visible = true;
				MessageBox.Show("El cliente no puede tener una edad menor de 18 años.");
				dateTimePicker.Focus();
				return false;
			}
			marco.Visible = false;
			return true;
		}
		//Validaciones de correo
		public static Boolean VCorreo(TextBox txt)
		{
			if (txt.Text == "")
			{
				return true;
			}
			else
			{
				if (!txt.Text.Contains("@") && !txt.Text.Contains("."))
				{
					return false;
				}
				else
				{
					if ((txt.Text.IndexOf("@") < txt.Text.LastIndexOf(".")))
					{
						return true;
					}
					else
					{
						return false;
					}
				}
			}
		}
	}
}
