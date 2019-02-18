using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioLibrary.CapaLogica
{
    class clCondicionFisica
    {
        int CondidionFisica_ID;
        decimal CondF_Peso;
        decimal Cond_Talla;
        decimal CondF_IndiceMC;
        decimal CondF_Temp;
        int CondF_Sistolica;
        int CondF_Diastolica;
        int Exa_ID;

        public clCondicionFisica(int condidionFisica_ID, decimal condF_Peso, decimal cond_Talla, decimal condF_IndiceMC, decimal condF_Temp, int condF_Sistolica, int condF_Diastolica, int exa_ID)
        {
            CondidionFisica_ID = condidionFisica_ID;
            CondF_Peso = condF_Peso;
            Cond_Talla = cond_Talla;
            CondF_IndiceMC = condF_IndiceMC;
            CondF_Temp = condF_Temp;
            CondF_Sistolica = condF_Sistolica;
            CondF_Diastolica = condF_Diastolica;
            Exa_ID = exa_ID;

        }

        public int ID { get { return CondidionFisica_ID; } set { CondidionFisica_ID = value; }}
        public decimal Peso { get { return  CondF_Peso; } set { CondF_Peso = value; }}
        public decimal Talla { get { return Cond_Talla;} set { Cond_Talla = value; }}
        public decimal IndiceMC { get { return CondF_IndiceMC;} set { CondF_IndiceMC = value; }}
        public decimal Temperatura { get { return CondF_Temp;} set { CondF_Temp = value; }}
        public int PresaionAlta { get { return CondF_Sistolica; } set { CondF_Sistolica = value; }}
        public int PresionBaja { get { return CondF_Diastolica; } set { CondF_Diastolica = value; }}
        public int ExamenFisicoID { get { return Exa_ID; } set { Exa_ID = value; } }


    }
}
