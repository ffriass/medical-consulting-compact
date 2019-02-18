using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultorioLibrary.Fachada.BusquedaPaciente;
using ConsultorioLibrary.Fachada.BusquedaConsulta;
using ConsultorioLibrary.Fachada;
using WinApp.Interfaces;

namespace WinApp
{
    public partial class ucBusquedaP : UcPadre
    {
        private static ucBusquedaP objucBusquedaP;
        clFachadaBusquedaPaciente objBusquedaP = new clFachadaBusquedaPaciente();
        
        public ucBusquedaP()
        {
            InitializeComponent();
        }

        public ucBusquedaP(IManipulable manipulable)
            :base(manipulable)
        {
            InitializeComponent();
        }

        public static ucBusquedaP Instancia(IManipulable manipulable)
        {    
            if (objucBusquedaP == null || objucBusquedaP.IsDisposed)
            {
                objucBusquedaP = new ucBusquedaP(manipulable);
            }
        objucBusquedaP.LoadComponents();
        return objucBusquedaP;
        }
   

        private void ucBusquedaP_MouseMove(object sender, MouseEventArgs e)
        {

            manipulable.ocultar();
        }

        private void panel19_MouseMove(object sender, MouseEventArgs e)
        {
            manipulable.ocultar();
        }

        internal void ucBusquedaP_Load(object sender, EventArgs e)
        {
            LoadComponents();
        }
        //To Inicializze all necesary elemen6ts the UI uses from the database and dates
        internal void LoadComponents()
        {

            dtpEdadHasta.MinDate = new DateTime(1900, 12, 31);
            dtpEdadHasta.MaxDate = DateTime.Today;

            dtpEdadDesde.MinDate = new DateTime(1900, 12, 31);
            dtpEdadDesde.MaxDate = DateTime.Today;

            dtpConsultaDesde.MinDate = new DateTime(1900, 12, 31);
            dtpConsultaDesde.MaxDate = DateTime.Today;

            dtpConsultaHasta.MinDate = new DateTime(1900, 12, 31);
            dtpConsultaHasta.MaxDate = DateTime.Today;

            bool ResultadoOK = false;
            string MensajeError = "";

            DataTable DTPacientes = new DataTable();
            DTPacientes = objBusquedaP.Buscar("", 1, ref ResultadoOK, ref MensajeError);
            string FechaNac;
            string FechaAlta;
            //  dgvResultadoBusquedaP.DataSource = DTPacientes;

            dgvResultadoBusquedaP.Rows.Clear();
            for (int i = 0; i < DTPacientes.Rows.Count; i++)
            {
                //FechaNac = Convert.ToDateTime(DTPacientes.Rows[i]["Pa_FechaNac"]).ToShortDateString();
                FechaAlta = Convert.ToDateTime(DTPacientes.Rows[i]["Pa_FechaAlta"]).ToShortDateString();
                FechaNac = Efecto.ObtenerEdad(Convert.ToDateTime(DTPacientes.Rows[i]["Pa_FechaNac"]));
                dgvResultadoBusquedaP.Rows.Add(

                        DTPacientes.Rows[i]["Pa_ID"],
                        DTPacientes.Rows[i]["Pa_Nombre"],
                        DTPacientes.Rows[i]["Pa_Apellido"],
                        DTPacientes.Rows[i]["Gen_Descripcion"],
                        DTPacientes.Rows[i]["TP_Descripcion"],
                        FechaNac,
                        FechaAlta,
                        DTPacientes.Rows[i]["Pa_Cedula"],
                        DTPacientes.Rows[i]["Pa_Telefono"],
                        DTPacientes.Rows[i]["Pa_Celular"],
                        DTPacientes.Rows[i]["Est_Descripcion"],
                        DTPacientes.Rows[i]["Pa_Email"],
                        DTPacientes.Rows[i]["Zo_Nombre"],
                        DTPacientes.Rows[i]["Domi_Calle"],
                        DTPacientes.Rows[i]["Domi_Numero"],
                        DTPacientes.Rows[i]["Domi_Sector"],
                        DTPacientes.Rows[i]["Mu_Nombre"],
                        DTPacientes.Rows[i]["Pro_Nombre"]
                        );

            }
        }

        private void CargarConsultas(string  PacienteID )
        {
            clFachadaBusquedaConsultas objConsultas = new clFachadaBusquedaConsultas();
            bool ResultadoOK = false;
            string Mensajeerror = "";
            //DataTable DTConsulta = new DataTable();
            DataTable DTConsulta =  objConsultas.BuscarConsultas(PacienteID, 1, ref ResultadoOK, ref Mensajeerror);

            dgvListadoConsulta.Rows.Clear();
            
            if (DTConsulta.Rows.Count >=1)
            {
                dgvListadoConsulta.Focus();
               string FechaCon;
               string Seguimiento = "Normal";
                for (int i = 0; i < DTConsulta.Rows.Count; i++)
                {
                    FechaCon = Convert.ToDateTime(DTConsulta.Rows[i]["Con_Fecha"]).ToShortDateString();
                    if (Convert.ToBoolean(DTConsulta.Rows[i]["Con_Seguimiento"])== true)
                    {
                        Seguimiento = "Seguimiento";
                    }
                    dgvListadoConsulta.Rows.Add(
                        DTConsulta.Rows[i]["Con_ID"],
                        FechaCon,
                        DTConsulta.Rows[i]["Con_Motivo"],
                        Seguimiento,
                        DTConsulta.Rows[i]["Con_Historial"],
                        DTConsulta.Rows[i]["Exa_Descripcion"],
                        DTConsulta.Rows[i]["Dia_Descripcion"],
                        DTConsulta.Rows[i]["Trat_Descripcion"],
                        DTConsulta.Rows[i]["CondF_Peso"],
                        DTConsulta.Rows[i]["CondF_Temp"],
                        DTConsulta.Rows[i]["CondF_IndiceMC"],
                        DTConsulta.Rows[i]["Cond_Talla"],
                        DTConsulta.Rows[i]["CondF_Sistolica"],
                        DTConsulta.Rows[i]["CondF_Diastolica"],
                        DTConsulta.Rows[i]["Con_Hora"]
                        );                  
                }
            }
            else
            {
                MessageBox.Show("El Paciente No tiene Consulta");
            }
        }

