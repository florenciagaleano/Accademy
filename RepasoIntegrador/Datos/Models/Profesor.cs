using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class Profesor : Persona
    {
        public string Titulo { get; set; }

        public Profesor() { }
        public Profesor(int id, string nombre, string apellido, string dni, string titulo)
            : base(id, nombre, apellido, dni)
        {
            Titulo = titulo;
        }
    }
}
