﻿using System;
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

            sqlCommand.ExecuteNonQuery();
 
        } catch(Exception ex){
           //Manejar errores
            throw ex;
        }finally{
            desconectar();
        }
    }
        
        public static DataTable filtrarClientes(Cliente clie) {
            try {
                conectar();

                sqlCommand = new SqlCommand();
           
                sqlCommand.CommandText = "SELECT id_usuario, nombre, apellido, usuario_dni, mail, telefono, direccion, codigo_postal, fecha_nacimiento FROM NONAME.Cliente join NONAME.Usuario on id_cliente = id_usuario WHERE " + (String.IsNullOrEmpty(clie.nombre) ? "1=1" : ("nombre ='" + clie.nombre) + "'") + (clie.dni == 0  ? " And 1=1" : ( " And id_usuario_dni =" + clie.dni.ToString())) + (String.IsNullOrEmpty(clie.apellido) ? " And 1=1" : (" And apellido ='" + clie.apellido.ToString() + "'")) ;
                sqlCommand.CommandType = CommandType.Text; //Esto es opcional porque de base es un texto
                sqlCommand.Connection = miConexion;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableClientes = new DataTable();
                dataTableClientes.Load(sqlReader);
                return dataTableClientes;
          
            }catch(Exception ex){
                //hacer algo con las exepciones
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
                sqlCommand.CommandText = "SELECT id_usuario, nombre, apellido, usuario_dni, mail, telefono, direccion, codigo_postal, fecha_nacimiento FROM NONAME.Usuario join NONAME.Cliente on id_usuario = id_cliente";
                sqlCommand.CommandType = CommandType.Text; //opcional
                sqlCommand.Connection = miConexion;
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableClientes = new DataTable();
                dataTableClientes.Load(sqlReader);
                return dataTableClientes;
            }
            catch (Exception ex)
            {
                //hacer algo con las exepciones
                return null;
                throw ex;
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

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //manejar exepciones
                throw ex;
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
                sqlCommand = new SqlCommand("NONAME.sproc_cliente_baja");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@id_usuario", clie.id_cliente);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //manejar exepciones
                throw ex;
            }
            finally
            {
                desconectar();
            }
        }
    }
}


