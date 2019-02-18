using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioLibrary.CapaLogica
{
    class clTratamiento
    {
        int Trat_ID;
        string Trat_Descripcion;
        int Con_ID;

        public clTratamiento(int trat_ID, string trat_descripcion, int con_ID)
        {
            Trat_ID = trat_ID;
            Trat_Descripcion = trat_descripcion;
            Con_ID = con_ID;
        }

        public int ID { get {return  Trat_ID; }set { Trat_ID = value; }}
        public string Descripcion { get {return Trat_Descripcion; } set { Trat_Descripcion = value; }}
        public int ConsultaID { get { return Con_ID; } set { Con_ID = value; } }
    }

}
