using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebSiteProductos.Data;
using WebSiteProductos.Models;

namespace WebSiteProductos.Respository
{
    public class AdminSubcategory
    {
        private static ProductoDbContext context = new ProductoDbContext();

        public static List<Subcategory> TraerTodos()
       {
            return context.Subcategories.ToList();
        }

        public static Subcategory TraerPorId(int id)
        {
            return context.Subcategories.Find(id);
        }

        public static IEnumerable<Subcategory> TraerPorCategory(int categoryId)
        {
            return (from s in context.Subcategories where s.CategoryID == categoryId select s).ToList();
        }

        public static int Agregar(Subcategory subcategory)
        {
            context.Subcategories.Add(subcategory);
            return context.SaveChanges();
        }

        public static int Modificar(Subcategory category)
        {
            context.Entry(category).State = EntityState.Modified;
            return context.SaveChanges();
        }

        public static int Eliminar(Subcategory category)
        {
            context.Subcategories.Remove(category);
            return context.SaveChanges();
        }
    }
}