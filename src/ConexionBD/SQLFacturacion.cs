using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UberFrba.Properties;

namespace UberFrba.ConexionBD
{
    public class SQLFacturacion : ConexionSQL
    {
        static SqlCommand sqlCommand = new SqlCommand();

        public static DataTable ObtenerFacturacionCliente(int id_cliente)
        {
            DateTime fecha = Settings.Default.fecha_sistema;
            try
            {
                conectar();
                sqlCommand = new SqlCommand("NONAME.sp_detalle_facturacion");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@id_usuario", id_cliente);
                sqlCommand.Parameters.AddWithValue("@fecha", fecha);


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

        public static double rendirElTotal(int id_cliente)
        {
            try
            {
                conectar();

                sqlCommand = new SqlCommand("NONAME.sp_importe_facturacion");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@id_usuario", id_cliente);
                sqlCommand.Parameters.AddWithValue("@fecha", fecha);

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableListado = new DataTable();
                dataTableListado.Load(sqlReader);
                if (dataTableListado.Rows.Count == 0) {
                    return 0;
                }
                else
                {
                    return double.Parse(dataTableListado.Rows[0][0].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                desconectar();
            }
        }

    }
}
