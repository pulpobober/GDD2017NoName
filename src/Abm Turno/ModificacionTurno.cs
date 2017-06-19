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
            if (verificarDatosTurno(cmbInicio.SelectedItem, cmbFinal.SelectedItem, txtDescripcion.Text, txtValorKm.Text, txtPrecioBase.Text))
            {
                Turno nuevoTurno = new Turno(idTurno, Int32.Parse(sacarHoraReal(cmbInicio.SelectedItem.ToString())), Int32.Parse(sacarHoraReal(cmbFinal.SelectedItem.ToString())), txtDescripcion.Text, double.Parse(txtValorKm.Text), double.Parse(txtPrecioBase.Text), ckbHabilitado.Checked);
                string response=SQLTurno.modificarTurno(nuevoTurno);
                MessageBox.Show(response);
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
        }

         private void ModificacionTurno_Load(object sender, EventArgs e)
         {

         }

         private void cmbInicio_SelectedIndexChanged(object sender, EventArgs e)
         {

         }
    }
}
