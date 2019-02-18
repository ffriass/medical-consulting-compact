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
    public partial class ucVerCitas : UcPadre
    {
        private static ucVerCitas instance;
        public ucVerCitas(IManipulable manipulable)
            :base(manipulable)
        {
            InitializeComponent();
        }

        public ucVerCitas()
        {
            InitializeComponent();
        }

        public static ucVerCitas Instance(IManipulable manipulable)           
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ucVerCitas(manipulable);
            }
                return instance;
        }

        private void ucVerCitas_MouseMove(object sender, MouseEventArgs e)
        {
            manipulable.ocultar();
        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvResuBusquedaP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
