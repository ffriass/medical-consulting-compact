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
    class clActualizacion
    {

        internal void RActualizar(clPaciente ObjPaciente, ref bool ResultadoOk, ref string MensajeError)
        {
            //clDomicilio Domicilio = new clDomicilio();
            //clBusquedaAvanzada Busqueda = new clBusquedaAvanzada();
            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            clConexion ObjConexion = new clConexion();
            SqlConnection con = new SqlConnection(ObjConexion.Conectar());

            try
            {
                SqlCommand cmd = new SqlCommand("SIUD_Paciente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Control", "U");
                cmd.Parameters.AddWithValue("@Pa_ID", ObjPaciente.ID);
                cmd.Parameters.AddWithValue("@Pa_Nombre", ObjPaciente.Nombre);
                cmd.Parameters.AddWithValue("@Pa_Apellido", ObjPaciente.Apellidos);
                cmd.Parameters.AddWithValue("@Pa_Telefono", ObjPaciente.Telefono);
                cmd.Parameters.AddWithValue("@Pa_Celular", ObjPaciente.Celular);
                cmd.Parameters.AddWithValue("@Pa_Email", ObjPaciente.Email);
                cmd.Parameters.AddWithValue("@Pa_Cedula", ObjPaciente.Cedula);
                cmd.Parameters.AddWithValue("@Gen_ID", ObjPaciente.Genero);
                cmd.Parameters.AddWithValue("@Pa_FechaNac", ObjPaciente.Fecha_Nacimiento);
                cmd.Parameters.AddWithValue("@Est_ID", ObjPaciente.EstadoCivil);
                cmd.Parameters.AddWithValue("@Domi_ID", ObjPaciente.DomicilioID);
                cmd.Parameters.AddWithValue("@Pa_EstaActivo", ObjPaciente.EstaActivo);
                cmd.Parameters.AddWithValue("@Zo_ID", ObjPaciente.Zona);
                cmd.Parameters.AddWithValue("@TP_ID", ObjPaciente.TipoPaciente);
                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);
                //datatable = dataset.Tables[0];
                //ObjPaciente.ID = Convert.ToInt32(datatable.Rows[0]["Pa_ID"]);

                ResultadoOk = true;
                MensajeError = "";


            }
            catch (Exception error)
            {
                ResultadoOk = false;
                MensajeError = "Ha ocurrido un Error al Actualizar el Paciente" + error.Message.ToString();
            }
            finally
            {
                con.Close();
                ObjConexion = null;
                datatable = null;
                datatable = null;
                con = null;
            }

        }


        internal void ActualizarDomicilio(clDomicilio clDomicilio, ref bool ResultadoOk, ref string MensajeError)
        {

            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            clConexion ObjConexion = new clConexion();
            SqlConnection con = new SqlConnection(ObjConexion.Conectar());
            try
            {

                SqlCommand cmd = new SqlCommand("SIUD_Domicilio", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Control", "U");
                cmd.Parameters.AddWithValue("@Domi_ID", clDomicilio.ID);
                cmd.Parameters.AddWithValue("@Domi_Sector", clDomicilio.Sector);
                cmd.Parameters.AddWithValue("@Domi_Calle", clDomicilio.Calle);
                cmd.Parameters.AddWithValue("@Domi_Numero", clDomicilio.Numero);
                cmd.Parameters.AddWithValue("@Mu_ID", clDomicilio.MunicipioID);

                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);
                //datatable = dataset.Tables[0];
                //clDomicilio.ID = Convert.ToInt32(datatable.Rows[0]["Domi_ID"]);


                ResultadoOk = true;
                MensajeError = "";
            }
            catch (Exception error)
            {
                ResultadoOk = false;
                MensajeError = "Ha ocurrido un error durante el registro del Domicilio" + error.Message.ToString();
            }
            finally
            {
                con.Close();
                ObjConexion = null;
                datatable = null;
                datatable = null;
                con = null;
            }

        }


    }
}
