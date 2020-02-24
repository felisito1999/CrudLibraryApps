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
                if (JuegosTotales != 0)
                    return PuntosTotales / JuegosTotales;
                else
                    return 0;
            }
        }
        public double RebotesPorJuego
        {
            get
            {
                if (RebotesTotales != 0)
                    return RebotesTotales / JuegosTotales;
                else
                    return 0;
            }
        }
        public double AsistenciasPorJuego
        {
            get
            {
                if (AsistenciasTotales != 0)
                    return AsistenciasTotales / JuegosTotales;
                else
                    return 0;
            }
        }
        public double TirosDeCampoIntentadosPorjuego 
        { 
            get
            {
                if (TirosDeCampoIntentados != 0)
                    return TirosDeCampoIntentados / JuegosTotales;
                else
                    return 0;
            }
        }
        public double TirosDeCampoEncestadosPorJuego 
        { 
            get
            {
                if  (TirosDeCampoEncestados != 0)
                    return TirosDeCampoEncestados / JuegosTotales;
                else
                    return 0;
            } 
        }
        public double PerdidasDeBalosPorJuego
        {
            get
            {
                if (PerdidasDeBalon != 0)
                    return PerdidasDeBalon / JuegosTotales;
                else
                    return 0;
            }
        }
    }
}
