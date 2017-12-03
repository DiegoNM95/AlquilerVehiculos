namespace Alquiler_de_Vehículos
{
	partial class frmPrecios
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
			this.gbxVehiculo = new System.Windows.Forms.GroupBox();
			this.txtbusqueda = new System.Windows.Forms.TextBox();
			this.dgvListado = new System.Windows.Forms.DataGridView();
			this.btnModificar = new System.Windows.Forms.Button();
			this.mstAtajos = new System.Windows.Forms.MenuStrip();
			this.tsmRegresar = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.pbPrecio = new System.Windows.Forms.PictureBox();
			this.gbxVehiculo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
			this.mstAtajos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbPrecio)).BeginInit();
			this.SuspendLayout();
			// 
			// gbxVehiculo
			// 
			this.gbxVehiculo.Controls.Add(this.txtbusqueda);
			this.gbxVehiculo.Controls.Add(this.dgvListado);
			this.gbxVehiculo.Location = new System.Drawing.Point(13, 45);
			this.gbxVehiculo.Name = "gbxVehiculo";
			this.gbxVehiculo.Size = new System.Drawing.Size(766, 329);
			this.gbxVehiculo.TabIndex = 0;
			this.gbxVehiculo.TabStop = false;
			this.gbxVehiculo.Text = "Vehiculo";
			// 
			// txtbusqueda
			// 
			this.txtbusqueda.Location = new System.Drawing.Point(6, 21);
			this.txtbusqueda.Name = "txtbusqueda";
			this.txtbusqueda.Size = new System.Drawing.Size(753, 22);
			this.txtbusqueda.TabIndex = 1;
			this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
			// 
			// dgvListado
			// 
			this.dgvListado.AllowUserToAddRows = false;
			this.dgvListado.AllowUserToDeleteRows = false;
			this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListado.Location = new System.Drawing.Point(6, 49);
			this.dgvListado.Name = "dgvListado";
			this.dgvListado.ReadOnly = true;
			this.dgvListado.RowTemplate.Height = 24;
			this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListado.Size = new System.Drawing.Size(754, 268);
			this.dgvListado.TabIndex = 0;
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(13, 420);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(766, 60);
			this.btnModificar.TabIndex = 1;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// mstAtajos
			// 
			this.mstAtajos.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mstAtajos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRegresar});
			this.mstAtajos.Location = new System.Drawing.Point(0, 0);
			this.mstAtajos.Name = "mstAtajos";
			this.mstAtajos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.mstAtajos.Size = new System.Drawing.Size(791, 28);
			this.mstAtajos.TabIndex = 2;
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 389);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Precio:";
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(74, 386);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(100, 22);
			this.txtPrecio.TabIndex = 4;
			this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
			this.txtPrecio.Leave += new System.EventHandler(this.txtPrecio_Leave);
			// 
			// pbPrecio
			// 
			this.pbPrecio.BackColor = System.Drawing.Color.Tomato;
			this.pbPrecio.Location = new System.Drawing.Point(72, 384);
			this.pbPrecio.Name = "pbPrecio";
			this.pbPrecio.Size = new System.Drawing.Size(106, 28);
			this.pbPrecio.TabIndex = 6;
			this.pbPrecio.TabStop = false;
			this.pbPrecio.Visible = false;
			// 
			// frmPrecios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(791, 492);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.gbxVehiculo);
			this.Controls.Add(this.mstAtajos);
			this.Controls.Add(this.pbPrecio);
			this.MainMenuStrip = this.mstAtajos;
			this.Name = "frmPrecios";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PreciosCont";
			this.Load += new System.EventHandler(this.frmPrecios_Load);
			this.gbxVehiculo.ResumeLayout(false);
			this.gbxVehiculo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
			this.mstAtajos.ResumeLayout(false);
			this.mstAtajos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbPrecio)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gbxVehiculo;
		private System.Windows.Forms.TextBox txtbusqueda;
		private System.Windows.Forms.DataGridView dgvListado;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.MenuStrip mstAtajos;
		private System.Windows.Forms.ToolStripMenuItem tsmRegresar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.PictureBox pbPrecio;
	}
}