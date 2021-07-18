using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebSiteProductos.Validations
{
    public class CheckColor : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string color = value.ToString();
            if(color == "Blanco" || color == "Negro")
            {
                return true;
            }

            return false;
        }

    }
}