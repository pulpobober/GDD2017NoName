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
using System.Data.SqlClient;

namespace UberFrba.Rendicion_Viajes
{
    public partial class RendicionViajes : Form
    {
        public RendicionViajes()
        {
            InitializeComponent();
        }

        private void btnRendir_Click(object sender, EventArgs e)
        {
            int idchofer = obtainIdChofer(txtChofer.Text);
            int idturno = obtainIdTurno(txtTurno.Text);
            tablaRendicion.DataSource = SQLRendicionViajes.rendir(idchofer, idturno, Convert.ToDouble(txtImporteTotal.Text), selectorFecha.Text);

        }

        public int obtainIdChofer(string chofer)
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

        private int obtainIdTurno(string turno)
        {

            SqlConnection miConexion = new SqlConnection(ConexionSQL.cadenaConexion());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "Select id_turno where descripcion='" + turno + "'";
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
    }
}
