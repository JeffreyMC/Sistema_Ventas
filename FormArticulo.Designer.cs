﻿namespace Faro
{
	partial class FormArticulo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArticulo));
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.txtPrecioFinal = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPrecioVendedor = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCantidadDisponible = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAddArticulo = new System.Windows.Forms.Button();
			this.btnVolver = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label1.Location = new System.Drawing.Point(74, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(159, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Agregar artículo";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Faro.Properties.Resources.icons8_product_480px_1;
			this.pictureBox1.Location = new System.Drawing.Point(27, 23);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(41, 42);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.txtPrecioFinal);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtPrecioVendedor);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtCantidadDisponible);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtDescripcion);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(27, 82);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(685, 254);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.checkBox2.Location = new System.Drawing.Point(68, 115);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(42, 17);
			this.checkBox2.TabIndex = 11;
			this.checkBox2.Text = "NO";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.checkBox1.Location = new System.Drawing.Point(26, 115);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(36, 17);
			this.checkBox1.TabIndex = 10;
			this.checkBox1.Text = "SÍ";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// txtPrecioFinal
			// 
			this.txtPrecioFinal.Location = new System.Drawing.Point(393, 113);
			this.txtPrecioFinal.Name = "txtPrecioFinal";
			this.txtPrecioFinal.Size = new System.Drawing.Size(239, 20);
			this.txtPrecioFinal.TabIndex = 9;
			this.txtPrecioFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioFinal_KeyPress);
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
			this.txtPrecioVendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVendedor_KeyPress);
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
			this.txtCantidadDisponible.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadDisponible_KeyPress);
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
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label3.Location = new System.Drawing.Point(23, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Activo";
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
			// btnAddArticulo
			// 
			this.btnAddArticulo.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnAddArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddArticulo.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnAddArticulo.Location = new System.Drawing.Point(27, 368);
			this.btnAddArticulo.Name = "btnAddArticulo";
			this.btnAddArticulo.Size = new System.Drawing.Size(183, 45);
			this.btnAddArticulo.TabIndex = 12;
			this.btnAddArticulo.Text = "Registrar Artículo";
			this.btnAddArticulo.UseVisualStyleBackColor = false;
			this.btnAddArticulo.Click += new System.EventHandler(this.btnAddArticulo_Click);
			// 
			// btnVolver
			// 
			this.btnVolver.BackColor = System.Drawing.Color.SeaGreen;
			this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVolver.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnVolver.Location = new System.Drawing.Point(582, 33);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Size = new System.Drawing.Size(130, 32);
			this.btnVolver.TabIndex = 13;
			this.btnVolver.Text = "Volver al menú";
			this.btnVolver.UseVisualStyleBackColor = false;
			this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
			// 
			// FormArticulo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
			this.ClientSize = new System.Drawing.Size(751, 457);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.btnAddArticulo);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormArticulo";
			this.Text = "Agregar artículo";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormArticulo_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCantidadDisponible;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox txtPrecioFinal;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPrecioVendedor;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnAddArticulo;
		private System.Windows.Forms.Button btnVolver;
	}
}