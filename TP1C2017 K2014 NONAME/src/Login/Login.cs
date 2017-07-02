﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //resulLogin deberia devolver el id del usuario si lo encuetra
            int resultadoLogin;

            if (txtUsuario.Text.Length == 0 && txtContrasenia.Text.Length == 0){
                MessageBox.Show("Debe llenar usuario y contrasena", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else{
                resultadoLogin = SQLLogin.verificarLogin(txtUsuario.Text, txtContrasenia.Text);

                if (resultadoLogin > 0)
                {
                    this.Hide();
                    new RolesUsuario(resultadoLogin, txtUsuario.Text).ShowDialog();
                }

                if (resultadoLogin == 0)
                {
                    MessageBox.Show("Usuario o contrasena invalida", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                if (resultadoLogin == -1)
                {
                    MessageBox.Show("Usuario Bloqueado", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}