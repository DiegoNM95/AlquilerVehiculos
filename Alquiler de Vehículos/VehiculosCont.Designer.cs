namespace Alquiler_de_Vehículos
{
	partial class frmVehiculos
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
			this.tbvehiculos = new System.Windows.Forms.TabControl();
			this.tbpvehiculos = new System.Windows.Forms.TabPage();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnbuscar = new System.Windows.Forms.Button();
			this.btnagregar = new System.Windows.Forms.Button();
			this.btneliminar = new System.Windows.Forms.Button();
			this.btnmodificar = new System.Windows.Forms.Button();
			this.gbxInformacion = new System.Windows.Forms.GroupBox();
			this.cboClaseVehiculo = new System.Windows.Forms.ComboBox();
			this.txtAño = new System.Windows.Forms.TextBox();
			this.lblmarca = new System.Windows.Forms.Label();
			this.lblaño = new System.Windows.Forms.Label();
			this.lblmodelo = new System.Windows.Forms.Label();
			this.txtMarca = new System.Windows.Forms.TextBox();
			this.cboEmbrague = new System.Windows.Forms.ComboBox();
			this.txtModelo = new System.Windows.Forms.TextBox();
			this.lblembrague = new System.Windows.Forms.Label();
			this.lblclasedevehiculo = new System.Windows.Forms.Label();
			this.pbMarca = new System.Windows.Forms.PictureBox();
			this.pbModelo = new System.Windows.Forms.PictureBox();
			this.pbAño = new System.Windows.Forms.PictureBox();
			this.pbClasevehiculo = new System.Windows.Forms.PictureBox();
			this.pbEmbrague = new System.Windows.Forms.PictureBox();
			this.gbxIdentificacion = new System.Windows.Forms.GroupBox();
			this.lblplaca = new System.Windows.Forms.Label();
			this.txtPlaca = new System.Windows.Forms.TextBox();
			this.txtColor = new System.Windows.Forms.TextBox();
			this.lblcolor = new System.Windows.Forms.Label();
			this.txtPropietario = new System.Windows.Forms.TextBox();
			this.lblpropietario = new System.Windows.Forms.Label();
			this.pbPlaca = new System.Windows.Forms.PictureBox();
			this.pbColor = new System.Windows.Forms.PictureBox();
			this.pbPropietario = new System.Windows.Forms.PictureBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.gbxBusqueda = new System.Windows.Forms.GroupBox();
			this.txtbuscarlistado = new System.Windows.Forms.TextBox();
			this.dgvlistadodeautos = new System.Windows.Forms.DataGridView();
			this.btnbuscarlistado = new System.Windows.Forms.Button();
			this.mnsAtajos = new System.Windows.Forms.MenuStrip();
			this.tsmRegresar = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmLimpiarcampos = new System.Windows.Forms.ToolStripMenuItem();
			this.tbvehiculos.SuspendLayout();
			this.tbpvehiculos.SuspendLayout();
			this.panel1.SuspendLayout();
			this.gbxInformacion.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbMarca)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbModelo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAño)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbClasevehiculo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbEmbrague)).BeginInit();
			this.gbxIdentificacion.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbPlaca)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPropietario)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.gbxBusqueda.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvlistadodeautos)).BeginInit();
			this.mnsAtajos.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbvehiculos
			// 
			this.tbvehiculos.Controls.Add(this.tbpvehiculos);
			this.tbvehiculos.Controls.Add(this.tabPage2);
			this.tbvehiculos.Location = new System.Drawing.Point(0, 28);
			this.tbvehiculos.Margin = new System.Windows.Forms.Padding(4);
			this.tbvehiculos.Name = "tbvehiculos";
			this.tbvehiculos.SelectedIndex = 0;
			this.tbvehiculos.Size = new System.Drawing.Size(794, 466);
			this.tbvehiculos.TabIndex = 2;
			// 
			// tbpvehiculos
			// 
			this.tbpvehiculos.Controls.Add(this.txtCodigo);
			this.tbpvehiculos.Controls.Add(this.panel1);
			this.tbpvehiculos.Controls.Add(this.gbxInformacion);
			this.tbpvehiculos.Controls.Add(this.gbxIdentificacion);
			this.tbpvehiculos.Location = new System.Drawing.Point(4, 25);
			this.tbpvehiculos.Margin = new System.Windows.Forms.Padding(4);
			this.tbpvehiculos.Name = "tbpvehiculos";
			this.tbpvehiculos.Padding = new System.Windows.Forms.Padding(4);
			this.tbpvehiculos.Size = new System.Drawing.Size(786, 437);
			this.tbpvehiculos.TabIndex = 0;
			this.tbpvehiculos.Text = "Administración";
			this.tbpvehiculos.UseVisualStyleBackColor = true;
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(11, 282);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.ReadOnly = true;
			this.txtCodigo.Size = new System.Drawing.Size(100, 22);
			this.txtCodigo.TabIndex = 28;
			this.txtCodigo.Visible = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnbuscar);
			this.panel1.Controls.Add(this.btnagregar);
			this.panel1.Controls.Add(this.btneliminar);
			this.panel1.Controls.Add(this.btnmodificar);
			this.panel1.Location = new System.Drawing.Point(8, 320);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(767, 73);
			this.panel1.TabIndex = 27;
			// 
			// btnbuscar
			// 
			this.btnbuscar.Location = new System.Drawing.Point(585, 4);
			this.btnbuscar.Margin = new System.Windows.Forms.Padding(4);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.Size = new System.Drawing.Size(179, 64);
			this.btnbuscar.TabIndex = 19;
			this.btnbuscar.Text = "Buscar";
			this.btnbuscar.UseVisualStyleBackColor = true;
			this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
			// 
			// btnagregar
			// 
			this.btnagregar.Location = new System.Drawing.Point(3, 4);
			this.btnagregar.Margin = new System.Windows.Forms.Padding(4);
			this.btnagregar.Name = "btnagregar";
			this.btnagregar.Size = new System.Drawing.Size(186, 64);
			this.btnagregar.TabIndex = 16;
			this.btnagregar.Text = "Agregar";
			this.btnagregar.UseVisualStyleBackColor = true;
			this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
			// 
			// btneliminar
			// 
			this.btneliminar.Location = new System.Drawing.Point(391, 4);
			this.btneliminar.Margin = new System.Windows.Forms.Padding(4);
			this.btneliminar.Name = "btneliminar";
			this.btneliminar.Size = new System.Drawing.Size(186, 64);
			this.btneliminar.TabIndex = 18;
			this.btneliminar.Text = "Eliminar";
			this.btneliminar.UseVisualStyleBackColor = true;
			this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
			// 
			// btnmodificar
			// 
			this.btnmodificar.Location = new System.Drawing.Point(197, 4);
			this.btnmodificar.Margin = new System.Windows.Forms.Padding(4);
			this.btnmodificar.Name = "btnmodificar";
			this.btnmodificar.Size = new System.Drawing.Size(186, 64);
			this.btnmodificar.TabIndex = 17;
			this.btnmodificar.Text = "Modificar";
			this.btnmodificar.UseVisualStyleBackColor = true;
			this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
			// 
			// gbxInformacion
			// 
			this.gbxInformacion.Controls.Add(this.cboClaseVehiculo);
			this.gbxInformacion.Controls.Add(this.txtAño);
			this.gbxInformacion.Controls.Add(this.lblmarca);
			this.gbxInformacion.Controls.Add(this.lblaño);
			this.gbxInformacion.Controls.Add(this.lblmodelo);
			this.gbxInformacion.Controls.Add(this.txtMarca);
			this.gbxInformacion.Controls.Add(this.cboEmbrague);
			this.gbxInformacion.Controls.Add(this.txtModelo);
			this.gbxInformacion.Controls.Add(this.lblembrague);
			this.gbxInformacion.Controls.Add(this.lblclasedevehiculo);
			this.gbxInformacion.Controls.Add(this.pbMarca);
			this.gbxInformacion.Controls.Add(this.pbModelo);
			this.gbxInformacion.Controls.Add(this.pbAño);
			this.gbxInformacion.Controls.Add(this.pbClasevehiculo);
			this.gbxInformacion.Controls.Add(this.pbEmbrague);
			this.gbxInformacion.Location = new System.Drawing.Point(9, 97);
			this.gbxInformacion.Name = "gbxInformacion";
			this.gbxInformacion.Size = new System.Drawing.Size(766, 169);
			this.gbxInformacion.TabIndex = 26;
			this.gbxInformacion.TabStop = false;
			this.gbxInformacion.Text = "Información de Fabricante";
			// 
			// cboClaseVehiculo
			// 
			this.cboClaseVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboClaseVehiculo.FormattingEnabled = true;
			this.cboClaseVehiculo.Items.AddRange(new object[] {
            "Automovil",
            "Pick-Up",
            "Microbus"});
			this.cboClaseVehiculo.Location = new System.Drawing.Point(135, 114);
			this.cboClaseVehiculo.Margin = new System.Windows.Forms.Padding(4);
			this.cboClaseVehiculo.Name = "cboClaseVehiculo";
			this.cboClaseVehiculo.Size = new System.Drawing.Size(227, 24);
			this.cboClaseVehiculo.TabIndex = 6;
			this.cboClaseVehiculo.SelectedIndexChanged += new System.EventHandler(this.cboClaseVehiculo_SelectedIndexChanged);
			this.cboClaseVehiculo.Leave += new System.EventHandler(this.cboClaseVehiculo_Leave);
			// 
			// txtAño
			// 
			this.txtAño.Location = new System.Drawing.Point(627, 44);
			this.txtAño.Margin = new System.Windows.Forms.Padding(4);
			this.txtAño.MaxLength = 4;
			this.txtAño.Name = "txtAño";
			this.txtAño.Size = new System.Drawing.Size(132, 22);
			this.txtAño.TabIndex = 5;
			this.txtAño.TextChanged += new System.EventHandler(this.txtAño_TextChanged);
			this.txtAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAño_KeyPress);
			this.txtAño.Leave += new System.EventHandler(this.txtAño_Leave);
			// 
			// lblmarca
			// 
			this.lblmarca.AutoSize = true;
			this.lblmarca.Location = new System.Drawing.Point(8, 47);
			this.lblmarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblmarca.Name = "lblmarca";
			this.lblmarca.Size = new System.Drawing.Size(51, 17);
			this.lblmarca.TabIndex = 1;
			this.lblmarca.Text = "Marca:";
			// 
			// lblaño
			// 
			this.lblaño.AutoSize = true;
			this.lblaño.Location = new System.Drawing.Point(582, 47);
			this.lblaño.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblaño.Name = "lblaño";
			this.lblaño.Size = new System.Drawing.Size(37, 17);
			this.lblaño.TabIndex = 23;
			this.lblaño.Text = "Año:";
			// 
			// lblmodelo
			// 
			this.lblmodelo.AutoSize = true;
			this.lblmodelo.Location = new System.Drawing.Point(246, 47);
			this.lblmodelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblmodelo.Name = "lblmodelo";
			this.lblmodelo.Size = new System.Drawing.Size(58, 17);
			this.lblmodelo.TabIndex = 2;
			this.lblmodelo.Text = "Modelo:";
			// 
			// txtMarca
			// 
			this.txtMarca.Location = new System.Drawing.Point(67, 44);
			this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
			this.txtMarca.MaxLength = 50;
			this.txtMarca.Name = "txtMarca";
			this.txtMarca.Size = new System.Drawing.Size(171, 22);
			this.txtMarca.TabIndex = 3;
			this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
			this.txtMarca.Leave += new System.EventHandler(this.txtMarca_Leave);
			// 
			// cboEmbrague
			// 
			this.cboEmbrague.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboEmbrague.FormattingEnabled = true;
			this.cboEmbrague.Items.AddRange(new object[] {
            "Automático",
            "Standar"});
			this.cboEmbrague.Location = new System.Drawing.Point(508, 116);
			this.cboEmbrague.Margin = new System.Windows.Forms.Padding(4);
			this.cboEmbrague.Name = "cboEmbrague";
			this.cboEmbrague.Size = new System.Drawing.Size(248, 24);
			this.cboEmbrague.TabIndex = 7;
			this.cboEmbrague.SelectedIndexChanged += new System.EventHandler(this.cboEmbrague_SelectedIndexChanged);
			this.cboEmbrague.Leave += new System.EventHandler(this.cboEmbrague_Leave);
			// 
			// txtModelo
			// 
			this.txtModelo.Location = new System.Drawing.Point(312, 44);
			this.txtModelo.Margin = new System.Windows.Forms.Padding(4);
			this.txtModelo.MaxLength = 50;
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.Size = new System.Drawing.Size(262, 22);
			this.txtModelo.TabIndex = 4;
			this.txtModelo.TextChanged += new System.EventHandler(this.txtModelo_TextChanged);
			this.txtModelo.Leave += new System.EventHandler(this.txtModelo_Leave);
			// 
			// lblembrague
			// 
			this.lblembrague.AutoSize = true;
			this.lblembrague.Location = new System.Drawing.Point(370, 119);
			this.lblembrague.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblembrague.Name = "lblembrague";
			this.lblembrague.Size = new System.Drawing.Size(128, 17);
			this.lblembrague.TabIndex = 10;
			this.lblembrague.Text = "Tipo de embrague:";
			// 
			// lblclasedevehiculo
			// 
			this.lblclasedevehiculo.AutoSize = true;
			this.lblclasedevehiculo.Location = new System.Drawing.Point(8, 117);
			this.lblclasedevehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblclasedevehiculo.Name = "lblclasedevehiculo";
			this.lblclasedevehiculo.Size = new System.Drawing.Size(123, 17);
			this.lblclasedevehiculo.TabIndex = 6;
			this.lblclasedevehiculo.Text = "Clase de vehiculo:";
			// 
			// pbMarca
			// 
			this.pbMarca.BackColor = System.Drawing.Color.OrangeRed;
			this.pbMarca.Location = new System.Drawing.Point(65, 42);
			this.pbMarca.Name = "pbMarca";
			this.pbMarca.Size = new System.Drawing.Size(176, 27);
			this.pbMarca.TabIndex = 67;
			this.pbMarca.TabStop = false;
			this.pbMarca.Visible = false;
			// 
			// pbModelo
			// 
			this.pbModelo.BackColor = System.Drawing.Color.OrangeRed;
			this.pbModelo.Location = new System.Drawing.Point(308, 42);
			this.pbModelo.Name = "pbModelo";
			this.pbModelo.Size = new System.Drawing.Size(272, 27);
			this.pbModelo.TabIndex = 68;
			this.pbModelo.TabStop = false;
			this.pbModelo.Visible = false;
			// 
			// pbAño
			// 
			this.pbAño.BackColor = System.Drawing.Color.OrangeRed;
			this.pbAño.Location = new System.Drawing.Point(620, 42);
			this.pbAño.Name = "pbAño";
			this.pbAño.Size = new System.Drawing.Size(143, 27);
			this.pbAño.TabIndex = 69;
			this.pbAño.TabStop = false;
			this.pbAño.Visible = false;
			// 
			// pbClasevehiculo
			// 
			this.pbClasevehiculo.BackColor = System.Drawing.Color.OrangeRed;
			this.pbClasevehiculo.Location = new System.Drawing.Point(132, 112);
			this.pbClasevehiculo.Name = "pbClasevehiculo";
			this.pbClasevehiculo.Size = new System.Drawing.Size(235, 29);
			this.pbClasevehiculo.TabIndex = 70;
			this.pbClasevehiculo.TabStop = false;
			this.pbClasevehiculo.Visible = false;
			// 
			// pbEmbrague
			// 
			this.pbEmbrague.BackColor = System.Drawing.Color.OrangeRed;
			this.pbEmbrague.Location = new System.Drawing.Point(505, 113);
			this.pbEmbrague.Name = "pbEmbrague";
			this.pbEmbrague.Size = new System.Drawing.Size(253, 29);
			this.pbEmbrague.TabIndex = 71;
			this.pbEmbrague.TabStop = false;
			this.pbEmbrague.Visible = false;
			// 
			// gbxIdentificacion
			// 
			this.gbxIdentificacion.Controls.Add(this.lblplaca);
			this.gbxIdentificacion.Controls.Add(this.txtPlaca);
			this.gbxIdentificacion.Controls.Add(this.txtColor);
			this.gbxIdentificacion.Controls.Add(this.lblcolor);
			this.gbxIdentificacion.Controls.Add(this.txtPropietario);
			this.gbxIdentificacion.Controls.Add(this.lblpropietario);
			this.gbxIdentificacion.Controls.Add(this.pbPlaca);
			this.gbxIdentificacion.Controls.Add(this.pbColor);
			this.gbxIdentificacion.Controls.Add(this.pbPropietario);
			this.gbxIdentificacion.Location = new System.Drawing.Point(8, 19);
			this.gbxIdentificacion.Name = "gbxIdentificacion";
			this.gbxIdentificacion.Size = new System.Drawing.Size(766, 63);
			this.gbxIdentificacion.TabIndex = 25;
			this.gbxIdentificacion.TabStop = false;
			this.gbxIdentificacion.Text = "Identificación";
			// 
			// lblplaca
			// 
			this.lblplaca.AutoSize = true;
			this.lblplaca.Location = new System.Drawing.Point(8, 29);
			this.lblplaca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblplaca.Name = "lblplaca";
			this.lblplaca.Size = new System.Drawing.Size(47, 17);
			this.lblplaca.TabIndex = 21;
			this.lblplaca.Text = "Placa:";
			// 
			// txtPlaca
			// 
			this.txtPlaca.Location = new System.Drawing.Point(63, 26);
			this.txtPlaca.Margin = new System.Windows.Forms.Padding(4);
			this.txtPlaca.MaxLength = 8;
			this.txtPlaca.Name = "txtPlaca";
			this.txtPlaca.Size = new System.Drawing.Size(150, 22);
			this.txtPlaca.TabIndex = 0;
			this.txtPlaca.TextChanged += new System.EventHandler(this.txtPlaca_TextChanged);
			this.txtPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca_KeyPress);
			this.txtPlaca.Leave += new System.EventHandler(this.txtPlaca_Leave);
			// 
			// txtColor
			// 
			this.txtColor.Location = new System.Drawing.Point(274, 26);
			this.txtColor.Margin = new System.Windows.Forms.Padding(4);
			this.txtColor.MaxLength = 50;
			this.txtColor.Name = "txtColor";
			this.txtColor.Size = new System.Drawing.Size(150, 22);
			this.txtColor.TabIndex = 1;
			this.txtColor.TextChanged += new System.EventHandler(this.txtColor_TextChanged);
			this.txtColor.Leave += new System.EventHandler(this.txtColor_Leave);
			// 
			// lblcolor
			// 
			this.lblcolor.AutoSize = true;
			this.lblcolor.Location = new System.Drawing.Point(221, 29);
			this.lblcolor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblcolor.Name = "lblcolor";
			this.lblcolor.Size = new System.Drawing.Size(45, 17);
			this.lblcolor.TabIndex = 3;
			this.lblcolor.Text = "Color:";
			// 
			// txtPropietario
			// 
			this.txtPropietario.Location = new System.Drawing.Point(521, 26);
			this.txtPropietario.Margin = new System.Windows.Forms.Padding(4);
			this.txtPropietario.MaxLength = 70;
			this.txtPropietario.Name = "txtPropietario";
			this.txtPropietario.Size = new System.Drawing.Size(238, 22);
			this.txtPropietario.TabIndex = 2;
			this.txtPropietario.TextChanged += new System.EventHandler(this.txtPropietario_TextChanged);
			this.txtPropietario.Leave += new System.EventHandler(this.txtPropietario_Leave);
			// 
			// lblpropietario
			// 
			this.lblpropietario.AutoSize = true;
			this.lblpropietario.Location = new System.Drawing.Point(432, 29);
			this.lblpropietario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblpropietario.Name = "lblpropietario";
			this.lblpropietario.Size = new System.Drawing.Size(81, 17);
			this.lblpropietario.TabIndex = 5;
			this.lblpropietario.Text = "Propietario:";
			// 
			// pbPlaca
			// 
			this.pbPlaca.BackColor = System.Drawing.Color.OrangeRed;
			this.pbPlaca.Location = new System.Drawing.Point(60, 24);
			this.pbPlaca.Name = "pbPlaca";
			this.pbPlaca.Size = new System.Drawing.Size(158, 27);
			this.pbPlaca.TabIndex = 64;
			this.pbPlaca.TabStop = false;
			this.pbPlaca.Visible = false;
			// 
			// pbColor
			// 
			this.pbColor.BackColor = System.Drawing.Color.OrangeRed;
			this.pbColor.Location = new System.Drawing.Point(271, 24);
			this.pbColor.Name = "pbColor";
			this.pbColor.Size = new System.Drawing.Size(158, 27);
			this.pbColor.TabIndex = 65;
			this.pbColor.TabStop = false;
			this.pbColor.Visible = false;
			// 
			// pbPropietario
			// 
			this.pbPropietario.BackColor = System.Drawing.Color.OrangeRed;
			this.pbPropietario.Location = new System.Drawing.Point(516, 23);
			this.pbPropietario.Name = "pbPropietario";
			this.pbPropietario.Size = new System.Drawing.Size(246, 27);
			this.pbPropietario.TabIndex = 66;
			this.pbPropietario.TabStop = false;
			this.pbPropietario.Visible = false;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.gbxBusqueda);
			this.tabPage2.Controls.Add(this.dgvlistadodeautos);
			this.tabPage2.Controls.Add(this.btnbuscarlistado);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage2.Size = new System.Drawing.Size(786, 437);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Listado de autos";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// gbxBusqueda
			// 
			this.gbxBusqueda.Controls.Add(this.txtbuscarlistado);
			this.gbxBusqueda.Location = new System.Drawing.Point(8, 8);
			this.gbxBusqueda.Name = "gbxBusqueda";
			this.gbxBusqueda.Size = new System.Drawing.Size(765, 75);
			this.gbxBusqueda.TabIndex = 3;
			this.gbxBusqueda.TabStop = false;
			this.gbxBusqueda.Text = "Busqueda";
			// 
			// txtbuscarlistado
			// 
			this.txtbuscarlistado.Location = new System.Drawing.Point(7, 33);
			this.txtbuscarlistado.Margin = new System.Windows.Forms.Padding(4);
			this.txtbuscarlistado.Name = "txtbuscarlistado";
			this.txtbuscarlistado.Size = new System.Drawing.Size(751, 22);
			this.txtbuscarlistado.TabIndex = 1;
			this.txtbuscarlistado.TextChanged += new System.EventHandler(this.txtbuscarlistado_TextChanged);
			// 
			// dgvlistadodeautos
			// 
			this.dgvlistadodeautos.AllowUserToAddRows = false;
			this.dgvlistadodeautos.AllowUserToDeleteRows = false;
			this.dgvlistadodeautos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvlistadodeautos.Location = new System.Drawing.Point(8, 90);
			this.dgvlistadodeautos.Margin = new System.Windows.Forms.Padding(4);
			this.dgvlistadodeautos.MultiSelect = false;
			this.dgvlistadodeautos.Name = "dgvlistadodeautos";
			this.dgvlistadodeautos.ReadOnly = true;
			this.dgvlistadodeautos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvlistadodeautos.Size = new System.Drawing.Size(766, 277);
			this.dgvlistadodeautos.TabIndex = 2;
			// 
			// btnbuscarlistado
			// 
			this.btnbuscarlistado.Location = new System.Drawing.Point(8, 375);
			this.btnbuscarlistado.Margin = new System.Windows.Forms.Padding(4);
			this.btnbuscarlistado.Name = "btnbuscarlistado";
			this.btnbuscarlistado.Size = new System.Drawing.Size(766, 54);
			this.btnbuscarlistado.TabIndex = 0;
			this.btnbuscarlistado.Text = "Modificar";
			this.btnbuscarlistado.UseVisualStyleBackColor = true;
			this.btnbuscarlistado.Click += new System.EventHandler(this.btnbuscarlistado_Click);
			// 
			// mnsAtajos
			// 
			this.mnsAtajos.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mnsAtajos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRegresar,
            this.tsmLimpiarcampos});
			this.mnsAtajos.Location = new System.Drawing.Point(0, 0);
			this.mnsAtajos.Name = "mnsAtajos";
			this.mnsAtajos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.mnsAtajos.Size = new System.Drawing.Size(791, 28);
			this.mnsAtajos.TabIndex = 3;
			this.mnsAtajos.Text = "menuStrip1";
			// 
			// tsmRegresar
			// 
			this.tsmRegresar.BackColor = System.Drawing.SystemColors.ControlDark;
			this.tsmRegresar.Image = global::Alquiler_de_Vehículos.Properties.Resources.flecha_hacia_la_izquierda;
			this.tsmRegresar.Name = "tsmRegresar";
			this.tsmRegresar.Size = new System.Drawing.Size(32, 24);
			this.tsmRegresar.Click += new System.EventHandler(this.tsmRegresar_Click);
			// 
			// tsmLimpiarcampos
			// 
			this.tsmLimpiarcampos.BackColor = System.Drawing.SystemColors.ControlDark;
			this.tsmLimpiarcampos.Image = global::Alquiler_de_Vehículos.Properties.Resources.trash;
			this.tsmLimpiarcampos.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
			this.tsmLimpiarcampos.Name = "tsmLimpiarcampos";
			this.tsmLimpiarcampos.Size = new System.Drawing.Size(32, 24);
			this.tsmLimpiarcampos.Click += new System.EventHandler(this.tsmLimpiarcampos_Click);
			// 
			// frmVehiculos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(791, 492);
			this.Controls.Add(this.tbvehiculos);
			this.Controls.Add(this.mnsAtajos);
			this.MainMenuStrip = this.mnsAtajos;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmVehiculos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "VehiculosCont";
			this.Load += new System.EventHandler(this.frmVehiculos_Load);
			this.tbvehiculos.ResumeLayout(false);
			this.tbpvehiculos.ResumeLayout(false);
			this.tbpvehiculos.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.gbxInformacion.ResumeLayout(false);
			this.gbxInformacion.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbMarca)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbModelo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAño)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbClasevehiculo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbEmbrague)).EndInit();
			this.gbxIdentificacion.ResumeLayout(false);
			this.gbxIdentificacion.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbPlaca)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPropietario)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.gbxBusqueda.ResumeLayout(false);
			this.gbxBusqueda.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvlistadodeautos)).EndInit();
			this.mnsAtajos.ResumeLayout(false);
			this.mnsAtajos.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.TabControl tbvehiculos;
        private System.Windows.Forms.TabPage tbpvehiculos;
        private System.Windows.Forms.Label lblembrague;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblclasedevehiculo;
        private System.Windows.Forms.Label lblcolor;
        private System.Windows.Forms.Label lblmodelo;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.ComboBox cboEmbrague;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label lblplaca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label lblaño;
        private System.Windows.Forms.TextBox txtPropietario;
        private System.Windows.Forms.Label lblpropietario;
        private System.Windows.Forms.DataGridView dgvlistadodeautos;
        private System.Windows.Forms.Button btnbuscarlistado;
		private System.Windows.Forms.MenuStrip mnsAtajos;
		private System.Windows.Forms.GroupBox gbxIdentificacion;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox gbxInformacion;
		private System.Windows.Forms.GroupBox gbxBusqueda;
		private System.Windows.Forms.TextBox txtbuscarlistado;
		private System.Windows.Forms.ToolStripMenuItem tsmRegresar;
		private System.Windows.Forms.ToolStripMenuItem tsmLimpiarcampos;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.ComboBox cboClaseVehiculo;
		private System.Windows.Forms.PictureBox pbMarca;
		private System.Windows.Forms.PictureBox pbModelo;
		private System.Windows.Forms.PictureBox pbAño;
		private System.Windows.Forms.PictureBox pbClasevehiculo;
		private System.Windows.Forms.PictureBox pbEmbrague;
		private System.Windows.Forms.PictureBox pbPlaca;
		private System.Windows.Forms.PictureBox pbColor;
		private System.Windows.Forms.PictureBox pbPropietario;
	}
}