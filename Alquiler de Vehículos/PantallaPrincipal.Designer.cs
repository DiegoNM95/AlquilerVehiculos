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
			this.lblnombreusuario = new System.Windows.Forms.Label();
			this.lblnameuser = new System.Windows.Forms.Label();
			this.btnconfiguracion = new System.Windows.Forms.Button();
			this.btnrenta = new System.Windows.Forms.Button();
			this.btnusuarios = new System.Windows.Forms.Button();
			this.btnvehiculos = new System.Windows.Forms.Button();
			this.btnprecios = new System.Windows.Forms.Button();
			this.btnclientes = new System.Windows.Forms.Button();
			this.lblclientes = new System.Windows.Forms.Label();
			this.lblvehiculos = new System.Windows.Forms.Label();
			this.lblprecios = new System.Windows.Forms.Label();
			this.lblrenta = new System.Windows.Forms.Label();
			this.lblusuarios = new System.Windows.Forms.Label();
			this.lblconfiguracion = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblnombreusuario
			// 
			this.lblnombreusuario.AutoSize = true;
			this.lblnombreusuario.Location = new System.Drawing.Point(696, 22);
			this.lblnombreusuario.Name = "lblnombreusuario";
			this.lblnombreusuario.Size = new System.Drawing.Size(61, 17);
			this.lblnombreusuario.TabIndex = 8;
			this.lblnombreusuario.Text = "Usuario:";
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
			this.btnconfiguracion.Location = new System.Drawing.Point(637, 329);
			this.btnconfiguracion.Name = "btnconfiguracion";
			this.btnconfiguracion.Size = new System.Drawing.Size(244, 142);
			this.btnconfiguracion.TabIndex = 7;
			this.btnconfiguracion.UseVisualStyleBackColor = false;
			this.btnconfiguracion.Click += new System.EventHandler(this.btnconfiguracion_Click);
			// 
			// btnrenta
			// 
			this.btnrenta.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnrenta.BackgroundImage = global::Alquiler_de_Vehículos.Properties.Resources.renta;
			this.btnrenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnrenta.Location = new System.Drawing.Point(28, 329);
			this.btnrenta.Name = "btnrenta";
			this.btnrenta.Size = new System.Drawing.Size(244, 142);
			this.btnrenta.TabIndex = 6;
			this.btnrenta.UseVisualStyleBackColor = false;
			// 
			// btnusuarios
			// 
			this.btnusuarios.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnusuarios.BackgroundImage = global::Alquiler_de_Vehículos.Properties.Resources.usuarios;
			this.btnusuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnusuarios.Location = new System.Drawing.Point(330, 329);
			this.btnusuarios.Name = "btnusuarios";
			this.btnusuarios.Size = new System.Drawing.Size(244, 142);
			this.btnusuarios.TabIndex = 3;
			this.btnusuarios.UseVisualStyleBackColor = false;
			// 
			// btnvehiculos
			// 
			this.btnvehiculos.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnvehiculos.BackgroundImage = global::Alquiler_de_Vehículos.Properties.Resources.vehiculos;
			this.btnvehiculos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnvehiculos.Location = new System.Drawing.Point(330, 106);
			this.btnvehiculos.Name = "btnvehiculos";
			this.btnvehiculos.Size = new System.Drawing.Size(244, 142);
			this.btnvehiculos.TabIndex = 2;
			this.btnvehiculos.UseVisualStyleBackColor = false;
			// 
			// btnprecios
			// 
			this.btnprecios.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnprecios.BackgroundImage = global::Alquiler_de_Vehículos.Properties.Resources.precio;
			this.btnprecios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnprecios.Location = new System.Drawing.Point(637, 106);
			this.btnprecios.Name = "btnprecios";
			this.btnprecios.Size = new System.Drawing.Size(244, 142);
			this.btnprecios.TabIndex = 1;
			this.btnprecios.UseVisualStyleBackColor = false;
			// 
			// btnclientes
			// 
			this.btnclientes.BackColor = System.Drawing.SystemColors.ControlDark;
			this.btnclientes.BackgroundImage = global::Alquiler_de_Vehículos.Properties.Resources.cliente;
			this.btnclientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnclientes.Location = new System.Drawing.Point(28, 106);
			this.btnclientes.Name = "btnclientes";
			this.btnclientes.Size = new System.Drawing.Size(244, 142);
			this.btnclientes.TabIndex = 0;
			this.btnclientes.UseVisualStyleBackColor = false;
			// 
			// lblclientes
			// 
			this.lblclientes.BackColor = System.Drawing.SystemColors.ControlDark;
			this.lblclientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblclientes.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblclientes.ForeColor = System.Drawing.Color.White;
			this.lblclientes.Location = new System.Drawing.Point(28, 251);
			this.lblclientes.Name = "lblclientes";
			this.lblclientes.Size = new System.Drawing.Size(244, 37);
			this.lblclientes.TabIndex = 10;
			this.lblclientes.Text = "Clientes";
			this.lblclientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblvehiculos
			// 
			this.lblvehiculos.BackColor = System.Drawing.SystemColors.ControlDark;
			this.lblvehiculos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblvehiculos.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblvehiculos.ForeColor = System.Drawing.Color.White;
			this.lblvehiculos.Location = new System.Drawing.Point(332, 251);
			this.lblvehiculos.Name = "lblvehiculos";
			this.lblvehiculos.Size = new System.Drawing.Size(244, 37);
			this.lblvehiculos.TabIndex = 11;
			this.lblvehiculos.Text = "Vehículos";
			this.lblvehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblprecios
			// 
			this.lblprecios.BackColor = System.Drawing.SystemColors.ControlDark;
			this.lblprecios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblprecios.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblprecios.ForeColor = System.Drawing.Color.White;
			this.lblprecios.Location = new System.Drawing.Point(637, 251);
			this.lblprecios.Name = "lblprecios";
			this.lblprecios.Size = new System.Drawing.Size(244, 37);
			this.lblprecios.TabIndex = 12;
			this.lblprecios.Text = "Precios";
			this.lblprecios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblrenta
			// 
			this.lblrenta.BackColor = System.Drawing.SystemColors.ControlDark;
			this.lblrenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblrenta.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblrenta.ForeColor = System.Drawing.Color.White;
			this.lblrenta.Location = new System.Drawing.Point(28, 474);
			this.lblrenta.Name = "lblrenta";
			this.lblrenta.Size = new System.Drawing.Size(244, 37);
			this.lblrenta.TabIndex = 13;
			this.lblrenta.Text = "Renta";
			this.lblrenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblusuarios
			// 
			this.lblusuarios.BackColor = System.Drawing.SystemColors.ControlDark;
			this.lblusuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblusuarios.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblusuarios.ForeColor = System.Drawing.Color.White;
			this.lblusuarios.Location = new System.Drawing.Point(332, 474);
			this.lblusuarios.Name = "lblusuarios";
			this.lblusuarios.Size = new System.Drawing.Size(244, 37);
			this.lblusuarios.TabIndex = 14;
			this.lblusuarios.Text = "Usuarios";
			this.lblusuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblconfiguracion
			// 
			this.lblconfiguracion.BackColor = System.Drawing.SystemColors.ControlDark;
			this.lblconfiguracion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblconfiguracion.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblconfiguracion.ForeColor = System.Drawing.Color.White;
			this.lblconfiguracion.Location = new System.Drawing.Point(637, 474);
			this.lblconfiguracion.Name = "lblconfiguracion";
			this.lblconfiguracion.Size = new System.Drawing.Size(244, 37);
			this.lblconfiguracion.TabIndex = 15;
			this.lblconfiguracion.Text = "Configuración";
			this.lblconfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmprincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(908, 539);
			this.Controls.Add(this.lblconfiguracion);
			this.Controls.Add(this.lblusuarios);
			this.Controls.Add(this.lblrenta);
			this.Controls.Add(this.lblprecios);
			this.Controls.Add(this.lblvehiculos);
			this.Controls.Add(this.lblclientes);
			this.Controls.Add(this.lblnameuser);
			this.Controls.Add(this.lblnombreusuario);
			this.Controls.Add(this.btnconfiguracion);
			this.Controls.Add(this.btnrenta);
			this.Controls.Add(this.btnusuarios);
			this.Controls.Add(this.btnvehiculos);
			this.Controls.Add(this.btnprecios);
			this.Controls.Add(this.btnclientes);
			this.Name = "frmprincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AV";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnclientes;
		private System.Windows.Forms.Button btnprecios;
		private System.Windows.Forms.Button btnvehiculos;
		private System.Windows.Forms.Button btnusuarios;
		private System.Windows.Forms.Button btnrenta;
		private System.Windows.Forms.Button btnconfiguracion;
		private System.Windows.Forms.Label lblnombreusuario;
		private System.Windows.Forms.Label lblnameuser;
		private System.Windows.Forms.Label lblclientes;
		private System.Windows.Forms.Label lblvehiculos;
		private System.Windows.Forms.Label lblprecios;
		private System.Windows.Forms.Label lblrenta;
		private System.Windows.Forms.Label lblusuarios;
		private System.Windows.Forms.Label lblconfiguracion;
	}
}