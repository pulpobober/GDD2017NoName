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

namespace UberFrba.Abm_Chofer
{
    public partial class ModificacionChofer : AbmChofer
    {
        int idChofer;
        public ModificacionChofer()
        {
            InitializeComponent();
        }
        
        public ModificacionChofer(Chofer chofer) {
            InitializeComponent();
            idChofer = chofer.id_Chofer;
            txtNombre.Text = chofer.nombre;
            txtApellido.Text = chofer.apellido;
            txtDNI.Text = chofer.dni.ToString();
            txtMail.Text = chofer.mail;
            txtTelefono.Text = chofer.telefono.ToString();
            dateTimeNacimiento.Value = chofer.fechaNacimiento;
            ckbHabilitado.Checked = chofer.habilitado;
            depurarDireccion(chofer.direccion);
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
            if (verificarDatosChofer(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtMail.Text, txtTelefono.Text, txtDireccion.Text, txtLocalidad.Text))
            {
                if (SQLChofer.verificarTelefono(int.Parse(txtTelefono.Text), idChofer))
                {
                    if (SQLChofer.verificarDNI(int.Parse(txtDNI.Text), idChofer))
                    {
                        string direccion = obtenerDireccionEntera(txtDireccion.Text, txtPiso.Text, txtDepto.Text, txtLocalidad.Text);
                        Chofer ChoferAModificar = new Chofer(idChofer,txtNombre.Text, txtApellido.Text, Int32.Parse(txtDNI.Text), txtMail.Text, Int32.Parse(txtTelefono.Text), direccion, dateTimeNacimiento.Value, ckbHabilitado.Checked);
                        SQLChofer.modificarChofer(ChoferAModificar);
                        MessageBox.Show("El chofer ha sido modificado correctamente");
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
