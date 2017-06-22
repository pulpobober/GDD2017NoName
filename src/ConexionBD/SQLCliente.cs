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

        public static string insertarCliente(Cliente clie) {
        try
        {
            conectar();

            sqlCommand = new SqlCommand("NONAME.sproc_cliente_alta");
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Connection = miConexion;
 
            sqlCommand.Parameters.AddWithValue("@nombre", clie.nombre);
            sqlCommand.Parameters.AddWithValue("@apellido", clie.apellido);
            sqlCommand.Parameters.AddWithValue("@usuario_dni", clie.dni);
            sqlCommand.Parameters.AddWithValue("@mail", clie.mail);
            sqlCommand.Parameters.AddWithValue("@telefono", clie.telefono);
            sqlCommand.Parameters.AddWithValue("@direccion", clie.direccion);
            sqlCommand.Parameters.AddWithValue("@codigo_postal", clie.codPostal);
            sqlCommand.Parameters.AddWithValue("@fecha_nacimiento", clie.fechaNacimiento);

            int response=sqlCommand.ExecuteNonQuery();
            if (response > 0)
            {
                return "Cliente dado de alta correctamente";
            }
            else
            {
                return "Fallo al dar de alta el cliente: " + clie.nombre + " " + clie.apellido;
            }
 
        } catch(Exception ex){
            return "Fallo al dar de alta el cliente: " + clie.nombre + " " + clie.apellido;
            throw ex;
        }finally{
            desconectar();
        }
    }
        
        public static DataTable filtrarClientes(Cliente clie) {
            try {
                conectar();

                sqlCommand = new SqlCommand();
           
                sqlCommand.CommandText = "SELECT id_usuario, nombre, apellido, usuario_dni, mail, telefono, direccion, codigo_postal, fecha_nacimiento FROM NONAME.Cliente join NONAME.Usuario on id_cliente = id_usuario WHERE " + (String.IsNullOrEmpty(clie.nombre) ? "1=1" : ("nombre like '%" + clie.nombre) + "%'") + (clie.dni == 0  ? " And 1=1" : ( " And id_usuario_dni =" + clie.dni.ToString())) + (String.IsNullOrEmpty(clie.apellido) ? " And 1=1" : (" And apellido like '%" + clie.apellido.ToString() + "%'")) ;
                sqlCommand.CommandType = CommandType.Text; //Esto es opcional porque de base es un texto
                sqlCommand.Connection = miConexion;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableClientes = new DataTable();
                dataTableClientes.Load(sqlReader);
                return dataTableClientes;
          
            }catch(Exception ex){
                return null;
                throw ex;
            }finally{
                desconectar();
            }
        }

        public static DataTable obtenerTodosLosClientes()
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT id_usuario, nombre, apellido, usuario_dni, mail, telefono, direccion, codigo_postal, fecha_nacimiento, habilitado FROM NONAME.Usuario join NONAME.Cliente on id_usuario = id_cliente";
                sqlCommand.CommandType = CommandType.Text; //opcional
                sqlCommand.Connection = miConexion;
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableClientes = new DataTable();
                dataTableClientes.Load(sqlReader);
                return dataTableClientes;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                desconectar();
            }
        }

        public static string modificarCliente(Cliente clie)
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand("NONAME.sproc_cliente_modificacion");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;
                sqlCommand.Parameters.AddWithValue("@id_usuario", clie.id_cliente);
                sqlCommand.Parameters.AddWithValue("@nombre", clie.nombre);
                sqlCommand.Parameters.AddWithValue("@apellido", clie.apellido);
                sqlCommand.Parameters.AddWithValue("@usuario_dni", clie.dni);
                sqlCommand.Parameters.AddWithValue("@mail", clie.mail);
                sqlCommand.Parameters.AddWithValue("@telefono", clie.telefono);
                sqlCommand.Parameters.AddWithValue("@direccion", clie.direccion);
                sqlCommand.Parameters.AddWithValue("@codigo_postal", clie.codPostal);
                sqlCommand.Parameters.AddWithValue("@fecha_nacimiento", clie.fechaNacimiento);
                sqlCommand.Parameters.AddWithValue("@habilitado", clie.habilitado);

                int response=sqlCommand.ExecuteNonQuery();
                if (response > 0)
                {
                    return "Cliente modificado correctamente";
                }
                else
                {
                    return "Fallo modificar el cliente: " + clie.nombre + " " + clie.apellido;
                }
            }
            catch (Exception ex)
            {
                return "Fallo modificar el cliente: " + clie.nombre + " " + clie.apellido;
                throw ex;
            }
            finally
            {
                desconectar();
            }
        }

        public static string eliminarCliente(Cliente clie)
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand("NONAME.sproc_cliente_baja");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@id_usuario", clie.id_cliente);

                int response=sqlCommand.ExecuteNonQuery();
                if (response > 0)
                {
                    return "Cliente dado de baja exitosamente";
                }
                else
                {
                    return "Fallo al dar de baja el cliente: " + clie.nombre + " " + clie.apellido;
                }
            }
            catch (Exception ex)
            {
                return "Fallo al dar de baja el cliente: " + clie.nombre + " " + clie.apellido;
                throw ex;
            }
            finally
            {
                desconectar();
            }
        }

        public static DataTable obtenerTodosLosClientesHabilitados()
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT id_usuario, nombre, apellido, usuario_dni, mail, telefono, direccion, codigo_postal, fecha_nacimiento FROM NONAME.Usuario join NONAME.Cliente on id_usuario = id_cliente WHERE habilitado = 1";
                sqlCommand.CommandType = CommandType.Text; //opcional
                sqlCommand.Connection = miConexion;
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableClientes = new DataTable();
                dataTableClientes.Load(sqlReader);
                return dataTableClientes;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                desconectar();
            }
        }
    }
}


