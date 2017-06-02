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

        Cliente clienteSeleccionado;
        public ListaClientes()
        {
            InitializeComponent();
        }

        private void ListaClientes_Load(object sender, EventArgs e)
        {
            //Obtener todos los clientes cuando se carga el formulario
            DataTable clientes = SQLCliente.obtenerTodosLosClientes();
            tablaClientes.DataSource = clientes;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (verificarDatosBusqueda(txtNombre.Text, txtApellido.Text, txtDNI.Text))
            {
                if (txtNombre.Text.Length > 0) {
                    //tiene nombre
                    if (txtApellido.Text.Length > 0) { }
                }

                Cliente clieABuscar = new Cliente(txtNombre.Text, txtApellido.Text, String.IsNullOrEmpty(txtDNI.Text) ?  0 : Int32.Parse(txtDNI.Text));
                tablaClientes.DataSource = SQLCliente.filtrarClientes(clieABuscar);
            }
        }

        private bool verificarDatosBusqueda(string nombre, string apellido, string dni)
        {
            if (nombre.Length == 0 && apellido.Length == 0 && dni.Length == 0)
            {
                MessageBox.Show("Debe escribir algun campo para filtrar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
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

        //Por ahora no hago nada con el doble ckick
        public void tablaClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //este es el cliente, nose como me viene de la tabla, quizas tenga que hacer uno x uno los datos de las columnas
           // DataGridViewRow clieRow = tablaClientes.Rows[e.RowIndex];
           // Cliente cliente = new Cliente(clieRow);
            //seleccionoCliente(cliente);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro?", "Esta seguro que quiere dar de baja este cliente?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SQLCliente.eliminarCliente(clienteSeleccionado);
            }
        }

        private void tablaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow clieRow = tablaClientes.Rows[e.RowIndex];
            clienteSeleccionado = new Cliente(clieRow);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            new ModificacionCliente(clienteSeleccionado).ShowDialog();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DataTable clientes = SQLCliente.obtenerTodosLosClientes();
            tablaClientes.DataSource = clientes;
            txtDNI.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
        }
    }
}
