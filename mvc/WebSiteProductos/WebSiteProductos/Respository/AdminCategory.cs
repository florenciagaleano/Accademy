using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSiteProductos.Models;
using WebSiteProductos.Data;
using System.Data.Entity;

namespace WebSiteProductos.Respository
{
    public static class AdminCategory
    {
        private static ProductoDbContext context = new ProductoDbContext();

        public static List<Category> TraerTodos()
        {
            return context.Categories.ToList();
        }

        public static Category TraerPorId(int id)
        {
            return context.Categories.Find(id);
        }

        public static int Agregar(Category category)
        {
            context.Categories.Add(category);
            return context.SaveChanges();
        }

        public static int Modificar(Category category)
        {
            context.Entry(category).State = EntityState.Modified;
            return context.SaveChanges();
        }

        public static int Eliminar(Category category)
        {
            context.Categories.Remove(category);
            return context.SaveChanges();
        }
    }
}