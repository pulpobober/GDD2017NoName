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
    public partial class ModificacionRol : AbmRol
    {
        DataTable funcionalidadesHabilitadas;
        int idRol;
        public ModificacionRol()
        {
            InitializeComponent();
        }

        public ModificacionRol(Rol rolSeleccionado)
        {
            InitializeComponent();
            funcionalidades = SQLRoles.obtenerTodasLasFuncionalidades();

            txtNombreRol.Text = rolSeleccionado.nombre;
            ckbHabilitado.Checked = rolSeleccionado.estado ? true : false;
            idRol = rolSeleccionado.id_rol;

            funcionalidadesHabilitadas = SQLRoles.obtenerTodasLasFuncionalidadesHabilitadasDelRol(rolSeleccionado.id_rol);
            foreach (DataRow row in funcionalidades.Rows)
            {
                Boolean check = estaHabilitadaLaFuncion(row["id_funcion"].ToString());
                checkListFuncionalidades.Items.Add(row["descripcion"].ToString(), check);
            }
        }

        private Boolean estaHabilitadaLaFuncion(String id_funcion) { 
            foreach (DataRow row in funcionalidadesHabilitadas.Rows)
            {
                if(row["id_funcion"].ToString() == id_funcion){
                   return true;
                }
            }
            return false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (verificarDatosRol(txtNombreRol.Text))
            {
                DataTable funcionalidadesHabilitadas = obtenerFuncionalidadesHabilitadas();
                Rol unRol = new Rol(idRol, txtNombreRol.Text, ckbHabilitado.Checked ? true : false, funcionalidadesHabilitadas);
                SQLRoles.modificarRol(unRol);
            }
        }
    }
}
