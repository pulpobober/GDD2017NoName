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
                sqlCommand.Parameters.AddWithValue("@fecha", fecha.Date);


                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableListado = new DataTable();
                dataTableListado.Load(sqlReader);
                return dataTableListado;
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

        public static DataTable rendirElTotal(int id_cliente)
        {
            DateTime fecha = Settings.Default.fecha_sistema;
            try
            {
                conectar();

                sqlCommand = new SqlCommand("NONAME.sp_importe_facturacion");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@id_usuario", id_cliente);
                sqlCommand.Parameters.AddWithValue("@fecha", fecha.Date);

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableListado = new DataTable();
                dataTableListado.Load(sqlReader);
                return dataTableListado;
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


        public static void facturar(int id_factura)
        {
            DateTime fecha = Settings.Default.fecha_sistema;
            try
            {
                conectar();

                sqlCommand = new SqlCommand("NONAME.sp_confirmacion_facturacion");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@nro_factura", id_factura);
                sqlCommand.Parameters.AddWithValue("@fecha", fecha.Date);

                sqlCommand.ExecuteReader();
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
