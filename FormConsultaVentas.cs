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
	public partial class FormConsultaVentas : Form
	{
		private Form menu;

		public FormConsultaVentas(Form menu)
		{
			InitializeComponent();
			this.CenterToScreen();

			this.menu = menu;
		}

		private void FormConsultaVentas_Load(object sender, EventArgs e)
		{
			ConexionBD con = new ConexionBD();

			// listas necesarias
			List<OrdenCompraDetalle> detalle = con.listaDetalle();
			List<OrdenCompra> orden = con.listaOrdenes();
			List<Vendedor> vendedor = con.listaVendedores();
			List<Articulo> articulos = con.listaArticulos();

			//se pasan los datos al data grid view
			foreach (OrdenCompraDetalle od in detalle)
			{
				int idOrden = od.IdOrden;
				OrdenCompra ordenTemp = orden.FirstOrDefault(o => o.IdOrden == idOrden);

				DateTime fecha = ordenTemp.Fecha;
				int idArticulo = od.IdArticulo;
				decimal precioV = od.PrecioVendedor;
				decimal precioF = od.PrecioFinal;
				int cantidad = od.CantidadArticulo;

				Vendedor vendedorTemp = vendedor.FirstOrDefault(v => v.Identificacion == ordenTemp.Identificacion);
				string nombre = vendedorTemp.Nombre + " " + vendedorTemp.PrimerApellido + " " + vendedorTemp.SegundoApellido;

				Articulo articuloTemp = articulos.FirstOrDefault(a => a.IdArticulo == od.IdArticulo);

				//se crea un arreglo de objetos
				Object[] fila = { od.IdOrden, fecha.ToString("dd/MM/yyyy"), nombre, articuloTemp.Descripcion, od.CantidadArticulo, precioV, precioF };

				//se agregan los artículos en el data grid view
				tablaVentas.Rows.Add(fila);
			}
		}

		private void btnVolver_Click(object sender, EventArgs e)
		{
			this.Close();
			menu.Visible = true;
		}

		//si cierra la ventana
		private void FormConsultaVentas_FormClosed(object sender, FormClosedEventArgs e)
		{
			menu.Visible = true;
		}
	}
}
