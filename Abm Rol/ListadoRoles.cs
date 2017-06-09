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

namespace UberFrba.Abm_Rol
{
    public partial class ListadoRoles : Form
    {
        Rol rolSeleccionado;

        public ListadoRoles()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            new ModificacionRol(rolSeleccionado).ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro?", "Esta seguro que quiere dar de baja este rol?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {              
                //Rol rolSeleccionado = new Rol(listaRoles.SelectedItem.ToString());
              //  SQLRoles.eliminarRol(rolSeleccionado);
            }

        }

        private void ListadoRoles_Load(object sender, EventArgs e)
        {
            DataTable roles = SQLRoles.obtenerTodosLosRoles();
            listaRoles.DataSource = roles;
            this.listaRoles.Columns[0].Visible = false; //rol_id
            this.listaRoles.Columns[2].Visible = false; //habilitado


        }

        private void listaRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow listaRow = listaRoles.Rows[e.RowIndex];
            rolSeleccionado = new Rol(listaRow);


        }
    }
}
