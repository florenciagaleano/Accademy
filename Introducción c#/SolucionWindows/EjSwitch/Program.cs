using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa numero: ");
            string num = Console.ReadLine();
            num = num.ToLower();

            switch (num)
            {
                case "uno":
                    Console.WriteLine(1);
                    break;
                case "dos":
                    Console.WriteLine(1);
                    break;
                case "tres":
                    Console.WriteLine(1);
                    break;
                case "cuatro":
                    Console.WriteLine(1);
                    break;
                case "cinco":
                    Console.WriteLine(1);
                    break;
                default:
                    Console.WriteLine("Valor fuera de rango");
                    break;
            }



            Console.ReadKey();
        }
    }
}
