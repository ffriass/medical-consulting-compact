using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConsultorioLibrary.CapaDatos;

namespace ConsultorioLibrary.CapaLogica
{
    class Usuario
    {
        string usuario;
        string contrasena;
        string imageURL;

        public Usuario() { }
        public Usuario(string usuario, string contrasena, string imageURL)
        {
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.imageURL = imageURL;
        }

        public string ImageURL { get => imageURL; set => imageURL = value; }
        internal string User { get { return usuario; } set { usuario = value; } }
        internal string Password { get { return contrasena; } set { contrasena = value; } }

        internal DataTable IniciarSeccion(string usuario, string contrasena, int SubControl, ref bool ResultadoOK, ref string MensajeError)
        {
            DataTable DT = new DataTable();
            BusquedaUsuario ObjBusqueda = new BusquedaUsuario();
            DT = ObjBusqueda.SeleccionarUsuario(usuario, contrasena, SubControl, ref ResultadoOK, ref MensajeError);            
            return DT;
        } 
    }
}
