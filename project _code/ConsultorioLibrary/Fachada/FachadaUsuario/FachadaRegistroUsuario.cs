using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultorioLibrary.Model;

namespace ConsultorioLibrary.Fachada.FachadaUsuario
{
    public partial class FachadaRegistroUsuario
    {
        public int Registrar(string username, string password, byte[] foto, int doctor, int tipo, string estatus, ref bool resultadoOk, ref string mensajeError)
        {
            Usuario user= new Usuario();
            user.Doc_ID = doctor;
            user.Us_Usuario = username;
            user.Us_Contrasena = password;
            user.Us_Foto = foto;
            user.TU_ID = tipo;
            user.Us_Estatus = estatus;
            user.Registrar(user, ref resultadoOk, ref mensajeError);
            return user.Us_ID;
        }
    }
}
