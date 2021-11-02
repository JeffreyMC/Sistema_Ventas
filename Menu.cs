using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faro
{
	public partial class Menu : Form
	{

		public Menu()
		{
			InitializeComponent();
			this.CenterToScreen();
		}

		private void Menu_Load(object sender, EventArgs e)
		{

		}

		private void btnAddArticulo_Click(object sender, EventArgs e)
		{
			//formulario de artículo // se le pasa por argumento este formulario
			FormArticulo formArticulo = new FormArticulo(this);
			//se esconde el formulario actual
			this.Hide();
			//se hace visible el formulario artículo
			formArticulo.ShowDialog();
		}

		private void btnAddVendedor_Click(object sender, EventArgs e)
		{
			//formulario de vendedor //se le pasa por argumento
			FormVendedor vendedor = new FormVendedor(this);
			//se esconde el formulario del menú
			this.Hide();
			//se hace visible el formulario del vendedor
			vendedor.ShowDialog();
		}

		private void btnVenta_Click(object sender, EventArgs e)
		{
			//formulario de venta //se le pasa por argumento
			FormVenta venta = new FormVenta(this);
			//se esconde el formulario del menú
			this.Hide();
			//se hace visible el formulario de venta
			venta.ShowDialog();
		}

		private void btnConsultaInventario_Click(object sender, EventArgs e)
		{
			//formulario de consulta de inventario //se le pasa por argumento
			FormConsultaArticulos inventario = new FormConsultaArticulos(this);
			//se esconde el formulario del menú
			this.Hide();
			//se hace visible el formulario de venta
			inventario.ShowDialog();
		}

		private void btnConsultaVenta_Click(object sender, EventArgs e)
		{
			//formulario de consulta de ventas //se le pasa por argumento
			FormConsultaVentas ventas = new FormConsultaVentas(this);
			//se esconde el formulario del menú
			this.Hide();
			//se hace visible el formulario de venta
			ventas.ShowDialog();
		}

		private void btnActualizarArticulo_Click(object sender, EventArgs e)
		{
			//formulario de actualización de artículos //se le pasa por argumento
			FormActualizarArticulo ventas = new FormActualizarArticulo(this);
			//se esconde el formulario del menú
			this.Hide();
			//se hace visible el formulario de venta
			ventas.ShowDialog();
		}
	}
}
