using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebSiteProductos.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        
        [DisplayName("Category Name")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string CategoryName { get; set; }

        public List<Subcategory> Subcategories { get; set; }
    }


}