using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultorioLibrary.Model;

namespace ConsultorioLibrary.Fachada.FachadaDoctor
{
    public class FachadaRegistroDoctor
    {
        public int Registrar(string nombre, string apellido, string cedula, string codigo, string telefono, string email, ref bool resultadoOk, ref string mensajeError)
        {
            Doctor doctor = new Doctor();
            doctor.Doc_Nombre = nombre;
            doctor.Doc_Apellido = apellido;
            doctor.Doc_Cedula = cedula;
            doctor.Doc_Codico = codigo;
            doctor.Doc_Email = email;
            doctor.Doc_Telefono = telefono;
            doctor.Registrar(doctor, ref resultadoOk, ref mensajeError);
            return doctor.Doc_ID;    
        }
    }
}
