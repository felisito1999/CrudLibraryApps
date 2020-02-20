using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectData.DataMethods;

namespace CrudAppNBA
{
    public partial class frmEstadisticasjugador : Form
    {
        public frmEstadisticasjugador()
        {
            InitializeComponent();
        }
        
        private void EstadisticasJugador_Load(object sender, EventArgs e)
        {
            DataMethodsRepo dataMethods = new DataMethodsRepo();
            var jugadores = dataMethods.GetJugadorMethods().SelectViewJugador();
            dgvBusquedaJugadores.DataSource = jugadores;
        }
    }
}
