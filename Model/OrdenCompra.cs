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
    
    public partial class OrdenCompra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrdenCompra()
        {
            this.OrdenCompraDetalles = new HashSet<OrdenCompraDetalle>();
        }
    
        public int IdOrden { get; set; }
        public string Identificacion { get; set; }
        public System.DateTime Fecha { get; set; }
    
        public virtual Vendedor Vendedor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenCompraDetalle> OrdenCompraDetalles { get; set; }
    }
}
