namespace Alquiler_de_Vehículos
{
	partial class frmRenta
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
			this.tabpageHistorial = new System.Windows.Forms.TabPage();
			this.btnEntrega = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.dgvListadoRenta = new System.Windows.Forms.DataGridView();
			this.tabcontrolRentas = new System.Windows.Forms.TabControl();
			this.tabPageAgregar = new System.Windows.Forms.TabPage();
			this.label8 = new System.Windows.Forms.Label();
			this.txtFianza = new System.Windows.Forms.TextBox();
			this.txtCodigoVehiculo = new System.Windows.Forms.TextBox();
			this.txtCodigoCliente = new System.Windows.Forms.TextBox();
			this.gbxVehiculo = new System.Windows.Forms.GroupBox();
			this.txtClase = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtModelo = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtMarca = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPlaca = new System.Windows.Forms.TextBox();
			this.gbxCliente = new System.Windows.Forms.GroupBox();
			this.txtNit = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDui = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtnombreclientes = new System.Windows.Forms.TextBox();
			this.lblnombrecliente = new System.Windows.Forms.Label();
			this.btnSelectV = new System.Windows.Forms.Button();
			this.btnselectU = new System.Windows.Forms.Button();
			this.btnRentar = new System.Windows.Forms.Button();
			this.dgvVehiculo = new System.Windows.Forms.DataGridView();
			this.dgvUser = new System.Windows.Forms.DataGridView();
			this.lbldevolucion = new System.Windows.Forms.Label();
			this.dtpDevolucion = new System.Windows.Forms.DateTimePicker();
			this.txtVehiculo = new System.Windows.Forms.TextBox();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lbluser = new System.Windows.Forms.Label();
			this.mstAtajos = new System.Windows.Forms.MenuStrip();
			this.tsmRegresar = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmLimpiar = new System.Windows.Forms.ToolStripMenuItem();
			this.tabpageHistorial.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListadoRenta)).BeginInit();
			this.tabcontrolRentas.SuspendLayout();
			this.tabPageAgregar.SuspendLayout();
			this.gbxVehiculo.SuspendLayout();
			this.gbxCliente.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVehiculo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
			this.mstAtajos.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabpageHistorial
			// 
			this.tabpageHistorial.Controls.Add(this.btnEntrega);
			this.tabpageHistorial.Controls.Add(this.label10);
			this.tabpageHistorial.Controls.Add(this.textBox1);
			this.tabpageHistorial.Controls.Add(this.dgvListadoRenta);
			this.tabpageHistorial.Location = new System.Drawing.Point(4, 25);
			this.tabpageHistorial.Margin = new System.Windows.Forms.Padding(4);
			this.tabpageHistorial.Name = "tabpageHistorial";
			this.tabpageHistorial.Padding = new System.Windows.Forms.Padding(4);
			this.tabpageHistorial.Size = new System.Drawing.Size(1243, 605);
			this.tabpageHistorial.TabIndex = 1;
			this.tabpageHistorial.Text = "Historial de rentas";
			this.tabpageHistorial.UseVisualStyleBackColor = true;
			// 
			// btnEntrega
			// 
			this.btnEntrega.Location = new System.Drawing.Point(9, 498);
			this.btnEntrega.Name = "btnEntrega";
			this.btnEntrega.Size = new System.Drawing.Size(1224, 61);
			this.btnEntrega.TabIndex = 3;
			this.btnEntrega.Text = "Agregar Entrega";
			this.btnEntrega.UseVisualStyleBackColor = true;
			this.btnEntrega.Click += new System.EventHandler(this.btnEntrega_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(9, 20);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(76, 17);
			this.label10.TabIndex = 2;
			this.label10.Text = "Busqueda:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(91, 20);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(522, 22);
			this.textBox1.TabIndex = 1;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// dgvListadoRenta
			// 
			this.dgvListadoRenta.AllowUserToAddRows = false;
			this.dgvListadoRenta.AllowUserToDeleteRows = false;
			this.dgvListadoRenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListadoRenta.Location = new System.Drawing.Point(9, 60);
			this.dgvListadoRenta.Margin = new System.Windows.Forms.Padding(4);
			this.dgvListadoRenta.Name = "dgvListadoRenta";
			this.dgvListadoRenta.ReadOnly = true;
			this.dgvListadoRenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListadoRenta.Size = new System.Drawing.Size(1223, 422);
			this.dgvListadoRenta.TabIndex = 0;
			// 
			// tabcontrolRentas
			// 
			this.tabcontrolRentas.Controls.Add(this.tabPageAgregar);
			this.tabcontrolRentas.Controls.Add(this.tabpageHistorial);
			this.tabcontrolRentas.Location = new System.Drawing.Point(0, 28);
			this.tabcontrolRentas.Margin = new System.Windows.Forms.Padding(4);
			this.tabcontrolRentas.Name = "tabcontrolRentas";
			this.tabcontrolRentas.SelectedIndex = 0;
			this.tabcontrolRentas.Size = new System.Drawing.Size(1251, 634);
			this.tabcontrolRentas.TabIndex = 0;
			// 
			// tabPageAgregar
			// 
			this.tabPageAgregar.Controls.Add(this.label8);
			this.tabPageAgregar.Controls.Add(this.txtFianza);
			this.tabPageAgregar.Controls.Add(this.txtCodigoVehiculo);
			this.tabPageAgregar.Controls.Add(this.txtCodigoCliente);
			this.tabPageAgregar.Controls.Add(this.gbxVehiculo);
			this.tabPageAgregar.Controls.Add(this.gbxCliente);
			this.tabPageAgregar.Controls.Add(this.btnSelectV);
			this.tabPageAgregar.Controls.Add(this.btnselectU);
			this.tabPageAgregar.Controls.Add(this.btnRentar);
			this.tabPageAgregar.Controls.Add(this.dgvVehiculo);
			this.tabPageAgregar.Controls.Add(this.dgvUser);
			this.tabPageAgregar.Controls.Add(this.lbldevolucion);
			this.tabPageAgregar.Controls.Add(this.dtpDevolucion);
			this.tabPageAgregar.Controls.Add(this.txtVehiculo);
			this.tabPageAgregar.Controls.Add(this.txtUser);
			this.tabPageAgregar.Controls.Add(this.label2);
			this.tabPageAgregar.Controls.Add(this.lbluser);
			this.tabPageAgregar.Location = new System.Drawing.Point(4, 25);
			this.tabPageAgregar.Margin = new System.Windows.Forms.Padding(4);
			this.tabPageAgregar.Name = "tabPageAgregar";
			this.tabPageAgregar.Padding = new System.Windows.Forms.Padding(4);
			this.tabPageAgregar.Size = new System.Drawing.Size(1243, 605);
			this.tabPageAgregar.TabIndex = 0;
			this.tabPageAgregar.Text = "Renta de vehiculos";
			this.tabPageAgregar.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(260, 460);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(54, 17);
			this.label8.TabIndex = 43;
			this.label8.Text = "Fianza:";
			// 
			// txtFianza
			// 
			this.txtFianza.Location = new System.Drawing.Point(263, 480);
			this.txtFianza.Name = "txtFianza";
			this.txtFianza.ReadOnly = true;
			this.txtFianza.Size = new System.Drawing.Size(228, 22);
			this.txtFianza.TabIndex = 44;
			this.txtFianza.Text = "75.00";
			// 
			// txtCodigoVehiculo
			// 
			this.txtCodigoVehiculo.Location = new System.Drawing.Point(691, 230);
			this.txtCodigoVehiculo.Name = "txtCodigoVehiculo";
			this.txtCodigoVehiculo.ReadOnly = true;
			this.txtCodigoVehiculo.Size = new System.Drawing.Size(100, 22);
			this.txtCodigoVehiculo.TabIndex = 42;
			this.txtCodigoVehiculo.Visible = false;
			// 
			// txtCodigoCliente
			// 
			this.txtCodigoCliente.Location = new System.Drawing.Point(27, 230);
			this.txtCodigoCliente.Name = "txtCodigoCliente";
			this.txtCodigoCliente.ReadOnly = true;
			this.txtCodigoCliente.Size = new System.Drawing.Size(100, 22);
			this.txtCodigoCliente.TabIndex = 41;
			this.txtCodigoCliente.Visible = false;
			// 
			// gbxVehiculo
			// 
			this.gbxVehiculo.Controls.Add(this.txtClase);
			this.gbxVehiculo.Controls.Add(this.label7);
			this.gbxVehiculo.Controls.Add(this.txtModelo);
			this.gbxVehiculo.Controls.Add(this.label6);
			this.gbxVehiculo.Controls.Add(this.txtMarca);
			this.gbxVehiculo.Controls.Add(this.label4);
			this.gbxVehiculo.Controls.Add(this.label5);
			this.gbxVehiculo.Controls.Add(this.txtPlaca);
			this.gbxVehiculo.Location = new System.Drawing.Point(669, 258);
			this.gbxVehiculo.Name = "gbxVehiculo";
			this.gbxVehiculo.Size = new System.Drawing.Size(556, 133);
			this.gbxVehiculo.TabIndex = 40;
			this.gbxVehiculo.TabStop = false;
			this.gbxVehiculo.Text = "Vehiculo";
			// 
			// txtClase
			// 
			this.txtClase.Location = new System.Drawing.Point(322, 98);
			this.txtClase.Name = "txtClase";
			this.txtClase.ReadOnly = true;
			this.txtClase.Size = new System.Drawing.Size(228, 22);
			this.txtClase.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(319, 78);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(98, 17);
			this.label7.TabIndex = 12;
			this.label7.Text = "Renta por día:";
			// 
			// txtModelo
			// 
			this.txtModelo.Location = new System.Drawing.Point(322, 47);
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.ReadOnly = true;
			this.txtModelo.Size = new System.Drawing.Size(228, 22);
			this.txtModelo.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(319, 25);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 17);
			this.label6.TabIndex = 10;
			this.label6.Text = "Modelo:";
			// 
			// txtMarca
			// 
			this.txtMarca.Location = new System.Drawing.Point(10, 98);
			this.txtMarca.Name = "txtMarca";
			this.txtMarca.ReadOnly = true;
			this.txtMarca.Size = new System.Drawing.Size(228, 22);
			this.txtMarca.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 78);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 17);
			this.label4.TabIndex = 8;
			this.label4.Text = "Marca:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 17);
			this.label5.TabIndex = 6;
			this.label5.Text = "Placa:";
			// 
			// txtPlaca
			// 
			this.txtPlaca.Location = new System.Drawing.Point(11, 47);
			this.txtPlaca.Name = "txtPlaca";
			this.txtPlaca.ReadOnly = true;
			this.txtPlaca.Size = new System.Drawing.Size(228, 22);
			this.txtPlaca.TabIndex = 7;
			// 
			// gbxCliente
			// 
			this.gbxCliente.Controls.Add(this.txtNit);
			this.gbxCliente.Controls.Add(this.label3);
			this.gbxCliente.Controls.Add(this.txtDui);
			this.gbxCliente.Controls.Add(this.label1);
			this.gbxCliente.Controls.Add(this.txtnombreclientes);
			this.gbxCliente.Controls.Add(this.lblnombrecliente);
			this.gbxCliente.Location = new System.Drawing.Point(27, 258);
			this.gbxCliente.Name = "gbxCliente";
			this.gbxCliente.Size = new System.Drawing.Size(596, 100);
			this.gbxCliente.TabIndex = 39;
			this.gbxCliente.TabStop = false;
			this.gbxCliente.Text = "Cliente";
			// 
			// txtNit
			// 
			this.txtNit.Location = new System.Drawing.Point(362, 69);
			this.txtNit.Name = "txtNit";
			this.txtNit.ReadOnly = true;
			this.txtNit.Size = new System.Drawing.Size(228, 22);
			this.txtNit.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(317, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "NIT:";
			// 
			// txtDui
			// 
			this.txtDui.Location = new System.Drawing.Point(46, 69);
			this.txtDui.Name = "txtDui";
			this.txtDui.ReadOnly = true;
			this.txtDui.Size = new System.Drawing.Size(228, 22);
			this.txtDui.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "DUI:";
			// 
			// txtnombreclientes
			// 
			this.txtnombreclientes.Location = new System.Drawing.Point(76, 22);
			this.txtnombreclientes.Name = "txtnombreclientes";
			this.txtnombreclientes.ReadOnly = true;
			this.txtnombreclientes.Size = new System.Drawing.Size(514, 22);
			this.txtnombreclientes.TabIndex = 1;
			// 
			// lblnombrecliente
			// 
			this.lblnombrecliente.AutoSize = true;
			this.lblnombrecliente.Location = new System.Drawing.Point(7, 22);
			this.lblnombrecliente.Name = "lblnombrecliente";
			this.lblnombrecliente.Size = new System.Drawing.Size(62, 17);
			this.lblnombrecliente.TabIndex = 0;
			this.lblnombrecliente.Text = "Nombre:";
			// 
			// btnSelectV
			// 
			this.btnSelectV.Location = new System.Drawing.Point(692, 199);
			this.btnSelectV.Margin = new System.Windows.Forms.Padding(4);
			this.btnSelectV.Name = "btnSelectV";
			this.btnSelectV.Size = new System.Drawing.Size(100, 28);
			this.btnSelectV.TabIndex = 38;
			this.btnSelectV.Text = "Seleccionar vehiculo";
			this.btnSelectV.UseVisualStyleBackColor = true;
			this.btnSelectV.Click += new System.EventHandler(this.btnSelectV_Click);
			// 
			// btnselectU
			// 
			this.btnselectU.Location = new System.Drawing.Point(27, 199);
			this.btnselectU.Margin = new System.Windows.Forms.Padding(4);
			this.btnselectU.Name = "btnselectU";
			this.btnselectU.Size = new System.Drawing.Size(100, 28);
			this.btnselectU.TabIndex = 37;
			this.btnselectU.Text = "Seleccionar usuario";
			this.btnselectU.UseVisualStyleBackColor = true;
			this.btnselectU.Click += new System.EventHandler(this.btnselectU_Click);
			// 
			// btnRentar
			// 
			this.btnRentar.Location = new System.Drawing.Point(875, 459);
			this.btnRentar.Margin = new System.Windows.Forms.Padding(4);
			this.btnRentar.Name = "btnRentar";
			this.btnRentar.Size = new System.Drawing.Size(350, 64);
			this.btnRentar.TabIndex = 35;
			this.btnRentar.Text = "Rentar";
			this.btnRentar.UseVisualStyleBackColor = true;
			this.btnRentar.Click += new System.EventHandler(this.btnRentar_Click);
			// 
			// dgvVehiculo
			// 
			this.dgvVehiculo.AllowUserToAddRows = false;
			this.dgvVehiculo.AllowUserToDeleteRows = false;
			this.dgvVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVehiculo.Location = new System.Drawing.Point(692, 64);
			this.dgvVehiculo.Margin = new System.Windows.Forms.Padding(4);
			this.dgvVehiculo.MultiSelect = false;
			this.dgvVehiculo.Name = "dgvVehiculo";
			this.dgvVehiculo.ReadOnly = true;
			this.dgvVehiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvVehiculo.Size = new System.Drawing.Size(533, 128);
			this.dgvVehiculo.TabIndex = 32;
			// 
			// dgvUser
			// 
			this.dgvUser.AllowUserToAddRows = false;
			this.dgvUser.AllowUserToDeleteRows = false;
			this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUser.Location = new System.Drawing.Point(27, 64);
			this.dgvUser.Margin = new System.Windows.Forms.Padding(4);
			this.dgvUser.MultiSelect = false;
			this.dgvUser.Name = "dgvUser";
			this.dgvUser.ReadOnly = true;
			this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvUser.Size = new System.Drawing.Size(596, 128);
			this.dgvUser.TabIndex = 31;
			// 
			// lbldevolucion
			// 
			this.lbldevolucion.AutoSize = true;
			this.lbldevolucion.Location = new System.Drawing.Point(34, 459);
			this.lbldevolucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbldevolucion.Name = "lbldevolucion";
			this.lbldevolucion.Size = new System.Drawing.Size(139, 17);
			this.lbldevolucion.TabIndex = 30;
			this.lbldevolucion.Text = "Fecha de devolucion";
			// 
			// dtpDevolucion
			// 
			this.dtpDevolucion.CustomFormat = "MM/dd/yyyy";
			this.dtpDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDevolucion.Location = new System.Drawing.Point(37, 480);
			this.dtpDevolucion.Margin = new System.Windows.Forms.Padding(4);
			this.dtpDevolucion.Name = "dtpDevolucion";
			this.dtpDevolucion.Size = new System.Drawing.Size(168, 22);
			this.dtpDevolucion.TabIndex = 29;
			this.dtpDevolucion.Value = new System.DateTime(2017, 11, 27, 0, 0, 0, 0);
			// 
			// txtVehiculo
			// 
			this.txtVehiculo.Location = new System.Drawing.Point(776, 23);
			this.txtVehiculo.Margin = new System.Windows.Forms.Padding(4);
			this.txtVehiculo.Name = "txtVehiculo";
			this.txtVehiculo.Size = new System.Drawing.Size(449, 22);
			this.txtVehiculo.TabIndex = 26;
			this.txtVehiculo.TextChanged += new System.EventHandler(this.txtVehiculo_TextChanged);
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(83, 20);
			this.txtUser.Margin = new System.Windows.Forms.Padding(4);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(540, 22);
			this.txtUser.TabIndex = 25;
			this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(688, 27);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 17);
			this.label2.TabIndex = 24;
			this.label2.Text = "Vehiculo";
			// 
			// lbluser
			// 
			this.lbluser.AutoSize = true;
			this.lbluser.Location = new System.Drawing.Point(24, 23);
			this.lbluser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbluser.Name = "lbluser";
			this.lbluser.Size = new System.Drawing.Size(51, 17);
			this.lbluser.TabIndex = 23;
			this.lbluser.Text = "Cliente";
			// 
			// mstAtajos
			// 
			this.mstAtajos.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mstAtajos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRegresar,
            this.tsmLimpiar});
			this.mstAtajos.Location = new System.Drawing.Point(0, 0);
			this.mstAtajos.Name = "mstAtajos";
			this.mstAtajos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.mstAtajos.Size = new System.Drawing.Size(1249, 28);
			this.mstAtajos.TabIndex = 1;
			this.mstAtajos.Text = "menuStrip1";
			// 
			// tsmRegresar
			// 
			this.tsmRegresar.BackColor = System.Drawing.SystemColors.ControlDark;
			this.tsmRegresar.Image = global::Alquiler_de_Vehículos.Properties.Resources.flecha_hacia_la_izquierda;
			this.tsmRegresar.Name = "tsmRegresar";
			this.tsmRegresar.Size = new System.Drawing.Size(32, 24);
			this.tsmRegresar.Click += new System.EventHandler(this.tsmRegresar_Click);
			// 
			// tsmLimpiar
			// 
			this.tsmLimpiar.BackColor = System.Drawing.SystemColors.ControlDark;
			this.tsmLimpiar.Image = global::Alquiler_de_Vehículos.Properties.Resources.trash;
			this.tsmLimpiar.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
			this.tsmLimpiar.Name = "tsmLimpiar";
			this.tsmLimpiar.Size = new System.Drawing.Size(32, 24);
			this.tsmLimpiar.Click += new System.EventHandler(this.tsmLimpiar_Click);
			// 
			// frmRenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1249, 624);
			this.Controls.Add(this.tabcontrolRentas);
			this.Controls.Add(this.mstAtajos);
			this.MainMenuStrip = this.mstAtajos;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmRenta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RentaCont";
			this.Load += new System.EventHandler(this.frmRenta_Load);
			this.tabpageHistorial.ResumeLayout(false);
			this.tabpageHistorial.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListadoRenta)).EndInit();
			this.tabcontrolRentas.ResumeLayout(false);
			this.tabPageAgregar.ResumeLayout(false);
			this.tabPageAgregar.PerformLayout();
			this.gbxVehiculo.ResumeLayout(false);
			this.gbxVehiculo.PerformLayout();
			this.gbxCliente.ResumeLayout(false);
			this.gbxCliente.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVehiculo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
			this.mstAtajos.ResumeLayout(false);
			this.mstAtajos.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.TabPage tabpageHistorial;
        private System.Windows.Forms.DataGridView dgvListadoRenta;
        private System.Windows.Forms.TabControl tabcontrolRentas;
		private System.Windows.Forms.MenuStrip mstAtajos;
		private System.Windows.Forms.ToolStripMenuItem tsmRegresar;
		private System.Windows.Forms.ToolStripMenuItem tsmLimpiar;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TabPage tabPageAgregar;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtFianza;
		private System.Windows.Forms.TextBox txtCodigoVehiculo;
		private System.Windows.Forms.TextBox txtCodigoCliente;
		private System.Windows.Forms.GroupBox gbxVehiculo;
		private System.Windows.Forms.TextBox txtClase;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtModelo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtMarca;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtPlaca;
		private System.Windows.Forms.GroupBox gbxCliente;
		private System.Windows.Forms.TextBox txtNit;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDui;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtnombreclientes;
		private System.Windows.Forms.Label lblnombrecliente;
		private System.Windows.Forms.Button btnSelectV;
		private System.Windows.Forms.Button btnselectU;
		private System.Windows.Forms.Button btnRentar;
		private System.Windows.Forms.DataGridView dgvVehiculo;
		private System.Windows.Forms.DataGridView dgvUser;
		private System.Windows.Forms.Label lbldevolucion;
		private System.Windows.Forms.DateTimePicker dtpDevolucion;
		private System.Windows.Forms.TextBox txtVehiculo;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbluser;
		private System.Windows.Forms.Button btnEntrega;
	}
}