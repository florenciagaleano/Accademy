using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    public class Medico
    {
        public Medico(int id, string nombre, string apellido, int matricula, string especialidad)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Matricula = matricula;
            Especialidad = especialidad;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Matricula { get; set; }
        public string Especialidad { get; set; }
    }
}
