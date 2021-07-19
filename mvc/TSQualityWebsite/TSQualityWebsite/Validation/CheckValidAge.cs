using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TSQualityWebsite.Validation
{
    public class CheckValidAge : ValidationAttribute
    {
        public CheckValidAge()
        {
            ErrorMessage = "Edad no valida";
        }

        public override bool IsValid(object value)
        {
            int nacimiento = ((DateTime)value).Year;
            int edad = DateTime.Now.Year - nacimiento;

            if(edad >= 18 && edad < 60)
            {
                return true;
            }

            return false;
        }
    }
}