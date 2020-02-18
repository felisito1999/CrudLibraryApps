using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using ProjectData.Models;

namespace ProjectData
{
    public class DataMethods
    {
        public void InsertJugador(Jugador jugador)
        {
            var connection = ConnectionFactory.GetConnection();
            string addJugadorCommand = "INSERT INTO Jugadores VALUES (@nombre, @apellido, @pais, @sexo, @fechaNacimiento," +
                "@fechaCreacion, @estado, @deleted)";

            using (connection)
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand(addJugadorCommand, connection))
                {
                    command.Parameters.AddWithValue("@nombre", jugador.Nombre);
                    command.Parameters.AddWithValue("@apellido", jugador.Apellido);
                    command.Parameters.AddWithValue("@pais", jugador.Pais.CodigoPais);
                    command.Parameters.AddWithValue("@sexo", jugador.Sexo.CodigoSexo);
                    command.Parameters.AddWithValue("@fechaNacimiento", jugador.FechaNacimiento);
                    command.Parameters.AddWithValue("@fechaCreacion", jugador.FechaCreacion);
                    command.Parameters.AddWithValue("@estado", jugador.Estado.CodigoEstado);
                    command.Parameters.AddWithValue("@deleted", jugador.Deleted);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public void UpdateJugador(Jugador jugador)
        {
            var connection = ConnectionFactory.GetConnection();
            string updateJugadorCommand = "UPDATE Jugadores SET NombreJugador = @nombre, Apellidojugador = @apellido, PaisJugador= @pais, " +
                "Sexo = @sexo, FechaNacimiento = @fechaNacimiento, fechaCreacion = @fechaCreacion, Estado = @estado, Deleted = @deleted " +
                "WHERE CodigoJugador = @id;";

            using (connection)
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(updateJugadorCommand, connection))
                {
                    command.Parameters.AddWithValue("@id", jugador.CodigoJugador);
                    command.Parameters.AddWithValue("@nombre", jugador.Nombre);
                    command.Parameters.AddWithValue("@apellido", jugador.Apellido);
                    command.Parameters.AddWithValue("@pais", jugador.Pais.CodigoPais);
                    command.Parameters.AddWithValue("@sexo", jugador.Sexo.CodigoSexo);
                    command.Parameters.AddWithValue("@fechaNacimiento", jugador.FechaNacimiento);
                    command.Parameters.AddWithValue("@fechaCreacion", DateTime.Now);
                    command.Parameters.AddWithValue("@estado", jugador.Estado.CodigoEstado);
                    command.Parameters.AddWithValue("@deleted", jugador.Deleted);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public void DeletedUpdateJugadores(int id)
        {
            var connection = ConnectionFactory.GetConnection();
            string deletedUpdateCommand = "UPDATE Jugadores SET Deleted = 1 WHERE CodigoJugador = @id;";

            using (connection)
            {
                using (SqlCommand command = new SqlCommand(deletedUpdateCommand,connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public List<Jugador> SelectAllJugadores()
        {
            var connection = ConnectionFactory.GetConnection();
            string selectAllJugadoresCommand = "SELECT a.CodigoJugador, a.NombreJugador AS Nombre, a.ApellidoJugador AS Apellido, b.NombrePais AS Pais, d.NombreSexo AS Sexo, FechaNacimiento " +
            "AS[Fecha de nacimiento], c.DescripcionEstado AS Estado FROM Jugadores a INNER JOIN Paises b ON a.PaisJugador = b.CodigoPais INNER JOIN Estados c ON " +
            "a.Estado = c.CodigoEstado INNER JOIN Sexos d ON a.Sexo = d.CodigoSexo;";

            using (connection)
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(selectAllJugadoresCommand, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    List<Jugador> jugadorList = new List<Jugador>();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Jugador jugador = new Jugador();
                            Pais pais = new Pais();
                            Sexo sexo = new Sexo();
                            Estado estado = new Estado();

                            pais.NombrePais = reader.GetString(3);
                            sexo.NombreSexo = reader.GetString(4);
                            estado.DescripcionEstado = reader.GetString(6);

                            jugador.CodigoJugador = reader.GetInt32(0);
                            jugador.Nombre = reader.GetString(1);
                            jugador.Apellido = reader.GetString(2);
                            jugador.Pais.NombrePais = pais.NombrePais;
                            jugador.Sexo.NombreSexo = sexo.NombreSexo;
                            jugador.FechaNacimiento = reader.GetDateTime(5);
                            jugador.Estado.DescripcionEstado = estado.DescripcionEstado;

                            jugadorList.Add(jugador);
                        }
                        reader.Close();
                    }
                    return jugadorList;
                }
            }
        }
        public Jugador SelectJugadorById(int id)
        {
            var connection = ConnectionFactory.GetConnection();

            string getJugadorByIdCommand = "SELECT CodigoJugador, Nombrejugador, ApellidoJugador, PaisJugador, Sexo, FechaNacimiento, Estado, Deleted FROM " +
                "Jugadores WHERE CodigoJugador = @id";
            
            using (connection)
            {
                using (SqlCommand command = new SqlCommand(getJugadorByIdCommand, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = command.ExecuteReader();

                    Jugador jugador = new Jugador();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var pais = SelectPaisesById(reader.GetInt32(3));
                            var sexo = SelectSexoById(reader.GetInt32(4));
                            var estado = SelectEstadoById(reader.GetInt32(6));

                            jugador.CodigoJugador = id;
                            jugador.Nombre = reader.GetString(1);
                            jugador.Apellido = reader.GetString(2);
                            jugador.Pais = pais;
                            jugador.Sexo = sexo;
                            jugador.FechaNacimiento = reader.GetDateTime(5);
                            jugador.Estado = estado;
                            jugador.Deleted = reader.GetBoolean(7);
                        }
                        connection.Close();
                    }
                    return jugador;
                }
            }
        }
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
                        while(reader.Read())
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
        public List<ViewJugador> SelectViewJugador()
        {
            var connection = ConnectionFactory.GetConnection();
            string selectAllJugadoresCommand = "SELECT a.CodigoJugador, a.NombreJugador AS Nombre, a.ApellidoJugador AS Apellido, b.NombrePais AS Pais, d.NombreSexo AS Sexo, FechaNacimiento " +
            "AS [Fecha de nacimiento], c.DescripcionEstado AS Estado FROM Jugadores a INNER JOIN Paises b ON a.PaisJugador = b.CodigoPais INNER JOIN Estados c ON " +
            "a.Estado = c.CodigoEstado INNER JOIN Sexos d ON a.Sexo = d.CodigoSexo WHERE a.Deleted = 0;";

            using (connection)
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(selectAllJugadoresCommand, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    List<ViewJugador> viewJugadorList = new List<ViewJugador>();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ViewJugador viewJugador = new ViewJugador();

                            viewJugador.CodigoJugador = reader.GetInt32(0);
                            viewJugador.Nombre = reader.GetString(1);
                            viewJugador.Apellido = reader.GetString(2);
                            viewJugador.NombrePais = reader.GetString(3);
                            viewJugador.NombreSexo = reader.GetString(4);
                            viewJugador.FechaNacimiento = reader.GetDateTime(5);
                            viewJugador.DescripcionEstado = reader.GetString(6);

                            viewJugadorList.Add(viewJugador);
                        }
                        reader.Close();
                    }
                    return viewJugadorList;
                }
            }
        }
    }
}
