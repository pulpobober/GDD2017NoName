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


namespace UberFrba.Abm_Automovil
{
    public partial class ModificacionAutomovil : AbmAutomovil
    {
        int idautomovil;
        public ModificacionAutomovil(Automovil auto)
        {
            InitializeComponent();
            idautomovil = auto.idautomovil;
            txtPatente.Text = auto.patente;
            txtModelo.Text = auto.modelo;
            selectMarca.Text = SQLAutomovil.obtainMarca(auto.idmarca);
            txtChofer.Text = SQLAutomovil.obtainChofer(auto.idchofer);
            selectHabilitado.Text = SQLAutomovil.obtainHabilitado(idautomovil);
           
        }
        private int obtainIdMarca(string marca)
        {
            int length_substring = marca.IndexOf("]");
            int idMarca = Convert.ToInt32(marca.Substring(1, length_substring - 1));
            return idMarca;
        }
        private int obtainIdTurno(string turno)
        {
            SqlConnection miConexion = new SqlConnection(ConexionSQL.cadenaConexion());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT id_turno FROM Noname.Turno where descripcion='" + turno + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = miConexion;

            miConexion.Open();

            reader = cmd.ExecuteReader();

            // miConexion.Close();

            while (reader.Read())
            {
                return Convert.ToInt32(reader["id_turno"]);
            }
            return 0;
        }
        private int obtainIdChofer(string chofer)
        {
            chofer = chofer.Replace(' ', '_');
            int indexof_whitspace = chofer.IndexOf("_");
            string nombre = chofer.Substring(0, indexof_whitspace);
            string apellido = chofer.Substring(indexof_whitspace + 1);

            SqlConnection miConexion = new SqlConnection(ConexionSQL.cadenaConexion());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "Select id_usuario from NONAME.Usuario inner join NONAME.Chofer on id_usuario=id_chofer where nombre='" + nombre + "' and apellido='" + apellido + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = miConexion;

            miConexion.Open();

            reader = cmd.ExecuteReader();

            // miConexion.Close();

            while (reader.Read())
            {
                return Convert.ToInt32(reader["id_usuario"]);
            }
            return 0;

        }
        private int obtainIdAuto(int idchofer)
        {
            SqlConnection miConexion = new SqlConnection(ConexionSQL.cadenaConexion());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "select id_auto from NONAME.Auto_Chofer where id_chofer=" + idchofer + "group by id_auto";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = miConexion;

            miConexion.Open();

            reader = cmd.ExecuteReader();

            // miConexion.Close();

            while (reader.Read())
            {
                return Convert.ToInt32(reader["id_auto"]);
            }
            return 0;

        }
        private void btnModificacion_Click(object sender, EventArgs e)
        {
            if(verificarDatosAutomovil(txtTurno.Text,txtPatente.Text,txtModelo.Text, selectMarca.Text, txtChofer.Text)){
                int idmarca = obtainIdMarca(selectMarca.Text);
                int idturno = obtainIdTurno(txtTurno.Text);
                int idchofer = obtainIdChofer(txtChofer.Text);
                int idautomovil = obtainIdAuto(idchofer);
                Automovil auto = new Automovil(idautomovil,idturno, txtPatente.Text, txtModelo.Text, idmarca, idchofer, txtRodado.Text, txtLicencia.Text, 1);
                string response = SQLAutomovil.modificarAutomovil(auto);
                MessageBox.Show(response);
            }
        }


    }
}
