using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_Chofer
{
    public partial class AbmChofer : Form
    {
        public AbmChofer()
        {
            InitializeComponent();
        }

        public string obtenerDireccionEntera(string direccion, string piso, string depto, string localidad) { 
            return (direccion + ", " + piso + ", " + depto + ", " + localidad);
        }

        public bool verificarDatosChofer(string nombre, string apellido, string dni, string mail, string telefono, string direccion, string localidad)
        {
            if (nombre.Length == 0)
            {
                MessageBox.Show("No se puede dejar el campo nombre vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (apellido.Length == 0)
            {
                MessageBox.Show("No se puede dejar el campo apellido vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (dni.Length == 0)
            {
                MessageBox.Show("No se puede dejar el campo Dni vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (telefono.Length == 0)
            {
                MessageBox.Show("No se puede dejar el campo telefono vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (direccion.Length == 0)
            {
                MessageBox.Show("No se puede dejar el campo direccion vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        private void txtDNI_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCodPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void AbmChofer_Load(object sender, EventArgs e)
        {

        }
    }
}
