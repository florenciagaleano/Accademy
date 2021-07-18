using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebSiteProductos.Data;
using WebSiteProductos.Models;

namespace WebSiteProductos.Respository
{
    public class AdminProduct
    {
        private static ProductoDbContext context = new ProductoDbContext();

        public static List<Product> TraerTodos()
        {
            return context.Products.ToList();
        }

        public static Product TraerPorId(int id)
        {
            return context.Products.Find(id);
        }

        public IEnumerable<Product> TraerPorSubcategory(int subCategory)
        {
            var productos = (from p in context.Products where p.SubcategoryID == subCategory select p).ToList();
            return productos;
        }

        public IEnumerable<Product> TraerPorColor(string color)
        {
            var productos = (from p in context.Products where p.Color == color select p).ToList();
            return productos;
        }


        public static int Agregar(Product subcategory)
        {
            context.Products.Add(subcategory);
            return context.SaveChanges();
        }

        public static int Modificar(Product category)
        {
            context.Entry(category).State = EntityState.Modified;
            return context.SaveChanges();
        }

        public static int Eliminar(Product category)
        {
            context.Products.Remove(category);
            return context.SaveChanges();
        }
    }
}