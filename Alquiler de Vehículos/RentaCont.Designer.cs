namespace Alquiler_de_Vehículos
{
	partial class RentaCont
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
            this.tabpage2 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.lbluser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtVehiculo = new System.Windows.Forms.TextBox();
            this.lblfecha = new System.Windows.Forms.Label();
            this.dtpRenta = new System.Windows.Forms.DateTimePicker();
            this.dtpDevolucion = new System.Windows.Forms.DateTimePicker();
            this.lbldevolucion = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnregistro = new System.Windows.Forms.Button();
            this.btnselectU = new System.Windows.Forms.Button();
            this.btnSelectV = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabpage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabpage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(938, 538);
            this.tabControl1.TabIndex = 0;
            // 
            // tabpage2
            // 
            this.tabpage2.Controls.Add(this.btnborrar);
            this.tabpage2.Controls.Add(this.btnmodificar);
            this.tabpage2.Controls.Add(this.dataGridView3);
            this.tabpage2.Location = new System.Drawing.Point(4, 22);
            this.tabpage2.Name = "tabpage2";
            this.tabpage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage2.Size = new System.Drawing.Size(930, 512);
            this.tabpage2.TabIndex = 1;
            this.tabpage2.Text = "Historial de rentas";
            this.tabpage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(31, 22);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(751, 346);
            this.dataGridView3.TabIndex = 0;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(806, 22);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 1;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(806, 62);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(75, 23);
            this.btnborrar.TabIndex = 2;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(17, 19);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(96, 13);
            this.lbluser.TabIndex = 23;
            this.lbluser.Text = "Nombre de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Vehiculo";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(122, 16);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(252, 20);
            this.txtUser.TabIndex = 25;
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.Location = new System.Drawing.Point(582, 19);
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.Size = new System.Drawing.Size(219, 20);
            this.txtVehiculo.TabIndex = 26;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(278, 229);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(79, 13);
            this.lblfecha.TabIndex = 27;
            this.lblfecha.Text = "Fecha de renta";
            // 
            // dtpRenta
            // 
            this.dtpRenta.Location = new System.Drawing.Point(404, 229);
            this.dtpRenta.Name = "dtpRenta";
            this.dtpRenta.Size = new System.Drawing.Size(236, 20);
            this.dtpRenta.TabIndex = 28;
            // 
            // dtpDevolucion
            // 
            this.dtpDevolucion.Location = new System.Drawing.Point(404, 269);
            this.dtpDevolucion.Name = "dtpDevolucion";
            this.dtpDevolucion.Size = new System.Drawing.Size(236, 20);
            this.dtpDevolucion.TabIndex = 29;
            this.dtpDevolucion.Value = new System.DateTime(2017, 11, 15, 16, 24, 0, 0);
            // 
            // lbldevolucion
            // 
            this.lbldevolucion.AutoSize = true;
            this.lbldevolucion.Location = new System.Drawing.Point(278, 275);
            this.lbldevolucion.Name = "lbldevolucion";
            this.lbldevolucion.Size = new System.Drawing.Size(107, 13);
            this.lbldevolucion.TabIndex = 30;
            this.lbldevolucion.Text = "Fecha de devolucion";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(519, 52);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(363, 104);
            this.dataGridView2.TabIndex = 32;
            this.dataGridView2.Visible = false;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(392, 13);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 33;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(807, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnregistro
            // 
            this.btnregistro.Location = new System.Drawing.Point(435, 388);
            this.btnregistro.Name = "btnregistro";
            this.btnregistro.Size = new System.Drawing.Size(129, 23);
            this.btnregistro.TabIndex = 35;
            this.btnregistro.Text = "Agregar";
            this.btnregistro.UseVisualStyleBackColor = true;
            this.btnregistro.Click += new System.EventHandler(this.btnregistro_Click);
            // 
            // btnselectU
            // 
            this.btnselectU.Location = new System.Drawing.Point(20, 162);
            this.btnselectU.Name = "btnselectU";
            this.btnselectU.Size = new System.Drawing.Size(75, 23);
            this.btnselectU.TabIndex = 37;
            this.btnselectU.Text = "Seleccionar usuario";
            this.btnselectU.UseVisualStyleBackColor = true;
            this.btnselectU.Visible = false;
            // 
            // btnSelectV
            // 
            this.btnSelectV.Location = new System.Drawing.Point(519, 162);
            this.btnSelectV.Name = "btnSelectV";
            this.btnSelectV.Size = new System.Drawing.Size(75, 23);
            this.btnSelectV.TabIndex = 38;
            this.btnSelectV.Text = "Seleccionar vehiculo";
            this.btnSelectV.UseVisualStyleBackColor = true;
            this.btnSelectV.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView4);
            this.tabPage1.Controls.Add(this.btnSelectV);
            this.tabPage1.Controls.Add(this.btnselectU);
            this.tabPage1.Controls.Add(this.btnregistro);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnbuscar);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.lbldevolucion);
            this.tabPage1.Controls.Add(this.dtpDevolucion);
            this.tabPage1.Controls.Add(this.dtpRenta);
            this.tabPage1.Controls.Add(this.lblfecha);
            this.tabPage1.Controls.Add(this.txtVehiculo);
            this.tabPage1.Controls.Add(this.txtUser);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lbluser);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(930, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Renta de vehiculos";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 104);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.Visible = false;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(266, 337);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(471, 32);
            this.dataGridView4.TabIndex = 39;
            // 
            // RentaCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 507);
            this.Controls.Add(this.tabControl1);
            this.Name = "RentaCont";
            this.Text = "RentaCont";
            this.Load += new System.EventHandler(this.RentaCont_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabpage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpage2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSelectV;
        private System.Windows.Forms.Button btnselectU;
        private System.Windows.Forms.Button btnregistro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbldevolucion;
        private System.Windows.Forms.DateTimePicker dtpDevolucion;
        private System.Windows.Forms.DateTimePicker dtpRenta;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.TextBox txtVehiculo;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.DataGridView dataGridView4;
    }
}