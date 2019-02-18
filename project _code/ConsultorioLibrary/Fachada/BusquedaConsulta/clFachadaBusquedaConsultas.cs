using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConsultorioLibrary.CapaLogica;

namespace ConsultorioLibrary.Fachada.BusquedaConsulta
{
    public class clFachadaBusquedaConsultas
    {

        public DataTable BuscarConsultas(string Busqueda, int SubControl, ref bool ResultadoOK, ref string MensajeError)
        {
            clConsulta consulta = new clConsulta();
            return consulta.Buscar(Busqueda, SubControl, ref ResultadoOK, ref MensajeError);
        }

        public DataTable BuscarConsultas(string Busqueda, DateTime Desde, DateTime Hasta, int SubControl, ref bool ResultadoOK, ref string MensajeError)
        {
            clConsulta consulta = new clConsulta();
            return consulta.Buscar(Busqueda, Desde, Hasta, SubControl, ref ResultadoOK, ref MensajeError);
        }

        
    }
}
