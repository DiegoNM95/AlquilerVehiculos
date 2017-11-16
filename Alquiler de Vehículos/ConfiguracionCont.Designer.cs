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
			this.SuspendLayout();
			// 
			// txtprueba
			// 
			this.txtprueba.Location = new System.Drawing.Point(306, 79);
			this.txtprueba.Name = "txtprueba";
			this.txtprueba.Size = new System.Drawing.Size(270, 22);
			this.txtprueba.TabIndex = 0;
			this.txtprueba.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprueba_KeyPress);
			// 
			// ConfiguracionCont
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(908, 539);
			this.Controls.Add(this.txtprueba);
			this.Name = "ConfiguracionCont";
			this.Text = "AV | Configuración";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtprueba;
	}
}