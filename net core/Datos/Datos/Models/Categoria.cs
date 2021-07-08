using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    
        [Table("Categoria")]
        public class Categoria
        {
            [Key]
            public int IdCategoria { get; set; }

            [Required]
            [Column(TypeName = "varchar")]
            [StringLength(50)]
            public string Nombre { get; set; }
        public List<SubCategoria> Subcategorias { get; set; }

    }

}

