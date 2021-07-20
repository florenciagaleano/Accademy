using SistemaWebAlumnos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SistemaWebAlumnos.Datos
{
    public class DBContextEstudiantes : DbContext
    {
        public DBContextEstudiantes()
            :base("KeyDB")
        {

        }

        public DbSet<Alumno> Alumnos { get; set; }
    }
}