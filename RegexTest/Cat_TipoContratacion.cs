//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegexTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cat_TipoContratacion
    {
        public Cat_TipoContratacion()
        {
            this.ContratoArrto = new HashSet<ContratoArrto>();
        }
    
        public byte IdTipoContratacion { get; set; }
        public string DescripcionTipoContratacion { get; set; }
        public bool EstatusRegistro { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public int Fk_IdUsuarioRegistro { get; set; }
        public Nullable<int> Orden { get; set; }
    
        public virtual ICollection<ContratoArrto> ContratoArrto { get; set; }
    }
}
