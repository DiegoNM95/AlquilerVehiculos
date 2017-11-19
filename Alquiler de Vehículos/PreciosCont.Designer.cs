namespace Alquiler_de_Vehículos
{
	partial class PreciosCont
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
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.lblprecio = new System.Windows.Forms.Label();
            this.dgvautos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.lblcolor = new System.Windows.Forms.Label();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.lblplaca = new System.Windows.Forms.Label();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.lblmodelo = new System.Windows.Forms.Label();
            this.lblmarca = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblprecioderenta = new System.Windows.Forms.Label();
            this.txtprecioderenta = new System.Windows.Forms.TextBox();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.Pbfoto = new System.Windows.Forms.PictureBox();
            this.lblfoto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvautos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(109, 61);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(336, 20);
            this.txtbuscar.TabIndex = 2;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(28, 58);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 3;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.BackColor = System.Drawing.SystemColors.Control;
            this.lblprecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblprecio.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.Location = new System.Drawing.Point(438, 9);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(116, 28);
            this.lblprecio.TabIndex = 8;
            this.lblprecio.Text = "PRECIOS";
            // 
            // dgvautos
            // 
            this.dgvautos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvautos.Location = new System.Drawing.Point(28, 114);
            this.dgvautos.Name = "dgvautos";
            this.dgvautos.Size = new System.Drawing.Size(417, 175);
            this.dgvautos.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtcolor);
            this.panel1.Controls.Add(this.lblcolor);
            this.panel1.Controls.Add(this.txtplaca);
            this.panel1.Controls.Add(this.lblplaca);
            this.panel1.Controls.Add(this.txtmodelo);
            this.panel1.Controls.Add(this.txtmarca);
            this.panel1.Controls.Add(this.lblmodelo);
            this.panel1.Controls.Add(this.lblmarca);
            this.panel1.Location = new System.Drawing.Point(476, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 175);
            this.panel1.TabIndex = 16;
            // 
            // txtcolor
            // 
            this.txtcolor.Location = new System.Drawing.Point(73, 140);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.ReadOnly = true;
            this.txtcolor.Size = new System.Drawing.Size(165, 20);
            this.txtcolor.TabIndex = 23;
            // 
            // lblcolor
            // 
            this.lblcolor.AutoSize = true;
            this.lblcolor.Location = new System.Drawing.Point(9, 143);
            this.lblcolor.Name = "lblcolor";
            this.lblcolor.Size = new System.Drawing.Size(34, 13);
            this.lblcolor.TabIndex = 22;
            this.lblcolor.Text = "Color:";
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(73, 95);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.ReadOnly = true;
            this.txtplaca.Size = new System.Drawing.Size(165, 20);
            this.txtplaca.TabIndex = 21;
            // 
            // lblplaca
            // 
            this.lblplaca.AutoSize = true;
            this.lblplaca.Location = new System.Drawing.Point(9, 98);
            this.lblplaca.Name = "lblplaca";
            this.lblplaca.Size = new System.Drawing.Size(37, 13);
            this.lblplaca.TabIndex = 20;
            this.lblplaca.Text = "Placa:";
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(73, 50);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.ReadOnly = true;
            this.txtmodelo.Size = new System.Drawing.Size(165, 20);
            this.txtmodelo.TabIndex = 19;
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(73, 8);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.ReadOnly = true;
            this.txtmarca.Size = new System.Drawing.Size(165, 20);
            this.txtmarca.TabIndex = 18;
            // 
            // lblmodelo
            // 
            this.lblmodelo.AutoSize = true;
            this.lblmodelo.Location = new System.Drawing.Point(3, 53);
            this.lblmodelo.Name = "lblmodelo";
            this.lblmodelo.Size = new System.Drawing.Size(45, 13);
            this.lblmodelo.TabIndex = 17;
            this.lblmodelo.Text = "Modelo:";
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Location = new System.Drawing.Point(9, 11);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(40, 13);
            this.lblmarca.TabIndex = 16;
            this.lblmarca.Text = "Marca:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnmodificar);
            this.panel2.Controls.Add(this.txtprecioderenta);
            this.panel2.Controls.Add(this.lblprecioderenta);
            this.panel2.Location = new System.Drawing.Point(774, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 112);
            this.panel2.TabIndex = 17;
            // 
            // lblprecioderenta
            // 
            this.lblprecioderenta.AutoSize = true;
            this.lblprecioderenta.Location = new System.Drawing.Point(57, 12);
            this.lblprecioderenta.Name = "lblprecioderenta";
            this.lblprecioderenta.Size = new System.Drawing.Size(87, 13);
            this.lblprecioderenta.TabIndex = 17;
            this.lblprecioderenta.Text = "Precio de Renta:";
            // 
            // txtprecioderenta
            // 
            this.txtprecioderenta.Location = new System.Drawing.Point(18, 40);
            this.txtprecioderenta.Name = "txtprecioderenta";
            this.txtprecioderenta.Size = new System.Drawing.Size(165, 20);
            this.txtprecioderenta.TabIndex = 19;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(55, 72);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(89, 23);
            this.btnmodificar.TabIndex = 20;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            // 
            // Pbfoto
            // 
            this.Pbfoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pbfoto.Location = new System.Drawing.Point(774, 30);
            this.Pbfoto.Name = "Pbfoto";
            this.Pbfoto.Size = new System.Drawing.Size(200, 143);
            this.Pbfoto.TabIndex = 18;
            this.Pbfoto.TabStop = false;
            // 
            // lblfoto
            // 
            this.lblfoto.AutoSize = true;
            this.lblfoto.Location = new System.Drawing.Point(855, 40);
            this.lblfoto.Name = "lblfoto";
            this.lblfoto.Size = new System.Drawing.Size(28, 13);
            this.lblfoto.TabIndex = 19;
            this.lblfoto.Text = "Foto";
            // 
            // PreciosCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 327);
            this.Controls.Add(this.lblfoto);
            this.Controls.Add(this.Pbfoto);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvautos);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbuscar);
            this.Name = "PreciosCont";
            this.Text = "PreciosCont";
            this.Load += new System.EventHandler(this.PreciosCont_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvautos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.DataGridView dgvautos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.Label lblcolor;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.Label lblplaca;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Label lblmodelo;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.TextBox txtprecioderenta;
        private System.Windows.Forms.Label lblprecioderenta;
        private System.Windows.Forms.PictureBox Pbfoto;
        private System.Windows.Forms.Label lblfoto;
    }
}