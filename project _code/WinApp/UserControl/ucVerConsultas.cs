using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultorioLibrary.Fachada.BusquedaConsulta;
using WinApp.Interfaces;

namespace WinApp
{
    public partial class ucVerConsultas : UcPadre
    {
        private static ucVerConsultas instance;
        public ucVerConsultas()
        {
            InitializeComponent();
        }

        public ucVerConsultas(IManipulable manipulable)
            :base(manipulable)
        {
            InitializeComponent();
           
        }
        public static ucVerConsultas Instance(IManipulable manipulable)
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new ucVerConsultas(manipulable);
            }
            return instance;
        }

        private void txtBuscarP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Efecto.SoloLetrasOrNumeros('N', e);

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btnBuscarConsulta_Click(sender, e);
            }
        }

        internal void CargarDataDrid()
        {
            clFachadaBusquedaConsultas objConsulta = new clFachadaBusquedaConsultas();
            bool ResultadoOk = false;
            string MensajeError = "";
            DateTime Fechadesde = Convert.ToDateTime(dtpDesde.Text);
            DateTime FechaHasta = Convert.ToDateTime(dtpHasta.Text);
            string Busqueda ="0";
            int SubControl = 3;

            DataTable DTConsulta = new DataTable();
            
            dgvListadoConsulta.Rows.Clear();
            
            string FechaCon;
            string Condicion = "Normal";


            /*if (cbbOpcioines.SelectedIndex == -1 || cbbOpcioines.SelectedIndex == 0)
            {
                Busqueda = "0";
                SubControl = 3;
                DTConsulta = objConsulta.BuscarConsultas(Busqueda, Fechadesde, FechaHasta, SubControl, ref ResultadoOk, ref MensajeError);
            }*/
            if ((cbbOpcioines.SelectedIndex == 1) && !(string.IsNullOrEmpty(txtBuscarP.Text.Trim())) && (cbIncluir.Checked))
            {
                Busqueda = txtBuscarP.Text;
                SubControl = 2;
                DTConsulta = objConsulta.BuscarConsultas(Busqueda, Fechadesde, FechaHasta, SubControl, ref ResultadoOk, ref MensajeError);

                if (DTConsulta.Rows.Count == 0)
                {
                    MessageBox.Show("Este paciente no tiene");
                }
                
            }
            else if ((cbIncluir.Checked) && (string.IsNullOrEmpty(txtBuscarP.Text.Trim())))
            {
                Busqueda = "0";
                SubControl = 2;
                DTConsulta = objConsulta.BuscarConsultas(Busqueda, Fechadesde, FechaHasta, SubControl, ref ResultadoOk, ref MensajeError);
            }
            else if ((cbbOpcioines.SelectedIndex == 1) && !(string.IsNullOrEmpty(txtBuscarP.Text.Trim())) && (cbIncluir.Checked == false))
            {
                Busqueda = txtBuscarP.Text;
                SubControl = 1;
                DTConsulta = objConsulta.BuscarConsultas(Busqueda, Fechadesde, FechaHasta, SubControl, ref ResultadoOk, ref MensajeError);
                if (DTConsulta.Rows.Count == 0)
                {
                    MessageBox.Show("Este paciente no tiene Consultas en este momento");
                }
            }

            else
            {
                Busqueda = "0";
                SubControl = 3;
                DTConsulta = objConsulta.BuscarConsultas(Busqueda
                    ,Fechadesde
                    ,FechaHasta
                    ,SubControl
                    ,ref ResultadoOk
                    ,ref MensajeError);
            }

            dgvListadoConsulta.Rows.Clear();
            for (int i = 0; i < DTConsulta.Rows.Count; i++)
            {
                FechaCon = Convert.ToDateTime(DTConsulta.Rows[i]["Con_Fecha"]).ToShortDateString();
                if (Convert.ToBoolean(DTConsulta.Rows[i]["Con_Seguimiento"]) == true)
                {
                    Condicion = "Seguimiento";
                }
                
                dgvListadoConsulta.Rows.Add(

                    DTConsulta.Rows[i]["Con_ID"],
                    DTConsulta.Rows[i]["Pa_Nombre"] + " " + DTConsulta.Rows[i]["Pa_Apellido"],
                    FechaCon,
                    DTConsulta.Rows[i]["Con_Motivo"],
                    Condicion                                             
                    );
            }           
        }
        private void btnBuscarConsulta_Click(object sender, EventArgs e)
        {
            CargarDataDrid();          
        }

        private void ucVerConsultas_Load(object sender, EventArgs e)
        {
            dtpDesde.MinDate = new DateTime(1900,12,31);
            dtpDesde.MaxDate = DateTime.Now;

            dtpHasta.MinDate = new DateTime(1900, 12, 31);
            dtpHasta.MaxDate = DateTime.Now;

            CargarDataDrid();


        }

        private void cbIncluir_Click(object sender, EventArgs e)
        {
            if (cbIncluir.Checked)
            {
                dtpDesde.Enabled = true;
                dtpHasta.Enabled = true;

            }
            else
            {
                dtpDesde.Enabled = false;
                dtpHasta.Enabled = false;
            }
        }

        private void panel19_MouseMove(object sender, MouseEventArgs e)
        {
            manipulable.ocultar();
        }

        private void dgvListadoConsulta_MouseMove(object sender, MouseEventArgs e)
        {
            manipulable.ocultar();
        }

        private void btnNuevaConsulta_Click(object sender, EventArgs e)
        {
            
        }
    }
}
