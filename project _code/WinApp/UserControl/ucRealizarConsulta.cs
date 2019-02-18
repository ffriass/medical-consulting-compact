using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultorioLibrary.Fachada;
using ConsultorioLibrary.Fachada.BusquedaPaciente;
using WinApp.Interfaces;


namespace WinApp
{
    public partial class ucRealizarConsulta : UcPadre, IBuscable
    {
        private static ucRealizarConsulta instance;
        public ucRealizarConsulta(IManipulable manipulable)
            : base(manipulable)
        {
            InitializeComponent();
        }

        public ucRealizarConsulta()
        {
            InitializeComponent();
        }

        public static ucRealizarConsulta Instance(IManipulable manipulable)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ucRealizarConsulta(manipulable);
            }
            return instance;
        }

        private void ucRealizarConsulta_MouseMove(object sender, MouseEventArgs e)
        {
            //use the interface method to accomplish the task
            manipulable.ocultar();
        }

        private void btnMasMenosCitas_Click(object sender, EventArgs e)
        {
            /*use the method MostrarOcultar from the Efecto class to hide and show 
             * the panel passed in the parameter panel by clicking a referenced button*/
            Efecto.MostrarOcultar(panelCita, btnMasMenosCitas);
        }
   
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if ((Efecto.ValidarFormulario(this, ErrorDatos) == false) 
                && !(string.IsNullOrEmpty(rtxtMotivoConsulta.Text.Trim()))  
                && !(string.IsNullOrEmpty(rtxtHistoria.Text.Trim())))
            {
                clFachadaConsulta objConsulta = new clFachadaConsulta();
                try
                {
                        bool ResultadoOk = true;
                        string MensajeError = "";                        
                        DateTime FechaConsulta = Convert.ToDateTime(dtpFechaConsulta.Value);
                        DateTime HoraConsulta = Convert.ToDateTime(dtpHoraConsulta.Value);
                        string Motivo = rtxtMotivoConsulta.Text;
                        string Historia = rtxtHistoria.Text;
                        bool seguimiento = false;
                        if (cbSeguimiento.Checked) {
                        seguimiento = true;
                            }

                        int Doc_ID = 1;
                        string Examen = txtExamenFisico.Text;
                        decimal peso = 0;
                        decimal talla = 0;
                        decimal indiceMC = 0;
                        decimal Temp = 0;
                        int Presionalta = 0;
                        int PresionBaja = 0;

                    try
                    {
                        if (string.IsNullOrEmpty(txtPeso.Text.Trim()))
                        {
                            peso = 0;
                        }
                        else { peso = Convert.ToDecimal(txtPeso.Text); }

                        if (string.IsNullOrEmpty(txtTalla.Text.Trim()))
                        {
                            talla = 0;
                        }
                        else { talla = Convert.ToDecimal(txtTalla.Text); }

                        if (string.IsNullOrEmpty(txtIndiceMC.Text.Trim()))
                        {
                            if ((string.IsNullOrEmpty(txtPeso.Text.Trim())) || (string.IsNullOrEmpty(txtTalla.Text.Trim())))
                            {
                                indiceMC = 0;
                            }
                            else
                            {
                                indiceMC = (peso / (talla * talla));
                                txtIndiceMC.Text = indiceMC.ToString();
                            }
                        }

                        if (string.IsNullOrEmpty(txtTemperatura.Text.Trim()))
                        {
                            Temp = 0;
                        }
                        else { Temp = Convert.ToDecimal(txtTemperatura.Text); }

                        if ((string.IsNullOrEmpty(txtPeso.Text.Trim())) || (string.IsNullOrEmpty(txtTalla.Text.Trim())))
                        {
                            indiceMC = 0;
                        }
                        else
                        {
                            indiceMC = (peso / (talla * talla));
                            txtIndiceMC.Text = indiceMC.ToString();
                        }

                        if ((string.IsNullOrEmpty(txtPresionalta.Text.Trim())) || (string.IsNullOrEmpty(txtPresionBaja.Text.Trim())))
                        {
                        }
                        else
                        {
                            Presionalta = Convert.ToInt16(txtPresionalta.Text);
                            PresionBaja = Convert.ToInt16(txtPresionBaja.Text);
                        }
                    }
                    catch
                    {
                        ResultadoOk = false;
                    }

                    if (ResultadoOk)
                    {
                        int Pa_ID = Convert.ToInt32(txtExpediente.Text);
                        int Con_ID = 0;
                        string Diagnostico = txtDiagnostico.Text;
                        string Tratamiento = txtTratamiento.Text;
                        objConsulta.RegistrarConsulta(ref Con_ID, FechaConsulta, HoraConsulta, Motivo, Historia, seguimiento, Doc_ID, Pa_ID, Examen, peso, talla, indiceMC, Temp,
                                                        Presionalta, PresionBaja, Diagnostico, Tratamiento, ref ResultadoOk, ref MensajeError);

                        if (ResultadoOk)
                        {
                            txtConsultaID.Text = Con_ID.ToString();
                            MessageBox.Show("Consulta Guardada Exitosamente");
                        }
                        else
                        {
                            MessageBox.Show(MensajeError);
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Los datos Introducidos en el Apartado de condicion Fisica, como : peso, talla, etc., estan en el Formato incorrecto");
                    }                    
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }
            else
            {
                MessageBox.Show("Los campos: Motivo, Historia y Examen Fisico deben estar llenos ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }           
        }

        private void txtBuscarP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Efecto.SoloLetrasOrNumeros('N', e);

            if (e.KeyChar == (int)Keys.Enter)
            {
                btnBuscarPaciente_Click(sender, e);
            }
        }

        internal void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            buscar(txtBuscarP.Text);           
        }

        private void btnEditarPaciente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtExpediente.Text.Trim()))
            {
                ErrorDatos.SetError(btnBuscarPaciente,"No ha elegido un paciente");
            }
            else
            {
                manipulable.manipular(ucRegistroP.Instance(manipulable), this.txtExpediente.Text);
                Efecto.LimpiarForm(this);
            }
        }

        private void txtBuscarP_TextChanged(object sender, EventArgs e)
        {
            ErrorDatos.SetError(btnBuscarPaciente, "");
        }

        private void txtBuscarP_Enter(object sender, EventArgs e)
        {                       
        }

        private void txtPresionalta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Efecto.SoloLetrasOrNumeros('N', e);
        }

        private void txtPresionBaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            Efecto.SoloLetrasOrNumeros('N', e);
        }

        private void txtTemperatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            Efecto.SoloLetrasOrNumeros('N', e);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Efecto.LimpiarForm(this);
        }

        private void panel2_Move(object sender, EventArgs e)
        {
            manipulable.ocultar();;
        }

        //@IOverride
        public void buscar(string id)
        {
            if (string.IsNullOrEmpty(id)) //txtBuscarP.Text.Trim()) just in case
            {
                Form_BuscarPaciente FB = new Form_BuscarPaciente(this);
                FB.ShowDialog();
            }
            else
            {
                clFachadaBusquedaPaciente objFachadaPaciente = new clFachadaBusquedaPaciente();
                DataTable DTPaciente = new DataTable();
                string Pa_ID = id;
                bool ResultadoOK = false;
                string MensajeError = "";

                DTPaciente = objFachadaPaciente.Buscar(Pa_ID, 3, ref ResultadoOK, ref MensajeError);

                if (DTPaciente.Rows.Count == 1)
                {
                    //para asinar a las etiquetas en valor  de los datos del pacinetede la tabla consultada

                    lblNombre.Text = DTPaciente.Rows[0]["Pa_Nombre"].ToString();
                    lblApellido.Text = DTPaciente.Rows[0]["Pa_Apellido"].ToString();
                    lblEdad.Text = Efecto.ObtenerEdad(Convert.ToDateTime(DTPaciente.Rows[0]["Pa_FechaNac"].ToString()));
                    lblGenero.Text = DTPaciente.Rows[0]["Gen_Descripcion"].ToString();
                    lblTipoPaciente.Text = DTPaciente.Rows[0]["TP_Descripcion"].ToString();
                    lblZona.Text = DTPaciente.Rows[0]["Zo_Nombre"].ToString();
                    lblCedula.Text = DTPaciente.Rows[0]["Pa_Cedula"].ToString();
                    lblEstadoCivil.Text = DTPaciente.Rows[0]["Est_descripcion"].ToString();
                    txtExpediente.Text = DTPaciente.Rows[0]["Pa_ID"].ToString();
                }
                else
                {
                    MessageBox.Show("Paciente no encontrado", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                DTPaciente = null;
            }
        }
    }
}
