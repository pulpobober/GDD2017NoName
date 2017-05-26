﻿using System;
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
                /*
            case "Alta Rol":
                new Abm_Rol.AltaRol().ShowDialog();
                break;

            case "Baja Rol":
                new Abm_Rol.ListaRolBaja(Accion.Baja).ShowDialog();
                break;

            case "Modificacion Rol":
                new Abm_Rol.ListaRolModificacion(Accion.Modificacion).ShowDialog();
                break;*/
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                case "Alta Cliente":
                    new Abm_Cliente.AltaCliente().ShowDialog();
                    break;

                case "Modificacion Cliente":
                    new Abm_Cliente.ListaClientesModificacion().ShowDialog();
                    break;

                case "Baja Cliente":
                    new Abm_Cliente.ListaClientesBaja().ShowDialog();
                    break;
//////////////////////////////////////////////////////////////////////////////////////////////////////
                /* case "Alta Automovil":
                     new Abm_Automovil.AltaAutomovil().ShowDialog();
                     break;

                 case "Modificacion Automovil":
                     new Abm_Automovil.ListaAutomovilModificacion().ShowDialog();
                     break;

                 case "Baja Automovil":
                     new Abm_Automovil.ListaAutomovilBaja().ShowDialog();
                     break;
 //////////////////////////////////////////////////////////////////////////////////////////////////////
                 case "Alta Turno":
                     new Abm_Turno.AltaTurno().ShowDialog();
                     break;

                 case "Modificacion Turno":
                     new Abm_Turno.ListaTurnoModificacion().ShowDialog();
                     break;

                 case "Baja Turno":
                     new Abm_Turno.ListaTurnoBaja().ShowDialog();
                     break;
 //////////////////////////////////////////////////////////////////////////////////////////////////////
                 case "Alta Chofer":
                     new Abm_Chofer.AltaChofer().ShowDialog();
                     break;

                 case "Modificacion Chofer":
                     new Abm_Chofer.ListaChoferModificacion().ShowDialog();
                     break;

                 case "Baja Chofer":
                     new Abm_Chofer.ListaChoferBaja().ShowDialog();
                     break;
 //////////////////////////////////////////////////////////////////////////////////////////////////////
                 case "Registro Viaje":
                     new Registrar_Viaje..ShowDialog();
                     break;
 //////////////////////////////////////////////////////////////////////////////////////////////////////
                 case "Rendicion Viaje":
                     new Rendicion_Viaje..ShowDialog();
                     break;
 //////////////////////////////////////////////////////////////////////////////////////////////////////
                 case "Facturacion Cliente":
                     new Facturacion_Cliente..ShowDialog();
                     break;
 //////////////////////////////////////////////////////////////////////////////////////////////////////
                 case "Listado Estadistico":
                     new Listados.ListadoEstadistico().ShowDialog();
                     break;*/
            }
 
            Show();
        }
    }
}
