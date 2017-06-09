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

namespace UberFrba.Abm_Rol
{
    public partial class AltaRol : AbmRol
    {
        public AltaRol()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            DataTable funcionalidadesHabilitadas = obtenerFuncionalidadesHabilitadas();
             Rol unRol = new Rol(txtNombreRol.Text, ckbHabilitado.Checked ? true : false, funcionalidadesHabilitadas);
            SQLRoles.insertarRol(unRol);
        }
    }
}
