namespace Alquiler_de_Vehículos
{
	partial class VehiculosCont
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.cboembrague = new System.Windows.Forms.ComboBox();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.lblembrague = new System.Windows.Forms.Label();
            this.txtclasevehiculo = new System.Windows.Forms.TextBox();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.lblclasedevehiculo = new System.Windows.Forms.Label();
            this.lblcolor = new System.Windows.Forms.Label();
            this.lblmodelo = new System.Windows.Forms.Label();
            this.lblmarca = new System.Windows.Forms.Label();
            this.lblagregarautomovil = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblplaca = new System.Windows.Forms.Label();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.lblaño = new System.Windows.Forms.Label();
            this.txtaño = new System.Windows.Forms.TextBox();
            this.txtpripietario = new System.Windows.Forms.TextBox();
            this.lblpropietario = new System.Windows.Forms.Label();
            this.btnbuscarlistado = new System.Windows.Forms.Button();
            this.txtbuscarlistado = new System.Windows.Forms.TextBox();
            this.dgvlistadodeautos = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistadodeautos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(791, 395);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtaño);
            this.tabPage1.Controls.Add(this.lblaño);
            this.tabPage1.Controls.Add(this.txtplaca);
            this.tabPage1.Controls.Add(this.lblplaca);
            this.tabPage1.Controls.Add(this.btnbuscar);
            this.tabPage1.Controls.Add(this.btneliminar);
            this.tabPage1.Controls.Add(this.btnmodificar);
            this.tabPage1.Controls.Add(this.btnagregar);
            this.tabPage1.Controls.Add(this.cboembrague);
            this.tabPage1.Controls.Add(this.txtpripietario);
            this.tabPage1.Controls.Add(this.txtcolor);
            this.tabPage1.Controls.Add(this.lblembrague);
            this.tabPage1.Controls.Add(this.txtclasevehiculo);
            this.tabPage1.Controls.Add(this.txtmodelo);
            this.tabPage1.Controls.Add(this.txtmarca);
            this.tabPage1.Controls.Add(this.lblclasedevehiculo);
            this.tabPage1.Controls.Add(this.lblpropietario);
            this.tabPage1.Controls.Add(this.lblcolor);
            this.tabPage1.Controls.Add(this.lblmodelo);
            this.tabPage1.Controls.Add(this.lblmarca);
            this.tabPage1.Controls.Add(this.lblagregarautomovil);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(783, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Administración";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(642, 329);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 19;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(455, 329);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 18;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(250, 329);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 17;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(55, 329);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 16;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            // 
            // cboembrague
            // 
            this.cboembrague.FormattingEnabled = true;
            this.cboembrague.Location = new System.Drawing.Point(630, 136);
            this.cboembrague.Name = "cboembrague";
            this.cboembrague.Size = new System.Drawing.Size(129, 21);
            this.cboembrague.TabIndex = 15;
            // 
            // txtcolor
            // 
            this.txtcolor.Location = new System.Drawing.Point(99, 133);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(129, 20);
            this.txtcolor.TabIndex = 13;
            // 
            // lblembrague
            // 
            this.lblembrague.AutoSize = true;
            this.lblembrague.Location = new System.Drawing.Point(524, 139);
            this.lblembrague.Name = "lblembrague";
            this.lblembrague.Size = new System.Drawing.Size(96, 13);
            this.lblembrague.TabIndex = 10;
            this.lblembrague.Text = "Tipo de embrague:";
            // 
            // txtclasevehiculo
            // 
            this.txtclasevehiculo.Location = new System.Drawing.Point(630, 64);
            this.txtclasevehiculo.Name = "txtclasevehiculo";
            this.txtclasevehiculo.Size = new System.Drawing.Size(129, 20);
            this.txtclasevehiculo.TabIndex = 9;
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(351, 64);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(129, 20);
            this.txtmodelo.TabIndex = 8;
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(99, 64);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(129, 20);
            this.txtmarca.TabIndex = 7;
            // 
            // lblclasedevehiculo
            // 
            this.lblclasedevehiculo.AutoSize = true;
            this.lblclasedevehiculo.Location = new System.Drawing.Point(526, 67);
            this.lblclasedevehiculo.Name = "lblclasedevehiculo";
            this.lblclasedevehiculo.Size = new System.Drawing.Size(94, 13);
            this.lblclasedevehiculo.TabIndex = 6;
            this.lblclasedevehiculo.Text = "Clase de vehiculo:";
            // 
            // lblcolor
            // 
            this.lblcolor.AutoSize = true;
            this.lblcolor.Location = new System.Drawing.Point(34, 136);
            this.lblcolor.Name = "lblcolor";
            this.lblcolor.Size = new System.Drawing.Size(34, 13);
            this.lblcolor.TabIndex = 3;
            this.lblcolor.Text = "Color:";
            // 
            // lblmodelo
            // 
            this.lblmodelo.AutoSize = true;
            this.lblmodelo.Location = new System.Drawing.Point(284, 67);
            this.lblmodelo.Name = "lblmodelo";
            this.lblmodelo.Size = new System.Drawing.Size(45, 13);
            this.lblmodelo.TabIndex = 2;
            this.lblmodelo.Text = "Modelo:";
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Location = new System.Drawing.Point(34, 67);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(40, 13);
            this.lblmarca.TabIndex = 1;
            this.lblmarca.Text = "Marca:";
            // 
            // lblagregarautomovil
            // 
            this.lblagregarautomovil.AutoSize = true;
            this.lblagregarautomovil.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblagregarautomovil.Location = new System.Drawing.Point(293, 16);
            this.lblagregarautomovil.Name = "lblagregarautomovil";
            this.lblagregarautomovil.Size = new System.Drawing.Size(213, 20);
            this.lblagregarautomovil.TabIndex = 0;
            this.lblagregarautomovil.Text = "Agregar Automovil";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvlistadodeautos);
            this.tabPage2.Controls.Add(this.txtbuscarlistado);
            this.tabPage2.Controls.Add(this.btnbuscarlistado);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(783, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listado de autos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblplaca
            // 
            this.lblplaca.AutoSize = true;
            this.lblplaca.Location = new System.Drawing.Point(37, 200);
            this.lblplaca.Name = "lblplaca";
            this.lblplaca.Size = new System.Drawing.Size(37, 13);
            this.lblplaca.TabIndex = 21;
            this.lblplaca.Text = "Placa:";
            this.lblplaca.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(99, 197);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(129, 20);
            this.txtplaca.TabIndex = 22;
            // 
            // lblaño
            // 
            this.lblaño.AutoSize = true;
            this.lblaño.Location = new System.Drawing.Point(292, 203);
            this.lblaño.Name = "lblaño";
            this.lblaño.Size = new System.Drawing.Size(29, 13);
            this.lblaño.TabIndex = 23;
            this.lblaño.Text = "Año:";
            // 
            // txtaño
            // 
            this.txtaño.Location = new System.Drawing.Point(351, 200);
            this.txtaño.Name = "txtaño";
            this.txtaño.Size = new System.Drawing.Size(129, 20);
            this.txtaño.TabIndex = 24;
            // 
            // txtpripietario
            // 
            this.txtpripietario.Location = new System.Drawing.Point(630, 200);
            this.txtpripietario.Name = "txtpripietario";
            this.txtpripietario.Size = new System.Drawing.Size(129, 20);
            this.txtpripietario.TabIndex = 14;
            // 
            // lblpropietario
            // 
            this.lblpropietario.AutoSize = true;
            this.lblpropietario.Location = new System.Drawing.Point(545, 203);
            this.lblpropietario.Name = "lblpropietario";
            this.lblpropietario.Size = new System.Drawing.Size(60, 13);
            this.lblpropietario.TabIndex = 5;
            this.lblpropietario.Text = "Propietario:";
            // 
            // btnbuscarlistado
            // 
            this.btnbuscarlistado.Location = new System.Drawing.Point(25, 21);
            this.btnbuscarlistado.Name = "btnbuscarlistado";
            this.btnbuscarlistado.Size = new System.Drawing.Size(75, 23);
            this.btnbuscarlistado.TabIndex = 0;
            this.btnbuscarlistado.Text = "Buscar";
            this.btnbuscarlistado.UseVisualStyleBackColor = true;
            // 
            // txtbuscarlistado
            // 
            this.txtbuscarlistado.Location = new System.Drawing.Point(119, 23);
            this.txtbuscarlistado.Name = "txtbuscarlistado";
            this.txtbuscarlistado.Size = new System.Drawing.Size(654, 20);
            this.txtbuscarlistado.TabIndex = 1;
            // 
            // dgvlistadodeautos
            // 
            this.dgvlistadodeautos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistadodeautos.Location = new System.Drawing.Point(25, 100);
            this.dgvlistadodeautos.Name = "dgvlistadodeautos";
            this.dgvlistadodeautos.Size = new System.Drawing.Size(748, 235);
            this.dgvlistadodeautos.TabIndex = 2;
            // 
            // VehiculosCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 387);
            this.Controls.Add(this.tabControl1);
            this.Name = "VehiculosCont";
            this.Text = "VehiculosCont";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistadodeautos)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblembrague;
        private System.Windows.Forms.TextBox txtclasevehiculo;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Label lblclasedevehiculo;
        private System.Windows.Forms.Label lblcolor;
        private System.Windows.Forms.Label lblmodelo;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.Label lblagregarautomovil;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.ComboBox cboembrague;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label lblplaca;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.TextBox txtaño;
        private System.Windows.Forms.Label lblaño;
        private System.Windows.Forms.TextBox txtpripietario;
        private System.Windows.Forms.Label lblpropietario;
        private System.Windows.Forms.DataGridView dgvlistadodeautos;
        private System.Windows.Forms.TextBox txtbuscarlistado;
        private System.Windows.Forms.Button btnbuscarlistado;
    }
}