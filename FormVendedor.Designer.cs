namespace Faro
{
	partial class FormVendedor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVendedor));
			this.btnAddVendedor = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.fechaIngreso = new System.Windows.Forms.DateTimePicker();
			this.fechaNac = new System.Windows.Forms.DateTimePicker();
			this.txtApellido2 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.checkBoxF = new System.Windows.Forms.CheckBox();
			this.checkBoxM = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtApellido1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnVolver = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAddVendedor
			// 
			this.btnAddVendedor.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnAddVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddVendedor.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnAddVendedor.Location = new System.Drawing.Point(529, 403);
			this.btnAddVendedor.Name = "btnAddVendedor";
			this.btnAddVendedor.Size = new System.Drawing.Size(183, 45);
			this.btnAddVendedor.TabIndex = 16;
			this.btnAddVendedor.Text = "Registrar Vendedor";
			this.btnAddVendedor.UseVisualStyleBackColor = false;
			this.btnAddVendedor.Click += new System.EventHandler(this.btnAddVendedor_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.fechaIngreso);
			this.groupBox1.Controls.Add(this.fechaNac);
			this.groupBox1.Controls.Add(this.txtApellido2);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtNombre);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.checkBoxF);
			this.groupBox1.Controls.Add(this.checkBoxM);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtApellido1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtId);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(27, 83);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(685, 314);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			// 
			// fechaIngreso
			// 
			this.fechaIngreso.Location = new System.Drawing.Point(393, 193);
			this.fechaIngreso.Name = "fechaIngreso";
			this.fechaIngreso.Size = new System.Drawing.Size(239, 20);
			this.fechaIngreso.TabIndex = 17;
			// 
			// fechaNac
			// 
			this.fechaNac.Location = new System.Drawing.Point(393, 34);
			this.fechaNac.Name = "fechaNac";
			this.fechaNac.Size = new System.Drawing.Size(239, 20);
			this.fechaNac.TabIndex = 16;
			// 
			// txtApellido2
			// 
			this.txtApellido2.Location = new System.Drawing.Point(26, 276);
			this.txtApellido2.Name = "txtApellido2";
			this.txtApellido2.Size = new System.Drawing.Size(239, 20);
			this.txtApellido2.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label8.Location = new System.Drawing.Point(23, 247);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(116, 16);
			this.label8.TabIndex = 14;
			this.label8.Text = "Segundo Apellido";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(26, 113);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(239, 20);
			this.txtNombre.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label7.Location = new System.Drawing.Point(23, 87);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 16);
			this.label7.TabIndex = 12;
			this.label7.Text = "Nombre";
			// 
			// checkBoxF
			// 
			this.checkBoxF.AutoSize = true;
			this.checkBoxF.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.checkBoxF.Location = new System.Drawing.Point(435, 116);
			this.checkBoxF.Name = "checkBoxF";
			this.checkBoxF.Size = new System.Drawing.Size(32, 17);
			this.checkBoxF.TabIndex = 11;
			this.checkBoxF.Text = "F";
			this.checkBoxF.UseVisualStyleBackColor = true;
			this.checkBoxF.CheckedChanged += new System.EventHandler(this.checkBoxF_CheckedChanged);
			// 
			// checkBoxM
			// 
			this.checkBoxM.AutoSize = true;
			this.checkBoxM.Checked = true;
			this.checkBoxM.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxM.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.checkBoxM.Location = new System.Drawing.Point(393, 116);
			this.checkBoxM.Name = "checkBoxM";
			this.checkBoxM.Size = new System.Drawing.Size(35, 17);
			this.checkBoxM.TabIndex = 10;
			this.checkBoxM.Text = "M";
			this.checkBoxM.UseVisualStyleBackColor = true;
			this.checkBoxM.CheckedChanged += new System.EventHandler(this.checkBoxM_CheckedChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label6.Location = new System.Drawing.Point(390, 165);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(94, 16);
			this.label6.TabIndex = 8;
			this.label6.Text = "Fecha ingreso";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label5.Location = new System.Drawing.Point(390, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(133, 16);
			this.label5.TabIndex = 6;
			this.label5.Text = "Fecha de nacimiento";
			// 
			// txtApellido1
			// 
			this.txtApellido1.Location = new System.Drawing.Point(26, 194);
			this.txtApellido1.Name = "txtApellido1";
			this.txtApellido1.Size = new System.Drawing.Size(239, 20);
			this.txtApellido1.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label4.Location = new System.Drawing.Point(23, 165);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 16);
			this.label4.TabIndex = 4;
			this.label4.Text = "Primer Apellido";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label3.Location = new System.Drawing.Point(390, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Sexo";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(26, 35);
			this.txtId.MaxLength = 10;
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(239, 20);
			this.txtId.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label2.Location = new System.Drawing.Point(23, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Identificación";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label1.Location = new System.Drawing.Point(74, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(180, 24);
			this.label1.TabIndex = 13;
			this.label1.Text = "Agregar vendedor";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Faro.Properties.Resources.icons8_user_480px;
			this.pictureBox1.Location = new System.Drawing.Point(27, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(41, 42);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// btnVolver
			// 
			this.btnVolver.BackColor = System.Drawing.Color.SeaGreen;
			this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVolver.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnVolver.Location = new System.Drawing.Point(582, 24);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Size = new System.Drawing.Size(130, 32);
			this.btnVolver.TabIndex = 17;
			this.btnVolver.Text = "Volver al menú";
			this.btnVolver.UseVisualStyleBackColor = false;
			this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
			// 
			// FormVendedor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
			this.ClientSize = new System.Drawing.Size(747, 477);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.btnAddVendedor);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormVendedor";
			this.Text = "Registrar Vendedor";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormVendedor_FormClosed);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAddVendedor;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox checkBoxF;
		private System.Windows.Forms.CheckBox checkBoxM;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtApellido1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker fechaNac;
		private System.Windows.Forms.TextBox txtApellido2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker fechaIngreso;
		private System.Windows.Forms.Button btnVolver;
	}
}