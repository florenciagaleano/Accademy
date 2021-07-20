using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebSiteProductos.Validations
{
    public class CheckColor : ValidationAttribute
    {
        //public override string FormatErrorMessage(string color)
        //{
        //    return base.FormatErrorMessage("El color debe ser blaco o negro");
        //}
        public override bool IsValid(object value)
        {
            string color = value.ToString();

            if (color == "Blanco" || color == "Negro")
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