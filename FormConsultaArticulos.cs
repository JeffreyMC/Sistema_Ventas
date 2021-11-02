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
	public partial class FormConsultaArticulos : Form
	{
		private Form menu;
		public FormConsultaArticulos(Form menu)
		{
			InitializeComponent();
			this.CenterToScreen();
			this.menu = menu;
		}

		private void FormConsultaArticulos_Load(object sender, EventArgs e)
		{
			ConexionBD con = new ConexionBD();

			//llena el datagridview
			//se obtienen los artículos
			List<Articulo> articulos = con.listaArticulos();

			//se llena el datagridview
			foreach (Articulo a in articulos)
			{
				//se cambia los valores de Activo de TRUE y FALSE a SÍ y NO
				//para que sea más comprensible
				string activo = "";
				if (a.Activo)
				{
					activo = "SÍ";
				}
				else
					activo = "NO";

				//se crea un arreglo de objetos con los datos de la lista
				Object[] fila = { a.IdArticulo, a.Descripcion, activo, a.PrecioVendedor, a.PrecioFinal, a.CantidadDisponible };
				//se llenan las filas
				tablaArticulos.Rows.Add(fila);
			}
		}

		private void btnVolver_Click(object sender, EventArgs e)
		{
			this.Close();
			menu.Visible = true;
		}

		//si cierra la ventana
		private void FormConsultaArticulos_FormClosed(object sender, FormClosedEventArgs e)
		{
			menu.Visible = true;
		}
	}
}