using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioLibrary.CapaLogica
{
    class clDomicilio
    {


        string Domi_Sector;
        string Domi_Calle;
        string Domi_Numero;
        int Domi_ID;
        int Mu_ID;

        public clDomicilio() { }
        public clDomicilio (int Domi_ID, string Domi_Sector, string Domi_Calle, string Domi_Numero, int Mu_ID )
        {
            this.Domi_Sector = Domi_Sector;
            this.Domi_Calle = Domi_Calle;
            this.Domi_Numero = Domi_Numero;
            this.Mu_ID = Mu_ID;
            this.Domi_ID = Domi_ID;
        }

        public string Sector { get {return  Domi_Sector;} set { Domi_Sector = value; }}
        public string Calle { get { return Domi_Calle;} set { Domi_Calle = value; }}
        public string Numero { get { return Domi_Numero; } set { Domi_Numero = value; }}
        public int MunicipioID { get { return Mu_ID;} set { Mu_ID = value; }}
        public int ID { get { return Domi_ID; } set { Domi_ID = value; } }
    }
}
