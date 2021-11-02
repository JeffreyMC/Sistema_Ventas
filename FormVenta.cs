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
	public partial class FormVenta : Form
	{
		private Form menu;
		public FormVenta(Form menu)
		{

			InitializeComponent();
			this.CenterToScreen();

			this.menu = menu;
		}

		private void FormVenta_Load(object sender, EventArgs e)
		{
			ConexionBD con = new ConexionBD();
			//Valida que haya conexión a base de datos
			if (!con.validaConexion())
			{
				MessageBox.Show("Error en conexión a la base de datos. Verifique la ruta");
				this.Close();
				menu.Visible = true;
			}
			// valida que existan vendedores
			if (!existeVendedor())
			{
				MessageBox.Show("No existen vendedores registrados. Debe agregar uno");
				this.Close();
				menu.Visible = true;
			}
			//valida que existan artículos
			if (!existeArticulo())
			{
				MessageBox.Show("No existen artículos registrados. Debe agregar uno");
				this.Close();
				menu.Visible = true;
			}

			//se obtiene la lista de vendedores
			List<Vendedor> vendedores;
			using (FaroEntities context = new FaroEntities())
			{
				vendedores = context.Vendedors.ToList();
			}
			//se carga el drop down list
			foreach (Vendedor v in vendedores)
			{
				comboBoxVendedores.Items.Add(v.Nombre + " " + v.PrimerApellido + " " + v.SegundoApellido);
			}

			//se obtienen los artículos
			List<Articulo> articulos;
			using (FaroEntities context = new FaroEntities())
			{
				articulos = context.Articuloes.ToList();
			}
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
				listaArticulos.Rows.Add(fila);
			}


		}

		//valida que exista al menos un vendedor
		private bool existeVendedor()
		{
			using (FaroEntities context = new FaroEntities())
			{
				int contador = context.Vendedors.Count();

				if (contador > 0)
					return true; //si encuentra al menos 1 registro devuelve true

				return false; //si no hay registros devuelve false
			}
		}

		//valida que exista al menos un artículo
		private bool existeArticulo()
		{
			using (FaroEntities context = new FaroEntities())
			{
				int contador = context.Articuloes.Count();

				if (contador > 0)
					return true; //si encuentra al menos 1 registro devuelve true

				return false; //si no hay registros devuelve false
			}
		}

		//si se cierra la ventana
		private void FormVenta_FormClosed(object sender, FormClosedEventArgs e)
		{
			menu.Visible = true;
		}


		//variables globales de la suma de precio vendedor y precio final
		decimal sumPrecioVendedor = 0;
		decimal sumPrecioFinal = 0;
		//agrega una venta
		private void btnAgregar_Click(object sender, EventArgs e)
		{
			//verifica que el campo de cantidad no esté vacío
			if (txtCantidad.Text.Equals(""))
			{
				MessageBox.Show("Debe indicar la cantidad a vender");
			}
			//valida que la cantidad esté disponible
			else if (validaCantidad())
			{
				//obtiene los datos que tendrá al artículo de la orden
				int id = int.Parse(listaArticulos.SelectedCells[0].Value.ToString());
				string descripcion = listaArticulos.SelectedCells[1].Value.ToString();
				int cantidad = int.Parse(txtCantidad.Text);

				//valida que el artículo no se haya agregado anteriormente
				if (agregadoLista(id))
				{
					MessageBox.Show("El artículo ya está agregado a la lista");
					txtCantidad.Text = "";
				}
				//valida si el artículo está activo
				else if (!validaActivo())
				{
					MessageBox.Show("El artículo no está activo");
					txtCantidad.Text = "";
				}
				else
				{
					//pasa la fila seleccionada al datagridview de orden
					ordenCompras.Rows.Add(id, descripcion, cantidad);

					//se obtiene el precio final y el precio de vendedor multiplicado por la cantidad elegida
					decimal precioV = decimal.Parse(listaArticulos.SelectedCells[3].Value.ToString()) * cantidad;
					decimal precioF = decimal.Parse(listaArticulos.SelectedCells[4].Value.ToString()) * cantidad;

					//se suman los precios de vendedor y precio final
					sumPrecioVendedor += precioV;
					sumPrecioFinal += precioF;

					//se muestra el resultado de la suma en los textboxes correspondientes
					txtPrecioVendedor.Text = sumPrecioVendedor.ToString();
					txtPrecioFinal.Text = sumPrecioFinal.ToString();

					//se actualiza la información en el datagridview de los artículos
					actualizaStock();
					txtCantidad.Text = "";
				}

			}
			else
			{
				MessageBox.Show("La cantidad ingresada sobrepasa la cantidad disponible en stock");
				txtCantidad.Text = "";
			}
		}

		//obliga al usuario a introducir solo números
		private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
				(e.KeyChar != '.'))
			{
				e.Handled = true;
			}
		}

		private bool validaCantidad()
		{
			//obtiene la cantidad de artículos en stock
			int stock = int.Parse(listaArticulos.SelectedCells[5].Value.ToString());

			//valida que que haya disponibilidad
			int cant = int.Parse(txtCantidad.Text);
			if (stock - cant < 0)
				return false; //si no hay disponibilidad devuelve false

			return true; //si hay disponibilidad devuelve true
		}

		//actualiza la cantidad en stock
		private void actualizaStock()
		{
			//obtiene la cantidad de artículos en stock
			int stock = int.Parse(listaArticulos.SelectedCells[5].Value.ToString());

			//obtiene la cantidad
			int cant = int.Parse(txtCantidad.Text);

			//se actualiza el datagridview
			listaArticulos.SelectedCells[5].Value = stock - cant;

		}

		//valida que el artículo no haya sido agregado
		private bool agregadoLista(int id)
		{

			if (ordenCompras.Rows.Count > 1)
			{
				foreach (DataGridViewRow fila in ordenCompras.Rows)
				{
					if (fila.Cells["ColumnIdArticulo"].Value == null)
						return false; //si el valor es nulo retorna false
									  //valida si el artículo está en la lista
					if (id == int.Parse(fila.Cells["ColumnIdArticulo"].Value.ToString()))
					{
						return true; //si el artículo está agregado retorna true
					}

				}

			}
			return false; //si el artículo no está agregado retorna false
		}

		//Agrega la venta y actualiza la base de datos
		private void btnAddVenta_Click(object sender, EventArgs e)
		{
			//valida que al menos haya un artículo en la lista
			if (existeArticuloLista())
			{
				//valida que el vendedor esté seleccionado
				if (comboBoxVendedores.SelectedItem == null)
					MessageBox.Show("Debe seleccionar un vendedor de la lista");
				else
				{
					Random rnd = new Random();

					///DATOS DE LA ORDEN///
					int idOrden;
					//valida que no exista un id de orden igual
					bool existeOrden = true;
					do
					{
						idOrden = rnd.Next(1, 10000); //se genera un ID del 1 al 10.000
						if (!existeIdOrden(idOrden))
							existeOrden = false;

					} while (existeOrden);

					//Se obtiene el vendedor seleccionado
					string idVendedor = getIdVendedor();
					//obtiene la fecha actual
					DateTime fecha = DateTime.Today;

					///DATOS DEL DETALLE///
					///
					//se comienza a agregar el detalle a la base de datos
					using (FaroEntities context = new FaroEntities())
					{
						//se egrega la orden a la base de datos
						OrdenCompra orden = new OrdenCompra();
						orden.IdOrden = idOrden;
						orden.Identificacion = idVendedor;
						orden.Fecha = fecha;
						context.OrdenCompras.Add(orden);

						//se crea un ciclo para ir agregando el detalle de la compra
						foreach (DataGridViewRow fila in ordenCompras.Rows)
						{
							OrdenCompraDetalle detalle = new OrdenCompraDetalle();
							int idDetalle;
							//se genera un ID único
							bool existe = true;
							do
							{
								idDetalle = rnd.Next(1, 10000); //se genera un ID del 1 al 10.000

								if (!existeIdDetalle(idDetalle))
									existe = false;
							} while (existe);

							//se llena el objeto Orden Compra detalle
							detalle.IdDetalle = idDetalle;
							detalle.IdOrden = idOrden;


							int cantidad = int.Parse(fila.Cells["ColumnCantidad"].Value.ToString());

							//obtiene lista de artículos
							decimal precioV = 0; ;
							decimal precioF = 0;
							int idArt;
							foreach (DataGridViewRow fila2 in listaArticulos.Rows)
							{
								//se obtiene el id del artículo
								idArt = int.Parse(fila.Cells["ColumnIdArticulo"].Value.ToString());
								detalle.IdArticulo = idArt;

								if (int.Parse(fila2.Cells["Column1"].Value.ToString()) == idArt)
								{
									precioV = decimal.Parse(fila2.Cells["Column4"].Value.ToString());
									//se multiplica por la cantidad de artículos
									precioV *= cantidad;
									precioF = decimal.Parse(fila2.Cells["Column5"].Value.ToString());
									//se multiplica por los artículos
									precioF *= cantidad;

									//se actualiza la cantidad disponible en base de datos
									Articulo nuevaCantidad = context.Articuloes.SingleOrDefault(a => a.IdArticulo == idArt);
									nuevaCantidad.CantidadDisponible = int.Parse(fila2.Cells["Column6"].Value.ToString());
									//guarda los cambios
									context.SaveChanges();
								}
							}
							//se llena el resto de valores
							detalle.CantidadArticulo = cantidad;
							detalle.PrecioVendedor = precioV;
							detalle.PrecioFinal = precioF;

							//se guarda en la base de datos
							context.OrdenCompraDetalles.Add(detalle);

							//se guardan los demás cambios en la BDD
							context.SaveChanges();

						}
					}


					//envía un mensaje de éxito
					MessageBox.Show("Venta agregada exitósamente");
					limpiar(); //limpia los campos
				}
			}
			else
			{
				MessageBox.Show("Debe agregar al menos un artículo a la orden");
			}
		}

		//valida que exista al menos un artículo en la lista
		private bool existeArticuloLista()
		{
			if (ordenCompras.Rows.Count > 0)
				return true; //retorna true si hay artículos
			return false; //retorna false si no hay artículos
		}

		//devuelve el ID del vendedor seleccionado
		private string getIdVendedor()
		{
			string vendedor = comboBoxVendedores.SelectedItem.ToString();

			ConexionBD con = new ConexionBD();
			//obtiene la lista de vendedores
			List<Vendedor> listaVendedores = con.listaVendedores();

			//obtiene el id del vendedor comparado los nombres y apellidos
			foreach (Vendedor v in listaVendedores)
			{
				string nombre = v.Nombre + " " + v.PrimerApellido + " " + v.SegundoApellido;

				if (nombre.Equals(vendedor))
					return v.Identificacion;
			}

			return null;
		}

		//valida que no exista el ID detalle generado
		private bool existeIdDetalle(int id)
		{
			ConexionBD con = new ConexionBD();

			if (con.cantidadDetalles() > 0)
			{
				List<OrdenCompraDetalle> detalleLista = con.listaDetalle();

				foreach (OrdenCompraDetalle o in detalleLista)
				{
					if (o.IdDetalle == id)
						return true;
				}

			}

			return false;
		}

		//valida que no exista el ID ORDEN generado
		private bool existeIdOrden(int id)
		{
			ConexionBD con = new ConexionBD();

			if (con.cantidadDetalles() > 0)
			{
				List<OrdenCompraDetalle> detalleLista = con.listaDetalle();

				foreach (OrdenCompraDetalle o in detalleLista)
				{
					if (o.IdOrden == id)
						return true;
				}

			}

			return false;
		}

		private void limpiar()
		{
			ordenCompras.Rows.Clear();
			txtCantidad.Text = "";
			txtPrecioVendedor.Text = "";
			txtPrecioFinal.Text = "";

		}

		private void btnVolver_Click(object sender, EventArgs e)
		{
			this.Close();
			menu.Visible = true;
		}

		private bool validaActivo()
		{
			string activo = listaArticulos.SelectedCells[2].Value.ToString();

			if (activo.Equals("SÍ"))
				return true; //si está activo retorna true

			return false; //si no está activo retorna false

		}
	}
}
