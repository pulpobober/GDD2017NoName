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
        DataTable turnosSeleccionados;

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

            tablaTurnos = SQLTurno.obtenerTodosLosTurnosHabilitados();
            
            turnosSeleccionados = SQLAutomovil.obtenerTurnosDefinidosAuto(auto.idautomovil);
            checkListTurno.Items.Clear();
            foreach (DataRow row in tablaTurnos.Rows)
            {
                Boolean check = estaSeleccionadoTurno(row["id_turno"].ToString());
                checkListTurno.Items.Add(row["descripcion"].ToString(), check);
            }            

            string nombreMarca = obtenerNombreMarca(auto.idmarca);
            selectMarca.SelectedIndex = selectMarca.FindStringExact(nombreMarca);

            ckbHabilitado.Checked = auto.habilitado == 1? true : false;

            //No se usa esto??
            txtLicencia.Text = auto.licencia;
            txtRodado.Text = auto.rodado;
        }
        private Boolean estaSeleccionadoTurno(String id_turno)
        { 
            foreach (DataRow row in turnosSeleccionados.Rows)
            {
                if(row["id_turno"].ToString() == id_turno){
                   return true;
                }
            }
            return false;
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            if(verificarDatosAutomovil(txtPatente.Text,txtModelo.Text)){
                if (SQLAutomovil.verificarPatente(txtPatente.Text, idautomovil))
                {
                    if (SQLAutomovil.verificarChofer(obtenerIDChofer(cmbChofer.Text), idautomovil))
                    {
                        int idmarca = obtenerIDMarca(selectMarca.Text);
                        DataTable turnosSeleccionados = obtenerTurnosSeleccionados();
                        int idchofer = obtenerIDChofer(cmbChofer.Text);

                        Automovil auto = new Automovil(idautomovil, turnosSeleccionados, txtPatente.Text, txtModelo.Text, idmarca, idchofer, txtRodado.Text, txtLicencia.Text, ckbHabilitado.Checked ? 1 : 0);
                        SQLAutomovil.modificarAutomovil(auto);
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("El auto ha sido modificado correctamente");
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Esta chofer ya tiene asignado un auto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
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
            if (checkListTurno.CheckedItems.Count== 0)
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
