﻿using System;
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
	}
}
