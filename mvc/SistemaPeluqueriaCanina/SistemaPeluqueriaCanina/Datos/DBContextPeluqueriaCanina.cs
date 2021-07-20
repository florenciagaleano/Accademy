using SistemaPeluqueríaCanina.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SistemaPeluqueriaCanina.Datos
{
    public class DBContextPeluqueriaCanina : DbContext
    {
        public DBContextPeluqueriaCanina()
            :base("KeyDB")
        {

        }

        public DbSet<Turno> Turnos { get; set; }
    }
}