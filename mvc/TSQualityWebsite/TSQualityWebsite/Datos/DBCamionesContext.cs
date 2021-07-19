using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TSQualityWebsite.Models;

namespace TSQualityWebsite.Datos
{
    public class DBCamionesContext : DbContext
    {
        public DBCamionesContext()
           : base("KeyDB")
        {
            DateTime nacimiento = new DateTime(2021, 2, 12);
            int edad = DateTime.Now.Year - nacimiento.Year;
        }

        public DbSet<Chofer> Choferes { get; set; }

        public DbSet<Camion> Camiones { get; set; }
    }
}