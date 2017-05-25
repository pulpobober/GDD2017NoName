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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //resulLogin deberia devolver el id del usuario si lo encuetra
            int resulLogin;

            //resulLogin = DAO.DAOLogin.login(txtUsuario.Text, txtContrasenia.Text);
            if (txtUsuario.Text == "admin" && txtContrasenia.Text == "admin")
            {
                resulLogin = 1;
            }
            else {
                resulLogin = 0;
            }

            if (resulLogin == 1)
            {
                new RolesUsuario(resulLogin).ShowDialog();
            }

            if (resulLogin == 0)
            {
                MessageBox.Show("Usuario o contrasena incorrecto", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
