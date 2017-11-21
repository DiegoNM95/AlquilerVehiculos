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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.btbcrear = new System.Windows.Forms.Button();
            this.btblimpiar = new System.Windows.Forms.Button();
            this.lbltipousuario = new System.Windows.Forms.Label();
            this.cmbusuario = new System.Windows.Forms.ComboBox();
            this.btbeliminar = new System.Windows.Forms.Button();
            this.tdadministracion.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tdadministracion
            // 
            this.tdadministracion.Controls.Add(this.tabPage1);
            this.tdadministracion.Controls.Add(this.tabPage2);
            this.tdadministracion.Location = new System.Drawing.Point(0, 0);
            this.tdadministracion.Name = "tdadministracion";
            this.tdadministracion.SelectedIndex = 0;
            this.tdadministracion.Size = new System.Drawing.Size(657, 321);
            this.tdadministracion.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btbeliminar);
            this.tabPage1.Controls.Add(this.cmbusuario);
            this.tabPage1.Controls.Add(this.lbltipousuario);
            this.tabPage1.Controls.Add(this.btblimpiar);
            this.tabPage1.Controls.Add(this.btbcrear);
            this.tabPage1.Controls.Add(this.txtcontraseña);
            this.tabPage1.Controls.Add(this.txtusuario);
            this.tabPage1.Controls.Add(this.txtcodigo);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(649, 295);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Administración de usuarios";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(649, 295);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Búsqueda de Usuarios";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(45, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Buscar usuario";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(516, 173);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Asignar nombre de usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Crear contraseña";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(180, 52);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 3;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(180, 97);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(100, 20);
            this.txtusuario.TabIndex = 4;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(180, 143);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(100, 20);
            this.txtcontraseña.TabIndex = 5;
            // 
            // btbcrear
            // 
            this.btbcrear.Location = new System.Drawing.Point(25, 181);
            this.btbcrear.Name = "btbcrear";
            this.btbcrear.Size = new System.Drawing.Size(105, 23);
            this.btbcrear.TabIndex = 6;
            this.btbcrear.Text = "Crear";
            this.btbcrear.UseVisualStyleBackColor = true;
            // 
            // btblimpiar
            // 
            this.btblimpiar.Location = new System.Drawing.Point(180, 181);
            this.btblimpiar.Name = "btblimpiar";
            this.btblimpiar.Size = new System.Drawing.Size(75, 23);
            this.btblimpiar.TabIndex = 7;
            this.btblimpiar.Text = "Limpiar";
            this.btblimpiar.UseVisualStyleBackColor = true;
            // 
            // lbltipousuario
            // 
            this.lbltipousuario.AutoSize = true;
            this.lbltipousuario.Location = new System.Drawing.Point(315, 52);
            this.lbltipousuario.Name = "lbltipousuario";
            this.lbltipousuario.Size = new System.Drawing.Size(80, 13);
            this.lbltipousuario.TabIndex = 9;
            this.lbltipousuario.Text = "Tipo de usuario";
            // 
            // cmbusuario
            // 
            this.cmbusuario.FormattingEnabled = true;
            this.cmbusuario.Location = new System.Drawing.Point(412, 52);
            this.cmbusuario.Name = "cmbusuario";
            this.cmbusuario.Size = new System.Drawing.Size(121, 21);
            this.cmbusuario.TabIndex = 10;
            this.cmbusuario.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // btbeliminar
            // 
            this.btbeliminar.Location = new System.Drawing.Point(318, 181);
            this.btbeliminar.Name = "btbeliminar";
            this.btbeliminar.Size = new System.Drawing.Size(75, 23);
            this.btbeliminar.TabIndex = 11;
            this.btbeliminar.Text = "Eliminar usuario";
            this.btbeliminar.UseVisualStyleBackColor = true;
            // 
            // UsuariosCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 321);
            this.Controls.Add(this.tdadministracion);
            this.Name = "UsuariosCont";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.UsuariosCont_Load);
            this.tdadministracion.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.TabControl tdadministracion;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbusuario;
        private System.Windows.Forms.Label lbltipousuario;
        private System.Windows.Forms.Button btblimpiar;
        private System.Windows.Forms.Button btbcrear;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btbeliminar;
    }
}