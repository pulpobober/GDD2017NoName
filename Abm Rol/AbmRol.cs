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

namespace UberFrba.Abm_Rol
{
    public partial class AbmRol : Form
    {
        public DataTable funcionalidades;
        DataTable funcionabilidadesHabilitadas;

        public AbmRol()
        {
            InitializeComponent();
        }

        private void AbmRol_Load(object sender, EventArgs e)
        {
            //Llenar listas funcionalidades
            funcionalidades = SQLRoles.obtenerTodasLasFuncionalidades();
            foreach (DataRow row in funcionalidades.Rows)
            {
                checkListFuncionalidades.Items.Add(row["descripcion"].ToString());
            }
        }
    }
}
