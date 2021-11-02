namespace Faro
{
	partial class FormActualizarArticulo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActualizarArticulo));
			this.btnVolver = new System.Windows.Forms.Button();
			this.btnAddArticulo = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtPrecioFinal = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPrecioVendedor = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCantidadDisponible = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rb2 = new System.Windows.Forms.RadioButton();
			this.rb1 = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnVolver
			// 
			this.btnVolver.BackColor = System.Drawing.Color.SeaGreen;
			this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVolver.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnVolver.Location = new System.Drawing.Point(575, 46);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Size = new System.Drawing.Size(130, 32);
			this.btnVolver.TabIndex = 18;
			this.btnVolver.Text = "Volver al menú";
			this.btnVolver.UseVisualStyleBackColor = false;
			this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
			// 
			// btnAddArticulo
			// 
			this.btnAddArticulo.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnAddArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddArticulo.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnAddArticulo.Location = new System.Drawing.Point(20, 456);
			this.btnAddArticulo.Name = "btnAddArticulo";
			this.btnAddArticulo.Size = new System.Drawing.Size(183, 45);
			this.btnAddArticulo.TabIndex = 17;
			this.btnAddArticulo.Text = "Actualizar Artículo";
			this.btnAddArticulo.UseVisualStyleBackColor = false;
			this.btnAddArticulo.Click += new System.EventHandler(this.btnAddArticulo_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.txtPrecioFinal);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtPrecioVendedor);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtCantidadDisponible);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtDescripcion);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(20, 170);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(685, 254);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			// 
			// txtPrecioFinal
			// 
			this.txtPrecioFinal.Location = new System.Drawing.Point(393, 113);
			this.txtPrecioFinal.Name = "txtPrecioFinal";
			this.txtPrecioFinal.Size = new System.Drawing.Size(239, 20);
			this.txtPrecioFinal.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label6.Location = new System.Drawing.Point(390, 87);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 16);
			this.label6.TabIndex = 8;
			this.label6.Text = "Precio final";
			// 
			// txtPrecioVendedor
			// 
			this.txtPrecioVendedor.Location = new System.Drawing.Point(393, 35);
			this.txtPrecioVendedor.Name = "txtPrecioVendedor";
			this.txtPrecioVendedor.Size = new System.Drawing.Size(239, 20);
			this.txtPrecioVendedor.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label5.Location = new System.Drawing.Point(390, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(108, 16);
			this.label5.TabIndex = 6;
			this.label5.Text = "Precio vendedor";
			// 
			// txtCantidadDisponible
			// 
			this.txtCantidadDisponible.Location = new System.Drawing.Point(26, 194);
			this.txtCantidadDisponible.Name = "txtCantidadDisponible";
			this.txtCantidadDisponible.Size = new System.Drawing.Size(239, 20);
			this.txtCantidadDisponible.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label4.Location = new System.Drawing.Point(23, 165);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 16);
			this.label4.TabIndex = 4;
			this.label4.Text = "Cantidad disponible";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(26, 35);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(239, 20);
			this.txtDescripcion.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label2.Location = new System.Drawing.Point(23, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Descripción";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Faro.Properties.Resources.icons8_product_480px_1;
			this.pictureBox1.Location = new System.Drawing.Point(20, 36);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(41, 42);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label1.Location = new System.Drawing.Point(67, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(175, 24);
			this.label1.TabIndex = 14;
			this.label1.Text = "Actualizar artículo";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label7.Location = new System.Drawing.Point(17, 105);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(89, 16);
			this.label7.TabIndex = 12;
			this.label7.Text = "ID del artículo";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(112, 104);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(91, 20);
			this.txtId.TabIndex = 12;
			this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.Brown;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnBuscar.Location = new System.Drawing.Point(224, 97);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(86, 32);
			this.btnBuscar.TabIndex = 19;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rb2);
			this.groupBox2.Controls.Add(this.rb1);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
			this.groupBox2.Location = new System.Drawing.Point(26, 80);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 58);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Activo";
			// 
			// rb2
			// 
			this.rb2.AutoSize = true;
			this.rb2.Location = new System.Drawing.Point(111, 26);
			this.rb2.Name = "rb2";
			this.rb2.Size = new System.Drawing.Size(46, 20);
			this.rb2.TabIndex = 1;
			this.rb2.Text = "NO";
			this.rb2.UseVisualStyleBackColor = true;
			// 
			// rb1
			// 
			this.rb1.AutoSize = true;
			this.rb1.Checked = true;
			this.rb1.Location = new System.Drawing.Point(55, 26);
			this.rb1.Name = "rb1";
			this.rb1.Size = new System.Drawing.Size(38, 20);
			this.rb1.TabIndex = 0;
			this.rb1.TabStop = true;
			this.rb1.Text = "SÍ";
			this.rb1.UseVisualStyleBackColor = true;
			// 
			// FormActualizarArticulo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
			this.ClientSize = new System.Drawing.Size(738, 523);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.btnAddArticulo);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormActualizarArticulo";
			this.Text = "Actualizar artículo";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormActualizarArticulo_FormClosed);
			this.Load += new System.EventHandler(this.FormActualizarArticulo_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnVolver;
		private System.Windows.Forms.Button btnAddArticulo;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtPrecioFinal;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPrecioVendedor;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtCantidadDisponible;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rb2;
		private System.Windows.Forms.RadioButton rb1;
	}
}