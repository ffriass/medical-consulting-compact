using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultorioLibrary.CapaLogica;

namespace ConsultorioLibrary.Fachada
{
    public class clFachadaConsulta
    {

        public void RegistrarConsulta(ref int Con_ID, DateTime Fecha, DateTime Hora, string Motivo, string Historial, bool Seguimiento, int DoctorID, int PacienteID,
                                        string ExamenFisico, decimal Peso, decimal Talla, decimal InciceMC, decimal Temperatura, int PresionAlta, int PresionBaja,
                                         string Diganostico, string Tratamiento, ref bool ResultadoOk, ref string MensajeError)
        {
            clConsulta objConsulta = new clConsulta(Con_ID, Fecha, Hora, Motivo, Historial, Seguimiento, DoctorID, PacienteID );
            clExamenFisico objExamenFisico = new clExamenFisico(0, ExamenFisico, Con_ID);

            clCondicionFisica clCondicionFisica = new clCondicionFisica(0, Peso, Talla, InciceMC, Temperatura, PresionAlta, PresionBaja, objExamenFisico.ID);
            clDiagnostico clDiagnostico = new clDiagnostico(0, Diganostico, Con_ID);
            clTratamiento clTratamiento = new clTratamiento(0, Tratamiento, Con_ID);


            //objConsulta.Registrar(objConsulta, ref ResultadoOk, ref MensajeError);
            //Con_ID = objConsulta.ConsultaID;


            objConsulta.Registrar(objConsulta, objExamenFisico, clCondicionFisica, clDiagnostico, clTratamiento, ref ResultadoOk, ref MensajeError);
            Con_ID = objConsulta.ConsultaID;
        }
    }
}
