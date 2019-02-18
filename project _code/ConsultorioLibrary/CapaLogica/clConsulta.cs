using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultorioLibrary.CapaDatos;
using System.Data;

namespace ConsultorioLibrary.CapaLogica
{
    class clConsulta
    {
        int Consulta_ID;
        DateTime FechaConsulta;
        DateTime HoraConsulta;
        string Motivo_consulta;
        string HistoriaConsulta;
        bool SeguiminetoConsulta;
        int Doctor_ID;
        int Paciente_ID;

        clRegistro objRegistro = new clRegistro();

        public clConsulta() { }
        public clConsulta(int consulta_ID, DateTime fechaConsulta, DateTime horaConsulta, string motivo_consulta, string historiaConsulta, bool seguiminetoConsulta, int doctorID, int pacienteID)
        {
            Consulta_ID = consulta_ID;
            FechaConsulta = fechaConsulta;
            HoraConsulta = horaConsulta;
            Motivo_consulta = motivo_consulta;
            HistoriaConsulta = historiaConsulta;
            SeguiminetoConsulta = seguiminetoConsulta;
            DoctorID = doctorID;
            this.PacienteID = pacienteID;
        }

        public int ConsultaID { get { return Consulta_ID;} set { Consulta_ID = value; }}
        public DateTime Fecha { get { return FechaConsulta;} set{ FechaConsulta = value; }}

        public DateTime Hora { get { return HoraConsulta; } set { HoraConsulta = value; }}
        public string Motivo { get { return Motivo_consulta;} set { Motivo_consulta = value; }}
        public string Historia { get { return HistoriaConsulta; } set { HistoriaConsulta = value; }}
        public bool Seguimineto { get { return SeguiminetoConsulta;} set { SeguiminetoConsulta = value; }}
        public int DoctorID { get { return Doctor_ID;} set { Doctor_ID = value; }}
        public int PacienteID { get { return Paciente_ID; } set { Paciente_ID = value; } }


        internal void Registrar(clConsulta objConsulta, clExamenFisico objExamenFisico, clCondicionFisica objCondicionFisica, clDiagnostico objDiagnostico, clTratamiento objTratamiento, ref bool ResultadoOk, ref string MensajeError)
        {
            // objRegistro = new clRegistro();
            try
            {
                objRegistro.RegistrarConsulta(objConsulta, ref ResultadoOk, ref MensajeError);
                objExamenFisico.ConsultaID = objConsulta.ConsultaID;
                objDiagnostico.ConsultaID = objConsulta.ConsultaID;
                objTratamiento.ConsultaID = objConsulta.ConsultaID;

                RegistrarDetalleConsulta(objExamenFisico, objCondicionFisica, objDiagnostico, objTratamiento, ref ResultadoOk, ref MensajeError);
            }
            catch (Exception error)
            {
                ResultadoOk = false;
                MensajeError = "Ha ocurrido un Error Durante el de la Consulta" + error.Message.ToString();

            }

        }

        internal void RegistrarDetalleConsulta(clExamenFisico objExamenfisico, clCondicionFisica objCondicionFisica, clDiagnostico objDiagnostico, clTratamiento objTratamiento, ref bool ResultadoOk, ref string MensajeError)
        {
            //clRegistro objRegistro = new clRegistro();
            try
            {
                objRegistro.RegistrarDetalleConsulta(objExamenfisico, objCondicionFisica, objDiagnostico, objTratamiento, ref ResultadoOk, ref MensajeError);
            }
            catch (Exception error)
            {
                ResultadoOk = false;
                MensajeError = "Ha ocurrido un Error Durante el de la Consulta" + error.Message.ToString();

            }
        }


        internal DataTable Buscar(string Busqueda, int SubControl, ref bool ResultadoOk, ref string MensajeError)
        {
            clBusquedaAvanzada objBusqueda = new clBusquedaAvanzada();
           
                return objBusqueda.BuscarConsultas(Busqueda, SubControl, ref ResultadoOk, ref MensajeError);
                
           
        }

        internal DataTable Buscar(string Busqueda, DateTime Desde, DateTime Hasta, int SubControl, ref bool ResultadoOk, ref string MensajeError)
        {
            clBusquedaAvanzada objBusqueda = new clBusquedaAvanzada();

            return objBusqueda.BuscarConsultas(Busqueda, Desde, Hasta, SubControl, ref ResultadoOk, ref MensajeError);
            
        }
        //
    }
}
