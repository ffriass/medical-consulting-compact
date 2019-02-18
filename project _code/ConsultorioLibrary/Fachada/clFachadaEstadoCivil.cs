using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ConsultorioLibrary.CapaLogica;

namespace ConsultorioLibrary.Fachada
{
   public  class clFachadaEstadoCivil
    {
        public DataTable Seleccionar(int SubControl)
        {
            clEstadoCivil objEstadoCivil = new clEstadoCivil();
            return objEstadoCivil.Seleccionar(SubControl);
        }
    }
}
