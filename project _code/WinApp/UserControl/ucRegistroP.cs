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
    public partial class ucRegistroP : UcPadre, IBuscable
    {

        private clFachadaGenero objFacchadaGenero = new clFachadaGenero();
        clFachadaPaciente objPaciente;
        private static ucRegistroP instance;

        public ucRegistroP()
        {
            InitializeComponent();
        }

        public ucRegistroP(IManipulable manipulable)
            : base(manipulable)
        {
            InitializeComponent();
        }

        public static ucRegistroP Instance(IManipulable manipulable)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ucRegistroP(manipulable);
            }                
            return instance;
        }

        #region inicializaciones
        private void ucRegistroP_Load(object sender, EventArgs e)
        {
            enterNavigation(this);
            LLenar_cbbGenero();
            LLenar_cbbEstadoCivil();
            LLenar_cbbTipoPaciente();
            LLenar_cbbZona();
            LLenar_cbbProvincia();
            LLenar_cbbCiudad();
            LLenar_cbbSector();
        }

        private void LLenar_cbbGenero()
        {
            cbbGenero.DisplayMember = "Gen_Descripcion";
            cbbGenero.ValueMember = "Gen_ID";          
            cbbGenero.DataSource = objFacchadaGenero.SeleccionarGenero(1);           
        }


        private void LLenar_cbbCiudad()
        {
            clFachadaCiudad objCiudad = new clFachadaCiudad();
            cbbCiudad.DisplayMember = "Mu_Nombre";
            cbbCiudad.ValueMember = "Mu_ID";
            cbbCiudad.DataSource = objCiudad.Seleccionar(1, Convert.ToInt32(cbbProvincia.SelectedValue));
        }

        private void LLenar_cbbSector()
        {
            //clFachadaSector objSector = new clFachadaSector();
            //cbbSector.DisplayMember = "Sec_Nombre";
            //cbbSector.ValueMember = "Sec_ID";

            //cbbSector.DataSource = objSector.Seleccionar(1, Convert.ToInt32(cbbCiudad.SelectedValue));

        }
        private void LLenar_cbbTipoPaciente()
        {
            clFachadaTipoPaciente objTipoPaciente = new clFachadaTipoPaciente();
            cbbTipoPaciente.DisplayMember = "TP_Descripcion";
            cbbTipoPaciente.ValueMember = "TP_ID";
            cbbTipoPaciente.DataSource = objTipoPaciente.Seleccionar(1);
        }

        private void LLenar_cbbProvincia()
        {
            clFachadaProvincia objProvincia = new clFachadaProvincia();
            cbbProvincia.DisplayMember = "Pro_Nombre";
            cbbProvincia.ValueMember = "Pro_ID";
            cbbProvincia.DataSource = objProvincia.Seleccionar(1);
        }

        private void LLenar_cbbEstadoCivil()
        {
            clFachadaEstadoCivil objEstadoCivil = new clFachadaEstadoCivil();
            cbbEstadoCivil.DisplayMember = "Est_Descripcion";
            cbbEstadoCivil.ValueMember = "Est_ID";
            cbbEstadoCivil.DataSource = objEstadoCivil.Seleccionar(1);
        }

        private void LLenar_cbbZona()
        {
            clFachadaZona objZona = new clFachadaZona();
            cbbZona.DisplayMember = "Zo_Nombre";
            cbbZona.ValueMember = "Zo_ID";
            cbbZona.DataSource = objZona.Seleccionar(1);
        }

        #endregion

        private void butSoloGuardarP_Click(object sender, EventArgs e)
        {
            if(Efecto.ValidarFormulario(this, ErrorDatos) == false)
            {
                objPaciente = new clFachadaPaciente();

                string Pa_Cedula;
                int Pa_ID = 0;
                int Domi_ID = 0;

                if (string.IsNullOrEmpty(txtExpediente.Text.Trim()))
                {
                    Pa_ID = 0;
                    Domi_ID = 0;
                }
                else
                {
                    try
                    {
                        Pa_ID = Convert.ToInt32(txtExpediente.Text);
                        Domi_ID = Convert.ToInt32(txtDomi_ID.Text);
                    }
                    catch { Pa_ID = 0; Domi_ID = 0; }
                }

                string Pa_Nombre = txtNombre.Text;
                string Pa_Apellido = txtApellido.Text;
                int Gen_ID = Convert.ToInt32(cbbGenero.SelectedValue);
                DateTime Pa_FechaNac = Convert.ToDateTime(dtpFechNaci.Text);

                if (string.IsNullOrEmpty(txtCedula.Text)) { Pa_Cedula = null; }
                else { Pa_Cedula = txtCedula.Text; }

                int Est_ID = Convert.ToInt32(cbbEstadoCivil.SelectedValue);
                string Pa_Telefono = txtTelefono.Text;
                string Pa_Celular = txtCelular.Text;
                string Pa_Email = txtEmail.Text;
                int TP_ID = Convert.ToInt32(cbbTipoPaciente.SelectedValue);
                int Zo_ID = Convert.ToInt32(cbbZona.SelectedValue);
                
                string Sector = txtSector.Text;
                string Calle = txtCalle.Text;
                string Numero = txtNumero.Text;
                int ciudad_ID = Convert.ToInt32(cbbCiudad.SelectedValue);
                bool ResultadoOk = false;
                string MensajeError = "";

                objPaciente.Registrar(ref Pa_ID, Pa_Nombre, Pa_Apellido, Gen_ID, Pa_FechaNac, Pa_Cedula, Est_ID, Pa_Telefono, Pa_Celular, Pa_Email, TP_ID, Zo_ID, Domi_ID, Sector, Calle, Numero, ciudad_ID, ref ResultadoOk, ref MensajeError);

                if (ResultadoOk)
                {
                    if (string.IsNullOrEmpty(txtExpediente.Text.Trim()))
                    {
                        MessageBox.Show("Paciente Guardado", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtExpediente.Text = Pa_ID.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Paciente Actualizado", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(MensajeError, "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {

            }       
        }

        private void cbbProvincia_SelectedValueChanged(object sender, EventArgs e)
        {
            LLenar_cbbCiudad();
        }

        private void cbbCiudad_SelectedValueChanged(object sender, EventArgs e)
        {
            LLenar_cbbSector();
        }

        private void btnGuardaryConsultar_Click(object sender, EventArgs e)
        {
            if (Efecto.ValidarFormulario(this, ErrorDatos) == false)
            {                
                manipulable.manipular(ucRealizarConsulta.Instance(manipulable), this.txtExpediente.Text);
                Efecto.LimpiarForm(this);
                
            }
         }

        private string ObtenerEdad(DateTime Fecha)
        {
            int Edad;
            txtCedula.Enabled = false;
            Edad = (DateTime.Today.AddTicks(-Fecha.Ticks).Year - 1);
            if (Edad == 0)
            {
                Edad = (DateTime.Today.AddTicks(-Fecha.Ticks).Month - 1);
                if (Edad == 1)
                {
                    return Edad + " Mes".ToString();
                }
                else
                {
                    return Edad + " Meses".ToString();
                }
            }
            else
            {
                if (Edad == 1)
                {
                    return Edad + " Año".ToString();
                }
                else
                {
                    if (Edad >= 18) { txtCedula.Enabled = true; }
                    return Edad + " Años".ToString();
                }
            }
        }

        private void dtpFechNaci_ValueChanged(object sender, EventArgs e)
        {
            dtpFechNaci.MinDate = new DateTime(1900, 6, 20);
            dtpFechNaci.MaxDate = DateTime.Today;
            if (!string.IsNullOrEmpty(dtpFechNaci.Text))
            {
                txtEdad.Text = ObtenerEdad(Convert.ToDateTime(dtpFechNaci.Text));
            }
                       
        }

        internal void btnBuscarP_Click(object sender, EventArgs e)
        {
            buscarPaciente();
        }

        void buscarPaciente()
        {
            string Busqueda;
            bool resultadoOK = false;
            string MensajeError = "";
            if (string.IsNullOrEmpty(txtBuscarP.Text))
            {
                Form_BuscarPaciente FormBuscar = new Form_BuscarPaciente(this);
                FormBuscar.ShowDialog();
            }
            else
            {
                clFachadaBusquedaPaciente objBuscar = new clFachadaBusquedaPaciente();
                DataTable DTPaciente = new DataTable();
                Busqueda = txtBuscarP.Text;
                DTPaciente = objBuscar.Buscar(Busqueda, 2, ref resultadoOK, ref MensajeError);
                if (DTPaciente.Rows.Count == 1)
                {
                    txtExpediente.Text = DTPaciente.Rows[0]["Pa_ID"].ToString();
                    txtNombre.Text = DTPaciente.Rows[0]["Pa_Nombre"].ToString();
                    txtApellido.Text = DTPaciente.Rows[0]["Pa_Apellido"].ToString();
                    txtCedula.Text = DTPaciente.Rows[0]["Pa_Cedula"].ToString();
                    txtTelefono.Text = DTPaciente.Rows[0]["Pa_Telefono"].ToString();
                    txtCelular.Text = DTPaciente.Rows[0]["Pa_Celular"].ToString();
                    txtEmail.Text = DTPaciente.Rows[0]["Pa_Email"].ToString();
                    dtpFechNaci.Value = Convert.ToDateTime(DTPaciente.Rows[0]["Pa_FechaNac"]);
                    txtDomi_ID.Text = DTPaciente.Rows[0]["Domi_ID"].ToString();
                    txtSector.Text = DTPaciente.Rows[0]["Domi_Sector"].ToString();
                    txtCalle.Text = DTPaciente.Rows[0]["Domi_calle"].ToString();
                    txtNumero.Text = DTPaciente.Rows[0]["Domi_Numero"].ToString();
                    cbbGenero.SelectedValue = Convert.ToUInt16(DTPaciente.Rows[0]["Gen_ID"]);
                    cbbEstadoCivil.SelectedValue = Convert.ToUInt16(DTPaciente.Rows[0]["Est_ID"]);
                    cbbTipoPaciente.SelectedValue = Convert.ToUInt16(DTPaciente.Rows[0]["TP_ID"]);
                    cbbZona.SelectedValue = Convert.ToUInt16(DTPaciente.Rows[0]["Zo_ID"]);
                    cbbProvincia.SelectedValue = Convert.ToUInt16(DTPaciente.Rows[0]["Pro_ID"]);
                    cbbCiudad.SelectedValue = Convert.ToUInt16(DTPaciente.Rows[0]["Mu_ID"]);
                }
                else
                {
                    MessageBox.Show("Paciente No encontrado" + " " + MensajeError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            Efecto.SoloLetrasOrNumeros('C', e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Efecto.SoloLetrasOrNumeros('L', e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Efecto.SoloLetrasOrNumeros('L', e);
        }

        private void txtSector_KeyPress(object sender, KeyPressEventArgs e)
        {
            Efecto.SoloLetrasOrNumeros('L', e);
        }

        private void txtBuscarP_KeyPress(object sender, KeyPressEventArgs e)
        {           
            Efecto.SoloLetrasOrNumeros('N', e);

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                btnBuscarP_Click(sender, e);
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ErrorDatos.SetError(txtNombre, "");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtExpediente.Text.Trim()))
            {
                ErrorDatos.SetError(txtExpediente, "No ha elegido \nningun pacinte");
            }
            else
            {
                bool ResultadoOK = false;
                string mensajeError = "";
                objPaciente = new clFachadaPaciente();
                try
                {
                    objPaciente.EliminarPaciente(Convert.ToInt32(txtExpediente.Text), 1, ref ResultadoOK, ref mensajeError);
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message.ToString());
                }

                if (ResultadoOK)
                {
                    MessageBox.Show("Paciente Elimnado con exito \n\n En cualquier momento puede restaurar el paciente ");
                    Efecto.LimpiarForm(this);
                }
                else
                {
                    MessageBox.Show("Paciente no Eliminado");
                }
                
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
           // Efecto.LimpiarFormulario(this);
            Efecto.LimpiarForm(this);
        }

        private void panelDatosPersonales_MouseHover(object sender, EventArgs e)
        {
            manipulable.ocultar();
        }

        private void panelOtrosDatos_MouseMove(object sender, MouseEventArgs e)
        {
            manipulable.ocultar();
        }

        //@Override
        public void buscar(string id)
        {
            txtBuscarP.Text = id;
            buscarPaciente();
        }

        private void cbbGenero_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
