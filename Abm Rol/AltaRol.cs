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
            Dictionary<int, Boolean> diccionarioFunciones = new Dictionary<int, bool>();
            foreach (String key in checkListFuncionalidades.Items)
            {
                DataRow[] row = funcionalidades.Select("Nombre = '" + key + "'");
                diccionarioFunciones.Add(int.Parse(row[0]["Funcionabilidad_id"].ToString()), checkListFuncionalidades.GetItemChecked(checkListFuncionalidades.FindStringExact(key)));
            }

            Rol unRol = new Rol(txtNombreRol.Text, cmbEstado.SelectedItem.ToString() == "Habilitado" ? false : true, diccionarioFunciones);
            SQLRoles.insertarRol(unRol);
        }
    }
}
