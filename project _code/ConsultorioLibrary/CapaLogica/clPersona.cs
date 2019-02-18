using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioLibrary.CapaLogica
{
    class clPersona
    {
        protected int per_ID;
        protected string per_Nombre;
        protected string per_Apellidos;
        protected DateTime per_Fecha_Nac;
        protected int per_Genero;
        protected string per_Cedula;
        protected string per_Calle;
        protected int per_Sector;
        protected int per_Domicilio;
        protected DateTime per_FechaCreacion;
        protected int per_Estado_Civil;

        internal int ID { get { return per_ID; } set { per_ID = value; } }
        internal string Nombre { get{ return per_Nombre; }set{ per_Nombre = value; }}
        internal string Apellidos { get{ return per_Apellidos; }set{ per_Apellidos = value; }}
        internal DateTime Fecha_Nacimiento { get{ return per_Fecha_Nac; }set{ per_Fecha_Nac = value; }}
        internal int Genero { get{ return per_Genero; }set{ per_Genero = value; }}
        internal string Cedula { get{ return per_Cedula; }set{ per_Cedula = value; }}
        internal string Calle { get { return per_Calle; } set { per_Calle = value; } }
        internal int Sector { get{ return per_Sector; }set{ per_Sector = value; }}
        internal int EstadoCivil { get { return per_Estado_Civil; } set { per_Estado_Civil = value; } }
        internal DateTime FechaCreacion { get{ return per_FechaCreacion; }set{ per_FechaCreacion = value; }}
        internal int DomicilioID { get { return per_Domicilio; } set { per_Domicilio = value; } }
        public clPersona() { }

        public clPersona( int ID, string Nombre, string Apellidos,int Genero, DateTime Fecha_Nac, string Cedula, int Estado_Civil)
        {
            this.per_ID = ID;
            this.per_Nombre = Nombre;
            this.per_Apellidos = Apellidos;
            this.per_Fecha_Nac = Fecha_Nac;
            this.per_Genero = Genero;
            this.per_Cedula = Cedula;
            this.per_Sector = Sector;
            this.per_Estado_Civil = Estado_Civil;
        }


    }
}
