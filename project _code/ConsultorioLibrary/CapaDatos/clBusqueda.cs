using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConsultorioLibrary.CapaDatos
{
    class clBusqueda
    {

        internal DataTable SeleccionarGenero(int Sub_Control)
        {
            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            clConexion ObjConexion =clConexion.Instance;
            SqlConnection coneccion = new SqlConnection(ObjConexion.Conectar());
            try
            {
                SqlCommand cmd = new SqlCommand("SIUD_Genero", coneccion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Control", "S");
                cmd.Parameters.AddWithValue("@Sub_Control", Sub_Control);

                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);
                datatable = dataset.Tables[0];
            }
            catch (Exception error)
            {
                error.Message.ToString();
            }
            finally
            {
                coneccion.Close();
                ObjConexion = null;
            }
            return datatable;
        }


        internal DataTable SeleccionarEstadoCivil(int Sub_Control)
        {
            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            clConexion ObjConexion = clConexion.Instance;
            SqlConnection coneccion = new SqlConnection(ObjConexion.Conectar());
            try
            {
                SqlCommand cmd = new SqlCommand("SIUD_EstadoCivil", coneccion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Control", "S");
                cmd.Parameters.AddWithValue("@Sub_Control", Sub_Control);

                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);
                datatable = dataset.Tables[0];
            }
            catch (Exception error)
            {
                error.Message.ToString();
            }
            finally
            {
                coneccion.Close();
                ObjConexion = null;
            }

            return datatable;
        }


        internal DataTable SeleccionarTipoPaciente(int Sub_Control)
        {
            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            clConexion ObjConexion = clConexion.Instance;
            SqlConnection coneccion = new SqlConnection(ObjConexion.Conectar());
            try
            {

                SqlCommand cmd = new SqlCommand("SIUD_TipoPaciente", coneccion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Control", "S");
                cmd.Parameters.AddWithValue("@Sub_Control", Sub_Control);

                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);
                datatable = dataset.Tables[0];

            }
            catch (Exception error)
            {
                error.Message.ToString();
            }
            finally
            {
                coneccion.Close();
                ObjConexion = null;
            }

            return datatable;

        }

        internal DataTable SeleccionarCiudad(int SubControl, int Pro_ID)
        {
            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            clConexion ObjConexion = clConexion.Instance;
            SqlConnection coneccion = new SqlConnection(ObjConexion.Conectar());
            try
            {
                SqlCommand cmd = new SqlCommand("SIUD_Municipio", coneccion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Control", "S");
                cmd.Parameters.AddWithValue("@Sub_Control", SubControl);
                cmd.Parameters.AddWithValue("@Pro_ID", Pro_ID);

                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);
                datatable = dataset.Tables[0];
            }
            catch (Exception error)
            {
                error.Message.ToString();
            }
            finally
            {
                coneccion.Close();
                ObjConexion = null;
            }
            return datatable;
        }


        internal DataTable SeleccionarProvincia(int SubControl)
        {
            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            clConexion ObjConexion = clConexion.Instance;
            SqlConnection coneccion = new SqlConnection(ObjConexion.Conectar());
            try
            {
                SqlCommand cmd = new SqlCommand("SIUD_Provincia", coneccion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Control", "S");
                cmd.Parameters.AddWithValue("@Sub_Control", SubControl);

                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);
                datatable = dataset.Tables[0];
            }
            catch (Exception error)
            {
                error.Message.ToString();
            }
            finally
            {
                coneccion.Close();
                ObjConexion = null;
            }

            return datatable;
        }

        internal DataTable SeleccionarSector(int SubControl, int Mu_ID)
        {
            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            clConexion ObjConexion = clConexion.Instance;
            SqlConnection coneccion = new SqlConnection(ObjConexion.Conectar());
            try
            {

                SqlCommand cmd = new SqlCommand("SIUD_Sector", coneccion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Control", "S");
                cmd.Parameters.AddWithValue("@Sub_Control", SubControl);
                cmd.Parameters.AddWithValue("@Mu_ID", Mu_ID);

                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);
                datatable = dataset.Tables[0];

            }
            catch (Exception error)
            {
                error.Message.ToString();
            }
            finally
            {
                coneccion.Close();
                ObjConexion = null;
            }

            return datatable;
        }



        internal DataTable SeleccionarZona(int SubControl)
        {
            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            clConexion ObjConexion = clConexion.Instance;
            SqlConnection coneccion = new SqlConnection(ObjConexion.Conectar());
            try
            {

                SqlCommand cmd = new SqlCommand("SIUD_Zona", coneccion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Control", "S");
                cmd.Parameters.AddWithValue("@Sub_Control", SubControl);

                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);
                datatable = dataset.Tables[0];

            }
            catch (Exception error)
            {
                error.Message.ToString();
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
