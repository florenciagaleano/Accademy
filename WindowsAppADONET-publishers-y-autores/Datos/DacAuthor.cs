using Datos.BaseDatos;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Datos
{
    public static class DacAuthor // DATA ACCESS AUTHOR -- clase estatica (no hace falta estar instanciada) que se encarga de realizar sentencias sql para la tabla de autores.
    {
        public static List<Author> Select_TraerTodos()
        {
            //2-- crear variable del tipo cadena para especificar la consulta SQL.
            string consultaSQL = "SELECT  au_id, au_lname, au_fname, au_fname, address, city,phone, state, zip , contract FROM  dbo.authors";

            //3-- preparar el SqlCommand.
            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.ConectarDB()); // conectarDB es un metodo que llama a abrir la conexion.

            //3-- declaramos un SqlReader.
            SqlDataReader reader;

            //4-- invocar ExecuteReader() del SqlCommand.
            reader = command.ExecuteReader(); // esto nos permite que el reader comience a recorrer los datos de la base de datos.

            //5-- recorrer los datos.
            List<Author> authors = new List<Author>();

            while (reader.Read())
            {
                authors.Add(
                   new Author()
                   {
                       Au_Id = reader[0].ToString(),
                       Au_Lname = reader["au_lname"].ToString(),
                       Au_Fname = reader["au_fname"].ToString(),
                       Address = reader["address"].ToString(),
                       City = reader["city"].ToString(),
                       State = reader["state"].ToString(),
                       Phone = reader["phone"].ToString(),
                       Zip = reader["zip"].ToString(),
                       Contract = (bool)reader["contract"]
                   }
                    );

            }

            //8--cerrar reader.
            reader.Close();

            //9-cerrar conexion -- MUY IMPORTANTE.
            AdminDB.ConectarDB().Close();

            return authors; //-- retorno la lista de autores.
        }

        public static int Insert(Author author)
        {
            string consultaSql = "INSERT INTO  dbo.authors(au_id, au_lname, au_fname, phone, address, city, state, zip, contract) VALUES(@au_id, @au_lname, @au_fname, @phone, @address, @city, @state, @zip, @contract)";
            SqlCommand comando = new SqlCommand(consultaSql, AdminDB.ConectarDB());

            comando.Parameters.Add("@au_id", SqlDbType.VarChar, 11).Value = author.Au_Id;
            comando.Parameters.Add("@au_lname", SqlDbType.VarChar, 40).Value = author.Au_Lname;
            comando.Parameters.Add("@au_fname", SqlDbType.VarChar, 20).Value = author.Au_Fname;
            comando.Parameters.Add("@phone", SqlDbType.Char, 12).Value = author.Phone;
            comando.Parameters.Add("@address", SqlDbType.VarChar, 40).Value = author.Address;
            comando.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = author.City;
            comando.Parameters.Add("@state", SqlDbType.Char, 2).Value = author.State;
            comando.Parameters.Add("@zip", SqlDbType.Char, 5).Value = author.Zip;
            comando.Parameters.Add("@contract", SqlDbType.Bit).Value = author.Contract;

            int filasAfectadas = comando.ExecuteNonQuery();
            AdminDB.ConectarDB().Close();
            return filasAfectadas;
        }

        public static int Update(Author author)
        {
            string consultaSQL = "UPDATE dbo.authors SET au_lname = @au_lname, au_fname = @au_fname, phone = @phone, address = @address, city = @city, state = @state, zip = @zip, contract = @contract WHERE au_id = @au_id";
            //2 crear sqlcommand
            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.ConectarDB());

            //3  declarar los parametros y asignar valores
            command.Parameters.Add("@au_id", SqlDbType.VarChar, 11).Value = author.Au_Id;
            command.Parameters.Add("@au_lname", SqlDbType.VarChar, 40).Value = author.Au_Lname;
            command.Parameters.Add("@au_fname", SqlDbType.VarChar, 20).Value = author.Au_Fname;
            command.Parameters.Add("@phone", SqlDbType.Char, 12).Value = author.Phone;
            command.Parameters.Add("@address", SqlDbType.VarChar, 40).Value = author.Address;
            command.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = author.City;
            command.Parameters.Add("@state", SqlDbType.Char, 2).Value = author.State;
            command.Parameters.Add("@zip", SqlDbType.Char, 5).Value = author.Zip;
            command.Parameters.Add("@contract", SqlDbType.Bit).Value = author.Contract;

            //4 ejecutar el UPDATE

            int filasAfectadas = command.ExecuteNonQuery();

            //cerrar conexión
            AdminDB.ConectarDB().Close();

            return filasAfectadas;

        }

        public static int Delete(int id)
        {
            string consultaSql = "DELETE FROM dbo.publishers      WHERE pub_id = @pub_id";
            SqlCommand comando = new SqlCommand(consultaSql, AdminDB.ConectarDB());

            comando.Parameters.Add("@au_id", SqlDbType.VarChar, 11).Value = id;

            int filasAfectadas = comando.ExecuteNonQuery();
            AdminDB.ConectarDB().Close();
            return filasAfectadas;
        }

        public static DataTable Select_TraerTodosDS()
        {
            string consultaSQL = "SELECT  au_id, au_lname, au_fname, au_fname, address, city,phone, state, zip , contract FROM  dbo.authors";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(consultaSQL, AdminDB.ConectarDB());

            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "authors");

            return ds.Tables["authors"];
        }

        public static DataTable Select_TraerPorId(string id)
        {
            string consultaSQL = "SELECT	Id,Nombre,Apellido,DNI,Titulo FROM dbo.Profesor WHERE id=@id";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(consultaSQL, AdminDB.ConectarDB());

            dataAdapter.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds,"profesores");

            return ds.Tables["profesores"];
        }
    }
}
