using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faro.Model;

namespace Faro
{
	class ConexionBD
	{
		public ConexionBD() { }

		//valida la conexión a la base de datos
		public bool validaConexion()
		{
			using (FaroEntities context = new FaroEntities())
			{
				bool respuesta = context.Database.Exists();

				if (respuesta)
					return true; //si la conexión existe devuelve true
			}

			return false; // devuelve false si la conexión no existe
		}

		//retorna lista de vendedores
		public List<Vendedor> listaVendedores()
		{
			List<Vendedor> lista;

			using (FaroEntities context = new FaroEntities())
			{
				lista = context.Vendedors.ToList();
			}

			return lista;
		}

		//retorna lista de artículos
		public List<Articulo> listaArticulos()
		{
			List<Articulo> lista;

			using (FaroEntities context = new FaroEntities())
			{
				lista = context.Articuloes.ToList();
			}

			return lista;
		}

		//retorna la lista de detalles de compra
		public List<OrdenCompraDetalle> listaDetalle()
		{
			List<OrdenCompraDetalle> lista;

			using (FaroEntities context = new FaroEntities())
			{
				lista = context.OrdenCompraDetalles.ToList();
			}

			return lista;
		}

		//retorna la lista de órdenes de compra
		public List<OrdenCompra> listaOrdenes()
		{
			List<OrdenCompra> lista;

			using (FaroEntities context = new FaroEntities())
			{
				lista = context.OrdenCompras.ToList();
			}

			return lista;
		}

		//retorna la cantidad de detalles de compra
		public int cantidadDetalles()
		{
			int cantidad = 0;

			using (FaroEntities context = new FaroEntities())
			{
				cantidad = context.OrdenCompraDetalles.Count();
			}

			return cantidad;
		}

		//devuelve true si la cantidad de artículos es mayor a 0
		public bool cantidadArticulos()
		{
			using (FaroEntities context = new FaroEntities())
			{
				int contador = context.Articuloes.Count();

				if (contador > 0)
					return true; //si encuentra al menos 1 registro devuelve true

				return false; //si no hay registros devuelve false
			}
		}

		//valida que exista al menos un vendedor
		public bool cantidadVendedores()
		{
			using (FaroEntities context = new FaroEntities())
			{
				int contador = context.Vendedors.Count();

				if (contador > 0)
					return true; //si encuentra al menos 1 registro devuelve true

				return false; //si no hay registros devuelve false
			}
		}

		//valida que exista un artículo
		public bool existeArticulo(int id)
		{
			Articulo art;

			using (FaroEntities context = new FaroEntities())
			{
				art = context.Articuloes.FirstOrDefault(a => a.IdArticulo == id);
			}

			if (art == null)
				return false;

			return true; //si existe devuelve true

		}

		//función que verifica si el ID de vendedor existe
		public bool existeVendedor(string id)
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
	}
}
