using SistemaWebEmpleados.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SistemaWebEmpleados.Datos
{
    public class DbContextEmpleados : DbContext
    {
        public DbContextEmpleados()
            :base("KeyDB")
        {
        }

        public DbSet<Empleado> Empleados { get; set; }
    }
}