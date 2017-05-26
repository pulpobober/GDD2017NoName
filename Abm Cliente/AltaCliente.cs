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
            if (verificarDatosCliente(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtMail.Text, txtTelefono.Text, txtDireccion.Text, txtNroPiso.Text, txtDepto.Text, txtLocalidad.Text, txtCodPostal.Text))
            {
                //Hacer el alta con el DAO
            }
        }
    }
}
