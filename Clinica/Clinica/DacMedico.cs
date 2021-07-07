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
    /*--Select_TraerTodos()-->Retorna una lista de médicos
    --Select_TraerPorEspecialidad(Especialidad)-->Retorna una lista de médicos de esa especialidad
    --Select_TraerPorId(Int Id)-->Retorna un Médico → En el cuerpo usar un //TODO lo implementaremos luego
    --Insertar(medico)
    --Eliminar(IdMedico)
    --Realizar las pruebas de DacMedico en un formulario de windows
    */
    public static class DacMedico
    {
        public static List<Medico> TraerMedios()
        {
            List<Medico> lista = new List<Medico>();

            string consulta = "SELECT Nombre, Apellido, Matricula, Especialidad FROM dbo.Medico";

            SqlCommand comando = new SqlCommand(consulta, AdminDB.ConectarDB());
            SqlDataReader reader = new SqlDataReader();

            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                
            }


            return lista;
        }
    }
}
