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
			this.t = new System.Windows.Forms.TabControl();
			this.tbpAdminClientes = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnlimpiar = new System.Windows.Forms.Button();
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
			this.gbxDocumentacion = new System.Windows.Forms.GroupBox();
			this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
			this.lblfechadenacimiento = new System.Windows.Forms.Label();
			this.cbtipolicencia = new System.Windows.Forms.ComboBox();
			this.txtNit = new System.Windows.Forms.TextBox();
			this.txtDui = new System.Windows.Forms.TextBox();
			this.lblNit = new System.Windows.Forms.Label();
			this.lblTipolicencia = new System.Windows.Forms.Label();
			this.lblDui = new System.Windows.Forms.Label();
			this.gbxApellidos = new System.Windows.Forms.GroupBox();
			this.txtSapellido = new System.Windows.Forms.TextBox();
			this.txtPapellido = new System.Windows.Forms.TextBox();
			this.lblSapellido = new System.Windows.Forms.Label();
			this.lblPapellido = new System.Windows.Forms.Label();
			this.gbxNombres = new System.Windows.Forms.GroupBox();
			this.txttercernombre = new System.Windows.Forms.TextBox();
			this.lblTnombre = new System.Windows.Forms.Label();
			this.txtSnombre = new System.Windows.Forms.TextBox();
			this.txtPnombre = new System.Windows.Forms.TextBox();
			this.lblSnombre = new System.Windows.Forms.Label();
			this.lblPnombre = new System.Windows.Forms.Label();
			this.tbpListadoClientes = new System.Windows.Forms.TabPage();
			this.gbxBusqueda = new System.Windows.Forms.GroupBox();
			this.txtbuscarcodigo = new System.Windows.Forms.TextBox();
			this.dtgListadoClientes = new System.Windows.Forms.DataGridView();
			this.mstAtajos = new System.Windows.Forms.MenuStrip();
			this.stsRegresar = new System.Windows.Forms.ToolStripMenuItem();
			this.t.SuspendLayout();
			this.tbpAdminClientes.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.gbxContacto.SuspendLayout();
			this.gbxDocumentacion.SuspendLayout();
			this.gbxApellidos.SuspendLayout();
			this.gbxNombres.SuspendLayout();
			this.tbpListadoClientes.SuspendLayout();
			this.gbxBusqueda.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgListadoClientes)).BeginInit();
			this.mstAtajos.SuspendLayout();
			this.SuspendLayout();
			// 
			// t
			// 
			this.t.Controls.Add(this.tbpAdminClientes);
			this.t.Controls.Add(this.tbpListadoClientes);
			this.t.Location = new System.Drawing.Point(0, 32);
			this.t.Margin = new System.Windows.Forms.Padding(4);
			this.t.Name = "t";
			this.t.SelectedIndex = 0;
			this.t.Size = new System.Drawing.Size(794, 464);
			this.t.TabIndex = 20;
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
			this.tableLayoutPanel1.Controls.Add(this.btnlimpiar, 3, 0);
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
			// btnlimpiar
			// 
			this.btnlimpiar.Location = new System.Drawing.Point(569, 4);
			this.btnlimpiar.Margin = new System.Windows.Forms.Padding(4);
			this.btnlimpiar.Name = "btnlimpiar";
			this.btnlimpiar.Size = new System.Drawing.Size(188, 55);
			this.btnlimpiar.TabIndex = 66;
			this.btnlimpiar.Text = "Limpiar";
			this.btnlimpiar.UseVisualStyleBackColor = true;
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
			// 
			// gbxContacto
			// 
			this.gbxContacto.Controls.Add(this.txtcorreo);
			this.gbxContacto.Controls.Add(this.txttelefono);
			this.gbxContacto.Controls.Add(this.txtdireccion);
			this.gbxContacto.Controls.Add(this.lblEmail);
			this.gbxContacto.Controls.Add(this.lblTel);
			this.gbxContacto.Controls.Add(this.lblDireccion);
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
			// 
			// txttelefono
			// 
			this.txttelefono.Location = new System.Drawing.Point(91, 54);
			this.txttelefono.Margin = new System.Windows.Forms.Padding(4);
			this.txttelefono.Name = "txttelefono";
			this.txttelefono.Size = new System.Drawing.Size(210, 22);
			this.txttelefono.TabIndex = 58;
			// 
			// txtdireccion
			// 
			this.txtdireccion.Location = new System.Drawing.Point(94, 24);
			this.txtdireccion.Margin = new System.Windows.Forms.Padding(4);
			this.txtdireccion.Name = "txtdireccion";
			this.txtdireccion.Size = new System.Drawing.Size(661, 22);
			this.txtdireccion.TabIndex = 57;
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
			this.gbxDocumentacion.Location = new System.Drawing.Point(10, 148);
			this.gbxDocumentacion.Name = "gbxDocumentacion";
			this.gbxDocumentacion.Size = new System.Drawing.Size(762, 91);
			this.gbxDocumentacion.TabIndex = 64;
			this.gbxDocumentacion.TabStop = false;
			this.gbxDocumentacion.Text = "Documentación";
			// 
			// dtpNacimiento
			// 
			this.dtpNacimiento.CustomFormat = "";
			this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNacimiento.Location = new System.Drawing.Point(553, 53);
			this.dtpNacimiento.Margin = new System.Windows.Forms.Padding(4);
			this.dtpNacimiento.Name = "dtpNacimiento";
			this.dtpNacimiento.Size = new System.Drawing.Size(202, 22);
			this.dtpNacimiento.TabIndex = 69;
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
			// 
			// txtNit
			// 
			this.txtNit.Location = new System.Drawing.Point(442, 20);
			this.txtNit.Margin = new System.Windows.Forms.Padding(4);
			this.txtNit.Name = "txtNit";
			this.txtNit.Size = new System.Drawing.Size(313, 22);
			this.txtNit.TabIndex = 66;
			// 
			// txtDui
			// 
			this.txtDui.Location = new System.Drawing.Point(58, 20);
			this.txtDui.Margin = new System.Windows.Forms.Padding(4);
			this.txtDui.Name = "txtDui";
			this.txtDui.Size = new System.Drawing.Size(306, 22);
			this.txtDui.TabIndex = 65;
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
			// gbxApellidos
			// 
			this.gbxApellidos.Controls.Add(this.txtSapellido);
			this.gbxApellidos.Controls.Add(this.txtPapellido);
			this.gbxApellidos.Controls.Add(this.lblSapellido);
			this.gbxApellidos.Controls.Add(this.lblPapellido);
			this.gbxApellidos.Location = new System.Drawing.Point(10, 78);
			this.gbxApellidos.Name = "gbxApellidos";
			this.gbxApellidos.Size = new System.Drawing.Size(762, 64);
			this.gbxApellidos.TabIndex = 63;
			this.gbxApellidos.TabStop = false;
			this.gbxApellidos.Text = "Apellidos";
			// 
			// txtSapellido
			// 
			this.txtSapellido.Location = new System.Drawing.Point(372, 22);
			this.txtSapellido.Margin = new System.Windows.Forms.Padding(4);
			this.txtSapellido.Name = "txtSapellido";
			this.txtSapellido.Size = new System.Drawing.Size(132, 22);
			this.txtSapellido.TabIndex = 49;
			// 
			// txtPapellido
			// 
			this.txtPapellido.Location = new System.Drawing.Point(110, 22);
			this.txtPapellido.Margin = new System.Windows.Forms.Padding(4);
			this.txtPapellido.Name = "txtPapellido";
			this.txtPapellido.Size = new System.Drawing.Size(132, 22);
			this.txtPapellido.TabIndex = 48;
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
			// gbxNombres
			// 
			this.gbxNombres.Controls.Add(this.txttercernombre);
			this.gbxNombres.Controls.Add(this.lblTnombre);
			this.gbxNombres.Controls.Add(this.txtSnombre);
			this.gbxNombres.Controls.Add(this.txtPnombre);
			this.gbxNombres.Controls.Add(this.lblSnombre);
			this.gbxNombres.Controls.Add(this.lblPnombre);
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
			// 
			// txtPnombre
			// 
			this.txtPnombre.Location = new System.Drawing.Point(110, 22);
			this.txtPnombre.Margin = new System.Windows.Forms.Padding(4);
			this.txtPnombre.Name = "txtPnombre";
			this.txtPnombre.Size = new System.Drawing.Size(132, 22);
			this.txtPnombre.TabIndex = 59;
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
			// tbpListadoClientes
			// 
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
			this.txtbuscarcodigo.MaxLength = 4;
			this.txtbuscarcodigo.Name = "txtbuscarcodigo";
			this.txtbuscarcodigo.Size = new System.Drawing.Size(751, 22);
			this.txtbuscarcodigo.TabIndex = 43;
			// 
			// dtgListadoClientes
			// 
			this.dtgListadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgListadoClientes.Location = new System.Drawing.Point(9, 75);
			this.dtgListadoClientes.Margin = new System.Windows.Forms.Padding(4);
			this.dtgListadoClientes.Name = "dtgListadoClientes";
			this.dtgListadoClientes.Size = new System.Drawing.Size(765, 348);
			this.dtgListadoClientes.TabIndex = 0;
			// 
			// mstAtajos
			// 
			this.mstAtajos.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mstAtajos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsRegresar});
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
			// ClientesCont
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(791, 492);
			this.ControlBox = false;
			this.Controls.Add(this.t);
			this.Controls.Add(this.mstAtajos);
			this.MainMenuStrip = this.mstAtajos;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ClientesCont";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AV | Clientes";
			this.t.ResumeLayout(false);
			this.tbpAdminClientes.ResumeLayout(false);
			this.tbpAdminClientes.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.gbxContacto.ResumeLayout(false);
			this.gbxContacto.PerformLayout();
			this.gbxDocumentacion.ResumeLayout(false);
			this.gbxDocumentacion.PerformLayout();
			this.gbxApellidos.ResumeLayout(false);
			this.gbxApellidos.PerformLayout();
			this.gbxNombres.ResumeLayout(false);
			this.gbxNombres.PerformLayout();
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
        private System.Windows.Forms.TabControl t;
        private System.Windows.Forms.TabPage tbpAdminClientes;
        private System.Windows.Forms.TabPage tbpListadoClientes;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView dtgListadoClientes;
        private System.Windows.Forms.TextBox txtbuscarcodigo;
        private System.Windows.Forms.Button btnborrar;
		private System.Windows.Forms.Button btnlimpiar;
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
	}
}