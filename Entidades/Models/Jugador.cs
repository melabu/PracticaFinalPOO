using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Jugador:Persona
    {
        public Jugador() { }

        public Jugador(int id, string nombre, string apellido, DateTime fechaNacimiento, string puesto) : base(nombre, apellido)
        {
            this.Id = id;
            this.FechaNacimiento = fechaNacimiento;
            this.Puesto = puesto;
        }

        public Jugador(string nombre, string apellido, DateTime fechaNacimiento, string puesto) : base (nombre, apellido)
        {
            this.FechaNacimiento = fechaNacimiento;
            this.Puesto = puesto;
        }

        #region
        public DateTime FechaNacimiento { get; set; }
        public string Puesto { get; set; }
        #endregion
    }
}
