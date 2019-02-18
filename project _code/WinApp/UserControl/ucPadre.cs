using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinApp.Interfaces;

namespace WinApp
{
    public partial class UcPadre : UserControl
    {
        public IManipulable manipulable;
        /*Receive a IOcultbale insterface as a parameter, for being able to
        change the value of the classes who implement this interface*/

        public UcPadre(IManipulable manipulable)
        {
            InitializeComponent();
            this.manipulable = manipulable;
        }

        public UcPadre()
        {           
            InitializeComponent();
        }


        protected void ucPadre_MouseMove(object sender, MouseEventArgs e)
        {
            manipulable.ocultar();
        }

        
        protected void enterNavigation(Control o)
        {
            foreach (Object objContainer in o.Controls)
            {
                if (objContainer is Control)
                {
                    Control foundContainer = (Control) objContainer;

                    foreach (Control objNavegable in foundContainer.Controls)
                    {
                        if (objNavegable is TextBoxBase )
                        {
                            Control tb = (Control)objNavegable;
                            tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ucPadre_KeyPress);
                        }
                        if(objNavegable is ComboBox)
                        {
                            ComboBox tb = (ComboBox)objNavegable;
                            tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ucPadre_KeyPress);
                        }
                    }
                }
            }
        }

        protected void ucPadre_Load(object sender, EventArgs e)
        {
            
        }

        private void ucPadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                //evito el pitido
                e.Handled = true;
                System.Windows.Forms.SendKeys.Send("{TAB}");
            }
        }
    }
}
