using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConsultorioLibrary.CapaLogica;

namespace ConsultorioLibrary.Fachada
{
    public class clFachadaCiudad
    {
        public DataTable Seleccionar(int SubControl, int Pro_ID)
        {
            clCiudad objCiudad = new clCiudad();
            return objCiudad.Seleccionar(SubControl, Pro_ID);
        }
    }
}
