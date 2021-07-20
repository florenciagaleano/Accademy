using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaPeluqueríaCanina.Models
{
    public class Dueño
    {
        public int DueñoID { get; set; } 
        
        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [DisplayName("Nombre")]

        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public int Telefono { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [DisplayName("Email")]
        public string Email { get; set; }

        public List<Turno> Turno { get; set; }

        public List<Mascota> Mascotas { get; set; }
        



    }
}