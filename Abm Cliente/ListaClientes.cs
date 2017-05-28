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
    //Clase Padre De las listas, es la que va a traerme la info de los que quiero seleccionar para borrar y eliminar
    public partial class ListaClientes : Form
    {
        public ListaClientes()
        {
            InitializeComponent();
        }

        private void ListaClientes_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (verificarDatosBusqueda(txtNombre.Text, txtApellido.Text, txtDNI.Text))
            {
                Cliente clie = new Cliente(txtNombre.Text, txtApellido.Text, Int32.Parse(txtDNI.Text));
                tablaClientes.DataSource = SQLCliente.buscarClientes(clie);
            }
        }

        private bool verificarDatosBusqueda(string nombre, string apellido, string dni) {
            if (nombre.Length == 0 && apellido.Length == 0 && dni.Length == 0) {
                MessageBox.Show("Debe escribir algun campo para buscar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
