﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Club
    {
        public Club(string nombre, string domicilio, string telefono)
        {
            this.Nombre = nombre;
            this.Domicilio = domicilio;
            this.Telefono = telefono;
        }

        #region
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        #endregion
    }
}
