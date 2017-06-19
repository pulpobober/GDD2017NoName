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

namespace UberFrba.Login
{
    public partial class RolesUsuario : Form
    {
        int id_usuario;
        string nombre_usuario;
        DataTable rolesUsuario;

        public RolesUsuario()
        {
            InitializeComponent();
        }

        public RolesUsuario(int idUsuario, string nombreUsuario)
        {
            InitializeComponent();
            nombre_usuario  = nombreUsuario;
            id_usuario = idUsuario;

            //rolesUsuario me deberia devolver todos los roles que tiene el usuario
            rolesUsuario = SQLLogin.obtenerRolesUsuario(nombreUsuario);
            //Aca va recorriendo la tabla y los va agregando al cmbRoles
            foreach (DataRow row in rolesUsuario.Rows)
            {
                cmbRoles.Items.Add(row["tipo"].ToString());
                cmbRoles.SelectedIndex = 0;
            }
        }

        
        private void btnRol_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu_Acciones.MenuAcciones(obtenerIdRolSeleccionado(cmbRoles.SelectedItem.ToString()), id_usuario).ShowDialog();
        }

        //Cuando se carga la pantalla, verifica si hay un solo rol o mas roles
        private void RolesUsuario_Load(object sender, EventArgs e)
        {
            if (cmbRoles.Items.Count == 1)
            {
                this.Hide();
                this.Close();
                new Menu_Acciones.MenuAcciones(obtenerIdRolSeleccionado(cmbRoles.SelectedItem.ToString()), id_usuario).ShowDialog();
            }
            if (cmbRoles.Items.Count == 0)
            {
                this.Hide();
                MessageBox.Show("Usted no posee un rol asignado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private int obtenerIdRolSeleccionado(string tipo) { 
            foreach (DataRow row in rolesUsuario.Rows)
            {
                if (row["tipo"].ToString() == tipo){
                    return int.Parse(row["id_rol"].ToString());
                }
            }
            return -1;
        }
    }
}
