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
using UberFrba.Objetos;

namespace UberFrba.Abm_Turno
{
    public partial class AltaTurno : AbmTurno
    {
        public AltaTurno()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (verificarDatosTurno(txtDescripcion.Text, txtValorKm.Text, txtPrecioBase.Text))
            {
                Turno nuevoTurno = new Turno(Int32.Parse(sacarHoraReal(cmbInicio.SelectedItem.ToString())), Int32.Parse(sacarHoraReal(cmbFinal.SelectedItem.ToString())), txtDescripcion.Text, Int32.Parse(txtValorKm.Text), Int32.Parse(txtPrecioBase.Text), ckbHabilitado.Checked);
                string response=SQLTurno.insertarTurno(nuevoTurno);
                MessageBox.Show(response);
            }
        }

        private void AltaTurno_Load(object sender, EventArgs e)
        {

        }
    }
}
