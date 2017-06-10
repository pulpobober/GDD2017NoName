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
            cmbInicio.Items.Clear();
            cmbFinal.Items.Clear();

            for (int i = 0; i < 25; i++)
            {
                cmbInicio.Items.Add(i.ToString() + ":00");
                cmbFinal.Items.Add(i.ToString() + ":00");
            }
        }

        public bool verificarDatosTurno(object inicio, object fin, string descripcion, string valorKm, string precioBase)
        {
            if (inicio == null)
            {
                MessageBox.Show("No se puede dejar el campo hora inicio vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (fin == null)
            {
                MessageBox.Show("No se puede dejar el campo hora finalizacion vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtValorKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPrecioBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        public string agregarHoraReal(string horaReal)
        {
            return horaReal + ":00";
        }

        public string sacarHoraReal(string horaReal)
        {
            string hora = "";
            for (int i = 0; i < horaReal.Length; i++)
            {
                if (horaReal[i] == ':')
                {
                    return hora;
                }
                else
                {
                    hora += horaReal[i];
                }
            }
            return hora;
        }

    }
}
