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
    
    public partial class Convenio_Modificatorio
    {
        public int IdConvenioModif { get; set; }
        public int Fk_IdContratoArrto { get; set; }
        public short IdConvenio { get; set; }
        public Nullable<System.DateTime> FechaConvenio { get; set; }
        public Nullable<System.DateTime> FechaTerminacion { get; set; }
        public Nullable<decimal> Nueva_Superficie { get; set; }
        public Nullable<int> Institución_justipreciacion { get; set; }
        public Nullable<int> Institución_promovente { get; set; }
        public string Fk_IdJustipreciacion { get; set; }
        public Nullable<decimal> Importe_Renta { get; set; }
        public int Fk_IdUsuarioRegistro { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public System.DateTime FechaEfecConvenio { get; set; }
        public string Nombre { get; set; }
        public string Primer_Apellido { get; set; }
        public string Segundo_Apellido { get; set; }
        public string Nombre_Cargo { get; set; }
        public string Email { get; set; }
    
        public virtual ContratoArrto ContratoArrto { get; set; }
    }
}
