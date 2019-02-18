using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ConsultorioLibrary.CapaDatos;

namespace ConsultorioLibrary.CapaLogica
{
    class clTipoPaciente
    {

        internal DataTable Seleccionar(int SubControl)
        {
            clBusqueda objBusqueda = new clBusqueda();
            return objBusqueda.SeleccionarTipoPaciente(SubControl);
        }
        


    }


}
