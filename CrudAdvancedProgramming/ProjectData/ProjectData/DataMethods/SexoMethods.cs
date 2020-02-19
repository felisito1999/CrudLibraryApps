using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProjectData.Models;

namespace ProjectData.DataMethods
{
    public class SexoMethods
    {
        public List<Sexo> SelectAllSexos()
        {
            var connection = ConnectionFactory.GetConnection();
            string selectAllSexosCommand = "SELECT CodigoSexo, NombreSexo FROM Sexos";

            using (SqlCommand command = new SqlCommand(selectAllSexosCommand, connection))
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                List<Sexo> sexosList = new List<Sexo>();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Sexo sexo = new Sexo();

                        sexo.CodigoSexo = reader.GetInt32(0);
                        sexo.NombreSexo = reader.GetString(1);

                        sexosList.Add(sexo);
                    }
                    connection.Close();
                }
                return sexosList;
            }
        }
        public Sexo SelectSexoById(int id)
        {
            var connection = ConnectionFactory.GetConnection();
            string selectSexoByIdCommand = "SELECT CodigoSexo, NombreSexo FROM Sexos WHERE CodigoSexo = @id;";

            using (connection)
            {
                using (SqlCommand command = new SqlCommand(selectSexoByIdCommand, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    Sexo sexo = new Sexo();
                    while (reader.Read())
                    {
                        sexo.CodigoSexo = reader.GetInt32(0);
                        sexo.NombreSexo = reader.GetString(1);
                    }
                    connection.Close();
                    return sexo;
                }
            }
        }
    }
}
