
namespace ConsultorioLibrary.Model
{
    using System;
    using System.Collections.Generic;
    using CapaDatos.Registro;
    
    public partial class Usuario
    {
        public int Us_ID { get; set; }
        public string Us_Usuario { get; set; }
        public string Us_Contrasena { get; set; }
        public int Doc_ID { get; set; }
        public byte[] Us_Foto { get; set; }
        public string Us_Estatus { get; set; }
        public Nullable<int> TU_ID { get; set; }
    
        public virtual Doctor Doctor { get; set; }
        public virtual Tipo_Usuario Tipo_Usuario { get; set; }

        internal int Registrar(Usuario objUsuario, ref bool resultadoOk, ref string mensajeError)
        {
            RegistroUsuario  registroUsuario = new RegistroUsuario();
            this.Us_ID = registroUsuario.Registrar(objUsuario, ref resultadoOk, ref mensajeError);
            return this.Us_ID;
        }
    }
}
