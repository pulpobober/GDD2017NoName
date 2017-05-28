using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using UberFrba.Objetos;

namespace UberFrba.ConexionBD
{
    public class SQLCliente:ConexionSQL
    {
        static SqlCommand sqlCommand = new SqlCommand();
        

        public static void insertarCliente(Cliente clie) {
        try
        {
            conectar();
            
            sqlCommand = new SqlCommand("NONAME.alta_cliente");
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Connection = miConexion;
 
            sqlCommand.Parameters.AddWithValue("@nombre", clie.nombre);
            sqlCommand.Parameters.AddWithValue("@apellido", clie.apellido);
            sqlCommand.Parameters.AddWithValue("@id_usuario_dni", clie.dni);
            sqlCommand.Parameters.AddWithValue("@mail", clie.mail);
            sqlCommand.Parameters.AddWithValue("@telefono", clie.telefono);
            sqlCommand.Parameters.AddWithValue("@direccion", clie.direccion);
            sqlCommand.Parameters.AddWithValue("@localidad", clie.localidad);
            sqlCommand.Parameters.AddWithValue("@codPostal", clie.codPostal);
            sqlCommand.Parameters.AddWithValue("@fechaNacimiento", clie.fechaNacimiento);

            sqlCommand.ExecuteNonQuery();
 
        } catch(Exception ex){
           //Manejar errores
            
        }finally{
            desconectar();
        }
    }
        
        public static DataTable filtrarClientes(Cliente clie) {
            try {
                conectar();
                sqlCommand = new SqlCommand("NONAME.filtrar_clientes");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@nombre", clie.nombre);
                sqlCommand.Parameters.AddWithValue("@apellido", clie.apellido);
                sqlCommand.Parameters.AddWithValue("@id_usuario_dni", clie.dni);
                sqlCommand.ExecuteNonQuery();
          
                DataTable dataTableClientes = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataTableClientes);
                return dataTableClientes;
               
            }catch(Exception ex){
                //hacer algo con las exepciones
             
                return null;
            }finally{
                desconectar();
            }
        }

        public static DataTable obtenerTodosLosClientes()
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand("NONAME.obtener_todos_los_clientes");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.ExecuteNonQuery();

                DataTable dataTableClientes = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataTableClientes);
                return dataTableClientes;

            }
            catch (Exception ex)
            {
                //hacer algo con las exepciones
                return null;
            }
            finally
            {
                desconectar();
            }
        }

        public static void modificarCliente(Cliente clie)
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand("NONAME.modificar_cliente");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@nombre", clie.nombre);
                sqlCommand.Parameters.AddWithValue("@apellido", clie.apellido);
                sqlCommand.Parameters.AddWithValue("@id_usuario_dni", clie.dni);
                sqlCommand.Parameters.AddWithValue("@mail", clie.mail);
                sqlCommand.Parameters.AddWithValue("@telefono", clie.telefono);
                sqlCommand.Parameters.AddWithValue("@direccion", clie.direccion);
                sqlCommand.Parameters.AddWithValue("@localidad", clie.localidad);
                sqlCommand.Parameters.AddWithValue("@codPostal", clie.codPostal);
                sqlCommand.Parameters.AddWithValue("@fechaNacimiento", clie.fechaNacimiento);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //manejar exepciones
            }
            finally
            {
                desconectar();
            }
        }

        public static void eliminarCliente(Cliente clie)
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand("NONAME.baja_cliente");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@id_usuario_dni", clie.dni);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //manejar exepciones
            }
            finally
            {
                desconectar();
            }
        }
    }
}


