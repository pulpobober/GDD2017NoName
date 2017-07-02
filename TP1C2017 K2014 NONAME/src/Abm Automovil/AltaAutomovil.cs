using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Objetos;
using UberFrba.ConexionBD;
using System.Data.SqlClient;
using System.Diagnostics;

namespace UberFrba.Abm_Automovil
{
    public partial class AltaAutomovil : AbmAutomovil
    {
        public AltaAutomovil()
        {
            InitializeComponent();
        }

        private void btnAlta_Click_1(object sender, EventArgs e)
        {
            if (verificarDatosAutomovil(txtPatente.Text, txtModelo.Text))
            {
                if (SQLAutomovil.verificarPatente(txtPatente.Text, -1))
                {
                    if (SQLAutomovil.verificarChofer(obtenerIDChofer(cmbChofer.Text), -1))
                    {

                        int idmarca = obtenerIDMarca(selectMarca.SelectedItem.ToString());
                        DataTable turnosSeleccionados = obtenerTurnosSeleccionados();
                        int idchofer = obtenerIDChofer(cmbChofer.SelectedItem.ToString());
                        Automovil auto = new Automovil(turnosSeleccionados, txtPatente.Text, txtModelo.Text, idmarca, idchofer, txtRodado.Text, txtLicencia.Text, 1);
                        SQLAutomovil.insertarAutomovil(auto);
                        MessageBox.Show("El Auto se ha dado de alta correctamente");
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Esta chofer ya tiene asignado un auto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {
                    MessageBox.Show("Esta patente ya esta en uso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool verificarDatosAutomovil(string patente, string modelo)
        {
            if (patente.Length == 0)
            {
                MessageBox.Show("No se puede dejar el campo patente vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (modelo.Length == 0)
            {
                MessageBox.Show("No se puede dejar el campo modelo vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (selectMarca.SelectedItem == null)
            {
                MessageBox.Show("No se puede dejar el campo marca vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbChofer.SelectedItem == null)
            {
                MessageBox.Show("No se puede dejar el campo chofer vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (checkListTurno.SelectedItem == null)
            {
                MessageBox.Show("No se puede dejar el campo turno vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void AltaAutomovil_Load(object sender, EventArgs e)
        {
            tablaTurnos = SQLTurno.obtenerTodosLosTurnosHabilitados();
            foreach (DataRow row in tablaTurnos.Rows)
            {
                checkListTurno.Items.Add(row["descripcion"].ToString());
            }
        }
    }
}
