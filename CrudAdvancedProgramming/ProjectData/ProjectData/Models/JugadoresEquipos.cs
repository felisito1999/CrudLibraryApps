using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.Models
{
    public class JugadoresEquipos
    {
        public int Codigo { get; set; }
        public Jugador Jugador { get; set; }
        public Equipo Equipos { get; set; }
        public Estado EstadoFirma { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinalizacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Deleted { get; set; }
    }
}
