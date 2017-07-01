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
            if (verificarDatosRol(txtNombreRol.Text))
            {
                DataTable funcionalidadesHabilitadas = obtenerFuncionalidadesHabilitadas();
                Rol unRol = new Rol(txtNombreRol.Text, ckbHabilitado.Checked ? true : false, funcionalidadesHabilitadas);
                SQLRoles.insertarRol(unRol);
                MessageBox.Show("Rol dado de alta correctamente");
                this.Close();
            }
        }

        private void AltaRol_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            foreach (DataRow row in funcionalidades.Rows)
            {
                checkListFuncionalidades.Items.Add(row["descripcion"].ToString());
            }
        }
    }
}
