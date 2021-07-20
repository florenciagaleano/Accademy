using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebSiteProductos.Models;
using WebSiteProductos.Data;
using System.Data.Entity;


namespace WebSiteProductos.Repository
{
    public static class AdminProduct
    {

        private static ProductDbContext context = new ProductDbContext();

        public static IEnumerable<Product> TraerTodos()
        {
            return context.Products.ToList();
        }

        public static Product TraerPorId(int id)
        {
            return context.Products.Find(id);
        }

        public static IEnumerable<Product> TraerPorSubCategory(int subCategory)
        {
            var productos = (from p in context.Products where p.SubCategoryID == subCategory select p).ToList();
            return productos;
        }

        public static IEnumerable<Product> TraerPorColor(string color)
        {
            var productos = (from p in context.Products where p.Color == color select p).ToList();
            return productos;
        }

        public static int Agregar(Product product)
        {
            context.Products.Add(product);
            return context.SaveChanges();
        }

        public static int Modificar(Product product)
        {
            context.Entry(product).State = EntityState.Modified;
            return context.SaveChanges();
        }


        public static int Eliminar(Product product)
        {
            context.Products.Remove(product);
            return context.SaveChanges();
        }

    }

}
 