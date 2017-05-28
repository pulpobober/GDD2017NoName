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

namespace UberFrba.Abm_Cliente
{
    public partial class ListaClientesModificacion : ListaClientes
    {
        public ListaClientesModificacion()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        public override void seleccionoCliente(Cliente clie)
        {
            new ModificacionCliente(clie).ShowDialog();
 	        //base.seleccionoCliente(clie);
        }
    }

}
