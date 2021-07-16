using OperasWebSite.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OperasWebSite.Models
{
    public class Opera
    {
        public int OperaId { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(200)]
        public string Title { get; set; }

        [CheckValidYear]
        public int Year { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Composer { get; set; }
    }
}
