namespace Alquiler_de_Vehículos
{
	partial class frmprincipal
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
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.lblusuario = new System.Windows.Forms.Label();
			this.lblnameuser = new System.Windows.Forms.Label();
			this.btnconfiguracion = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(444, 196);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(160, 71);
			this.button3.TabIndex = 2;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(610, 196);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(160, 71);
			this.button4.TabIndex = 3;
			this.button4.Text = "button4";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(112, 297);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(160, 71);
			this.button5.TabIndex = 4;
			this.button5.Text = "button5";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(278, 297);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(160, 71);
			this.button6.TabIndex = 5;
			this.button6.Text = "button6";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(444, 297);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(160, 71);
			this.button7.TabIndex = 6;
			this.button7.Text = "button7";
			this.button7.UseVisualStyleBackColor = true;
			// 
			// lblusuario
			// 
			this.lblusuario.AutoSize = true;
			this.lblusuario.Location = new System.Drawing.Point(696, 22);
			this.lblusuario.Name = "lblusuario";
			this.lblusuario.Size = new System.Drawing.Size(61, 17);
			this.lblusuario.TabIndex = 8;
			this.lblusuario.Text = "Usuario:";
			// 
			// lblnameuser
			// 
			this.lblnameuser.AutoSize = true;
			this.lblnameuser.Location = new System.Drawing.Point(763, 22);
			this.lblnameuser.Name = "lblnameuser";
			this.lblnameuser.Size = new System.Drawing.Size(118, 17);
			this.lblnameuser.TabIndex = 9;
			this.lblnameuser.Text = "Nombres Usuario";
			// 
			// btnconfiguracion
			// 
			this.btnconfiguracion.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnconfiguracion.BackgroundImage = global::Alquiler_de_Vehículos.Properties.Resources.ajustes;
			this.btnconfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnconfiguracion.Location = new System.Drawing.Point(610, 297);
			this.btnconfiguracion.Name = "btnconfiguracion";
			this.btnconfiguracion.Size = new System.Drawing.Size(160, 115);
			this.btnconfiguracion.TabIndex = 7;
			this.btnconfiguracion.UseVisualStyleBackColor = false;
			this.btnconfiguracion.Click += new System.EventHandler(this.btnconfiguracion_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.button2.BackgroundImage = global::Alquiler_de_Vehículos.Properties.Resources.precio;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button2.Location = new System.Drawing.Point(278, 152);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(160, 115);
			this.button2.TabIndex = 1;
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.button1.BackgroundImage = global::Alquiler_de_Vehículos.Properties.Resources.cliente;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.Location = new System.Drawing.Point(112, 152);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(160, 115);
			this.button1.TabIndex = 0;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// frmprincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(908, 539);
			this.Controls.Add(this.lblnameuser);
			this.Controls.Add(this.lblusuario);
			this.Controls.Add(this.btnconfiguracion);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "frmprincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AV";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button btnconfiguracion;
		private System.Windows.Forms.Label lblusuario;
		private System.Windows.Forms.Label lblnameuser;
	}
}