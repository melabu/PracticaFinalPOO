using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Entrenador : Persona
    {
        public Entrenador() { }

        public Entrenador(string nombre, string apellido, string domicilio, string telefono, string titulo): base (nombre, apellido)
        {
            this.Domicilio = domicilio;
            this.Telefono = telefono;
            this.Titulo = titulo;
        }

        #region
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Titulo { get; set; }
        #endregion
    }
}
