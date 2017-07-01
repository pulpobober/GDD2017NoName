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
        int idCliente;
        public ModificacionCliente()
        {
            InitializeComponent();
        }
        
        public ModificacionCliente(Cliente clie) {
            InitializeComponent();
            idCliente = clie.id_cliente;
            txtNombre.Text = clie.nombre;
            txtApellido.Text = clie.apellido;
            txtDNI.Text = clie.dni.ToString();
            txtMail.Text = clie.mail;
            txtTelefono.Text = clie.telefono.ToString();
            txtCodPostal.Text = clie.codPostal.ToString();
            dateTimeNacimiento.Value = clie.fechaNacimiento;
            ckbHabilitado.Checked = clie.habilitado;
            depurarDireccion(clie.direccion);
        }

        public void depurarDireccion(string direccionEntera) { 
            string letras = "";
            int contadorPropio = 0;
            for (int i = 0; i < direccionEntera.Length; i++)
            {
                if (direccionEntera[i] == ',')
                {
                    escribirForm(letras, contadorPropio);
                    letras = "";
                    i++;
                    contadorPropio ++;

                }
                 else{
                    letras += direccionEntera[i];
                 }
            }
            escribirForm(letras, contadorPropio);
        }

        public void escribirForm(string letras, int contador) {
            switch (contador)
            {
                case 0:
                    txtDireccion.Text = letras;
                    break;
                case 1:
                    txtPiso.Text = letras;
                    break;
                case 2:
                    txtDepto.Text = letras;
                    break;
                case 3:
                    txtLocalidad.Text = letras;
                    break;
            }
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            if (verificarDatosCliente(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtMail.Text, txtTelefono.Text, txtDireccion.Text, txtLocalidad.Text, txtCodPostal.Text))
            {
                if (SQLCliente.verificarTelefono(int.Parse(txtTelefono.Text), idCliente))
                {
                    if (SQLCliente.verificarDNI(int.Parse(txtDNI.Text), idCliente))
                    {
                        string direccion = obtenerDireccionEntera(txtDireccion.Text, txtPiso.Text, txtDepto.Text, txtLocalidad.Text);
                        Cliente clienteAModificar = new Cliente(idCliente, txtNombre.Text, txtApellido.Text, Int32.Parse(txtDNI.Text), txtMail.Text, Int32.Parse(txtTelefono.Text), direccion, txtCodPostal.Text, dateTimeNacimiento.Value, ckbHabilitado.Checked);
                        SQLCliente.modificarCliente(clienteAModificar);
                        MessageBox.Show("El cliente se ha modificado correctamente");
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
    }
}
