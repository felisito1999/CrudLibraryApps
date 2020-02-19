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
        public void SelectEstadisticasById(int id)
        {
            var connection = ConnectionFactory.GetConnection();
            string selectEstadisticasByIdCommand = "SELECT CodigoStats, CodigoJugador, PuntosTotales, AsistenciasTotales, RebotesTotales, TirosDeCampoIntentados, " +
                "TirosDeCampoEncestados, PerdidasDeBalon, JuegosTotales, JuegosIniciados, JuegosTotales, JuegosIniciados, FechaCreacion, Deleted, FROM EstadisticasJugador;";

            using (connection)
            {
                using (SqlCommand command = new SqlCommand(selectEstadisticasByIdCommand, connection))
                {
                    connection.Open();
                    
                    SqlDataReader reader = command.ExecuteReader();
                    List<EstadisticasJugador> estadisticasJugadorList = new List<EstadisticasJugador>();

                    if (reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            EstadisticasJugador estadisticasJugador = new EstadisticasJugador();
                            estadisticasJugador.CodigoStats = reader.GetInt32(0);
                        }
                    }
                }
            }
        }
    }
}
