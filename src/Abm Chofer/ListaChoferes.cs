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
    public partial class ListaChoferes : Form
    {
        Chofer choferSeleccionado;
        bool modificacion;
        public ListaChoferes()
        {
            InitializeComponent();
        }

        public ListaChoferes(bool modif)
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

        private void ListaChoferes_Load(object sender, EventArgs e)
        {
            //Obtener todos los Choferes cuando se carga el formulario
            DataTable Choferes;
            if (modificacion)
            {
                Choferes = SQLChofer.obtenerTodosLosChoferes();
            }
            else
            {
                Choferes = SQLChofer.obtenerTodosLosChoferesHabilitados();
            }
            tablaChoferes.DataSource = Choferes;
            this.tablaChoferes.Columns[0].Visible = false; //usuarioID
            DataGridViewRow clieRow = tablaChoferes.Rows[0];
            choferSeleccionado = new Chofer(clieRow);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (verificarDatosBusqueda(txtNombre.Text, txtApellido.Text, txtDNI.Text))
            {
                Chofer clieABuscar = new Chofer(txtNombre.Text, txtApellido.Text, String.IsNullOrEmpty(txtDNI.Text) ?  0 : Int32.Parse(txtDNI.Text));

                if (modificacion)
                {
                    tablaChoferes.DataSource = SQLChofer.filtrarChoferes(clieABuscar);
                }
                else {
                    tablaChoferes.DataSource = SQLChofer.filtrarChoferesHabilitados(clieABuscar);
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

        public void tablaChoferes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (choferSeleccionado.habilitado == true)
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro?", "Esta seguro que quiere dar de baja este chofer?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string response = SQLChofer.eliminarChofer(choferSeleccionado);
                    MessageBox.Show(response);
                }
            }
            else
            {
                MessageBox.Show("El chofer ya esta eliminado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tablaChoferes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow clieRow = tablaChoferes.Rows[e.RowIndex];
            choferSeleccionado = new Chofer(clieRow);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            new ModificacionChofer(choferSeleccionado).ShowDialog();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DataTable Choferes;
            if (modificacion)
            {
                Choferes = SQLChofer.obtenerTodosLosChoferes();
            }
            else
            {
                Choferes = SQLChofer.obtenerTodosLosChoferesHabilitados();
            }
            tablaChoferes.DataSource = Choferes;
            this.tablaChoferes.Columns[0].Visible = false; //usuarioID
            DataGridViewRow clieRow = tablaChoferes.Rows[0];
            choferSeleccionado = new Chofer(clieRow);

            txtDNI.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            DataTable Choferes;
            if (modificacion)
            {
                Choferes = SQLChofer.obtenerTodosLosChoferes();
            }
            else
            {
                Choferes = SQLChofer.obtenerTodosLosChoferesHabilitados();
            }
            tablaChoferes.DataSource = Choferes;
            this.tablaChoferes.Columns[0].Visible = false; //usuarioID
            DataGridViewRow clieRow = tablaChoferes.Rows[0];
            choferSeleccionado = new Chofer(clieRow);

            txtDNI.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
        }
    }
}
