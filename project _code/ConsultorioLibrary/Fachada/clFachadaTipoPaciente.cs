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
    public class clFachadaTipoPaciente
    {

        public DataTable Seleccionar(int SubControl)
        {
            clTipoPaciente objTipoPaciente = new clTipoPaciente();
            return  objTipoPaciente.Seleccionar(SubControl);
        }
    }
}
