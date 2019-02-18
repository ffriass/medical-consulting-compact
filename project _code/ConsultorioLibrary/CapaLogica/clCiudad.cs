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
    class clCiudad
    {
        internal DataTable Seleccionar(int SubControl, int Pro_ID)
        {
            clBusqueda objBusqueda = new clBusqueda();
            return objBusqueda.SeleccionarCiudad(SubControl, Pro_ID);
        }
    }
}
