using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public abstract class Persona
    {
        public Persona() { }
        public Persona(int id, string nombre, string apellido, string dNI)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dNI;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
    }
}
