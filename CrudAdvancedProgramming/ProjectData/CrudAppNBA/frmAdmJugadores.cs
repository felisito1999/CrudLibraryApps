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
                DataMethodsRepo dataMethodsRepo = new DataMethodsRepo();

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

                    jugador.CodigoJugador = CodigoJugador;
                    jugador.Nombre = txtNombre.Text;
                    jugador.Apellido = txtApellido.Text;
                    jugador.Sexo = sexo;
                    jugador.FechaNacimiento = dtpFechaNacimiento.Value.Date;
                    jugador.Pais = pais;
                    jugador.FechaCreacion = DateTime.Now;
                    jugador.Estado = estado;

                    DataMethodsRepo dataMethodsRepo = new DataMethodsRepo();

                    dataMethodsRepo.GetJugadorMethods().UpdateJugador(jugador);
                    LoadData();
                    ClearFields();
                    MessageBox.Show("El jugador ha sido actualizado exitosamente!");
                }
                else
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

                    jugador.Nombre = txtNombre.Text;
                    jugador.Apellido = txtApellido.Text;
                    jugador.Sexo = sexo;
                    jugador.FechaNacimiento = dtpFechaNacimiento.Value.Date;
                    jugador.Pais = pais;
                    jugador.FechaCreacion = DateTime.Now;
                    jugador.Estado = estado;

                    DataMethodsRepo dataMethodsRepo = new DataMethodsRepo();

                    dataMethodsRepo.GetJugadorMethods().InsertJugador(jugador);
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
                DataMethodsRepo dataMethodsRepo = new DataMethodsRepo();
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
                DataMethodsRepo dataMethodsRepo = new DataMethodsRepo();

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
    }
}
