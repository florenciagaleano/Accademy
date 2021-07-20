using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SistemaWebAlumnos.Models;

namespace SistemaWebAlumnos.Data
{
    public class AlumnoDbContext: DbContext
    {
        public AlumnoDbContext() : base("KeyDb") { }

        public DbSet<Alumno> alumnos { get; set; }
    }
}