        private void dgvResultadoBusquedaP_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string Pa_ID;
            Pa_ID = dgvResultadoBusquedaP.SelectedRows[0].Cells["colNoExp"].Value.ToString();
            CargarConsultas(Pa_ID);
           // MostrarResumenConsulta();
        }

        private void MostrarResumenConsulta()
        {
            try{
            txtHistoria.Text = dgvListadoConsulta.SelectedRows[0].Cells["colHistoria"].Value.ToString();
            txtExamen.Text = dgvListadoConsulta.SelectedRows[0].Cells["colExamen"].Value.ToString();
            txtDiagnostico.Text = dgvListadoConsulta.SelectedRows[0].Cells["colDiagnostico"].Value.ToString();
            txtTratamiento.Text = dgvListadoConsulta.SelectedRows[0].Cells["colTratamiento"].Value.ToString();
            txtHistoria.Text = dgvListadoConsulta.SelectedRows[0].Cells["colHistoria"].Value.ToString();

            lblPeso.Text = dgvListadoConsulta.SelectedRows[0].Cells["colPeso"].Value.ToString() + "Kg";
            lblTalla.Text = dgvListadoConsulta.SelectedRows[0].Cells["colTalla"].Value.ToString() + "m";
            lblMC.Text = dgvListadoConsulta.SelectedRows[0].Cells["colIndiceMC"].Value.ToString() + "Kg/m²";
            lblTemp.Text = dgvListadoConsulta.SelectedRows[0].Cells["colTemp"].Value.ToString() + "ºC";
            string PresionAlta = dgvListadoConsulta.SelectedRows[0].Cells["colPresionA"].Value.ToString();
            string PresionBaja = dgvListadoConsulta.SelectedRows[0].Cells["colPresionB"].Value.ToString();
            lblPresion.Text = PresionAlta + "/" + PresionBaja + "mmHg";
           }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
        private void dgvListadoConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarResumenConsulta();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxEdad_Click(object sender, EventArgs e)
        {
            if (checkBoxEdad.Checked)
            {
                dtpEdadDesde.Enabled = true;
                dtpEdadHasta.Enabled = true;
            }
            else
            {
                dtpEdadDesde.Enabled = false;
                dtpEdadHasta.Enabled = false;
            }
        }

        private void checkBoxConsulta_Click(object sender, EventArgs e)
        {
            if (checkBoxConsulta.Checked)
            {
                dtpConsultaDesde.Enabled = true;
                dtpConsultaHasta.Enabled = true;
            }
            else
            {
                dtpConsultaDesde.Enabled = false;
                dtpConsultaHasta.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvResultadoBusquedaP.SelectedRows.Count == 1)
            {
                clFachadaPaciente objPaciente = new clFachadaPaciente();
                bool ResultadoOK = false;
                string mensajeError = "";
                
                try
                {
                    int Pa_ID = Convert.ToInt32(dgvResultadoBusquedaP.SelectedRows[0].Cells["colNoExp"].Value);
                    objPaciente.EliminarPaciente(Convert.ToInt32(Pa_ID), 1, ref ResultadoOK, ref mensajeError);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message.ToString());
                }

                if (ResultadoOK)
                {
                    MessageBox.Show("Paciente Elimnado con exito \n\n En cualquier momento puede restaurar el paciente ");
                    ucBusquedaP_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Paciente no Eliminado");
                }
            }
            else
            {
               // ErrorDatos.SetError(txtExpediente, "No ha elegido \nningun pacinte");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvResultadoBusquedaP.SelectedRows.Count == 1)
            {
                try
                {
                 //manipulable.manipular();   
               /*FP.btnAgregarPaciente_Click(sender, e);
                 FP.ucRegistroP2.txtBuscarP.Text = dgvResultadoBusquedaP.SelectedRows[0].Cells["colNoExp"].Value.ToString();
                 FP.ucRegistroP2.btnBuscarP_Click(sender, e);*/      
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message.ToString());
                }
            }
            else
            {
                ErrorDatos.SetError(btnEditar, "No ha elegido \nningun Pacinte");
            }
        }

        private void btnImprimirResumen_Click(object sender, EventArgs e)
        {
            Form_ResumenConsulta FR = new Form_ResumenConsulta();
            FR.ConsultaID = Convert.ToInt32(dgvListadoConsulta.CurrentRow.Cells["colConsultaID"].Value);
            FR.ShowDialog();
        }
    }
}
