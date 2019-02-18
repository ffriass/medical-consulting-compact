using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ConsultorioLibrary.CapaLogica;

namespace ConsultorioLibrary.CapaDatos
{
    class clEliminacion
    {
        internal void EliminarPaciente(int PacienteID, int SubControl, ref bool ResultadoOK, ref string MensajeError)
        {
            DataSet dataset = new DataSet();
            clConexion ObjConexion = new clConexion();
            SqlConnection coneccion = new SqlConnection(ObjConexion.Conectar());
            try
            {

                SqlCommand cmd = new SqlCommand("SIUD_Paciente", coneccion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Control", "D");
                cmd.Parameters.AddWithValue("@Sub_Control", SubControl);
                cmd.Parameters.AddWithValue("@Pa_ID", PacienteID);

                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);
                ResultadoOK = true;
                MensajeError = "";

            }
            catch (Exception error)
            {
                ResultadoOK = false;
                MensajeError = "No se pudo eliminar el paciente "+error.Message.ToString();
            }
            finally
            {
                coneccion.Close();
                ObjConexion = null;
            }

            
        }

    }
}
