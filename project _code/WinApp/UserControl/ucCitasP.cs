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
    public partial class ucCitasP : UcPadre
    {
        private static ucCitasP instance;
  
        public ucCitasP(IManipulable manipulable)
            :base(manipulable)
        {
            InitializeComponent();            
        }
        public ucCitasP()
        {
            InitializeComponent();
        }
        public static ucCitasP Instance(IManipulable manipulable)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ucCitasP(manipulable);
            }
            return instance;
        }

        private void ucCitasP_Load(object sender, EventArgs e)
        {

        }

        private void ucCitasP_MouseMove(object sender, MouseEventArgs e)
        {
            manipulable.ocultar();
        }

    
        private void btnProgramarCita_Click_1(object sender, EventArgs e)
        {
            if (Efecto.ValidarFormulario(this,ErrorDatos) == false)
            {
                try
                {
                    int Pa_ID = Convert.ToInt32(txtExpediente.Text);
                    int Cita_ID = 0;
                    string MotivoCita = txtMotivo.Text;
                    DateTime FechaCita = Convert.ToDateTime(dtpFechaCita.Value);
                    DateTime HoraCita = Convert.ToDateTime(dtpHoraCita.Value);
                    string NotaCita = txtNotaCita.Text;
                    bool ResultadoOk = false;
                    string MensajeError = "";

                    clFachadaCita FachadaCita = new clFachadaCita();

                    FachadaCita.RegistrarCita(ref Cita_ID
                        ,Pa_ID
                        ,MotivoCita
                        ,HoraCita, FechaCita
                        ,NotaCita
                        ,ref ResultadoOk
                        ,ref MensajeError);

                    if (ResultadoOk)
                    {
                        txtCirtaNo.Text = Cita_ID.ToString();
                        cargarCitas(txtExpediente.Text);
                        MessageBox.Show("La cita se guardo exitosamente");
                    }
                    else
                    {
                        MessageBox.Show(MensajeError);
                    }
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message.ToString());
                }                
            }
            else
            {

            }
           
        }

        private void txtMotivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Efecto.SoloLetrasOrNumeros('L', e);
        }

        private void txtNotaCita_KeyPress(object sender, KeyPressEventArgs e)
        {
            Efecto.SoloLetrasOrNumeros('T', e);
        }

        private void txtBuscarP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Efecto.SoloLetrasOrNumeros('N', e);
        }

        private void dtpFechaCita_DropDown(object sender, EventArgs e)
        {
            dtpFechaCita.MinDate = DateTime.Today; 
            dtpFechaCita.MaxDate = new DateTime(2020, 12, 31);
        }

        internal void cargarCitas(string PacienteID)
        {
            clFachadaCita objCitas = new clFachadaCita();
            bool ResultadoOK = false;
            string Mensajeerror = "";

            
            DataTable DTCita = objCitas.BuscarCita(PacienteID, ref ResultadoOK, ref Mensajeerror);

            dgvCitas.Rows.Clear();

            if (DTCita.Rows.Count >= 1)
            {
                string FechaCita;
                dgvCitas.Rows.Clear();
                for (int i = 0; i < DTCita.Rows.Count; i++)
                {
                    FechaCita = Convert.ToDateTime(DTCita.Rows[i]["Ci_Fecha"]).ToShortDateString();                    
                    dgvCitas.Rows.Add( FechaCita, DTCita.Rows[i]["Ci_Motivo"], DTCita.Rows[i]["Ci_Nota"]);
                }
            }
            else
            {
               
            }
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {           
            if (string.IsNullOrEmpty(txtBuscarP.Text.Trim()))
            {
                Form_BuscarPaciente FB = new Form_BuscarPaciente();
                FB.ShowDialog();
            }
            else
            {
                clFachadaBusquedaPaciente objFachadaPaciente = new clFachadaBusquedaPaciente();
                DataTable DTPaciente = new DataTable();
                string Pa_ID = txtBuscarP.Text;
                bool ResultadoOK = false;
                string MensajeError = "";

                DTPaciente = objFachadaPaciente.Buscar(Pa_ID, 3, ref ResultadoOK, ref MensajeError);

                if (DTPaciente.Rows.Count == 1)
                {
                    //para asignar a las etiquetas en valor  de los datos del pacinetede la tabla consultada

                    lblNombre.Text = DTPaciente.Rows[0]["Pa_Nombre"].ToString();
                    lblApellido.Text = DTPaciente.Rows[0]["Pa_Apellido"].ToString();
                    lblEdad.Text = Efecto.ObtenerEdad(Convert.ToDateTime(DTPaciente.Rows[0]["Pa_FechaNac"].ToString()));
                    lblGenero.Text = DTPaciente.Rows[0]["Gen_Descripcion"].ToString();
                    lblTipoPaciente.Text = DTPaciente.Rows[0]["TP_Descripcion"].ToString();
                    lblZona.Text = DTPaciente.Rows[0]["Zo_Nombre"].ToString();
                    lblCedula.Text = DTPaciente.Rows[0]["Pa_Cedula"].ToString();
                    lblEstadoCivil.Text = DTPaciente.Rows[0]["Est_descripcion"].ToString();
                    txtExpediente.Text = DTPaciente.Rows[0]["Pa_ID"].ToString();

                    cargarCitas(txtExpediente.Text);
                }
                else
                {
                    MessageBox.Show("Paciente no encontrado", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                DTPaciente = null;
            }
        }

        private void btnEditarPaciente_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnEditarPaciente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtExpediente.Text.Trim()))
            {
                ErrorDatos.SetError(txtExpediente, "No ha elegido un paciente\na editar");
            }
            else
            {
                manipulable.manipular(ucRegistroP.Instance(manipulable), this.txtExpediente.Text);
                /*FP.btnAgregarPaciente_Click(sender, e);
                FP.ucRegistroP2.txtBuscarP.Text = this.txtExpediente.Text;
                FP.ucRegistroP2.btnBuscarP_Click(sender, e);*/
                
            }
           
        }

        private void cbMostrarNota_Click(object sender, EventArgs e)
        {
            if (cbMostrarNota.Checked)
            {
                dgvCitas.Columns["colNota"].Visible = true;
            }
            else
            {
                dgvCitas.Columns["colNota"].Visible = false;
            }
        }

        private void panelDatosPersonales_MouseMove(object sender, MouseEventArgs e)
        {
            manipulable.ocultar();
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            manipulable.ocultar();
        }
    }
}
