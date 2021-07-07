using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    internal static class AdminDB // internal ==> solo puede ser accedido dentro de la librería datos -- clase estática (no hace falta ser instanciada), que se utiliza para conectarse a la base de datos.
    {
        internal static SqlConnection ConectarDB() //Conectar a la base de datos.
        {
            string cadena = Properties.Settings.Default.KeyDB;
            SqlConnection connection = new SqlConnection(cadena);
            connection.Open();

            return connection;
        }
    }
}
