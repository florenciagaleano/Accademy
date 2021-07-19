using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TSQualityWebsite.Validation;

namespace TSQualityWebsite.Models
{
    public class Chofer
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(12)]
        public string Dni { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(100)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [CheckValidAge]
        public DateTime Nacimiento { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int CamionId { get; set; }

        public virtual Camion Camion { get; set; }

    }
}