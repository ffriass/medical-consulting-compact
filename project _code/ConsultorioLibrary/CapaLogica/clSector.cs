using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConsultorioLibrary.CapaDatos;

namespace ConsultorioLibrary.CapaLogica
{
    class clSector
    {
        internal DataTable Seleccionar(int SubControl, int Mu_ID)
        {
            clBusqueda objBusqueda = new clBusqueda();
            return objBusqueda.SeleccionarSector(SubControl, Mu_ID);
        }
    }
}
