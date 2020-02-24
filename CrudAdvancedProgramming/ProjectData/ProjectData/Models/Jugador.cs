using ProjectData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData
{
    public class Jugador
    {
        
        public int CodigoJugador { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreCompleto {
            get
            {
                return Nombre + ' ' + Apellido;
            }
        }
        public Pais Pais { get; set; }
        public Sexo Sexo { get; set; }
        public Estado Estado { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Deleted { get; set; }
    }
}
