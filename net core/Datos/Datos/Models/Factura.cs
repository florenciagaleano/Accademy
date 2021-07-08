using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    [Table("Factura")]
    public class Factura
    {
        public int FacturaId { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime Fecha { get; set; }

        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }

        public int EmpleadoId { get; set; }
        [ForeignKey("EmpleadoId ")]
        public Empleado Empleado { get; set; }

        public List<DetalleFactura> detalleFacturas { get; set; }
    }

}
