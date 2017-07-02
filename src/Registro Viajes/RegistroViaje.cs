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
        DataTable tablaClientes;
        bool esRolAdministrador;

        public RegistroViaje()
        {
            InitializeComponent();
        }

        public RegistroViaje(int id_cliente, int id_rol)
        {
            InitializeComponent();
            idCliente = id_cliente;

            esRolAdministrador = id_rol == 1;

            cmbAutomovil.Hide();
            lblAutomovil.Hide();
            lblTurno.Hide();
            cmbTurnos.Hide();
            
            tablaChoferes = SQLChofer.obtenerTodosLosChoferesHabilitados();

            foreach (DataRow row in tablaChoferes.Rows)
            {
                cmbChoferes.Items.Add(row["nombre"].ToString() + " " + row["apellido"].ToString());
            }

            tablaClientes = SQLCliente.obtenerTodosLosClientesHabilitados();

            if (esRolAdministrador)
            {
                cmbCliente.Enabled = true;
                foreach (DataRow row in tablaClientes.Rows)
                {
                    cmbCliente.Items.Add(row["nombre"].ToString() + " " + row["apellido"].ToString());
                }

            }
            else
            {
                cmbCliente.Enabled = false;
                foreach (DataRow row in tablaClientes.Rows)
                {
                    if (int.Parse(row["id_usuario"].ToString()) == id_cliente)
                    {
                        cmbCliente.Items.Add(row["nombre"].ToString() + " " + row["apellido"].ToString());
                        cmbCliente.SelectedIndex = 0;
                        break;
                    }
                }
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

        private void btnRegistrarViaje_Click(object sender, EventArgs e)
        {
            if (verificarDatosRegistro()) {
                string respuesta = SQLRegistroViaje.registrarViaje(obtenerIDChofer(cmbChoferes.SelectedItem.ToString()), obtenerIDAuto(cmbAutomovil.SelectedItem.ToString()), obtenerIDTurno(cmbTurnos.SelectedItem.ToString()), int.Parse(txtCantidadKm.Text), dataTimeInicio.Value, dateTimeFin.Value, obtenerIDCliente(cmbCliente.SelectedItem.ToString()));
               MessageBox.Show(respuesta);
            }
        }

        private bool verificarSiHayUnViajeEnEsaHoraConEseChofer() {
            return false;
        }

        private int obtenerIDCliente(string nombreYApellido)
        {
            if (esRolAdministrador)
            {
                foreach (DataRow row in tablaClientes.Rows)
                {
                    if (row["nombre"].ToString() + " " + row["apellido"].ToString() == nombreYApellido)
                    {
                        return int.Parse(row["id_usuario"].ToString());
                    }
                }
                return -1;
            }
            else {
                return idCliente;
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
            else if (DateTime.Compare(dataTimeInicio.Value, dateTimeFin.Value) >= 0)
            {
                MessageBox.Show("La fecha de inicio es mayor o igual que la del fin", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if ((int.Parse(txtCantidadKm.Text)) <= 0)  {
                MessageBox.Show("La cantidad de kilometros tiene que ser mayor a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cmbCliente.SelectedItem == null)
            {
                MessageBox.Show("No se puede dejar el campo clientes vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!verificarHoraConTurno()) {
                MessageBox.Show("La hora del viaje no coincide con el turno elegido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool verificarHoraConTurno() {
            DataTable turnoElegido;
            turnoElegido = SQLTurno.obtenerHoraInicioYFinDelTurno(obtenerIDTurno(cmbTurnos.SelectedItem.ToString()));
            DataRow row = turnoElegido.Rows[0];

            int hora_inicio = int.Parse(row["hora_inicio"].ToString());
            int hora_fin = int.Parse(row["hora_fin"].ToString());
            int hora_viaje_inicio =  dataTimeInicio.Value.Hour;
            int hora_viaje_fin =  dateTimeFin.Value.Hour;

            if (hora_viaje_inicio < hora_inicio || hora_viaje_inicio > hora_fin) { 
                return false;
            }
            else if (hora_viaje_fin < hora_inicio || hora_viaje_fin > hora_fin)
            {
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

        private void txtCantidadKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void RegistroViaje_Load(object sender, EventArgs e)
        {

        }
    }
}
