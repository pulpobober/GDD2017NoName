using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_Automovil
{
    public partial class AbmAutomovil : Form
    {
        public AbmAutomovil()
        {
            InitializeComponent();
        }

        public bool verificarDatosAutomovil(string turno, string patente, string modelo, string marca, string chofer)
        {
            if (turno.Length == 0)
            {
                MessageBox.Show("No se puede dejar el campo turno vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (patente.Length == 0)
            {
                MessageBox.Show("No se puede dejar el campo patente vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (modelo.Length == 0)
            {
                MessageBox.Show("No se puede dejar el campo modelo vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (marca.Length == 0)
            {
                MessageBox.Show("No se puede dejar el campo marca vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (chofer.Length == 0)
            {
                MessageBox.Show("No se puede dejar el campo chofer vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
