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

        public RendicionViajes()
        {
            InitializeComponent();
            lblImporteTotal.Hide();
            lblImporteTotalTexto.Hide();


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
            int id_turno = -1;
            int id_chofer = -1;
            foreach (DataRow row in tablaTurnos.Rows)
            {
                if (row["descripcion"].ToString() == cmbTurno.SelectedItem.ToString()) {
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


            lblImporteTotal.Show();
            lblImporteTotalTexto.Show();
            tablaRendicion.DataSource = SQLRendicionViajes.rendirConDetalle(id_chofer, id_turno, selectorFecha.Value);
           // lblImporteTotal.Text = SQLRendicionViajes.rendirElTotal(id_chofer, id_turno, selectorFecha.Value).ToString();
        }
    }
}
