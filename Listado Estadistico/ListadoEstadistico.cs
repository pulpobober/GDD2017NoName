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

namespace UberFrba.Listado_Estadistico
{
    public partial class ListadoEstadistico : Form
    {
        public ListadoEstadistico()
        {
            InitializeComponent();
            cmbTrimestre.SelectedIndex = 0;

        }


        private int obtenerTrimestre()
        {
            switch (cmbTrimestre.Text)
            {
                case "Primero":
                    return 1;

                case "Segundo":
                    return 2;

                case "Tercero":
                    return 3;

                case "Cuarto":
                    return 4;
            }
            return 0;
        }

        private void btnMostrarListado_Click(object sender, EventArgs e)
        {
            int anio = int.Parse(txtAnio.Text);

            int trimestre = obtenerTrimestre();

            switch (cmbListado.Text)
            {

                case "":
                    MessageBox.Show("Seleccione un listado estadistico", "Listado Estadistico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Top 5 de los choferes con mayor recaudacion":
                    tablaListado.DataSource = SQLListadoEstadistico.choferesConMasRecaudacion(anio, trimestre);
                    break;

                case "Top 5 de los choferes con el viaje mas largo realizado":
                    tablaListado.DataSource = SQLListadoEstadistico.choferesConElViajeMasLargoRealizado(anio, trimestre);
                    break;

                case "Top 5 de los clientes con mayor consumo":
                    tablaListado.DataSource = SQLListadoEstadistico.clientesConMayorConsumo(anio, trimestre);
                    break;

                case "Cliente que utilizo mas veces el mismo automovil en los viajes que ha realizado":
                    tablaListado.DataSource = SQLListadoEstadistico.ClienteQueUtilizoMasVecesElMismoAutomovil(anio, trimestre);
                    break;
            }
        }

        private void ListadoEstadistico_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
