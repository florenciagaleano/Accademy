using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WindowsEF.Models;

namespace WindowsEF.Data
{
    public class DBPedidosContext : DbContext
    {
        //ctor default, se envia a base la palabra clave de la cadena de conexion
        public DBPedidosContext()
            : base("KeyDb")
        {

        }

        //preparo en EFla administracion de categorias yproductos
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
    }
}
