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
        public ListadoAutomoviles()
        {
            InitializeComponent();
        }

        private void ListaAutomoviles_Load(object sender, EventArgs e)
        {
            //Obtener todos los automoviles cuando se carga el formulario
            DataTable autos = SQLAutomovil.obtenerTodosLosAutomoviles();
            tablaAutomoviles.DataSource = autos;
        }
        private int obtainIdMarca(string marca)
        {
            int length_substring = marca.IndexOf("]");
            int idMarca = Convert.ToInt32(marca.Substring(1, length_substring - 1));
            return idMarca;
        }
        private int obtainIdTurno(string turno)
        {
            SqlConnection miConexion = new SqlConnection(ConexionSQL.cadenaConexion());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT id_turno FROM Noname.Turno where descripcion='" + turno + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = miConexion;

            miConexion.Open();

            reader = cmd.ExecuteReader();

            // miConexion.Close();

            while (reader.Read())
            {
                return Convert.ToInt32(reader["id_turno"]);
            }
            return 0;
        }
        private int obtainIdChofer(string chofer)
        {
            chofer = chofer.Replace(' ', '_');
            int indexof_whitspace = chofer.IndexOf("_");
            string nombre = chofer.Substring(0, indexof_whitspace);
            string apellido = chofer.Substring(indexof_whitspace + 1);

            SqlConnection miConexion = new SqlConnection(ConexionSQL.cadenaConexion());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "Select id_usuario from NONAME.Usuario inner join NONAME.Chofer on id_usuario=id_chofer where nombre='" + nombre + "' and apellido='" + apellido + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = miConexion;

            miConexion.Open();

            reader = cmd.ExecuteReader();

            // miConexion.Close();

            while (reader.Read())
            {
                return Convert.ToInt32(reader["id_usuario"]);
            }
            return 0;

        }

        private bool verificarDatosAutomovil(string patente, string modelo, string marca, string chofer)
        {
            if (patente.Length == 0 && modelo.Length == 0 && marca.Length == 0 && chofer.Length == 0)
            {
                MessageBox.Show("Debe escribir algun campo para filtrar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro?", "Esta seguro que quiere dar de baja este Automovil?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int response=SQLAutomovil.eliminarAutomovil(autoSeleccionado);
                if (response > 0)
                {
                    MessageBox.Show("El automovil "+autoSeleccionado.idautomovil+" ha sido eliminado");
                }
                else{
                    MessageBox.Show("El automovil " + autoSeleccionado.idautomovil + " no ha podido eliminarse");
                }

                
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (verificarDatosAutomovil(txtPatente.Text, txtModelo.Text, selectMarca.GetItemText(selectMarca.SelectedItem), txtChofer.Text))
            {   
                int idmarca = selectMarca.Text!=""?obtainIdMarca(selectMarca.Text):0;
                int idchofer = txtChofer.Text!=""?obtainIdChofer(txtChofer.Text):0;
                Automovil autoABuscar = new Automovil(idmarca, txtModelo.Text, txtPatente.Text, idchofer);
                tablaAutomoviles.DataSource = SQLAutomovil.filtrarAutomoviles(autoABuscar);
            }
        }
        private void tablaAutomoviles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          DataGridViewRow autoRow = tablaAutomoviles.Rows[e.RowIndex];
            autoSeleccionado = new Automovil(autoRow);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DataTable autos = SQLAutomovil.obtenerTodosLosAutomoviles();
            tablaAutomoviles.DataSource = autos;
            selectMarca.Text = "";
            txtModelo.Text = "";
            txtPatente.Text = "";
            txtChofer.Text = "";
            //this.tablaAutomoviles.Columns[0].Visible = false; //autoID
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            new ModificacionAutomovil(autoSeleccionado).ShowDialog();
        }

        private void tablaAutomoviles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow autoRow = tablaAutomoviles.Rows[e.RowIndex];
            autoSeleccionado = new Automovil(autoRow);
        }

    }
}
