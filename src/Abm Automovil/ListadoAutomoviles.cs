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
using System.Data.SqlClient;


namespace UberFrba.Abm_Automovil
{
    public partial class ListadoAutomoviles : Form
    {
        Automovil autoSeleccionado = new Automovil();

        DataTable tablaMarcas;
        bool modificacion;
        public ListadoAutomoviles()
        {
            InitializeComponent();
        }

        public ListadoAutomoviles(bool modif)
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

        private void ListaAutomoviles_Load(object sender, EventArgs e)
        {
            //Obtener todos los automoviles cuando se carga el formulario
            DataTable autos;
            if (modificacion)
            {
                autos = SQLAutomovil.obtenerTodosLosAutomoviles();
            }
            else {
                autos = SQLAutomovil.obtenerTodosLosAutomovilesHabilitados();
            }
            tablaAutomoviles.DataSource = autos;
            selectMarca.Items.Clear();
            tablaMarcas = SQLAutomovil.obtenerTodasLasMarcas();
            foreach (DataRow row in tablaMarcas.Rows)
            {
                selectMarca.Items.Add(row["nombre"].ToString());
            }

            this.tablaAutomoviles.Columns[0].Visible = false; //autoID
            this.tablaAutomoviles.Columns[3].Visible = false; //marcaID
            this.tablaAutomoviles.Columns[9].Visible = false; //turnoID
            this.tablaAutomoviles.Columns[10].Visible = false; //choferID

            DataGridViewRow autoRow = tablaAutomoviles.Rows[0];
            autoSeleccionado = new Automovil(autoRow);
        }

        private bool verificarDatosAutomovil(string patente, string modelo, string marca, string nombreChofer, string apellidoChofer)
        {
            if (patente.Length == 0 && modelo.Length == 0 && marca.Length == 0 && nombreChofer.Length == 0 && apellidoChofer.Length == 0)
            {
                MessageBox.Show("Debe escribir algun campo para filtrar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (autoSeleccionado.habilitado == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro?", "Esta seguro que quiere dar de baja este Automovil?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int response = SQLAutomovil.eliminarAutomovil(autoSeleccionado);
                    if (response > 0)
                    {
                        MessageBox.Show("El automovil " + autoSeleccionado.idautomovil + " ha sido eliminado");
                        tablaAutomoviles.DataSource = SQLAutomovil.obtenerTodosLosAutomovilesHabilitados();
                    }
                    else
                    {
                        MessageBox.Show("El automovil " + autoSeleccionado.idautomovil + " no ha podido eliminarse");
                    }
                }
            }
            else
            {
                MessageBox.Show("El auto ya esta eliminado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (verificarDatosAutomovil(txtPatente.Text, txtModelo.Text, selectMarca.GetItemText(selectMarca.SelectedItem), txtChoferNombre.Text, txtApellidoChofer.Text))
            {   
                int idmarca = selectMarca.SelectedItem == null ? 0 : obtenerIDMarca(selectMarca.SelectedItem.ToString());

                Automovil autoABuscar = new Automovil(idmarca, txtModelo.Text, txtPatente.Text, txtChoferNombre.Text, txtApellidoChofer.Text);
                if (modificacion)
                {
                    tablaAutomoviles.DataSource = SQLAutomovil.filtrarAutomoviles(autoABuscar);
                }
                else {
                    tablaAutomoviles.DataSource = SQLAutomovil.filtrarAutomovilesHabilitados(autoABuscar);
                }
            }
        }
        private void tablaAutomoviles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          DataGridViewRow autoRow = tablaAutomoviles.Rows[e.RowIndex];
            autoSeleccionado = new Automovil(autoRow);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DataTable autos;
            if (modificacion)
            {
                autos = SQLAutomovil.obtenerTodosLosAutomoviles();
            }
            else
            {
                autos = SQLAutomovil.obtenerTodosLosAutomovilesHabilitados();
            } 
            tablaAutomoviles.DataSource = autos;
            selectMarca.Text = "";
            txtModelo.Text = "";
            txtPatente.Text = "";
            txtChoferNombre.Text = "";
            txtApellidoChofer.Text = "";

            this.tablaAutomoviles.Columns[0].Visible = false; //autoID
            this.tablaAutomoviles.Columns[3].Visible = false; //marcaID
            this.tablaAutomoviles.Columns[9].Visible = false; //turnoID
            this.tablaAutomoviles.Columns[10].Visible = false; //choferID
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificacionAutomovil modificacionAutomovil = new ModificacionAutomovil(autoSeleccionado);
            modificacionAutomovil.ShowDialog();

            if (modificacionAutomovil.DialogResult == DialogResult.OK)
            {
                recargar();
            }
        }

        private void tablaAutomoviles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow autoRow = tablaAutomoviles.Rows[e.RowIndex];
            autoSeleccionado = new Automovil(autoRow);
        }

        public int obtenerIDMarca(string marca)
        {
            foreach (DataRow row in tablaMarcas.Rows)
            {
                if (row["nombre"].ToString() == marca)
                {
                    return int.Parse(row["id_marca"].ToString());
                }
            }
            return -1;
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            recargar();
        }
        private void recargar() {
            DataTable autos;
            if (modificacion)
            {
                autos = SQLAutomovil.obtenerTodosLosAutomoviles();
            }
            else
            {
                autos = SQLAutomovil.obtenerTodosLosAutomovilesHabilitados();
            } 
            tablaAutomoviles.DataSource = autos;

            selectMarca.Items.Clear();
            tablaMarcas = SQLAutomovil.obtenerTodasLasMarcas();
            foreach (DataRow row in tablaMarcas.Rows)
            {
                selectMarca.Items.Add(row["nombre"].ToString());
            }

            this.tablaAutomoviles.Columns[0].Visible = false; //autoID
            this.tablaAutomoviles.Columns[3].Visible = false; //marcaID
            this.tablaAutomoviles.Columns[9].Visible = false; //turnoID
            this.tablaAutomoviles.Columns[10].Visible = false; //choferID

            DataGridViewRow autoRow = tablaAutomoviles.Rows[0];
            autoSeleccionado = new Automovil(autoRow);

            selectMarca.Text = "";
            txtModelo.Text = "";
            txtPatente.Text = "";
            txtChoferNombre.Text = "";
        }
    }
}
