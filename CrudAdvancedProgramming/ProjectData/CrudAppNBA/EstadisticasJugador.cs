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
        DataMethodsRepo dataMethods = new DataMethodsRepo();
        private void EstadisticasJugador_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtBusquedaJugador_TextChanged(object sender, EventArgs e)
        {
            var nombreJugador = txtBusquedaJugador.Text;
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
        private void dgvBusquedaJugadores_SelectionChanged(object sender, EventArgs e)
        {
            ObjectIds.CodigoJugador = (int)dgvBusquedaJugadores[0, dgvBusquedaJugadores.CurrentRow.Index].Value;        
            var EstadisticasJugador = dataMethods.GetEstadisticasJugadorMethods().SelectEstadisticasByIdJugador(ObjectIds.CodigoJugador);

            if (EstadisticasJugador is null)
            {
                lblPuntosT.Text = "0";
                lblAsistenciasT.Text = "0";
                lblRebT.Text = "0";
                lblTirosDeCampoT.Text = "0";
                lblTirosDeCampoET.Text = "0";
                lblPerdidasT.Text = "0";
                lblJuegosTotales.Text = "0";
                lblJuegosIniciados.Text = "0";
                lblPuntosPorJuego.Text = "0";
                lblAsistenciasPorJuego.Text = "0";
                lblRebotesPorJuego.Text = "0";
                lblTirosIntentadosPorJuego.Text = "0";
                lblTirosDeCampoEncestadosPorJuego.Text = "0";
                lblPerdidasDeBalonPorJuego.Text = "0";
            }
            else
            {
                lblPuntosT.Text = EstadisticasJugador.PuntosTotales.ToString();
                lblAsistenciasT.Text = EstadisticasJugador.AsistenciasTotales.ToString();
                lblRebT.Text = EstadisticasJugador.RebotesTotales.ToString();
                lblTirosDeCampoT.Text = EstadisticasJugador.TirosDeCampoIntentados.ToString();
                lblTirosDeCampoET.Text = EstadisticasJugador.TirosDeCampoEncestados.ToString();
                lblPerdidasT.Text = EstadisticasJugador.PerdidasDeBalon.ToString();
                lblJuegosTotales.Text = EstadisticasJugador.JuegosTotales.ToString();
                lblJuegosIniciados.Text = EstadisticasJugador.JuegosIniciados.ToString();
                lblPuntosPorJuego.Text = EstadisticasJugador.PuntosPorJuego.ToString();
                lblAsistenciasPorJuego.Text = EstadisticasJugador.AsistenciasPorJuego.ToString();
                lblRebotesPorJuego.Text = EstadisticasJugador.RebotesPorJuego.ToString();
                lblTirosIntentadosPorJuego.Text = EstadisticasJugador.TirosDeCampoIntentadosPorjuego.ToString();
                lblTirosDeCampoEncestadosPorJuego.Text = EstadisticasJugador.TirosDeCampoEncestadosPorJuego.ToString();
                lblPerdidasDeBalonPorJuego.Text = EstadisticasJugador.PerdidasDeBalosPorJuego.ToString();
            }
        }

        private void btnActualizarEstadisticas_Click(object sender, EventArgs e)
        {
            frmActualizarEstadisticas actualizarEstadisticas = new frmActualizarEstadisticas();
            actualizarEstadisticas.ShowDialog();
            LoadData();
        }
        private void LoadData()
        {
            var jugadores = dataMethods.GetJugadorMethods().SelectViewJugador();
            dgvBusquedaJugadores.DataSource = jugadores;
        }
    }
}
