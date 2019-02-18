using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultorioLibrary.CapaLogica;
using System.Data;

namespace ConsultorioLibrary.Fachada.BusquedaPaciente
{
    public class clFachadaBusquedaPaciente
    {
        public DataTable Buscar(string Busqueda, int Sub_Control, ref bool ResultadoOk, ref string MensajeError)
        {

            clPaciente objPaciente = new clPaciente();
            return objPaciente.Buscar(Busqueda, Sub_Control, ref  ResultadoOk, ref  MensajeError);
        }

    }
}
