//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsultorioLibrary.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tratamiento
    {
        public int Trat_ID { get; set; }
        public string Trat_Descripcion { get; set; }
        public int Con_ID { get; set; }
    
        public virtual Consulta Consulta { get; set; }
    }
}
