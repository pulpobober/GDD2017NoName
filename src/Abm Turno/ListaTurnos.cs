using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.ConexionBD;
using UberFrba.Objetos;

namespace UberFrba.Abm_Turno
{
    public partial class ListaTurnos : Form
    {
        Turno turnoSeleccionado;
        bool modificacion;
        public ListaTurnos()
        {
            InitializeComponent();
        }

        public ListaTurnos(bool modif){
            InitializeComponent();
            modificacion = modif;
            if (modificacion)
            {
                btnEliminar.Hide();
            }
            else {
                btnModificar.Hide();
            }
        }

        private void ListaTurnos_Load(object sender, EventArgs e)
        {
            //Obtener todos los turnos cuando se carga el formulario
            DataTable turnos;
            if (modificacion)
            {
                turnos = SQLTurno.obtenerTodosLosTurnos();
            }
            else
            {
                turnos = SQLTurno.obtenerTodosLosTurnosHabilitados();
            }
            tablaTurnos.DataSource = turnos;
            this.tablaTurnos.Columns[0].Visible = false; //turnoId
            DataGridViewRow turnoRow = tablaTurnos.Rows[0];
            turnoSeleccionado = new Turno(turnoRow);
        }

        private void bnBuscar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Length == 0){
                MessageBox.Show("Debe escribir algun campo para buscar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                Turno turnoABuscar = new Turno(txtDescripcion.Text);
                if (modificacion)
                {
                    tablaTurnos.DataSource = SQLTurno.filtarTurnos(turnoABuscar);
                }
                else
                {
                    tablaTurnos.DataSource = SQLTurno.filtarTurnosHabilitados(turnoABuscar);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            new ModificacionTurno(turnoSeleccionado).ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro?", "Esta seguro que quiere dar de baja este Turno?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string response=SQLTurno.eliminarTurno(turnoSeleccionado);
                MessageBox.Show(response);
            }
        }

        private void tablaTurnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow turnoRow = tablaTurnos.Rows[e.RowIndex];
            turnoSeleccionado = new Turno(turnoRow);
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            DataTable turnos;
            if (modificacion)
            {
                turnos = SQLTurno.obtenerTodosLosTurnos();
            }
            else
            {
                turnos = SQLTurno.obtenerTodosLosTurnosHabilitados();
            } 
            tablaTurnos.DataSource = turnos;
            this.tablaTurnos.Columns[0].Visible = false; //turnoId
            DataGridViewRow turnoRow = tablaTurnos.Rows[0];
            turnoSeleccionado = new Turno(turnoRow);

            txtDescripcion.Text = "";
        }
    }
}
