using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Objetos;

namespace UberFrba.Abm_Rol
{
    public partial class ModificacionRol : AbmRol
    {
        public ModificacionRol()
        {
            InitializeComponent();
        }

        public ModificacionRol(Rol rolSeleccionado)
        {
            txtNombreRol.Text = rolSeleccionado.nombre;
            ckbHabilitado.Checked = rolSeleccionado.estado ? true : false;
            
         //   ckbHabilitado.set
//            ckb.selec = rolSeleccionado.estado ? "Habilitado" : "Desabilitado";
          //  checkListFuncionalidades llenarlo con los datos de este usuario, lo voy a pedir ahora
            //checkListFuncionalidades.Items.
        }
    }
}
