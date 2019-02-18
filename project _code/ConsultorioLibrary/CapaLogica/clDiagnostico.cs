using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioLibrary.CapaLogica
{
    class clDiagnostico
    {
        int Dia_ID;
        string Dia_Descripcion;
        int Consulta_ID;

        public clDiagnostico(int dia_ID, string dia_descripcion, int consulta_ID)
        {
            Dia_ID = dia_ID;
            Dia_Descripcion = dia_descripcion;
            Consulta_ID = consulta_ID;
        }

        public int ID { get { return Dia_ID;} set { Dia_ID = value; }}
        public string Descripcion { get { return Dia_Descripcion; } set { Dia_Descripcion = value; } }
        public int ConsultaID { get { return Consulta_ID; } set { Consulta_ID = value; } }
    }
}
