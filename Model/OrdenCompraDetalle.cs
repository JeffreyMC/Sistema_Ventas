//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Faro.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrdenCompraDetalle
    {
        public int IdDetalle { get; set; }
        public int IdOrden { get; set; }
        public int IdArticulo { get; set; }
        public int CantidadArticulo { get; set; }
        public decimal PrecioVendedor { get; set; }
        public decimal PrecioFinal { get; set; }
    
        public virtual Articulo Articulo { get; set; }
        public virtual OrdenCompra OrdenCompra { get; set; }
    }
}
