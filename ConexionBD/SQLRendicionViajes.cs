using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.ConexionBD
{
    class SQLRendicionViajes:ConexionSQL
    {
        static SqlCommand sqlCommand = new SqlCommand();
        public static DataTable rendir(int idchofer, int id_turno, double importe_final, string fecha)
        {
            conectar();

            sqlCommand = new SqlCommand("NONAME.rendirViaje");
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Connection = miConexion;

            sqlCommand.Parameters.AddWithValue("@id_chofer", idchofer);
            sqlCommand.Parameters.AddWithValue("@id_turno", id_turno);
            sqlCommand.Parameters.AddWithValue("@importe_final", importe_final);
            sqlCommand.Parameters.AddWithValue("@fecha", fecha);

            SqlDataReader sqlReader = sqlCommand.ExecuteReader();
            DataTable dataTableListado = new DataTable();
            dataTableListado.Load(sqlReader);
            return dataTableListado;
        }



    }
}
