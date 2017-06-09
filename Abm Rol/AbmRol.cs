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

        public AbmRol()
        {
            InitializeComponent();
        }

        private void AbmRol_Load(object sender, EventArgs e)
        {
            //Llenar listas funcionalidades
            funcionalidades = SQLRoles.obtenerTodasLasFuncionalidades();
        }

        public DataTable obtenerFuncionalidadesHabilitadas(){
            DataTable funcionalidadesHabilitadas = new DataTable();
            funcionalidadesHabilitadas.Clear();
            funcionalidadesHabilitadas.Columns.Add("id_funcion");


            int i;
            for (i = 0; i <= (checkListFuncionalidades.Items.Count-1); i++)
            {
                if (checkListFuncionalidades.GetItemChecked(i))
                {
                    DataRow newRow = funcionalidadesHabilitadas.NewRow();
                    newRow["id_funcion"] = obtenerIDFuncion(checkListFuncionalidades.Items[i].ToString());
                    funcionalidadesHabilitadas.Rows.Add(newRow);

                }
            }
            return funcionalidadesHabilitadas;
        }

        private int obtenerIDFuncion(String descripcion)
        {
            foreach (DataRow row in funcionalidades.Rows)
            {
                if (row["descripcion"].ToString() == descripcion)
                {
                    return int.Parse(row["id_funcion"].ToString());
                }
            }
            return -1;
        }
    }
}
