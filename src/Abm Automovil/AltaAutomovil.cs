﻿using System;
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
                int idmarca = obtenerIDMarca(selectMarca.SelectedItem.ToString());
                int idturno = obtenerIDTurno(cmbTurno.SelectedItem.ToString());
                int idchofer = obtenerIDChofer(cmbChofer.SelectedItem.ToString());
                Automovil auto = new Automovil(idturno, txtPatente.Text, txtModelo.Text, idmarca, idchofer, txtRodado.Text, txtLicencia.Text, 1);
                string response=SQLAutomovil.insertarAutomovil(auto);
                MessageBox.Show(response);
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
            if (cmbTurno.SelectedItem == null)
            {
                MessageBox.Show("No se puede dejar el campo turno vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void AltaAutomovil_Load(object sender, EventArgs e)
        {

        }
    }
}
