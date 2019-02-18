using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinApp.Interfaces;


//Tamano de el panel de trabajo 1129; 466
//Localizacion del panel de trabajo 39; 142
namespace WinApp
{
    public partial class Form_Principal : Form, IManipulable
    {
        public static string user;
        public static string username, userlastname, useremail;

        public void receiveUser(DataTable dt)
        {
            user = dt.Rows[0]["Us_Usuario"].ToString();
            username = dt.Rows[0]["Doc_Nombre"].ToString();
            userlastname = dt.Rows[0]["Doc_Apellido"].ToString();
            useremail = dt.Rows[0]["Doc_Email"].ToString();
            lblUser.Text = user;
            btnLogedUser.Text = username + " " + userlastname;
        }

        //@OverRide
        public void mostrar()
        {
            MostrarPanel();
        }

        //@Override
        public void ocultar()
        {
            OcultarPanel();
        }
        //@Override
        public void manipular(UserControl destino, string valor)
        {
            UcPadre mydestino = (UcPadre)destino;
            switch (destino.Name)
            {
                case "ucRegistroP":
                    //ucRegistroP.Instance(this).txtBuscarP.Text = valor;
                    ucRegistroP.Instance(this).buscar(valor);
                    //SwitchingControlsManager(Panel_Principal, ucRegistroP.Instance(this));
                    break;
            }

            SwitchingControlsManager(Panel_Principal, mydestino);
        }

        private static Form_Principal inst;
        int panelHeight;
        bool Hidden;

        public Form_Principal()
        {
            InitializeComponent();

            panelHeight = Panel_Slide.Height;
            Hidden = false;
            Panel_Slide.Visible = false;
            Timer_Panel.Start();
        }
        public static Form_Principal Instancia
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                {
                    inst = new Form_Principal();
                }
                return inst;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //para mostrar el panel
        private void MostrarPanel()
        {
            if (Hidden)
            {
                // Panel_Slide.Visible = true;
                Panel_Slide.BringToFront();
                Timer_Panel.Start();
                Panel_Slide.Height = Panel_Slide.Height + 10;
                if (Panel_Slide.Height >= panelHeight)
                {
                    Timer_Panel.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
        }

        //para ocultar el panel
        internal void OcultarPanel()
        {
            if (Hidden == false)
            {
                // Hidden = true;
                Timer_Panel.Start();
                Panel_Slide.Height = Panel_Slide.Height - 10;

                if (Panel_Slide.Height <= 0)
                {
                    Timer_Panel.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
        }

        private void btnPacientes_MouseMove(object sender, MouseEventArgs e)
        {
            Efecto.Instance.panelMoving(Panel_Barra, btnPacientes, Efecto.VERTICAL);
            MostrarPanel();
            Efecto.VisibleNoVisible(Panel_Slide, Pacientes_Panel);
        }

        private void btnConsultas_MouseMove(object sender, MouseEventArgs e)
        {
            Efecto.Instance.panelMoving(Panel_Barra, btnConsultas, Efecto.VERTICAL);
            MostrarPanel();
            Efecto.VisibleNoVisible(Panel_Slide, Consultas_Panel);
        }

        private void btnCitas_MouseMove(object sender, MouseEventArgs e)
        {
            Efecto.Instance.panelMoving(Panel_Barra, btnCitas, Efecto.VERTICAL);
            MostrarPanel();
            Efecto.VisibleNoVisible(Panel_Slide, Citas_Panel);
        }

        private void btn_Home_MouseMove(object sender, MouseEventArgs e)
        {
            Efecto.Instance.panelMoving(Panel_Barra, btnHome, Efecto.VERTICAL);
            OcultarPanel();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            Panel_Principal.Dock = DockStyle.Fill;
            Panel_Principal.BringToFront();
            SwitchingControlsManager(Panel_Principal, ucDashboard.Instance(this));
        }

        internal void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
                SwitchingControlsManager(Panel_Principal, ucBusquedaP.Instancia(this));                
        }

        internal static void SwitchingControlsManager(Control container, Control uc)
        {
            int x = 0;
            //To center the child contror into its container
            x = (container.Width / 2) - (uc.Width / 2);
            uc.Location = new Point(x, uc.Location.Y);

            foreach (Control ucOtros in container.Controls)
            {
                container.Controls.Remove(ucOtros);              
            }
            container.Controls.Add(uc);   
        }

        internal void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            SwitchingControlsManager(Panel_Principal, ucRegistroP.Instance(this));                           
        }

        //TODO: I have to refactor this code here
        private void Timer_Panel_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                Panel_Slide.Visible = true;
               // Panel_Slide.BringToFront();
                Panel_Slide.Height = Panel_Slide.Height + 10;
                if (Panel_Slide.Height >= panelHeight)
                {
                    Timer_Panel.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                Panel_Slide.Height = Panel_Slide.Height - 10;

                if (Panel_Slide.Height <= 0)
                {
                    Timer_Panel.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        internal void panel_Menu_Rigth_MouseMove(object sender, MouseEventArgs e)
        {
            OcultarPanel();
        }

        private void panelMenu_Left_MouseMove(object sender, MouseEventArgs e)
        {
            OcultarPanel();
        }

        private void Panel_Principal_MouseMove(object sender, MouseEventArgs e)
        {
            OcultarPanel();
        }

        internal void btnNuevaConsultaP_Click(object sender, EventArgs e)
        {
          SwitchingControlsManager(Panel_Principal, ucRealizarConsulta.Instance(this));
        }

        private void btnReportes_MouseMove(object sender, MouseEventArgs e)
        {
            Efecto.Instance.panelMoving(Panel_Barra, btnReportes,Efecto.VERTICAL);
            MostrarPanel();
            Efecto.VisibleNoVisible(Panel_Slide, Reportes_Panel);
        }
       
        private void btnReportePaciente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por Motivos de matenimiento al Sistema \nesta opcion no esta disonible po el momento");
        }
        
        internal void btnVerConsultas_Click(object sender, EventArgs e)
        {
                SwitchingControlsManager(Panel_Principal, ucVerConsultas.Instance(this));
        }

        internal void btnProgramarCita_Click(object sender, EventArgs e)
        {
                SwitchingControlsManager(Panel_Principal, ucCitasP.Instance(this));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_ConfigPricipal configuracion = new Form_ConfigPricipal();
            configuracion.ShowDialog();
        }

        internal void btnVerCitas_Click(object sender, EventArgs e)
        {
                SwitchingControlsManager(Panel_Principal, ucVerCitas.Instance(this));
        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {
            SwitchingControlsManager(Panel_Principal, ucDashboard.Instance(this));
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Por Motivos de matenimiento al Sistema \nesta opcion no esta disonible po el momento");
        }

        private void textBoxValidable1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
