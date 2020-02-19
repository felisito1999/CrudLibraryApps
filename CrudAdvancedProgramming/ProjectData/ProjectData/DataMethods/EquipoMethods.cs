using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProjectData.Models;

namespace ProjectData.DataMethods
{
    public class EquipoMethods
    {
        public void InsertEquipos(Equipo equipo)
        {
            var connection = ConnectionFactory.GetConnection();
            string addEquiposCommand = "INSERT INTO Equipos VALUES(@nombreEquipo, @paisEquipo, @estado, @fechaCreacion, @deleted;";

            using (SqlCommand command = new SqlCommand(addEquiposCommand, connection))
            {
                command.Parameters.AddWithValue("@nombreEquipo", equipo.Nombre);
                command.Parameters.AddWithValue("@paisEquipo", equipo.Pais.CodigoPais);
                command.Parameters.AddWithValue("@estado", equipo.Estado.CodigoEstado);
                command.Parameters.AddWithValue("@fechaCreacion", equipo.FechaCreacion);
                command.Parameters.AddWithValue("@deleted", equipo.Deleted);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void UpdateEquipos(int id)
        {
            var connection = ConnectionFactory.GetConnection();
            string addEquiposCommand = "INSERT INTO Equipos VALUES(@nombreEquipo, @paisEquipo, @estado, @fechaCreacion, @deleted);";

            using (SqlCommand command = new SqlCommand(addEquiposCommand, connection))
            {
                Equipo equipo = new Equipo();

                command.Parameters.AddWithValue("@nombreEquipo", equipo.Nombre);
                command.Parameters.AddWithValue("@paisEquipo", equipo.Pais.CodigoPais);
                command.Parameters.AddWithValue("@estado", equipo.Estado.CodigoEstado);
                command.Parameters.AddWithValue("@fechaCreacion", equipo.FechaCreacion);
                command.Parameters.AddWithValue("@deleted", equipo.Deleted);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
