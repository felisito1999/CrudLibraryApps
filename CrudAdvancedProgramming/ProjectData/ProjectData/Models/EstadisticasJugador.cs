using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.Models
{
    public class EstadisticasJugador
    {
        public EstadisticasJugador()
        {
            this.AsistenciasPorJuego = 2;
        }
        public int CodigoStats { get; set; }
        public Jugador Jugador { get; set; }
        public int PuntosTotales { get; set; }
        public int AsistenciasTotales { get; set; }
        public int RebotesTotales { get; set; }
        public int TirosDeCampoIntentados { get; set; }
        public int TirosDeCampoEncestados { get; set; }
        public int PerdidasDeBalon { get; set; }
        public int JuegosTotales { get; set; }
        public int JuegosIniciados { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Deleted { get; set; }
        public double PuntosPorJuego { 
            get 
            {
                return PuntosTotales / JuegosTotales;
            }
        }
        public double RebotesPorJuego
        {
            get
            {
                return RebotesTotales / JuegosTotales;
            }
        }
        public double AsistenciasPorJuego
        {
            get
            {
                return AsistenciasTotales / JuegosTotales;
            }
        }
        public double TirosDeCampoIntentadosPorjuego 
        { 
            get
            {
                return TirosDeCampoIntentados / JuegosTotales;
            }
        }
        public double TirosDeCampoEncestadosPorJuego 
        { 
            get
            {
                return TirosDeCampoEncestados / JuegosTotales;
            } 
        }
        public double PerdidasDeBalosPorJuego
        {
            get
            {
                return PerdidasDeBalon / JuegosTotales;
            }
        }
    }
}
