using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Login
{
    public partial class RolesUsuario : Form
    {

        int user_id;
        DataTable rolesUsuario;

        public RolesUsuario()
        {
            InitializeComponent();
        }

        public RolesUsuario(int userId)
        {
            user_id = userId;
            InitializeComponent();

            //rolesUsuario me deberia devolver todos los roles que tiene el usuario
            //rolesUsuario = DAO.DAOLogin.roles_x_usuario(userId);

            //Aca va recorriendo la tabla y los va agregando al cmbRoles
            foreach (DataRow row in rolesUsuario.Rows)
            {
                cmbRoles.Items.Add(row["Nombre"].ToString());
                cmbRoles.SelectedIndex = 0;
            }
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            DataRow[] row = rolesUsuario.Select("Nombre='" + cmbRoles.Text + "'");
            new Menu_Acciones.MenuAcciones(int.Parse(row[0]["Rol_id"].ToString()), user_id).ShowDialog();
            this.Close();
        }

        //Cuando se carga la pantalla, verifica si hay uno o mas roles
        private void RolesUsuario_Load(object sender, EventArgs e)
        {
            if (cmbRoles.Items.Count == 1)
            {
                DataRow[] row = rolesUsuario.Select("Nombre='" + cmbRoles.Text + "'");
                new Menu_Acciones.MenuAcciones(int.Parse(row[0]["Rol_id"].ToString()), user_id).ShowDialog();
                this.Close();
            }
            if (cmbRoles.Items.Count == 0)
            {
                MessageBox.Show("Usted no posee un rol asignado", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
