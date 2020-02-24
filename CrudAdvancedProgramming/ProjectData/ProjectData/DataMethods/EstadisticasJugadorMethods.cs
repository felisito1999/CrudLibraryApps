using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProjectData.Models;
using ProjectData.DataMethods;

namespace ProjectData.DataMethods
{
    public class EstadisticasJugadorMethods
    {
        DataMethodsRepo dataMethodsRepo = new DataMethodsRepo();
        public EstadisticasJugador SelectEstadisticasByIdJugador(int idJugador)
        {
            var connection = ConnectionFactory.GetConnection();
            string selectEstadisticasByIdCommand = "SELECT CodigoStats, CodigoJugador, PuntosTotales, AsistenciasTotales, RebotesTotales, TirosDeCampoIntentados, " +
                "TirosDeCampoEncestados, PerdidasDeBalon, JuegosTotales, JuegosIniciados, FechaCreacion, Deleted FROM EstadisticasJugador " +
                "WHERE CodigoJugador = @id AND Deleted = 0;";

            using (connection)
            {
                using (SqlCommand command = new SqlCommand(selectEstadisticasByIdCommand, connection))
                {
                    command.Parameters.AddWithValue("@id", idJugador);
                    connection.Open();
                    
                    SqlDataReader reader = command.ExecuteReader();
                    EstadisticasJugador estadisticasJugador = new EstadisticasJugador();

                    if (reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            Jugador jugador = new Jugador();
                            jugador.CodigoJugador = reader.GetInt32(1);
                    
                            estadisticasJugador.CodigoStats = reader.GetInt32(0);
                            estadisticasJugador.Jugador = jugador;
                            estadisticasJugador.PuntosTotales = reader.GetInt32(2);
                            estadisticasJugador.AsistenciasTotales = reader.GetInt32(3);
                            estadisticasJugador.RebotesTotales = reader.GetInt32(4);
                            estadisticasJugador.TirosDeCampoIntentados = reader.GetInt32(5);
                            estadisticasJugador.TirosDeCampoEncestados = reader.GetInt32(6);
                            estadisticasJugador.PerdidasDeBalon = reader.GetInt32(7);
                            estadisticasJugador.JuegosTotales = reader.GetInt32(8);
                            estadisticasJugador.JuegosIniciados = reader.GetInt32(9);
                        }
                        connection.Close();
                    }
                    return estadisticasJugador;
                }
            }
        }
        public void InsertEstadisticasJugador(EstadisticasJugador estadisticas)
        {
            var connection = ConnectionFactory.GetConnection();
            string insertEstadisticasCommand = "INSERT INTO EstadisticasJugador VALUES (@codigoJugador, @puntosTotales, @asistenciasTotales, @rebotesTotales, @tirosDeCampoIntentados, " +
                "@tirosDeCampoEncestados, @perdidasDeBalon, @juegosTotales, @juegosIniciados, @fechaCreacion, @deleted);";

            using(connection)
            {
                using (SqlCommand command = new SqlCommand(insertEstadisticasCommand, connection))
                {
                    command.Parameters.AddWithValue("@codigoJugador",estadisticas.Jugador.CodigoJugador);
                    command.Parameters.AddWithValue("@puntosTotales",estadisticas.PuntosTotales);
                    command.Parameters.AddWithValue("@asistenciasTotales", estadisticas.AsistenciasTotales);
                    command.Parameters.AddWithValue("@rebotesTotales",estadisticas.RebotesTotales);
                    command.Parameters.AddWithValue("@tirosDeCampoIntentados", estadisticas.TirosDeCampoIntentados);
                    command.Parameters.AddWithValue("@tirosDeCampoEncestados", estadisticas.TirosDeCampoEncestados);
                    command.Parameters.AddWithValue("@perdidasDeBalon", estadisticas.PerdidasDeBalon);
                    command.Parameters.AddWithValue("@juegosTotales", estadisticas.JuegosTotales);
                    command.Parameters.AddWithValue("@juegosIniciados", estadisticas.JuegosIniciados);
                    command.Parameters.AddWithValue("@fechaCreacion", estadisticas.FechaCreacion);
                    command.Parameters.AddWithValue("@deleted", estadisticas.Deleted);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public void UpdateEstadisticasJugador(EstadisticasJugador estadisticas)
        {
            var connection = ConnectionFactory.GetConnection();
            string updateEstadisticasCommand = "UPDATE EstadisticasJugador SET PuntosTotales = @puntosTotales, AsistenciasTotales = @asistenciasTotales, RebotesTotales = @rebotesTotales, " +
                "TirosDeCampoIntentados = @tirosIntentados, TirosDeCampoEncestados = @tirosEncestados, PerdidasDeBalon = @perdidasDeBalon, JuegosTotales = @juegosTotales, " +
                "JuegosIniciados = @juegosIniciados WHERE CodigoJugador = @codigoJugador";
            using (connection)
            {
                using (SqlCommand command = new SqlCommand(updateEstadisticasCommand, connection))
                {
                    

                    command.Parameters.AddWithValue("@codigoJugador", ObjectIds.CodigoJugador);
                    command.Parameters.AddWithValue("@puntosTotales", estadisticas.PuntosTotales);
                    command.Parameters.AddWithValue("@asistenciasTotales", estadisticas.AsistenciasTotales);
                    command.Parameters.AddWithValue("@rebotesTotales", estadisticas.RebotesTotales);
                    command.Parameters.AddWithValue("@tirosIntentados", estadisticas.TirosDeCampoIntentados);
                    command.Parameters.AddWithValue("@tirosEncestados", estadisticas.TirosDeCampoEncestados);
                    command.Parameters.AddWithValue("@perdidasDeBalon", estadisticas.PerdidasDeBalon);
                    command.Parameters.AddWithValue("@juegosTotales", estadisticas.JuegosTotales);
                    command.Parameters.AddWithValue("@juegosIniciados", estadisticas.JuegosIniciados);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
    }
}
