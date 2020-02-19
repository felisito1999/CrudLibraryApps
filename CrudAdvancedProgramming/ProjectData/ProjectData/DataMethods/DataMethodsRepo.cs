using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.DataMethods
{
    public class DataMethodsRepo
    {
        public JugadorMethods GetJugadorMethods()
        {
            return new JugadorMethods();
        }
        public EquipoMethods GetEquipoMethods()
        {
            return new EquipoMethods();
        }
        public EstadoMethods GetEstadoMethods()
        {
            return new EstadoMethods();
        }
        public PaisMethods GetPaisMethods()
        {
            return new PaisMethods();
        }
        public SexoMethods GetSexoMethods()
        {
            return new SexoMethods();
        }
        public EstadisticasJugadorMethods GetEstadisticasJugadorMethods()
        {
            return new EstadisticasJugadorMethods();
        }
    }
}
