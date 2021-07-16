using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OperasWebSite.Data;
using OperasWebSite.Models;

namespace OperasWebSite.Inicializer
{
    public class OperaDBInicializer: DropCreateDatabaseAlways<OperaDbContext>
    {
        protected override void Seed(OperaDbContext context)
        {
            //base.Seed(context);
            var operas = new List<Opera>()
            {
                new Opera()
                {
                    Title="Cosi Fan Tutte", Year=1790, Composer="Mozart",
                }
            };
            operas.ForEach(s => context.Operas.Add(s));
            context.SaveChanges();
        }
    }
}
