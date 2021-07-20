using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebSiteProductos.Models;
using WebSiteProductos.Data;
using System.Data.Entity;

namespace WebSiteProductos.Repository
{
    public static class AdminCategory
    {
        private static ProductDbContext context = new ProductDbContext();
        //Traertodos
        public static List<Category> Traertodos()
        {
            return context.Categories.ToList();
        
        }
       
        //TraerPorId
        public static Category TraerPorId(int id)
        {

            return context.Categories.Find(id);
        }

        //Agregar
        public static int Agregar(Category category)
        {
            context.Categories.Add(category);

            return context.SaveChanges();
        }

        //Modificar
        public static int Modificar(Category category)
        {
            context.Entry(category).State = EntityState.Modified;
            return context.SaveChanges();
        }

        //Eliminar
        public static int Eliminar(Category category)
        {
            context.Categories.Remove(category);
            return context.SaveChanges();
        }

    }
}