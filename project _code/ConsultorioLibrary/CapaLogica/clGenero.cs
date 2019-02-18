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
     class clGenero
    {

        public DataTable Seleccionar(int SubControl)
        {
            DataTable dt;
            clBusqueda objConsulta = new clBusqueda();
           dt =  objConsulta.SeleccionarGenero(SubControl);
          return dt;
        }
    }
}
