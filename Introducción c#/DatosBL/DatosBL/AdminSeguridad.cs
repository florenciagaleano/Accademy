using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosBL
{
    public class AdminSeguridad
    {
        /// <summary>
        /// Validar las credenciales del usuario
        /// </summary>
        /// <param name="usuario">Se espera el nombre del usuario(cadena)</param>
        /// <param name="password">Se espera una password máximo 4 dígitos (cadena)</param>
        /// <returns>Retorna true si el usuario existe en la base, sino false</returns>
        public bool Autenticar(string usuario,string password)
        {
            if(usuario == "pepe" && password == "1234")
            {
                return true;
            }

            return false;
        }
    }
}
