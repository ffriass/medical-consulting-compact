using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultorioLibrary.CapaLogica;
using System.Data;

namespace ConsultorioLibrary.Fachada
{
    public class clFachadaCita
    {

        clCita objCita; 
        public void RegistrarCita(ref int cita_ID, int pa_ID, string motivoCita, DateTime horaCita, DateTime fechaCita, string notaCita, ref bool ResultadoOk, ref string MensajeError)
        {
            objCita = new clCita(cita_ID, pa_ID, motivoCita, horaCita, fechaCita, notaCita);
            objCita.Registrar(objCita, ref ResultadoOk, ref MensajeError);
            cita_ID = objCita.CitaID;
        }



        public DataTable BuscarCita(string Busqueda, DateTime Desde, DateTime Hasta, int SubControl, ref bool ResultadoOK, ref string MensajeError)
        {
            objCita = new clCita();
            return objCita.BuscarCita(Busqueda, Desde, Hasta, SubControl, ref ResultadoOK, ref MensajeError);

        }

        public DataTable BuscarCita(string Busqueda, ref bool ResultadoOK, ref string MensajeError)
        {
            objCita = new clCita();
            return objCita.BuscarCita(Busqueda, ref ResultadoOK, ref MensajeError);

        }

    }
}
