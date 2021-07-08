using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
        [Table("Cliente")]
        public class Cliente
        {
            private int idCliente;

            public int IdCliente
            {
                get { return idCliente; }
                set { idCliente = value; }
            }
            private string nombre;
            [Required]
            [Column(TypeName = "varchar")]
            [StringLength(50)]
            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }
            private string apellido;
            [Required]
            [Column(TypeName = "varchar")]
            [StringLength(50)]
            public string Apellido
            {
                get { return apellido; }
                set { apellido = value; }
            }
            private DateTime fechaNacimiento;
            [Column(TypeName = "datetime")]
            public DateTime? FechaNacimiento
            {
                get { return fechaNacimiento; }
                set { fechaNacimiento = (DateTime)value; }
            }

        
        public List<Factura> Facturas { get; set; }
    }
}

