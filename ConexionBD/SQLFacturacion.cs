using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.ConexionBD
{
    public class SQLFacturacion : ConexionSQL
    {
        static SqlCommand sqlCommand = new SqlCommand();

        public static DataTable ObtenerFacturacionCliente(int id_cliente)
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand("NONAME.facturacion_cliente");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@id_cliente", id_cliente);

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableListado = new DataTable();
                dataTableListado.Load(sqlReader);
                return dataTableListado;
            }
            catch (Exception ex)
            {
                //Manejar errores
                throw ex;
            }
            finally
            {
                desconectar();
            }
        }
    }
}
