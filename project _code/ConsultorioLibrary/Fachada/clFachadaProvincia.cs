using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ConsultorioLibrary.CapaLogica;

namespace ConsultorioLibrary.Fachada
{
    public class clFachadaProvincia
    {
        public DataTable Seleccionar(int SubControl)
        {
            clProvincia objProvincia = new clProvincia();

            return objProvincia.Seleccionar(SubControl);
        }
    }
}
