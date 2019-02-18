using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultorioLibrary.CapaDatos;
using System.Data;



namespace ConsultorioLibrary.CapaLogica
{
    class clPaciente : clPersona
    {


        private string Pa_Telefono;
        private string Pa_Celular;
        private string Pa_Email;
        private bool Pa_EstaActivo;
        private int Pa_Zona;
        private int Pa_TipoPaciente;
        //clDomicilio objDomicilio;

        public clPaciente() { }

        public clPaciente(int ID)
        {
            this.per_ID = ID;

        }

        public clPaciente(int ID, string Nombre, string Apellidos, int Genero, DateTime Fecha_Nac, string Cedula, int Estado_Civil, string Telefono, string Celular,
              int TipoPaciente, int Zona) :
            base(ID, Nombre, Apellidos, Genero, Fecha_Nac, Cedula, Estado_Civil)
        {

            Pa_Telefono = Telefono;
            Pa_Celular = Celular;
            Pa_TipoPaciente = TipoPaciente;
            Pa_Zona = Zona;
            Pa_EstaActivo = EstaActivo;

        }
        //Estan definidas las propiedades del paciente
        internal string Telefono { get { return Pa_Telefono; } set { Pa_Telefono = value; } }
        internal string Celular { get { return Pa_Celular; } set { Pa_Celular = value; } }
        internal string Email { get { return Pa_Email; } set { Pa_Email = value; } }
        internal bool EstaActivo { get { return Pa_EstaActivo; } set { Pa_EstaActivo = value; } }
        internal int Zona { get { return Pa_Zona; } set { Pa_Zona = value; } }
        internal int TipoPaciente { get { return Pa_TipoPaciente; } set { Pa_TipoPaciente = value; } }
        

        //Metodo que registra y actualiza el paciente dependiendo del los datos a ingresar
        internal void Registrar(clPaciente objPaciente, clDomicilio Domicilio, ref bool ResultadoOk, ref string MensajeError)
        {
            
                //creola instancia de la clase registro
                clRegistro objRegistro = new clRegistro();
                
                //pregunto si la cedula del paciente esta vacia
                if (string.IsNullOrEmpty(objPaciente.Cedula) )
                {
                    try
                    {   //envio al paciente a registrar
                        objRegistro.RegistrarDomicilio(Domicilio, ref ResultadoOk, ref MensajeError);
                        DomicilioID = Domicilio.ID;
                        objRegistro.Registrar(objPaciente, ref ResultadoOk, ref MensajeError);
                    }
                    catch (Exception error)
                    {
                        ResultadoOk = false;
                        MensajeError = "Ha ocurrido un Error Durante el registro" + error.Message.ToString();
                    }

                }
                else
                {
                    DataTable DT = new DataTable();
                    //clBusquedaAvanzada Busqueda = new clBusquedaAvanzada();
                    //DT = Busqueda.BuscarPaciente(objPaciente.Cedula, 2, ref ResultadoOk, ref MensajeError);
                   DT = Buscar(objPaciente.Cedula, 2, ref ResultadoOk, ref MensajeError);

                    if (DT.Rows.Count == 1)
                    {
                ///---------------
                        if (objPaciente.ID == 0)
                        {
                            ResultadoOk = false;
                            MensajeError = "La Cedula esta en Nuestro Sistema";

                        }
                        else
                        {
                            if (Convert.ToInt32(DT.Rows[0]["Pa_ID"]) == objPaciente.ID)
                            {
                                try
                                {
                                    objRegistro.RegistrarDomicilio(Domicilio, ref ResultadoOk, ref MensajeError);
                                    DomicilioID = Domicilio.ID;
                                    objRegistro.Registrar(objPaciente, ref ResultadoOk, ref MensajeError);
                                }
                                catch (Exception error)
                                {
                                    ResultadoOk = false;
                                    MensajeError = "Ha ocurrido un Error Durante el registro" + error.Message.ToString();
                                }

                            }
                            else
                            {
                                    ResultadoOk = false;
                                    MensajeError = "La Cedula esta en Nuestro Sistema";
                            }
                        }                      
                    }
                    else if (DT.Rows.Count == 0)
                    {
                        try
                        {
                            objRegistro.RegistrarDomicilio(Domicilio, ref ResultadoOk, ref MensajeError);
                            DomicilioID = Domicilio.ID;
                            objRegistro.Registrar(objPaciente, ref ResultadoOk, ref MensajeError);
                        }
                        catch (Exception error)
                        {
                            ResultadoOk = false;
                            MensajeError = "Ha ocurrido un Error Durante el registro" + error.Message.ToString();
                        }
                    }
                    else
                    {
                        //Aqui va el codigo en caso que encuentre mas de un registro con la misma cedula
                        ResultadoOk = false;
                        MensajeError = "Cedula Duplicada revice eso";
                    }
    
                }
         }
        


        /*internal void Actualizar(clPaciente objPaciente, clDomicilio Domicilio, ref bool ResultadoOk, ref string MensajeError)
        {

            clActualizacion objActualizacion = new clActualizacion();
            if (string.IsNullOrEmpty(objPaciente.Cedula))
            {
                try
                {
                    objActualizacion.RegistrarDomicilio(Domicilio, ref ResultadoOk, ref MensajeError);
                    DomicilioID = Domicilio.ID;
                    objRegistro.Registrar(objPaciente, ref ResultadoOk, ref MensajeError);
                }
                catch (Exception error)
                {
                    ResultadoOk = false;
                    MensajeError = "Ha ocurrido un Error Durante el registro" + error.Message.ToString();
                }

            }
            else
            {
                clBusquedaAvanzada Busqueda = new clBusquedaAvanzada();
                DataTable DT = new DataTable();
                DT = Busqueda.BuscarPaciente(objPaciente.Cedula, 2, ref ResultadoOk, ref MensajeError);

                if (DT.Rows.Count == 1)
                {
                    ResultadoOk = false;
                    MensajeError = "La Cedula esta en Nuestro Sistema";
                }
                else
                {
                    try
                    {
                        objRegistro.RegistrarDomicilio(Domicilio, ref ResultadoOk, ref MensajeError);
                        DomicilioID = Domicilio.ID;
                        objRegistro.Registrar(objPaciente, ref ResultadoOk, ref MensajeError);
                    }
                    catch (Exception error)
                    {
                        ResultadoOk = false;
                        MensajeError = "Ha ocurrido un Error Durante el registro" + error.Message.ToString();
                    }
                }
            }


        }*/


        internal DataTable Buscar(string Busqueda, int Sub_Control, ref bool ResultadoOK, ref string  MensajeError )
        {
           // DataTable DT = new DataTable();
            clBusquedaAvanzada objBusqueda = new clBusquedaAvanzada();
            return objBusqueda.BuscarPaciente(Busqueda, Sub_Control, ref ResultadoOK, ref MensajeError);

        }

        internal void EliminarPaciente(int PacienteID, int SubControl, ref bool ResultadoOK, ref string MensajeError)
        {
            clEliminacion objEliminacion = new clEliminacion();
            objEliminacion.EliminarPaciente(PacienteID, SubControl, ref ResultadoOK, ref MensajeError);
        }
    }
}
