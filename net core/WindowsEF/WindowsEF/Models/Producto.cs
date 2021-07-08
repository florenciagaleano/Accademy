using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEF
{
    [Table("Producto")]
    public class Producto
    {
        public int Id { get; set; }

        [Required]//required es para obligatorio NOT NULL, puede hber más de uno
        [Column(TypeName = "varchar")]//cambio tipo de dato en la base - varchar-> cadena variable
        [StringLength(50)]
        public string Nombre { get; set; }

        [Column(TypeName ="money")]
        public decimal Precio { get; set; }

        //public int CategoriaID { get; set; }

        //propiedad de navegación
        [ForeignKey("CategoriaID")]
        //public Categoria Categoria { get; set; }
    }
}
