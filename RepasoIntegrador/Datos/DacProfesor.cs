using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;


namespace Datos
{
    public class DacProfesor
    {
        public static List<Profesor> Listar()
        {
            string consulta = "SELECT	Id,Nombre,Apellido,DNI,Titulo FROM dbo.Profesor";
            SqlCommand comando = new SqlCommand(consulta, AdminDB.ConectarDB()); // conectarDB es un metodo que llama a abrir la conexion.
            List<Profesor> profesores = new List<Profesor>();

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                profesores.Add(new Profesor((int)reader["Id"], reader["Nombre"].ToString(), reader["Apellido"].ToString(), reader["DNI"].ToString(), reader["Titulo"].ToString()));
            }
            reader.Close();
            AdminDB.ConectarDB().Close();
            return profesores;
        }

        public static DataTable TraerPorId(string id)
        {
            string consultaSQL = "SELECT Id,Nombre,Apellido,DNI,Titulo FROM dbo.Profesor WHERE id=@id";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(consultaSQL, AdminDB.ConectarDB());

            dataAdapter.SelectCommand.Parameters.Add("@id", SqlDbType.VarChar, 11).Value = id;

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds, "profesores");

            return ds.Tables["profesores"];
        }

        public static int Insert(Profesor profesor)
        {
            string consultaSql = "INSERT INTO  dbo.Profesor(Nombre,Apellido,DNI,Titulo) VALUES(@Nombre,@Apellido,@DNI,@Titulo)";
            SqlCommand comando = new SqlCommand(consultaSql, AdminDB.ConectarDB());

            //comando.Parameters.Add("@Id", SqlDbType.Int).Value = profesor.Id;
            comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = profesor.Nombre;
            comando.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = profesor.Apellido;
            comando.Parameters.Add("@DNI", SqlDbType.Char, 11).Value = profesor.DNI;
            comando.Parameters.Add("@Titulo", SqlDbType.VarChar, 50).Value = profesor.Titulo;


            int filasAfectadas = comando.ExecuteNonQuery();
            AdminDB.ConectarDB().Close();
            return filasAfectadas;
        }

        public static int Update(Profesor p)
        {
            string consultaSQL = "UPDATE dbo.Profesor SET Nombre=@nombre,Apellido=@apellido,DNI=@dni,Titulo=@titulo WHERE id=@id";
            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.ConectarDB());

            command.Parameters.Add("@id", SqlDbType.VarChar, 4).Value = p.Id;
            command.Parameters.Add("@nombre", SqlDbType.VarChar, 40).Value = p.Nombre;
            command.Parameters.Add("@apellido", SqlDbType.VarChar, 20).Value = p.Apellido;
            command.Parameters.Add("@dni", SqlDbType.Char, 2).Value = p.DNI;
            command.Parameters.Add("@titulo", SqlDbType.Char, 30).Value = p.Titulo;

            int filasAfectadas = command.ExecuteNonQuery();
            AdminDB.ConectarDB().Close();

            return filasAfectadas;
        }

        public static int Delete(int id)
        {
            string consultaSql = "DELETE FROM dbo.Profesor WHERE id=@id";
            SqlCommand comando = new SqlCommand(consultaSql, AdminDB.ConectarDB());

            comando.Parameters.Add("@id", SqlDbType.VarChar, 4).Value = id;


            int filasAfectadas = comando.ExecuteNonQuery();
            AdminDB.ConectarDB().Close();
            return filasAfectadas;
        }
    }
}
