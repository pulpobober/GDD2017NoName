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
                if (SQLCliente.verificarTelefono(int.Parse(txtTelefono.Text), -1))
                {
                    if (SQLCliente.verificarDNI(int.Parse(txtDNI.Text), -1))
                    {
                        string direccion = obtenerDireccionEntera(txtDireccion.Text, txtPiso.Text, txtDepto.Text, txtLocalidad.Text);
                        Cliente nuevoCliente = new Cliente(txtNombre.Text, txtApellido.Text, Int32.Parse(txtDNI.Text), txtMail.Text, Int32.Parse(txtTelefono.Text), direccion, txtCodPostal.Text, dateTimeNacimiento.Value);
                        SQLCliente.insertarCliente(nuevoCliente);
                        MessageBox.Show("El cliente ha sido dado de alta correctamente");
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Ese DNI ya esta en uso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {
                    MessageBox.Show("Ese telefono ya esta en uso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
