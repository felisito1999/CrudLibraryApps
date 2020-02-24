using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProjectData.Models;

namespace ProjectData.DataMethods
{
    public class PaisMethods
    {
        public List<Pais> SelectAllPaises()
        {
            var connection = ConnectionFactory.GetConnection();
            string selectAllPaisesCommand = "SELECT CodigoPais, NombrePais FROM Paises;";

            using (connection)
            {
                using (SqlCommand command = new SqlCommand(selectAllPaisesCommand, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    List<Pais> paisesList = new List<Pais>();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Pais pais = new Pais();

                            pais.CodigoPais = reader.GetInt32(0);
                            pais.NombrePais = reader.GetString(1);

                            paisesList.Add(pais);
                        }
                    }
                    connection.Close();
                    return paisesList;
                }
            }
        }
        public IEnumerable<Pais> SelectAllPaisesWeb()
        {
            var connection = ConnectionFactory.GetConnection();
            string selectAllPaisesCommand = "SELECT CodigoPais, NombrePais FROM Paises;";

            using (connection)
            {
                using (SqlCommand command = new SqlCommand(selectAllPaisesCommand, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    IEnumerable<Pais> paisesList = new List<Pais>();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Pais pais = new Pais();

                            pais.CodigoPais = reader.GetInt32(0);
                            pais.NombrePais = reader.GetString(1);

                            paisesList.Append(pais);
                        }
                    }
                    connection.Close();
                    return paisesList;
                }
            }
        }
        public Pais SelectPaisesById(int id)
        {
            var connection = ConnectionFactory.GetConnection();
            string selectPaisesByIdCommand = "SELECT CodigoPais, NombrePais, ISO_Pais FROM Paises WHERE CodigoPais = @id";

            using (connection)
            {
                using (SqlCommand command = new SqlCommand(selectPaisesByIdCommand, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    Pais pais = new Pais();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            pais.CodigoPais = reader.GetInt32(0);
                            pais.NombrePais = reader.GetString(1);
                            pais.ISO_Pais = reader.GetString(2);
                        }
                    }
                    return pais;
                }
            }
        }
    }
}
