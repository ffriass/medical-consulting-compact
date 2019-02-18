using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp.Interfaces
{
    public interface IManipulable
    {
       
        void ocultar();
        void mostrar();
        void manipular(UserControl destino, string valor);
    } 
}
