using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultorioLibrary.Fachada.FachadaDoctor;
using ConsultorioLibrary.Fachada.FachadaUsuario;

namespace WinApp
{
    public partial class Form_ConfigPricipal : Form
    {
        public Form_ConfigPricipal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form_ConfigPricipal_Load(object sender, EventArgs e)
        {
           // Form_Principal.SwitchingControlsManager(tabPageRegistro, panelTabRegistro);
        }


        private void tabPage1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            new SolutionHelper().BrowseFile(this.openFileDialogImage, this.imageUser);            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            
            byte[] file = new SolutionHelper().ConvertToByte(this.openFileDialogImage);

            bool resultadoOk = false;
            string mensajeError = "";
            int doctorID = 0;
            string UsEstato = "A";
            try
            {
                FachadaRegistroDoctor fachadaRegistroDoctor = new FachadaRegistroDoctor();
                doctorID = fachadaRegistroDoctor.Registrar(
                    txtDocNombre.Text
                    , txtDocApellido.Text
                    , txtDocCedula.Text
                    , txtDocCodigo.Text
                    , txtDocCelular.Text
                    , txtDocEmail.Text
                    , ref resultadoOk
                    , ref mensajeError);
                txtDocID.Text = doctorID.ToString();
                if (!checkBoxUsActivo.Checked)
                {
                    UsEstato = "I";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString()+" "+mensajeError);
            }
            

            FachadaRegistroUsuario registroUsuario = new FachadaRegistroUsuario();
            registroUsuario.Registrar(txtUserNombre.Text, txtUserPassword.Text, file, doctorID, 1, UsEstato, ref resultadoOk, ref mensajeError);
        }



    }
}
