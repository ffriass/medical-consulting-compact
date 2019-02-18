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
using System.Windows.Forms.DataVisualization.Charting;

namespace WinApp
{
    public partial class ucDashboard : UcPadre
    {
        private static ucDashboard instance;

        public ucDashboard()
        {
            InitializeComponent();
        }
        public ucDashboard(IManipulable manipulable)
            :base(manipulable)
        {
            InitializeComponent();
        }

        public static ucDashboard Instance(IManipulable manipulable)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ucDashboard(manipulable);
            }
            return instance;
        }
    }
}
