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
           //Obtener todos los clientes cuando se carga el formulario
           DataTable clientes = SQLCliente.obtenerTodosLosClientes();
           tablaClientes.DataSource = clientes;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (verificarDatosBusqueda(txtNombre.Text, txtApellido.Text, txtDNI.Text))
            {
                Cliente clie = new Cliente(txtNombre.Text, txtApellido.Text, Int32.Parse(txtDNI.Text));
                tablaClientes.DataSource = SQLCliente.filtrarClientes(clie);
            }
        }

        private bool verificarDatosBusqueda(string nombre, string apellido, string dni) {
            if (nombre.Length == 0 && apellido.Length == 0 && dni.Length == 0) {
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

        public void tablaClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //este es el cliente, nose como me viene de la tabla, quizas tenga que hacer uno x uno los datos de las columnas
            DataGridViewRow clieRow = tablaClientes.Rows[e.RowIndex];
            Cliente cliente = new Cliente(clieRow);
            seleccionoCliente(cliente);
        }

        public virtual void seleccionoCliente(Cliente clie) { 
            //metodo que se va a sobreescribir 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente clie = obtenerClienteSeleccionado();
            DialogResult dialogResult = MessageBox.Show("Esta seguro?", "Esta seguro que quiere dar de baja este cliente?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SQLCliente.eliminarCliente(clie);
            }
        }

        private Cliente obtenerClienteSeleccionado()
        {
            //este es el cliente, nose como me viene de la tabla, quizas tenga que hacer uno x uno los datos de las columnas
            DataGridViewRow clieRow = tablaClientes.SelectedRows;
            Cliente cliente = new Cliente(clieRow);
            seleccionoCliente(cliente);
        }

        
    }
}
