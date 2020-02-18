using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.Models
{
    public class Equipo
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public Pais Pais { get; set; }
        public Estado Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Deleted { get; set; }
    }
}
