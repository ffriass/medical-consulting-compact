using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultorioLibrary.Model;

namespace ConsultorioLibrary.CapaDatos.Registro
{
    class RegistroDoctor
    {
        internal int Registrar(Doctor objDoctor, ref bool resultadoOk, ref string mensajeError)
        {
            using (Model.Consultorio_DBEntities db = new Model.Consultorio_DBEntities())
            {
                try
                {                  
                    db.Doctor.Add(objDoctor);
                    db.SaveChanges();
                    
                    resultadoOk = true;
                }
                catch (Exception error)
                {
                    resultadoOk = false;
                    mensajeError = error.Message.ToString();
                }
            }
            return objDoctor.Doc_ID;
        }
    }
}
