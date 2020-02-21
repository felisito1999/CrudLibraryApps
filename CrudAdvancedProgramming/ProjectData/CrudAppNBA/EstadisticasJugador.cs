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

        private void txtBusquedaJugador_TextChanged(object sender, EventArgs e)
        {
            var nombreJugador = txtBusquedaJugador.Text;
            DataMethodsRepo dataMethods = new DataMethodsRepo();
            var busquedaJugadores = dataMethods.GetJugadorMethods().SelectJugadorByName(nombreJugador);
            var allJugadores = dataMethods.GetJugadorMethods().SelectViewJugador();

            if (string.IsNullOrWhiteSpace(txtBusquedaJugador.Text) == true)
            {
                dgvBusquedaJugadores.DataSource = allJugadores;
            }
            else
            {
                dgvBusquedaJugadores.DataSource = busquedaJugadores;
            }
        }
        public int CodigoJugador;
        private void dgvBusquedaJugadores_SelectionChanged(object sender, EventArgs e)
        {
            var 
            CodigoJugador = (int)dgvBusquedaJugadores[0, dgvBusquedaJugadores.CurrentRow.Index].Value;
            dgvEstadisticasJugadores.DataSource = 
        }
    }
}
