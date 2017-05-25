using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Menu_Acciones
{
    public partial class MenuAcciones : Form
    {
        int user_id;
        int rol_id;
        DataTable accionesUsuario;

        public MenuAcciones()
        {
            InitializeComponent();
        }


        public MenuAcciones(int rol, int user)
        {
            rol_id = rol;
            user_id = user;
            InitializeComponent();
            
            // accionesUsuario se carga con todas las acciones de ese usuario
            //accionesUsuario = DAO.DAORoles.funcionabilidadesHabilitadasXRol(rol_id);

            foreach (DataRow row in accionesUsuario.Rows)
            {

                cmbAcciones.Items.Add(row["Nombre"].ToString());
                cmbAcciones.SelectedIndex = 0;


            }

        }

        private void btnSeleccionarAccion_Click(object sender, EventArgs e)
        {

        }
    }
}
