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
    
    public partial class Cita
    {
        public int Ci_ID { get; set; }
        public string Ci_Motivo { get; set; }
        public System.DateTime Ci_Fecha { get; set; }
        public Nullable<System.TimeSpan> Ci_Hora { get; set; }
        public string Ci_Nota { get; set; }
        public int Pa_ID { get; set; }
        public Nullable<bool> Ci_EstaEliminado { get; set; }
    
        public virtual Paciente Paciente { get; set; }
    }
}
