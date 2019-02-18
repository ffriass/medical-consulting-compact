using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultorioLibrary.CapaLogica;

namespace ConsultorioLibrary.Fachada
{
    public class clFachadaPaciente
    {
        clPaciente objPaciente;
        clDomicilio objDomicilio;

        public void Registrar(ref int ID, string Nombre, string Apellidos, int Genero, DateTime Fecha_Nac, string Cedula, int Estado_Civil, string Telefono, string Celular, string Email,
              int TipoPaciente, int Zona,int Domi_ID, string Sector, string Calle, string Numero, int Mu_ID, ref bool ResultadoOk, ref string MensajeError)
              {
            objDomicilio = new clDomicilio(Domi_ID, Sector, Calle, Numero, Mu_ID);
                
           objPaciente = new clPaciente(ID, Nombre, Apellidos, Genero, Fecha_Nac, Cedula, Estado_Civil, Telefono, Celular, TipoPaciente, Zona);

             objPaciente.Registrar(objPaciente, objDomicilio, ref ResultadoOk, ref MensajeError);
             ID = objPaciente.ID;
        }


        public void EliminarPaciente(int PacienteID, int SubControl, ref bool ResultadoOK, ref string MensajeError)
        {
            objPaciente = new clPaciente();
            objPaciente.EliminarPaciente(PacienteID, SubControl, ref ResultadoOK, ref MensajeError);
        }


    }
}
