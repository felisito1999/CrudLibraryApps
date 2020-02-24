using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectData;
using ProjectData.Models;
using ProjectData.DataMethods;

namespace CrudAppNBA
{
    public partial class frmAdmJugadores : Form
    {
        DataMethodsRepo dataMethodsRepo = new DataMethodsRepo();
        public frmAdmJugadores()
        {
            InitializeComponent();
        }
        public int CodigoJugador;
        private void frmAdmJugadores_Load(object sender, EventArgs e)
        {
            LoadData();
            ClearFields();
        }
        public void LoadData()
        {
            try
            { 

                cbSexo.DataSource = dataMethodsRepo.GetSexoMethods().SelectAllSexos();
                cbSexo.DisplayMember = "NombreSexo";
                cbSexo.ValueMember = "CodigoSexo";

                cbEstado.DataSource = dataMethodsRepo.GetEstadoMethods().SelectAllEstados();
                cbEstado.DisplayMember = "DescripcionEstado";
                cbEstado.ValueMember = "CodigoEstado";

                cbPais.DataSource = dataMethodsRepo.GetPaisMethods().SelectAllPaises();
                cbPais.DisplayMember = "NombrePais";
                cbPais.ValueMember = "CodigoPais";

                dgvJugadores.DataSource = dataMethodsRepo.GetJugadorMethods().SelectViewJugador();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido el siguiente problema: \n" + ex.ToString());
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) == false & string.IsNullOrWhiteSpace(txtApellido.Text) == false &
                dtpFechaNacimiento.Value.Date <= DateTime.Now.Date)
                {
                    if (CodigoJugador != 0)
                    {
                        Jugador jugador = new Jugador();

                        Pais pais = new Pais();
                        pais.CodigoPais = (int)cbPais.SelectedValue;
                        pais.NombrePais = cbPais.SelectedText;

                        Sexo sexo = new Sexo();
                        sexo.CodigoSexo = (int)cbSexo.SelectedValue;
                        sexo.NombreSexo = cbSexo.SelectedText;

                        Estado estado = new Estado();
                        estado.CodigoEstado = (int)cbEstado.SelectedValue;
                        estado.DescripcionEstado = cbEstado.SelectedText;

                        EstadisticasJugador estadisticas = new EstadisticasJugador();


                        jugador.CodigoJugador = CodigoJugador;
                        jugador.Nombre = txtNombre.Text;
                        jugador.Apellido = txtApellido.Text;
                        jugador.Sexo = sexo;
                        jugador.FechaNacimiento = dtpFechaNacimiento.Value.Date;
                        jugador.Pais = pais;
                        jugador.FechaCreacion = DateTime.Now;
                        jugador.Estado = estado;

                        dataMethodsRepo.GetJugadorMethods().UpdateJugador(jugador);
                        LoadData();
                        ClearFields();
                        MessageBox.Show("El jugador ha sido actualizado exitosamente!");
                    }
                    else
                    {
                        Pais pais = new Pais();
                        pais.CodigoPais = (int)cbPais.SelectedValue;
                        pais.NombrePais = cbPais.SelectedText;

                        Sexo sexo = new Sexo();
                        sexo.CodigoSexo = (int)cbSexo.SelectedValue;
                        sexo.NombreSexo = cbSexo.SelectedText;

                        Estado estado = new Estado();
                        estado.CodigoEstado = (int)cbEstado.SelectedValue;
                        estado.DescripcionEstado = cbEstado.SelectedText;

                        Jugador jugador = new Jugador();
                        jugador.CodigoJugador = dataMethodsRepo.GetJugadorMethods().GetLastIdJugador();
                        jugador.Nombre = txtNombre.Text;
                        jugador.Apellido = txtApellido.Text;
                        jugador.Sexo = sexo;
                        jugador.FechaNacimiento = dtpFechaNacimiento.Value.Date;
                        jugador.Pais = pais;
                        jugador.FechaCreacion = DateTime.Now;
                        jugador.Estado = estado;

                        EstadisticasJugador estadisticas = new EstadisticasJugador();
                        estadisticas.Jugador = jugador;
                        estadisticas.PuntosTotales = 0;
                        estadisticas.AsistenciasTotales = 0;
                        estadisticas.RebotesTotales = 0;
                        estadisticas.PerdidasDeBalon = 0;
                        estadisticas.JuegosTotales = 0;
                        estadisticas.JuegosIniciados = 0;
                        estadisticas.FechaCreacion = DateTime.Now;
                        estadisticas.Deleted = false;

                        dataMethodsRepo.GetJugadorMethods().InsertJugador(jugador);
                        dataMethodsRepo.GetEstadisticasJugadorMethods().InsertEstadisticasJugador(estadisticas);
                        LoadData();
                        ClearFields();
                        MessageBox.Show("El jugador ha sido ingresado existosamente");
                    }
                }
                else
                {
                    MessageBox.Show("Uno de los campos no ha sido completado correctamente\n" +
                        "revise los campos e intente de nuevo");
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Ha ocurrido el siguiente problema" + ex.ToString());
            }
        }
        public void ClearFields()
        {
            foreach (var i in this.Controls)
            {
                if (i is TextBox)
                {
                    ((TextBox)i).Clear();
                }
                if (i is ComboBox)
                {
                    ((ComboBox)i).SelectedIndex = 0;
                }
                if (i is DateTimePicker)
                {
                    ((DateTimePicker)i).Value = DateTime.Now;
                }
                if( i is DataGridView)
                {
                    ((DataGridView)i).ClearSelection();
                }
                CodigoJugador = 0;
            }
        }
        private void dgvJugadores_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvJugadores.RowCount >= 1)
            {
                CodigoJugador = (int)dgvJugadores[0, dgvJugadores.CurrentRow.Index].Value;

                var jugador = dataMethodsRepo.GetJugadorMethods().SelectJugadorById(CodigoJugador);

                txtNombre.Text = jugador.Nombre;
                txtApellido.Text = jugador.Apellido;
                cbPais.SelectedValue = jugador.Pais.CodigoPais;
                dtpFechaNacimiento.Value = jugador.FechaNacimiento.Date;
                cbSexo.SelectedValue = jugador.Sexo.CodigoSexo;
                cbEstado.SelectedValue = jugador.Estado.CodigoEstado;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (CodigoJugador != 0)
            {

                dataMethodsRepo.GetJugadorMethods().DeletedUpdateJugadores(CodigoJugador);
                LoadData();
                ClearFields();
                MessageBox.Show("El elemento seleccionado ha sido borrado!");
            }
            else
            {
                MessageBox.Show("No se puede borrar porque no hay ningun elemento seleccionado!");
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
