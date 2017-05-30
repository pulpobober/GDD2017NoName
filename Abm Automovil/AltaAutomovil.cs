using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Objetos;
using UberFrba.ConexionBD;
using System.Data.SqlClient;
using System.Diagnostics;

namespace UberFrba.Abm_Automovil
{
    public partial class AltaAutomovil : AbmAutomovil
    {
        public AltaAutomovil()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
           System.Diagnostics.Debug.Write("hola");
            ConexionSQL conexion = new ConexionSQL();
            if (verificarDatosAutomovil(txtTurno.Text, txtPatente.Text, txtModelo.Text, selectMarca.Text, txtChofer.Text))
            {   int idmarca= obtainIdMarca(selectMarca.Text);
                  int idturno = 1;//obtainIdTurno(txtTurno.Text);
                var automovil = new { patente_auto = txtPatente.Text, modelo = txtModelo.Text,id_turno = idturno, id_marca = idmarca,rodado="rodado",habilitado="si",licencia="si" };
               Console.WriteLine(ConexionSQL.insertar(automovil, "Auto"));
                /*Automovil auto = new Automovil(txtTurno.Text, txtPatente.Text, txtModelo.Text, selectMarca.Text, txtChofer.Text);
                SQLAutomovil.insertarAutomovil(auto);*/
            }

        }
        private int obtainIdMarca(string marca)
        {
            SqlConnection miConexion = new SqlConnection(ConexionSQL.cadenaConexion());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT idMarca FROM Marca";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = miConexion;

            miConexion.Open();

            reader = cmd.ExecuteReader();

            miConexion.Close();

            return Convert.ToInt32(reader["idMarca"]);
        }
        private int obtainIdTurno(string turno)
        {
            SqlConnection miConexion = new SqlConnection(ConexionSQL.cadenaConexion());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT idTurno FROM Turno";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = miConexion;

            miConexion.Open();

            reader = cmd.ExecuteReader();

            miConexion.Close();

            return Convert.ToInt32(reader["idTurno"]);
        }

        private void btnAlta_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.Write("hola");
            ConexionSQL conexion = new ConexionSQL();
            if (verificarDatosAutomovil(txtTurno.Text, txtPatente.Text, txtModelo.Text, selectMarca.Text, txtChofer.Text))
            {
                int idmarca = obtainIdMarca(selectMarca.Text);
                int idturno = 1;//obtainIdTurno(txtTurno.Text);
                var automovil = new { patente_auto = txtPatente.Text, modelo = txtModelo.Text, id_turno = idturno, id_marca = idmarca, rodado = "rodado", habilitado = "si", licencia = "si" };
                Console.WriteLine(ConexionSQL.insertar(automovil, "Auto"));
                /*Automovil auto = new Automovil(txtTurno.Text, txtPatente.Text, txtModelo.Text, selectMarca.Text, txtChofer.Text);
                SQLAutomovil.insertarAutomovil(auto);*/
            }
        }
    }
}
