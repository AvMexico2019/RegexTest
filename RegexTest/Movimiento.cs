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
    
    public partial class Movimiento
    {
        public int IdMovimiento { get; set; }
        public int FK_IdAplicacionConcepto { get; set; }
        public int Fk_IdConcAccesibilidad { get; set; }
        public Nullable<bool> Aplica { get; set; }
        public Nullable<bool> Existe { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<bool> SeRequiere { get; set; }
        public Nullable<bool> Cumple { get; set; }
        public string Observaciones { get; set; }
        public bool EstatusRegistro { get; set; }
        public int Fk_IdUsuarioRegistro { get; set; }
        public System.DateTime FechaRegistro { get; set; }
    
        public virtual AplicacionConcepto AplicacionConcepto { get; set; }
        public virtual ConceptoAccesibilidad ConceptoAccesibilidad { get; set; }
    }
}