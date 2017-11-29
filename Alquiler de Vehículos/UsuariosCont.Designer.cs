namespace Alquiler_de_Vehículos
{
	partial class UsuariosCont
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
			this.tdadministracion = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btnbuscar = new System.Windows.Forms.Button();
			this.btbeliminar = new System.Windows.Forms.Button();
			this.cmbusuario = new System.Windows.Forms.ComboBox();
			this.lbltipousuario = new System.Windows.Forms.Label();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btbcrear = new System.Windows.Forms.Button();
			this.txtcontraseña = new System.Windows.Forms.TextBox();
			this.txtusuario = new System.Windows.Forms.TextBox();
			this.txtcodigo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.dgvListado = new System.Windows.Forms.DataGridView();
			this.button3 = new System.Windows.Forms.Button();
			this.mstAtajos = new System.Windows.Forms.MenuStrip();
			this.tsmRegresar = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmLimpiar = new System.Windows.Forms.ToolStripMenuItem();
			this.tdadministracion.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
			this.mstAtajos.SuspendLayout();
			this.SuspendLayout();
			// 
			// tdadministracion
			// 
			this.tdadministracion.Controls.Add(this.tabPage1);
			this.tdadministracion.Controls.Add(this.tabPage2);
			this.tdadministracion.Location = new System.Drawing.Point(2, 32);
			this.tdadministracion.Margin = new System.Windows.Forms.Padding(4);
			this.tdadministracion.Name = "tdadministracion";
			this.tdadministracion.SelectedIndex = 0;
			this.tdadministracion.Size = new System.Drawing.Size(876, 412);
			this.tdadministracion.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btnbuscar);
			this.tabPage1.Controls.Add(this.btbeliminar);
			this.tabPage1.Controls.Add(this.cmbusuario);
			this.tabPage1.Controls.Add(this.lbltipousuario);
			this.tabPage1.Controls.Add(this.btnModificar);
			this.tabPage1.Controls.Add(this.btbcrear);
			this.tabPage1.Controls.Add(this.txtcontraseña);
			this.tabPage1.Controls.Add(this.txtusuario);
			this.tabPage1.Controls.Add(this.txtcodigo);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage1.Size = new System.Drawing.Size(868, 383);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Administración de usuarios";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// btnbuscar
			// 
			this.btnbuscar.Location = new System.Drawing.Point(593, 254);
			this.btnbuscar.Margin = new System.Windows.Forms.Padding(4);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.Size = new System.Drawing.Size(100, 28);
			this.btnbuscar.TabIndex = 12;
			this.btnbuscar.Text = "Buscar";
			this.btnbuscar.UseVisualStyleBackColor = true;
			this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
			// 
			// btbeliminar
			// 
			this.btbeliminar.Location = new System.Drawing.Point(435, 254);
			this.btbeliminar.Margin = new System.Windows.Forms.Padding(4);
			this.btbeliminar.Name = "btbeliminar";
			this.btbeliminar.Size = new System.Drawing.Size(100, 28);
			this.btbeliminar.TabIndex = 11;
			this.btbeliminar.Text = "Eliminar usuario";
			this.btbeliminar.UseVisualStyleBackColor = true;
			this.btbeliminar.Click += new System.EventHandler(this.btbeliminar_Click);
			// 
			// cmbusuario
			// 
			this.cmbusuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbusuario.FormattingEnabled = true;
			this.cmbusuario.Location = new System.Drawing.Point(240, 108);
			this.cmbusuario.Margin = new System.Windows.Forms.Padding(4);
			this.cmbusuario.Name = "cmbusuario";
			this.cmbusuario.Size = new System.Drawing.Size(160, 24);
			this.cmbusuario.TabIndex = 10;
			// 
			// lbltipousuario
			// 
			this.lbltipousuario.AutoSize = true;
			this.lbltipousuario.Location = new System.Drawing.Point(40, 108);
			this.lbltipousuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbltipousuario.Name = "lbltipousuario";
			this.lbltipousuario.Size = new System.Drawing.Size(107, 17);
			this.lbltipousuario.TabIndex = 9;
			this.lbltipousuario.Text = "Tipo de usuario";
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(240, 254);
			this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(100, 28);
			this.btnModificar.TabIndex = 7;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btbcrear
			// 
			this.btbcrear.Location = new System.Drawing.Point(43, 254);
			this.btbcrear.Margin = new System.Windows.Forms.Padding(4);
			this.btbcrear.Name = "btbcrear";
			this.btbcrear.Size = new System.Drawing.Size(140, 28);
			this.btbcrear.TabIndex = 6;
			this.btbcrear.Text = "Crear";
			this.btbcrear.UseVisualStyleBackColor = true;
			this.btbcrear.Click += new System.EventHandler(this.btbcrear_Click);
			// 
			// txtcontraseña
			// 
			this.txtcontraseña.Location = new System.Drawing.Point(240, 176);
			this.txtcontraseña.Margin = new System.Windows.Forms.Padding(4);
			this.txtcontraseña.Name = "txtcontraseña";
			this.txtcontraseña.Size = new System.Drawing.Size(132, 22);
			this.txtcontraseña.TabIndex = 5;
			// 
			// txtusuario
			// 
			this.txtusuario.Location = new System.Drawing.Point(240, 35);
			this.txtusuario.Margin = new System.Windows.Forms.Padding(4);
			this.txtusuario.Name = "txtusuario";
			this.txtusuario.Size = new System.Drawing.Size(132, 22);
			this.txtusuario.TabIndex = 4;
			// 
			// txtcodigo
			// 
			this.txtcodigo.Location = new System.Drawing.Point(727, 17);
			this.txtcodigo.Margin = new System.Windows.Forms.Padding(4);
			this.txtcodigo.Name = "txtcodigo";
			this.txtcodigo.ReadOnly = true;
			this.txtcodigo.Size = new System.Drawing.Size(132, 22);
			this.txtcodigo.TabIndex = 3;
			this.txtcodigo.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(29, 176);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(118, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Crear contraseña";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 38);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nombre Usuario:";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.textBox1);
			this.tabPage2.Controls.Add(this.dgvListado);
			this.tabPage2.Controls.Add(this.button3);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage2.Size = new System.Drawing.Size(868, 383);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Búsqueda de Usuarios";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(60, 58);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(740, 22);
			this.textBox1.TabIndex = 9;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// dgvListado
			// 
			this.dgvListado.AllowUserToAddRows = false;
			this.dgvListado.AllowUserToDeleteRows = false;
			this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListado.Location = new System.Drawing.Point(60, 104);
			this.dgvListado.Margin = new System.Windows.Forms.Padding(4);
			this.dgvListado.MultiSelect = false;
			this.dgvListado.Name = "dgvListado";
			this.dgvListado.ReadOnly = true;
			this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListado.Size = new System.Drawing.Size(740, 213);
			this.dgvListado.TabIndex = 8;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(60, 325);
			this.button3.Margin = new System.Windows.Forms.Padding(4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(740, 48);
			this.button3.TabIndex = 4;
			this.button3.Text = "Buscar usuario";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
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
			this.mstAtajos.Size = new System.Drawing.Size(876, 28);
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
			// UsuariosCont
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(876, 443);
			this.Controls.Add(this.tdadministracion);
			this.Controls.Add(this.mstAtajos);
			this.MainMenuStrip = this.mstAtajos;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "UsuariosCont";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Usuarios";
			this.Load += new System.EventHandler(this.UsuariosCont_Load);
			this.tdadministracion.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
			this.mstAtajos.ResumeLayout(false);
			this.mstAtajos.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.TabControl tdadministracion;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.ComboBox cmbusuario;
        private System.Windows.Forms.Label lbltipousuario;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btbcrear;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btbeliminar;
		private System.Windows.Forms.MenuStrip mstAtajos;
		private System.Windows.Forms.ToolStripMenuItem tsmRegresar;
		private System.Windows.Forms.ToolStripMenuItem tsmLimpiar;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnbuscar;
	}
}