using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaPeluqueríaCanina.Models
{
    public class Mascota
    {
        // Nombre Mascota, Raza, Dueño de la mascota, Teléfono, email, Día y Horario

        public int MascotaID { get; set; }

        [Required(ErrorMessage="Campo obligatorio")]
        [Column(TypeName="varchar")]
        [StringLength(50)]
        [DisplayName("Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [DisplayName("Raza")]
        public string Raza { get; set; }

        public int DueñoID { get; set; }

        [ForeignKey("DueñoID")]
        public Dueño Dueño { get; set; }
    }
}