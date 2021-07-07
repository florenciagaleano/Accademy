using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Clinica
{
    internal static class AdminDB
    {
        internal static SqlConnection ConectarDB()
        {
            string cadena = Properties.Settings.Default.KeyDB;
            SqlConnection conexion = new SqlConnection(cadena);

            conexion.Open();
            return conexion;
        }
    }
}
