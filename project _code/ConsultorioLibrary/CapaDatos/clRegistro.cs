using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultorioLibrary.CapaLogica;
using System.Data;
using System.Data.SqlClient;


namespace ConsultorioLibrary.CapaDatos
{
    class clRegistro
    {
        
        internal void Registrar(clPaciente ObjPaciente, ref bool ResultadoOk, ref string MensajeError)
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
                if (ObjPaciente.ID == 0)
                {
                    cmd.Parameters.AddWithValue("@Control", "I");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Control", "U");
                    cmd.Parameters.AddWithValue("@Pa_ID", ObjPaciente.ID);
                }
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

                if (ObjPaciente.ID == 0)
                {
                    datatable = dataset.Tables[0];
                    ObjPaciente.ID = Convert.ToInt32(datatable.Rows[0]["Pa_ID"]);
                }
                else
                {
                    
                }
                    ResultadoOk = true;
                    MensajeError = "";                                
            }
            catch (Exception error)
            {
                ResultadoOk = false;
                MensajeError = "Ha ocurrido un Error al Guardar el Paciente" + error.Message.ToString();
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


        internal void RegistrarDomicilio(clDomicilio clDomicilio, ref bool ResultadoOk, ref string MensajeError)
        {

            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            clConexion ObjConexion = new clConexion();
            SqlConnection con = new SqlConnection(ObjConexion.Conectar());
            try
            {

                SqlCommand cmd = new SqlCommand("SIUD_Domicilio", con);
                cmd.CommandType = CommandType.StoredProcedure;

                if(clDomicilio.ID == 0)
                {
                    cmd.Parameters.AddWithValue("@Control", "I");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Control", "U");
                }
                cmd.Parameters.AddWithValue("@Domi_ID", clDomicilio.ID);
                cmd.Parameters.AddWithValue("@Domi_Sector", clDomicilio.Sector);
                cmd.Parameters.AddWithValue("@Domi_Calle", clDomicilio.Calle);
                cmd.Parameters.AddWithValue("@Domi_Numero", clDomicilio.Numero);
                cmd.Parameters.AddWithValue("@Mu_ID", clDomicilio.MunicipioID);

                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);

                if (clDomicilio.ID == 0)
                {
                    datatable = dataset.Tables[0];
                    clDomicilio.ID = Convert.ToInt32(datatable.Rows[0]["Domi_ID"]);

                }
               

                ResultadoOk = true;
                MensajeError = "";
            }
            catch (Exception error)
            {
                ResultadoOk = false;
                MensajeError = "Ha ocurrido un Error surante el registro" + error.Message.ToString();
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

        internal void RegistrarDetalleConsulta(clExamenFisico objExamenFisico, clCondicionFisica objCondicionFisica, clDiagnostico objDiagnostico, clTratamiento objTratamiento, ref bool ResultadoOk, ref string MensajeError)
        {

            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            clConexion ObjConexion = new clConexion();
            SqlConnection con = new SqlConnection(ObjConexion.Conectar());
            try
            {

                SqlCommand cmd = new SqlCommand("SIUD_DetalleConsulta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Control", "I");

                cmd.Parameters.AddWithValue("@Dia_Descripcion", objDiagnostico.Descripcion);
                cmd.Parameters.AddWithValue("@Exa_Descripcion", objExamenFisico.ExaDescripcion);
                cmd.Parameters.AddWithValue("@Trat_Descripcion", objTratamiento.Descripcion);
                cmd.Parameters.AddWithValue("@Con_ID", objExamenFisico.ConsultaID);

                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);
                datatable = dataset.Tables[0];
                objExamenFisico.ID= Convert.ToInt32(datatable.Rows[0]["Exa_ID"]);
                objCondicionFisica.ExamenFisicoID = objExamenFisico.ID;

                ResultadoOk = true;
                MensajeError = "";

                RegistrarCondicionFisica(objCondicionFisica, ref ResultadoOk, ref MensajeError);

            }
            catch (Exception error)
            {
                ResultadoOk = false;
                MensajeError = "Ha ocurrido un Error Durante el de la Consulta" + error.Message.ToString();
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

        internal void RegistrarCondicionFisica(clCondicionFisica objCondicionFisica, ref bool ResultadoOk, ref string MensajeError)
        {

            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            clConexion ObjConexion = new clConexion();
            SqlConnection con = new SqlConnection(ObjConexion.Conectar());
            try
            {

                SqlCommand cmd = new SqlCommand("SIUD_CondicionFisica", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Control", "I");

                cmd.Parameters.AddWithValue("@CondF_Peso", objCondicionFisica.Peso);
                cmd.Parameters.AddWithValue("@Cond_Talla", objCondicionFisica.Talla);
                cmd.Parameters.AddWithValue("@CondF_IndiceMC", objCondicionFisica.IndiceMC);
                cmd.Parameters.AddWithValue("@CondF_Temp", objCondicionFisica.Temperatura);
                cmd.Parameters.AddWithValue("@CondF_Sistolica", objCondicionFisica.PresaionAlta);
                cmd.Parameters.AddWithValue("@CondF_Diastolica", objCondicionFisica.PresionBaja);
                cmd.Parameters.AddWithValue("@Exa_ID", objCondicionFisica.ExamenFisicoID);

                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);
                //datatable = dataset.Tables[0];


                ResultadoOk = true;
                MensajeError = "";
            }
            catch (Exception error)
            {
                ResultadoOk = false;
                MensajeError = "Ha ocurrido un Error Durante el de la Consulta" + error.Message.ToString();
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


        internal void RegistrarConsulta(clConsulta objConsulta, ref bool ResultadoOk, ref string MensajeError)
        {

            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            clConexion ObjConexion = new clConexion();
            SqlConnection con = new SqlConnection(ObjConexion.Conectar());
            try
            {

                SqlCommand cmd = new SqlCommand("SIUD_Consulta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Control", "I");
                cmd.Parameters.AddWithValue("@Con_Fecha", objConsulta.Fecha);
                cmd.Parameters.AddWithValue("@Con_Hora", objConsulta.Hora);
                cmd.Parameters.AddWithValue("@Con_Motivo", objConsulta.Motivo);
                cmd.Parameters.AddWithValue("@Con_Historial", objConsulta.Historia);
                cmd.Parameters.AddWithValue("@Con_Seguimiento", objConsulta.Seguimineto);
                cmd.Parameters.AddWithValue("@Doc_ID", objConsulta.DoctorID);
                cmd.Parameters.AddWithValue("@Pa_ID", objConsulta.PacienteID);

                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);
                datatable = dataset.Tables[0];
                objConsulta.ConsultaID = Convert.ToInt32(datatable.Rows[0]["Con_ID"]);

                ResultadoOk = true;
                MensajeError = "";
            }
            catch (Exception error)
            {
                ResultadoOk = false;
                MensajeError = "Ha ocurrido un Error Durante el de la Consulta" + error.Message.ToString();
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

        internal void RegistrarCita(clCita objCita, ref bool ResultadoOk, ref string MensajeError)
        {

            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            clConexion ObjConexion = new clConexion();
            SqlConnection con = new SqlConnection(ObjConexion.Conectar());
            try
            {

                SqlCommand cmd = new SqlCommand("SIUD_Cita", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Control", "I");
                //cmd.Parameters.AddWithValue("@Ci_ID", objConsulta.Fecha);
                cmd.Parameters.AddWithValue("@Ci_Motivo", objCita.Motivo);
                cmd.Parameters.AddWithValue("@Ci_Fecha", objCita.Fecha);
                cmd.Parameters.AddWithValue("@Ci_Hora", objCita.Hora);
                cmd.Parameters.AddWithValue("@Ci_Nota", objCita.Nota);
                cmd.Parameters.AddWithValue("@Pa_ID", objCita.PacienteID);

                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);
                datatable = dataset.Tables[0];
                objCita.CitaID = Convert.ToInt32(datatable.Rows[0]["Ci_ID"]);

                ResultadoOk = true;
                MensajeError = "";
            }
            catch (Exception error)
            {
                ResultadoOk = false;
                MensajeError = "Error al Guardar la Cita" + error.Message.ToString();
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



        /*internal void RegistrarConsultacCompleta(clConsulta objConsulta, clExamenFisico objExamenFisico, clCondicionFisica objCondicionFisica, clDiagnostico objDiagnostico, clTratamiento objTratamiento, ref bool ResultadoOk, ref string MensajeError)
        {

            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            clConexion ObjConexion = new clConexion();
            SqlConnection con = new SqlConnection(ObjConexion.Conectar());
            try
            {

                SqlCommand cmd = new SqlCommand("SIUD_Consulta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Control", "I");
                cmd.Parameters.AddWithValue("@Con_Fecha", objConsulta.Fecha);
                cmd.Parameters.AddWithValue("@Con_Hora", objConsulta.Hora);
                cmd.Parameters.AddWithValue("@Con_Motivo", objConsulta.Motivo);
                cmd.Parameters.AddWithValue("@Con_Historial", objConsulta.Historia);
                cmd.Parameters.AddWithValue("@Con_Seguimiento", objConsulta.Seguimineto);
                cmd.Parameters.AddWithValue("@Doc_ID", objConsulta.DoctorID);
                cmd.Parameters.AddWithValue("@Pa_ID", objConsulta.PacienteID);

                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);
                datatable = dataset.Tables[0];
                objConsulta.ConsultaID = Convert.ToInt32(datatable.Rows[0]["Con_ID"]);

                cmd.Parameters.AddWithValue("@Con_ID", objConsulta.ConsultaID);
                cmd.Parameters.AddWithValue("@Dia_Descripcion", objDiagnostico.Descripcion);
                cmd.Parameters.AddWithValue("@Exa_Descripcion", objExamenFisico.ExaDescripcion);
                cmd.Parameters.AddWithValue("@Trat_Descripcion", objTratamiento.Descripcion);
                SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);
                datatable = dataset.Tables[0];
                objExamenFisico.ID = Convert.ToInt32(datatable.Rows[0]["Exa_ID"]);
                objCondicionFisica.ExamenFisicoID = objExamenFisico.ID;

                //cmd = new SqlCommand("SIUD_CondicionFisica", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@Control", "I");

                cmd.Parameters.AddWithValue("@CondF_Peso", objCondicionFisica.Peso);
                cmd.Parameters.AddWithValue("@Cond_Talla", objCondicionFisica.Talla);
                cmd.Parameters.AddWithValue("@CondF_IndiceMC", objCondicionFisica.IndiceMC);
                cmd.Parameters.AddWithValue("@CondF_Temp", objCondicionFisica.Temperatura);
                cmd.Parameters.AddWithValue("@CondF_Sistolica", objCondicionFisica.PresaionAlta);
                cmd.Parameters.AddWithValue("@CondF_Diastolica", objCondicionFisica.PresionBaja);
                cmd.Parameters.AddWithValue("@Exa_ID", objCondicionFisica.ExamenFisicoID);

                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);






                ResultadoOk = true;
                MensajeError = "";
            }
            catch (Exception error)
            {
                ResultadoOk = false;
                MensajeError = "Ha ocurrido un Error Durante el de la Consulta" + error.Message.ToString();
            }
            finally
            {
                con.Close();
                ObjConexion = null;
                datatable = null;
                datatable = null;
                con = null;
            }

        }*/
    }

}
