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
using ProjectData.Models;
namespace CrudAppNBA
{
    public partial class frmActualizarEstadisticas : Form
    {
        public frmActualizarEstadisticas()
        {
            InitializeComponent();
        }
        DataMethodsRepo dataMethodsRepo = new DataMethodsRepo();
        private void ActualizarEstadisticas_Load(object sender, EventArgs e)
        {
            var estadisticasJugador = dataMethodsRepo.GetEstadisticasJugadorMethods().SelectEstadisticasByIdJugador(ObjectIds.CodigoJugador);
            txtPuntosT.Text = estadisticasJugador.PuntosTotales.ToString();
            txtAsistenciasT.Text = estadisticasJugador.AsistenciasTotales.ToString();
            txtRebotesT.Text = estadisticasJugador.RebotesTotales.ToString();
            txtJuegosIniciados.Text = estadisticasJugador.JuegosIniciados.ToString();
            txtJuegosTotales.Text = estadisticasJugador.JuegosTotales.ToString();
            txtTirosDeCampoInt.Text = estadisticasJugador.TirosDeCampoIntentados.ToString();
            txtTirosDeCampoEnc.Text = estadisticasJugador.TirosDeCampoEncestados.ToString();
            txtPerdidasDeBalon.Text = estadisticasJugador.PerdidasDeBalon.ToString();
        }
        private bool TextBoxIsValid()
        {
            List<bool>value = new List<bool>();
            foreach (var i in this.Controls)
            {
                if (i is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(((TextBox)i).Text) == true | int.TryParse(((TextBox)i).Text, out int result) == false)
                    {
                        value.Add(false);
                    }
                    else
                    {
                        value.Add(true);
                    }
                }
            }
            if (value.Contains(false) == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnActualizarEstadisticas_Click(object sender, EventArgs e)
        {
            if (TextBoxIsValid() == true)
            {
                try
                {
                    EstadisticasJugador estadisticasJugador = new EstadisticasJugador();
                    estadisticasJugador.PuntosTotales = int.Parse(txtPuntosT.Text);
                    estadisticasJugador.AsistenciasTotales = int.Parse(txtAsistenciasT.Text);
                    estadisticasJugador.RebotesTotales = int.Parse(txtRebotesT.Text);
                    estadisticasJugador.TirosDeCampoIntentados = int.Parse(txtTirosDeCampoInt.Text);
                    estadisticasJugador.TirosDeCampoEncestados = int.Parse(txtTirosDeCampoEnc.Text);
                    estadisticasJugador.PerdidasDeBalon = int.Parse(txtPerdidasDeBalon.Text);
                    estadisticasJugador.JuegosTotales = int.Parse(txtJuegosTotales.Text);
                    estadisticasJugador.JuegosIniciados = int.Parse(txtJuegosIniciados.Text);

                    dataMethodsRepo.GetEstadisticasJugadorMethods().UpdateEstadisticasJugador(estadisticasJugador);
                    MessageBox.Show("Se han actualizado las estadisticas exitosamente!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido el siguiente error: " + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("No se ha podido realizar la actualizacion porque hay datos\n incorrectos, revise los campos e intente de nuevo!");
            }
        }
    }
}
