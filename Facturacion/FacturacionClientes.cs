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

namespace UberFrba.Facturacion
{
    public partial class FacturacionClientes : Form
    {

        DataTable clientes;
        public FacturacionClientes()
        {
            InitializeComponent();
        }

        private void FacturacionClientes_Load(object sender, EventArgs e)
        {
            //llenar con los nombres de los clientes
            clientes = SQLCliente.obtenerTodosLosClientes();

            foreach (DataRow row in clientes.Rows)
            {
                cmbClientes.Items.Add(row["nombre"].ToString() + " " + row["apellido"].ToString());
                cmbClientes.SelectedIndex = 0;
            }
            lblFacturacionClientesTexto.Hide();
            lblFacturacionTotal.Hide();

        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            tablaFacturacion.DataSource = SQLFacturacion.ObtenerFacturacionCliente(obtenerIDCliente(cmbClientes.SelectedItem.ToString()));
            lblFacturacionClientesTexto.Show();
            lblFacturacionTotal.Show();

            lblFacturacionTotal.Text = SQLFacturacion.rendirElTotal(obtenerIDCliente(cmbClientes.SelectedItem.ToString())).ToString();
        }

        private int obtenerIDCliente(string nombreUsuario)
        {
            foreach (DataRow row in clientes.Rows)
            {
                if (row["nombre"].ToString() + " " + row["apellido"].ToString() == nombreUsuario)
                {
                    return int.Parse(row["id_usuario"].ToString());
                }
            }
            return -1;
        }


    }
}
