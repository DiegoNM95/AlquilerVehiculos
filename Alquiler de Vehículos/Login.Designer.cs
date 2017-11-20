namespace Alquiler_de_Vehículos
{
	partial class frmlogin
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
			this.lblusuario = new System.Windows.Forms.Label();
			this.txtusuario = new System.Windows.Forms.TextBox();
			this.txtcontra = new System.Windows.Forms.TextBox();
			this.lblcontra = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnEntrar = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblusuario
			// 
			resources.ApplyResources(this.lblusuario, "lblusuario");
			this.lblusuario.Name = "lblusuario";
			// 
			// txtusuario
			// 
			resources.ApplyResources(this.txtusuario, "txtusuario");
			this.txtusuario.Name = "txtusuario";
			// 
			// txtcontra
			// 
			resources.ApplyResources(this.txtcontra, "txtcontra");
			this.txtcontra.Name = "txtcontra";
			// 
			// lblcontra
			// 
			resources.ApplyResources(this.lblcontra, "lblcontra");
			this.lblcontra.Name = "lblcontra";
			// 
			// panel1
			// 
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.lblusuario);
			this.panel1.Controls.Add(this.txtusuario);
			this.panel1.Controls.Add(this.lblcontra);
			this.panel1.Controls.Add(this.txtcontra);
			this.panel1.Name = "panel1";
			// 
			// pictureBox1
			// 
			resources.ApplyResources(this.pictureBox1, "pictureBox1");
			this.pictureBox1.Image = global::Alquiler_de_Vehículos.Properties.Resources.locked;
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.TabStop = false;
			// 
			// btnEntrar
			// 
			resources.ApplyResources(this.btnEntrar, "btnEntrar");
			this.btnEntrar.Name = "btnEntrar";
			this.btnEntrar.UseVisualStyleBackColor = true;
			this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click_1);
			// 
			// button2
			// 
			resources.ApplyResources(this.button2, "button2");
			this.button2.Name = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// frmlogin
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnEntrar);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmlogin";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblusuario;
		private System.Windows.Forms.TextBox txtusuario;
		private System.Windows.Forms.TextBox txtcontra;
		private System.Windows.Forms.Label lblcontra;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnEntrar;
		private System.Windows.Forms.Button button2;
	}
}

