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


namespace UberFrba.Abm_Automovil
{
    public partial class ModificacionAutomovil : AbmAutomovil
    {
        int idautomovil;

        public ModificacionAutomovil()
        {
            InitializeComponent();
        }

        public ModificacionAutomovil(Automovil auto)
        {
            InitializeComponent();
            cargarForm();

            idautomovil = auto.idautomovil;
            txtPatente.Text = auto.patente;
            txtModelo.Text = auto.modelo;


            string nombreYApellido = obtenerNombreYApellidoChofer(auto.idchofer);
            cmbChofer.SelectedIndex = cmbChofer.FindStringExact(nombreYApellido);
           // cmbChofer.SelectedText = nombreYApellido;

            string nombreTurno = obtenerNombreTurno(auto.idturno);
            cmbTurno.SelectedIndex = cmbTurno.FindStringExact(nombreTurno);
            

            string nombreMarca = obtenerNombreMarca(auto.idmarca);
            selectMarca.SelectedIndex = selectMarca.FindStringExact(nombreMarca);
            //selectMarca.SelectedText = nombreMarca;

            ckbHabilitado.Checked = auto.habilitado == 1? true : false;

            //No se usa esto??
            txtLicencia.Text = auto.licencia;
            txtRodado.Text = auto.rodado;
        }
       

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            if(verificarDatosAutomovil(txtPatente.Text,txtModelo.Text)){
                int idmarca = obtenerIDMarca(selectMarca.Text);
                int idturno = obtenerIDTurno(cmbTurno.Text);
                int idchofer = obtenerIDChofer(cmbChofer.Text);

                Automovil auto = new Automovil(idautomovil, idturno, txtPatente.Text, txtModelo.Text, idmarca, idchofer, txtRodado.Text, txtLicencia.Text, ckbHabilitado.Checked ? 1 : 0);
                string response = SQLAutomovil.modificarAutomovil(auto);
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
            if (selectMarca.Text.Length == 0)
            {
                MessageBox.Show("No se puede dejar el campo marca vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbChofer.Text.Length == 0)
            {
                MessageBox.Show("No se puede dejar el campo chofer vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbTurno.Text.Length == 0)
            {
                MessageBox.Show("No se puede dejar el campo turno vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void ModificacionAutomovil_Load(object sender, EventArgs e)
        {

        }

        private void cmbChofer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
