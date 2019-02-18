using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultorioLibrary.Fachada.FachadaUsuario;

namespace WinApp
{ 
    public partial class FormLogin : Form
    {
        string user = "";
        string password = "";
        string mensajeError = "";
        bool resultadoOk = false;
        int subControl = 0;
        DataTable dataTable = new DataTable();
        ErrorProvider errorProvider = new ErrorProvider();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }
       
        private void signIn()
        {
            Autenticacion aut = Autenticacion.Instance;

            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                errorProvider.SetError(txtUserName, "Debe llenar el usuario");                
            }
            else
            {
                
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    user = txtUserName.Text;
                    subControl = 3;//para seleccionar solo por el usuario y verificar si existe;
                    dataTable = aut.IniciarSeccion(user, password, subControl, ref resultadoOk, ref mensajeError);
                    if (dataTable.Rows.Count == 1)
                    {
                        panelPasswordContainer.Visible = true;
                        txtPassword.Focus();
                        txtUserName.Enabled = false;
                        lblBienvenido.Visible = true;
                        btnBack.Visible = true;
                        string nombre = dataTable.Rows[0]["Doc_Nombre"].ToString();
                        string apellido = dataTable.Rows[0]["Doc_Apellido"].ToString();
                      
                        if (!string.IsNullOrEmpty(dataTable.Rows[0]["Us_Foto"].ToString()))
                        {
                            byte[] imgageURL = (byte[])dataTable.Rows[0]["Us_Foto"];
                            imgUserLogin.Image = SolutionHelper.ConvertToImage(imgageURL);
                        }
                            
                        lblUserInfoName.Text = nombre;
                        lblUserInfoLastName.Text = apellido;
                        btnLogin.Text = "Sing In";
                    }
                    else
                    {
                        MessageBox.Show("Usuario no Encontrado");
                    }

                }
                else
                {
                    password = txtPassword.Text;
                    subControl = 2;//para seleccionar solo por el usuario y la contyrasena;
                    dataTable = aut.IniciarSeccion(user, password, subControl, ref resultadoOk, ref mensajeError);
                    if(dataTable.Rows.Count == 1)
                    {
                        //El usuario  esta autenticado
                        Form_Principal FP = new Form_Principal();
                        FP.receiveUser(dataTable);
                        FP.Show();
                        Efecto.LimpiarForm(this);
                        this.Hide();
                        //this.Close();
                    }
                    else
                    {
                        errorProvider.SetError(txtPassword, "Contraseña Inavalida");
                    }
                }
                
            }
        }
        

        private void lblCloseAppliation_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            signIn();
        }

        private void txtUserName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            txtUserName.Enabled = true;
            txtPassword.Text = "";
            panelPasswordContainer.Hide();

        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider.SetError(txtUserName, "");
        }
    }
}
