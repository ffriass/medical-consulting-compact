using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultorioLibrary.Fachada.BusquedaPaciente;
using WinApp.Interfaces;

namespace WinApp
{
    public partial class Form_BuscarPaciente : Form
    {

        private IBuscable buscable;

        public Form_BuscarPaciente(IBuscable buscable)
        {
            InitializeComponent();
            this.buscable = buscable;
        }

        
        public Form_BuscarPaciente()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscarP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Efecto.SoloLetrasOrNumeros('C',e);
        }

        private void EnviarInformacion()
        {

            buscable
                .buscar(dgvResultadoBusquedaP
                .Rows[dgvResultadoBusquedaP
                .CurrentRow.Index]
                .Cells["colNoExp"]
                .Value
                .ToString());
        }

        private void txtBuscarP_TextChanged(object sender, EventArgs e)
        {
            bool ResultadoOK = false;
            string MensajeError = "";
            clFachadaBusquedaPaciente objBusquedaP = new clFachadaBusquedaPaciente();
            DataTable DTPacientes = new DataTable();
            DTPacientes = objBusquedaP.Buscar(txtBuscarP.Text, 3, ref ResultadoOK, ref MensajeError);
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
            objBusquedaP = null;
            DTPacientes = null;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            EnviarInformacion();
            this.Close();
        }

        private void Form_BuscarPaciente_Load(object sender, EventArgs e)
        {

        }
    }
}
