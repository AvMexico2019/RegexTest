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
    
    public partial class InmuebleArrendamiento
    {
        public InmuebleArrendamiento()
        {
            this.AplicacionConcepto = new HashSet<AplicacionConcepto>();
            this.ContratoArrto = new HashSet<ContratoArrto>();
        }
    
        public int IdInmuebleArrendamiento { get; set; }
        public int Fk_IdInstitucion { get; set; }
        public int Fk_IdPais { get; set; }
        public Nullable<int> Fk_IdTipoInmueble { get; set; }
        public Nullable<int> Fk_IdEstado { get; set; }
        public Nullable<int> Fk_IdMunicipio { get; set; }
        public Nullable<int> Fk_IdLocalidad { get; set; }
        public string OtraColonia { get; set; }
        public int Fk_IdTipoVialidad { get; set; }
        public string NombreVialidad { get; set; }
        public string NumExterior { get; set; }
        public string NumInterior { get; set; }
        public string CodigoPostal { get; set; }
        public Nullable<decimal> GeoRefLatitud { get; set; }
        public Nullable<decimal> GeoRefLongitud { get; set; }
        public string NombreInmueble { get; set; }
        public Nullable<int> Fk_IdInmueble { get; set; }
        public bool EstatusRegistro { get; set; }
        public int Fk_IdUsuarioRegistro { get; set; }
        public string CargoUsuarioRegistro { get; set; }
        public System.DateTime FechaRegistro { get; set; }
    
        public virtual ICollection<AplicacionConcepto> AplicacionConcepto { get; set; }
        public virtual ICollection<ContratoArrto> ContratoArrto { get; set; }
        public virtual DatosAdicionalesInmueble DatosAdicionalesInmueble { get; set; }
        public virtual Inmueble Inmueble { get; set; }
    }
}
