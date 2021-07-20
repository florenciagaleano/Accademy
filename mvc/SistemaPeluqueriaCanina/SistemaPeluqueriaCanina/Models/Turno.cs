using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaPeluqueríaCanina.Models
{
    public class Turno
    {
        public int TurnoID { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public DateTime Horario { get; set; }

        public List<Dueño> dueños{ get; set; }

        public int mascotaID { get; set; }

    }
}