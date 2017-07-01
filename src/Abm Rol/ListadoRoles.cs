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
        bool modificacion;

        public ListadoRoles()
        {
            InitializeComponent();
        }

        public ListadoRoles(bool modif)
        {
            InitializeComponent();
            modificacion = modif;
            if (modificacion)
            {
                btnEliminar.Hide();
            }
            else {
                btnModificar.Hide();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (listaRoles.Rows.Count > 0)
            {
                ModificacionRol modificacionRol = new ModificacionRol(rolSeleccionado);
                modificacionRol.ShowDialog();

                if (modificacionRol.DialogResult == DialogResult.OK)
                {
                    recargar();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar algun rol", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listaRoles.Rows.Count > 0)
            {
                if (rolSeleccionado.estado == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Esta seguro?", "Esta seguro que quiere dar de baja este rol?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string response = SQLRoles.eliminarRol(rolSeleccionado);
                        MessageBox.Show(response);
                    }
                }
                else
                {
                    MessageBox.Show("El rol ya esta eliminado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else {
                MessageBox.Show("Debe seleccionar algun rol", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListadoRoles_Load(object sender, EventArgs e)
        {
            recargar();
        }
        private void recargar() {
            DataTable roles;
            if (modificacion)
            {
                roles = SQLRoles.obtenerTodosLosRoles();
            }
            else
            {
                roles = SQLRoles.obtenerTodosLosRolesHabilitados();
            }
            listaRoles.DataSource = roles;
            this.listaRoles.Columns[0].Visible = false; //rol_id
            this.listaRoles.Columns[2].Visible = false; //habilitado
            DataGridViewRow listaRow = listaRoles.Rows[0];
            rolSeleccionado = new Rol(listaRow);

        }

        private void listaRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow listaRow = listaRoles.Rows[e.RowIndex];
            rolSeleccionado = new Rol(listaRow);
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            recargar();
        }
    }
}
