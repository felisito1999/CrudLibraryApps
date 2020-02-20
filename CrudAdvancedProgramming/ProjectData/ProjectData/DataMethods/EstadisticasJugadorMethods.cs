using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProjectData.Models;

namespace ProjectData.DataMethods
{
    public class EstadisticasJugadorMethods
    {
        public EstadisticasJugador SelectEstadisticasByIdJugador(int idJugador)
        {
            var connection = ConnectionFactory.GetConnection();
            string selectEstadisticasByIdCommand = "SELECT CodigoStats, CodigoJugador, PuntosTotales, AsistenciasTotales, RebotesTotales, TirosDeCampoIntentados, " +
                "TirosDeCampoEncestados, PerdidasDeBalon, JuegosTotales, JuegosIniciados, FechaCreacion, Deleted, FROM EstadisticasJugador" +
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
        public void InsertEstadisticasJugador(EstadisticasJugador estadisticas, Jugador jugador)
        {
            var connection = ConnectionFactory.GetConnection();
            string insertEstadisticasCommand = "INSERT INTO EstadisticasJugador VALUES (@CodigoJugador, @PuntosTotales, @AsistenciasTotales, @RebotesTotales, @TirosDeCampoIntentados, " +
                "@TirosDeCampoEncestadosyokjnb );"
        }
    }
}
