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
using System.Data.SqlClient;

namespace UberFrba.Rendicion_Viajes
{
    public partial class RendicionViajes : Form
    {
        DataTable tablaTurnos;
        DataTable tablaChoferes;
        int id_turno = -1;
        int id_chofer = -1;
        int idRendicion = -1;

        public RendicionViajes()
        {
            InitializeComponent();
            lblImporteTotal.Hide();
            lblImporteTotalTexto.Hide();
            lblNumeroRendicion.Hide();
            lblNumeroRendicionTexto.Hide();
            lblPrevisualizarImporte.Hide();
            lblPrevisualizarImporteTexto.Hide();
            lblDetalleRendicion.Hide();
            tablaRendicion.Hide();
            tablaPreviaRendicion.Hide();
            lblPrevisualizar.Hide();
            btnConfirmarRendicion.Hide();

            tablaTurnos = SQLTurno.obtenerTodosLosTurnos();

            foreach (DataRow row in tablaTurnos.Rows)
            {
                cmbTurno.Items.Add(row["descripcion"].ToString());
                cmbTurno.SelectedIndex = 0;
            }

            tablaChoferes = SQLChofer.obtenerTodosLosChoferes();

            foreach (DataRow row in tablaChoferes.Rows)
            {
                cmbChoferes.Items.Add(row["nombre"].ToString() + " " + row["apellido"].ToString());
                cmbChoferes.SelectedIndex = 0;
            }

        }

        private void btnRendir_Click(object sender, EventArgs e)
        {

            foreach (DataRow row in tablaTurnos.Rows)
            {
                if (row["descripcion"].ToString() == cmbTurno.SelectedItem.ToString())
                {
                    id_turno = int.Parse(row["id_turno"].ToString());
                }
            }

            foreach (DataRow row in tablaChoferes.Rows)
            {
                if (row["nombre"].ToString() + " " + row["apellido"].ToString() == cmbChoferes.SelectedItem.ToString())
                {
                    id_chofer = int.Parse(row["id_usuario"].ToString());
                }
            }

            DataTable previaRendicion = SQLRendicionViajes.previsualizarConDetalle(id_chofer, id_turno, selectorFecha.Value);
            if (previaRendicion.Rows.Count == 0)
            {
                MessageBox.Show("No hay nada para rendir", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (!Convert.ToBoolean(previaRendicion.Rows[0][3].ToString()))
                {
                    tablaPreviaRendicion.DataSource = previaRendicion;

                    DataTable respuesta = SQLRendicionViajes.rendirElTotal(id_chofer, id_turno, selectorFecha.Value);
                    if (respuesta.Rows.Count == 0)
                    {
                        MessageBox.Show("Hubo un error", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        lblPrevisualizarImporte.Text = respuesta.Rows[0][0].ToString();
                        idRendicion = int.Parse(respuesta.Rows[0][1].ToString());
                        tablaPreviaRendicion.DataSource = previaRendicion;
                        this.tablaPreviaRendicion.Columns[3].Visible = false; //rendido
                        lblPrevisualizarImporte.Show();
                        lblPrevisualizarImporteTexto.Show();
                        lblPrevisualizarImporte.Show();
                        tablaPreviaRendicion.Show();
                        lblPrevisualizar.Show();
                        btnConfirmarRendicion.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Ya esta hecha la rendicion para ese cliente en ese dia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void RendicionViajes_Load(object sender, EventArgs e)
        {

        }

        private void lblDetalleRendicion_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            lblImporteTotal.Show();
            lblImporteTotalTexto.Show();
            lblNumeroRendicion.Show();
            lblNumeroRendicionTexto.Show();
            tablaRendicion.Show();
            lblDetalleRendicion.Show();
            SQLRendicionViajes.rendir(idRendicion, id_chofer, id_turno, selectorFecha.Value);
            tablaRendicion.DataSource = tablaPreviaRendicion.DataSource;
            this.tablaRendicion.Columns[3].Visible = false; //rendido
            lblImporteTotal.Text = lblPrevisualizarImporte.Text;
            lblNumeroRendicion.Text = idRendicion.ToString();


        }
    }
}
