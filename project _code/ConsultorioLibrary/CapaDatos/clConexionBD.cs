using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioLibrary.CapaDatos
{
    class clConexion
    {
        //ConectadorDBConnectionString

        private static clConexion instance;
        public clConexion() { }

        public static clConexion Instance{
            get
            {
                if(instance == null)
                {
                    instance = new clConexion();
                }
                return instance;
            }
        }

        public string Conectar()
        {
            string conexion = System
                .Configuration
                .ConfigurationManager
                .ConnectionStrings["ConectadorDBConnectionString"]
                .ConnectionString;
            return conexion;
        }
    }
}
