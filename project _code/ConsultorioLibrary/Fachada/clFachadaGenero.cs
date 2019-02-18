using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultorioLibrary.CapaLogica;
using System.Data.SqlClient;
using System.Data;

namespace ConsultorioLibrary.Fachada
{
   public  class clFachadaGenero
    {
        public DataTable SeleccionarGenero(int SubControl)
        {
            DataTable dt;
            clGenero objGenero = new clGenero();
           dt = objGenero.Seleccionar(SubControl);
           return dt;
        }
    }
}
