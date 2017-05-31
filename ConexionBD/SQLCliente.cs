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

            sqlCommand = new SqlCommand("NONAME.sproc_cliente_altaPRUEBA");
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Connection = miConexion;
 
            sqlCommand.Parameters.AddWithValue("@nombre", clie.nombre);
            sqlCommand.Parameters.AddWithValue("@apellido", clie.apellido);
            sqlCommand.Parameters.AddWithValue("@id_usuario_dni", clie.dni);
            sqlCommand.Parameters.AddWithValue("@mail", clie.mail);
            sqlCommand.Parameters.AddWithValue("@telefono", clie.telefono);
            sqlCommand.Parameters.AddWithValue("@direccion", clie.direccion);
           // sqlCommand.Parameters.AddWithValue("@localidad", clie.localidad);
            sqlCommand.Parameters.AddWithValue("@codigo_postal", clie.codPostal);
            sqlCommand.Parameters.AddWithValue("@fecha_nacimiento", clie.fechaNacimiento);

            sqlCommand.ExecuteNonQuery();
 
        } catch(Exception ex){
           //Manejar errores
            
        }finally{
            desconectar();
        }
    }
        
        public static DataTable filtrarClientes(Cliente clie) {
            try {
                /* lO VIEJO
        * sqlCommand = new SqlCommand("NONAME.filtrar_clientes");
       sqlCommand.CommandType = CommandType.StoredProcedure;
       sqlCommand.Connection = miConexion;
                
                 
       sqlCommand.Parameters.AddWithValue("@nombre", clie.nombre);
       sqlCommand.Parameters.AddWithValue("@apellido", clie.apellido);
       sqlCommand.Parameters.AddWithValue("@id_usuario_dni", clie.dni);
       sqlCommand.ExecuteNonQuery(); */           


                conectar();

                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT nombre, apellido, id_usuario_dni, mail, telefono, direccion, codigo_postal, fecha_nacimiento FROM Cliente join Usuario on id_cliente = id_usuario_dni WHERE nombre=" + clie.nombre
                    + "And apellido =" + clie.apellido + "And id_usuario_dni =" + clie.dni ;
                sqlCommand.CommandType = CommandType.Text; //Esto es opcional porque de base es un texto
                sqlCommand.Connection = miConexion;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableClientes = new DataTable();
                dataTableClientes.Load(sqlReader);
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
                //Falta depurar bien el select

                conectar();
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT nombre, apellido, id_usuario_dni, mail, telefono, direccion, codigo_postal, fecha_nacimiento FROM NONAME.Usuario join NONAME.Cliente on id_usuario_dni = id_cliente";
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
            //    sqlCommand.Parameters.AddWithValue("@localidad", clie.localidad);
                sqlCommand.Parameters.AddWithValue("@codigo_postal", clie.codPostal);
                sqlCommand.Parameters.AddWithValue("@fecha_nacimiento", clie.fechaNacimiento);

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


