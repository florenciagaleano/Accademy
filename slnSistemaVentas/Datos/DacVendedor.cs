using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.BaseDeDatos;
using Datos.Models;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Datos
{
    public class DacVendedor
    {
        public static List<Vendedor> Listar()
        {
            string consulta = "SELECT Id,Nombre,Apellido,DNI,Comision FROM dbo.Vendedor";
            SqlCommand comando = new SqlCommand(consulta, AdminDB.ConectarDB());
            List<Vendedor> vendedores = new List<Vendedor>();

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                vendedores.Add(new Vendedor((int)reader["Id"], reader["Nombre"].ToString(), reader["Apellido"].ToString(), reader["DNI"].ToString(), (decimal)reader["Comision"]));
            }
            reader.Close();
            AdminDB.ConectarDB().Close();
            return vendedores;
        }

        public static DataTable TraerPorId(int id)
        {
            string consultaSQL = "SELECT Id,Nombre,Apellido,DNI,Comision FROM dbo.Vendedor WHERE id=@id";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(consultaSQL, AdminDB.ConectarDB());

            dataAdapter.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds, "vendedores");

            return ds.Tables["vendedores"];
        }

        public static int Insert(Vendedor vendedor)
        {
            string consultaSql = "INSERT INTO  dbo.Vendedor(Nombre,Apellido,DNI,Comision) VALUES(@Nombre,@Apellido,@DNI,@Comision)";
            SqlCommand comando = new SqlCommand(consultaSql, AdminDB.ConectarDB());

            //comando.Parameters.Add("@Id", SqlDbType.Int).Value = profesor.Id;
            comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = vendedor.Nombre;
            comando.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = vendedor.Apellido;
            comando.Parameters.Add("@DNI", SqlDbType.Char, 11).Value = vendedor.Dni;
            comando.Parameters.Add("@Comision", SqlDbType.Decimal).Value = vendedor.Comision;


            int filasAfectadas = comando.ExecuteNonQuery();
            AdminDB.ConectarDB().Close();
            return filasAfectadas;
        }

        public static DataTable TraerPorComision(decimal comision)
        {
            string consulta = "SELECT Id,Nombre,Apellido,DNI,Comision FROM dbo.Vendedor WHERE comision=@comision";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(consulta, AdminDB.ConectarDB());

            dataAdapter.SelectCommand.Parameters.Add("@comision", SqlDbType.Decimal).Value = comision;

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds, "vendedoresPorComision");

            return ds.Tables["vendedoresPorComision"];
        }

        public static int Update(Vendedor vendedor)
        {
            string consultaSQL = "UPDATE dbo.Vendedor SET Nombre=@nombre,Apellido=@Apellido,DNI=@Dni,Comision=@Comision WHERE id=@Id";
            SqlCommand comando = new SqlCommand(consultaSQL, AdminDB.ConectarDB());

            comando.Parameters.Add("@Id", SqlDbType.Int).Value = vendedor.Id;
            comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = vendedor.Nombre;
            comando.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = vendedor.Apellido;
            comando.Parameters.Add("@DNI", SqlDbType.Char, 11).Value = vendedor.Dni;
            comando.Parameters.Add("@Comision", SqlDbType.Decimal).Value = vendedor.Comision;

            int filasAfectadas = comando.ExecuteNonQuery();
            AdminDB.ConectarDB().Close();

            return filasAfectadas;
        }

        public static int Delete(int id)
        {
            string consultaSql = "DELETE FROM dbo.Vendedor WHERE id=@id";
            SqlCommand comando = new SqlCommand(consultaSql, AdminDB.ConectarDB());

            comando.Parameters.Add("@id", SqlDbType.Int).Value = id;

            int filasAfectadas = comando.ExecuteNonQuery();
            AdminDB.ConectarDB().Close();
            return filasAfectadas;
        }
    }
}
