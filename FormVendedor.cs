﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Faro.Model;

namespace Faro
{
	public partial class FormVendedor : Form
	{
		private Form menu;

		public FormVendedor(Form menu)
		{
			InitializeComponent();
			this.CenterToScreen(); //centra la ventana
								   // menú principal (está escondido)
			this.menu = menu;
		}

		//valida los checkboxes de sexo (masculino y femenino)
		private void checkBoxM_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxM.Checked)
				checkBoxF.CheckState = CheckState.Unchecked;
		}

		private void checkBoxF_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxF.Checked)
				checkBoxM.CheckState = CheckState.Unchecked;

		}

		//función que verifica si el ID de vendedor existe
		public bool existeID(string id)
		{
			using (FaroEntities context = new FaroEntities())
			{
				//obtiene el vendedor de la base de datos
				var articulo = context.Vendedors.FirstOrDefault(a => a.Identificacion.Equals(id));

				if (articulo != null)
					return true; //si existe el artículo retorna true
				return false; //si no existe retorna false
			}
		}

		//vuelve al menú principal
		private void btnVolver_Click(object sender, EventArgs e)
		{
			this.Close();
			menu.Visible = true;
		}

		//registra un vendedor
		private void btnAddVendedor_Click(object sender, EventArgs e)
		{
			ConexionBD con = new ConexionBD();
			if (!con.validaConexion())
			{
				MessageBox.Show("Error en conexión a la base de datos. Verifique la ruta");
			}
			//verifica que el ID no exista
			else if (existeID(txtId.Text))
			{
				MessageBox.Show("Ya existe´la identificación " + txtId.Text);

				//solo limpia el campo de identificacion
				txtId.Text = "";
			}
			else if (!validaCamposBlanco())
			{
				MessageBox.Show("Debe llenar todos los campos");
				limpiar();
			}
			else
			{
				//crear un objeto de tipo vendedor para luego almacenarlo en la BD
				Vendedor vendedor = new Vendedor();

				//se validan los checkboxes
				if (checkBoxM.Checked)
					vendedor.Genero = "M";
				else
					vendedor.Genero = "F";

				//se llenan los demás valores
				vendedor.Identificacion = txtId.Text;
				vendedor.Nombre = txtNombre.Text;
				vendedor.PrimerApellido = txtApellido1.Text;
				vendedor.SegundoApellido = txtApellido2.Text;
				vendedor.FechaNacimiento = fechaNac.Value;
				vendedor.FechaIngreso = fechaIngreso.Value;

				//se agrega el valor a la base de datos
				using (FaroEntities context = new FaroEntities())
				{
					context.Vendedors.Add(vendedor);
					//se guardan los cambios
					context.SaveChanges();

					MessageBox.Show("Vendedor guardado éxitosamente");
				}

				limpiar(); // limpia los campos

			}

		}
		private bool validaCamposBlanco()
		{
			if (txtNombre.Text.Equals("") || txtId.Text.Equals("") || txtApellido1.Text.Equals("") ||
				txtApellido2.Text.Equals(""))
				return false;

			return true; //si los campos están llenos devuelve true
		}

		//limpia los campos
		private void limpiar()
		{
			txtId.Text = "";
			txtNombre.Text = "";
			txtApellido1.Text = "";
			txtApellido2.Text = "";
			checkBoxM.Checked = true; checkBoxF.Checked = false;
			fechaNac.Value = DateTime.Today;
			fechaIngreso.Value = DateTime.Today;
		}

		private void FormVendedor_FormClosed(object sender, FormClosedEventArgs e)
		{
			menu.Visible = true;
		}
	}
}
