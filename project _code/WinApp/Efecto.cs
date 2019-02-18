using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public class Efecto
    {
        public const int VERTICAL = 1;
        public const int HORIZAONTAL = 2;

        private static Efecto instance;
        private Efecto() { }
        //a singleton patern to this class
        public static Efecto Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Efecto();
                }
                return instance;
            }
        }

        public void panelMoving(Control barra, Control boton, int orientation)
        {
            if (orientation == VERTICAL)
            {
                barra.Width = boton.Width;
                barra.Left = boton.Left;
            }
            else if (orientation == HORIZAONTAL)
            {
                barra.Height = boton.Height;
                barra.Top = boton.Top;
            }
        }

        //for making the transcition panel hiding effect and add a letter to the clicked button
        public static void MostrarOcultar(Control control, Button boton )
        {
            if(control.Visible)
            {
                control.Visible = false;
                boton.Text = "+";
            }
            else
            {
                control.Visible = true;
                boton.Text = "-";
            }
         }

        public static void VisibleNoVisible(Control container, Control conteinedPanel)
        {
            /*Search into container to make all Controls into it invisible excep for 
            the one tha is in the paramter, it is conteinedPanel.*/
            foreach (Panel pn in container.Controls)
            {
                if (pn == conteinedPanel) {pn.Visible = true;}
                else{pn.Visible = false;}
            }
        }

        public static string ObtenerEdad(DateTime Fecha)
        {
            int Edad;            
            Edad = (DateTime.Today.AddTicks(-Fecha.Ticks).Year - 1);
            if (Edad == 0)
            {
                Edad = (DateTime.Today.AddTicks(-Fecha.Ticks).Month - 1);
                if (Edad == 1){
                    return Edad + " Mes".ToString();
                }
                else {
                    return Edad + " Meses".ToString();
                }
            }
            else
            {
                if (Edad == 1){
                    return Edad + " Año".ToString();
                }
                else{
                    return Edad + " Años".ToString();
                }
            }
        }

       /* public static Boolean ValidarFormulario1(Control Objeto, ErrorProvider ErrorProvider)
        {
            Boolean HayErrores = false;

            foreach (Control Item in Objeto.Controls)
            {
                if (Item is TextBoxValidable)
                {
                    TextBoxValidable Obj = (TextBoxValidable)Item;

                    if (Obj.Validar == true)
                    {
                        if (string.IsNullOrEmpty(Obj.Text.Trim()))
                        {
                            ErrorProvider.SetError(Obj, "No puede estar vacio");
                            HayErrores = true;
                        }
                    }
                    else
                    {
                        ErrorProvider.SetError(Obj, "");
                    }
                }
            }

            return HayErrores;
        }*/
         
        public static void RemoveText(Control TextBox)
        {    
             TextBox.Text = "";
        }

        public static void AddText(Control TextBox, string Texto)
        {
         if(String.IsNullOrWhiteSpace(TextBox.Text))
             TextBox.Text = Texto;
           }

        public static void SoloLetrasOrNumeros(char Opcion, KeyPressEventArgs e)
        {
            if (Opcion == 'N' || Opcion == 'n')
            {
                if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
                {
                    e.Handled = true;
                    return;
                }
            }
            else if (Opcion == 'L' || Opcion == 'l')
            {
                if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
                {
                    if ((e.KeyChar == ' ') || (e.KeyChar == 'ñ') || (e.KeyChar == 'Ñ'))
                    {
                        e.Handled = false;
                        return;
                    }
                    e.Handled = true;
                    return;
                }
            }
            else if (Opcion == 'C' || Opcion == 'c')
            {
                if ((e.KeyChar >= 32 && e.KeyChar <= 44) || (e.KeyChar == 47) || (e.KeyChar >= 58 && e.KeyChar <= 63) || (e.KeyChar >= 91 && e.KeyChar <= 94)
                    || e.KeyChar == 96 || (e.KeyChar >= 123 && e.KeyChar <= 255))
                {
                    e.Handled = true;
                    return;
                }
            }

            else if (Opcion == 'T' || Opcion == 't')
            {
                if ((e.KeyChar >= 126 && e.KeyChar <= 163) || (e.KeyChar >= 166 && e.KeyChar <= 255))
                {
                    if ((e.KeyChar == ' ') ||( e.KeyChar >= 160 || e.KeyChar >=165 ))
                    {
                        e.Handled = false;
                        return;
                    }

                    e.Handled = true;
                    return;
                }
            }
        }

        public static Boolean ValidarFormulario(Control Objeto, ErrorProvider ErrorProvider)
        {
            Boolean HayErrores = false;

            foreach (Control Item in Objeto.Controls)
            {
                if (Item is Panel)
                {
                    
                    Panel ObjPanel = (Panel)Item;

                    foreach (Control Text in ObjPanel.Controls)
                    {
                        if (Text is TextBoxValidable)
                        {
                            TextBoxValidable ObjErrorTextBox = (TextBoxValidable)Text;
                            if (ObjErrorTextBox.Validar == true)
                            {
                                if (string.IsNullOrEmpty(ObjErrorTextBox.Text.Trim()))
                                {
                                    ErrorProvider.SetError(ObjErrorTextBox, "No puede estar vacio");
                                    ObjErrorTextBox.Focus();
                                    HayErrores = true;
                                }
                            }
                            else
                            {
                                ErrorProvider.SetError(ObjErrorTextBox, "");
                            }
                        }
                        else if (Text is ComboBox)
                        {
                            ComboBox objErrorComboBox = (ComboBox)Text;
                            if (Convert.ToInt32(objErrorComboBox.SelectedValue) == 0)
                            {                             
                                ErrorProvider.SetError(objErrorComboBox, "No puede estar vacio");
                                objErrorComboBox.Focus();
                                    HayErrores = true;     
                            }
                            else
                            {
                                ErrorProvider.SetError(objErrorComboBox, "");
                            }
                        }
                    }
                }
               else if (Item is TextBoxValidable)
                {
                    TextBoxValidable ObjErrorTextBox = (TextBoxValidable)Item;
                    if (ObjErrorTextBox.Validar == true)
                    {
                        if (string.IsNullOrEmpty(ObjErrorTextBox.Text.Trim()))
                        {
                            ErrorProvider.SetError(ObjErrorTextBox, "No puede estar vacio");
                            ObjErrorTextBox.Focus();
                            HayErrores = true;
                        }
                    }
                    else
                    {
                        ErrorProvider.SetError(ObjErrorTextBox, "");
                    }
                }
            }
            return HayErrores;
        }

        public static void LimpiarForm(Control Objeto)
        {
            foreach (Control Item in Objeto.Controls)
            {
                if (Item is Control)
                {
                    Control ObjConatiner = (Control)Item;

                    foreach (Control editable in ObjConatiner.Controls)
                    {
                        if (editable is TextBoxBase)
                        {
                            TextBoxBase objText = (TextBoxBase)editable;
                            objText.Clear();
                        }
                        if (editable is ListControl)
                        {
                            ListControl objListControl = (ListControl)editable;
                            objListControl.SelectedIndex = 0;
                        }
                        if(editable is ButtonBase)
                        {
                            ButtonBase buttonBase = (ButtonBase) editable;
                            buttonBase.Refresh();
                        }
                    }//End foreach editable
                }
            }//End foreach of object
        }//End Method LimpiarForm
    }   
}

