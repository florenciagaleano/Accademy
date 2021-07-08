using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEF
{
    [Table("Categoria")]
    public class Categoria
    {
        public int IdCategoria { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [ForeignKey("")]
        public List<Subcategoria> Subcategorias { get; set; }
        /*[Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }*/

        /*[Required]//required es para obligatorio NOT NULL, puede hber más de uno
        [Column(TypeName = "varchar")]//cambio tipo de dato en la base - varchar-> cadena variable
        [StringLength(50)]
        public string Nombre { get; set; }*/

        //propiedad de navegacion


    }
}
