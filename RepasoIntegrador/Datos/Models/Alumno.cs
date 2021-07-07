using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class Alumno : Persona
    {
        public int NroMatricula { get; set; }

        public Alumno(int id, string nombre, string apellido, string dni, int nroMatricula)
            :base(id,nombre,apellido,dni)
        {
            NroMatricula = nroMatricula;
        }
    }
}
