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
			this.lblusuario = new System.Windows.Forms.Label();
			this.txtusuario = new System.Windows.Forms.TextBox();
			this.txtcontra = new System.Windows.Forms.TextBox();
			this.lblcontra = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblusuario
			// 
			this.lblusuario.AutoSize = true;
			this.lblusuario.Location = new System.Drawing.Point(221, 65);
			this.lblusuario.Name = "lblusuario";
			this.lblusuario.Size = new System.Drawing.Size(61, 17);
			this.lblusuario.TabIndex = 0;
			this.lblusuario.Text = "Usuario:";
			// 
			// txtusuario
			// 
			this.txtusuario.Location = new System.Drawing.Point(288, 65);
			this.txtusuario.Name = "txtusuario";
			this.txtusuario.Size = new System.Drawing.Size(279, 22);
			this.txtusuario.TabIndex = 1;
			// 
			// txtcontra
			// 
			this.txtcontra.Location = new System.Drawing.Point(288, 133);
			this.txtcontra.Name = "txtcontra";
			this.txtcontra.PasswordChar = '*';
			this.txtcontra.Size = new System.Drawing.Size(279, 22);
			this.txtcontra.TabIndex = 3;
			// 
			// lblcontra
			// 
			this.lblcontra.AutoSize = true;
			this.lblcontra.Location = new System.Drawing.Point(197, 133);
			this.lblcontra.Name = "lblcontra";
			this.lblcontra.Size = new System.Drawing.Size(85, 17);
			this.lblcontra.TabIndex = 2;
			this.lblcontra.Text = "Contraseña:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Alquiler_de_Vehículos.Properties.Resources.locked;
			this.pictureBox1.Location = new System.Drawing.Point(16, 40);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(149, 144);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(28, 247);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(283, 46);
			this.button1.TabIndex = 5;
			this.button1.Text = "Entrar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(336, 247);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(283, 46);
			this.button2.TabIndex = 6;
			this.button2.Text = "Crear Usuario";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.lblusuario);
			this.panel1.Controls.Add(this.txtusuario);
			this.panel1.Controls.Add(this.lblcontra);
			this.panel1.Controls.Add(this.txtcontra);
			this.panel1.Location = new System.Drawing.Point(28, 27);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(591, 214);
			this.panel1.TabIndex = 0;
			// 
			// frmlogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(652, 324);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "frmlogin";
			this.Text = "AV | Iniciar Sesión";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblusuario;
		private System.Windows.Forms.TextBox txtusuario;
		private System.Windows.Forms.TextBox txtcontra;
		private System.Windows.Forms.Label lblcontra;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel1;
	}
}

