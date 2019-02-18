using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioLibrary.CapaDatos
{
    class BusquedaUsuario
    {

        internal DataTable SeleccionarUsuario(string usuario, string contrasena, int sub_Control, ref bool resultadoOK, ref string mensajeError)
        {
            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            clConexion ObjConexion = clConexion.Instance;
            SqlConnection coneccion = new SqlConnection(ObjConexion.Conectar());
            try
            {
                SqlCommand cmd = new SqlCommand("SIUD_USUARIO", coneccion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Control", "S");
                cmd.Parameters.AddWithValue("@Sub_Control", sub_Control);
                cmd.Parameters.AddWithValue("@Us_Usuario", usuario);
                cmd.Parameters.AddWithValue("@Us_Password", contrasena);

                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);
                datatable = dataset.Tables[0];

                resultadoOK = true;
                mensajeError = "";

            }
            catch (Exception error)
            {
                resultadoOK = false;
                mensajeError = "No Encontrado" + error.Message.ToString();
            }
            finally
            {

                coneccion.Close();
                ObjConexion = null;
            }

            return datatable;
        }

        internal DataTable UserAuthentication(string Usuario, string Contrasena, int Sub_Control, ref bool ResultadoOK, ref string MensajeError)
        {
            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            clConexion ObjConexion = clConexion.Instance;
            SqlConnection coneccion = new SqlConnection(ObjConexion.Conectar());
            try
            {
                SqlCommand cmd = new SqlCommand("Busqueda_Usuario", coneccion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Control", "S");
                cmd.Parameters.AddWithValue("@Sub_Control", Sub_Control);
                cmd.Parameters.AddWithValue("@Usuario", Usuario);
                cmd.Parameters.AddWithValue("@Contrasena", Contrasena);

                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);
                datatable = dataset.Tables[0];

                ResultadoOK = true;
                MensajeError = "";

            }
            catch (Exception error)
            {
                ResultadoOK = false;
                MensajeError = "No Encontrado" + error.Message.ToString();
            }
            finally
            {

                coneccion.Close();
                ObjConexion = null;
            }

            return datatable;
        }
    }
}
