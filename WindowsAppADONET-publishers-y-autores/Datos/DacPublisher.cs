using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Datos.Models;
using Datos.BaseDatos;   

namespace Datos
{
    public class DacPublisher
    {
        public static List<Publisher> Select_TraerTodos()
        {
            //2-- crear variable del tipo cadena para especificar la consulta SQL.
            string consultaSQL = "SELECT pub_id, pub_name,city,state,country FROM  dbo.publishers";

            //3-- preparar el SqlCommand.
            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.ConectarDB()); // conectarDB es un metodo que llama a abrir la conexion.

            //3-- declaramos un SqlReader.
            SqlDataReader reader;

            //4-- invocar ExecuteReader() del SqlCommand.
            reader = command.ExecuteReader(); // esto nos permite que el reader comience a recorrer los datos de la base de datos.

            //5-- recorrer los datos.
            List<Publisher> lista = new List<Publisher>();

            while (reader.Read())
            {
                lista.Add(new Publisher(reader["pub_id"].ToString(), reader["pub_name"].ToString(), reader["city"].ToString(), reader["state"].ToString(), reader["country"].ToString()));

            }

            //8--cerrar reader.
            reader.Close();

            //9-cerrar conexion -- MUY IMPORTANTE.
            AdminDB.ConectarDB().Close();

            return lista; //-- retorno la lista de autores.
        }
        public static int Insert(Publisher publisher)//ok
        {
            string consultaSql = "INSERT INTO  dbo.publishers(pub_id,pub_name,city,state,country) VALUES(@pub_id,@pub_name,@city,@state,@country)";
            SqlCommand comando = new SqlCommand(consultaSql, AdminDB.ConectarDB());

            comando.Parameters.Add("@pub_id", SqlDbType.VarChar, 4).Value = publisher.Id;
            comando.Parameters.Add("@pub_name", SqlDbType.VarChar, 40).Value = publisher.Pub_name;
            comando.Parameters.Add("@state", SqlDbType.VarChar, 20).Value = publisher.State;
            comando.Parameters.Add("@country", SqlDbType.Char, 2).Value = publisher.Country;
            comando.Parameters.Add("@city", SqlDbType.Char, 30).Value = publisher.City;


            int filasAfectadas = comando.ExecuteNonQuery();
            AdminDB.ConectarDB().Close();
            return filasAfectadas;
        }

        public static int Update(Publisher p)
        {
            string consultaSQL = "UPDATE dbo.publishers SET pub_id=@pub_id,pub_name=@pub_name,city=@city,state=@state,country=@country";
            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.ConectarDB());

            command.Parameters.Add("@pub_id", SqlDbType.VarChar, 4).Value = p.Id;
            command.Parameters.Add("@pub_name", SqlDbType.VarChar, 40).Value = p.Pub_name;
            command.Parameters.Add("@state", SqlDbType.VarChar, 20).Value = p.State;
            command.Parameters.Add("@country", SqlDbType.Char, 2).Value = p.Country;
            command.Parameters.Add("@city", SqlDbType.Char, 30).Value = p.City;

            int filasAfectadas = command.ExecuteNonQuery();
            AdminDB.ConectarDB().Close();

            return filasAfectadas;
        }

        public static int Delete(string id)
        {
            string consultaSql = "DELETE FROM dbo.publishers      WHERE pub_id = @pub_id";
            SqlCommand comando = new SqlCommand(consultaSql, AdminDB.ConectarDB());

            comando.Parameters.Add("@pub_id", SqlDbType.VarChar, 4).Value = id;

            int filasAfectadas = comando.ExecuteNonQuery();
            AdminDB.ConectarDB().Close();
            return filasAfectadas;
        }
    }
}

