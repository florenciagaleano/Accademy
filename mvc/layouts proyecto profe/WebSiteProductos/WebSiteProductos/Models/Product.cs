using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebSiteProductos.Validations;

namespace WebSiteProductos.Models
{
    [Table("Product")]
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [DisplayName("Product Number")]
        public string ProductNumber { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [CheckColor]
        public string Color { get; set; }

        public int DaysToManuFacture { get; set; }

        [Column(TypeName = "date")]
        public DateTime SellStartDate { get; set; }

        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString =
"{0:dd/MM/yy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.DateTime)]
        [DisplayName("Sell End Date")]
         public DateTime SellEndDate { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Size { get; set; }

        [Column(TypeName = "money")]
        [CheckListPrice]
        public decimal ListPrice { get; set; }

        public int SubCategoryID { get; set; }

        [ForeignKey("SubCategoryID")]
        public Subcategory SubCategory { get; set; }

    }

}