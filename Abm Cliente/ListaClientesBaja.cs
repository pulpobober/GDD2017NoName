using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Objetos;
using UberFrba.ConexionBD;

namespace UberFrba.Abm_Cliente
{
    public partial class ListaClientesBaja : ListaClientes
    {
        public ListaClientesBaja()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        public override void seleccionoCliente(Cliente clie)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro?", "Esta seguro que quiere dar de baja este cliente?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SQLCliente.eliminarCliente(clie);
            }
            //base.seleccionoCliente(clie);
        }
    }
}
