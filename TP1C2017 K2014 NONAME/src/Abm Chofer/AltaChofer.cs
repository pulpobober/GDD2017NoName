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

namespace UberFrba.Abm_Chofer
{
    public partial class AltaChofer : AbmChofer
    {
       public AltaChofer()
        {
            InitializeComponent();
        }

        private void btnAlta2_Click(object sender, EventArgs e)
        {
            if (verificarDatosChofer(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtMail.Text, txtTelefono.Text, txtDireccion.Text, txtLocalidad.Text))
            {
                if (SQLChofer.verificarTelefono(int.Parse(txtTelefono.Text), -1))
                {
                    if (SQLChofer.verificarDNI(int.Parse(txtDNI.Text), -1))
                    {
                        string direccion = obtenerDireccionEntera(txtDireccion.Text, txtPiso.Text, txtDepto.Text, txtLocalidad.Text);
                        Chofer nuevoChofer = new Chofer(txtNombre.Text, txtApellido.Text, Int32.Parse(txtDNI.Text), txtMail.Text, Int32.Parse(txtTelefono.Text), direccion, dateTimeNacimiento.Value);
                        SQLChofer.insertarChofer(nuevoChofer);
                        MessageBox.Show("El chofer ha sido dado de alta correctamente");
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
