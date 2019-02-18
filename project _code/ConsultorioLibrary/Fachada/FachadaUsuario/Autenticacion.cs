using ConsultorioLibrary.CapaLogica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioLibrary.Fachada.FachadaUsuario
{
    public class Autenticacion
    {
        private static Autenticacion instance;
        private Autenticacion() { }

        public static Autenticacion Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Autenticacion();
                }      
                return instance;
            }
        }

        public DataTable IniciarSeccion(string usuario, string contrasena, int SubControl, ref bool ResultadoOK, ref string MensajeError)
        {
            DataTable DT = new DataTable();
            Usuario user = new Usuario();
            DT = user.IniciarSeccion(usuario, contrasena, SubControl, ref ResultadoOK, ref MensajeError);
            return DT;
        }
    }
}
