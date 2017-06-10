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

                Turno nuevoTurno = new Turno(idTurno, Int32.Parse(sacarHoraReal(cmbInicio.SelectedItem.ToString())), Int32.Parse(sacarHoraReal(cmbFinal.SelectedItem.ToString())), txtDescripcion.Text, Int32.Parse(txtValorKm.Text), Int32.Parse(txtPrecioBase.Text), ckbHabilitado.Checked);
                SQLTurno.modificarTurno(nuevoTurno);
            }
        }

         public ModificacionTurno(Turno tur) {
            InitializeComponent();
            idTurno = tur.id_turno;
            cmbInicio.SelectedItem = agregarHoraReal(tur.hora_inicio.ToString());
            cmbFinal.SelectedItem = agregarHoraReal(tur.hora_fin.ToString());
            txtDescripcion.Text = tur.descripcion;
            txtValorKm.Text = tur.valor_km.ToString();
            txtPrecioBase.Text = tur.precio_base.ToString();
        }

         private void ModificacionTurno_Load(object sender, EventArgs e)
         {

         }
    }
}
