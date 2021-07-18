using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebSiteProductos.Models;

namespace WebSiteProductos.Data
{
    public class ProductoDbContext : DbContext
    {
        public ProductoDbContext() : base("KeyDB")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}