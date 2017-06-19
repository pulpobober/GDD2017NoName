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

namespace UberFrba.Abm_Automovil
{
    public partial class AbmAutomovil : Form
    {
        public DataTable tablaChoferes;
        public DataTable tablaTurnos;
        public DataTable tablaMarcas;

        public AbmAutomovil()
        {
            InitializeComponent();
        }

      

        private void AbmAutomovil_Load(object sender, EventArgs e)
        {
            cargarForm();
        }

        public void cargarForm() {
            cmbChofer.Items.Clear();
            tablaChoferes = SQLChofer.obtenerTodosLosChoferes();
            foreach (DataRow row in tablaChoferes.Rows)
            {
                cmbChofer.Items.Add(row["nombre"].ToString() + " " + row["apellido"].ToString());
            }

            cmbTurno.Items.Clear();
            tablaTurnos = SQLTurno.obtenerTodosLosTurnos();
            foreach (DataRow row in tablaTurnos.Rows)
            {
                cmbTurno.Items.Add(row["descripcion"].ToString());
            }

            selectMarca.Items.Clear();
            tablaMarcas = SQLAutomovil.obtenerTodasLasMarcas();
            foreach (DataRow row in tablaMarcas.Rows)
            {
                selectMarca.Items.Add(row["nombre"].ToString());
            }
        }

        public int obtenerIDChofer(string nombreYApellido)
        {
            foreach (DataRow row in tablaChoferes.Rows)
            {
                if (row["nombre"].ToString() + " " + row["apellido"].ToString() == nombreYApellido)
                {
                    return int.Parse(row["id_usuario"].ToString());
                }
            }
            return -1;
        }

        public int obtenerIDTurno(string turno)
        {
            foreach (DataRow row in tablaTurnos.Rows)
            {
                if (row["descripcion"].ToString() == turno)
                {
                    return int.Parse(row["id_turno"].ToString());
                }
            }
            return -1;
        }

        public int obtenerIDMarca(string marca)
        {
            foreach (DataRow row in tablaMarcas.Rows)
            {
                if (row["nombre"].ToString() == marca)
                {
                    return int.Parse(row["id_marca"].ToString());
                }
            }
            return -1;
        }

        public string obtenerNombreYApellidoChofer(int id_chofer)
        {
            foreach (DataRow row in tablaChoferes.Rows)
            {
                if (int.Parse(row["id_usuario"].ToString()) == id_chofer)
                {
                    return row["nombre"].ToString() + " " + row["apellido"].ToString();
                }
            }
            return "";
        }

        public string obtenerNombreTurno(int id_turno)
        {
            foreach (DataRow row in tablaTurnos.Rows)
            {
                if (int.Parse(row["id_turno"].ToString()) == id_turno)
                {
                    return row["descripcion"].ToString();
                }
            }
            return "";
        }

        public string obtenerNombreMarca(int id_marca)
        {
            foreach (DataRow row in tablaMarcas.Rows)
            {
                if (int.Parse(row["id_marca"].ToString()) == id_marca)
                {
                    return row["nombre"].ToString();
                }
            }
            return "";
        }
    }
}
