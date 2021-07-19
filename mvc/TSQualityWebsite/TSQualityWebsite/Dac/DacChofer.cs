using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TSQualityWebsite.Datos;
using TSQualityWebsite.Models;

namespace TSQualityWebsite.Dac
{
    public class DacChofer
    {
        private static DBCamionesContext context = new DBCamionesContext();

        public static List<Chofer> TraerTodos()
        {
            return context.Choferes.ToList();
        }

        public static Chofer TraerPorId(int id)
        {
            return context.Choferes.Find(id);
        }

        public static int Insert(Chofer chofer)
        {
            context.Choferes.Add(chofer);
            return context.SaveChanges();
        }

        public static int Modify(Chofer chofer)
        {
            context.Entry(chofer).State = EntityState.Modified;
            return context.SaveChanges();
        }

        public static int Delete(Chofer chofer)
        {
            context.Choferes.Remove(chofer);
            return context.SaveChanges();
        }
    }
}