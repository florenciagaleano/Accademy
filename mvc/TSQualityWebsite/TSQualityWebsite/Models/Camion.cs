using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TSQualityWebsite.Models
{
    public class Camion
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(6)]
        public string Matricula { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(50)]
        public string Marca { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public int Modelo { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public int ChoferId { get; set; }
        [ForeignKey("ChoferId")] //el fk se usa cuando hay muchos datos asociados entre                             tablas, y cuando hay listas
        public virtual IEnumerable<Chofer> Chofer { get; set; }

    }
}