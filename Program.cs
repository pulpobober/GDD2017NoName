﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;

namespace UberFrba
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Listado_Estadistico.ListadoEstadistico());
           //  Application.Run(new Login.Login());
             Application.Run(new Menu_Acciones.MenuAcciones());
            //Application.Run(new Abm_Rol.ListadoRoles());


        }
    }
}
