using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TSQualityWebsite.Datos;
using TSQualityWebsite.Models;
using System.Data.Entity;

namespace TSQualityWebsite.Datos
{
    public static class DacCamion
    {
        private static DBCamionesContext context = new DBCamionesContext();

        public static List<Camion> TraerTodos()
        {
            return context.Camiones.ToList();
        }

        public static Camion TraerPorId(int id)
        {
            return context.Camiones.Find(id);
        }

        public static int Insert(Camion camion)
        {
            context.Camiones.Add(camion);
            return context.SaveChanges();
        }

        public static int Modify(Camion camion)
        {
            context.Entry(camion).State = EntityState.Modified;
            return context.SaveChanges();
        }

        public static int Delete(Camion camion)
        {
            context.Camiones.Remove(camion);
            return context.SaveChanges();
        }
    }
}