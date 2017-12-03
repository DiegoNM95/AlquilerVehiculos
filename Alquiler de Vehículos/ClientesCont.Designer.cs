namespace Alquiler_de_Vehículos
{
	partial class ClientesCont
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
			this.tbcClientes = new System.Windows.Forms.TabControl();
			this.tbpAdminClientes = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnbuscar = new System.Windows.Forms.Button();
			this.btnagregar = new System.Windows.Forms.Button();
			this.btnborrar = new System.Windows.Forms.Button();
			this.btnmodificar = new System.Windows.Forms.Button();
			this.gbxContacto = new System.Windows.Forms.GroupBox();
			this.txtcorreo = new System.Windows.Forms.TextBox();
			this.txttelefono = new System.Windows.Forms.TextBox();
			this.txtdireccion = new System.Windows.Forms.TextBox();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblTel = new System.Windows.Forms.Label();
			this.lblDireccion = new System.Windows.Forms.Label();
			this.pbDireccion = new System.Windows.Forms.PictureBox();
			this.pbTelefono = new System.Windows.Forms.PictureBox();
			this.gbxDocumentacion = new System.Windows.Forms.GroupBox();
			this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
			this.lblfechadenacimiento = new System.Windows.Forms.Label();
			this.cbtipolicencia = new System.Windows.Forms.ComboBox();
			this.txtNit = new System.Windows.Forms.TextBox();
			this.txtDui = new System.Windows.Forms.TextBox();
			this.lblNit = new System.Windows.Forms.Label();
			this.lblTipolicencia = new System.Windows.Forms.Label();
			this.lblDui = new System.Windows.Forms.Label();
			this.pbDui = new System.Windows.Forms.PictureBox();
			this.pbNit = new System.Windows.Forms.PictureBox();
			this.pbLicencia = new System.Windows.Forms.PictureBox();
			this.pbNacimiento = new System.Windows.Forms.PictureBox();
			this.gbxApellidos = new System.Windows.Forms.GroupBox();
			this.txtcodigo = new System.Windows.Forms.TextBox();
			this.txtSapellido = new System.Windows.Forms.TextBox();
			this.txtPapellido = new System.Windows.Forms.TextBox();
			this.lblSapellido = new System.Windows.Forms.Label();
			this.lblPapellido = new System.Windows.Forms.Label();
			this.pbApellido1 = new System.Windows.Forms.PictureBox();
			this.pbApellido2 = new System.Windows.Forms.PictureBox();
			this.gbxNombres = new System.Windows.Forms.GroupBox();
			this.txttercernombre = new System.Windows.Forms.TextBox();
			this.lblTnombre = new System.Windows.Forms.Label();
			this.txtSnombre = new System.Windows.Forms.TextBox();
			this.lblSnombre = new System.Windows.Forms.Label();
			this.lblPnombre = new System.Windows.Forms.Label();
			this.txtPnombre = new System.Windows.Forms.TextBox();
			this.pbNombre1 = new System.Windows.Forms.PictureBox();
			this.tbpListadoClientes = new System.Windows.Forms.TabPage();
			this.btnmodificar2 = new System.Windows.Forms.Button();
			this.gbxBusqueda = new System.Windows.Forms.GroupBox();
			this.txtbuscarcodigo = new System.Windows.Forms.TextBox();
			this.dtgListadoClientes = new System.Windows.Forms.DataGridView();
			this.mstAtajos = new System.Windows.Forms.MenuStrip();
			this.stsRegresar = new System.Windows.Forms.ToolStripMenuItem();
			this.stsLimpiarcampos = new System.Windows.Forms.ToolStripMenuItem();
			this.tbcClientes.SuspendLayout();
			this.tbpAdminClientes.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.gbxContacto.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbDireccion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbTelefono)).BeginInit();
			this.gbxDocumentacion.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbDui)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbNit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbLicencia)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbNacimiento)).BeginInit();
			this.gbxApellidos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbApellido1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbApellido2)).BeginInit();
			this.gbxNombres.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbNombre1)).BeginInit();
			this.tbpListadoClientes.SuspendLayout();
			this.gbxBusqueda.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgListadoClientes)).BeginInit();
			this.mstAtajos.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbcClientes
			// 
			this.tbcClientes.Controls.Add(this.tbpAdminClientes);
			this.tbcClientes.Controls.Add(this.tbpListadoClientes);
			this.tbcClientes.Location = new System.Drawing.Point(0, 32);
			this.tbcClientes.Margin = new System.Windows.Forms.Padding(4);
			this.tbcClientes.Name = "tbcClientes";
			this.tbcClientes.SelectedIndex = 0;
			this.tbcClientes.Size = new System.Drawing.Size(794, 464);
			this.tbcClientes.TabIndex = 20;
			// 
			// tbpAdminClientes
			// 
			this.tbpAdminClientes.Controls.Add(this.tableLayoutPanel1);
			this.tbpAdminClientes.Controls.Add(this.gbxContacto);
			this.tbpAdminClientes.Controls.Add(this.gbxDocumentacion);
			this.tbpAdminClientes.Controls.Add(this.gbxApellidos);
			this.tbpAdminClientes.Controls.Add(this.gbxNombres);
			this.tbpAdminClientes.Location = new System.Drawing.Point(4, 25);
			this.tbpAdminClientes.Margin = new System.Windows.Forms.Padding(4);
			this.tbpAdminClientes.Name = "tbpAdminClientes";
			this.tbpAdminClientes.Padding = new System.Windows.Forms.Padding(4);
			this.tbpAdminClientes.Size = new System.Drawing.Size(786, 435);
			this.tbpAdminClientes.TabIndex = 0;
			this.tbpAdminClientes.Text = "Administración de Clientes";
			this.tbpAdminClientes.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 187F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197F));
			this.tableLayoutPanel1.Controls.Add(this.btnbuscar, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnagregar, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnborrar, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnmodificar, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 362);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(762, 63);
			this.tableLayoutPanel1.TabIndex = 67;
			// 
			// btnbuscar
			// 
			this.btnbuscar.Location = new System.Drawing.Point(569, 4);
			this.btnbuscar.Margin = new System.Windows.Forms.Padding(4);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.Size = new System.Drawing.Size(188, 55);
			this.btnbuscar.TabIndex = 66;
			this.btnbuscar.Text = "Buscar";
			this.btnbuscar.UseVisualStyleBackColor = true;
			this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
			// 
			// btnagregar
			// 
			this.btnagregar.Location = new System.Drawing.Point(4, 4);
			this.btnagregar.Margin = new System.Windows.Forms.Padding(4);
			this.btnagregar.Name = "btnagregar";
			this.btnagregar.Size = new System.Drawing.Size(180, 55);
			this.btnagregar.TabIndex = 28;
			this.btnagregar.Text = "Agregar";
			this.btnagregar.UseVisualStyleBackColor = true;
			this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
			// 
			// btnborrar
			// 
			this.btnborrar.Location = new System.Drawing.Point(382, 4);
			this.btnborrar.Margin = new System.Windows.Forms.Padding(4);
			this.btnborrar.Name = "btnborrar";
			this.btnborrar.Size = new System.Drawing.Size(179, 55);
			this.btnborrar.TabIndex = 58;
			this.btnborrar.Text = "Borrar";
			this.btnborrar.UseVisualStyleBackColor = true;
			this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
			// 
			// btnmodificar
			// 
			this.btnmodificar.Location = new System.Drawing.Point(193, 4);
			this.btnmodificar.Margin = new System.Windows.Forms.Padding(4);
			this.btnmodificar.Name = "btnmodificar";
			this.btnmodificar.Size = new System.Drawing.Size(180, 55);
			this.btnmodificar.TabIndex = 29;
			this.btnmodificar.Text = "Modificar";
			this.btnmodificar.UseVisualStyleBackColor = true;
			this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
			// 
			// gbxContacto
			// 
			this.gbxContacto.Controls.Add(this.txtcorreo);
			this.gbxContacto.Controls.Add(this.txttelefono);
			this.gbxContacto.Controls.Add(this.txtdireccion);
			this.gbxContacto.Controls.Add(this.lblEmail);
			this.gbxContacto.Controls.Add(this.lblTel);
			this.gbxContacto.Controls.Add(this.lblDireccion);
			this.gbxContacto.Controls.Add(this.pbDireccion);
			this.gbxContacto.Controls.Add(this.pbTelefono);
			this.gbxContacto.Location = new System.Drawing.Point(10, 246);
			this.gbxContacto.Name = "gbxContacto";
			this.gbxContacto.Size = new System.Drawing.Size(762, 100);
			this.gbxContacto.TabIndex = 65;
			this.gbxContacto.TabStop = false;
			this.gbxContacto.Text = "Información de Contacto";
			// 
			// txtcorreo
			// 
			this.txtcorreo.Location = new System.Drawing.Point(372, 54);
			this.txtcorreo.Margin = new System.Windows.Forms.Padding(4);
			this.txtcorreo.Name = "txtcorreo";
			this.txtcorreo.Size = new System.Drawing.Size(383, 22);
			this.txtcorreo.TabIndex = 59;
			this.txtcorreo.Leave += new System.EventHandler(this.txtcorreo_Leave);
			// 
			// txttelefono
			// 
			this.txttelefono.Location = new System.Drawing.Point(91, 54);
			this.txttelefono.Margin = new System.Windows.Forms.Padding(4);
			this.txttelefono.MaxLength = 8;
			this.txttelefono.Name = "txttelefono";
			this.txttelefono.Size = new System.Drawing.Size(210, 22);
			this.txttelefono.TabIndex = 58;
			this.txttelefono.TextChanged += new System.EventHandler(this.txttelefono_TextChanged);
			this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress);
			this.txttelefono.Leave += new System.EventHandler(this.txttelefono_Leave);
			// 
			// txtdireccion
			// 
			this.txtdireccion.Location = new System.Drawing.Point(94, 24);
			this.txtdireccion.Margin = new System.Windows.Forms.Padding(4);
			this.txtdireccion.Name = "txtdireccion";
			this.txtdireccion.Size = new System.Drawing.Size(661, 22);
			this.txtdireccion.TabIndex = 57;
			this.txtdireccion.TextChanged += new System.EventHandler(this.txtdireccion_TextChanged);
			this.txtdireccion.Leave += new System.EventHandler(this.txtdireccion_Leave);
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(309, 57);
			this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(55, 17);
			this.lblEmail.TabIndex = 56;
			this.lblEmail.Text = "Correo:";
			// 
			// lblTel
			// 
			this.lblTel.AutoSize = true;
			this.lblTel.Location = new System.Drawing.Point(15, 57);
			this.lblTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTel.Name = "lblTel";
			this.lblTel.Size = new System.Drawing.Size(68, 17);
			this.lblTel.TabIndex = 55;
			this.lblTel.Text = "Teléfono:";
			// 
			// lblDireccion
			// 
			this.lblDireccion.AutoSize = true;
			this.lblDireccion.Location = new System.Drawing.Point(15, 27);
			this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDireccion.Name = "lblDireccion";
			this.lblDireccion.Size = new System.Drawing.Size(71, 17);
			this.lblDireccion.TabIndex = 54;
			this.lblDireccion.Text = "Dirección:";
			// 
			// pbDireccion
			// 
			this.pbDireccion.BackColor = System.Drawing.Color.OrangeRed;
			this.pbDireccion.Location = new System.Drawing.Point(92, 23);
			this.pbDireccion.Name = "pbDireccion";
			this.pbDireccion.Size = new System.Drawing.Size(665, 27);
			this.pbDireccion.TabIndex = 73;
			this.pbDireccion.TabStop = false;
			this.pbDireccion.Visible = false;
			// 
			// pbTelefono
			// 
			this.pbTelefono.BackColor = System.Drawing.Color.OrangeRed;
			this.pbTelefono.Location = new System.Drawing.Point(88, 53);
			this.pbTelefono.Name = "pbTelefono";
			this.pbTelefono.Size = new System.Drawing.Size(216, 27);
			this.pbTelefono.TabIndex = 66;
			this.pbTelefono.TabStop = false;
			this.pbTelefono.Visible = false;
			// 
			// gbxDocumentacion
			// 
			this.gbxDocumentacion.Controls.Add(this.dtpNacimiento);
			this.gbxDocumentacion.Controls.Add(this.lblfechadenacimiento);
			this.gbxDocumentacion.Controls.Add(this.cbtipolicencia);
			this.gbxDocumentacion.Controls.Add(this.txtNit);
			this.gbxDocumentacion.Controls.Add(this.txtDui);
			this.gbxDocumentacion.Controls.Add(this.lblNit);
			this.gbxDocumentacion.Controls.Add(this.lblTipolicencia);
			this.gbxDocumentacion.Controls.Add(this.lblDui);
			this.gbxDocumentacion.Controls.Add(this.pbDui);
			this.gbxDocumentacion.Controls.Add(this.pbNit);
			this.gbxDocumentacion.Controls.Add(this.pbLicencia);
			this.gbxDocumentacion.Controls.Add(this.pbNacimiento);
			this.gbxDocumentacion.Location = new System.Drawing.Point(10, 148);
			this.gbxDocumentacion.Name = "gbxDocumentacion";
			this.gbxDocumentacion.Size = new System.Drawing.Size(762, 91);
			this.gbxDocumentacion.TabIndex = 64;
			this.gbxDocumentacion.TabStop = false;
			this.gbxDocumentacion.Text = "Documentación";
			// 
			// dtpNacimiento
			// 
			this.dtpNacimiento.CustomFormat = "MM/dd/yyyy";
			this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNacimiento.Location = new System.Drawing.Point(553, 53);
			this.dtpNacimiento.Margin = new System.Windows.Forms.Padding(4);
			this.dtpNacimiento.Name = "dtpNacimiento";
			this.dtpNacimiento.Size = new System.Drawing.Size(202, 22);
			this.dtpNacimiento.TabIndex = 69;
			this.dtpNacimiento.Leave += new System.EventHandler(this.dtpNacimiento_Leave);
			// 
			// lblfechadenacimiento
			// 
			this.lblfechadenacimiento.AutoSize = true;
			this.lblfechadenacimiento.Location = new System.Drawing.Point(400, 58);
			this.lblfechadenacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblfechadenacimiento.Name = "lblfechadenacimiento";
			this.lblfechadenacimiento.Size = new System.Drawing.Size(145, 17);
			this.lblfechadenacimiento.TabIndex = 68;
			this.lblfechadenacimiento.Text = "Fecha de Nacimiento:";
			// 
			// cbtipolicencia
			// 
			this.cbtipolicencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbtipolicencia.FormattingEnabled = true;
			this.cbtipolicencia.Items.AddRange(new object[] {
            "Particular",
            "Liviana",
            "Pesada",
            "Pesada T"});
			this.cbtipolicencia.Location = new System.Drawing.Point(139, 50);
			this.cbtipolicencia.Margin = new System.Windows.Forms.Padding(4);
			this.cbtipolicencia.Name = "cbtipolicencia";
			this.cbtipolicencia.Size = new System.Drawing.Size(225, 24);
			this.cbtipolicencia.TabIndex = 67;
			this.cbtipolicencia.SelectedIndexChanged += new System.EventHandler(this.cbtipolicencia_SelectedIndexChanged);
			this.cbtipolicencia.Leave += new System.EventHandler(this.cbtipolicencia_Leave);
			// 
			// txtNit
			// 
			this.txtNit.Location = new System.Drawing.Point(442, 20);
			this.txtNit.Margin = new System.Windows.Forms.Padding(4);
			this.txtNit.MaxLength = 17;
			this.txtNit.Name = "txtNit";
			this.txtNit.Size = new System.Drawing.Size(313, 22);
			this.txtNit.TabIndex = 66;
			this.txtNit.TextChanged += new System.EventHandler(this.txtNit_TextChanged);
			this.txtNit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNit_KeyPress);
			this.txtNit.Leave += new System.EventHandler(this.txtNit_Leave);
			// 
			// txtDui
			// 
			this.txtDui.Location = new System.Drawing.Point(58, 20);
			this.txtDui.Margin = new System.Windows.Forms.Padding(4);
			this.txtDui.MaxLength = 10;
			this.txtDui.Name = "txtDui";
			this.txtDui.Size = new System.Drawing.Size(306, 22);
			this.txtDui.TabIndex = 65;
			this.txtDui.TextChanged += new System.EventHandler(this.txtDui_TextChanged);
			this.txtDui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDui_KeyPress);
			this.txtDui.Leave += new System.EventHandler(this.txtDui_Leave);
			// 
			// lblNit
			// 
			this.lblNit.AutoSize = true;
			this.lblNit.Location = new System.Drawing.Point(400, 23);
			this.lblNit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNit.Name = "lblNit";
			this.lblNit.Size = new System.Drawing.Size(34, 17);
			this.lblNit.TabIndex = 63;
			this.lblNit.Text = "NIT:";
			// 
			// lblTipolicencia
			// 
			this.lblTipolicencia.AutoSize = true;
			this.lblTipolicencia.Location = new System.Drawing.Point(15, 53);
			this.lblTipolicencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTipolicencia.Name = "lblTipolicencia";
			this.lblTipolicencia.Size = new System.Drawing.Size(116, 17);
			this.lblTipolicencia.TabIndex = 64;
			this.lblTipolicencia.Text = "Tipo de Licencia:";
			// 
			// lblDui
			// 
			this.lblDui.AutoSize = true;
			this.lblDui.Location = new System.Drawing.Point(15, 23);
			this.lblDui.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDui.Name = "lblDui";
			this.lblDui.Size = new System.Drawing.Size(35, 17);
			this.lblDui.TabIndex = 62;
			this.lblDui.Text = "DUI:";
			// 
			// pbDui
			// 
			this.pbDui.BackColor = System.Drawing.Color.OrangeRed;
			this.pbDui.Location = new System.Drawing.Point(57, 19);
			this.pbDui.Name = "pbDui";
			this.pbDui.Size = new System.Drawing.Size(310, 27);
			this.pbDui.TabIndex = 66;
			this.pbDui.TabStop = false;
			this.pbDui.Visible = false;
			// 
			// pbNit
			// 
			this.pbNit.BackColor = System.Drawing.Color.OrangeRed;
			this.pbNit.Location = new System.Drawing.Point(440, 19);
			this.pbNit.Name = "pbNit";
			this.pbNit.Size = new System.Drawing.Size(317, 27);
			this.pbNit.TabIndex = 70;
			this.pbNit.TabStop = false;
			this.pbNit.Visible = false;
			// 
			// pbLicencia
			// 
			this.pbLicencia.BackColor = System.Drawing.Color.OrangeRed;
			this.pbLicencia.Location = new System.Drawing.Point(137, 49);
			this.pbLicencia.Name = "pbLicencia";
			this.pbLicencia.Size = new System.Drawing.Size(229, 29);
			this.pbLicencia.TabIndex = 71;
			this.pbLicencia.TabStop = false;
			this.pbLicencia.Visible = false;
			// 
			// pbNacimiento
			// 
			this.pbNacimiento.BackColor = System.Drawing.Color.OrangeRed;
			this.pbNacimiento.Location = new System.Drawing.Point(551, 52);
			this.pbNacimiento.Name = "pbNacimiento";
			this.pbNacimiento.Size = new System.Drawing.Size(206, 27);
			this.pbNacimiento.TabIndex = 72;
			this.pbNacimiento.TabStop = false;
			this.pbNacimiento.Visible = false;
			// 
			// gbxApellidos
			// 
			this.gbxApellidos.Controls.Add(this.txtcodigo);
			this.gbxApellidos.Controls.Add(this.txtSapellido);
			this.gbxApellidos.Controls.Add(this.txtPapellido);
			this.gbxApellidos.Controls.Add(this.lblSapellido);
			this.gbxApellidos.Controls.Add(this.lblPapellido);
			this.gbxApellidos.Controls.Add(this.pbApellido1);
			this.gbxApellidos.Controls.Add(this.pbApellido2);
			this.gbxApellidos.Location = new System.Drawing.Point(10, 78);
			this.gbxApellidos.Name = "gbxApellidos";
			this.gbxApellidos.Size = new System.Drawing.Size(762, 64);
			this.gbxApellidos.TabIndex = 63;
			this.gbxApellidos.TabStop = false;
			this.gbxApellidos.Text = "Apellidos";
			// 
			// txtcodigo
			// 
			this.txtcodigo.Location = new System.Drawing.Point(623, 22);
			this.txtcodigo.Name = "txtcodigo";
			this.txtcodigo.ReadOnly = true;
			this.txtcodigo.Size = new System.Drawing.Size(100, 22);
			this.txtcodigo.TabIndex = 50;
			this.txtcodigo.Visible = false;
			// 
			// txtSapellido
			// 
			this.txtSapellido.Location = new System.Drawing.Point(372, 22);
			this.txtSapellido.Margin = new System.Windows.Forms.Padding(4);
			this.txtSapellido.Name = "txtSapellido";
			this.txtSapellido.Size = new System.Drawing.Size(132, 22);
			this.txtSapellido.TabIndex = 49;
			this.txtSapellido.TextChanged += new System.EventHandler(this.txtSapellido_TextChanged);
			this.txtSapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSapellido_KeyPress);
			this.txtSapellido.Leave += new System.EventHandler(this.txtSapellido_Leave);
			// 
			// txtPapellido
			// 
			this.txtPapellido.Location = new System.Drawing.Point(110, 22);
			this.txtPapellido.Margin = new System.Windows.Forms.Padding(4);
			this.txtPapellido.Name = "txtPapellido";
			this.txtPapellido.Size = new System.Drawing.Size(132, 22);
			this.txtPapellido.TabIndex = 48;
			this.txtPapellido.TextChanged += new System.EventHandler(this.txtPapellido_TextChanged);
			this.txtPapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPapellido_KeyPress);
			this.txtPapellido.Leave += new System.EventHandler(this.txtPapellido_Leave);
			// 
			// lblSapellido
			// 
			this.lblSapellido.AutoSize = true;
			this.lblSapellido.Location = new System.Drawing.Point(274, 25);
			this.lblSapellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSapellido.Name = "lblSapellido";
			this.lblSapellido.Size = new System.Drawing.Size(90, 17);
			this.lblSapellido.TabIndex = 47;
			this.lblSapellido.Text = "2do Apellido:";
			// 
			// lblPapellido
			// 
			this.lblPapellido.AutoSize = true;
			this.lblPapellido.Location = new System.Drawing.Point(15, 25);
			this.lblPapellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPapellido.Name = "lblPapellido";
			this.lblPapellido.Size = new System.Drawing.Size(87, 17);
			this.lblPapellido.TabIndex = 46;
			this.lblPapellido.Text = "1er Apellido:";
			// 
			// pbApellido1
			// 
			this.pbApellido1.BackColor = System.Drawing.Color.OrangeRed;
			this.pbApellido1.Location = new System.Drawing.Point(108, 21);
			this.pbApellido1.Name = "pbApellido1";
			this.pbApellido1.Size = new System.Drawing.Size(136, 27);
			this.pbApellido1.TabIndex = 64;
			this.pbApellido1.TabStop = false;
			this.pbApellido1.Visible = false;
			// 
			// pbApellido2
			// 
			this.pbApellido2.BackColor = System.Drawing.Color.OrangeRed;
			this.pbApellido2.Location = new System.Drawing.Point(370, 21);
			this.pbApellido2.Name = "pbApellido2";
			this.pbApellido2.Size = new System.Drawing.Size(136, 27);
			this.pbApellido2.TabIndex = 65;
			this.pbApellido2.TabStop = false;
			this.pbApellido2.Visible = false;
			// 
			// gbxNombres
			// 
			this.gbxNombres.Controls.Add(this.txttercernombre);
			this.gbxNombres.Controls.Add(this.lblTnombre);
			this.gbxNombres.Controls.Add(this.txtSnombre);
			this.gbxNombres.Controls.Add(this.lblSnombre);
			this.gbxNombres.Controls.Add(this.lblPnombre);
			this.gbxNombres.Controls.Add(this.txtPnombre);
			this.gbxNombres.Controls.Add(this.pbNombre1);
			this.gbxNombres.Location = new System.Drawing.Point(10, 7);
			this.gbxNombres.Name = "gbxNombres";
			this.gbxNombres.Size = new System.Drawing.Size(762, 65);
			this.gbxNombres.TabIndex = 62;
			this.gbxNombres.TabStop = false;
			this.gbxNombres.Text = "Nombres";
			// 
			// txttercernombre
			// 
			this.txttercernombre.Location = new System.Drawing.Point(623, 22);
			this.txttercernombre.Margin = new System.Windows.Forms.Padding(4);
			this.txttercernombre.Name = "txttercernombre";
			this.txttercernombre.Size = new System.Drawing.Size(132, 22);
			this.txttercernombre.TabIndex = 62;
			this.txttercernombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttercernombre_KeyPress);
			// 
			// lblTnombre
			// 
			this.lblTnombre.AutoSize = true;
			this.lblTnombre.Location = new System.Drawing.Point(528, 25);
			this.lblTnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTnombre.Name = "lblTnombre";
			this.lblTnombre.Size = new System.Drawing.Size(87, 17);
			this.lblTnombre.TabIndex = 61;
			this.lblTnombre.Text = "3er Nombre:";
			// 
			// txtSnombre
			// 
			this.txtSnombre.Location = new System.Drawing.Point(372, 22);
			this.txtSnombre.Margin = new System.Windows.Forms.Padding(4);
			this.txtSnombre.Name = "txtSnombre";
			this.txtSnombre.Size = new System.Drawing.Size(132, 22);
			this.txtSnombre.TabIndex = 60;
			this.txtSnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSnombre_KeyPress);
			// 
			// lblSnombre
			// 
			this.lblSnombre.AutoSize = true;
			this.lblSnombre.Location = new System.Drawing.Point(274, 25);
			this.lblSnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSnombre.Name = "lblSnombre";
			this.lblSnombre.Size = new System.Drawing.Size(90, 17);
			this.lblSnombre.TabIndex = 58;
			this.lblSnombre.Text = "2do Nombre:";
			// 
			// lblPnombre
			// 
			this.lblPnombre.AutoSize = true;
			this.lblPnombre.Location = new System.Drawing.Point(15, 25);
			this.lblPnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPnombre.Name = "lblPnombre";
			this.lblPnombre.Size = new System.Drawing.Size(87, 17);
			this.lblPnombre.TabIndex = 57;
			this.lblPnombre.Text = "1er Nombre:";
			// 
			// txtPnombre
			// 
			this.txtPnombre.Location = new System.Drawing.Point(110, 22);
			this.txtPnombre.Margin = new System.Windows.Forms.Padding(4);
			this.txtPnombre.Name = "txtPnombre";
			this.txtPnombre.Size = new System.Drawing.Size(132, 22);
			this.txtPnombre.TabIndex = 59;
			this.txtPnombre.TextChanged += new System.EventHandler(this.txtPnombre_TextChanged);
			this.txtPnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPnombre_KeyPress);
			this.txtPnombre.Leave += new System.EventHandler(this.txtPnombre_Leave);
			// 
			// pbNombre1
			// 
			this.pbNombre1.BackColor = System.Drawing.Color.OrangeRed;
			this.pbNombre1.Location = new System.Drawing.Point(108, 21);
			this.pbNombre1.Name = "pbNombre1";
			this.pbNombre1.Size = new System.Drawing.Size(136, 27);
			this.pbNombre1.TabIndex = 63;
			this.pbNombre1.TabStop = false;
			this.pbNombre1.Visible = false;
			// 
			// tbpListadoClientes
			// 
			this.tbpListadoClientes.Controls.Add(this.btnmodificar2);
			this.tbpListadoClientes.Controls.Add(this.gbxBusqueda);
			this.tbpListadoClientes.Controls.Add(this.dtgListadoClientes);
			this.tbpListadoClientes.Location = new System.Drawing.Point(4, 25);
			this.tbpListadoClientes.Margin = new System.Windows.Forms.Padding(4);
			this.tbpListadoClientes.Name = "tbpListadoClientes";
			this.tbpListadoClientes.Padding = new System.Windows.Forms.Padding(4);
			this.tbpListadoClientes.Size = new System.Drawing.Size(786, 435);
			this.tbpListadoClientes.TabIndex = 1;
			this.tbpListadoClientes.Text = "Listado de Clientes";
			this.tbpListadoClientes.UseVisualStyleBackColor = true;
			// 
			// btnmodificar2
			// 
			this.btnmodificar2.Location = new System.Drawing.Point(9, 384);
			this.btnmodificar2.Name = "btnmodificar2";
			this.btnmodificar2.Size = new System.Drawing.Size(764, 44);
			this.btnmodificar2.TabIndex = 45;
			this.btnmodificar2.Text = "Modificar";
			this.btnmodificar2.UseVisualStyleBackColor = true;
			this.btnmodificar2.Click += new System.EventHandler(this.btnmodificar2_Click);
			// 
			// gbxBusqueda
			// 
			this.gbxBusqueda.Controls.Add(this.txtbuscarcodigo);
			this.gbxBusqueda.Location = new System.Drawing.Point(8, 7);
			this.gbxBusqueda.Name = "gbxBusqueda";
			this.gbxBusqueda.Size = new System.Drawing.Size(765, 61);
			this.gbxBusqueda.TabIndex = 44;
			this.gbxBusqueda.TabStop = false;
			this.gbxBusqueda.Text = "Búsqueda";
			// 
			// txtbuscarcodigo
			// 
			this.txtbuscarcodigo.Location = new System.Drawing.Point(7, 22);
			this.txtbuscarcodigo.Margin = new System.Windows.Forms.Padding(4);
			this.txtbuscarcodigo.MaxLength = 100;
			this.txtbuscarcodigo.Name = "txtbuscarcodigo";
			this.txtbuscarcodigo.Size = new System.Drawing.Size(751, 22);
			this.txtbuscarcodigo.TabIndex = 43;
			this.txtbuscarcodigo.TextChanged += new System.EventHandler(this.txtbuscarcodigo_TextChanged);
			// 
			// dtgListadoClientes
			// 
			this.dtgListadoClientes.AllowUserToAddRows = false;
			this.dtgListadoClientes.AllowUserToDeleteRows = false;
			this.dtgListadoClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dtgListadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgListadoClientes.Location = new System.Drawing.Point(9, 75);
			this.dtgListadoClientes.Margin = new System.Windows.Forms.Padding(4);
			this.dtgListadoClientes.MultiSelect = false;
			this.dtgListadoClientes.Name = "dtgListadoClientes";
			this.dtgListadoClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgListadoClientes.Size = new System.Drawing.Size(765, 301);
			this.dtgListadoClientes.TabIndex = 0;
			// 
			// mstAtajos
			// 
			this.mstAtajos.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mstAtajos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsRegresar,
            this.stsLimpiarcampos});
			this.mstAtajos.Location = new System.Drawing.Point(0, 0);
			this.mstAtajos.Name = "mstAtajos";
			this.mstAtajos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.mstAtajos.Size = new System.Drawing.Size(791, 28);
			this.mstAtajos.TabIndex = 21;
			this.mstAtajos.Text = "Atajos";
			// 
			// stsRegresar
			// 
			this.stsRegresar.BackColor = System.Drawing.SystemColors.ControlDark;
			this.stsRegresar.Image = global::Alquiler_de_Vehículos.Properties.Resources.flecha_hacia_la_izquierda;
			this.stsRegresar.ImageTransparentColor = System.Drawing.Color.DarkGray;
			this.stsRegresar.Name = "stsRegresar";
			this.stsRegresar.Size = new System.Drawing.Size(32, 24);
			this.stsRegresar.Click += new System.EventHandler(this.stsRegresar_Click);
			// 
			// stsLimpiarcampos
			// 
			this.stsLimpiarcampos.AccessibleDescription = "Limpiar Campos";
			this.stsLimpiarcampos.AccessibleName = "Limpiar Campos";
			this.stsLimpiarcampos.AutoToolTip = true;
			this.stsLimpiarcampos.BackColor = System.Drawing.SystemColors.ControlDark;
			this.stsLimpiarcampos.Image = global::Alquiler_de_Vehículos.Properties.Resources.trash;
			this.stsLimpiarcampos.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.stsLimpiarcampos.Name = "stsLimpiarcampos";
			this.stsLimpiarcampos.ShortcutKeyDisplayString = "";
			this.stsLimpiarcampos.Size = new System.Drawing.Size(32, 24);
			this.stsLimpiarcampos.ToolTipText = "Limpiar Campos";
			this.stsLimpiarcampos.Click += new System.EventHandler(this.stsLimpiarcampos_Click);
			// 
			// ClientesCont
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(791, 492);
			this.ControlBox = false;
			this.Controls.Add(this.tbcClientes);
			this.Controls.Add(this.mstAtajos);
			this.MainMenuStrip = this.mstAtajos;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ClientesCont";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AV | Clientes";
			this.Load += new System.EventHandler(this.ClientesCont_Load);
			this.tbcClientes.ResumeLayout(false);
			this.tbpAdminClientes.ResumeLayout(false);
			this.tbpAdminClientes.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.gbxContacto.ResumeLayout(false);
			this.gbxContacto.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbDireccion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbTelefono)).EndInit();
			this.gbxDocumentacion.ResumeLayout(false);
			this.gbxDocumentacion.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbDui)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbNit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbLicencia)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbNacimiento)).EndInit();
			this.gbxApellidos.ResumeLayout(false);
			this.gbxApellidos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbApellido1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbApellido2)).EndInit();
			this.gbxNombres.ResumeLayout(false);
			this.gbxNombres.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbNombre1)).EndInit();
			this.tbpListadoClientes.ResumeLayout(false);
			this.gbxBusqueda.ResumeLayout(false);
			this.gbxBusqueda.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgListadoClientes)).EndInit();
			this.mstAtajos.ResumeLayout(false);
			this.mstAtajos.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion
        private System.Windows.Forms.TabControl tbcClientes;
        private System.Windows.Forms.TabPage tbpAdminClientes;
        private System.Windows.Forms.TabPage tbpListadoClientes;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView dtgListadoClientes;
        private System.Windows.Forms.TextBox txtbuscarcodigo;
        private System.Windows.Forms.Button btnborrar;
		private System.Windows.Forms.Button btnbuscar;
		private System.Windows.Forms.GroupBox gbxContacto;
		private System.Windows.Forms.TextBox txtcorreo;
		private System.Windows.Forms.TextBox txttelefono;
		private System.Windows.Forms.TextBox txtdireccion;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblTel;
		private System.Windows.Forms.Label lblDireccion;
		private System.Windows.Forms.GroupBox gbxDocumentacion;
		private System.Windows.Forms.DateTimePicker dtpNacimiento;
		private System.Windows.Forms.Label lblfechadenacimiento;
		private System.Windows.Forms.ComboBox cbtipolicencia;
		private System.Windows.Forms.TextBox txtNit;
		private System.Windows.Forms.TextBox txtDui;
		private System.Windows.Forms.Label lblNit;
		private System.Windows.Forms.Label lblTipolicencia;
		private System.Windows.Forms.Label lblDui;
		private System.Windows.Forms.GroupBox gbxApellidos;
		private System.Windows.Forms.TextBox txtSapellido;
		private System.Windows.Forms.TextBox txtPapellido;
		private System.Windows.Forms.Label lblSapellido;
		private System.Windows.Forms.Label lblPapellido;
		private System.Windows.Forms.GroupBox gbxNombres;
		private System.Windows.Forms.TextBox txttercernombre;
		private System.Windows.Forms.Label lblTnombre;
		private System.Windows.Forms.TextBox txtSnombre;
		private System.Windows.Forms.TextBox txtPnombre;
		private System.Windows.Forms.Label lblSnombre;
		private System.Windows.Forms.Label lblPnombre;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.MenuStrip mstAtajos;
		private System.Windows.Forms.GroupBox gbxBusqueda;
		private System.Windows.Forms.ToolStripMenuItem stsRegresar;
		private System.Windows.Forms.TextBox txtcodigo;
		private System.Windows.Forms.PictureBox pbNombre1;
		private System.Windows.Forms.PictureBox pbDireccion;
		private System.Windows.Forms.PictureBox pbTelefono;
		private System.Windows.Forms.PictureBox pbDui;
		private System.Windows.Forms.PictureBox pbNit;
		private System.Windows.Forms.PictureBox pbLicencia;
		private System.Windows.Forms.PictureBox pbNacimiento;
		private System.Windows.Forms.PictureBox pbApellido1;
		private System.Windows.Forms.PictureBox pbApellido2;
		private System.Windows.Forms.ToolStripMenuItem stsLimpiarcampos;
		private System.Windows.Forms.Button btnmodificar2;
	}
}