using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_Cliente
{
    public partial class AltaCliente : AbmCliente
    {
        public AltaCliente()
        {
            InitializeComponent();
        }

        private void btnAlta2_Click(object sender, EventArgs e)
        {
            if (verificarAltaCliente(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtMail.Text, txtTelefono.Text, txtDireccion.Text, txtNroPiso.Text, txtDepto.Text, txtLocalidad.Text, txtCodPostal.Text))
            {
                //Hacer el alta con el DAO
            }
            else {
                MessageBox.Show("Hay algun campo vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool verificarAltaCliente(string nombre, string apellido, string dni, string mail, string telefono, string direccion, string nroPiso, string depto, string localidad, string codPostal)
        {
            //Si se quiere hacer re cheto mal, le ponemos un string que va concatenando los nombres y mostrar un mensaje que diga
            //cuales son los campos que faltan
            bool camposCorrectos = true;
            if (nombre.Length == 0) {
                camposCorrectos = false;
            }
            if (apellido.Length == 0)
            {
                camposCorrectos = false;
            }
            if (dni.Length == 0)
            {
                camposCorrectos = false;
            }
            if (telefono.Length == 0)
            {
                camposCorrectos = false;
            }
            if (direccion.Length == 0)
            {
                camposCorrectos = false;
            }
            if (nroPiso.Length == 0)
            {
                camposCorrectos = false;
            }
            if (depto.Length == 0)
            {
                camposCorrectos = false;
            }
            if (localidad.Length == 0)
            {
                camposCorrectos = false;
            }
            if (codPostal.Length == 0)
            {
                camposCorrectos = false;
            }

            return camposCorrectos;
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
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
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
