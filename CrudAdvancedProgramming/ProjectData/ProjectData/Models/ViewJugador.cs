using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.Models
{
    public class ViewJugador
    {
        public int CodigoJugador { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreCompleto
        {
            get
            {
                return Nombre + ' ' + Apellido;
            }
        }
        public string NombrePais { get; set; }
        public string NombreSexo { get; set; }
        public string DescripcionEstado { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
