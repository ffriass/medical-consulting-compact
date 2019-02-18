using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultorioLibrary.Model;

namespace ConsultorioLibrary.CapaDatos.Registro
{
    public class RegistroUsuario
    {
        internal int Registrar(Usuario objUsuario, ref bool resultadoOk, ref string mensajeError)
        {
            using (Model.Consultorio_DBEntities db = new Model.Consultorio_DBEntities())
            {
                try
                {
                    db.Usuario.Add(objUsuario);
                    db.SaveChanges();
                    resultadoOk = true;
                }
                catch (Exception error)
                {
                    resultadoOk = false;
                    mensajeError = error.Message.ToString();
                }
            }
            return objUsuario.Us_ID;
        }
    }
}
