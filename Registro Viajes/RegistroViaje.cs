using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Registro_Viajes
{
    public partial class RegistroViaje : Form
    {
        int idCliente;
        public RegistroViaje()
        {
            InitializeComponent();
        }

        public RegistroViaje(int id_cliente)
        {
            InitializeComponent();
            idCliente = id_cliente;

        }

        private void RegistroViaje_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimeFin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarViaje_Click(object sender, EventArgs e)
        {

        }
    }
}
