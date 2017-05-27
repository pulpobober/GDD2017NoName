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
            
            sqlCommand = new SqlCommand("insertar_cliente");
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Connection = miConexion;
 
            sqlCommand.Parameters.AddWithValue("@nombre", clie.nombre);
            sqlCommand.Parameters.AddWithValue("@apellido", clie.apellido);
            sqlCommand.Parameters.AddWithValue("@dni", clie.dni);
            sqlCommand.Parameters.AddWithValue("@mail", clie.mail);
            sqlCommand.Parameters.AddWithValue("@telefono", clie.telefono);
            sqlCommand.Parameters.AddWithValue("@direccion", clie.direccion);
            sqlCommand.Parameters.AddWithValue("@piso", clie.piso);
            sqlCommand.Parameters.AddWithValue("@depto", clie.depto);
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
    
        public static void editarCliente(Cliente clie)
        {
        try
        {
            conectar();
            sqlCommand = new SqlCommand("editar_cliente");
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Connection = miConexion;

            sqlCommand.Parameters.AddWithValue("@nombre", clie.nombre);
            sqlCommand.Parameters.AddWithValue("@apellido", clie.apellido);
            sqlCommand.Parameters.AddWithValue("@dni", clie.dni);
            sqlCommand.Parameters.AddWithValue("@mail", clie.mail);
            sqlCommand.Parameters.AddWithValue("@telefono", clie.telefono);
            sqlCommand.Parameters.AddWithValue("@direccion", clie.direccion);
            sqlCommand.Parameters.AddWithValue("@piso", clie.piso);
            sqlCommand.Parameters.AddWithValue("@depto", clie.depto);
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

            /*
            public DataTable obtenerCliente() {
            try {
                conectado();
                cmd = new SqlCommand("obtener_cliente");
                cmd.CommandType = CommandType.StoredProcedure;
 
                cmd.Connection = cnn;
 
                if( cmd.ExecuteNonQuery ){
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }else{
                    return null;
                }
            }catch(Exception ex){
                MsgBox(ex.Message);
                return null;
            }finally{
                desconectado();
            }
        }  */

        }
    }


