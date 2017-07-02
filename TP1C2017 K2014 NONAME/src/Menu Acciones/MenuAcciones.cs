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


        public MenuAcciones(int id_rol, int id_usuario)
        {
            rol_id = id_rol;
            user_id = id_usuario;
            InitializeComponent();
            
            // accionesUsuario se carga con todas las acciones de ese usuario
            accionesUsuario = SQLRoles.obtenerTodasLasFuncionalidadesHabilitadasDelRol(rol_id);

            //Para cada accion que tiene el usuario lo pongo en el cmbAcciones
            foreach (DataRow row in accionesUsuario.Rows)
            {
                cmbAcciones.Items.Add(row["descripcion"].ToString());
                cmbAcciones.SelectedIndex = 0;
            }
        }

        private void btnSeleccionarAccion_Click(object sender, EventArgs e)
        {
            Hide();
            switch (cmbAcciones.SelectedItem.ToString())
            {
                
                case "Alta Rol":
                    new Abm_Rol.AltaRol().ShowDialog();
                    break;

                case "Baja Rol":
                    new Abm_Rol.ListadoRoles(false).ShowDialog();
                    break;
         
                case "Modificacion Rol":
                    new Abm_Rol.ListadoRoles(true).ShowDialog();
                    break;
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                case "Alta Cliente":
                    new Abm_Cliente.AltaCliente().ShowDialog();
                    break;

                case "Modificacion Cliente":
                    new Abm_Cliente.ListaClientes(true).ShowDialog();
                    break;

                case "Baja Cliente":
                    new Abm_Cliente.ListaClientes(false).ShowDialog();
                    break;
//////////////////////////////////////////////////////////////////////////////////////////////////////
                case "Alta Auto":
                     new Abm_Automovil.AltaAutomovil().ShowDialog();
                     break;

                 case "Modificacion Auto":
                    new Abm_Automovil.ListadoAutomoviles(true).ShowDialog();
                    break;

                 case "Baja Auto":
                     new Abm_Automovil.ListadoAutomoviles(false).ShowDialog();
                     break; 
 //////////////////////////////////////////////////////////////////////////////////////////////////////
                 case "Alta Turno":
                     new Abm_Turno.AltaTurno().ShowDialog();
                     break;

                 case "Modificacion Turno":
                     new Abm_Turno.ListaTurnos(true).ShowDialog();
                     break;

                 case "Baja Turno":
                     new Abm_Turno.ListaTurnos(false).ShowDialog();
                     break;
 //////////////////////////////////////////////////////////////////////////////////////////////////////
                 case "Alta Chofer":
                     new Abm_Chofer.AltaChofer().ShowDialog();
                     break;

                 case "Modificacion Chofer":
                     new Abm_Chofer.ListaChoferes(true).ShowDialog();
                     break;

                 case "Baja Chofer":
                    new Abm_Chofer.ListaChoferes(false).ShowDialog();
                     break;
 //////////////////////////////////////////////////////////////////////////////////////////////////////
                 case "Registro de Viajes":
                     new Registro_Viajes.RegistroViaje(user_id, rol_id).ShowDialog();
                     break;
 //////////////////////////////////////////////////////////////////////////////////////////////////////
                 case "Pago al Chofer":
                     new Rendicion_Viajes.RendicionViajes().ShowDialog();
                     break;
 //////////////////////////////////////////////////////////////////////////////////////////////////////
                 case "Facturacion del Cliente":
                     new Facturacion.FacturacionClientes().ShowDialog();
                     break;
 //////////////////////////////////////////////////////////////////////////////////////////////////////
                 case "Listado Estadistico":
                     new Listado_Estadistico.ListadoEstadistico().ShowDialog();
                     break;
            }
 
            Show();
        }

        private void MenuAcciones_Load(object sender, EventArgs e)
        {

        }
    }
}
