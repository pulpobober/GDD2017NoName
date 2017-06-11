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

namespace UberFrba.Registro_Viajes
{
    public partial class RegistroViaje : Form
    {
        int idCliente;
        DataTable tablaTurnos;
        DataTable tablaChoferes;

        public RegistroViaje()
        {
            InitializeComponent();
        }

        public RegistroViaje(int id_cliente)
        {
            InitializeComponent();
            idCliente = id_cliente;



            tablaTurnos = SQLTurno.obtenerTodosLosTurnos();

            foreach (DataRow row in tablaTurnos.Rows)
            {
                cmbTurnos.Items.Add(row["descripcion"].ToString());
                cmbTurnos.SelectedIndex = 0;
            }

            tablaChoferes = SQLChofer.obtenerTodosLosChoferes();

            foreach (DataRow row in tablaChoferes.Rows)
            {
                cmbChoferes.Items.Add(row["nombre"].ToString() + " " + row["apellido"].ToString());
                cmbChoferes.SelectedIndex = 0;
            }


        }

        private void RegistroViaje_Load(object sender, EventArgs e)
        {

            ////ESTO LO PONGO PARA PROBAR MIENTRAS SE SOLUCIONA EL LOGIN, DESPUES BORRAR

            tablaTurnos = SQLTurno.obtenerTodosLosTurnos();

            foreach (DataRow row in tablaTurnos.Rows)
            {
                cmbTurnos.Items.Add(row["descripcion"].ToString());
                cmbTurnos.SelectedIndex = 0;
            }

            tablaChoferes = SQLChofer.obtenerTodosLosChoferes();

            foreach (DataRow row in tablaChoferes.Rows)
            {
                cmbChoferes.Items.Add(row["nombre"].ToString() + " " + row["apellido"].ToString());
                cmbChoferes.SelectedIndex = 0;
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimeFin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarViaje_Click(object sender, EventArgs e)
        {

        }
    }
}
