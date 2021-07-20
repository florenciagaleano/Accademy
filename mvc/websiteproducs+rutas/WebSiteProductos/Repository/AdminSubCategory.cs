using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using WebSiteProductos.Models;
using WebSiteProductos.Data;
using System.Data.Entity;

namespace WebSiteProductos.Repository
{
    public static class AdminSubCategory
    {

        private static ProductDbContext context = new ProductDbContext();
        //Traertodos
        public static List<Subcategory> Traertodos()
        {
            return context.Subcategories.ToList();

        }
        //TraerPorCategoryId
        public static List<Subcategory> TraerPorCategory(int categoryID)
        {
            return (from s in context.Subcategories
                    where s.CategoryID==categoryID
                    select s).ToList();
        }


        //TraerPorId
        public static Subcategory TraerPorId(int id)
        {
            return context.Subcategories.Find(id);
        }

        //Agregar
        public static int Agregar(Subcategory subcategory)
        {
            context.Subcategories.Add(subcategory);

            return context.SaveChanges();
        }

        //Modificar
        public static int Modificar(Subcategory subcategory)
        {
            context.Entry(subcategory).State = EntityState.Modified;
            return context.SaveChanges();
        }

        //Eliminar
        public static int Eliminar(Subcategory subcategory)
        {
            context.Subcategories.Remove(subcategory);
            return context.SaveChanges();
        }
    }
}