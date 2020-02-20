using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudAppNBA
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void administracionDeJugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmJugadores admJugadores = new frmAdmJugadores();
            admJugadores.ShowDialog();
        }

        private void estadisticasDeJugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticasjugador estadisticasJugador = new frmEstadisticasjugador();
            estadisticasJugador.ShowDialog();
        }
    }
}
