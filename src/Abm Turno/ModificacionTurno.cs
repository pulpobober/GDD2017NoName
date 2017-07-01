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
    public partial class ModificacionTurno : AbmTurno
    {
        int idTurno;
        public ModificacionTurno()
        {
            InitializeComponent();
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            if (verificarDatosTurno(txtDescripcion.Text, txtValorKm.Text, txtPrecioBase.Text))
            {
                Turno nuevoTurno = new Turno(idTurno, Int32.Parse(sacarHoraReal(cmbInicio.Text)), Int32.Parse(sacarHoraReal(cmbFinal.Text)), txtDescripcion.Text, double.Parse(txtValorKm.Text), double.Parse(txtPrecioBase.Text), ckbHabilitado.Checked);
                string response=SQLTurno.modificarTurno(nuevoTurno);
                this.DialogResult = DialogResult.OK;
                MessageBox.Show(response);
                this.Close();
            }
        }

         public ModificacionTurno(Turno tur) {
            InitializeComponent();
            idTurno = tur.id_turno;
            cmbInicio.SelectedItem = agregarHoraReal(tur.hora_inicio.ToString());
            cmbInicio.Text = agregarHoraReal(tur.hora_inicio.ToString());
            cmbFinal.SelectedItem = agregarHoraReal(tur.hora_fin.ToString());
            cmbFinal.Text = agregarHoraReal(tur.hora_fin.ToString());
            txtDescripcion.Text = tur.descripcion;
            txtValorKm.Text = tur.valor_km.ToString();
            txtPrecioBase.Text = tur.precio_base.ToString();
            ckbHabilitado.Checked = tur.habilitado;
        }

         private void ModificacionTurno_Load(object sender, EventArgs e)
         {

         }

         private void cmbInicio_SelectedIndexChanged(object sender, EventArgs e)
         {

         }

         private void ModificacionTurno_Load_1(object sender, EventArgs e)
         {

         }
    }
}
