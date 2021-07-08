using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
  
        [Table("DetalleFactura")]
        public class DetalleFactura
        {
            public int IdDetalleFactura { get; set; }

            public int IdFactura { get; set; }

            [ForeignKey("IdFactura")]
            public Factura Factura { get; set; }

            [Column(TypeName = "money")]
            public decimal Precio { get; set; }

            public int Cantidad { get; set; }

            [Required]
            [Column(TypeName = "varchar")]
            [StringLength(50)]
            public string Descripcion { get; set; }

            public int IdProducto { get; set; }
            [ForeignKey("IdProducto")]
            public Producto Producto { get; set; }
        }

    }

