using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebSiteProductos.Models
{
    [Table("Subcategory")]
    public class Subcategory
    {
        //[Key] 
        public int SubcategoryID { get; set; }
        
        [Required(ErrorMessage = "Campo Obligatorio")]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [DisplayName("SubCategory Name")]
        public string SubcategoryName { get; set; }

        public int CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public Category Category { get; set; }
        public List<Product> Products { get; set; }

    }



}
 