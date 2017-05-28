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

           
            if (verificarDatosCliente(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtMail.Text, txtTelefono.Text, txtDireccion.Text, txtLocalidad.Text, txtCodPostal.Text))
            {
                Cliente nuevoCliente = new Cliente(txtNombre.Text, txtApellido.Text, Int32.Parse(txtDNI.Text), txtMail.Text, Int32.Parse(txtTelefono.Text), txtDireccion.Text, txtLocalidad.Text, Int32.Parse(txtCodPostal.Text), dateTimeNacimiento.Value);
                SQLCliente.insertarCliente(nuevoCliente);
            }
             
        }
    }
}
