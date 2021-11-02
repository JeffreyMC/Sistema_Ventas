using System;
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
	public partial class FormActualizarArticulo : Form
	{
		private Form menu;

		public FormActualizarArticulo(Form menu)
		{
			InitializeComponent();
			this.CenterToScreen();

			this.menu = menu;
		}

		private void btnVolver_Click(object sender, EventArgs e)
		{
			this.Close();
			menu.Visible = true;
		}

		//Al cerrar la ventana vuelve al menú
		private void FormActualizarArticulo_FormClosed(object sender, FormClosedEventArgs e)
		{
			menu.Visible = true;
		}

		private void FormActualizarArticulo_Load(object sender, EventArgs e)
		{
			//se deshabilitan los campos hasta que busque el ID
			txtDescripcion.Enabled = false;
			txtCantidadDisponible.Enabled = false;
			txtPrecioVendedor.Enabled = false;
			txtPrecioFinal.Enabled = false;
			checkBoxA.Enabled = false;
			checkBoxD.Enabled = false;
		}

		//valida de que solo se agreguen numeros
		private void txtId_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
				(e.KeyChar != '.'))
			{
				e.Handled = true;
			}
		}

		//busca un articulo
		private void btnBuscar_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtId.Text);

			ConexionBD con = new ConexionBD();

			if (con.existeArticulo(id))
			{
				//se deshabilitan los campos de búsqueda
				txtId.Enabled = false;
				btnBuscar.Enabled = false;
				//se habilitan los campos
				txtPrecioVendedor.Enabled = true;
				txtPrecioFinal.Enabled = true;
				txtCantidadDisponible.Enabled = true;
				checkBoxA.Enabled = true;
				checkBoxD.Enabled = true;

				//se busca el artículo
				Articulo articulo;
				using (FaroEntities context = new FaroEntities())
				{
					articulo = context.Articuloes.FirstOrDefault(a => a.IdArticulo == id);
				}

				//se llenan los campos con los datos
				txtDescripcion.Text = articulo.Descripcion;
				txtPrecioVendedor.Text = articulo.PrecioVendedor.ToString();
				txtPrecioFinal.Text = articulo.PrecioFinal.ToString();
				txtCantidadDisponible.Text = articulo.CantidadDisponible.ToString();
				if (articulo.Activo == true)
					checkBoxA.Checked = true;
				else
					checkBoxD.Checked = true;
			}
			else
			{
				MessageBox.Show("No existe un artículo con el ID: " + id);
				txtId.Text = "";
			}
		}

		//valida las opciones con el check
		private void checkBoxA_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxA.Checked)
				checkBoxD.CheckState = CheckState.Unchecked;
		}

		private void checkBoxD_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxD.Checked)
				checkBoxA.CheckState = CheckState.Unchecked;
		}

		//actualiza el artículo
		private void btnAddArticulo_Click(object sender, EventArgs e)
		{
			//valida que no hayan campos en blanco
			if (validaCamposLlenos())
			{
				//obtiene el id
				int id = int.Parse(txtId.Text);

				//busca el objeto y lo edita
				using (FaroEntities context = new FaroEntities())
				{
					Articulo art = context.Articuloes.FirstOrDefault(a => a.IdArticulo == id);

					//edita las propiedades
					art.PrecioVendedor = decimal.Parse(txtPrecioVendedor.Text);
					art.PrecioFinal = decimal.Parse(txtPrecioFinal.Text);
					art.CantidadDisponible = int.Parse(txtCantidadDisponible.Text);

					if (checkBoxA.Checked)
						art.Activo = true;
					else
						art.Activo = false;

					//GUARDA LOS CAMBIOS EN LA BASE DE DATOS
					context.SaveChanges();

					MessageBox.Show("Artículo actualizado exitosamente");

					//vuelve a deshabilitar los campos
					//se habilitan los campos de búsqueda
					txtId.Text = "";
					txtId.Enabled = true;
					btnBuscar.Enabled = true;
					//se habilitan los campos
					txtDescripcion.Enabled = false;
					txtPrecioVendedor.Enabled = false;
					txtPrecioFinal.Enabled = false;
					txtCantidadDisponible.Enabled = false;
					checkBoxA.Enabled = false;
					checkBoxD.Enabled = false;

					//se reinician los campos
					txtDescripcion.Text = "";
					txtPrecioVendedor.Text = "";
					txtPrecioFinal.Text = "";
					txtCantidadDisponible.Text = "";

				}
			}
			else
			{
				MessageBox.Show("Debe llenar todos los campos");
			}
		}

		private bool validaCamposLlenos()
		{
			if (txtDescripcion.Text.Equals("") || txtPrecioFinal.Text.Equals("") ||
				txtPrecioVendedor.Text.Equals("") || txtCantidadDisponible.Text.Equals(""))
				return false;

			return true; //si los campos están llenos devuelve true
		}
	}
}
