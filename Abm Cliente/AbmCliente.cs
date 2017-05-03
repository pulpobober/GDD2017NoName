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
    public partial class AbmCliente : Form
    {
        public AbmCliente()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            verificarAltaCliente(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtMail.Text, txtTelefono.Text, txtDireccion.Text, txtNroPiso.Text, txtDepto.Text, txtLocalidad.Text)
        }

        private void verificarAltaCliente(string nombre, string apellido, string dni, string mail, string telefono, string direccion, string nroPiso, string depto, string localidad) { 
        }
    }
}
