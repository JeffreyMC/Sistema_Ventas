namespace Faro
{
	partial class FormVenta
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenta));
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBoxVendedores = new System.Windows.Forms.ComboBox();
			this.listaArticulos = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPrecioVendedor = new System.Windows.Forms.TextBox();
			this.txtPrecioFinal = new System.Windows.Forms.TextBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.ordenCompras = new System.Windows.Forms.DataGridView();
			this.ColumnIdArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAddVenta = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnVolver = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.listaArticulos)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ordenCompras)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label1.Location = new System.Drawing.Point(59, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(153, 24);
			this.label1.TabIndex = 15;
			this.label1.Text = "Registrar Venta";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBoxVendedores);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.groupBox1.Location = new System.Drawing.Point(41, 72);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(270, 82);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Vendedores";
			// 
			// comboBoxVendedores
			// 
			this.comboBoxVendedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxVendedores.FormattingEnabled = true;
			this.comboBoxVendedores.Location = new System.Drawing.Point(6, 31);
			this.comboBoxVendedores.Name = "comboBoxVendedores";
			this.comboBoxVendedores.Size = new System.Drawing.Size(258, 24);
			this.comboBoxVendedores.TabIndex = 0;
			// 
			// listaArticulos
			// 
			this.listaArticulos.AllowUserToAddRows = false;
			this.listaArticulos.AllowUserToDeleteRows = false;
			this.listaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.listaArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
			this.listaArticulos.Location = new System.Drawing.Point(6, 19);
			this.listaArticulos.MultiSelect = false;
			this.listaArticulos.Name = "listaArticulos";
			this.listaArticulos.ReadOnly = true;
			this.listaArticulos.RowHeadersWidth = 20;
			this.listaArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.listaArticulos.Size = new System.Drawing.Size(606, 273);
			this.listaArticulos.TabIndex = 18;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "ID";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Descripción";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Activo";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Precio vendedor";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Precio Final";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Cantidad Disponible";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.listaArticulos);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.groupBox2.Location = new System.Drawing.Point(41, 189);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(618, 305);
			this.groupBox2.TabIndex = 19;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Lista de articulos";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label2.Location = new System.Drawing.Point(15, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(108, 16);
			this.label2.TabIndex = 20;
			this.label2.Text = "Precio vendedor";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label3.Location = new System.Drawing.Point(178, 39);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 16);
			this.label3.TabIndex = 21;
			this.label3.Text = "Precio Final";
			// 
			// txtPrecioVendedor
			// 
			this.txtPrecioVendedor.Location = new System.Drawing.Point(18, 70);
			this.txtPrecioVendedor.Name = "txtPrecioVendedor";
			this.txtPrecioVendedor.ReadOnly = true;
			this.txtPrecioVendedor.Size = new System.Drawing.Size(100, 22);
			this.txtPrecioVendedor.TabIndex = 22;
			// 
			// txtPrecioFinal
			// 
			this.txtPrecioFinal.Location = new System.Drawing.Point(181, 72);
			this.txtPrecioFinal.Name = "txtPrecioFinal";
			this.txtPrecioFinal.ReadOnly = true;
			this.txtPrecioFinal.Size = new System.Drawing.Size(100, 22);
			this.txtPrecioFinal.TabIndex = 23;
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnAgregar.Location = new System.Drawing.Point(673, 286);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(137, 31);
			this.btnAgregar.TabIndex = 24;
			this.btnAgregar.Text = "Agregar orden >>";
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label4.Location = new System.Drawing.Point(710, 341);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 16);
			this.label4.TabIndex = 25;
			this.label4.Text = "Cantidad";
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(688, 360);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(111, 20);
			this.txtCantidad.TabIndex = 26;
			this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.ordenCompras);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.groupBox3.Location = new System.Drawing.Point(822, 189);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(366, 305);
			this.groupBox3.TabIndex = 20;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Orden de Compra";
			// 
			// ordenCompras
			// 
			this.ordenCompras.AllowUserToAddRows = false;
			this.ordenCompras.AllowUserToDeleteRows = false;
			this.ordenCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ordenCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdArticulo,
            this.ColumnDescripcion,
            this.ColumnCantidad});
			this.ordenCompras.Location = new System.Drawing.Point(6, 19);
			this.ordenCompras.Name = "ordenCompras";
			this.ordenCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ordenCompras.Size = new System.Drawing.Size(349, 273);
			this.ordenCompras.TabIndex = 18;
			// 
			// ColumnIdArticulo
			// 
			this.ColumnIdArticulo.HeaderText = "ID";
			this.ColumnIdArticulo.Name = "ColumnIdArticulo";
			// 
			// ColumnDescripcion
			// 
			this.ColumnDescripcion.HeaderText = "Descripción";
			this.ColumnDescripcion.Name = "ColumnDescripcion";
			// 
			// ColumnCantidad
			// 
			this.ColumnCantidad.HeaderText = "Cantidad";
			this.ColumnCantidad.Name = "ColumnCantidad";
			// 
			// btnAddVenta
			// 
			this.btnAddVenta.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnAddVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddVenta.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnAddVenta.Location = new System.Drawing.Point(927, 500);
			this.btnAddVenta.Name = "btnAddVenta";
			this.btnAddVenta.Size = new System.Drawing.Size(183, 45);
			this.btnAddVenta.TabIndex = 27;
			this.btnAddVenta.Text = "Registrar Venta";
			this.btnAddVenta.UseVisualStyleBackColor = false;
			this.btnAddVenta.Click += new System.EventHandler(this.btnAddVenta_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Faro.Properties.Resources.icons8_sale_price_tag_480px;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(41, 42);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 16;
			this.pictureBox1.TabStop = false;
			// 
			// btnVolver
			// 
			this.btnVolver.BackColor = System.Drawing.Color.SeaGreen;
			this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVolver.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnVolver.Location = new System.Drawing.Point(41, 534);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Size = new System.Drawing.Size(130, 32);
			this.btnVolver.TabIndex = 28;
			this.btnVolver.Text = "Volver al menú";
			this.btnVolver.UseVisualStyleBackColor = false;
			this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.txtPrecioVendedor);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Controls.Add(this.txtPrecioFinal);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.groupBox4.Location = new System.Drawing.Point(853, 72);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(307, 111);
			this.groupBox4.TabIndex = 29;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Precios";
			// 
			// FormVenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
			this.ClientSize = new System.Drawing.Size(1231, 590);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.btnAddVenta);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormVenta";
			this.Text = "Consulta de Ventas";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormVenta_FormClosed);
			this.Load += new System.EventHandler(this.FormVenta_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.listaArticulos)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ordenCompras)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox comboBoxVendedores;
		private System.Windows.Forms.DataGridView listaArticulos;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPrecioVendedor;
		private System.Windows.Forms.TextBox txtPrecioFinal;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView ordenCompras;
		private System.Windows.Forms.Button btnAddVenta;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdArticulo;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.Button btnVolver;
		private System.Windows.Forms.GroupBox groupBox4;
	}
}