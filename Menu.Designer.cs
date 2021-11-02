namespace Faro
{
	partial class Menu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
			this.label2 = new System.Windows.Forms.Label();
			this.btnAddArticulo = new System.Windows.Forms.Button();
			this.btnAddVendedor = new System.Windows.Forms.Button();
			this.btnVenta = new System.Windows.Forms.Button();
			this.btnConsultaVenta = new System.Windows.Forms.Button();
			this.btnConsultaInventario = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnActualizarArticulo = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label2.Location = new System.Drawing.Point(200, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(233, 42);
			this.label2.TabIndex = 0;
			this.label2.Text = "Ventas Faro";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnAddArticulo
			// 
			this.btnAddArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
			this.btnAddArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddArticulo.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnAddArticulo.Location = new System.Drawing.Point(442, 93);
			this.btnAddArticulo.Name = "btnAddArticulo";
			this.btnAddArticulo.Size = new System.Drawing.Size(121, 49);
			this.btnAddArticulo.TabIndex = 1;
			this.btnAddArticulo.Text = "Registrar artículo";
			this.btnAddArticulo.UseVisualStyleBackColor = false;
			this.btnAddArticulo.Click += new System.EventHandler(this.btnAddArticulo_Click);
			// 
			// btnAddVendedor
			// 
			this.btnAddVendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
			this.btnAddVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddVendedor.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnAddVendedor.Location = new System.Drawing.Point(442, 234);
			this.btnAddVendedor.Name = "btnAddVendedor";
			this.btnAddVendedor.Size = new System.Drawing.Size(121, 49);
			this.btnAddVendedor.TabIndex = 2;
			this.btnAddVendedor.Text = "Registrar Vendedor";
			this.btnAddVendedor.UseVisualStyleBackColor = false;
			this.btnAddVendedor.Click += new System.EventHandler(this.btnAddVendedor_Click);
			// 
			// btnVenta
			// 
			this.btnVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
			this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVenta.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnVenta.Location = new System.Drawing.Point(442, 304);
			this.btnVenta.Name = "btnVenta";
			this.btnVenta.Size = new System.Drawing.Size(121, 49);
			this.btnVenta.TabIndex = 3;
			this.btnVenta.Text = "Registrar Venta";
			this.btnVenta.UseVisualStyleBackColor = false;
			this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
			// 
			// btnConsultaVenta
			// 
			this.btnConsultaVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
			this.btnConsultaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConsultaVenta.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnConsultaVenta.Location = new System.Drawing.Point(442, 377);
			this.btnConsultaVenta.Name = "btnConsultaVenta";
			this.btnConsultaVenta.Size = new System.Drawing.Size(121, 49);
			this.btnConsultaVenta.TabIndex = 4;
			this.btnConsultaVenta.Text = "Consultar Venta";
			this.btnConsultaVenta.UseVisualStyleBackColor = false;
			this.btnConsultaVenta.Click += new System.EventHandler(this.btnConsultaVenta_Click);
			// 
			// btnConsultaInventario
			// 
			this.btnConsultaInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
			this.btnConsultaInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConsultaInventario.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnConsultaInventario.Location = new System.Drawing.Point(442, 447);
			this.btnConsultaInventario.Name = "btnConsultaInventario";
			this.btnConsultaInventario.Size = new System.Drawing.Size(121, 49);
			this.btnConsultaInventario.TabIndex = 5;
			this.btnConsultaInventario.Text = "Consultar Inventario";
			this.btnConsultaInventario.UseVisualStyleBackColor = false;
			this.btnConsultaInventario.Click += new System.EventHandler(this.btnConsultaInventario_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Image = global::Faro.Properties.Resources.icon;
			this.pictureBox2.Location = new System.Drawing.Point(39, 93);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(100, 78);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 7;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::Faro.Properties.Resources.faroimg;
			this.pictureBox1.Image = global::Faro.Properties.Resources.faroimg;
			this.pictureBox1.Location = new System.Drawing.Point(39, 93);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(353, 403);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// btnActualizarArticulo
			// 
			this.btnActualizarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
			this.btnActualizarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnActualizarArticulo.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnActualizarArticulo.Location = new System.Drawing.Point(442, 163);
			this.btnActualizarArticulo.Name = "btnActualizarArticulo";
			this.btnActualizarArticulo.Size = new System.Drawing.Size(121, 49);
			this.btnActualizarArticulo.TabIndex = 8;
			this.btnActualizarArticulo.Text = "Actualizar artículo";
			this.btnActualizarArticulo.UseVisualStyleBackColor = false;
			this.btnActualizarArticulo.Click += new System.EventHandler(this.btnActualizarArticulo_Click);
			// 
			// Menu
			// 
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
			this.ClientSize = new System.Drawing.Size(616, 531);
			this.Controls.Add(this.btnActualizarArticulo);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnConsultaInventario);
			this.Controls.Add(this.btnConsultaVenta);
			this.Controls.Add(this.btnVenta);
			this.Controls.Add(this.btnAddVendedor);
			this.Controls.Add(this.btnAddArticulo);
			this.Controls.Add(this.label2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Menu";
			this.Load += new System.EventHandler(this.Menu_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnAddArticulo;
		private System.Windows.Forms.Button btnAddVendedor;
		private System.Windows.Forms.Button btnVenta;
		private System.Windows.Forms.Button btnConsultaVenta;
		private System.Windows.Forms.Button btnConsultaInventario;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button btnActualizarArticulo;
	}
}

