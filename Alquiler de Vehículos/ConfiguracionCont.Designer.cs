namespace Alquiler_de_Vehículos
{
	partial class ConfiguracionCont
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtprueba = new System.Windows.Forms.TextBox();
			this.txtprueba2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtprueba
			// 
			this.txtprueba.Location = new System.Drawing.Point(319, 179);
			this.txtprueba.Name = "txtprueba";
			this.txtprueba.Size = new System.Drawing.Size(270, 22);
			this.txtprueba.TabIndex = 1;
			this.txtprueba.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprueba_KeyPress);
			this.txtprueba.Leave += new System.EventHandler(this.txtprueba_Leave);
			// 
			// txtprueba2
			// 
			this.txtprueba2.Location = new System.Drawing.Point(319, 258);
			this.txtprueba2.Name = "txtprueba2";
			this.txtprueba2.Size = new System.Drawing.Size(270, 22);
			this.txtprueba2.TabIndex = 2;
			this.txtprueba2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprueba2_KeyPress);
			this.txtprueba2.Leave += new System.EventHandler(this.txtprueba2_Leave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(804, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "La validación de contenido de texbox se invoca asi: Validaciones.TexBoxContent(nú" +
    "merodecaso, nombredetexbox, e.KeyChar)";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(727, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Todos los casos de este método asumen que los texbox están validados, hasta que e" +
    "sa validación sea incorrecta.\r\n";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(373, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "El número de caso se encuentra en la clase: Validaciones";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 145);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(824, 17);
			this.label4.TabIndex = 5;
			this.label4.Text = "No necesitan instanciar la clase Validaciones, porque los métodos son estáticos. " +
    "Vean el ejemplo en el código de este formulario.";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(22, 116);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(602, 17);
			this.label5.TabIndex = 6;
			this.label5.Text = "La validación de texbox vacío, se desata cuando el texbox pierde el foco con el e" +
    "vento: Leave.\r\n";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(22, 216);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(477, 17);
			this.label6.TabIndex = 7;
			this.label6.Text = "El método que verifica que un texbox no esté vacío se llama. TexBoxEmpty";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(25, 465);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Probar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ConfiguracionCont
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(908, 539);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtprueba2);
			this.Controls.Add(this.txtprueba);
			this.Name = "ConfiguracionCont";
			this.Text = "AV | Configuración";
			this.Load += new System.EventHandler(this.ConfiguracionCont_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtprueba;
		private System.Windows.Forms.TextBox txtprueba2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
	}
}