﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConsultorioLibrary.CapaLogica;

namespace ConsultorioLibrary.Fachada
{
    public class clFachadaZona
    {
        public DataTable Seleccionar(int SubControl)
        {
           clZona objZona = new clZona();
           return objZona.Seleccionar(SubControl);
        }
    }
}
