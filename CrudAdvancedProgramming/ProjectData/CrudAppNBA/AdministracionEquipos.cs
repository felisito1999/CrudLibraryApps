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
    public partial class AdministracionEquipos : Form
    {
        DataMethodsRepo dataMethodsRepo = new DataMethodsRepo();
        public AdministracionEquipos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) & dtpFechaNacimiento))
            Equipo equipo = new Equipo();
            Pais pais = new Pais();
            Estado estado = new Estado();
            estado = dataMethodsRepo.GetEstadoMethods().SelectEstadoById((int)cbEstado.SelectedValue);
            pais = dataMethodsRepo.GetPaisMethods().SelectPaisesById((int)cbPais.SelectedValue);

            equipo.Nombre = txtNombre.Text;
            equipo.FechaCreacion = DateTime.Now;
            equipo.Pais = pais;
            equipo.Estado = estado;
            equipo.Deleted = false;
            dataMethodsRepo.GetEquipoMethods().InsertEquipos(equipo);
        }

        private void btnQuitarSeleccion_Click(object sender, EventArgs e)
        {

        }
        private void ClearFields()
        {
            
        }
    }
}
