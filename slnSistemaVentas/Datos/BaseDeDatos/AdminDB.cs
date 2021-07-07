using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Datos.BaseDeDatos
{
    internal static class AdminDB
    {
        internal static SqlConnection ConectarDB()
        {
            string cadena = Properties.Settings.Default.KeyDB;
            SqlConnection connection = new SqlConnection(cadena);
            connection.Open();

            return connection;
        }
    }
}
