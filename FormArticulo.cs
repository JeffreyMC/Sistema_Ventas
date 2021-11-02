using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Faro.Model; //utilizar el modelo de base de datos

namespace Faro
{
	public partial class FormArticulo : Form
	{
		private Form menu;
		public FormArticulo(Form menu)
		{
			InitializeComponent();
			this.CenterToScreen();

			//inicializa el menú (está escondido)
			this.menu = menu;
		}

		private void btnAddArticulo_Click(object sender, EventArgs e)
		{
			ConexionBD con = new ConexionBD();
			//valida la conexión a la base de datos
			if (!con.validaConexion())
			{
				MessageBox.Show("Error en conexión a la base de datos. Verifique la ruta");
			}
			//si no hay campos vacíos
			else if (validaCamposLlenos())
			{
				//se verifican los checkboxes
				bool activo;
				if (rb1.Checked)
					activo = true;
				else
					activo = false;

				//se crea un objeto de tipo Artículo
				Articulo art = new Articulo();

				//se crea un ID de forma aleatoria del 1 al 1000
				Random rnd = new Random();

				//se itera hasta que el ID sea único
				int id = 0;
				bool existe = true;
				do
				{
					id = rnd.Next(1, 1000);

					if (!con.existeArticulo(id))
					{
						existe = false; // si no existe el id sale del ciclo
					}

				} while (existe);

				//se llenan los datos del objeto
				art.IdArticulo = id;
				art.Activo = activo;
				art.Descripcion = txtDescripcion.Text;
				art.PrecioVendedor = decimal.Parse(txtPrecioVendedor.Text);
				art.PrecioFinal = decimal.Parse(txtPrecioFinal.Text);
				art.CantidadDisponible = int.Parse(txtCantidadDisponible.Text);

				//se llama a la base de datos
				using (FaroEntities context = new FaroEntities())
				{
					context.Articuloes.Add(art);

					//se guardan los cambios en la base de datos
					context.SaveChanges();

					MessageBox.Show("Artículo guardado éxitosamente");

					limpiar();
				}
			}
			else
			{
				//Se muestra un mensaje indicando que debe ingresar todos los datos
				MessageBox.Show("Debe llenar todos los campos");
				//se limpian los campos
				limpiar();
			}
		}


		//métodos que validan que se escriban solo números
		private void txtCantidadDisponible_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
				(e.KeyChar != '.'))
			{
				e.Handled = true;
			}
		}

		private void txtPrecioFinal_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
				(e.KeyChar != '.'))
			{
				e.Handled = true;
			}
		}

		private void txtPrecioVendedor_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
				(e.KeyChar != '.'))
			{
				e.Handled = true;
			}
		}

		//método que limpia los campos
		private void limpiar()
		{
			txtCantidadDisponible.Text = "";
			txtPrecioVendedor.Text = "";
			txtPrecioFinal.Text = "";
			txtDescripcion.Text = "";
		}

		private void btnVolver_Click(object sender, EventArgs e)
		{
			//cierra el formulario
			this.Close();
			//hace visible el formulario del menú
			menu.Visible = true;
		}


		private bool validaCamposLlenos()
		{
			if (txtDescripcion.Text.Equals("") || txtPrecioFinal.Text.Equals("") ||
				txtPrecioVendedor.Text.Equals("") || txtCantidadDisponible.Text.Equals(""))
				return false;

			return true; //si los campos están llenos devuelve true
		}

		private void FormArticulo_FormClosed(object sender, FormClosedEventArgs e)
		{
			menu.Visible = true;
		}
	}
}
