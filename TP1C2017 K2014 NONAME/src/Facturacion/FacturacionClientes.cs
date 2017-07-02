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
using UberFrba.Properties;

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
            clientes = SQLCliente.obtenerTodosLosClientesHabilitados();

            foreach (DataRow row in clientes.Rows)
            {
                cmbClientes.Items.Add(row["nombre"].ToString() + " " + row["apellido"].ToString());
                cmbClientes.SelectedIndex = 0;
            }
            lblFacturacionClientesTexto.Hide();
            lblFacturacionTotal.Hide();
            lblFechaFinFacturacion.Hide();
            lblFechaFinFacturacionTexto.Hide();
            lblFechaInicioFacturacion.Hide();
            lblFechaInicioFacturacionTexto.Hide();
            tablaFacturacion.Hide();
            lblDetalleDeFacturacion.Hide();

        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            tablaFacturacion.DataSource = SQLFacturacion.ObtenerFacturacionCliente(obtenerIDCliente(cmbClientes.SelectedItem.ToString()));
            
            lblFacturacionTotal.Text = SQLFacturacion.rendirElTotal(obtenerIDCliente(cmbClientes.SelectedItem.ToString())).ToString();

            if (lblFacturacionTotal.Text != "0")
            {
                lblFacturacionClientesTexto.Show();
                lblFacturacionTotal.Show();
                lblFechaFinFacturacion.Show();
                lblFechaInicioFacturacion.Show();
                lblFechaFinFacturacionTexto.Show();
                lblFechaInicioFacturacionTexto.Show();
                tablaFacturacion.Columns[2].Visible = false; //fecha_hora_inicio
                lblFechaInicioFacturacion.Text = tablaFacturacion.Rows[0].Cells["fecha_hora_inicio"].Value.ToString();
                lblFechaFinFacturacion.Text = Settings.Default.fecha_sistema.ToString();
            }
            else {
                MessageBox.Show("No tiene nada para facturar en este mes el cliente seleccionado");

            }
           
            

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

        private void btnConfirmarFacturacion_Click(object sender, EventArgs e)
        {

        }


    }
}
