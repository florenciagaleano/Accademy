using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebSiteProductos.Validations
{
    public class CheckListPrice : ValidationAttribute
    {

        public override bool IsValid(object value)
        {
            decimal listPrice = (decimal)value;

            if (listPrice > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
