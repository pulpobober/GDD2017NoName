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
        bool modificacion;
        public ListaClientes()
        {
            InitializeComponent();
        }

        public ListaClientes(bool modif)
        {
            InitializeComponent();
            modificacion = modif;
            if (modificacion)
            {
                btnEliminar.Hide();
            }
            else
            {
                btnModificar.Hide();
            }
        }


        private void ListaClientes_Load(object sender, EventArgs e)
        {
            DataTable clientes;
            if (modificacion){
                //Obtener todos los clientes cuando se carga el formulario
                clientes = SQLCliente.obtenerTodosLosClientes();
            }
            else {
                clientes = SQLCliente.obtenerTodosLosClientesHabilitados();

            }
            tablaClientes.DataSource = clientes;
            this.tablaClientes.Columns[0].Visible = false; //usuarioID
            DataGridViewRow clieRow = tablaClientes.Rows[0];
            clienteSeleccionado = new Cliente(clieRow);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (verificarDatosBusqueda(txtNombre.Text, txtApellido.Text, txtDNI.Text))
            {
                Cliente clieABuscar = new Cliente(txtNombre.Text, txtApellido.Text, String.IsNullOrEmpty(txtDNI.Text) ?  0 : Int32.Parse(txtDNI.Text));

                if (modificacion)
                {
                    tablaClientes.DataSource = SQLCliente.filtrarClientes(clieABuscar);
                }
                else
                {
                    tablaClientes.DataSource = SQLCliente.filtrarClientesHabilitados(clieABuscar);
                }
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
            if (tablaClientes.Rows.Count > 0)
            {
                if (clienteSeleccionado.habilitado == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Esta seguro?", "Esta seguro que quiere dar de baja este cliente?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string response = SQLCliente.eliminarCliente(clienteSeleccionado);
                        MessageBox.Show(response);
                        tablaClientes.DataSource = SQLCliente.obtenerTodosLosClientesHabilitados();
                    }
                }
                else
                {
                    MessageBox.Show("El cliente ya esta eliminado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else { 
                MessageBox.Show("Debe seleccionar algun cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tablaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow clieRow = tablaClientes.Rows[e.RowIndex];
            clienteSeleccionado = new Cliente(clieRow);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tablaClientes.Rows.Count > 0)
            {
                ModificacionCliente modificacionCliente = new ModificacionCliente(clienteSeleccionado);
                modificacionCliente.ShowDialog();

                if (modificacionCliente.DialogResult == DialogResult.OK)
                {
                    recargar();
                }
            }
            else {
                MessageBox.Show("Debe seleccionar algun cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            recargar();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            recargar();
        }

        private void recargar() {
            DataTable clientes;
            if (modificacion)
            {
                //Obtener todos los clientes cuando se carga el formulario
                clientes = SQLCliente.obtenerTodosLosClientes();
            }
            else
            {
                clientes = SQLCliente.obtenerTodosLosClientesHabilitados();

            }
            tablaClientes.DataSource = clientes;
            this.tablaClientes.Columns[0].Visible = false; //usuarioID
            DataGridViewRow clieRow = tablaClientes.Rows[0];
            clienteSeleccionado = new Cliente(clieRow);

            txtDNI.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
        }
    }
}
