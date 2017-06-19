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

namespace UberFrba.Registro_Viajes
{
    public partial class RegistroViaje : Form
    {
        int idCliente;
        DataTable tablaTurnos;
        DataTable tablaChoferes;
        DataTable tablaAutomoviles;

        public RegistroViaje()
        {
            InitializeComponent();
        }

        public RegistroViaje(int id_cliente)
        {
            InitializeComponent();
            idCliente = id_cliente;

            cmbAutomovil.Hide();
            lblAutomovil.Hide();
            lblTurno.Hide();
            cmbTurnos.Hide();

            
            tablaChoferes = SQLChofer.obtenerTodosLosChoferes();

            foreach (DataRow row in tablaChoferes.Rows)
            {
                cmbChoferes.Items.Add(row["nombre"].ToString() + " " + row["apellido"].ToString());
            }


        }

        private void RegistroViaje_Load(object sender, EventArgs e)
        {

            ////ESTO LO PONGO PARA PROBAR MIENTRAS SE SOLUCIONA EL LOGIN, DESPUES BORRAR

            cmbAutomovil.Hide();
            lblAutomovil.Hide();
            lblTurno.Hide();
            cmbTurnos.Hide();

            tablaChoferes = SQLChofer.obtenerTodosLosChoferes();

            foreach (DataRow row in tablaChoferes.Rows)
            {
                cmbChoferes.Items.Add(row["nombre"].ToString() + " " + row["apellido"].ToString());
            }

        }

        private int obtenerIDChofer(string nombreYApellido) {
            foreach (DataRow row in tablaChoferes.Rows)
            {
                if (row["nombre"].ToString() + " " + row["apellido"].ToString() == nombreYApellido) {
                    return int.Parse(row["id_usuario"].ToString());
                }
            }
            return -1;
        }

        private int obtenerIDTurno(string turno)
        {
            foreach (DataRow row in tablaTurnos.Rows)
            {
                if (row["descripcion"].ToString() == turno)
                {
                    return int.Parse(row["id_turno"].ToString());
                }
            }
            return -1;
        }

        private int obtenerIDAuto(string patente)
        {
            foreach (DataRow row in tablaAutomoviles.Rows)
            {
                if (row["patente_auto"].ToString() == patente)
                {
                    return int.Parse(row["id_auto"].ToString());
                }
            }
            return -1;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimeFin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarViaje_Click(object sender, EventArgs e)
        {
            if (verificarDatosRegistro()) {
               string respuesta = SQLRegistroViaje.registrarViaje(obtenerIDChofer(cmbChoferes.SelectedItem.ToString()), obtenerIDAuto(cmbAutomovil.SelectedItem.ToString()), obtenerIDTurno(cmbTurnos.SelectedItem.ToString()), int.Parse(txtCantidadKm.Text), dataTimeInicio.Value, dateTimeFin.Value,idCliente);
               MessageBox.Show(respuesta);
            }
        }

        private bool verificarDatosRegistro() { 
            if(cmbChoferes.SelectedItem == null) {
                MessageBox.Show("No se puede dejar el campo choferes vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cmbTurnos.SelectedItem == null)
            {
                MessageBox.Show("No se puede dejar el campo turnos vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cmbAutomovil.SelectedItem == null) {
                MessageBox.Show("No se puede dejar el campo automovil vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtCantidadKm.Text.Length == 0)
            {
                MessageBox.Show("No se puede dejar el campo cantidad de kilometros vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void cmbChoferes_SelectedIndexChanged(object sender, EventArgs e)
        {

            lblTurno.Show();
            cmbTurnos.Show();

            cmbTurnos.Items.Clear();
            cmbTurnos.Text = "";


            cmbAutomovil.Items.Clear();
            cmbAutomovil.Text = "";


            tablaTurnos = SQLTurno.obtenerTodosLosTurnosDelChofer(obtenerIDChofer(cmbChoferes.SelectedItem.ToString()));

            foreach (DataRow row in tablaTurnos.Rows)
            {
                cmbTurnos.Items.Add(row["descripcion"].ToString());
            }


        }

        private void cmbTurnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAutomovil.Show();
            cmbAutomovil.Show();
            //Carga los automoviles del chofer seleccionado en el turno seleccionado
            tablaAutomoviles = SQLAutomovil.obtenerAutomovilDelChofer(obtenerIDChofer(cmbChoferes.SelectedItem.ToString()), obtenerIDTurno(cmbTurnos.SelectedItem.ToString()));

            foreach (DataRow row in tablaAutomoviles.Rows)
            {
                cmbAutomovil.Items.Add(row["patente_auto"].ToString());
            }
        }
    }
}
