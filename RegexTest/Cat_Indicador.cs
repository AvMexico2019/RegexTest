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
    
    public partial class Cat_Indicador
    {
        public Cat_Indicador()
        {
            this.ConceptoAccesibilidad = new HashSet<ConceptoAccesibilidad>();
        }
    
        public int IdIndicador { get; set; }
        public string DescripcionIndicador { get; set; }
        public int PorcentajeIndica { get; set; }
        public bool EstatusRegistro { get; set; }
        public int Fk_IdUsuarioRegistro { get; set; }
        public System.DateTime FechaRegistro { get; set; }
    
        public virtual ICollection<ConceptoAccesibilidad> ConceptoAccesibilidad { get; set; }
    }
}
