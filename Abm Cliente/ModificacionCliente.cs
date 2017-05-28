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
using UberFrba.Objetos;

namespace UberFrba.Abm_Cliente
{
    public partial class ModificacionCliente : AbmCliente
    {
        public ModificacionCliente()
        {
            InitializeComponent();
        }

        public ModificacionCliente(Cliente clie) {
            txtNombre.Text = clie.nombre;
            txtApellido.Text = clie.apellido;
            txtDNI.Text = clie.dni.ToString();
            txtMail.Text = clie.mail;
            txtTelefono.Text = clie.telefono.ToString();
            txtDireccion.Text = clie.direccion;
            txtLocalidad.Text = clie.localidad;
            txtCodPostal.Text = clie.codPostal.ToString();
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            if (verificarDatosCliente(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtMail.Text, txtTelefono.Text, txtDireccion.Text, txtLocalidad.Text, txtCodPostal.Text))
            {
                Cliente clienteAModificar = new Cliente(txtNombre.Text, txtApellido.Text, Int32.Parse(txtDNI.Text), txtMail.Text, Int32.Parse(txtTelefono.Text), txtDireccion.Text, txtLocalidad.Text, Int32.Parse(txtCodPostal.Text), dateTimeNacimiento.Value);
                SQLCliente.modificarCliente(clienteAModificar);
                //Hacer el modificacion con el DAO
            }
        }        
    }
}
