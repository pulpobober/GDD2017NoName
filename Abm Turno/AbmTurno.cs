using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_Turno
{
    public partial class AbmTurno : Form
    {
        public AbmTurno()
        {
            InitializeComponent();
        }

        private void AbmTurno_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++)
            {
                cmbInicio.Items.Add(i.ToString() + ":00");
                cmbFinal.Items.Add(i.ToString() + ":00");
            }
        }

        public bool verificarDatosTurno(string inicio, string fin, string descripcion, string valorKm, string precioBase)
        {
            if (inicio == null)
            {
                MessageBox.Show("No se puede dejar el campo hora inicio vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (fin == null)
            {
                MessageBox.Show("No se puede dejar el campo hora fin vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (descripcion.Length == 0)
            {
                MessageBox.Show("No se puede dejar el campo descripcion vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (valorKm.Length == 0)
            {
                MessageBox.Show("No se puede dejar el campo valor kilometro vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (precioBase.Length == 0)
            {
                MessageBox.Show("No se puede dejar el campo precio base vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

    }
}
