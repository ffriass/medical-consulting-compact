
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultorioLibrary.CapaDatos;
using System.Data;

namespace ConsultorioLibrary.CapaLogica
{
    class clCita
    {
        int Cita_ID;
        int Pa_ID;
        string MotivoCita;
        DateTime HoraCita;
        DateTime FechaCita;
        string NotaCita;

        public clCita() { }
        public clCita(int cita_ID, int pa_ID, string motivoCita, DateTime horaCita, DateTime fechaCita, string notaCita)
        {
            Cita_ID = cita_ID;
            Pa_ID = pa_ID;
            MotivoCita = motivoCita;
            HoraCita = horaCita;
            FechaCita = fechaCita;
            NotaCita = notaCita;
        }

        public int CitaID { get { return Cita_ID;} set { Cita_ID = value; }}
        public int PacienteID { get { return Pa_ID; } set { Pa_ID = value; } }
        public DateTime Hora { get { return  HoraCita;} set { HoraCita = value; }}
        public DateTime Fecha { get { return  FechaCita;} set { FechaCita = value; }}
        public string Nota { get { return  NotaCita; } set { NotaCita = value; }}
        public string Motivo { get { return  MotivoCita; } set { MotivoCita = value; }}

        internal void Registrar(clCita objCita, ref bool ResultadoOk, ref string MensajeError)
        {
            clRegistro objRegistro = new clRegistro();
            objRegistro.RegistrarCita(objCita, ref ResultadoOk, ref MensajeError);

        }


        internal DataTable BuscarCita(string Busqueda, DateTime Desde, DateTime Hasta, int SubControl, ref bool ResultadoOK, ref string MensajeError)
        {
            clBusquedaAvanzada objBusqueda = new clBusquedaAvanzada();
           return objBusqueda.BuscarCita(Busqueda, Desde, Hasta, SubControl, ref ResultadoOK, ref MensajeError);

        }

        internal DataTable BuscarCita(string Busqueda, ref bool ResultadoOK, ref string MensajeError)
        {
            clBusquedaAvanzada objBusqueda = new clBusquedaAvanzada();
            return objBusqueda.BuscarCita(Busqueda,  ref ResultadoOK, ref MensajeError);

        }



    }
}
