using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProjectData.Models;

namespace ProjectData.DataMethods
{
    public class EstadoMethods
    {
        public List<Estado> SelectAllEstados()
        {
            var connection = ConnectionFactory.GetConnection();
            string selectAllEstadosCommand = "SELECT CodigoEstado, DescripcionEstado FROM Estados";

            using (connection)
            {
                using (SqlCommand command = new SqlCommand(selectAllEstadosCommand, connection))
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    List<Estado> estadosList = new List<Estado>();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Estado estado = new Estado();

                            estado.CodigoEstado = reader.GetInt32(0);
                            estado.DescripcionEstado = reader.GetString(1);

                            estadosList.Add(estado);
                        }
                    }
                    connection.Close();
                    return estadosList;
                }
            }
        }
        public Estado SelectEstadoById(int id)
        {
            var connection = ConnectionFactory.GetConnection();
            string selectEstadoByIdCommand = "SELECT CodigoEstado, DescripcionEstado FROM Estados WHERE CodigoEstado = @id;";

            using (connection)
            {
                using (SqlCommand command = new SqlCommand(selectEstadoByIdCommand, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    Estado estado = new Estado();
                    while (reader.Read())
                    {
                        estado.CodigoEstado = reader.GetInt32(0);
                        estado.DescripcionEstado = reader.GetString(1);
                    }
                    connection.Close();
                    return estado;
                }
            }
        }
    }
}
