using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OperasWebSite.Validation
{
    public class CheckValidYear: ValidationAttribute
        //Aqui crearemos nuestras propias Validaciones
    {
        public CheckValidYear()
        {
            ErrorMessage = "The earliest opera is Daphne, 1598, by Corsi, Peri, and Rinuccini";
        }
        public override bool IsValid(object value)
            //sobre escribimos el comportamiento con Override(Polimorfismo)
        {
            //return base.IsValid(value);
            int year = (int)value;
            if (year < 1598)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}