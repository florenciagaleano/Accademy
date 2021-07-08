using Datos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Data
{
    public class DBFacturacionContext : DbContext
    {
        public DBFacturacionContext() : base("KEYDB") { }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<DetalleFactura> DetallesFacturas { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<SubCategoria> SubCategorias { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }

}
