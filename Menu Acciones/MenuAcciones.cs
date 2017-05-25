using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Me vuelve loco este menu para esta clase https://www.youtube.com/watch?v=zwhyAv-qcbA
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

            //Para cada accion que tiene el usuario lo pongo en el cmbAcciones
            foreach (DataRow row in accionesUsuario.Rows)
            {
                cmbAcciones.Items.Add(row["Nombre"].ToString());
                cmbAcciones.SelectedIndex = 0;
            }
        }

        private void btnSeleccionarAccion_Click(object sender, EventArgs e)
        {
            Hide();
            switch (cmbAcciones.Text)
            {

                case "Alta Rol":
                    new AbmRol.AltaModificacionRol(Accion.Alta).ShowDialog();
                    break;

                case "Baja Rol":
                    new AbmRol.ListadoRoles(Accion.Baja).ShowDialog();
                    break;

                case "Modificacion Rol":
                    new AbmRol.ListadoRoles(Accion.Modificacion).ShowDialog();
                    break;
//////////////////////////////////////////////////////////////////////////////////////////////////////
                case "Alta Cliente":
                    new Abm_Cliente.AbmCliente.AltaModificacionAfiliados(Accion.Alta).ShowDialog();
                    break;

                case "Modificacion Cliente":
                    new AbmCliente.ListadoAfiliadosModificacion().ShowDialog();
                    break;

                case "Baja Cliente":
                    new AbmCliente.ListadoAfiliadosBaja().ShowDialog();
                    break;
//////////////////////////////////////////////////////////////////////////////////////////////////////
                case "Alta Automovil":
                    new AbmAutomovil.AltaModificacionAfiliados(Accion.Alta).ShowDialog();
                    break;

                case "Modificacion Automovil":
                    new AbmAutomovil.ListadoAfiliadosModificacion().ShowDialog();
                    break;

                case "Baja Automovil":
                    new AbmAutomovil.ListadoAfiliadosBaja().ShowDialog();
                    break;
//////////////////////////////////////////////////////////////////////////////////////////////////////
                case "Alta Turno":
                    new AbmTurno.AltaModificacionAfiliados(Accion.Alta).ShowDialog();
                    break;

                case "Modificacion Turno":
                    new AbmTurno.ListadoAfiliadosModificacion().ShowDialog();
                    break;

                case "Baja Turno":
                    new AbmTurno.ListadoAfiliadosBaja().ShowDialog();
                    break;
//////////////////////////////////////////////////////////////////////////////////////////////////////
                case "Alta Chofer":
                    new AbmChofer.AltaModificacionAfiliados(Accion.Alta).ShowDialog();
                    break;

                case "Modificacion Chofer":
                    new AbmChofer.ListadoAfiliadosModificacion().ShowDialog();
                    break;

                case "Baja Chofer":
                    new AbmChofer.ListadoAfiliadosBaja().ShowDialog();
                    break;
//////////////////////////////////////////////////////////////////////////////////////////////////////
                case "Registro Viaje":
                    new RegistrarViaje.SeleccionarOpcionAP(user_id).ShowDialog();
                    break;
//////////////////////////////////////////////////////////////////////////////////////////////////////
                case "Rendicion Viaje":
                    new RendicionViaje.BusquedaAfiliado().ShowDialog();
                    break;
//////////////////////////////////////////////////////////////////////////////////////////////////////
                case "Facturacion Cliente":
                    new Facturacion_Cliente.BusquedaAfiliado().ShowDialog();
                    break;
//////////////////////////////////////////////////////////////////////////////////////////////////////
                case "Listado Estadistico":
                    new Listados.ListadoEstadistico().ShowDialog();
                    break;
            }
            Show();
        }
    }
}
