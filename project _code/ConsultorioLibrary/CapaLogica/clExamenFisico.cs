using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioLibrary.CapaLogica
{
    class clExamenFisico
    {
        int Exa_ID;
        string Exa_Descripcion;
        int Con_ID;

        public clExamenFisico(int exa_ID, string exa_Descripcion, int con_ID)
        {
            Exa_ID = exa_ID;
            Exa_Descripcion = exa_Descripcion;
            Con_ID = con_ID;
        }

        public int ID { get {return Exa_ID;} set { Exa_ID = value; } }
        public string ExaDescripcion { get {return Exa_Descripcion; } set { Exa_Descripcion = value; }}
        public int ConsultaID { get { return Con_ID; } set { Con_ID = value; } }


    }
}
