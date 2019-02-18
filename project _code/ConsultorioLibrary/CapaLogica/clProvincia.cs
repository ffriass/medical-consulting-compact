using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ConsultorioLibrary.CapaDatos;

namespace ConsultorioLibrary.CapaLogica
{
    class clProvincia
    {

        internal DataTable Seleccionar(int SubControl)
        {
            clBusqueda objBusqueda = new clBusqueda();
            return objBusqueda.SeleccionarProvincia(SubControl);
        }
    }
}
