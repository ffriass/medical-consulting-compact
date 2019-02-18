using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConsultorioLibrary.CapaDatos
{
    class clBusquedaAvanzada
    {
        internal DataTable BuscarPaciente(string  Busqueda, int SubControl, ref bool ResultadoOK, ref string MensajeError)
        {
            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            DataTable dtAux = new DataTable();
            clConexion ObjConexion = new clConexion();
            SqlConnection coneccion = new SqlConnection(ObjConexion.Conectar());
            try
            {

                SqlCommand cmd = new SqlCommand("Busqueda_Paciente", coneccion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Sub_Control", SubControl);
                cmd.Parameters.AddWithValue("@Busqueda", Busqueda);

                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);
                datatable = dataset.Tables[0];

                ResultadoOK = true;
                MensajeError = "";

            }
            catch (Exception error)
            {
                ResultadoOK = false;
                MensajeError = "Paciente no encontrado " + error.Message.ToString();
            }
            finally
            {
                coneccion.Close();
                ObjConexion = null;
            }

            if (ResultadoOK == true)
                return datatable;
            else
                return dtAux;
        }


        internal DataTable BuscarConsultas(string Busqueda, int SubControl, ref bool ResultadoOK, ref string MensajeError)
        {
            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            DataTable dtAux = new DataTable();
            clConexion ObjConexion = new clConexion();
            SqlConnection coneccion = new SqlConnection(ObjConexion.Conectar());
            try
            {

                SqlCommand cmd = new SqlCommand("Busqueda_ConsultaCompleta", coneccion);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@Control", "S");
                cmd.Parameters.AddWithValue("@Sub_Control", SubControl);
                if (SubControl == 1)
                {
                    int busqueda2 = Convert.ToInt32(Busqueda);   
                    cmd.Parameters.AddWithValue("@Pa_ID", busqueda2);
                    Busqueda = "0";
                    cmd.Parameters.AddWithValue("@Busqueda", Busqueda);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Busqueda", Busqueda);
                }
               

                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);
                datatable = dataset.Tables[0];

                ResultadoOK = true;
                MensajeError = "";

            }
            catch (Exception error)
            {
                ResultadoOK = false;
                MensajeError = "El Paciente no tiene Consultas " + error.Message.ToString();
            }
            finally
            {
                coneccion.Close();
                ObjConexion = null;
            }

            if (ResultadoOK == true)
                return datatable;
            else
                return dtAux;
        }


        internal DataTable BuscarConsultas(string Busqueda, DateTime Desde, DateTime Hasta, int SubControl, ref bool ResultadoOK, ref string MensajeError)
        {
            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            DataTable dtAux = new DataTable();
            clConexion ObjConexion = new clConexion();
            SqlConnection coneccion = new SqlConnection(ObjConexion.Conectar());
            try
            {

                SqlCommand cmd = new SqlCommand("Busqueda_ConsultaCompleta", coneccion);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@Control", "S");
                cmd.Parameters.AddWithValue("@Sub_Control", SubControl);
                cmd.Parameters.AddWithValue("@Busqueda", Busqueda);
                cmd.Parameters.AddWithValue("@Con_FechaDesde", Desde);
                cmd.Parameters.AddWithValue("@Con_FechaHasta", Hasta);
               
                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);
                datatable = dataset.Tables[0];

                ResultadoOK = true;
                MensajeError = "";

            }
            catch (Exception error)
            {
                ResultadoOK = false;
                MensajeError = "El Paciente no tiene Consultas " + error.Message.ToString();
            }
            finally
            {
                coneccion.Close();
                ObjConexion = null;
            }

            if (ResultadoOK == true)
                return datatable;
            else
                return dtAux;
        }


        internal DataTable BuscarCita(string Busqueda, DateTime Desde, DateTime Hasta, int SubControl, ref bool ResultadoOK, ref string MensajeError)
        {
            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            DataTable dtAux = new DataTable();
            clConexion ObjConexion = new clConexion();
            SqlConnection coneccion = new SqlConnection(ObjConexion.Conectar());
            try
            {

                SqlCommand cmd = new SqlCommand("Busqueda_ConsultaCompleta", coneccion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Control", "S");
                cmd.Parameters.AddWithValue("@Sub_Control", SubControl);
                cmd.Parameters.AddWithValue("@Busqueda", Busqueda);
                cmd.Parameters.AddWithValue("@Con_FechaDesde", Desde);
                cmd.Parameters.AddWithValue("@Con_FechaHasta", Hasta);

                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);
                datatable = dataset.Tables[0];

                ResultadoOK = true;
                MensajeError = "";

            }
            catch (Exception error)
            {
                ResultadoOK = false;
                MensajeError = "El Paciente no tiene Citas " + error.Message.ToString();
            }
            finally
            {
                coneccion.Close();
                ObjConexion = null;
            }

            if (ResultadoOK == true)
                return datatable;
            else
                return dtAux;
        }

        internal DataTable BuscarCita(string Busqueda, ref bool ResultadoOK, ref string MensajeError)
        {
            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            DataTable dtAux = new DataTable();
            clConexion ObjConexion = new clConexion();
            SqlConnection coneccion = new SqlConnection(ObjConexion.Conectar());
            try
            {

                SqlCommand cmd = new SqlCommand("SIUD_Cita", coneccion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Control", "S");
                cmd.Parameters.AddWithValue("@Sub_Control", 1);
                cmd.Parameters.AddWithValue("@Busqueda", Busqueda);

                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);
                datatable = dataset.Tables[0];

                ResultadoOK = true;
                MensajeError = "";

            }
            catch (Exception error)
            {
                ResultadoOK = false;
                MensajeError = "El Paciente no tiene Citas " + error.Message.ToString();
            }
            finally
            {
                coneccion.Close();
                ObjConexion = null;
            }

            if (ResultadoOK == true)
                return datatable;
            else
                return dtAux;
        }

    }
}
