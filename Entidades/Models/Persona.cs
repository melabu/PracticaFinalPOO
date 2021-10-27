using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Persona
    {
        public Persona() { }

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        #region
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        #endregion
    }
}
