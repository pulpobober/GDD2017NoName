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
        int idFactura = -1;

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
            tablaPreviaFacturacion.Hide();
            lblNumeroFacturacionTexto.Hide();
            lblNumeroFacturacion.Hide();

            lblfechaFinFacturacionPrevia.Hide();
            lblFechaFinFacturacionPreviaTexto.Hide();
            lblFechaInicioFacturacionPrevia.Hide();
            lblFechaInicioFactPreviaTexto.Hide();
            btnConfirmarFacturacion.Hide();
            lblFactTotalPreviaTexto.Hide();
            lblFacturacionTotalPrevia.Hide();
            lblPrevisualizacionFact.Hide();

        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            DataTable previaFacturacion = SQLFacturacion.ObtenerFacturacionCliente(obtenerIDCliente(cmbClientes.SelectedItem.ToString()));
            if (previaFacturacion.Rows.Count == 0)
            {
                MessageBox.Show("No hay nada para facturar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if (!Convert.ToBoolean(previaFacturacion.Rows[0][3].ToString()))
                {
                    DataTable respuesta = SQLFacturacion.rendirElTotal(obtenerIDCliente(cmbClientes.SelectedItem.ToString()));
                    if (respuesta.Rows.Count == 0)
                    {
                        MessageBox.Show("Hubo un error", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        lblFacturacionTotalPrevia.Text = respuesta.Rows[0][0].ToString();
                        idFactura = int.Parse(respuesta.Rows[0][1].ToString());
                        tablaPreviaFacturacion.DataSource = previaFacturacion;

                        lblFechaInicioFacturacionPrevia.Text = tablaPreviaFacturacion.Rows[0].Cells["fecha_hora_inicio"].Value.ToString();
                        lblfechaFinFacturacionPrevia.Text = Settings.Default.fecha_sistema.ToString();

                        tablaPreviaFacturacion.Columns[2].Visible = false; //fecha_hora_inicio
                        tablaPreviaFacturacion.Columns[3].Visible = false; //rendido

                        tablaPreviaFacturacion.Show();
                        lblfechaFinFacturacionPrevia.Show();
                        lblFechaFinFacturacionPreviaTexto.Show();
                        lblFechaInicioFacturacionPrevia.Show();
                        lblFechaInicioFactPreviaTexto.Show();
                        btnConfirmarFacturacion.Show();
                        lblFactTotalPreviaTexto.Show();
                        lblFacturacionTotalPrevia.Show();
                        lblPrevisualizacionFact.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Ya esta hecha la facturacion para ese cliente en ese mes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            lblFacturacionClientesTexto.Show();
            lblFacturacionTotal.Show();
            lblFechaFinFacturacion.Show();
            lblFechaFinFacturacionTexto.Show();
            lblFechaInicioFacturacion.Show();
            lblFechaInicioFacturacionTexto.Show();
            tablaFacturacion.Show();
            lblDetalleDeFacturacion.Show();
            lblNumeroFacturacionTexto.Show();
            lblNumeroFacturacion.Show();

            SQLFacturacion.facturar(idFactura);
            tablaFacturacion.DataSource = tablaPreviaFacturacion.DataSource;
            tablaFacturacion.Columns[2].Visible = false; //fecha_hora_inicio
            tablaFacturacion.Columns[3].Visible = false; //rendido
            lblFacturacionTotal.Text = lblFacturacionTotalPrevia.Text;
            lblNumeroFacturacion.Text = idFactura.ToString();
            lblFechaInicioFacturacion.Text = lblFechaInicioFacturacionPrevia.Text;
            lblFechaFinFacturacion.Text = lblfechaFinFacturacionPrevia.Text;
            btnFacturacionPrevia.Enabled = false;
            btnConfirmarFacturacion.Enabled = false;
        }


    }
}
