using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Facturacion
{
    public partial class FacturacionClientes : Form
    {
        public FacturacionClientes()
        {
            InitializeComponent();
        }

        private void FacturacionClientes_Load(object sender, EventArgs e)
        {
            //llenar con llos nombres de los clientes
            DataTable clientes = new DataTable();

            foreach (DataRow row in clientes.Rows)
            {
                cmbClientes.Items.Add(row["nombre"].ToString());
                cmbClientes.SelectedIndex = 0;
            }
        }
    }
}
