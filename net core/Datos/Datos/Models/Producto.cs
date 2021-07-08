using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    [Table("Producto")]
    public class Producto
    {

        [Key]
        public int IdProducto { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Column(TypeName = "money")]

        public decimal? Precio { get; set; }

        //[ForeignKey("IdSubCategoria")]
        public int IdSubCategoria { get; set; }

        [ForeignKey("IdSubCategoria")]
        public SubCategoria SubCategoria { get; set; }
        public int EmpleadoID { get; set; }
        //Propiedad de navegacion
        //[ForeignKey("EmpleadoID ")]
        //public Empleado Empleado { get; set; }


        public List<Empleado> Empleados { get; set; }
    }

}
