using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    [Table("SubCategoria")]
    public class SubCategoria
    {

        [Key]
        public int IdSubCategoria { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]

        public string Nombre { get; set; }


       // [ForeignKey("CategoriaID")]
        public int IdCategoria { get; set; }
        public List<Producto> productos {get;set;}


        //propiedad de navegacion 
        [ForeignKey("CategoriaID")]
        public Categoria Categoria{ get; set; }

    }
}
    
