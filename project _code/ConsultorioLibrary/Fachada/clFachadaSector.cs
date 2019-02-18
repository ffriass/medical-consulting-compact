using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConsultorioLibrary.CapaLogica;

namespace ConsultorioLibrary.Fachada
{
    public class clFachadaSector
    {
        public DataTable Seleccionar(int SubControl, int Mu_ID)
        {
            clSector objSector = new clSector();
            return objSector.Seleccionar(SubControl, Mu_ID);
        }
    }
}
